Public Class DriverDAO
    Public ReadOnly Property Drivers As Collection

    Public Sub New()
        Me.Drivers = New Collection
    End Sub

    Public Sub ReadAll()
        Dim d As Driver
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Drivers ORDER BY DriverID;")
        For Each aux In col
            d = New Driver(Integer.Parse(aux(1).ToString()))
            d.DrvDAO.Read(d)
            Me.Drivers.Add(d)
        Next
    End Sub


    Public Sub Read(ByRef d As Driver)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Drivers WHERE DriverID='" & d.DriverID & "';")
        For Each aux In col
            d.DriverName = aux(2).ToString
            d.DriverSurname = aux(3).ToString
            d.DriverCountry = aux(4).ToString
        Next
    End Sub

    Public Function Insert(ByVal d As Driver) As Integer
        Return DBBroker.GetBroker().Change("INSERT INTO Drivers VALUES ('" & d.DriverID & "', '" & d.DriverName & "', '" & d.DriverSurname & "', '" & d.DriverCountry & "');")
    End Function

    Public Function Update(ByVal d As Driver) As Integer
        Return DBBroker.GetBroker().Change("UPDATE Drivers SET DriverName='" & d.DriverName & "', DriverSurname='" & d.DriverSurname & "', DriverCountry='" & d.DriverCountry & "' WHERE DriverID='" & d.DriverID & "';")
    End Function

    Public Function Delete(ByVal d As Driver) As Integer
        Return DBBroker.GetBroker().Change("DELETE FROM Drivers WHERE DriverID='" & d.DriverID & "';")
    End Function

    Public Function GetAllDrivers() As List(Of Driver)
        Dim drivers As New List(Of Driver)()

        Dim query As String = "SELECT DriverID, DriverName, DriverSurname, DriverCountry FROM Drivers ORDER BY DriverID;"
        Dim db As DBBroker = DBBroker.GetBroker()
        Dim result As Collection = db.Read(query)

        For Each row As Collection In result
            Dim driver As New Driver()
            driver.DriverID = Integer.Parse(row(0).ToString())
            driver.DriverName = row(1).ToString()
            driver.DriverSurname = row(2).ToString()
            driver.DriverCountry = row(3).ToString()
            drivers.Add(driver)
        Next

        Return drivers
    End Function
End Class
