Public Class Report

    Public Sub New()
    End Sub

    Public Sub LoadViews()
        DBBroker.GetBroker.Change("CREATE OR REPLACE VIEW driverwonraces(driv, seas, wonraces) AS
                                    SELECT Driver, Season, COUNT(*) 
                                    FROM races
                                    WHERE Position = 1
                                    GROUP BY Driver, Season;

                                    CREATE OR REPLACE VIEW sea_dri_points (seasonYear, driverId, points) AS
                                    SELECT Season, Driver, sum(Points)
                                    FROM races
                                    GROUP BY Season, Driver;

                                    CREATE OR REPLACE VIEW season_max_points(sea, maxp) AS
                                    SELECT seasonYear, max(points)
                                    FROM sea_dri_points
                                    GROUP BY seasonYear;

                                    CREATE OR REPLACE VIEW sea_winner_pts_cou (season,winner_driver,pts,country) AS
                                    SELECT seasonYear, s.driverId, maxp, DriverCountry
                                    FROM sea_dri_points s, season_max_points, drivers d
                                    WHERE points = maxp AND s.driverId = d.DriverID AND sea = seasonYear;
")
    End Sub
    Public Function GetClassificationDrivers(ByVal seasonYear As Integer) As Collection
        Return DBBroker.GetBroker.Read("SELECT Driver, sum(Points)
                                        FROM races, driverwonraces
                                        WHERE seas = Season AND Driver = driv 
                                        AND Season = '" & seasonYear & "' 
                                        GROUP BY Driver
                                        ORDER BY sum(Points) DESC,wonraces DESC;")
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

    Public Function HistoryDriversGetItsRaces(ByVal driverID As Integer, ByVal startSeason As Integer, ByVal endSeason As Integer) As Collection
        Return DBBroker.GetBroker.Read("SELECT Season, GP, Position, Points
                                        FROM races
                                        WHERE Driver = " & driverID & "
                                        AND Season >= " & startSeason & " 
                                        AND Season <= " & endSeason & ";")
    End Function


    Public Function HistoryTeamsGetItsDriverRacesResults(ByVal TeamID As Integer, ByVal startSeason As Integer, ByVal endSeason As Integer) As Collection
        Return DBBroker.GetBroker.Read("SELECT DISTINCT r.Driver
                                        FROM races r, contracts c
                                        WHERE r.Season = c.Season
                                        AND r.Season >= " & startSeason & " 
                                        AND r.Season <= " & endSeason & "
                                        AND (c.Driver1 = r.Driver OR c.Driver2 = r.Driver)
                                        AND c.Team = " & TeamID & ";")
    End Function
    Public Function HistoryTeamsGetItsRaces(ByVal DriverID As Integer, ByVal teamID As Integer, ByVal startSeason As Integer, ByVal endSeason As Integer) As Collection
        Return DBBroker.GetBroker.Read("SELECT r.Season, r.GP, r.Position, r.Points
                                        FROM races r, contracts c
                                        WHERE r.Driver='" & DriverID & "'
                                    	AND r.Season>='" & startSeason & "' AND r.Season<='" & endSeason & "'
                                    	AND r.Season=c.Season
                                        AND c.Team='" & teamID & "'
                                        AND (c.Driver1=r.Driver OR c.Driver2=r.Driver);")
    End Function

    Public Function WorldChampionshipGetAllSeasonsWinners(ByVal countryID As String) As Collection
        Return DBBroker.GetBroker.Read("SELECT s.winner_driver, s.season, c.team, s.pts, d.wonraces
                                        FROM sea_winner_pts_cou s, contracts c, driverwonraces d
                                        WHERE c.Season = s.season 
                                        AND (s.winner_driver = c.Driver1 OR s.winner_driver = c.Driver2) 
                                        AND s.winner_driver = d.driv 
                                        AND s.season = d.seas
                                        AND s.country = '" & countryID & "';")
    End Function
End Class
