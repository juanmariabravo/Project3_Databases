Public Class ContractDAO
    Public ReadOnly Property Contracts As Collection

    Public Sub New()
        Me.Contracts = New Collection
    End Sub
    Public Sub ReadAll()
        Dim contract As Contract
        Dim colContracts, auxContracts As Collection
        colContracts = DBBroker.GetBroker().Read("SELECT * FROM Contracts ORDER BY Season, Team;")

        For Each auxContracts In colContracts
            contract = New Contract(Integer.Parse(auxContracts(1).ToString), Integer.Parse(auxContracts(2).ToString))
            contract.ReadContract()
            Me.Contracts.Add(contract)
        Next
    End Sub
    Public Sub Read(ByRef contract As Contract)
        Dim colContracts As Collection
        Dim aux As Collection
        colContracts = DBBroker.GetBroker.Read("SELECT * FROM Contracts WHERE Season='" & contract.Season & "' AND Team='" & contract.Team & "';")
        If colContracts.Count > 0 Then
            For Each aux In colContracts
                contract.Driver1 = Integer.Parse(aux(3).ToString)
                contract.Driver2 = Integer.Parse(aux(4).ToString)
            Next
        End If


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
