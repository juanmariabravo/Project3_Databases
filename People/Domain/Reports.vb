Public Class Report

    Public Sub New()
    End Sub

    Public Function GetClassificationDrivers(ByVal seasonYear As Integer) As Collection
        Return DBBroker.GetBroker.Read("SELECT * FROM ClassificationDrivers 
                                        WHERE SeasonYear = '" & seasonYear & "' 
                                        ORDER BY Points DESC;")
    End Function

    Public Function GetClassificationTeams(ByVal seasonYear As Integer) As Collection
        Return DBBroker.GetBroker.Read("SELECT c.Team, sum(r.Points) 
                                        FROM races r, contracts c 
                                        WHERE r.Season = '" & seasonYear & "' 
                                        AND r.Season = c.Season 
                                        AND (c.Driver1 = r.Driver OR c.Driver2 = r.Driver) 
                                        GROUP BY c.Team 
                                        ORDER BY sum(r.Points) DESC;")
    End Function

    Public Function GetRacesHistoryOfDriver(ByVal driverID As Integer, ByVal startSeason As Integer, ByVal endSeason As Integer) As Collection
        Return DBBroker.GetBroker.Read("SELECT Season, GP, Position, Points
                                        FROM races
                                        WHERE Driver = " & driverID & "
                                        AND Season >= " & startSeason & " AND Season <= " & endSeason & ";")
    End Function

    Public Function GetDriverRacesResults(ByVal TeamID As Integer, ByVal startSeason As Integer, ByVal endSeason As Integer) As Collection
        Return DBBroker.GetBroker.Read("SELECT DISTINCT r.Driver
                                        FROM races r, contracts c
                                        WHERE r.Season = c.Season
                                        AND (c.Driver1 = r.Driver OR c.Driver2 = r.Driver)
                                        AND c.Team = " & TeamID & ";")
    End Function
End Class
