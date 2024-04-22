Imports System.Windows

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
                lstCountries.Items.Add(country.CountryID & " " & country.CountryName)
            Next

            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnClear.Enabled = True
            txtCountryID.Enabled = False '' to assign the automatic id

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCountries.SelectedIndexChanged
        Try
            If lstCountries.SelectedIndex >= 0 Then
                Dim country As New Country(lstCountries.SelectedItem.ToString.Substring(0, 3))
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
        Dim automatic_id As String
        Dim isAutomaticIDInList As Boolean = False

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
                ' MessageBox.Show("The ID must be 3 characters long")

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
                lstCountries.Items.Add(country.CountryID & " " & country.CountryName)
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
        ' Verifica si el carácter ingresado es un número o si es la tecla de retroceso (Backspace)
        If Char.IsDigit(e.KeyChar) Then
            ' Si es un numero, cancela el evento KeyPress (no deja escribir números)
            e.Handled = True
        End If
        ' Verifica si la longitud del texto en el TextBox es igual a 4 y el carácter no es una tecla de retroceso
        If txtCountryID.TextLength = 3 AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si ya hay 3 dígitos, cancela el evento KeyPress (no deja escribir más), pero si es una tecla de retroceso, deja borrar
            e.Handled = True
        End If
    End Sub
End Class