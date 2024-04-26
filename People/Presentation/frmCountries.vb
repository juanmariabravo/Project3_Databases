
Public Class frmCountries
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        frmFormulaOne.Enabled = True
        ' Close the current form
        Me.Close()
    End Sub

    Private Sub frmCountries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim country As New Country
            country.ReadAllCountries()

            lstCountries.Items.Clear()
            For Each country In country.CouDAO.Countries
                lstCountries.Items.Add(country.CountryID & " " & country.CountryName)

            Next
            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnClear.Enabled = True
            txtCountryID.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCountries.SelectedIndexChanged
        Try
            If lstCountries.SelectedIndex >= 0 Then ' to avoid exception when no item is selected
                Dim country As New Country(lstCountries.SelectedItem.ToString.Substring(0, 3))
                country.ReadCountry()
                txtCountryName.Text = country.CountryName ' important this line is before the next one: when changing the name, the id is automatically generated
                txtCountryID.Text = country.CountryID.ToString() ' but sometimes, the id is not the first 3 letters of the name
                txtCountryPopulation.Text = Country.CountryPopulation.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' when the name text  box is changed, the id is automatically generated
    Private Sub txtCountryName_TextChanged(sender As Object, e As EventArgs) Handles txtCountryName.TextChanged
        Try
            Dim automatic_id As String = ""
            ' if the id is disabled (no attemps to insert manually), the automatic id is written in the id field
            If txtCountryID.Enabled = False AndAlso txtCountryName.TextLength > 2 Then
                ' the automatic id is the name of the country 3 first letters in uppercase
                automatic_id = txtCountryName.Text.Substring(0, 3).ToUpper
                txtCountryID.Text = automatic_id
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim country As Country

        Try
            country = New Country(txtCountryID.Text)
            country.CountryName = txtCountryName.Text
            country.CountryPopulation = Integer.Parse(txtCountryPopulation.Text)

            country.InsertCountry()

            txtCountryID.Enabled = False

            ' update the list
            lstCountries.Items.Clear()
            country.ReadAllCountries()
            For Each country In country.CouDAO.Countries
                lstCountries.Items.Add(country.CountryID & " " & country.CountryName)
            Next

        Catch ex As Exception
            MessageBox.Show("That ID is already used by other country! Now you can type another ID")
            txtCountryID.Enabled = True
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
                lstCountries.Items.Add(country.CountryID & " " & country.CountryName)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Console.WriteLine("Delete button clicked. With ID: " & txtCountryID.Text)
        Try
            Dim country As New Country(txtCountryID.Text)
            country.DeleteCountry()
            lstCountries.Items.Clear()
            country.ReadAllCountries()
            For Each country In country.CouDAO.Countries
                lstCountries.Items.Add(country.CountryID & " " & country.CountryName)
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

    Private Sub txtCountryID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountryID.KeyPress
        ' Verify if the character entered is a number or if it is the backspace key (Backspace)
        If Char.IsDigit(e.KeyChar) Then
            ' If it is a number, cancel the KeyPress event (does not allow writing numbers)
            e.Handled = True
        End If
        ' Check if the length of the text in the TextBox is equal to 3 and the character is not a backspace key
        If txtCountryID.TextLength = 3 AndAlso e.KeyChar <> ControlChars.Back Then
            ' if there are already 3 digits, cancel the KeyPress event (does not allow writing more), but if it is a backspace key, it allows deleting
            e.Handled = True
        End If
    End Sub

    ' Enable main form if this form is closed
    Private Sub frmCountries_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmFormulaOne.Enabled = True
    End Sub
End Class