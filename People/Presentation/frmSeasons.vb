Public Class frmSeasons
    Private contract As Contract
    Private TxtBxseasonYear As Integer
    Private numberTeams As Integer
    Private numberGPs As Integer
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
        lstTeams.Enabled = False
        lstGPs.Enabled = False

        ' Initialize combo box with integers from 5 to 10
        For i As Integer = 5 To 10
            selectMinBox.Items.Add(i)
            selectMaxBox.Items.Add(i)
        Next

        ' Initialize combo box with integers from 10 to 20
        For i As Integer = 10 To 20
            CmbBoxMinGPs.Items.Add(i)
            CmbBoxMaxGPs.Items.Add(i)
        Next

    End Sub
    Private Sub LstSeasonTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeasons.SelectedIndexChanged
        Try
            If lstSeasons.SelectedIndex > 0 Then

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerateSeasonInfo_Click(sender As Object, e As EventArgs) Handles btnGenerateSeasonInfo.Click
        Dim minTeams As Integer
        Dim maxTeams As Integer
        Dim minGPs As Integer
        Dim maxGPs As Integer

        Try
            'Take all of the info for the season creation --------------------------------

            TxtBxseasonYear = Integer.Parse(txtSeasonYear.Text)
            'Checks whether the user has selected a valid range of teams
            If selectMinBox.SelectedIndex > 0 AndAlso selectMaxBox.SelectedIndex > 0 AndAlso selectMinBox.SelectedIndex < selectMaxBox.SelectedIndex Then
                minTeams = selectMinBox.SelectedIndex
                maxTeams = selectMaxBox.SelectedIndex
            Else
                minTeams = 5
                maxTeams = 10
            End If

            'Take random number of teams between minTeams and maxTeams
            numberTeams = New Random().Next(minTeams, maxTeams + 1)

            'We do the same with the controls of Combobox for the number of GPs
            If CmbBoxMinGPs.SelectedIndex > 0 AndAlso CmbBoxMaxGPs.SelectedIndex > 0 AndAlso CmbBoxMinGPs.SelectedIndex < CmbBoxMaxGPs.SelectedIndex Then
                minGPs = CmbBoxMinGPs.SelectedIndex
                maxGPs = CmbBoxMaxGPs.SelectedIndex
            Else
                minGPs = 10
                maxGPs = 20
            End If
            'Take random number of GPs between minGPs and maxGPs
            numberGPs = New Random().Next(minGPs, maxGPs + 1)

            ' Verificar si el año está dentro del rango permitido
            If TxtBxseasonYear < 1970 OrElse TxtBxseasonYear > 2024 Then
                Throw New Exception("The year selected must be between 1970 and 2024.")
            End If


            lblDriver1.Enabled = True
            lblDriver2.Enabled = True

            '
            FetchTeamsFromDatabase(numberTeams)
            FetchDriversFromDatabase(numberTeams * 2)
            FetchGPsFromDatabase()

            ' Enable controls for selecting GPs
            CmbBoxMaxGPs.Enabled = True
            CmbBoxMinGPs.Enabled = True
            btnClear.Enabled = True
            btnInsert.Enabled = True
            btnDone.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Si hay un error, deshabilita los controles adicionales
            CmbBoxMaxGPs.Enabled = False
            CmbBoxMinGPs.Enabled = False
            lblDriver2.Enabled = False
            lblDriver2.Enabled = False
            btnClear.Enabled = False
            btnInsert.Enabled = False
            btnDone.Enabled = False
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If numTeamsInserted < numberTeams Then
                MessageBox.Show($"Team {numTeamsInserted + 1}: {lblDriver2.Text} and {lblDriver2.Text}")

                ' Incrementar el contador de equipos insertados
                numTeamsInserted += 1

                ' Mostrar mensaje si se han insertado todos los equipos deseados
                If numTeamsInserted = numberTeams Then
                    MessageBox.Show("All teams have been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnInsert.Enabled = False
                Else
                    lblDriver2.Text = ""
                    lblDriver2.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to get random teams from the database, the input is the number of teams to generate 
    Private Sub FetchTeamsFromDatabase(ByVal numTeams As Integer)
        TeDAO.ReadAll()
        'Now the Team variable has stored all Teams in "Teams" collection, which now contain its contracts asociated to it

        Dim i As Integer
        Dim team As Team
        Dim teams As Collection
        Dim aux As Collection
        Dim random As New Random()

        ' Clear the list before adding new teams
        teamsList.Clear()

        'All teams from the database
        teams = TeDAO.Teams

        'If there are teams in the database
        If teams.Count > 0 Then
            'Get random teams from the database
            'For i = 0 To numTeams - 1
            'aux = DirectCast(teams(random.Next(teams.Count)), Collection)
            'team = New Team(Integer.Parse(aux(1).ToString), aux(2).ToString, Integer.Parse(aux(3).ToString), Date.Parse(aux(4).ToString))
            'team.ReadTeam()
            'teamsList.Add(team.TeamName)
            'Next
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

    Private Sub txtNumberOfGPs_TextChanged(sender As Object, e As EventArgs)

    End Sub


End Class

