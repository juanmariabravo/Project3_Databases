Imports Org.BouncyCastle.Utilities

Public Class SeasonDAO

    Public ReadOnly Property Seasons As Collection

    Public Sub New()
        Me.Seasons = New Collection
    End Sub

    Public Sub ReadAll()
        Dim se As Season
        Dim colSeasons, auxSeason As Collection

        colSeasons = DBBroker.GetBroker().Read("SELECT DISTINCT Season FROM Calendar ORDER BY Season;")
        If colSeasons.Count > 0 Then
            For Each auxSeason In colSeasons
                se = New Season(Integer.Parse(auxSeason(1).ToString))
                se.ReadSeason()

                Me.Seasons.Add(se)
            Next
        End If
    End Sub

    Public Sub Read(ByRef se As Season)
        Dim colContractsID As Collection
        Dim colGPsID As Collection

        Dim auxContractTeamID As Collection
        Dim auxGPID As Collection
        Dim auxRaceData As Collection
        Dim colRaces As Collection


        colContractsID = DBBroker.GetBroker().Read("SELECT Team FROM Contracts WHERE Season = " & se.SeasonID & ";")
        For Each auxContractTeamID In colContractsID
            'Adding the teamID to the collection, that is, the first element in the auxiliar collection
            se.ListContractsTeamID.Add(Integer.Parse(auxContractTeamID(1).ToString()))
        Next


        colGPsID = DBBroker.GetBroker().Read("SELECT GP FROM Calendar WHERE Season = " & se.SeasonID & ";")
        If colGPsID.Count > 0 Then
            'Adding all of the GPs ID to the collection
            For Each auxGPID In colGPsID
                se.ListGPsID.Add(Integer.Parse(auxGPID(1).ToString()))
            Next
        End If


        'Only take the GPID and the DriverID that participates in this season
        colRaces = DBBroker.GetBroker().Read("SELECT * FROM Races WHERE Season = " & se.SeasonID & ";")
        If colRaces.Count > 0 Then
            For Each auxRaceData In colRaces
                Dim auxRace As New Collection 'Create a new instance since if not it will take the same values over and over again
                auxRace.Add(se.SeasonID) '(1) the season
                auxRace.Add(Integer.Parse(auxRaceData(2).ToString)) '(2) the gp it is participating 
                auxRace.Add(Integer.Parse(auxRaceData(3).ToString())) '(3) the driver that is participating
                se.ListRaces.Add(auxRace)
            Next
        End If


    End Sub

    'To insert the season with random data ----------------------------------------
    Public Sub Insert(ByRef se As Season, ByVal numTeams As Integer, ByVal numGPs As Integer)
        ' Obtaining a list of all the teams in the database
        Dim auxTeamID As New Integer
        Dim auxDriverID As Integer
        Dim auxGPID As Integer

        'Collections to store the id of teams, contracts and gps ------------------------
        Dim colTeams As New Collection
        Dim colGPs As New Collection
        Dim colDrivers As New Collection


        'Variables for creating the races and its results------------------------
        Dim auxRace As Race
        Dim auxContract As New Contract

        Dim numGPsOnSeason As Integer

        'Variables for random operations ------------------------
        Dim i As Integer
        Dim num As Integer
        Dim rnd As New Random

        'Variables for creating the races and its results ------------------------
        Dim DriverIDToAdd As Integer
        Dim pointsForDriver As Integer
        Dim AuxListDrivers As New Collection

        Dim ColDriversToRace As New Collection
        Dim ColGPsToRace As New Collection
        Dim numPositionsPerRace As Integer = 20


        'Retrieval of information from the database ------------------------
        colTeams = DBBroker.GetBroker().Read("SELECT TeamID FROM Teams ORDER BY TeamID;")
        colDrivers = DBBroker.GetBroker().Read("SELECT DriverID FROM Drivers ORDER BY DriverID;")
        colGPs = DBBroker.GetBroker().Read("SELECT GPID FROM GPs ORDER BY GPID;")

        MessageBox.Show("The number of elements in the lists are: " & colTeams.Count & " teams, " & colDrivers.Count & " drivers and " & colGPs.Count & " GPs.")

        'Choosing the random teams --------------------------------
        'Checking if there are enough teams in the database
        If numTeams > colTeams.Count Then
            MessageBox.Show("There are not enough teams in the Database to perform the creation of the season.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For i = 1 To numTeams

            rnd = New Random(rnd.Next(1, colTeams.Count + 1))
                num = rnd.Next(1, colTeams.Count + 1)

                auxTeamID = Integer.Parse(colTeams.Item(num).ToString)
                colTeams.Remove(num)




            auxContract = New Contract(auxTeamID, se.SeasonID)



            'Choosing the first driver for the contract
            rnd = New Random(rnd.Next(1, colDrivers.Count))
            num = rnd.Next(1, colDrivers.Count)

            auxDriverID = Integer.Parse(colTeams.Item(num).ToString)
            auxContract.Driver1 = auxDriverID
            colDrivers.Remove(num)



            'Choosing the second driver for the contract
            rnd = New Random(rnd.Next(1, colDrivers.Count + 1))
            num = rnd.Next(1, colDrivers.Count + 1)

            auxDriverID = Integer.Parse(colTeams.Item(num).ToString)
            auxContract.Driver2 = auxDriverID
            colDrivers.Remove(num)

            auxContract.InsertContract()

            ColDriversToRace.Add(auxContract.Driver1)
            ColDriversToRace.Add(auxContract.Driver2)


        Next



        'Choosing the random GPs --------------------------------
        'Checking if there are enough GPs in the database

        If numGPs > colGPs.Count Then
            MessageBox.Show("There are not enough GPs in the Database to perform the creation of the season.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For i = 1 To numGPs

            num = rnd.Next(1, colGPs.Count + 1)
            auxGPID = Integer.Parse(colGPs.Item(num).ToString())

            colGPs.Remove(num)

            se.ListGPsID.Add(auxGPID)
        Next

        'Choosing the random races ----------------------------------------------------------------

        'Copying the GPs IDs to an auxiliar collection
        For i = 1 To se.ListGPsID.Count
            auxGPID = Integer.Parse(se.ListGPsID.Item(i).ToString)
            ColGPsToRace.Add(auxGPID)
        Next

        'Getting the size of the auxiliar collection
        numGPsOnSeason = ColGPsToRace.Count


        'Check that there are enough drivers to place all the positions, if not, adjust the number of positions to the number of drivers
        If numPositionsPerRace > ColDriversToRace.Count Then
            numPositionsPerRace = ColDriversToRace.Count
        End If

        For k = 1 To ColDriversToRace.Count
            AuxListDrivers.Add(ColDriversToRace.Item(k))
        Next

        For j = 1 To numGPsOnSeason

            auxGPID = Integer.Parse(ColGPsToRace.Item(j).ToString)

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
                auxRace = New Race(se.SeasonID, auxGPID, DriverIDToAdd)
                auxRace.Position = i
                auxRace.Points = pointsForDriver

                auxRace.InsertRace()

                AuxListDrivers.Remove(num)
            Next

            For k = 1 To ColDriversToRace.Count
                AuxListDrivers.Add(ColDriversToRace.Item(k))
            Next
        Next



        'Inserting the data from the GPs of the season in the calendar ------------------------
        For i = 1 To se.ListGPsID.Count
            auxGPID = Integer.Parse(se.ListGPsID.Item(i).ToString)
            'Insert the gp of the season in the calendar
            DBBroker.GetBroker().Change("INSERT INTO Calendar (Season, GP, `Order`) VALUES (" & se.SeasonID & ", " & auxGPID & ", " & i & ");")
        Next

    End Sub

    'To delete the season selected ----------------------------------------
    Public Function Delete(ByVal se As Season) As Integer

        Dim auxRaceCollectionToDelete As Collection
        Dim auxContractTeamIDToDelete As Integer

        Dim auxRaceGPIDToDelete As Integer
        Dim auxRaceDriverIDToDelete As Integer
        Dim auxRaceToDelete As Race

        Dim auxContractToDelete As Contract

        For i = 1 To se.ListRaces.Count

            auxRaceCollectionToDelete = CType(se.ListRaces(i), Collection)

            auxRaceGPIDToDelete = Integer.Parse(auxRaceCollectionToDelete.Item(2).ToString())
            auxRaceDriverIDToDelete = Integer.Parse(auxRaceCollectionToDelete.Item(3).ToString())
            auxRaceToDelete = New Race(se.SeasonID, auxRaceGPIDToDelete, auxRaceDriverIDToDelete)
            auxRaceToDelete.ReadRace()

            auxRaceToDelete.DeleteRace()

        Next

        For i = 1 To se.ListContractsTeamID.Count

            auxContractTeamIDToDelete = Integer.Parse(se.ListContractsTeamID(i).ToString)

            'Creates the contract to delete with the candidate keys
            auxContractToDelete = New Contract(auxContractTeamIDToDelete, se.SeasonID)
            auxContractToDelete.ReadContract()

            auxContractToDelete.DeleteContract()
        Next

        'Delete the season entry from the database
        Return DBBroker.GetBroker().Change("DELETE FROM Calendar WHERE Season = " & se.SeasonID & ";")

    End Function
End Class
