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
            If lstTeams.SelectedIndex >= 0 Then
                te = New Team(Integer.Parse(txtID.Text))
                te.TeamName = txtName.Text
                te.TeamCountry = txtcountryid.Text
                te.CreationDate = Date.Parse(txtCreationDate.Text)

                te.InsertTeam()
                lstTeams.Items.Clear()
                te.ReadAllTeams()
            End If

            For Each te In te.TeDAO.Teams
                lstTeams.Items.Add(te.TeamID & " " & te.TeamName)
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
                lstTeams.Items.Add(te.TeamID & " " & te.TeamName)
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
                lstTeams.Items.Add(te.TeamID & " " & te.TeamName)
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
        'Cerrar este formulario
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub
    Private Sub frmTeams_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
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