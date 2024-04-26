<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeasons
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerateSeasonInfo = New System.Windows.Forms.Button()
        Me.lblNumGPs = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lstSeasons = New System.Windows.Forms.ListBox()
        Me.lblNumTeams = New System.Windows.Forms.Label()
        Me.btnMainMenuSeasons = New System.Windows.Forms.Button()
        Me.CmbBoxMinTeams = New System.Windows.Forms.ComboBox()
        Me.CmbBoxMaxTeams = New System.Windows.Forms.ComboBox()
        Me.txtSeasonYear = New System.Windows.Forms.TextBox()
        Me.lstContracts = New System.Windows.Forms.ListBox()
        Me.lstGPs = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDriver2 = New System.Windows.Forms.Label()
        Me.lblDriver1 = New System.Windows.Forms.Label()
        Me.CmbBoxMaxGPs = New System.Windows.Forms.ComboBox()
        Me.CmbBoxMinGPs = New System.Windows.Forms.ComboBox()
        Me.btnClassifications = New System.Windows.Forms.Button()
        Me.seasonsLstBxTitle = New System.Windows.Forms.Label()
        Me.contractsLstBxTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First, select the year for the season"
        '
        'btnGenerateSeasonInfo
        '
        Me.btnGenerateSeasonInfo.Location = New System.Drawing.Point(40, 420)
        Me.btnGenerateSeasonInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerateSeasonInfo.Name = "btnGenerateSeasonInfo"
        Me.btnGenerateSeasonInfo.Size = New System.Drawing.Size(160, 50)
        Me.btnGenerateSeasonInfo.TabIndex = 3
        Me.btnGenerateSeasonInfo.Text = "Generate Season Information"
        Me.btnGenerateSeasonInfo.UseVisualStyleBackColor = True
        '
        'lblNumGPs
        '
        Me.lblNumGPs.Location = New System.Drawing.Point(37, 240)
        Me.lblNumGPs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumGPs.Name = "lblNumGPs"
        Me.lblNumGPs.Size = New System.Drawing.Size(453, 37)
        Me.lblNumGPs.TabIndex = 7
        Me.lblNumGPs.Text = " Introduce the number of GPs to be contested in the season (OPTIONAL). Left Selec" &
    "ts the minimum number, right chooses the maximum."
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(237, 420)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 50)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(404, 428)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(117, 42)
        Me.btnDone.TabIndex = 12
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lstSeasons
        '
        Me.lstSeasons.FormattingEnabled = True
        Me.lstSeasons.ItemHeight = 16
        Me.lstSeasons.Location = New System.Drawing.Point(547, 44)
        Me.lstSeasons.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSeasons.Name = "lstSeasons"
        Me.lstSeasons.Size = New System.Drawing.Size(248, 452)
        Me.lstSeasons.TabIndex = 13
        '
        'lblNumTeams
        '
        Me.lblNumTeams.Location = New System.Drawing.Point(37, 126)
        Me.lblNumTeams.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumTeams.Name = "lblNumTeams"
        Me.lblNumTeams.Size = New System.Drawing.Size(491, 32)
        Me.lblNumTeams.TabIndex = 15
        Me.lblNumTeams.Text = "Introduce the minimum and maximum number of participating teams (OPTIONAL). Left " &
    "Selects the minimum number, right chooses the maximum."
        '
        'btnMainMenuSeasons
        '
        Me.btnMainMenuSeasons.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenuSeasons.Location = New System.Drawing.Point(1182, 476)
        Me.btnMainMenuSeasons.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.btnMainMenuSeasons.Name = "btnMainMenuSeasons"
        Me.btnMainMenuSeasons.Size = New System.Drawing.Size(156, 81)
        Me.btnMainMenuSeasons.TabIndex = 26
        Me.btnMainMenuSeasons.Text = "Go to main menu"
        Me.btnMainMenuSeasons.UseVisualStyleBackColor = False
        '
        'CmbBoxMinTeams
        '
        Me.CmbBoxMinTeams.FormattingEnabled = True
        Me.CmbBoxMinTeams.Location = New System.Drawing.Point(40, 177)
        Me.CmbBoxMinTeams.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbBoxMinTeams.Name = "CmbBoxMinTeams"
        Me.CmbBoxMinTeams.Size = New System.Drawing.Size(121, 24)
        Me.CmbBoxMinTeams.TabIndex = 27
        Me.CmbBoxMinTeams.Text = "Min"
        '
        'CmbBoxMaxTeams
        '
        Me.CmbBoxMaxTeams.FormattingEnabled = True
        Me.CmbBoxMaxTeams.Location = New System.Drawing.Point(205, 177)
        Me.CmbBoxMaxTeams.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbBoxMaxTeams.Name = "CmbBoxMaxTeams"
        Me.CmbBoxMaxTeams.Size = New System.Drawing.Size(121, 24)
        Me.CmbBoxMaxTeams.TabIndex = 28
        Me.CmbBoxMaxTeams.Text = "Max"
        '
        'txtSeasonYear
        '
        Me.txtSeasonYear.Location = New System.Drawing.Point(40, 82)
        Me.txtSeasonYear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSeasonYear.Name = "txtSeasonYear"
        Me.txtSeasonYear.Size = New System.Drawing.Size(137, 22)
        Me.txtSeasonYear.TabIndex = 29
        '
        'lstContracts
        '
        Me.lstContracts.FormattingEnabled = True
        Me.lstContracts.ItemHeight = 16
        Me.lstContracts.Location = New System.Drawing.Point(864, 82)
        Me.lstContracts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstContracts.Name = "lstContracts"
        Me.lstContracts.Size = New System.Drawing.Size(161, 180)
        Me.lstContracts.TabIndex = 30
        '
        'lstGPs
        '
        Me.lstGPs.FormattingEnabled = True
        Me.lstGPs.ItemHeight = 16
        Me.lstGPs.Location = New System.Drawing.Point(864, 316)
        Me.lstGPs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstGPs.Name = "lstGPs"
        Me.lstGPs.Size = New System.Drawing.Size(161, 180)
        Me.lstGPs.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1087, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Driver 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1087, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Driver 2"
        '
        'lblDriver2
        '
        Me.lblDriver2.AutoSize = True
        Me.lblDriver2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDriver2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriver2.Location = New System.Drawing.Point(1087, 224)
        Me.lblDriver2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDriver2.Name = "lblDriver2"
        Me.lblDriver2.Size = New System.Drawing.Size(89, 20)
        Me.lblDriver2.TabIndex = 36
        Me.lblDriver2.Text = "________"
        '
        'lblDriver1
        '
        Me.lblDriver1.AutoSize = True
        Me.lblDriver1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDriver1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriver1.Location = New System.Drawing.Point(1087, 126)
        Me.lblDriver1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDriver1.Name = "lblDriver1"
        Me.lblDriver1.Size = New System.Drawing.Size(89, 20)
        Me.lblDriver1.TabIndex = 35
        Me.lblDriver1.Text = "________"
        '
        'CmbBoxMaxGPs
        '
        Me.CmbBoxMaxGPs.FormattingEnabled = True
        Me.CmbBoxMaxGPs.Location = New System.Drawing.Point(205, 289)
        Me.CmbBoxMaxGPs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbBoxMaxGPs.Name = "CmbBoxMaxGPs"
        Me.CmbBoxMaxGPs.Size = New System.Drawing.Size(121, 24)
        Me.CmbBoxMaxGPs.TabIndex = 38
        Me.CmbBoxMaxGPs.Text = "Max"
        '
        'CmbBoxMinGPs
        '
        Me.CmbBoxMinGPs.FormattingEnabled = True
        Me.CmbBoxMinGPs.Location = New System.Drawing.Point(40, 289)
        Me.CmbBoxMinGPs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbBoxMinGPs.Name = "CmbBoxMinGPs"
        Me.CmbBoxMinGPs.Size = New System.Drawing.Size(121, 24)
        Me.CmbBoxMinGPs.TabIndex = 37
        Me.CmbBoxMinGPs.Text = "Min"
        '
        'btnClassifications
        '
        Me.btnClassifications.Location = New System.Drawing.Point(1182, 374)
        Me.btnClassifications.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClassifications.Name = "btnClassifications"
        Me.btnClassifications.Size = New System.Drawing.Size(154, 83)
        Me.btnClassifications.TabIndex = 39
        Me.btnClassifications.Text = "Open Races And Show Classifications"
        Me.btnClassifications.UseVisualStyleBackColor = True
        '
        'seasonsLstBxTitle
        '
        Me.seasonsLstBxTitle.AutoSize = True
        Me.seasonsLstBxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seasonsLstBxTitle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.seasonsLstBxTitle.Location = New System.Drawing.Point(623, 9)
        Me.seasonsLstBxTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.seasonsLstBxTitle.Name = "seasonsLstBxTitle"
        Me.seasonsLstBxTitle.Size = New System.Drawing.Size(74, 20)
        Me.seasonsLstBxTitle.TabIndex = 39
        Me.seasonsLstBxTitle.Text = "Seasons"
        '
        'contractsLstBxTitle
        '
        Me.contractsLstBxTitle.AutoSize = True
        Me.contractsLstBxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contractsLstBxTitle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.contractsLstBxTitle.Location = New System.Drawing.Point(908, 46)
        Me.contractsLstBxTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.contractsLstBxTitle.Name = "contractsLstBxTitle"
        Me.contractsLstBxTitle.Size = New System.Drawing.Size(82, 20)
        Me.contractsLstBxTitle.TabIndex = 40
        Me.contractsLstBxTitle.Text = "Contracts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(938, 279)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "GPs"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(612, 515)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 42)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmSeasons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1696, 682)
        Me.Controls.Add(Me.btnClassifications)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.contractsLstBxTitle)
        Me.Controls.Add(Me.seasonsLstBxTitle)
        Me.Controls.Add(Me.CmbBoxMaxGPs)
        Me.Controls.Add(Me.CmbBoxMinGPs)
        Me.Controls.Add(Me.lblDriver2)
        Me.Controls.Add(Me.lblDriver1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstGPs)
        Me.Controls.Add(Me.lstContracts)
        Me.Controls.Add(Me.txtSeasonYear)
        Me.Controls.Add(Me.CmbBoxMaxTeams)
        Me.Controls.Add(Me.CmbBoxMinTeams)
        Me.Controls.Add(Me.btnMainMenuSeasons)
        Me.Controls.Add(Me.lblNumTeams)
        Me.Controls.Add(Me.lstSeasons)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblNumGPs)
        Me.Controls.Add(Me.btnGenerateSeasonInfo)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSeasons"
        Me.Text = "Seasons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerateSeasonInfo As Button
    Friend WithEvents lblNumGPs As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents lstSeasons As ListBox
    Friend WithEvents lblNumTeams As Label
    Friend WithEvents btnMainMenuSeasons As Button
    Friend WithEvents CmbBoxMinTeams As ComboBox
    Friend WithEvents CmbBoxMaxTeams As ComboBox
    Friend WithEvents txtSeasonYear As TextBox
    Friend WithEvents lstContracts As ListBox
    Friend WithEvents lstGPs As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDriver2 As Label
    Friend WithEvents lblDriver1 As Label
    Friend WithEvents CmbBoxMaxGPs As ComboBox
    Friend WithEvents CmbBoxMinGPs As ComboBox
    Friend WithEvents btnClassifications As Button
    Friend WithEvents seasonsLstBxTitle As Label
    Friend WithEvents contractsLstBxTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDelete As Button
End Class
