Public Class frmCountries
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'Cerrar este formulario
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub frmCountries_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Reactivar el formulario original
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub frmCountries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim country As New Country
            country.ReadAllCountries()

            lstCountries.Items.Clear()
            For Each country In country.CouDAO.Countries
                lstCountries.Items.Add(country.CountryID)

            Next

            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnClear.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCountries.SelectedIndexChanged
        Try
            If lstCountries.SelectedIndex > 0 Then
                Dim country As New Country(lstCountries.SelectedItem.ToString)
                country.ReadCountry()
                txtCountryID.Text = country.CountryID.ToString()
                txtCountryName.Text = country.CountryName
                txtCountryPopulation.Text = country.CountryPopulation.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim country As New Country(txtCountryID.Text)
            country.CountryName = txtCountryName.Text
            country.CountryPopulation = Integer.Parse(txtCountryPopulation.Text)
            country.InsertCountry()
            lstCountries.Items.Clear()
            country.ReadAllCountries()
            For Each country In country.CouDAO.Countries
                lstCountries.Items.Add(country.CountryID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim country As New Country(txtCountryID.Text)
            country.CountryName = txtCountryName.Text
            country.CountryPopulation = Integer.Parse(txtCountryPopulation.Text)
            country.UpdateCountry()
            lstCountries.Items.Clear()
            country.ReadAllCountries()
            For Each country In country.CouDAO.Countries
                lstCountries.Items.Add(country.CountryID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim country As New Country(txtCountryID.Text)
            country.DeleteCountry()
            lstCountries.Items.Clear()
            country.ReadAllCountries()
            For Each country In country.CouDAO.Countries
                lstCountries.Items.Add(country.CountryID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCountryID.Text = ""
        txtCountryName.Text = ""
        txtCountryPopulation.Text = ""
    End Sub

End Class