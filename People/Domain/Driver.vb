Public Class Driver
    Public Property DriverID As Integer
    Public Property DriverName As String
    Public Property DriverSurname As String
    Public Property DriverCountry As String

    Public ReadOnly Property DrvDAO As DriverDAO

    Public Sub New()
        Me.DrvDAO = New DriverDAO
    End Sub

    Public Sub New(ByVal id As Integer)
        Me.DriverID = id
        Me.DrvDAO = New DriverDAO
    End Sub

    Public Sub ReadAllDrivers()
        Me.DrvDAO.ReadAll()
    End Sub

    Public Sub ReadDriver()
        Me.DrvDAO.Read(Me)
    End Sub

    Public Function InsertDriver() As Integer
        Return Me.DrvDAO.Insert(Me)
    End Function

    Public Function UpdateDriver() As Integer
        Return Me.DrvDAO.Update(Me)
    End Function

    Public Function DeleteDriver() As Integer
        Return Me.DrvDAO.Delete(Me)
    End Function
End Class
