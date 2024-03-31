Public Class Team

    Public Property TeamID As Integer
    Public Property TeamName As String
    Public Property TeamCountry As Integer
    Public Property CreationDate As Date
    Public ReadOnly Property TeDAO As TeamDAO

    Public Sub New()
        Me.TeDAO = New TeamDAO
    End Sub

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal country As Integer, ByVal creaDate As Date)
        Me.TeamID = id
        Me.TeamName = name
        Me.TeamCountry = country
        Me.CreationDate = creaDate
        Me.TeDAO = New TeamDAO
    End Sub

    Public Sub ReadAllTeams()
        Me.TeDAO.ReadAll()
    End Sub

    Public Sub ReadTeam()
        Me.TeDAO.Read(Me)
    End Sub

    Public Function InsertTeam() As Integer
        Return Me.TeDAO.Insert(Me)
    End Function

    Public Function UpdateTeam() As Integer
        Return Me.TeDAO.Update(Me)
    End Function

    Public Function DeleteTeam() As Integer
        Return Me.TeDAO.Delete(Me)
    End Function
End Class
