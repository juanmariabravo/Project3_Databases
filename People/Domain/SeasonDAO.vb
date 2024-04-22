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
        Dim colRaces As Collection ' Agrega una colección para almacenar las carreras

        ' Obtener los equipos asociados a la temporada
        idTeams = DBBroker.GetBroker().Read("SELECT Team FROM Contracts WHERE Season = " & se.SeasonID & ";")
        For Each aux In idTeams
            auxTeam = New Team(Integer.Parse(aux(1).ToString))
            auxTeam.ReadTeam()
            colTeams.Add(auxTeam)
        Next

        If colTeams.Count > 0 Then
            se.ListTeams = colTeams
        End If

        ' Obtener los GPs asociados a la temporada
        colGPs = DBBroker.GetBroker().Read("SELECT * FROM GPs WHERE GPID IN (SELECT GP FROM Calendar WHERE Season = " & se.SeasonID & ");")
        If colGPs.Count > 0 Then
            se.ListGPs = colGPs
        End If

        ' Obtener las carreras asociadas a la temporada
        colRaces = DBBroker.GetBroker().Read("SELECT * FROM Races WHERE Season = " & se.SeasonID & ";")
        If colRaces.Count > 1 Then
            For Each raceData As Collection In colRaces
                Dim race As New Race(se.SeasonID)
                race.GP = Integer.Parse(raceData("GP").ToString())
                race.Position = Byte.Parse(raceData("Position").ToString())
                race.Points = Byte.Parse(raceData("Points").ToString())
                ' Agregar la carrera a la lista de carreras de la temporada
                se.ListRaces.Add(race)
            Next
        End If
    End Sub


    Public Sub Insert(ByRef se As Season, ByVal numTeams As Integer, ByVal numGPs As Integer)
        'Obtener una lista de todos los equipos de la base de datos
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
        Dim num2 As Integer
        Dim rnd As New Random
        Dim randomizer As New Random

        'Retrieval of information from the database ------------------------

        colTeams = DBBroker.GetBroker().Read("SELECT * FROM Teams ORDER BY TeamID;")
        colDrivers = DBBroker.GetBroker().Read("SELECT * FROM Drivers WHERE DriverID ;")
        colGPs = DBBroker.GetBroker().Read("SELECT * FROM GPs ORDER BY GPID;")



        'Choosing the random teams --------------------------------

        For i = 1 To numTeams
            Try

                rnd = New Random(rnd.Next(1, colTeams.Count + 1))
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

            randomizer = New Random(randomizer.Next(1, colDrivers.Count + 1))
            'Choosing the first driver for the contract
            num2 = randomizer.Next(1, colDrivers.Count + 1)

            auxDriver = CType(colDrivers.Item(num2), Collection)
            auxContract.Driver1 = Integer.Parse(auxDriver(1).ToString)
            colDrivers.Remove(num2)


            'Choosing the second driver for the contract

            rnd = New Random(rnd.Next(1, colDrivers.Count + 1))
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
                'Iterar por la lista de colDrivers
                'For Each auxDriver In colDrivers
                ' New Race <- (se.SeasonID, auxGP.GPID, auxDriver(1), Posicion aleatoria, puntos asociados (metodo en race))
                ' se.ListRaces.Add(Race)
                'Next
                se.ListGPs.Add(auxGP)
                    colGPs.Remove(num)

                Next

        Catch ex As Exception
            MessageBox.Show("Error while choosing the random GPs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'choosing positions for the driver in the race------------------------
        Try
            Dim driversForPosition As New List(Of Driver)()
            For Each race As Race In se.ListRaces
                Dim numAvailableDrivers As Integer = colDrivers.Count

                For position As Byte = 1 To race.Position

                    Dim randomIndex As Integer = rnd.Next(1, (numAvailableDrivers + 1))
                    Dim selectedDriver As Collection = CType(colDrivers.Item(randomIndex), Collection)
                    Dim driver As New Driver(Integer.Parse(selectedDriver(1).ToString()))
                    driver.ReadDriver()
                    driversForPosition.Add(driver)

                    ' Deleting the driver for the index
                    colDrivers.Remove(randomIndex)

                    'decrementing available drivers
                    numAvailableDrivers -= 1
                Next
            Next
        Catch ex As Exception
            MessageBox.Show("No hay suficientes conductores disponibles para todas las posiciones en la carrera '" & "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        'Inserting the data for races
        For i = 1 To se.ListRaces.Count
            Dim raceToAdd As Race = CType(se.ListRaces.Item(i), Race)
            DBBroker.GetBroker().Change($"INSERT INTO Races (Season, GP, Position, Points) VALUES ({se.SeasonID}, {raceToAdd.GP},{raceToAdd.Driver}, '{raceToAdd.Position}', {raceToAdd.Points});")

        Next
    End Sub
End Class
