Imports Org.BouncyCastle.Utilities

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
        Dim colRaces As Collection

        idTeams = DBBroker.GetBroker().Read("SELECT Team FROM Contracts WHERE Season = " & se.SeasonID & ";")
        For Each aux In idTeams
            auxTeam = New Team(Integer.Parse(aux(1).ToString))
            auxTeam.ReadTeam()
            colTeams.Add(auxTeam)
        Next

        If colTeams.Count > 0 Then
            se.ListContracts = colTeams
        End If

        colGPs = DBBroker.GetBroker().Read("SELECT * FROM GPs WHERE GPID IN (SELECT GP FROM Calendar WHERE Season = " & se.SeasonID & ");")
        If colGPs.Count > 1 Then
            se.ListGPs = colGPs
        End If

        colRaces = DBBroker.GetBroker().Read("SELECT * FROM Races WHERE Season = " & se.SeasonID & ";")

        If colRaces.Count > 1 Then
            For Each raceData As Collection In colRaces

                Dim race As New Race(se.SeasonID, Integer.Parse(raceData(2).ToString), Integer.Parse(raceData(3).ToString()))
                race.ReadRace()
                se.ListRaces.Add(race)
            Next
        End If


    End Sub

    'To insert the season with random data ----------------------------------------
    Public Sub Insert(ByRef se As Season, ByVal numTeams As Integer, ByVal numGPs As Integer)
        ' Obtaining a list of all the teams in the database
        Dim aux As New Collection

        'Variables for asigning teams, contracts and gps ------------------------
        Dim colTeams As Collection
        Dim auxTeam As New Team

        Dim colGPs As Collection
        Dim auxGP As GP

        Dim colDrivers As Collection
        Dim auxDriver As Collection
        Dim auxContract As New Contract

        'Variables for creating the races and its results------------------------
        Dim auxRace As New Race
        Dim ColDriversToRace As New Collection
        Dim ColGPsToRace As New Collection
        Dim numPositionsPerRace As Integer = 20
        Dim numGPsOnSeason As New Integer

        'Variables for random operations ------------------------
        Dim i As Integer
        Dim num As Integer
        Dim rnd As New Random

        'Retrieval of information from the database ------------------------
        colTeams = DBBroker.GetBroker().Read("SELECT * FROM Teams ORDER BY TeamID;")
        colDrivers = DBBroker.GetBroker().Read("SELECT * FROM Drivers ORDER BY DriverID;")
        colGPs = DBBroker.GetBroker().Read("SELECT * FROM GPs ORDER BY GPID;")



        'Choosing the random teams --------------------------------
        'Checking if there are enough teams in the database
        If numTeams > colTeams.Count Then
            MessageBox.Show("There are not enough teams in the Database to perform the creation of the season.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For i = 1 To numTeams
            Try
                rnd = New Random(rnd.Next(1, colTeams.Count + 1))
                num = rnd.Next(1, colTeams.Count + 1)
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
            rnd = New Random(rnd.Next(1, colDrivers.Count + 1))
            num = rnd.Next(1, colDrivers.Count + 1)

            auxDriver = CType(colDrivers.Item(num), Collection)
            auxContract.Driver1 = Integer.Parse(auxDriver(1).ToString)
            colDrivers.Remove(num)



            'Choosing the second driver for the contract
            rnd = New Random(rnd.Next(1, colDrivers.Count + 1))
            num = rnd.Next(1, colDrivers.Count + 1)

            auxDriver = CType(colDrivers.Item(num), Collection)
            auxContract.Driver2 = Integer.Parse(auxDriver(1).ToString)
            colDrivers.Remove(num)

            auxTeam.Contracts.Add(auxContract)
            ColDriversToRace.Add(auxContract.Driver1)
            ColDriversToRace.Add(auxContract.Driver2)

            se.ListContracts.Add(auxTeam)

        Next


        'Choosing the random GPs --------------------------------

        'Checking if there are enough GPs in the database
        If numGPs > colGPs.Count Then
            MessageBox.Show("There are not enough GPs in the Database to perform the creation of the season.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For i = 1 To numGPs
            num = rnd.Next(1, colGPs.Count + 1)
            aux = CType(colGPs.Item(num), Collection)
            auxGP = New GP(Integer.Parse(aux(1).ToString))
            auxGP.ReadGP()
            se.ListGPs.Add(auxGP)
            colGPs.Remove(num)
        Next

        'Choosing the random races --------------------------------

        ColGPsToRace = se.ListGPs
        numGPsOnSeason = ColGPsToRace.Count
        Dim DriverIDToAdd As Integer
        Dim pointsForDriver As Integer
        Dim AuxListDrivers As New Collection


        'Check that there are enough drivers to place all the positions, if not, adjust the number of positions to the number of drivers
        If numPositionsPerRace > ColDriversToRace.Count Then
            numPositionsPerRace = ColDriversToRace.Count
        End If




        For k = 1 To ColDriversToRace.Count
            AuxListDrivers.Add(ColDriversToRace.Item(k))
        Next

        For j = 1 To numGPsOnSeason
            auxGP = CType(ColGPsToRace.Item(j), GP)



            For i = 1 To numPositionsPerRace

                num = rnd.Next(1, AuxListDrivers.Count + 1)

                DriverIDToAdd = Integer.Parse(AuxListDrivers.Item(num).ToString)
                If i <= 6 Then
                    Select Case i
                        Case 1
                            pointsForDriver = 10
                        Case 2
                            pointsForDriver = 6
                        Case 3
                            pointsForDriver = 4
                        Case 4
                            pointsForDriver = 3
                        Case 5
                            pointsForDriver = 2
                        Case 6
                            pointsForDriver = 1
                    End Select
                Else
                    pointsForDriver = 0
                End If
                auxRace = New Race(se.SeasonID, auxGP.GPID, DriverIDToAdd)
                auxRace.Position = i
                auxRace.Points = pointsForDriver

                se.ListRaces.Add(auxRace)

                AuxListDrivers.Remove(num)
            Next
            For k = 1 To ColDriversToRace.Count
                AuxListDrivers.Add(ColDriversToRace.Item(k))
            Next
        Next
        'Inserting the season into the database ------------------------

        Dim teamToAdd As New Team
        Dim contractToAdd As New Contract
        For i = 1 To se.ListContracts.Count
            teamToAdd = CType(se.ListContracts.Item(i), Team)
            contractToAdd = CType(teamToAdd.Contracts.Item(teamToAdd.Contracts.Count - 1), Contract)
            'Call to the method of contract to insert the contract to the database
            contractToAdd.InsertContract()
        Next


        'Inserting the data from the GPs of the season in the calendar ------------------------
        Dim GPToAdd As GP
        For i = 1 To se.ListGPs.Count
            GPToAdd = CType(se.ListGPs.Item(i), GP)
            'Insert the gp of the seasoin in the calendar
            DBBroker.GetBroker().Change("INSERT INTO Calendar (Season, GP, `Order`) VALUES (" & se.SeasonID & ", " & GPToAdd.GPID & ", " & i & ");")
        Next
        Dim raceToAdd As Race
        'Inserting the data for races
        For i = 1 To se.ListRaces.Count
            raceToAdd = CType(se.ListRaces.Item(i), Race)
            raceToAdd.InsertRace()
        Next
    End Sub

    Public Sub Delete(ByRef se As Season)

    End Sub

End Class
