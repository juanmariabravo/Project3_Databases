
Public Class frmCountries
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' Close the current form
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub frmCountries_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Reopen the main menu form
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
            '' if the id is disabled (no attemps to insert manually), the automatic id is assigned
            If txtCountryID.Enabled = False Then
                '' the automatic id is the name of the country 3 first letters in uppercase
                automatic_id = txtCountryName.Text.Substring(0, 3).ToUpper
                txtCountryID.Text = automatic_id
            End If



            ' check if the automatic id is already in the list, if so, we show a message allowing the user to change the id manually
            ' and we cancel the current insertion

            For Each item As String In lstCountries.Items
                If item.Substring(0, Math.Min(3, item.Length)).Equals(txtCountryID.Text.ToUpper()) Then
                    isAutomaticIDInList = True
                    Exit For ' Exit the loop early if a match is found.
                End If
            Next

            If isAutomaticIDInList Then
                ' message box that allows inserting the id manually
                MessageBox.Show("The automatic id is already In the list, please insert another ID for the country")
                txtCountryID.Enabled = True
                ' ElseIf length of string is not 3
            ElseIf txtCountryID.TextLength <> 3 Then
                MessageBox.Show("The ID must be 3 characters long")

            Else
                Dim country As New Country(txtCountryID.Text)
                country.CountryName = txtCountryName.Text
                country.CountryPopulation = Integer.Parse(txtCountryPopulation.Text)

                txtCountryID.Enabled = False '' we disable the id field again in case of manual insertion
                '' check if the automatic id is already in the list, if so, we show a message allowing the user to change the id manually

                country.InsertCountry()
                '' update the list
                lstCountries.Items.Clear()
                country.ReadAllCountries()
                For Each country In country.CouDAO.Countries
                    lstCountries.Items.Add(country.CountryID & " " & country.CountryName)
                Next
            End If

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
End Class