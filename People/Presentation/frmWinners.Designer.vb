<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWinners
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
        Me.comboBoxSeasons = New System.Windows.Forms.ComboBox()
        Me.lblSelectSeason = New System.Windows.Forms.Label()
        Me.driversClassification = New System.Windows.Forms.ListBox()
        Me.teamsClassification = New System.Windows.Forms.ListBox()
        Me.lblSelectCoutry = New System.Windows.Forms.Label()
        Me.comboBoxCountries = New System.Windows.Forms.ComboBox()
        Me.lblDriversClass = New System.Windows.Forms.Label()
        Me.lblTeamsClass = New System.Windows.Forms.Label()
        Me.lblWorldChampions = New System.Windows.Forms.Label()
        Me.worldChampions = New System.Windows.Forms.ListBox()
        Me.btnMainMenuSeasons = New System.Windows.Forms.Button()
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
        'driversClassification
        '
        Me.driversClassification.Enabled = False
        Me.driversClassification.FormattingEnabled = True
        Me.driversClassification.ItemHeight = 16
        Me.driversClassification.Location = New System.Drawing.Point(70, 154)
        Me.driversClassification.Name = "driversClassification"
        Me.driversClassification.Size = New System.Drawing.Size(216, 388)
        Me.driversClassification.TabIndex = 3
        '
        'teamsClassification
        '
        Me.teamsClassification.Enabled = False
        Me.teamsClassification.FormattingEnabled = True
        Me.teamsClassification.ItemHeight = 16
        Me.teamsClassification.Location = New System.Drawing.Point(350, 154)
        Me.teamsClassification.Name = "teamsClassification"
        Me.teamsClassification.Size = New System.Drawing.Size(216, 388)
        Me.teamsClassification.TabIndex = 4
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
        Me.lblTeamsClass.Location = New System.Drawing.Point(302, 128)
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
        'worldChampions
        '
        Me.worldChampions.Enabled = False
        Me.worldChampions.FormattingEnabled = True
        Me.worldChampions.ItemHeight = 16
        Me.worldChampions.Location = New System.Drawing.Point(626, 154)
        Me.worldChampions.Name = "worldChampions"
        Me.worldChampions.Size = New System.Drawing.Size(545, 388)
        Me.worldChampions.TabIndex = 9
        '
        'btnMainMenuSeasons
        '
        Me.btnMainMenuSeasons.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenuSeasons.Location = New System.Drawing.Point(499, 583)
        Me.btnMainMenuSeasons.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.btnMainMenuSeasons.Name = "btnMainMenuSeasons"
        Me.btnMainMenuSeasons.Size = New System.Drawing.Size(156, 81)
        Me.btnMainMenuSeasons.TabIndex = 27
        Me.btnMainMenuSeasons.Text = "Go to main menu"
        Me.btnMainMenuSeasons.UseVisualStyleBackColor = False
        '
        'frmWinners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 685)
        Me.Controls.Add(Me.btnMainMenuSeasons)
        Me.Controls.Add(Me.lblWorldChampions)
        Me.Controls.Add(Me.worldChampions)
        Me.Controls.Add(Me.lblTeamsClass)
        Me.Controls.Add(Me.lblDriversClass)
        Me.Controls.Add(Me.lblSelectCoutry)
        Me.Controls.Add(Me.comboBoxCountries)
        Me.Controls.Add(Me.teamsClassification)
        Me.Controls.Add(Me.driversClassification)
        Me.Controls.Add(Me.lblSelectSeason)
        Me.Controls.Add(Me.comboBoxSeasons)
        Me.Name = "frmWinners"
        Me.Text = "frmWinners"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboBoxSeasons As ComboBox
    Friend WithEvents lblSelectSeason As Label
    Friend WithEvents driversClassification As ListBox
    Friend WithEvents teamsClassification As ListBox
    Friend WithEvents lblSelectCoutry As Label
    Friend WithEvents comboBoxCountries As ComboBox
    Friend WithEvents lblDriversClass As Label
    Friend WithEvents lblTeamsClass As Label
    Friend WithEvents lblWorldChampions As Label
    Friend WithEvents worldChampions As ListBox
    Friend WithEvents btnMainMenuSeasons As Button
End Class
