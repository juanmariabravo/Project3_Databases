Public Class SeasonDAO
    Public ReadOnly Property Seasons As Collection

    Public Sub New()
        Me.Seasons = New Collection
    End Sub

    Public Sub ReadAll()
        Dim se As Season
        Dim listTeams As Collection
        Dim listGPs As Collection
        Dim colTeams, colGPs As Collection
        Dim SeasonIDs As Collection
        SeasonIDs = DBBroker.GetBroker().Read("SELECT SeasonID FROM Calendar ORDER BY SeasonID;")
        colTeams = DBBroker.GetBroker().Read("SELECT * FROM Teams ORDER BY TeamID;")
        colGPs = DBBroker.GetBroker().Read("SELECT * FROM GPs ORDER BY GPID;")

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
            se = New Season(listTeams, listGPs)
            'Add the season to the collection
            Me.Seasons.Add(se)
        Else
            'Messaget that the season did not have any teams or GPs
            MsgBox("The season did not have any teams or GPs")
        End If

    End Sub

    Public Sub Read(ByRef se As Season)


    End Sub
End Class
