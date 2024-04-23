Public Class frmFormulaOne
    Private c As Country
    Private db As DBBroker

    Private Sub btnConnectDB_Click(sender As Object, e As EventArgs) Handles btnConnectDB.Click
        Try
            c = New Country
            c.ReadAllCountries()
            MessageBox.Show("Connection opened", "DB Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnOpenGPs.Enabled = True
            BtnOpenDrivers.Enabled = True
            btnOpenTeams.Enabled = True
            btnOpenCountries.Enabled = True
            btnOpenSeasons.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Connection not opened " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub btnOpenGPs_Click(sender As Object, e As EventArgs) Handles btnOpenGPs.Click
        Dim frmGPs As New frmGPs()
        Me.Enabled = False
        frmGPs.Show()
    End Sub

    Private Sub BtnOpenDrivers_Click(sender As Object, e As EventArgs) Handles BtnOpenDrivers.Click
        Dim frmDrivers As New frmDrivers()
        Me.Enabled = False
        frmDrivers.Show()

    End Sub

    Private Sub btnOpenTeams_Click(sender As Object, e As EventArgs) Handles btnOpenTeams.Click
        Dim frmTeams As New frmTeams()
        Me.Enabled = False
        frmTeams.Show()
    End Sub
    Private Sub btnOpenCountries_Click(sender As Object, e As EventArgs) Handles btnOpenCountries.Click
        Dim frmCount As New frmCountries()
        Me.Enabled = False
        frmCount.Show()
    End Sub

    Private Sub btnOpenSeasons_Click(sender As Object, e As EventArgs) Handles btnOpenSeasons.Click
        Dim frmseas As New frmSeasons()
        Me.Enabled = False
        frmseas.Show()
    End Sub

End Class