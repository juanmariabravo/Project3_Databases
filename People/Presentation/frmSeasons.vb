Imports System.Drawing.Text
Imports System.Linq.Expressions

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
        frmFormulaOne.Enabled = True
        'Close this form
        Me.Close()
    End Sub

    Private Sub frmFormulaOne_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Reopen the main menu form
        frmFormulaOne.Enabled = True
    End Sub
    Private Sub btnClassifications_Click(sender As Object, e As EventArgs) Handles btnClassifications.Click
        Dim races As New frmRaces()
        races.Show()

    End Sub


    Private Sub frmSeasons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadSeasons()
            DisableControls()
            InitializeComboBoxes()
        Catch ex As Exception
            MessageBox.Show("Error while loading seasons: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadSeasons()
        Dim season As New Season
        season.ReadAllSeasons()
        lstSeasons.Items.Clear()
        For Each seasonItem As Season In season.SeasonDAO.Seasons
            lstSeasons.Items.Add(seasonItem.SeasonID)
        Next

    End Sub

    Private Sub DisableControls()
        btnDelete.Enabled = False
        btnDone.Enabled = False
        lstContracts.Enabled = False
        lstGPs.Enabled = False
        lblDriver1.Enabled = False
        lblDriver2.Enabled = False
    End Sub

    Private Sub InitializeComboBoxes()
        InitializeComboBox(CmbBoxMinTeams, 5, 10)
        InitializeComboBox(CmbBoxMaxTeams, 5, 10)
        InitializeComboBox(CmbBoxMinGPs, 10, 20)
        InitializeComboBox(CmbBoxMaxGPs, 10, 20)
    End Sub

    Private Sub InitializeComboBox(comboBox As ComboBox, minValue As Integer, maxValue As Integer)
        comboBox.Items.Add(" ")
        For i As Integer = minValue To maxValue
            comboBox.Items.Add(i)
        Next
        comboBox.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub LstSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeasons.SelectedIndexChanged
        If lstSeasons.SelectedIndex >= 0 AndAlso lstSeasons.SelectedItems.Count = 1 Then
            Try
                Dim seasonID As Integer = CInt(lstSeasons.SelectedItem.ToString)
                lblDriver1.Text = " "
                lblDriver2.Text = " "
                LoadSeasonData(seasonID)

            Catch ex As Exception
                MessageBox.Show("Error while processing selected season: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LoadSeasonData(seasonID As Integer)
        Dim season As New Season()
        season.SeasonID = seasonID
        season.ReadSeason()
        ClearListBoxes()
        EnableListBoxes()
        InsertContracts(season)
        InsertGPs(season)

    End Sub

    Private Sub ClearListBoxes()
        lstContracts.Items.Clear()
        lstGPs.Items.Clear()
    End Sub

    Private Sub EnableListBoxes()
        lstContracts.Enabled = True
        lstGPs.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub InsertContracts(season As Season)
        For Each teamID As Integer In season.ListContractsTeamID
            Dim team As New Team(teamID)
            team.ReadTeam()
            lstContracts.Items.Add(team.TeamID & " " & team.TeamName)
        Next
    End Sub

    Private Sub InsertGPs(season As Season)
        For Each gpID As Integer In season.ListGPsID
            Dim gp As New GP(gpID)
            gp.ReadGP()
            lstGPs.Items.Add(gp.GPID & " " & gp.GPName)
        Next
    End Sub


    Private Sub lstContracts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstContracts.SelectedIndexChanged
        Try
            If lstContracts.Items.Count >= 0 Then
                Dim contract As Contract
                Dim contracID As Integer
                Dim seasonID As Integer
                Dim auxDriver As New Driver()

                If lstContracts.SelectedIndex >= 0 Then
                    Dim tokens As String() = lstContracts.SelectedItem.ToString.Split(" "c)
                    seasonID = CInt(lstSeasons.SelectedItem.ToString)
                    contracID = CInt(tokens(0))
                    contract = New Contract(contracID, seasonID)
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
            MessageBox.Show("Error while reading contracts: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGenerateSeasonInfo_Click(sender As Object, e As EventArgs) Handles btnGenerateSeasonInfo.Click
        Dim minTeams As Integer
        Dim maxTeams As Integer
        Dim minGPs As Integer
        Dim maxGPs As Integer
        Dim seasonYear As Integer
        getSeasonYear(seasonYear)
        getnumTeams(minTeams, maxTeams)
        getnumGPs(minGPs, maxGPs)

        If Not ShouldCreateSeason(minTeams, maxTeams, minGPs, maxGPs) Then
            Exit Sub
        End If

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
            MessageBox.Show("Error when inserting the season:" & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            season.DeleteSeason()
        End Try


    End Sub

    Private Sub getSeasonYear(ByRef seasonYear As Integer)

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
        If txtSeasonYear.TextLength = 4 AndAlso Integer.Parse(txtSeasonYear.Text) >= 1970 AndAlso CInt(txtSeasonYear.Text) <= 2024 Then
            seasonYear = CInt(txtSeasonYear.Text)
        Else
            MessageBox.Show("The year of the season must be between 1970 and 2024.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSeasonYear.Clear()
            txtSeasonYear.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub getnumTeams(ByRef minTeams As Integer, ByRef maxTeams As Integer)
        Try

            ControlNumberTeamsValues(minTeams, maxTeams)
            'Check for the selection of the number of teams and GPs
            If CmbBoxMinTeams.SelectedItem IsNot " " AndAlso CmbBoxMaxTeams.SelectedItem IsNot " " AndAlso CmbBoxMinTeams.SelectedIndex <= CmbBoxMaxTeams.SelectedIndex Then
                If CmbBoxMinTeams.SelectedIndex >= 0 AndAlso CmbBoxMaxTeams.SelectedIndex >= 0 Then
                    minTeams = Integer.Parse(CmbBoxMinTeams.SelectedItem.ToString)
                    maxTeams = Integer.Parse(CmbBoxMaxTeams.SelectedItem.ToString)
                Else
                    minTeams = 5
                    maxTeams = 10
                End If
                numberTeams = New Random().Next(minTeams, maxTeams + 1)
            End If
        Catch ex As Exception
            MessageBox.Show("Error while getting random numbers: An error occurred while generating random numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub getnumGPs(ByRef minGps As Integer, ByRef maxGps As Integer)
        Try

            ControlNumberGpsValues(minGps, maxGps)
            'Check for the selection of the number of teams and GPs
            If CmbBoxMinTeams.SelectedItem IsNot " " AndAlso CmbBoxMaxGPs.SelectedItem IsNot " " AndAlso CmbBoxMinGPs.SelectedIndex <= CmbBoxMaxGPs.SelectedIndex Then
                If CmbBoxMinGPs.SelectedIndex >= 0 AndAlso CmbBoxMaxGPs.SelectedIndex >= 0 Then
                    minGps = Integer.Parse(CmbBoxMinGPs.SelectedItem.ToString)
                    maxGps = Integer.Parse(CmbBoxMaxGPs.SelectedItem.ToString)
                Else
                    minGps = 10
                    maxGps = 20
                End If
                numberGPs = New Random().Next(minGps, maxGps + 1)
            End If
        Catch ex As Exception
            MessageBox.Show("Error while getting random numbers: An error occurred while generating random numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ControlNumberTeamsValues(ByRef minTeams As Integer, ByRef maxTeams As Integer)
        'Control cases in which only one combobox is selected
        If CmbBoxMinTeams.SelectedIndex > 0 Then

            minTeams = Integer.Parse(CmbBoxMinTeams.SelectedItem.ToString)
        Else
            minTeams = 5
        End If
        If CmbBoxMaxTeams.SelectedIndex > 0 Then
            maxTeams = Integer.Parse(CmbBoxMaxTeams.SelectedItem.ToString)
        Else
            maxTeams = 10
        End If
        numberTeams = New Random().Next(minTeams, maxTeams + 1)
    End Sub

    Private Sub ControlNumberGpsValues(ByRef minGps As Integer, ByRef maxGps As Integer)
        'Control cases in which only one combobox is selected
        If CmbBoxMinGPs.SelectedIndex > 0 Then

            minGps = Integer.Parse(CmbBoxMinGPs.SelectedItem.ToString)
        Else
            minGps = 10
        End If
        If CmbBoxMaxGPs.SelectedIndex > 0 Then
            maxGps = Integer.Parse(CmbBoxMaxGPs.SelectedItem.ToString)
        Else
            maxGps = 20
        End If
        numberGPs = New Random().Next(minGps, maxGps + 1)

    End Sub
    Private Function ShouldCreateSeason(minTeams As Integer, maxTeams As Integer, minGps As Integer, maxGps As Integer) As Boolean
        If minTeams > maxTeams Then
            MessageBox.Show("The minimum number of teams must be less than or equal to the maximum number of teams.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If minGps > maxGps Then
            MessageBox.Show("The minimum number of GPs must be less than or equal to the maximum number of GPs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Delete the season selected in the list of seasons
        Try
            Dim season As New Season(CInt(lstSeasons.SelectedItem.ToString))
            season.ReadSeason()
            season.DeleteSeason()
            lstSeasons.Items.Clear()
            season.ReadAllSeasons()
            For Each season In season.SeasonDAO.Seasons
                lstSeasons.Items.Add(season.SeasonID)
            Next
            lstContracts.Items.Clear()
            lstGPs.Items.Clear()
            btnDelete.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error while deleting the season: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtSeasonYear.Clear()

        lblDriver1.Text = ""
        lblDriver2.Text = ""

        lstGPs.Items.Clear()
        lstContracts.Items.Clear()

        CmbBoxMinTeams.SelectedIndex = -1
        CmbBoxMaxTeams.SelectedIndex = -1
        CmbBoxMinGPs.SelectedIndex = -1
        CmbBoxMaxGPs.SelectedIndex = -1

    End Sub

    Private Sub txtSeasonYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeasonYear.KeyPress
        ' Verify if the character entered is a number or if it is the backspace key
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            ' If it is not a number and it is not the backspace key, cancel the KeyPress event
            e.Handled = True
        End If
        ' Verify if the length of the text in the TextBox is equal to 4 and the character is not a backspace key
        If txtSeasonYear.TextLength = 4 AndAlso e.KeyChar <> ControlChars.Back Then
            ' If there are already 4 digits and it is not a backspace key, cancel the KeyPress event
            e.Handled = True
        End If
    End Sub

    ' Enable main form if this form is closed
    Private Sub frmSeasons_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmFormulaOne.Enabled = True
    End Sub
End Class

