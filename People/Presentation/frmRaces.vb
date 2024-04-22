Public Class frmRaces
    Private season As Season



    Private Sub btnPreviousfrm_Click(sender As Object, e As EventArgs) Handles btnPreviousfrm.Click
        'Cerrar este formulario
        Me.Close()

    End Sub
    Private Sub frmRaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            'Borrar el texto de todas las labels de drivers
            lblDriver1.Text = String.Empty
            lblDriver2.Text = String.Empty
            lblDriver3.Text = String.Empty
            lblDriver4.Text = String.Empty
            lblDriver5.Text = String.Empty
            lblDriver6.Text = String.Empty


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
                'Meter los nombres de los GPs en la lista de GPs
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
                Dim gpName As String = lstGPs.SelectedItem.ToString()
                Dim selectedGP As GP = season.ListGPs.Cast(Of GP)().FirstOrDefault(Function(gp) gp.GPName = gpName)

                If selectedGP IsNot Nothing Then
                    ShowRandomDrivers(season)
                End If
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
            For Each team As Team In selectedSeason.ListTeams
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
            Dim labels() As Label = {lblDriver1, lblDriver2, lblDriver3, lblDriver4, lblDriver5, lblDriver6}
            For i As Integer = 0 To Math.Min(driverNames.Count - 1, labels.Length - 1)
                labels(i).Text = driverNames(i)
            Next

            ' Limpiar los labels restantes si no hay suficientes conductores para llenar todas las posiciones
            For i As Integer = Math.Min(driverNames.Count, labels.Length) To labels.Length - 1
                labels(i).Text = String.Empty
            Next
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

