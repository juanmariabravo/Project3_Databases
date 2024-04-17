'Queda por añadir los atributos de los reports y calendarios
Public Class Season
    Public Property ListTeams As Collection
    Public Property ListGPs As Collection
    Public Property SeasonID As Integer

    Public ReadOnly Property SeasonDAO As SeasonDAO

    Public Sub New()
        Me.SeasonDAO = New SeasonDAO
    End Sub

    Public Sub New(Year As Integer, Teams As Collection, GPs As Collection)
        Me.SeasonID = Year
        Me.ListTeams = Teams
        Me.ListGPs = GPs
        Me.SeasonDAO = New SeasonDAO
    End Sub
    Public Sub ReadAll()
        Me.SeasonDAO.ReadAll()
    End Sub

    Public Sub ReadSeason()
        Me.SeasonDAO.Read(Me)
    End Sub




End Class
