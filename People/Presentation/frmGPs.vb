Public Class frmGPs
    Private gp As GP

    Private Sub FrmGPs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gp = New GP
            gp.ReadAllGPs()

            lstGPs.Items.Clear()
            For Each gp In gp.GpDAO.GPs
                lstGPs.Items.Add(gp.GPID & " " & gp.GPName)
            Next

            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LstGPs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGPs.SelectedIndexChanged
        Try
            If lstGPs.SelectedIndex >= 0 Then
                Dim tokens As String() = lstGPs.SelectedItem.ToString.Split(" "c)
                gp = New GP(Integer.Parse(tokens(0)))
                gp.ReadGP()
                txtID.Text = gp.GPID.ToString
                txtName.Text = gp.GPName
                txtcountryid.Text = gp.Countryid.ToString
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            gp = New GP(Integer.Parse(txtID.Text))
            gp.GPName = txtName.Text
            gp.Countryid = txtcountryid.Text
            gp.InsertGP()
            lstGPs.Items.Clear()
            gp.ReadAllGPs()
            For Each gp In gp.GpDAO.GPs
                lstGPs.Items.Add(gp.GPID & " " & gp.GPName)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            gp = New GP(Integer.Parse(txtID.Text))
            gp.GPName = txtName.Text
            gp.Countryid = txtcountryid.Text
            gp.UpdateGP()
            lstGPs.Items.Clear()
            gp.ReadAllGPs()
            For Each gp In gp.GpDAO.GPs
                lstGPs.Items.Add(gp.GPID & " " & gp.GPName)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            gp = New GP(Integer.Parse(txtID.Text))
            gp.DeleteGP()
            lstGPs.Items.Clear()
            gp.ReadAllGPs()
            For Each gp In gp.GpDAO.GPs
                lstGPs.Items.Add(gp.GPID & " " & gp.GPName)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Text = ""
        txtName.Text = ""
        txtcountryid.Text = ""
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'Cerrar este formulario
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub frmGPs_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Reactivar el formulario original
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        ' Verifica si el carácter ingresado es un número o si es la tecla de retroceso (Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si no es un número y no es la tecla Backspace, cancela el evento KeyPress
            e.Handled = True
        End If
        ' Verifica si la longitud del texto en el TextBox es igual a 4 y el carácter no es una tecla de retroceso
        If txtID.TextLength = 4 AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si ya hay 4 dígitos y no es una tecla de retroceso, cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub
End Class

