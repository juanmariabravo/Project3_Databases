Public Class frmGPs
    Private gp As GP

    Private Sub FrmGPs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gp = New GP
            gp.ReadAllGPs()

            lstGPs.Items.Clear()
            For Each gp In gp.GpDAO.GPs
                lstGPs.Items.Add(gp.GPName)
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
            gp = New GP(Integer.Parse(lstGPs.SelectedItem.ToString), "", gp.Countryid)
            gp.ReadGP()
            txtID.Text = gp.GPID.ToString
            txtName.Text = gp.GPName
            txtcountryid.Text = gp.Countryid.ToString

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            gp = New GP(Integer.Parse(txtID.Text), txtName.Text, Integer.Parse(txtcountryid.Text))
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
            gp = New GP(Integer.Parse(txtID.Text), txtName.Text, Integer.Parse(txtcountryid.Text))
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
            gp = New GP(Integer.Parse(txtID.Text), txtName.Text, Integer.Parse(txtcountryid.Text))
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
        'Cerrar este formulario
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub frmGPs_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Reactivar el formulario original
        frmFormulaOne.Enabled = True
    End Sub
End Class

