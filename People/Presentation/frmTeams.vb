Public Class frmTeams
    Private te As Team

    Private Sub FrmTeams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            te = New Team()
            te.ReadAllTeams()

            lstTeams.Items.Clear()
            For Each te In te.TeDAO.Teams
                lstTeams.Items.Add(te.TeamID & " " & te.TeamName)
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
            If lstTeams.SelectedIndex >= 0 Then
                Dim tokens As String() = lstTeams.SelectedItem.ToString.Split(" "c)
                te = New Team(Integer.Parse(tokens(0)))
                te.ReadTeam()
                txtID.Text = te.TeamID.ToString
                txtName.Text = te.TeamName
                txtcountryid.Text = te.TeamCountry.ToString
                txtCreationDate.Text = te.CreationDate.ToShortDateString
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If lstTeams.SelectedIndex > 0 Then
                te = New Team(Integer.Parse(txtID.Text))
                te.TeamName = txtName.Text
                te.TeamCountry = txtcountryid.Text
                te.CreationDate = Date.Parse(txtCreationDate.Text)

                te.InsertTeam()
                lstTeams.Items.Clear()
                te.ReadAllTeams()
            End If

            For Each te In te.TeDAO.Teams
                lstTeams.Items.Add(te.TeamID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            te = New Team(Integer.Parse(txtID.Text))
            te.TeamName = txtName.Text
            te.TeamCountry = txtcountryid.Text
            te.CreationDate = Date.Parse(txtCreationDate.Text)

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
            te = New Team(Integer.Parse(txtID.Text))
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
        txtCreationDate.Text = ""
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        frmFormulaOne.Enabled = True
        ' Close the current form
        Me.Close()
    End Sub

    ' Enable main form if this form is closed
    Private Sub frmTeams_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmFormulaOne.Enabled = True
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
End Class