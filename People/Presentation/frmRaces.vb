Imports Org.BouncyCastle.Bcpg.OpenPgp

Public Class frmRaces
    Private season As Season



    Private Sub btnPreviousfrm_Click(sender As Object, e As EventArgs) Handles btnPreviousfrm.Click
        'Cerrar este formulario
        Me.Close()

    End Sub
    Private Sub frmRaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            season = New Season()
            season.ReadAllSeasons()
            lstSeasons.Items.Clear()
            For Each s As Season In season.SeasonDAO.Seasons
                lstSeasons.Items.Add(s.SeasonID)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LstSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeasons.SelectedIndexChanged
        Try

            If lstSeasons.SelectedIndex >= 0 AndAlso lstSeasons.SelectedItems.Count = 1 Then
                Dim season As New Season()
                Dim aux As Collection
                season.SeasonID = Integer.Parse(lstSeasons.SelectedItem.ToString)
                season.ReadSeason()
                lstGPs.Items.Clear()
                lstGPs.Enabled = True

                For Each aux In season.ListGPs
                    lstGPs.Items.Add(aux(2).ToString)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstGPs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGPs.SelectedIndexChanged
        Try
            If lstGPs.SelectedIndex >= 0 AndAlso lstGPs.SelectedItems.Count = 1 Then
                Dim auxGP As New Collection
                Dim gpName As String = lstGPs.SelectedItem.ToString()
                Dim selectedGP As New GP
                'Buscar el GP seleccionado en la lista de GPs de la temporada
                For Each auxGP In season.ListGPs
                    If gpName = auxGP(2).ToString Then
                        selectedGP.GPID = Integer.Parse(auxGP(1).ToString)
                        selectedGP.ReadGP()
                        Exit For
                    End If
                    If selectedGP IsNot Nothing Then
                        ShowRandomDrivers(season)
                    End If
                Next

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ShowRandomDrivers(ByVal selectedSeason As Season)
        Try
            ' Crear una lista para almacenar los nombres de los conductores
            Dim driverNames As New List(Of String)()

            ' Obtener todos los conductores asignados a la temporada seleccionada
            For Each team As Team In selectedSeason.ListContracts
                For Each contract As Contract In team.Contracts
                    If contract.Season = selectedSeason.SeasonID Then
                        ' Leer el nombre del primer conductor y agregarlo a la lista
                        Dim driver1Name As String = GetDriverName(contract.Driver1)
                        driverNames.Add(driver1Name)

                        ' Leer el nombre del segundo conductor y agregarlo a la lista
                        Dim driver2Name As String = GetDriverName(contract.Driver2)
                        driverNames.Add(driver2Name)

                    End If
                Next
            Next

            ' Asignar conductores aleatorios a los labels
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Function GetDriverName(ByVal driverID As Integer) As String
        Dim driver As New Driver()
        driver.DriverID = driverID
        driver.ReadDriver()
        Return $"{driver.DriverName} {driver.DriverSurname}"
    End Function


End Class

