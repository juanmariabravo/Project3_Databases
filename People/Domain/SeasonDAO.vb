Public Class SeasonDAO

    Public ReadOnly Property Seasons As Collection

    Public Sub New()
        Me.Seasons = New Collection
    End Sub

    Public Sub ReadAll()
        Dim se As Season
        Dim col, aux As Collection

        col = DBBroker.GetBroker().Read("SELECT DISTINCT Season FROM Calendar ORDER BY Season;")
        If col.Count > 0 Then
            For Each aux In col
                se = New Season(Integer.Parse(aux(1).ToString))
                se.ReadSeason()
                Me.Seasons.Add(se)
            Next
        End If
    End Sub

    Public Sub Read(ByRef se As Season)
        Dim colTeams As New Collection
        Dim idTeams As Collection
        Dim aux As Collection
        Dim auxTeam As Team
        Dim colGPs As Collection

        idTeams = DBBroker.GetBroker().Read("SELECT Team FROM Contracts WHERE Season = " & se.SeasonID & ";")
        For Each aux In idTeams
            auxTeam = New Team(Integer.Parse(aux(1).ToString))
            auxTeam.ReadTeam()
            colTeams.Add(auxTeam)
        Next

        If colTeams.Count > 0 Then
            se.ListTeams = colTeams
        End If


        'Now get the GPs for the season
        colGPs = DBBroker.GetBroker().Read("SELECT * FROM GPs WHERE GPID IN (SELECT GP FROM Calendar WHERE Season = " & se.SeasonID & ");")
        If colGPs.Count > 0 Then
            se.ListGPs = colGPs
        End If

    End Sub

    Public Sub Insert(ByRef se As Season, ByVal numTeams As Integer, ByVal numGPs As Integer)
        ' Obtaining a list of all the teams in the database
        Dim aux As New Collection

        'Variables for asigning teams, contracts and gps
        Dim colTeams As Collection
        Dim auxTeam As New Team

        Dim colGPs As Collection
        Dim auxGP As GP

        Dim colDrivers As Collection
        Dim auxDriver As New Collection
        Dim auxContract As New Contract


        'Variables for random operations
        Dim i As Integer
        Dim num As Integer
        Dim rnd As New Random

        'Retrieval of information from the database ------------------------

        colTeams = DBBroker.GetBroker().Read("SELECT * FROM Teams ORDER BY TeamID;")
        colDrivers = DBBroker.GetBroker().Read("SELECT * FROM Drivers WHERE DriverID NOT IN (SELECT Driver1 FROM Contracts WHERE Season = " & se.SeasonID & " UNION SELECT Driver2 FROM Contracts WHERE Season = " & se.SeasonID & ");")
        colGPs = DBBroker.GetBroker().Read("SELECT * FROM GPs ORDER BY GPID;")



        'Choosing the random teams --------------------------------

        For i = 1 To numTeams
            Try
                'Choosing a random team
                num = rnd.Next(1, colTeams.Count + 1)

                'Getting the random team's ID
                aux = CType(colTeams.Item(num), Collection)
                colTeams.Remove(num)

            Catch ex As Exception
                MessageBox.Show("Error while gettting random number of teams: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                auxTeam = New Team(Integer.Parse(aux(1).ToString))
                auxTeam.ReadTeam()

                auxContract = New Contract(auxTeam.TeamID, se.SeasonID)
            Catch ex As Exception
                MessageBox.Show("Error while creating the teams and contracts for first driver: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Choosing the first driver for the contract
            num = rnd.Next(1, colDrivers.Count + 1)

            auxDriver = CType(colDrivers.Item(num), Collection)
            auxContract.Driver1 = Integer.Parse(auxDriver(1).ToString)
            colDrivers.Remove(num)


            'Choosing the second driver for the contract
            num = rnd.Next(1, colDrivers.Count + 1)

            auxDriver = CType(colDrivers.Item(num), Collection)
            auxContract.Driver2 = Integer.Parse(auxDriver(1).ToString)
            colDrivers.Remove(num)

            auxTeam.Contracts.Add(auxContract)

            se.ListTeams.Add(auxTeam)

        Next



        'Choosing the random GPs --------------------------------

        Try
            For i = 1 To numGPs
                num = rnd.Next(1, colGPs.Count + 1)
                aux = CType(colGPs.Item(num), Collection)
                auxGP = New GP(Integer.Parse(aux(1).ToString))
                auxGP.ReadGP()
                se.ListGPs.Add(auxGP)
                colGPs.Remove(num)
            Next

        Catch ex As Exception
            MessageBox.Show("Error while choosing the random GPs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        'Inserting the season into the database ------------------------

        Dim teamToAdd As New Team
        Dim contractToAdd As New Contract
        For i = 1 To se.ListTeams.Count
            teamToAdd = CType(se.ListTeams.Item(i), Team)
            contractToAdd = CType(teamToAdd.Contracts.Item(0), Contract)
            DBBroker.GetBroker().Change("INSERT INTO Contracts (Team, Season, Driver1, Driver2) VALUES (" & teamToAdd.TeamID & ", " & se.SeasonID & ", " & contractToAdd.Driver1 & ", " & contractToAdd.Driver2 & ");")
        Next


        'Inserting the data from the GPs of the season in the calendar ------------------------
        Dim GPToAdd As GP
        For i = 1 To se.ListGPs.Count
            GPToAdd = CType(se.ListGPs.Item(i), GP)
            DBBroker.GetBroker().Change("INSERT INTO Calendar (Season, GP, `Order`) VALUES (" & se.SeasonID & ", " & GPToAdd.GPID & ", " & i & ");")
        Next
    End Sub
End Class
