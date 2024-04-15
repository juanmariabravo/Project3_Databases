Public Class ContractDAO
    Public ReadOnly Property Contracts As Collection

    Public Sub New()
        Me.Contracts = New Collection
    End Sub
    Public Sub ReadAll()
        Dim contract As Contract
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Contracts ORDER BY Season, Team;")

        For Each aux In col
            contract = New Contract(
             Integer.Parse(aux(1).ToString),
             Integer.Parse(aux(2).ToString),
             Integer.Parse(aux(3).ToString),
             Integer.Parse(aux(4).ToString)
         )
            Me.Contracts.Add(contract)
        Next
    End Sub
    Public Sub Read(ByRef contract As Contract)
        Dim col As Collection
        Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Contracts WHERE Season='" & contract.Season & "' AND Team='" & contract.Team & "';")

        For Each aux In col
            contract.Driver1 = Integer.Parse(aux(3).ToString)
            contract.Driver2 = Integer.Parse(aux(4).ToString)
        Next
    End Sub

    Public Function Insert(ByVal contract As Contract) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Contracts VALUES ('" & contract.Team & "', '" & contract.Season & "', '" & contract.Driver1 & "', '" & contract.Driver2 & "');")
    End Function

    Public Function Update(ByVal contract As Contract) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Contracts SET Driver1='" & contract.Driver1 & "', Driver2='" & contract.Driver2 & "' WHERE Season='" & contract.Season & "' AND Team='" & contract.Team & "';")
    End Function

    Public Function Delete(ByVal contract As Contract) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Contracts WHERE Season='" & contract.Season & "' AND Team='" & contract.Team & "';")
    End Function
End Class
