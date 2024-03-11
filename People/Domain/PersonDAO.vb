Public Class PersonDAO

    Public ReadOnly Property Persons As Collection


    Public Sub New()
        ' create an empty person object whose DAO is going to have a collection containing all the persons read in the ReadAll method
        Me.Persons = New Collection
    End Sub

    Public Sub ReadAll()
        Dim p As Person : Dim col, aux As Collection ' : is used to separate statements in the same line
        col = DBBroker.GetBroker().Read("SELECT * FROM persons ORDER BY PersonID;")
        For Each aux In col ' for each element I get in the collection, I create a new Person object and add it to the collection
            p = New Person(aux(1).ToString)
            ' p.PersonName = aux(2).ToString, same as the following line
            p.ReadPerson() ' more simple if there are many properties
            Me.Persons.Add(p)
        Next
    End Sub

    Public Sub Read(ByRef p As Person)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Persons WHERE PersonID='" & p.PersonID & "';")
        For Each aux In col
            p.PersonName = aux(2).ToString
        Next
    End Sub

    Public Function Insert(ByVal p As Person) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Persons VALUES ('" & p.PersonID & "', '" & p.PersonName & "');")
    End Function

    Public Function Update(ByVal p As Person) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Persons SET PersonName='" & p.PersonName & "' WHERE PersonID='" & p.PersonID & "';")
    End Function

    Public Function Delete(ByVal p As Person) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Persons WHERE PersonID='" & p.PersonID & "';")
    End Function

End Class