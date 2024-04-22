Public Class Race
    Public Property Season As Integer
    Public Property GP As Integer
    Public Property Driver As Integer

    Public Property Position As Byte
    Public Property Points As Byte

    Public Sub New(SeasonID As Integer)
        Me.Season = SeasonID
    End Sub

    Public Sub New(SeasonID As Integer, GPID As Integer, DriverID As Integer, Position As Byte, Points As Byte)
        Me.Season = SeasonID
        Me.GP = GPID
        Me.Driver = DriverID
        Me.Position = Position
        Me.Points = Points
    End Sub

End Class
