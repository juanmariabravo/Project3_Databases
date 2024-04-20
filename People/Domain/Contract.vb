Public Class Contract
    Public Property Team As Integer
    Public Property Season As Integer
    Public Property Driver1 As Integer
    Public Property Driver2 As Integer

    Public ReadOnly Property ContractDAO As ContractDAO

    Public Sub New()
        Me.ContractDAO = New ContractDAO()
    End Sub
    Public Sub New(team As Integer, season As Integer)
        Me.Team = team
        Me.Season = season
        Me.ContractDAO = New ContractDAO()
    End Sub

    Public Sub ReadAllContracts()
        Me.ContractDAO.ReadAll()
    End Sub

    Public Sub ReadContract()
        Me.ContractDAO.Read(Me)
    End Sub

    Public Function InsertContract() As Integer
        Return Me.ContractDAO.Insert(Me)
    End Function

    Public Function UpdateContract() As Integer
        Return Me.ContractDAO.Update(Me)
    End Function

    Public Function DeleteContract() As Integer
        Return Me.ContractDAO.Delete(Me)
    End Function
End Class
