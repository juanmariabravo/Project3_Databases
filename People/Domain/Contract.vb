Public Class Contract
    Public Property Team As Integer
    Public Property Season As Integer
    Public Property Driver1 As Integer
    Public Property Driver2 As Integer

    Public ReadOnly Property ContractDAO As ContractDAO

    Public Sub New(team As Integer, season As Integer, driver1 As Integer, driver2 As Integer)
        Me.Team = team
        Me.Season = season
        Me.Driver1 = driver1
        Me.Driver2 = driver2
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
