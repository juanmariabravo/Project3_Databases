Public Class CountryDAO
    Public ReadOnly Property Countries As Collection

    Public Sub New()

        Me.Countries = New Collection
    End Sub

    Public Sub ReadAll()
        Dim c As Country : Dim col, aux As Collection ' : is used to separate statements in the same line
        col = DBBroker.GetBroker().Read("SELECT * FROM Countries ORDER BY CountryID;")
        For Each aux In col ' for each element I get in the collection, I create a new Country object and add it to the collection
            c = New Country(aux(1).ToString)
            c.ReadCountry()
            Me.Countries.Add(c)
        Next
    End Sub

    Public Sub Read(ByRef c As Country)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Countries WHERE CountryID='" & c.CountryID & "';")
        For Each aux In col
            c.CountryName = aux(2).ToString
            c.CountryPopulation = Integer.Parse(aux(3).ToString)
        Next
    End Sub

    Public Function Insert(ByVal c As Country) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Countries VALUES ('" & c.CountryID & "', '" & c.CountryName & "', '" & c.CountryPopulation & "');")
    End Function

    Public Function Update(ByVal c As Country) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Countries SET CountryName='" & c.CountryName & "', CountryPopulation='" & c.CountryPopulation & "' WHERE CountryID='" & c.CountryID & "';")
    End Function

    Public Function Delete(ByVal c As Country) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Countries WHERE CountryID='" & c.CountryID & "';")
    End Function
    Public Function GetAllCountries() As List(Of Country)
        Dim countries As New List(Of Country)()

        ' Consulta SQL para seleccionar todos los países
        Dim query As String = "SELECT CountryID, CountryName FROM Countries ORDER BY CountryName;"
        Dim db As DBBroker = DBBroker.GetBroker()
        Dim result As Collection = db.Read(query)

        ' Iterar sobre los resultados de la consulta
        For Each row As Collection In result
            Dim country As New Country()
            country.CountryID = row(0).ToString()
            country.CountryName = row(1).ToString()
            countries.Add(country)
        Next

        Return countries
    End Function


End Class