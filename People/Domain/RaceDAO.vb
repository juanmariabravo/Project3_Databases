Public Class RaceDAO
    Public ReadOnly Property races As Collection

    Public Sub New()
        Me.races = New Collection
    End Sub

    Public Sub ReadAll()
        Dim race As Race
        Dim colRaces, raceData As Collection
        If races.Count > 0 Then
            races.Clear()
        End If
        Try
            colRaces = DBBroker.GetBroker().Read("SELECT * FROM Races;")
            For Each raceData In colRaces
                race = New Race(Integer.Parse(raceData(1).ToString), Integer.Parse(raceData(2).ToString()), Integer.Parse(raceData(3).ToString()))
                race.ReadRace()
                Me.races.Add(race)
            Next
        Catch ex As Exception
            MessageBox.Show("Mistake while reading all of the races: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub Read(ByRef race As Race)
        Dim colRaces As Collection
        Dim auxRace As Collection

        colRaces = DBBroker.GetBroker().Read("SELECT * FROM races WHERE Season='" & race.Season & "';")

        If colRaces.Count > 1 Then
            For Each auxRace In colRaces
                race.Position = Integer.Parse(auxRace(4).ToString())
                race.Points = Integer.Parse(auxRace(5).ToString())
            Next

        End If
    End Sub

    Public Function Insert(ByVal race As Race) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Races VALUES('" & race.Season & "', '" & race.GP & "', '" & race.Driver & "', '" & race.Position & "', '" & race.Points & "');")
    End Function

    'Create the function to delete the race
    Public Function Delete(ByVal race As Race) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Races WHERE Season='" & race.Season & "' AND GP='" & race.GP & "' AND Driver='" & race.Driver & "';")
    End Function
End Class
