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
            comboBoxDrivers.Items.Add(d.DriverID) ' + d.DriverName)
        Next

        ' Initialize the ComboBox with the teams
        Dim t As Team
        t = New Team
        t.ReadAllTeams()
        For Each t In t.TeDAO.Teams
            comboBoxTeams.Items.Add(t.TeamID) ' + t.TeamName)
        Next


    End Sub

    Private Sub btnMainMenuSeasons_Click(sender As Object, e As EventArgs) Handles btnMainMenuSeasons.Click
        'Close this form
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub
End Class