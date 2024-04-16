Public Class frmSeasons
    Private contract As Contract
    Private seasonYear As Integer
    Private numberTeams As Integer
    Private numTeamsInserted As Integer ' Number of teams inserted 
    Private teamsList As New List(Of String)() ' List to store team names fetched from database
    Private driversList As New List(Of String)() ' List to store driver names fetched from database
    Private GPsList As New List(Of String)() ' List to store GP names fetched from database
    Public ReadOnly Property TeDAO As TeamDAO
    Public ReadOnly Property DrDAO As DriverDAO

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
        btnInsert.Enabled = False
        btnDone.Enabled = False

        ' Initialize combo box with integers from 5 to 10
        For i As Integer = 5 To 10
            selectMinBox.Items.Add(i)
            selectMaxBox.Items.Add(i)
        Next
    End Sub
    Private Sub LstSeasonTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeasons.SelectedIndexChanged
        Try
            If lstSeasons.SelectedIndex > 0 Then
                contract = New Contract(Integer.Parse(txtNumberOfGPs.Text), seasonYear, Integer.Parse(lblDriver2.Text), Integer.Parse(lblDriver2.Text))
                contract.ReadContract()
                txtNumberOfGPs.Text = contract.Team.ToString()
                seasonYear = contract.Season
                lblDriver1.Text = contract.Driver1.ToString()
                lblDriver2.Text = contract.Driver2.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnGenerateSeasonInfo.Click
        Try
            ' Obtener el año ingresado por el usuario
            seasonYear = Integer.Parse(txtSeasonYear.Text)
            ' Verificar si el año está dentro del rango permitido
            If seasonYear < 1974 OrElse seasonYear > 2024 Then
                Throw New Exception("The selected year must be between 1974 and 2024.")
            End If
            If numberTeams < 5 AndAlso numberTeams > 10 Then
                Throw New Exception("The selected value must be between 5 and 10.")
            End If

            txtNumberOfGPs.Enabled = True
            lblDriver1.Enabled = True
            lblDriver2.Enabled = True
            btnClear.Enabled = True
            btnInsert.Enabled = True
            btnDone.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Si hay un error, deshabilita los controles adicionales
            btnClear.Enabled = False
            btnInsert.Enabled = False
            btnDone.Enabled = False
        End Try
    End Sub

    Private Sub btnGenerateSeasonInfo_Click(sender As Object, e As EventArgs) Handles btnGenerateSeasonInfo.Click
        Dim minTeams As Integer
        Dim maxTeams As Integer

        Try
            ' Obtener el año ingresado por el usuario
            seasonYear = Integer.Parse(txtSeasonYear.Text)
            ' si combo box ha sido seleccionado, obtener el número de equipos
            If selectMinBox.SelectedIndex > 0 AndAlso selectMaxBox.SelectedIndex > 0 Then
                minTeams = selectMinBox.SelectedIndex
                maxTeams = selectMaxBox.SelectedIndex
            Else
                minTeams = 5
                maxTeams = 10
            End If

            ' random number of teams between minTeams and maxTeams
            numberTeams = New Random().Next(minTeams, maxTeams + 1)

            ' Verificar si el año está dentro del rango permitido
            If seasonYear < 1970 OrElse seasonYear > 2024 Then
                Throw New Exception("El año seleccionado debe estar entre 1970 y 2024.")
            End If

            ' Enable controls for selecting drivers
            lblDriver1.Enabled = True
            lblDriver2.Enabled = True

            ' Generate teams, drivers, and GPs lists from the database
            ' For demonstration purpose, I'll populate them with some dummy data
            FetchTeamsFromDatabase(numberTeams)
            FetchDriversFromDatabase(numberTeams * 2)
            FetchGPsFromDatabase()

            ' Enable controls for selecting GPs
            txtNumberOfGPs.Enabled = True
            btnClear.Enabled = True
            btnInsert.Enabled = True
            btnDone.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Si hay un error, deshabilita los controles adicionales
            txtNumberOfGPs.Enabled = False
            lblDriver2.Enabled = False
            lblDriver2.Enabled = False
            btnClear.Enabled = False
            btnInsert.Enabled = False
            btnDone.Enabled = False
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            ' Verificar que no se hayan insertado todos los equipos deseados
            If numTeamsInserted < numberTeams Then
                ' Insertar el contrato (You need to implement this method)
                ' For demonstration purpose, I'll just show the selected drivers
                MessageBox.Show($"Equipo {numTeamsInserted + 1}: {lblDriver2.Text} y {lblDriver2.Text}")

                ' Incrementar el contador de equipos insertados
                numTeamsInserted += 1

                ' Mostrar mensaje si se han insertado todos los equipos deseados
                If numTeamsInserted = numberTeams Then
                    MessageBox.Show("Todos los equipos han sido insertados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Deshabilitar las cajas de texto y el botón de inserción
                    txtNumberOfGPs.Enabled = False
                    btnInsert.Enabled = False
                Else
                    ' Limpiar las cajas de texto para insertar el siguiente equipo
                    txtNumberOfGPs.Clear()
                    lblDriver2.Text = ""
                    lblDriver2.Text = ""
                    txtNumberOfGPs.Focus() ' Poner el foco en el campo de equipo para la siguiente inserción
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to get random teams from the database, the input is the number of teams to generate 
    Private Sub FetchTeamsFromDatabase(ByVal numTeams As Integer)
        TeDAO.ReadAll()
        Dim i As Integer
        Dim team As Team
        Dim teams As Collection
        Dim aux As Collection
        Dim random As New Random()

        ' Clear the list before adding new teams
        teamsList.Clear()

        ' Get all teams from the database
        teams = TeDAO.Teams

        ' If there are teams in the database
        If teams.Count > 0 Then
            ' Get random teams from the database
            For i = 0 To numTeams - 1
                aux = DirectCast(teams(random.Next(teams.Count)), Collection)
                team = New Team(Integer.Parse(aux(1).ToString), aux(2).ToString, Integer.Parse(aux(3).ToString), Date.Parse(aux(4).ToString))
                team.ReadTeam()
                teamsList.Add(team.TeamName)
            Next
        End If


    End Sub

    ' Method to fetch drivers from the database (You need to implement this method)
    Private Sub FetchDriversFromDatabase(ByVal numDrivers As Integer)
        DrDAO.ReadAll()
        Dim i As Integer
        Dim driver As Driver
        Dim drivers As Collection
        Dim aux As Collection
        Dim random As New Random()

        ' Clear the list before adding new drivers
        driversList.Clear()

        ' Get all drivers from the database
        drivers = DrDAO.Drivers

        ' If there are drivers in the database
        If drivers.Count > 0 Then
            ' Get random drivers from the database
            For i = 0 To numDrivers - 1
                aux = DirectCast(drivers(random.Next(drivers.Count)), Collection)
                driver = New Driver(Integer.Parse(aux(1).ToString), aux(2).ToString, aux(3).ToString, Integer.Parse(aux(4).ToString))
                driver.ReadDriver()
                driversList.Add(driver.DriverName)
            Next
        End If
    End Sub

    ' Method to fetch GPs from the database (You need to implement this method)
    Private Sub FetchGPsFromDatabase()
        ' Dummy data for demonstration purpose
        GPsList.Add("GP 1")
        GPsList.Add("GP 2")
        ' Add more GPs as per your database retrieval logic
    End Sub
    Private Sub txtNumberteams_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        ' Cerrar el formulario
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub txtNumberOfGPs_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfGPs.TextChanged

    End Sub


End Class

