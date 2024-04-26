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

    End Sub

    Private Sub btnMainMenuSeasons_Click(sender As Object, e As EventArgs) Handles btnMainMenuSeasons.Click
        frmFormulaOne.Enabled = True
        'Close this form
        Me.Close()
    End Sub

    ' Enable main form if this form is closed
    Private Sub frmWinners_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmFormulaOne.Enabled = True
    End Sub

End Class