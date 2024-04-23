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
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lstSeasons = New System.Windows.Forms.ListBox()
        Me.lblNumTeams = New System.Windows.Forms.Label()
        Me.btnMainMenuSeasons = New System.Windows.Forms.Button()
        Me.selectMinBox = New System.Windows.Forms.ComboBox()
        Me.selectMaxBox = New System.Windows.Forms.ComboBox()
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
        Me.Label1.Location = New System.Drawing.Point(30, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First, select the year for the season"
        '
        'btnGenerateSeasonInfo
        '
        Me.btnGenerateSeasonInfo.Location = New System.Drawing.Point(30, 341)
        Me.btnGenerateSeasonInfo.Name = "btnGenerateSeasonInfo"
        Me.btnGenerateSeasonInfo.Size = New System.Drawing.Size(120, 41)
        Me.btnGenerateSeasonInfo.TabIndex = 3
        Me.btnGenerateSeasonInfo.Text = "Generate Season Information"
        Me.btnGenerateSeasonInfo.UseVisualStyleBackColor = True
        '
        'lblNumGPs
        '
        Me.lblNumGPs.Location = New System.Drawing.Point(28, 195)
        Me.lblNumGPs.Name = "lblNumGPs"
        Me.lblNumGPs.Size = New System.Drawing.Size(340, 30)
        Me.lblNumGPs.TabIndex = 7
        Me.lblNumGPs.Text = " Introduce the number of GPs to be contested in the season (OPTIONAL). Left Selec" &
    "ts the minimum number, right chooses the maximum."
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(178, 341)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 41)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(628, 388)
        Me.btnInsert.Location = New System.Drawing.Point(1052, 344)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(88, 34)
        Me.btnInsert.TabIndex = 11
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(303, 348)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(88, 34)
        Me.btnDone.TabIndex = 12
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lstSeasons
        '
        Me.lstSeasons.FormattingEnabled = True
        Me.lstSeasons.Location = New System.Drawing.Point(410, 36)
        Me.lstSeasons.Name = "lstSeasons"
        Me.lstSeasons.Size = New System.Drawing.Size(187, 368)
        Me.lstSeasons.TabIndex = 13
        '
        'lblNumTeams
        '
        Me.lblNumTeams.Location = New System.Drawing.Point(28, 102)
        Me.lblNumTeams.Name = "lblNumTeams"
        Me.lblNumTeams.Size = New System.Drawing.Size(368, 26)
        Me.lblNumTeams.TabIndex = 15
        Me.lblNumTeams.Text = "Introduce the minimum and maximum number of participating teams (OPTIONAL). Left " &
    "Selects the minimum number, right chooses the maximum."
        '
        'btnMainMenuSeasons
        '
        Me.btnMainMenuSeasons.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenuSeasons.Location = New System.Drawing.Point(759, 378)
        Me.btnMainMenuSeasons.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnMainMenuSeasons.Location = New System.Drawing.Point(1052, 420)
        Me.btnMainMenuSeasons.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnMainMenuSeasons.Name = "btnMainMenuSeasons"
        Me.btnMainMenuSeasons.Size = New System.Drawing.Size(90, 54)
        Me.btnMainMenuSeasons.Size = New System.Drawing.Size(117, 66)
        Me.btnMainMenuSeasons.TabIndex = 26
        Me.btnMainMenuSeasons.Text = "Go to main menu"
        Me.btnMainMenuSeasons.UseVisualStyleBackColor = False
        '
        'selectMinBox
        '
        Me.selectMinBox.FormattingEnabled = True
        Me.selectMinBox.Location = New System.Drawing.Point(30, 144)
        Me.selectMinBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.selectMinBox.Name = "selectMinBox"
        Me.selectMinBox.Size = New System.Drawing.Size(92, 21)
        Me.selectMinBox.TabIndex = 27
        Me.selectMinBox.Text = "Min"
        '
        'selectMaxBox
        '
        Me.selectMaxBox.FormattingEnabled = True
        Me.selectMaxBox.Location = New System.Drawing.Point(154, 144)
        Me.selectMaxBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.selectMaxBox.Name = "selectMaxBox"
        Me.selectMaxBox.Size = New System.Drawing.Size(92, 21)
        Me.selectMaxBox.TabIndex = 28
        Me.selectMaxBox.Text = "Max"
        '
        'txtSeasonYear
        '
        Me.txtSeasonYear.Location = New System.Drawing.Point(30, 67)
        Me.txtSeasonYear.Name = "txtSeasonYear"
        Me.txtSeasonYear.Size = New System.Drawing.Size(104, 20)
        Me.txtSeasonYear.TabIndex = 29
        '
        'lstContracts
        '
        Me.lstContracts.FormattingEnabled = True
        Me.lstContracts.Location = New System.Drawing.Point(610, 36)
        Me.lstContracts.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstContracts.ItemHeight = 16
        Me.lstContracts.Location = New System.Drawing.Point(814, 67)
        Me.lstContracts.Name = "lstContracts"
        Me.lstContracts.Size = New System.Drawing.Size(122, 147)
        Me.lstContracts.TabIndex = 30
        '
        'lstGPs
        '
        Me.lstGPs.FormattingEnabled = True
        Me.lstGPs.Location = New System.Drawing.Point(610, 206)
        Me.lstGPs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstGPs.ItemHeight = 16
        Me.lstGPs.Location = New System.Drawing.Point(814, 290)
        Me.lstGPs.Name = "lstGPs"
        Me.lstGPs.Size = New System.Drawing.Size(122, 147)
        Me.lstGPs.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(756, 50)
        Me.Label3.Location = New System.Drawing.Point(1008, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Driver 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(756, 115)
        Me.Label4.Location = New System.Drawing.Point(1008, 169)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Driver 2"
        '
        'lblDriver2
        '
        Me.lblDriver2.AutoSize = True
        Me.lblDriver2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDriver2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriver2.Location = New System.Drawing.Point(756, 136)
        Me.lblDriver2.Location = New System.Drawing.Point(1008, 195)
        Me.lblDriver2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDriver2.Name = "lblDriver2"
        Me.lblDriver2.Size = New System.Drawing.Size(80, 17)
        Me.lblDriver2.TabIndex = 36
        Me.lblDriver2.Text = "________"
        '
        'lblDriver1
        '
        Me.lblDriver1.AutoSize = True
        Me.lblDriver1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDriver1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriver1.Location = New System.Drawing.Point(756, 72)
        Me.lblDriver1.Location = New System.Drawing.Point(1008, 115)
        Me.lblDriver1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDriver1.Name = "lblDriver1"
        Me.lblDriver1.Size = New System.Drawing.Size(80, 17)
        Me.lblDriver1.TabIndex = 35
        Me.lblDriver1.Text = "________"
        '
        'CmbBoxMaxGPs
        '
        Me.CmbBoxMaxGPs.FormattingEnabled = True
        Me.CmbBoxMaxGPs.Location = New System.Drawing.Point(154, 235)
        Me.CmbBoxMaxGPs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbBoxMaxGPs.Name = "CmbBoxMaxGPs"
        Me.CmbBoxMaxGPs.Size = New System.Drawing.Size(92, 21)
        Me.CmbBoxMaxGPs.TabIndex = 38
        Me.CmbBoxMaxGPs.Text = "Max"
        '
        'CmbBoxMinGPs
        '
        Me.CmbBoxMinGPs.FormattingEnabled = True
        Me.CmbBoxMinGPs.Location = New System.Drawing.Point(30, 235)
        Me.CmbBoxMinGPs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbBoxMinGPs.Name = "CmbBoxMinGPs"
        Me.CmbBoxMinGPs.Size = New System.Drawing.Size(92, 21)
        Me.CmbBoxMinGPs.TabIndex = 37
        Me.CmbBoxMinGPs.Text = "Min"
        '
        'btnClassifications
        '
        Me.btnClassifications.Location = New System.Drawing.Point(759, 298)
        Me.btnClassifications.Name = "btnClassifications"
        Me.btnClassifications.Size = New System.Drawing.Size(90, 55)
        Me.btnClassifications.TabIndex = 39
        Me.btnClassifications.Text = "Show Classifications"
        Me.btnClassifications.UseVisualStyleBackColor = True
        '
        'seasonsLstBxTitle
        '
        Me.seasonsLstBxTitle.AutoSize = True
        Me.seasonsLstBxTitle.Font = New System.Drawing.Font("RadiateSans-Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seasonsLstBxTitle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.seasonsLstBxTitle.Location = New System.Drawing.Point(629, 13)
        Me.seasonsLstBxTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.seasonsLstBxTitle.Name = "seasonsLstBxTitle"
        Me.seasonsLstBxTitle.Size = New System.Drawing.Size(84, 27)
        Me.seasonsLstBxTitle.TabIndex = 39
        Me.seasonsLstBxTitle.Text = "Seasons"
        '
        'contractsLstBxTitle
        '
        Me.contractsLstBxTitle.AutoSize = True
        Me.contractsLstBxTitle.Font = New System.Drawing.Font("RadiateSans-Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contractsLstBxTitle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.contractsLstBxTitle.Location = New System.Drawing.Point(847, 37)
        Me.contractsLstBxTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.contractsLstBxTitle.Name = "contractsLstBxTitle"
        Me.contractsLstBxTitle.Size = New System.Drawing.Size(98, 27)
        Me.contractsLstBxTitle.TabIndex = 40
        Me.contractsLstBxTitle.Text = "Contracts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("RadiateSans-Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(869, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 27)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "GPs"
        '
        'frmSeasons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 450)
        Me.Controls.Add(Me.btnClassifications)
        Me.ClientSize = New System.Drawing.Size(1272, 554)
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
        Me.Controls.Add(Me.selectMaxBox)
        Me.Controls.Add(Me.selectMinBox)
        Me.Controls.Add(Me.btnMainMenuSeasons)
        Me.Controls.Add(Me.lblNumTeams)
        Me.Controls.Add(Me.lstSeasons)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblNumGPs)
        Me.Controls.Add(Me.btnGenerateSeasonInfo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSeasons"
        Me.Text = "frmSeasons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerateSeasonInfo As Button
    Friend WithEvents lblNumGPs As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents lstSeasons As ListBox
    Friend WithEvents lblNumTeams As Label
    Friend WithEvents btnMainMenuSeasons As Button
    Friend WithEvents selectMinBox As ComboBox
    Friend WithEvents selectMaxBox As ComboBox
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
End Class
