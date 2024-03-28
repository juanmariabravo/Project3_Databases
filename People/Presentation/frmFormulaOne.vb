﻿Public Class frmFormulaOne
    Private c As Country
    Private db As DBBroker

    Private Sub BtnOpenDB_Click(sender As Object, e As EventArgs) Handles btnOpenDB.Click
        Try
            c = New Country
            c.ReadAllCountries()
            MessageBox.Show("Connection opened", "DB Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True

            lstCountries.Items.Clear()
            For Each c In c.CouDAO.Countries
                lstCountries.Items.Add(c.CountryID)
            Next
        Catch ex As Exception
            MessageBox.Show("Connection not opened " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub LstCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCountries.SelectedIndexChanged
        Try
            c = New Country(lstCountries.SelectedItem.ToString)
            c.ReadCountry()
            txtID.Text = c.CountryID
            txtName.Text = c.CountryName
            txtPopulation.Text = c.CountryPopulation.ToString
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            c = New Country(txtID.Text)
            c.CountryName = txtName.Text
            c.CountryPopulation = Integer.Parse(txtPopulation.Text)
            c.InsertCountry()
            lstCountries.Items.Clear()
            c.ReadAllCountries()
            For Each c In c.CouDAO.Countries
                lstCountries.Items.Add(c.CountryID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            c = New Country(txtID.Text)
            c.CountryName = txtName.Text
            c.CountryPopulation = Integer.Parse(txtPopulation.Text)
            c.UpdateCountry()
            lstCountries.Items.Clear()
            c.ReadAllCountries()
            For Each c In c.CouDAO.Countries
                lstCountries.Items.Add(c.CountryID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            c = New Country(lstCountries.SelectedItem.ToString)
            c.DeleteCountry()
            lstCountries.Items.Clear()
            c.ReadAllCountries()
            For Each c In c.CouDAO.Countries
                lstCountries.Items.Add(c.CountryID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Text = ""
        txtName.Text = ""
        txtPopulation.Text = ""
    End Sub
    Private Sub btnOpenGPs_Click(sender As Object, e As EventArgs) Handles btnOpenGPs.Click
        Dim frmGPs As New frmGPs()
        frmGPs.Show()
    End Sub

End Class