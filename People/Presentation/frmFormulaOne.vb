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
            btnConnectDB.Enabled = False
            btnOpenRaces.Enabled = True
            btnOpenClassifications.Enabled = True
            btnOpenHistory.Enabled = True
            btnConnectDB.Text = "Connected to the database:)"
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

    Private Sub frmFormulaOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOpenClassifications_Click(sender As Object, e As EventArgs) Handles btnOpenClassifications.Click
        Dim frmClass As New frmWinners()
        Me.Enabled = False
        frmClass.Show()
    End Sub

    Private Sub btnOpenHistory_Click(sender As Object, e As EventArgs) Handles btnOpenHistory.Click
        Dim frmHis As New frmHistory()
        Me.Enabled = False
        frmHis.Show()
    End Sub

    Private Sub btnOpenRaces_Click(sender As Object, e As EventArgs) Handles btnOpenRaces.Click
        Dim frmRaces As New frmRaces()
        Me.Enabled = False
        frmRaces.Show()
    End Sub
End Class