Public Class frmTeams
    Private te As Team

    Private Sub FrmTeams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            te = New Team()
            te.ReadAllTeams()

            lstTeams.Items.Clear()
            For Each te In te.TeDAO.Teams
                lstTeams.Items.Add(te.TeamID)
            Next

            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LstTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTeams.SelectedIndexChanged
        Try
            te = New Team(Integer.Parse(lstTeams.SelectedItem.ToString), te.TeamName, te.TeamCountry, te.CreationDate)
            te.ReadTeam()
            txtID.Text = te.TeamID.ToString
            txtName.Text = te.TeamName
            txtcountryid.Text = te.TeamCountry.ToString

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            te = New Team(Integer.Parse(txtID.Text), txtName.Text, Integer.Parse(txtcountryid.Text), Date.Parse(txtCreationDate.Text))
            te.InsertTeam()
            lstTeams.Items.Clear()
            te.ReadAllTeams()
            For Each te In te.TeDAO.Teams
                lstTeams.Items.Add(te.TeamID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            te = New Team(Integer.Parse(txtID.Text), txtName.Text, Integer.Parse(txtcountryid.Text), Date.Parse(txtCreationDate.Text))
            te.UpdateTeam()
            lstTeams.Items.Clear()
            te.ReadAllTeams()
            For Each te In te.TeDAO.Teams
                lstTeams.Items.Add(te.TeamID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            te = New Team(Integer.Parse(txtID.Text), txtName.Text, Integer.Parse(txtcountryid.Text), Date.Parse(txtCreationDate.Text))
            te.DeleteTeam()
            lstTeams.Items.Clear()
            te.ReadAllTeams()
            For Each te In te.TeDAO.Teams
                lstTeams.Items.Add(te.TeamID)
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
    Private Sub frmTeams_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Reactivar el formulario original
        frmFormulaOne.Enabled = True
    End Sub
End Class