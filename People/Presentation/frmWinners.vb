Public Class frmWinners
    Private Sub frmWinners_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Intialize the ComboBox with the seasons
        Dim s As Season
        s = New Season
        s.ReadAllSeasons()
        For Each s In s.SeasonDAO.Seasons
            comboBoxSeasons.Items.Add(s.SeasonID)
        Next

        ' Initialize the ComboBox with the countries
        Dim c As Country
        c = New Country
        c.ReadAllCountries()
        For Each c In c.CouDAO.Countries
            comboBoxCountries.Items.Add(c.CountryID + " - " + c.CountryName)
        Next

        ' Call for the creation of the views
        Dim r As Report
        r = New Report
        r.LoadViews()


    End Sub

    Private Sub btnMainMenuSeasons_Click(sender As Object, e As EventArgs) Handles btnMainMenuSeasons.Click
        frmFormulaOne.Enabled = True
        Me.Close()
    End Sub

    ' Enable main form if this form is closed
    Private Sub frmWinners_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub comboBoxSeasons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxSeasons.SelectedIndexChanged
        ' Clear the listboxes
        lstDriversClassNameSur.Items.Clear()
        lstDriversClassPoints.Items.Clear()
        lstTeamsClassificationPoints.Items.Clear()
        lstTeamsClassificationTeams.Items.Clear()
        Try
            ' Get the classification of drivers
            Dim r As Report
            r = New Report
            Dim c As Collection
            Dim d As Driver
            Dim t As Team
            ' Call the method GetClassificationDrivers from the class Report that access the database and returns the classification of drivers
            c = r.GetClassificationDrivers(Integer.Parse(comboBoxSeasons.SelectedItem.ToString))
            If c.Count = 0 Then
                MessageBox.Show("No drivers in the classification")
                Exit Sub
            End If

            For Each driver_row As Collection In c

                d = New Driver(Integer.Parse(driver_row(1).ToString))
                d.ReadDriver()
                lstDriversClassNameSur.Items.Add(d.DriverName & " " & d.DriverSurname)
                lstDriversClassPoints.Items.Add(Integer.Parse(driver_row(2).ToString()))
            Next

            ' Get the classification of teams
            c = r.GetClassificationTeams(Integer.Parse(comboBoxSeasons.SelectedItem.ToString))
            If c.Count = 0 Then
                MessageBox.Show("No teams in the classification")
                Exit Sub
            End If
            For Each team_row As Collection In c
                t = New Team(Integer.Parse(team_row(1).ToString))
                t.ReadTeam()
                lstTeamsClassificationTeams.Items.Add(t.TeamName)
                lstTeamsClassificationPoints.Items.Add(Integer.Parse(team_row(2).ToString()))
            Next
            lblWorldDriverChampions.Text = lstDriversClassNameSur.Items(0).ToString
            lblWorldTeamChampion.Text = lstTeamsClassificationTeams.Items(0).ToString
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub comboBoxCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxCountries.SelectedIndexChanged
        ' Clear the listboxes
        lstWCwinner.Items.Clear()
        lstWCseason.Items.Clear()
        lstWCwonraces.Items.Clear()
        lstWCteam.Items.Clear()
        lstWCpoints.Items.Clear()

        Try
            ' Get the winners of the seasons
            Dim r As Report
            r = New Report
            Dim c As Collection
            Dim d As Driver
            Dim couID As String
            couID = comboBoxCountries.SelectedItem.ToString.Split(" "c)(0)
            ' Call the WorldChampionshipGetAllSeasonsWinners method from the class Report that access the database and returns the winners of the seasons from a country
            c = r.WorldChampionshipGetAllSeasonsWinners(couID)
            If c.Count = 0 Then
                MessageBox.Show("There are no winners from that country!")
                Exit Sub
            End If

            For Each winner_row As Collection In c

                d = New Driver(Integer.Parse(winner_row(1).ToString))
                d.ReadDriver()
                lstWCwinner.Items.Add(d.DriverName & " " & d.DriverSurname)
                lstWCseason.Items.Add(Integer.Parse(winner_row(2).ToString()))
                lstWCteam.Items.Add(Integer.Parse(winner_row(3).ToString()))
                lstWCpoints.Items.Add(Integer.Parse(winner_row(4).ToString()))
                lstWCwonraces.Items.Add(Integer.Parse(winner_row(5).ToString()))
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class