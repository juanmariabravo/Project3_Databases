<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSelectSeason = New System.Windows.Forms.Label()
        Me.comboBoxStartSeason = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboBoxEndSeason = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboBoxDrivers = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboBoxTeams = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboBoxEndSeason2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboBoxStartSeason2 = New System.Windows.Forms.ComboBox()
        Me.lstRaces = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstDrivers = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstRacesOfDriverSeason = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.btnMainMenuSeasons = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lstRacesOfDriverGP = New System.Windows.Forms.ListBox()
        Me.lstRacesOfDriverPosition = New System.Windows.Forms.ListBox()
        Me.lstRacesOfDriverPoints = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblSelectSeason
        '
        Me.lblSelectSeason.AutoSize = True
        Me.lblSelectSeason.Location = New System.Drawing.Point(46, 188)
        Me.lblSelectSeason.Name = "lblSelectSeason"
        Me.lblSelectSeason.Size = New System.Drawing.Size(145, 16)
        Me.lblSelectSeason.TabIndex = 4
        Me.lblSelectSeason.Text = "Select the start season:"
        '
        'comboBoxStartSeason
        '
        Me.comboBoxStartSeason.FormattingEnabled = True
        Me.comboBoxStartSeason.Location = New System.Drawing.Point(49, 219)
        Me.comboBoxStartSeason.Name = "comboBoxStartSeason"
        Me.comboBoxStartSeason.Size = New System.Drawing.Size(121, 24)
        Me.comboBoxStartSeason.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select the end season:"
        '
        'comboBoxEndSeason
        '
        Me.comboBoxEndSeason.FormattingEnabled = True
        Me.comboBoxEndSeason.Location = New System.Drawing.Point(49, 304)
        Me.comboBoxEndSeason.Name = "comboBoxEndSeason"
        Me.comboBoxEndSeason.Size = New System.Drawing.Size(121, 24)
        Me.comboBoxEndSeason.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select a driver:"
        '
        'comboBoxDrivers
        '
        Me.comboBoxDrivers.FormattingEnabled = True
        Me.comboBoxDrivers.Location = New System.Drawing.Point(49, 90)
        Me.comboBoxDrivers.Name = "comboBoxDrivers"
        Me.comboBoxDrivers.Size = New System.Drawing.Size(121, 24)
        Me.comboBoxDrivers.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Select a team:"
        '
        'comboBoxTeams
        '
        Me.comboBoxTeams.FormattingEnabled = True
        Me.comboBoxTeams.Location = New System.Drawing.Point(469, 91)
        Me.comboBoxTeams.Name = "comboBoxTeams"
        Me.comboBoxTeams.Size = New System.Drawing.Size(121, 24)
        Me.comboBoxTeams.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(466, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Select the end season:"
        '
        'comboBoxEndSeason2
        '
        Me.comboBoxEndSeason2.FormattingEnabled = True
        Me.comboBoxEndSeason2.Location = New System.Drawing.Point(469, 305)
        Me.comboBoxEndSeason2.Name = "comboBoxEndSeason2"
        Me.comboBoxEndSeason2.Size = New System.Drawing.Size(121, 24)
        Me.comboBoxEndSeason2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(466, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Select the start season:"
        '
        'comboBoxStartSeason2
        '
        Me.comboBoxStartSeason2.FormattingEnabled = True
        Me.comboBoxStartSeason2.Location = New System.Drawing.Point(469, 220)
        Me.comboBoxStartSeason2.Name = "comboBoxStartSeason2"
        Me.comboBoxStartSeason2.Size = New System.Drawing.Size(121, 24)
        Me.comboBoxStartSeason2.TabIndex = 9
        '
        'lstRaces
        '
        Me.lstRaces.FormattingEnabled = True
        Me.lstRaces.ItemHeight = 16
        Me.lstRaces.Location = New System.Drawing.Point(195, 90)
        Me.lstRaces.Name = "lstRaces"
        Me.lstRaces.Size = New System.Drawing.Size(253, 468)
        Me.lstRaces.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(293, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Races"
        '
        'lstDrivers
        '
        Me.lstDrivers.FormattingEnabled = True
        Me.lstDrivers.ItemHeight = 16
        Me.lstDrivers.Location = New System.Drawing.Point(642, 62)
        Me.lstDrivers.Name = "lstDrivers"
        Me.lstDrivers.Size = New System.Drawing.Size(205, 500)
        Me.lstDrivers.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(651, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Drivers of the team"
        '
        'lstRacesOfDriverSeason
        '
        Me.lstRacesOfDriverSeason.Enabled = False
        Me.lstRacesOfDriverSeason.FormattingEnabled = True
        Me.lstRacesOfDriverSeason.ItemHeight = 16
        Me.lstRacesOfDriverSeason.Location = New System.Drawing.Point(865, 93)
        Me.lstRacesOfDriverSeason.Name = "lstRacesOfDriverSeason"
        Me.lstRacesOfDriverSeason.Size = New System.Drawing.Size(90, 468)
        Me.lstRacesOfDriverSeason.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(917, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(297, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Selected Driver's Races Results:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(877, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(399, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Season        GP        Position Points"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 388)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Position"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 444)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Points"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPosition.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(135, 385)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(35, 25)
        Me.lblPosition.TabIndex = 24
        Me.lblPosition.Text = "#0"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPoints.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(135, 439)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(24, 25)
        Me.lblPoints.TabIndex = 25
        Me.lblPoints.Text = "0"
        '
        'btnMainMenuSeasons
        '
        Me.btnMainMenuSeasons.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenuSeasons.Location = New System.Drawing.Point(455, 480)
        Me.btnMainMenuSeasons.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.btnMainMenuSeasons.Name = "btnMainMenuSeasons"
        Me.btnMainMenuSeasons.Size = New System.Drawing.Size(156, 81)
        Me.btnMainMenuSeasons.TabIndex = 28
        Me.btnMainMenuSeasons.Text = "Go to main menu"
        Me.btnMainMenuSeasons.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(203, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 20)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Season       GP"
        '
        'lstRacesOfDriverGP
        '
        Me.lstRacesOfDriverGP.Enabled = False
        Me.lstRacesOfDriverGP.FormattingEnabled = True
        Me.lstRacesOfDriverGP.ItemHeight = 16
        Me.lstRacesOfDriverGP.Location = New System.Drawing.Point(961, 93)
        Me.lstRacesOfDriverGP.Name = "lstRacesOfDriverGP"
        Me.lstRacesOfDriverGP.Size = New System.Drawing.Size(163, 468)
        Me.lstRacesOfDriverGP.TabIndex = 30
        '
        'lstRacesOfDriverPosition
        '
        Me.lstRacesOfDriverPosition.Enabled = False
        Me.lstRacesOfDriverPosition.FormattingEnabled = True
        Me.lstRacesOfDriverPosition.ItemHeight = 16
        Me.lstRacesOfDriverPosition.Location = New System.Drawing.Point(1130, 94)
        Me.lstRacesOfDriverPosition.Name = "lstRacesOfDriverPosition"
        Me.lstRacesOfDriverPosition.Size = New System.Drawing.Size(74, 468)
        Me.lstRacesOfDriverPosition.TabIndex = 31
        '
        'lstRacesOfDriverPoints
        '
        Me.lstRacesOfDriverPoints.Enabled = False
        Me.lstRacesOfDriverPoints.FormattingEnabled = True
        Me.lstRacesOfDriverPoints.ItemHeight = 16
        Me.lstRacesOfDriverPoints.Location = New System.Drawing.Point(1210, 93)
        Me.lstRacesOfDriverPoints.Name = "lstRacesOfDriverPoints"
        Me.lstRacesOfDriverPoints.Size = New System.Drawing.Size(74, 468)
        Me.lstRacesOfDriverPoints.TabIndex = 32
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 600)
        Me.Controls.Add(Me.lstRacesOfDriverPoints)
        Me.Controls.Add(Me.lstRacesOfDriverPosition)
        Me.Controls.Add(Me.lstRacesOfDriverGP)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnMainMenuSeasons)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstRacesOfDriverSeason)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lstDrivers)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstRaces)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comboBoxTeams)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.comboBoxEndSeason2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.comboBoxStartSeason2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboBoxDrivers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboBoxEndSeason)
        Me.Controls.Add(Me.lblSelectSeason)
        Me.Controls.Add(Me.comboBoxStartSeason)
        Me.Name = "frmHistory"
        Me.Text = "History of Drivers and Teams"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelectSeason As Label
    Friend WithEvents comboBoxStartSeason As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboBoxEndSeason As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents comboBoxDrivers As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents comboBoxTeams As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents comboBoxEndSeason2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents comboBoxStartSeason2 As ComboBox
    Friend WithEvents lstRaces As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lstDrivers As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lstRacesOfDriverSeason As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents btnMainMenuSeasons As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lstRacesOfDriverGP As ListBox
    Friend WithEvents lstRacesOfDriverPosition As ListBox
    Friend WithEvents lstRacesOfDriverPoints As ListBox
End Class
