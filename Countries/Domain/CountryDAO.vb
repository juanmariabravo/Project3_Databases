Public Class CountryDAO

    Public ReadOnly Property Countries As Collection


    Public Sub New()
        ' create an empty person object whose DAO is going to have a collection containing all the persons read in the ReadAll method
        Me.Countries = New Collection
    End Sub

    Public Sub ReadAll()
        Dim p As Country : Dim col, aux As Collection ' : is used to separate statements in the same line
        col = DBBroker.GetBroker().Read("SELECT * FROM countries ORDER BY CountryID;")
        For Each aux In col ' for each element I get in the collection, I create a new Person object and add it to the collection
            p = New Country(aux(1).ToString)
            ' p.CountryName = aux(2).ToString, same as the following line
            p.ReadPerson() ' more simple if there are many properties
            Me.Countries.Add(p)
        Next
    End Sub

    Public Sub Read(ByRef p As Country)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Countries WHERE CountryID='" & p.CountryID & "';")
        For Each aux In col
            p.CountryName = aux(2).ToString
        Next
    End Sub

    Public Function Insert(ByVal p As Country) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Countries VALUES ('" & p.CountryID & "', '" & p.CountryName & "');")
    End Function

    Public Function Update(ByVal p As Country) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Countries SET CountryName='" & p.CountryName & "' WHERE CountryID='" & p.CountryID & "';")
    End Function

    Public Function Delete(ByVal p As Country) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Countries WHERE CountryID='" & p.CountryID & "';")
    End Function

End Class