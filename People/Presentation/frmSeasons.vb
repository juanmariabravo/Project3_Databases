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
        Try
            'Management of lists of Seasons, Teams and GPs
            Dim season As New Season
            season.ReadAllSeasons()
            lstSeasons.Items.Clear()
            For Each season In season.SeasonDAO.Seasons
                lstSeasons.Items.Add(season.SeasonID)
            Next

            'Management of visual elements
            btnInsert.Enabled = False
            btnDone.Enabled = False
            lstContracts.Enabled = False
            lstGPs.Enabled = False
            lblDriver1.Enabled = False
            lblDriver2.Enabled = False
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
            'Hacer que en la combobox no se pueda escribir, solo seleccionar el valor, pero que tenga un valor escrito en la opcion por defecto
            selectMinBox.DropDownStyle = ComboBoxStyle.DropDownList
            selectMaxBox.DropDownStyle = ComboBoxStyle.DropDownList
            CmbBoxMinGPs.DropDownStyle = ComboBoxStyle.DropDownList
            CmbBoxMaxGPs.DropDownStyle = ComboBoxStyle.DropDownList

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub LstSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeasons.SelectedIndexChanged
        Try

            If lstSeasons.SelectedIndex >= 0 AndAlso lstSeasons.SelectedItems.Count = 1 Then
                Dim season As New Season()
                Dim aux As Collection
                Dim auxTeam As New Team()
                season.SeasonID = Integer.Parse(lstSeasons.SelectedItem.ToString)
                season.ReadSeason()

                lstContracts.Items.Clear()
                lstGPs.Items.Clear()

                'Habilitar la lista de Gps y de contratos para meter ahí todos los nombres de los contratos, asi como los nombres de los gps
                lstContracts.Enabled = True
                lstGPs.Enabled = True
                'Meter los nombres de los equipos que tengan un contrato en la lista de contratos
                For Each auxTeam In season.ListTeams
                    lstContracts.Items.Add(auxTeam.TeamID & " " & auxTeam.TeamName)
                Next

                'Meter los nombres de los GPs en la lista de GPs
                For Each aux In season.ListGPs
                    lstGPs.Items.Add(aux(2).ToString)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstContracts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstContracts.SelectedIndexChanged
        Try
            If lstContracts.Items.Count > 0 Then
                Dim contract As New Contract()
                Dim auxDriver As New Driver()

                If lstContracts.SelectedIndex >= 0 Then
                    Dim tokens As String() = lstContracts.SelectedItem.ToString.Split(" "c)
                    contract.Season = Integer.Parse(lstSeasons.SelectedItem.ToString)
                    contract.Team = Integer.Parse(tokens(0))
                    contract.ReadContract()


                    auxDriver.DriverID = contract.Driver1
                    auxDriver.ReadDriver()
                    lblDriver1.Text = auxDriver.DriverName & " " & auxDriver.DriverSurname

                    auxDriver.DriverID = contract.Driver2
                    auxDriver.ReadDriver()
                    lblDriver2.Text = auxDriver.DriverName & " " & auxDriver.DriverSurname
                End If
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
        Dim seasonYear As Integer
        Dim i As Integer

        'Check for format in the year of the season --------------------------------
        Try
            'Check if the year is already created, then cancel creation
            For i = 1 To lstSeasons.Items.Count
                If lstSeasons.Items(i - 1).ToString = txtSeasonYear.Text Then
                    MessageBox.Show("The year of the season is already in the list of seasons.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSeasonYear.Clear()
                    txtSeasonYear.Focus()
                    Exit Sub
                End If
            Next
            'Check for the selection of the year of the season
            If txtSeasonYear.TextLength = 4 AndAlso Integer.Parse(txtSeasonYear.Text) >= 1970 AndAlso Integer.Parse(txtSeasonYear.Text) <= 2024 Then
                seasonYear = Integer.Parse(txtSeasonYear.Text)
            Else
                MessageBox.Show("The year of the season must be between 1970 and 2024.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSeasonYear.Clear()
                txtSeasonYear.Focus()
                Exit Sub
            End If

            'Check for the selection of the number of teams and GPs
            If selectMinBox.SelectedIndex >= 0 AndAlso selectMaxBox.SelectedIndex >= 0 AndAlso selectMinBox.SelectedIndex < selectMaxBox.SelectedIndex Then
                minTeams = Integer.Parse(selectMinBox.SelectedItem.ToString)
                maxTeams = Integer.Parse(selectMaxBox.SelectedItem.ToString)
            Else
                minTeams = 5
                maxTeams = 10
            End If


            'We do the same with the controls of Combobox for the number of GPs
            If CmbBoxMinGPs.SelectedIndex >= 0 AndAlso CmbBoxMaxGPs.SelectedIndex >= 0 AndAlso CmbBoxMinGPs.SelectedIndex < CmbBoxMaxGPs.SelectedIndex Then
                minGPs = Integer.Parse(CmbBoxMinGPs.SelectedItem.ToString)
                maxGPs = Integer.Parse(CmbBoxMaxGPs.SelectedItem.ToString)
            Else
                minGPs = 10
                maxGPs = 20
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Fetching Data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Take all of the info for the season creation --------------------------------
        Try

            'Random number of Teams
            numberTeams = New Random().Next(minTeams, maxTeams + 1)

            'Random number of GPs
            numberGPs = New Random().Next(minGPs, maxGPs + 1)

        Catch ex As Exception
            MessageBox.Show("Error while getting random numbers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim season As New Season(seasonYear)
        season.ReadSeason()
        Try

            'Insert the season in the database
            season.InsertSeason(numberTeams, numberGPs)

            'Recharge the seasons list
            season.ReadAllSeasons()
            lstSeasons.Items.Clear()
            For Each season In season.SeasonDAO.Seasons
                lstSeasons.Items.Add(season.SeasonID)
            Next

        Catch ex As Exception
            MessageBox.Show("Error while creating Season: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ' Disable the controls if an error occurs
        CmbBoxMaxGPs.Enabled = False
            CmbBoxMinGPs.Enabled = False
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



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtSeasonYear.Clear()

        lblDriver1.Text = ""
        lblDriver2.Text = ""

        lstGPs.Items.Clear()
        lstContracts.Items.Clear()

        selectMinBox.SelectedIndex = -1
        selectMaxBox.SelectedIndex = -1
        CmbBoxMinGPs.SelectedIndex = -1
        CmbBoxMaxGPs.SelectedIndex = -1

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        ' Cerrar el formulario
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub

    Private Sub txtSeasonYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeasonYear.KeyPress
        ' Verifica si el carácter ingresado es un número o si es la tecla de retroceso (Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si no es un número y no es la tecla Backspace, cancela el evento KeyPress
            e.Handled = True
        End If
        ' Verifica si la longitud del texto en el TextBox es igual a 4 y el carácter no es una tecla de retroceso
        If txtSeasonYear.TextLength = 4 AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si ya hay 4 dígitos y no es una tecla de retroceso, cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub
End Class

