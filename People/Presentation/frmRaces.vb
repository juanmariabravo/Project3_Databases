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
                Dim auxGPID As Integer
                Dim auxGP As GP
                season.SeasonID = Integer.Parse(lstSeasons.SelectedItem.ToString)
                season.ReadSeason()
                lstGPs.Items.Clear()
                lstGPs.Enabled = True

                For Each auxGPID In season.ListGPsID
                    auxGP = New GP(auxGPID)
                    auxGP.ReadGP()

                    lstGPs.Items.Add(auxGP.GPID & " " & auxGP.GPName)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstGPs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGPs.SelectedIndexChanged

        If lstGPs.SelectedIndex >= 0 AndAlso lstGPs.SelectedItems.Count = 1 Then
            Dim auxGP As New Collection
            Dim gpID As Integer
            Dim raceSelected As Race
            Dim season As New Season()
            Dim auxSeasonID_GPID_Driver As Collection

            season.SeasonID = Integer.Parse(lstSeasons.SelectedItem.ToString)
            season.ReadSeason()
            gpID = Integer.Parse(lstGPs.SelectedItem.ToString.Split(" "c)(0))

            For Each auxSeasonID_GPID_Driver In season.ListRaces

                If Integer.Parse(auxSeasonID_GPID_Driver(1).ToString) = season.SeasonID Or Integer.Parse(auxSeasonID_GPID_Driver(2).ToString) = gpID Then
                    raceSelected = New Race(season.SeasonID, gpID, Integer.Parse(auxSeasonID_GPID_Driver(3).ToString))
                    raceSelected.ReadRace()
                    Dim auxDriverForNames As New Driver(Integer.Parse(raceSelected.Driver.ToString))
                    auxDriverForNames.ReadDriver()

                    Select Case raceSelected.Position
                        Case 1
                            txtbxDriver1.Text = auxDriverForNames.DriverName & " " & auxDriverForNames.DriverSurname
                        Case 2
                            TxtBxDriver2.Text = auxDriverForNames.DriverName & " " & auxDriverForNames.DriverSurname
                        Case 3
                            TxtBxDriver3.Text = auxDriverForNames.DriverName & " " & auxDriverForNames.DriverSurname
                        Case 4
                            TxtBxDriver4.Text = auxDriverForNames.DriverName & " " & auxDriverForNames.DriverSurname
                        Case 5
                            TxtBxDriver5.Text = auxDriverForNames.DriverName & " " & auxDriverForNames.DriverSurname
                        Case 6
                            TxtBxDriver6.Text = auxDriverForNames.DriverName & " " & auxDriverForNames.DriverSurname
                    End Select
                End If
            Next






        End If

    End Sub









End Class

