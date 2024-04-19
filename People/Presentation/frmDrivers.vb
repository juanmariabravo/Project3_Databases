Public Class frmDrivers
    Private driver As Driver

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'Cerrar este formulario
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub
    Private Sub frmDrivers_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Reactivar el formulario original
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub FrmDrivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim driver As New Driver
            driver.ReadAllDrivers()

            lstDrivers.Items.Clear()
            For Each driver In driver.DrvDAO.Drivers
                lstDrivers.Items.Add(driver.DriverName & " " & driver.DriverSurname)
            Next

            btnAddDriver.Enabled = True
            btnUpdateDriver.Enabled = True
            btnDeleteDriver.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstDrivers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDrivers.SelectedIndexChanged
        Try
            If lstDrivers.SelectedIndex > 0 Then
                driver = New Driver(Integer.Parse(lstDrivers.SelectedItem.ToString))
                driver.ReadDriver()
                txtBxDriverID.Text = driver.DriverID.ToString()
                txtBxDriverName.Text = driver.DriverName
                txtBxDriverSurname.Text = driver.DriverSurname
                txtBxDriverCountry.Text = driver.DriverCountry.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAddDriver_Click(sender As Object, e As EventArgs) Handles btnAddDriver.Click
        Try
            driver = New Driver(Integer.Parse(txtBxDriverID.Text))
            driver.DriverName = txtBxDriverName.Text
            driver.DriverSurname = txtBxDriverSurname.Text
            driver.DriverCountry = txtBxDriverCountry.Text
            driver.InsertDriver()
            lstDrivers.Items.Clear()
            driver.ReadAllDrivers()
            For Each driver In driver.DrvDAO.Drivers
                lstDrivers.Items.Add(driver.DriverID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteDriver_Click(sender As Object, e As EventArgs) Handles btnDeleteDriver.Click
        Try
            driver = New Driver(Integer.Parse(txtBxDriverID.Text))
            driver.DeleteDriver()
            lstDrivers.Items.Clear()
            driver.ReadAllDrivers()
            For Each driver In driver.DrvDAO.Drivers
                lstDrivers.Items.Add(driver.DriverID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateDriver_Click(sender As Object, e As EventArgs) Handles btnUpdateDriver.Click
        Try
            driver = New Driver(Integer.Parse(txtBxDriverID.Text))
            driver.DriverName = txtBxDriverName.Text
            driver.DriverSurname = txtBxDriverSurname.Text
            driver.DriverCountry = txtBxDriverCountry.Text
            driver.UpdateDriver()
            lstDrivers.Items.Clear()
            driver.ReadAllDrivers()
            For Each driver In driver.DrvDAO.Drivers
                lstDrivers.Items.Add(driver.DriverID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearDriverFields_Click(sender As Object, e As EventArgs) Handles btnClearDriverFields.Click
        txtBxDriverID.Text = ""
        txtBxDriverName.Text = ""
        txtBxDriverSurname.Text = ""
        txtBxDriverCountry.Text = ""
    End Sub


End Class
