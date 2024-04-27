Imports System.Windows.Media
Imports Microsoft.VisualBasic.Devices
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

    Public Sub ReadContracts(season As Season)
        Dim colContractsID As Collection
        Dim auxContractTeamID As Collection

        colContractsID = DBBroker.GetBroker().Read("SELECT Team FROM Contracts WHERE Season = " & season.SeasonID & ";")
        For Each auxContractTeamID In colContractsID
            'Adding the teamID to the collection, that is, the first element in the auxiliar collection
            season.ListContractsTeamID.Add(Integer.Parse(auxContractTeamID(1).ToString()))
        Next
    End Sub

    Public Sub ReadGPs(season As Season)
        Dim colGPsID As Collection
        Dim auxGPID As Collection
        colGPsID = DBBroker.GetBroker().Read("SELECT GP FROM Calendar WHERE Season = " & season.SeasonID & ";")
        If colGPsID.Count > 0 Then
            'Adding all of the GPs ID to the collection
            For Each auxGPID In colGPsID
                season.ListGPsID.Add(Integer.Parse(auxGPID(1).ToString()))
            Next
        End If
    End Sub

    Public Sub ReadRaces(season As Season)
        Dim colRaces As Collection
        Dim auxRaceData As Collection
        'Only take the GPID and the DriverID that participates in this season
        colRaces = DBBroker.GetBroker().Read("SELECT * FROM Races WHERE Season = " & season.SeasonID & ";")
        If colRaces.Count > 0 Then
            For Each auxRaceData In colRaces
                Dim auxRace As New Collection 'Create a new instance since if not it will take the same values over and over again
                auxRace.Add(season.SeasonID) '(1) the season
                auxRace.Add(Integer.Parse(auxRaceData(2).ToString)) '(2) the gp it is participating 
                auxRace.Add(Integer.Parse(auxRaceData(3).ToString())) '(3) the driver that is participating
                season.ListRaces.Add(auxRace)
            Next
        End If
    End Sub

    Public Sub Read(season As Season)
        ReadContracts(season)
        ReadGPs(season)
        ReadRaces(season)
    End Sub
    Public Sub Insert(ByRef se As Season, ByVal numTeams As Integer, ByVal numGPs As Integer)

        'Variables for creating the races and its results------------------------------------------------------------------------------------------------------------------------------------
        Dim auxContract As New Contract

        'Collections to store the id of teams, contracts and gps ------------------------------------------------------------------------------------------------------------------------------------
        Dim colTeams As Collection
        Dim colGPs As Collection
        Dim colDrivers As Collection

        'ArrayList para almacenar las filas
        Dim auxTeamID As New ArrayList
        Dim auxDriverID As New ArrayList
        Dim auxGPID As New ArrayList
        Dim auxDriversIDListToRace As New ArrayList
        Dim copyDriversIDListToRace As New ArrayList

        'Variables for creating the races and its results ------------------------------------------------------------------------------------------------------------------------------------
        Dim auxRace As Race
        Dim pointsForDriver As Integer
        Dim numPositionsPerRace As Integer = 20

        'Retrieval of information from the database ------------------------------------------------------------------------------------------------------------------------------------
        colTeams = DBBroker.GetBroker().Read("SELECT TeamID FROM Teams ORDER BY TeamID;")
        colDrivers = DBBroker.GetBroker().Read("SELECT DriverID FROM Drivers ORDER BY DriverID;")
        colGPs = DBBroker.GetBroker().Read("SELECT GPID FROM GPs ORDER BY GPID;")

        If numTeams > colTeams.Count Then
            MessageBox.Show("There are not enough teams in the Database to perform the creation of the season.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Copy the data from the collections into arraylists ------------------------------------------------------------------------------------------------------------------------------------

        For Each auxTeamToCopy As Collection In colTeams
            Dim auxIndexArray As Integer = auxTeamID.Add(Integer.Parse(auxTeamToCopy(1).ToString()))
        Next

        For Each auxDriverToCopy As Collection In colDrivers
            Dim auxIndexArray As Integer = auxDriverID.Add(Integer.Parse(auxDriverToCopy(1).ToString()))
        Next

        For Each auxGPToCopy As Collection In colGPs
            Dim auxIndexArray As Integer = auxGPID.Add(Integer.Parse(auxGPToCopy(1).ToString()))
        Next



        'Choosing the random teams ------------------------------------------------------------------------------------------------------------------------------------     
        For i = 1 To numTeams
            'CHECKEAR QUE HAY SUFICIENTES EQUIPOS EN LA BASE DE DATOS (AUNQUE NO TIENE POR QUÉ HACER FALTA ESTO)

            Dim rand As New Random
            Dim randomIndexTeamSelected As Integer = rand.Next(0, auxTeamID.Count)

            Dim teamID As Integer = CInt(auxTeamID(randomIndexTeamSelected).ToString)

            auxContract = New Contract(teamID, se.SeasonID)

            'Choosing the first driver for the contract
            Dim randomIndexDriverSelected As Integer = rand.Next(0, auxDriverID.Count)
            Dim driverID As Integer = CInt(auxDriverID(randomIndexDriverSelected).ToString)
            auxContract.Driver1 = driverID
            auxDriverID.Remove(driverID)

            'Choosing the second driver for the contract
            randomIndexDriverSelected = rand.Next(0, auxDriverID.Count)
            driverID = CInt(auxDriverID(randomIndexDriverSelected).ToString)
            auxContract.Driver2 = driverID
            auxDriverID.Remove(driverID)

            auxContract.InsertContract()

            auxDriversIDListToRace.Add(auxContract.Driver1)
            auxDriversIDListToRace.Add(auxContract.Driver2)

            auxTeamID.Remove(teamID)

        Next

        'Checks if the number of drivers are below the sufficient number of drivers
        'for a formulaone race, if so, it will adjust the quantity
        If numPositionsPerRace > auxDriversIDListToRace.Count Then
            numPositionsPerRace = auxDriversIDListToRace.Count
        End If

        For Each copiedDriverID As Integer In auxDriversIDListToRace
            copyDriversIDListToRace.Add(copiedDriverID)
        Next

        'Choosing the random GPs ------------------------------------------------------------------------------------------------------------------------------------
        For i = 1 To numGPs

            Dim rand As New Random
            'Get the random index of the gp selected
            Dim randomIndexGPsSelected As Integer = rand.Next(0, auxGPID.Count)
            'Get its ID value
            Dim gpID As Integer = CInt(auxGPID(randomIndexGPsSelected).ToString)

            DBBroker.GetBroker().Change("INSERT INTO Calendar (Season, GP, `Order`) VALUES (" & se.SeasonID.ToString & ", " & gpID.ToString & ", " & i & ");")

            'Choosing the random races ------------------------------------------------------------------------------------------------------------------------------------
            For j = 1 To numPositionsPerRace
                'Get the random index for the driver that will participate
                Dim randomIndexDriverSelected As Integer = rand.Next(0, copyDriversIDListToRace.Count)

                'Gets the ID of the driver that will participate
                Dim auxDriverIDtoRace As Integer = CInt(copyDriversIDListToRace(randomIndexDriverSelected).ToString)
                If j <= 6 Then
                    Select Case j
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
                auxRace = New Race(se.SeasonID, gpID, auxDriverIDtoRace)
                auxRace.Points = pointsForDriver
                auxRace.Position = j

                auxRace.InsertRace()

                copyDriversIDListToRace.Remove(auxDriverIDtoRace)
            Next

            'We copy the list of drivers to race for every race that we need to do
            For Each copiedDriverID As Integer In auxDriversIDListToRace
                copyDriversIDListToRace.Add(copiedDriverID)
            Next

            'We remove this gp so that it can't be get selected again
            auxGPID.Remove(gpID)
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
