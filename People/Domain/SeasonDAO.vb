Public Class SeasonDAO

    Public ReadOnly Property Seasons As Collection

    Public Sub New()
        Me.Seasons = New Collection
    End Sub

    Public Sub ReadAll()
        Dim se As Season

        Dim colTeams As Collection
        Dim colGPs As Collection
        Dim colContracts As Collection
        Dim SeasonIDs As Collection
        Dim yearSeason As Integer

        SeasonIDs = DBBroker.GetBroker().Read("SELECT SeasonID FROM Calendar ORDER BY SeasonID;")
        If SeasonIDs.Count > 0 Then

            For Each se In SeasonIDs
                yearSeason = Integer.Parse(se.SeasonID.ToString)
                'Now get the contracts for the season
                colContracts = DBBroker.GetBroker().Read("SELECT * FROM Contracts WHERE Season = " & yearSeason & ";")
                'Now get the teams that have those contracts
                colTeams = DBBroker.GetBroker().Read("SELECT * FROM Teams WHERE TeamID IN (SELECT Team FROM Contracts WHERE Season = " & yearSeason & ");")
                'Now get the GPs for the season
                colGPs = DBBroker.GetBroker().Read("SELECT * FROM GPs WHERE GPID IN (SELECT GP FROM Calendar WHERE SeasonID = " & yearSeason & ");")
                'Create the collections

                'colTeams = DBBroker.GetBroker().Read("SELECT * FROM Teams ORDER BY TeamID;")
                'colGPs = DBBroker.GetBroker().Read("SELECT * FROM GPs ORDER BY GPID;")
                'colTeams.Add(ListContracts)
                'Add teams to the collection
                If colTeams.Count > 0 Then
                    For Each aux In colTeams
                        listTeams.Add(aux)
                    Next
                End If
                'Add GPs to the collection
                If colGPs.Count > 0 Then
                    For Each aux In colGPs
                        listGPs.Add(aux)
                    Next
                End If
                'If any of the lists are not empty, we create the season
                If listTeams.Count > 0 AndAlso listGPs.Count > 0 Then
                    se = New Season(yearSeason, listTeams, listGPs)
                    'Add the season to the collection
                    Me.Seasons.Add(se)
                Else
                    'Message that the season did not have any teams or GPs
                    MsgBox("The season did not have any teams or GPs")
                End If
            Next
        End If
    End Sub

    Public Sub Read(ByRef se As Season)
        Dim colTeams As Collection
        Dim colGPs As Collection
        Dim colContracts As Collection
        Dim aux As Collection

        'Now get the contracts for the season
        colContracts = DBBroker.GetBroker().Read("SELECT * FROM Contracts WHERE Season = " & se.SeasonID & ";")
        If colContracts.Count > 0 Then
            'Now get the teams that have those contracts
            For Each aux In colContracts
                colTeams = DBBroker.GetBroker().Read("SELECT * FROM Teams WHERE TeamID IN (SELECT Team FROM Contracts WHERE Season = " & se.SeasonID & ");")
                If colTeams.Count > 0 Then
                    se.ListTeams = colTeams
                End If
            Next
        End If

        'Now get the GPs for the season
        colGPs = DBBroker.GetBroker().Read("SELECT * FROM GPs WHERE GPID IN (SELECT GP FROM Calendar WHERE SeasonID = " & se.SeasonID & ");")
        If colGPs.Count > 0 Then
            se.ListGPs = colGPs
        End If

    End Sub

    Public Sub Insert(ByRef se As Season)

    End Sub
End Class
