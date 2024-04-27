<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWinners
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.comboBoxSeasons = New System.Windows.Forms.ComboBox()
        Me.lblSelectSeason = New System.Windows.Forms.Label()
        Me.lstDriversClassNameSur = New System.Windows.Forms.ListBox()
        Me.lstTeamsClassificationTeams = New System.Windows.Forms.ListBox()
        Me.lblSelectCoutry = New System.Windows.Forms.Label()
        Me.comboBoxCountries = New System.Windows.Forms.ComboBox()
        Me.lblDriversClass = New System.Windows.Forms.Label()
        Me.lblTeamsClass = New System.Windows.Forms.Label()
        Me.lblWorldChampions = New System.Windows.Forms.Label()
        Me.lstWCwinner = New System.Windows.Forms.ListBox()
        Me.btnMainMenuSeasons = New System.Windows.Forms.Button()
        Me.lstDriversClassPoints = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lstTeamsClassificationPoints = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstWCwonraces = New System.Windows.Forms.ListBox()
        Me.lstWCpoints = New System.Windows.Forms.ListBox()
        Me.lstWCteam = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lstWCseason = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWorldDriverChampions = New System.Windows.Forms.Label()
        Me.lblWorldTeamChampion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'comboBoxSeasons
        '
        Me.comboBoxSeasons.FormattingEnabled = True
        Me.comboBoxSeasons.Location = New System.Drawing.Point(231, 71)
        Me.comboBoxSeasons.Name = "comboBoxSeasons"
        Me.comboBoxSeasons.Size = New System.Drawing.Size(121, 24)
        Me.comboBoxSeasons.TabIndex = 0
        '
        'lblSelectSeason
        '
        Me.lblSelectSeason.AutoSize = True
        Me.lblSelectSeason.Location = New System.Drawing.Point(242, 42)
        Me.lblSelectSeason.Name = "lblSelectSeason"
        Me.lblSelectSeason.Size = New System.Drawing.Size(96, 16)
        Me.lblSelectSeason.TabIndex = 2
        Me.lblSelectSeason.Text = "Select season:"
        '
        'lstDriversClassNameSur
        '
        Me.lstDriversClassNameSur.Enabled = False
        Me.lstDriversClassNameSur.FormattingEnabled = True
        Me.lstDriversClassNameSur.ItemHeight = 16
        Me.lstDriversClassNameSur.Location = New System.Drawing.Point(38, 176)
        Me.lstDriversClassNameSur.Name = "lstDriversClassNameSur"
        Me.lstDriversClassNameSur.Size = New System.Drawing.Size(170, 388)
        Me.lstDriversClassNameSur.TabIndex = 3
        '
        'lstTeamsClassificationTeams
        '
        Me.lstTeamsClassificationTeams.Enabled = False
        Me.lstTeamsClassificationTeams.FormattingEnabled = True
        Me.lstTeamsClassificationTeams.ItemHeight = 16
        Me.lstTeamsClassificationTeams.Location = New System.Drawing.Point(336, 176)
        Me.lstTeamsClassificationTeams.Name = "lstTeamsClassificationTeams"
        Me.lstTeamsClassificationTeams.Size = New System.Drawing.Size(180, 388)
        Me.lstTeamsClassificationTeams.TabIndex = 4
        '
        'lblSelectCoutry
        '
        Me.lblSelectCoutry.AutoSize = True
        Me.lblSelectCoutry.Location = New System.Drawing.Point(865, 42)
        Me.lblSelectCoutry.Name = "lblSelectCoutry"
        Me.lblSelectCoutry.Size = New System.Drawing.Size(94, 16)
        Me.lblSelectCoutry.TabIndex = 6
        Me.lblSelectCoutry.Text = "Select country:"
        '
        'comboBoxCountries
        '
        Me.comboBoxCountries.FormattingEnabled = True
        Me.comboBoxCountries.Location = New System.Drawing.Point(854, 71)
        Me.comboBoxCountries.Name = "comboBoxCountries"
        Me.comboBoxCountries.Size = New System.Drawing.Size(121, 24)
        Me.comboBoxCountries.TabIndex = 5
        '
        'lblDriversClass
        '
        Me.lblDriversClass.AutoSize = True
        Me.lblDriversClass.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriversClass.Location = New System.Drawing.Point(34, 128)
        Me.lblDriversClass.Name = "lblDriversClass"
        Me.lblDriversClass.Size = New System.Drawing.Size(252, 23)
        Me.lblDriversClass.TabIndex = 7
        Me.lblDriversClass.Text = "Drivers Classification"
        '
        'lblTeamsClass
        '
        Me.lblTeamsClass.AutoSize = True
        Me.lblTeamsClass.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamsClass.Location = New System.Drawing.Point(356, 128)
        Me.lblTeamsClass.Name = "lblTeamsClass"
        Me.lblTeamsClass.Size = New System.Drawing.Size(230, 23)
        Me.lblTeamsClass.TabIndex = 8
        Me.lblTeamsClass.Text = "Teams Classification"
        '
        'lblWorldChampions
        '
        Me.lblWorldChampions.AutoSize = True
        Me.lblWorldChampions.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorldChampions.Location = New System.Drawing.Point(800, 128)
        Me.lblWorldChampions.Name = "lblWorldChampions"
        Me.lblWorldChampions.Size = New System.Drawing.Size(175, 23)
        Me.lblWorldChampions.TabIndex = 10
        Me.lblWorldChampions.Text = "World Champions"
        '
        'lstWCwinner
        '
        Me.lstWCwinner.Enabled = False
        Me.lstWCwinner.FormattingEnabled = True
        Me.lstWCwinner.ItemHeight = 16
        Me.lstWCwinner.Location = New System.Drawing.Point(617, 176)
        Me.lstWCwinner.Name = "lstWCwinner"
        Me.lstWCwinner.Size = New System.Drawing.Size(167, 468)
        Me.lstWCwinner.TabIndex = 9
        '
        'btnMainMenuSeasons
        '
        Me.btnMainMenuSeasons.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenuSeasons.Location = New System.Drawing.Point(1200, 42)
        Me.btnMainMenuSeasons.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.btnMainMenuSeasons.Name = "btnMainMenuSeasons"
        Me.btnMainMenuSeasons.Size = New System.Drawing.Size(156, 81)
        Me.btnMainMenuSeasons.TabIndex = 27
        Me.btnMainMenuSeasons.Text = "Go to main menu"
        Me.btnMainMenuSeasons.UseVisualStyleBackColor = False
        '
        'lstDriversClassPoints
        '
        Me.lstDriversClassPoints.Enabled = False
        Me.lstDriversClassPoints.FormattingEnabled = True
        Me.lstDriversClassPoints.ItemHeight = 16
        Me.lstDriversClassPoints.Location = New System.Drawing.Point(214, 176)
        Me.lstDriversClassPoints.Name = "lstDriversClassPoints"
        Me.lstDriversClassPoints.Size = New System.Drawing.Size(64, 388)
        Me.lstDriversClassPoints.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(90, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(189, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Driver      Points"
        '
        'lstTeamsClassificationPoints
        '
        Me.lstTeamsClassificationPoints.Enabled = False
        Me.lstTeamsClassificationPoints.FormattingEnabled = True
        Me.lstTeamsClassificationPoints.ItemHeight = 16
        Me.lstTeamsClassificationPoints.Location = New System.Drawing.Point(522, 176)
        Me.lstTeamsClassificationPoints.Name = "lstTeamsClassificationPoints"
        Me.lstTeamsClassificationPoints.Size = New System.Drawing.Size(64, 388)
        Me.lstTeamsClassificationPoints.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Team          Points"
        '
        'lstWCwonraces
        '
        Me.lstWCwonraces.Enabled = False
        Me.lstWCwonraces.FormattingEnabled = True
        Me.lstWCwonraces.ItemHeight = 16
        Me.lstWCwonraces.Location = New System.Drawing.Point(1116, 176)
        Me.lstWCwonraces.Name = "lstWCwonraces"
        Me.lstWCwonraces.Size = New System.Drawing.Size(93, 468)
        Me.lstWCwonraces.TabIndex = 37
        '
        'lstWCpoints
        '
        Me.lstWCpoints.Enabled = False
        Me.lstWCpoints.FormattingEnabled = True
        Me.lstWCpoints.ItemHeight = 16
        Me.lstWCpoints.Location = New System.Drawing.Point(1029, 176)
        Me.lstWCpoints.Name = "lstWCpoints"
        Me.lstWCpoints.Size = New System.Drawing.Size(59, 468)
        Me.lstWCpoints.TabIndex = 36
        '
        'lstWCteam
        '
        Me.lstWCteam.Enabled = False
        Me.lstWCteam.FormattingEnabled = True
        Me.lstWCteam.ItemHeight = 16
        Me.lstWCteam.Location = New System.Drawing.Point(861, 176)
        Me.lstWCteam.Name = "lstWCteam"
        Me.lstWCteam.Size = New System.Drawing.Size(144, 468)
        Me.lstWCteam.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(657, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(529, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Winner       Season      Team      Points  Races Won"
        '
        'lstWCseason
        '
        Me.lstWCseason.Enabled = False
        Me.lstWCseason.FormattingEnabled = True
        Me.lstWCseason.ItemHeight = 16
        Me.lstWCseason.Location = New System.Drawing.Point(790, 176)
        Me.lstWCseason.Name = "lstWCseason"
        Me.lstWCseason.Size = New System.Drawing.Size(65, 468)
        Me.lstWCseason.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(333, 594)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "World's Team Champion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 594)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "World's Driver Champion"
        '
        'lblWorldDriverChampions
        '
        Me.lblWorldDriverChampions.AutoSize = True
        Me.lblWorldDriverChampions.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorldDriverChampions.Location = New System.Drawing.Point(34, 621)
        Me.lblWorldDriverChampions.Name = "lblWorldDriverChampions"
        Me.lblWorldDriverChampions.Size = New System.Drawing.Size(0, 23)
        Me.lblWorldDriverChampions.TabIndex = 40
        '
        'lblWorldTeamChampion
        '
        Me.lblWorldTeamChampion.AutoSize = True
        Me.lblWorldTeamChampion.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorldTeamChampion.Location = New System.Drawing.Point(338, 621)
        Me.lblWorldTeamChampion.Name = "lblWorldTeamChampion"
        Me.lblWorldTeamChampion.Size = New System.Drawing.Size(0, 23)
        Me.lblWorldTeamChampion.TabIndex = 41
        '
        'frmWinners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 740)
        Me.Controls.Add(Me.lblWorldTeamChampion)
        Me.Controls.Add(Me.lblWorldDriverChampions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstWCwonraces)
        Me.Controls.Add(Me.lstWCpoints)
        Me.Controls.Add(Me.lstWCteam)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lstWCseason)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTeamsClassificationPoints)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lstDriversClassPoints)
        Me.Controls.Add(Me.btnMainMenuSeasons)
        Me.Controls.Add(Me.lblWorldChampions)
        Me.Controls.Add(Me.lstWCwinner)
        Me.Controls.Add(Me.lblTeamsClass)
        Me.Controls.Add(Me.lblDriversClass)
        Me.Controls.Add(Me.lblSelectCoutry)
        Me.Controls.Add(Me.comboBoxCountries)
        Me.Controls.Add(Me.lstTeamsClassificationTeams)
        Me.Controls.Add(Me.lstDriversClassNameSur)
        Me.Controls.Add(Me.lblSelectSeason)
        Me.Controls.Add(Me.comboBoxSeasons)
        Me.Name = "frmWinners"
        Me.Text = "Classifications and World Champions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboBoxSeasons As ComboBox
    Friend WithEvents lblSelectSeason As Label
    Friend WithEvents lstDriversClassNameSur As ListBox
    Friend WithEvents lstTeamsClassificationTeams As ListBox
    Friend WithEvents lblSelectCoutry As Label
    Friend WithEvents comboBoxCountries As ComboBox
    Friend WithEvents lblDriversClass As Label
    Friend WithEvents lblTeamsClass As Label
    Friend WithEvents lblWorldChampions As Label
    Friend WithEvents lstWCwinner As ListBox
    Friend WithEvents btnMainMenuSeasons As Button
    Friend WithEvents lstDriversClassPoints As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lstTeamsClassificationPoints As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstWCwonraces As ListBox
    Friend WithEvents lstWCpoints As ListBox
    Friend WithEvents lstWCteam As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lstWCseason As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblWorldDriverChampions As Label
    Friend WithEvents lblWorldTeamChampion As Label
End Class
