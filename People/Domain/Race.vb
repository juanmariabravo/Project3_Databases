Public Class Race
    Public Property Season As Integer
    Public Property GPID As Integer
    Public Property Driver As Integer
    Public Property Position As Integer
    Public Property Points As Integer
    Public Property RaceDAO As RaceDAO
    Public Sub New()
        Me.RaceDAO = New RaceDAO
    End Sub


    Public Sub New(SeasonID As Integer, GPID As Integer, DriverID As Integer)
        Me.Season = SeasonID
        Me.GPID = GPID
        Me.Driver = DriverID
        Me.RaceDAO = New RaceDAO
    End Sub



    Public Sub ReadAllRaces()
        Me.RaceDAO.ReadAll()
    End Sub
    Public Sub ReadRace()
        Me.RaceDAO.Read(Me)
    End Sub
    Public Sub InsertRace()
        Me.RaceDAO.Insert(Me)
    End Sub

    Public Sub DeleteRace()
        Me.RaceDAO.Delete(Me)
    End Sub
End Class
