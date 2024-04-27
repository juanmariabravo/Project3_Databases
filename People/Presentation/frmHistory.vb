Public Class frmHistory

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Intialize the ComboBox with the seasons
        Dim s As Season
        s = New Season
        s.ReadAllSeasons()
        For Each s In s.SeasonDAO.Seasons
            comboBoxEndSeason.Items.Add(s.SeasonID)
            comboBoxEndSeason2.Items.Add(s.SeasonID)
            comboBoxStartSeason.Items.Add(s.SeasonID)
            comboBoxStartSeason2.Items.Add(s.SeasonID)
        Next

        ' Initialize the ComboBox with the drivers
        Dim d As Driver
        d = New Driver
        d.ReadAllDrivers()
        For Each d In d.DrvDAO.Drivers
            comboBoxDrivers.Items.Add(d.DriverID & " " & d.DriverName & " " & d.DriverSurname)
        Next

        ' Initialize the ComboBox with the teams
        Dim t As Team
        t = New Team
        t.ReadAllTeams()
        For Each t In t.TeDAO.Teams
            comboBoxTeams.Items.Add(t.TeamID & " " & t.TeamName)
        Next





    End Sub

    Private Sub btnMainMenuSeasons_Click(sender As Object, e As EventArgs) Handles btnMainMenuSeasons.Click
        frmFormulaOne.Enabled = True
        Me.Close()
    End Sub


    Private Sub frmHistory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub comboBoxDrivers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxDrivers.SelectedIndexChanged

        If comboBoxDrivers.SelectedIndex >= 0 Then
            lstRaces.Items.Clear()
            Dim driverID As Integer = CInt(comboBoxDrivers.SelectedItem.ToString.Split(" "c)(0))
            Dim auxdriver As New Driver(driverID)
            Dim startSeason As Integer
            Dim endSeason As Integer
            Dim historyDriver As New Report
            Dim auxRacesOfDriver As Collection

            If comboBoxStartSeason.SelectedIndex >= 0 Then
                startSeason = CInt(comboBoxStartSeason.SelectedItem.ToString)
            Else
                startSeason = 1970
            End If

            If comboBoxEndSeason.SelectedIndex >= 0 Then
                endSeason = CInt(comboBoxEndSeason.SelectedItem.ToString)
            Else
                endSeason = 2024
            End If

            If comboBoxStartSeason.SelectedIndex >= 0 AndAlso startSeason > endSeason Then
                MessageBox.Show("The start season must be less than the end season")
                comboBoxStartSeason.SelectedIndex = -1
                comboBoxEndSeason.SelectedIndex = -1
            Else
                auxdriver.ReadDriver()

                auxRacesOfDriver = historyDriver.HistoryDriversGetItsRaces(driverID, startSeason, endSeason)

                If auxRacesOfDriver.Count > 0 Then

                    For Each auxRace As Collection In auxRacesOfDriver
                        Dim GPtoRead As GP = New GP(CInt(auxRace(2).ToString))
                        GPtoRead.ReadGP()
                        lstRaces.Items.Add(auxRace(1).ToString & "    " & GPtoRead.GPID & " " & GPtoRead.GPName) '4 posicion separada es el id del gp
                    Next
                End If
            End If

        End If



    End Sub

    Private Sub comboBoxStartSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxStartSeason.SelectedIndexChanged
        If comboBoxStartSeason.SelectedIndex >= 0 Then

            If comboBoxDrivers.SelectedIndex >= 0 Then

                Dim driverID As Integer = CInt(comboBoxDrivers.SelectedItem.ToString.Split(" "c)(0))
                Dim startSeason As Integer = CInt(comboBoxStartSeason.SelectedItem.ToString)
                Dim endSeason As Integer
                Dim historyDriver As New Report
                Dim auxRacesOfDriver As Collection

                If comboBoxEndSeason.SelectedIndex < 0 Then
                    endSeason = 2024
                Else
                    endSeason = CInt(comboBoxEndSeason.SelectedItem.ToString)
                End If


                If startSeason <= endSeason Then
                    lstRaces.Items.Clear()
                    auxRacesOfDriver = historyDriver.HistoryDriversGetItsRaces(driverID, startSeason, endSeason)

                    If auxRacesOfDriver.Count > 0 Then
                        For Each auxRace As Collection In auxRacesOfDriver
                            Dim GPtoRead As GP = New GP(CInt(auxRace(2).ToString))
                            GPtoRead.ReadGP()
                            lstRaces.Items.Add(auxRace(1).ToString & "    " & GPtoRead.GPID & " " & GPtoRead.GPName)
                        Next
                    End If
                Else
                    MessageBox.Show("The start season must be less than the end season")
                    comboBoxStartSeason.SelectedIndex = -1
                    comboBoxEndSeason.SelectedIndex = -1
                End If
            End If
        End If

    End Sub

    Private Sub comboBoxEndSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxEndSeason.SelectedIndexChanged
        If comboBoxEndSeason.SelectedIndex >= 0 Then

            If comboBoxDrivers.SelectedIndex >= 0 Then

                Dim driverID As Integer = CInt(comboBoxDrivers.SelectedItem.ToString.Split(" "c)(0))
                
                Dim startSeason As Integer
                Dim endSeason As Integer = CInt(comboBoxEndSeason.SelectedItem.ToString)
                Dim historyDriver As New Report
                Dim auxRacesOfDriver As Collection

                If comboBoxStartSeason.SelectedIndex < 0 Then
                    startSeason = 1970
                Else
                    startSeason = CInt(comboBoxStartSeason.SelectedItem.ToString)
                End If





                If startSeason <= endSeason Then
                    lstRaces.Items.Clear()
                    auxRacesOfDriver = historyDriver.HistoryDriversGetItsRaces(driverID, startSeason, endSeason)

                    If auxRacesOfDriver.Count > 0 Then
                        For Each auxRace As Collection In auxRacesOfDriver
                            Dim GPtoRead As GP = New GP(CInt(auxRace(2).ToString))
                            GPtoRead.ReadGP()
                            lstRaces.Items.Add(auxRace(1).ToString & "    " & GPtoRead.GPID & " " & GPtoRead.GPName)
                        Next
                    End If
                Else
                    MessageBox.Show("The start season must be less than the end season")
                    comboBoxStartSeason.SelectedIndex = -1
                    comboBoxEndSeason.SelectedIndex = -1
                End If
            End If
        End If
    End Sub

    Private Sub lstRaces_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRaces.SelectedIndexChanged
        If lstRaces.SelectedIndex >= 0 Then
            Dim GPID As Integer = CInt(lstRaces.SelectedItem.ToString.Split(" "c)(4))
            Dim seasonID As Integer = CInt(lstRaces.SelectedItem.ToString.Split(" "c)(0))
            Dim driverID As Integer = CInt(comboBoxDrivers.SelectedItem.ToString.Split(" "c)(0))
            Dim auxRace As New Race(seasonID, GPID, driverID)

            auxRace.ReadRace()
            lblPosition.Text = "#" & auxRace.Position.ToString
            lblPoints.Text = auxRace.Points.ToString
        End If
    End Sub

    Private Sub comboBoxTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxTeams.SelectedIndexChanged
        If comboBoxTeams.SelectedIndex >= 0 Then

            lstDrivers.Items.Clear()
            Dim teamID As Integer = CInt(comboBoxTeams.SelectedItem.ToString.Split(" "c)(0))
            Dim startSeason As Integer
            Dim endSeason As Integer
            Dim historyDriver As New Report
            Dim auxDriversOfTeam As Collection

            If comboBoxStartSeason2.SelectedIndex >= 0 Then
                startSeason = CInt(comboBoxStartSeason2.SelectedItem.ToString)
            Else
                startSeason = 1970
            End If

            If comboBoxEndSeason2.SelectedIndex >= 0 Then
                endSeason = CInt(comboBoxEndSeason2.SelectedItem.ToString)
            Else
                endSeason = 2024
            End If

            If comboBoxStartSeason2.SelectedIndex >= 0 AndAlso startSeason > endSeason Then
                MessageBox.Show("The start season must be less than the end season")
                comboBoxStartSeason2.SelectedIndex = -1
                comboBoxEndSeason2.SelectedIndex = -1
            Else


                auxDriversOfTeam = historyDriver.HistoryTeamsGetItsDriverRacesResults(teamID, startSeason, endSeason)

                If auxDriversOfTeam.Count > 0 Then

                    For Each auxDriver As Collection In auxDriversOfTeam
                        Dim DrivertoRead As Driver = New Driver(CInt(auxDriver(1).ToString))
                        DrivertoRead.ReadDriver()
                        lstDrivers.Items.Add(DrivertoRead.DriverID & " " & DrivertoRead.DriverName & " " & DrivertoRead.DriverSurname)
                    Next
                End If
            End If

        End If
    End Sub

    Private Sub comboBoxStartSeason2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxStartSeason2.SelectedIndexChanged

        If comboBoxStartSeason2.SelectedIndex >= 0 Then

            If comboBoxTeams.SelectedIndex >= 0 Then

                Dim teamID As Integer = CInt(comboBoxTeams.SelectedItem.ToString.Split(" "c)(0))
                Dim startSeason As Integer = CInt(comboBoxStartSeason2.SelectedItem.ToString)
                Dim endSeason As Integer
                Dim historyTeam As New Report
                Dim auxDriversOfTeam As Collection

                If comboBoxEndSeason2.SelectedIndex < 0 Then
                    endSeason = 2024
                Else
                    endSeason = CInt(comboBoxEndSeason2.SelectedItem.ToString)
                End If



                If startSeason <= endSeason Then

                    lstDrivers.Items.Clear()
                    auxDriversOfTeam = historyTeam.HistoryTeamsGetItsDriverRacesResults(teamID, startSeason, endSeason)

                    If auxDriversOfTeam.Count > 0 Then
                        For Each auxDriver As Collection In auxDriversOfTeam
                            Dim DrivertoRead As Driver = New Driver(CInt(auxDriver(1).ToString))
                            DrivertoRead.ReadDriver()
                            lstDrivers.Items.Add(DrivertoRead.DriverID & " " & DrivertoRead.DriverName & " " & DrivertoRead.DriverSurname)
                        Next
                    End If
                Else
                    MessageBox.Show("The start season must be less than the end season")
                    comboBoxStartSeason2.SelectedIndex = -1
                    comboBoxEndSeason2.SelectedIndex = -1
                End If
            End If
        End If
    End Sub

    Private Sub comboBoxEndSeason2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxEndSeason2.SelectedIndexChanged
        If comboBoxEndSeason2.SelectedIndex >= 0 Then

            If comboBoxTeams.SelectedIndex >= 0 Then

                Dim teamID As Integer = CInt(comboBoxTeams.SelectedItem.ToString.Split(" "c)(0))
                Dim startSeason As Integer
                Dim endSeason As Integer = CInt(comboBoxEndSeason2.SelectedItem.ToString)
                Dim historyTeam As New Report
                Dim auxDriversOfTeam As Collection

                If comboBoxStartSeason2.SelectedIndex < 0 Then
                    startSeason = 1970
                Else
                    startSeason = CInt(comboBoxStartSeason2.SelectedItem.ToString)
                End If



                If startSeason <= endSeason Then

                    lstDrivers.Items.Clear()
                    auxDriversOfTeam = historyTeam.HistoryTeamsGetItsDriverRacesResults(teamID, startSeason, endSeason)

                    If auxDriversOfTeam.Count > 0 Then
                        For Each auxDriver As Collection In auxDriversOfTeam
                            Dim DrivertoRead As Driver = New Driver(CInt(auxDriver(1).ToString))
                            DrivertoRead.ReadDriver()
                            lstDrivers.Items.Add(DrivertoRead.DriverID & " " & DrivertoRead.DriverName & " " & DrivertoRead.DriverSurname)
                        Next
                    End If
                Else
                    MessageBox.Show("The start season must be less than the end season")
                    comboBoxStartSeason2.SelectedIndex = -1
                    comboBoxEndSeason2.SelectedIndex = -1
                End If
            End If
        End If
    End Sub

    Private Sub lstDrivers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDrivers.SelectedIndexChanged
        If lstDrivers.SelectedIndex >= 0 Then
            Dim r As New Report
            Dim driverID As Integer = CInt(lstDrivers.SelectedItem.ToString.Split(" "c)(0))
            Dim startSeason As Integer
            Dim endSeason As Integer
            Dim auxDriverAttr As Collection
            Dim teamID As Integer = CInt(comboBoxTeams.SelectedItem.ToString.Split(" "c)(0))

            lstRacesOfDriverSeason.Items.Clear()
            lstRacesOfDriverGP.Items.Clear()
            lstRacesOfDriverPosition.Items.Clear()
            lstRacesOfDriverPoints.Items.Clear()

            If comboBoxStartSeason2.SelectedIndex >= 0 Then
                startSeason = CInt(comboBoxStartSeason2.SelectedItem.ToString)
            Else
                startSeason = 1970
            End If

            If comboBoxEndSeason2.SelectedIndex >= 0 Then
                endSeason = CInt(comboBoxEndSeason2.SelectedItem.ToString)
            Else
                endSeason = 2024
            End If

            If comboBoxStartSeason2.SelectedIndex >= 0 AndAlso startSeason > endSeason Then
                MessageBox.Show("The start season must be less than the end season")
                comboBoxStartSeason2.SelectedIndex = -1
                comboBoxEndSeason2.SelectedIndex = -1
            Else

                auxDriverAttr = r.HistoryTeamsGetItsRaces(driverID, teamID, startSeason, endSeason)
                For Each auxDriver As Collection In auxDriverAttr
                    Dim GPtoRead As GP = New GP(CInt(auxDriver(2).ToString))
                    GPtoRead.ReadGP()

                    lstRacesOfDriverSeason.Items.Add(auxDriver(1).ToString)
                    lstRacesOfDriverGP.Items.Add(GPtoRead.GPName)
                    lstRacesOfDriverPosition.Items.Add(auxDriver(3).ToString)
                    lstRacesOfDriverPoints.Items.Add(auxDriver(4).ToString)
                Next
            End If

        End If
    End Sub
End Class