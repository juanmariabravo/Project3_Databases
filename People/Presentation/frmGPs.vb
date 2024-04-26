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
                lstGPs.Items.Add(gp.GPID)
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
                lstGPs.Items.Add(gp.GPID)
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
                lstGPs.Items.Add(gp.GPID)
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
        frmFormulaOne.Enabled = True
        ' Close the current form
        Me.Close()
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        ' Check if the entered character is a number or if it is the backspace key (Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            ' If it is not a number and it is not the Backspace key, cancel the KeyPress event
            e.Handled = True
        End If
        ' Check if the length of the text in the TextBox is equal to 4 and the character is not a backspace key
        If txtID.TextLength = 4 AndAlso e.KeyChar <> ControlChars.Back Then
            ' If there are already 4 digits and it is not a backspace key, cancel the KeyPress event
            e.Handled = True
        End If
    End Sub

    ' Enable main form if this form is closed
    Private Sub FrmGPs_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmFormulaOne.Enabled = True
    End Sub
End Class

