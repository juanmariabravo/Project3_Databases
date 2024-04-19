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
        Me.SeasonDAO = New SeasonDAO
    End Sub
    Public Sub ReadAll()
        Me.SeasonDAO.ReadAll()
    End Sub

    Public Sub ReadSeason()
        Me.SeasonDAO.Read(Me)
    End Sub

    Public Sub InsertSeason(ByVal minTeams As Integer, ByVal maxTeams As Integer, ByVal minGPs As Integer, ByVal maxGPs As Integer)
        Me.SeasonDAO.Insert(Me)
    End Sub




End Class
