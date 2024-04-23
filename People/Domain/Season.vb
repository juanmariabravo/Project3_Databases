' TODO: Add the attributes of the reports and calendars
Public Class Season
    Public Property ListTeams As New Collection
    Public Property ListGPs As New Collection
    Public Property ListRaces As New Collection

    Public Property SeasonID As Integer

    Public ReadOnly Property SeasonDAO As SeasonDAO

    Public Sub New()
        Me.SeasonDAO = New SeasonDAO
    End Sub

    Public Sub New(Year As Integer)
        Me.SeasonID = Year
        Me.SeasonDAO = New SeasonDAO
    End Sub
    Public Sub ReadAllSeasons()
        Me.SeasonDAO.ReadAll()
    End Sub

    Public Sub ReadSeason()
        Me.SeasonDAO.Read(Me)
    End Sub

    Public Sub InsertSeason(ByVal numTeams As Integer, ByVal numGPs As Integer)
        Me.SeasonDAO.Insert(Me, numTeams, numGPs)
    End Sub

End Class
