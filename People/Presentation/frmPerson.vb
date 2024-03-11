﻿Public Class frmPersons
    Private p As Person
    Private db As DBBroker

    Private Sub BtnOpenDB_Click(sender As Object, e As EventArgs) Handles btnOpenDB.Click
        Try
            p = New Person
            p.ReadAllPersons()
            MessageBox.Show("Connection opened", "DB Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' button activation
            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            ' initialize the listbox
            lstPersons.Items.Clear()
            For Each p In p.PerDAO.Persons
                lstPersons.Items.Add(p.PersonID)
            Next
        Catch ex As Exception
            MessageBox.Show("Connection not opened " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub LstPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPersons.SelectedIndexChanged
        Try
            p = New Person(lstPersons.SelectedItem.ToString)
            p.ReadPerson()
            txtID.Text = p.PersonID
            txtName.Text = p.PersonName
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            p = New Person(txtID.Text)
            p.PersonName = txtName.Text
            p.InsertPerson()
            lstPersons.Items.Clear()
            p.ReadAllPersons()
            For Each p In p.PerDAO.Persons
                lstPersons.Items.Add(p.PersonID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            p = New Person(txtID.Text)
            p.PersonName = txtName.Text
            p.UpdatePerson()
            lstPersons.Items.Clear()
            p.ReadAllPersons()
            For Each p In p.PerDAO.Persons
                lstPersons.Items.Add(p.PersonID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            p = New Person(lstPersons.SelectedItem.ToString)
            p.DeletePerson()
            lstPersons.Items.Clear()
            p.ReadAllPersons()
            For Each p In p.PerDAO.Persons
                lstPersons.Items.Add(p.PersonID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Text = ""
        txtName.Text = ""
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class