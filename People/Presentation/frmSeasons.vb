Public Class frmSeasons
    Private contract As Contract
    Private contractYear As Integer
    Private numberTeams As Integer
    Private numTeamsInserted As Integer = 0
    Private Sub btnMainMenuSeasons_Click(sender As Object, e As EventArgs) Handles btnMainMenuSeasons.Click
        'Cerrar este formulario
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub frmCountries_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Reactivar el formulario original
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub frmSeasons_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtTeam.Enabled = False
        txtDriver1.Enabled = False
        txtDriver2.Enabled = False
        btnClear.Enabled = False
        btnInsert.Enabled = False
        btnDone.Enabled = False


    End Sub
    Private Sub LstSeasonTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstSeasonTeams.SelectedIndexChanged
        Try
            If LstSeasonTeams.SelectedIndex > 0 Then
                contract = New Contract(Integer.Parse(txtTeam.Text), contractYear, Integer.Parse(txtDriver1.Text), Integer.Parse(txtDriver2.Text))
                contract.ReadContract()
                txtTeam.Text = contract.Team.ToString()
                contractYear = contract.Season
                txtDriver1.Text = contract.Driver1.ToString()
                txtDriver2.Text = contract.Driver2.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            ' Obtener el año ingresado por el usuario
            contractYear = Integer.Parse(txtYear.Text)
            numberTeams = Integer.Parse(txtNumberteams.Text)
            ' Verificar si el año está dentro del rango permitido
            If contractYear < 1974 OrElse contractYear > 2024 Then
                Throw New Exception("The selected year must be between 1974 and 2024.")
            End If
            If numberTeams < 5 AndAlso numberTeams > 10 Then
                Throw New Exception("The selected value must be between 5 and 10.")
            End If

            txtTeam.Enabled = True
            txtDriver1.Enabled = True
            txtDriver2.Enabled = True
            btnClear.Enabled = True
            btnInsert.Enabled = True
            btnDone.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Si hay un error, deshabilita los controles adicionales
            txtTeam.Enabled = False
            txtDriver1.Enabled = False
            txtDriver2.Enabled = False
            btnClear.Enabled = False
            btnInsert.Enabled = False
            btnDone.Enabled = False
        End Try
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            ' Verificar que no se hayan insertado todos los equipos deseados
            If numTeamsInserted < numberTeams Then
                ' Insertar el contrato
                contract = New Contract(Integer.Parse(txtTeam.Text), contractYear, Integer.Parse(txtDriver1.Text), Integer.Parse(txtDriver2.Text))
                contract.InsertContract()

                ' Incrementar el contador de equipos insertados
                numTeamsInserted += 1

                ' Mostrar mensaje si se han insertado todos los equipos deseados
                If numTeamsInserted = numberTeams Then
                    MessageBox.Show("Todos los equipos han sido insertados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Deshabilitar las cajas de texto y el botón de inserción
                    txtTeam.Enabled = False
                    txtDriver1.Enabled = False
                    txtDriver2.Enabled = False
                    btnInsert.Enabled = False
                Else
                    ' Limpiar las cajas de texto para insertar el siguiente equipo
                    txtTeam.Clear()
                    txtDriver1.Clear()
                    txtDriver2.Clear()
                    txtTeam.Focus() ' Poner el foco en el campo de equipo para la siguiente inserción
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class

