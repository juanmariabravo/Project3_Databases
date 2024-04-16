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
        Me.txtNumberOfGPs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lstSeasons = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMainMenuSeasons = New System.Windows.Forms.Button()
        Me.selectMinBox = New System.Windows.Forms.ComboBox()
        Me.selectMaxBox = New System.Windows.Forms.ComboBox()
        Me.txtSeasonYear = New System.Windows.Forms.TextBox()
        Me.lstTeams = New System.Windows.Forms.ListBox()
        Me.lstGPs = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDriver2 = New System.Windows.Forms.Label()
        Me.lblDriver1 = New System.Windows.Forms.Label()
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
        'txtNumberOfGPs
        '
        Me.txtNumberOfGPs.Location = New System.Drawing.Point(40, 347)
        Me.txtNumberOfGPs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumberOfGPs.Name = "txtNumberOfGPs"
        Me.txtNumberOfGPs.Size = New System.Drawing.Size(196, 22)
        Me.txtNumberOfGPs.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 309)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = " Introduce the number of GPs to be contested in the season (OPTIONAL)"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(238, 420)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 50)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(838, 478)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(117, 42)
        Me.btnInsert.TabIndex = 11
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 147)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(481, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Introduce the minimum and maximum number of participating teams (OPTIONAL)"
        '
        'btnMainMenuSeasons
        '
        Me.btnMainMenuSeasons.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenuSeasons.Location = New System.Drawing.Point(1011, 466)
        Me.btnMainMenuSeasons.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnMainMenuSeasons.Name = "btnMainMenuSeasons"
        Me.btnMainMenuSeasons.Size = New System.Drawing.Size(120, 66)
        Me.btnMainMenuSeasons.TabIndex = 26
        Me.btnMainMenuSeasons.Text = "Go to main menu"
        Me.btnMainMenuSeasons.UseVisualStyleBackColor = False
        '
        'selectMinBox
        '
        Me.selectMinBox.FormattingEnabled = True
        Me.selectMinBox.Location = New System.Drawing.Point(40, 185)
        Me.selectMinBox.Name = "selectMinBox"
        Me.selectMinBox.Size = New System.Drawing.Size(121, 24)
        Me.selectMinBox.TabIndex = 27
        Me.selectMinBox.Text = "Min"
        '
        'selectMaxBox
        '
        Me.selectMaxBox.FormattingEnabled = True
        Me.selectMaxBox.Location = New System.Drawing.Point(40, 231)
        Me.selectMaxBox.Name = "selectMaxBox"
        Me.selectMaxBox.Size = New System.Drawing.Size(121, 24)
        Me.selectMaxBox.TabIndex = 28
        Me.selectMaxBox.Text = "Max"
        '
        'txtSeasonYear
        '
        Me.txtSeasonYear.Location = New System.Drawing.Point(40, 82)
        Me.txtSeasonYear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSeasonYear.Name = "txtSeasonYear"
        Me.txtSeasonYear.Size = New System.Drawing.Size(138, 22)
        Me.txtSeasonYear.TabIndex = 29
        '
        'lstTeams
        '
        Me.lstTeams.FormattingEnabled = True
        Me.lstTeams.ItemHeight = 16
        Me.lstTeams.Location = New System.Drawing.Point(814, 44)
        Me.lstTeams.Name = "lstTeams"
        Me.lstTeams.Size = New System.Drawing.Size(162, 180)
        Me.lstTeams.TabIndex = 30
        '
        'lstGPs
        '
        Me.lstGPs.FormattingEnabled = True
        Me.lstGPs.ItemHeight = 16
        Me.lstGPs.Location = New System.Drawing.Point(814, 254)
        Me.lstGPs.Name = "lstGPs"
        Me.lstGPs.Size = New System.Drawing.Size(162, 180)
        Me.lstGPs.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1008, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Driver 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1008, 142)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.lblDriver2.Location = New System.Drawing.Point(1008, 168)
        Me.lblDriver2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.lblDriver1.Location = New System.Drawing.Point(1008, 88)
        Me.lblDriver1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDriver1.Name = "lblDriver1"
        Me.lblDriver1.Size = New System.Drawing.Size(89, 20)
        Me.lblDriver1.TabIndex = 35
        Me.lblDriver1.Text = "________"
        '
        'frmSeasons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 554)
        Me.Controls.Add(Me.lblDriver2)
        Me.Controls.Add(Me.lblDriver1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstGPs)
        Me.Controls.Add(Me.lstTeams)
        Me.Controls.Add(Me.txtSeasonYear)
        Me.Controls.Add(Me.selectMaxBox)
        Me.Controls.Add(Me.selectMinBox)
        Me.Controls.Add(Me.btnMainMenuSeasons)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstSeasons)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumberOfGPs)
        Me.Controls.Add(Me.btnGenerateSeasonInfo)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSeasons"
        Me.Text = "frmSeasons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerateSeasonInfo As Button
    Friend WithEvents txtNumberOfGPs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents lstSeasons As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnMainMenuSeasons As Button
    Friend WithEvents selectMinBox As ComboBox
    Friend WithEvents selectMaxBox As ComboBox
    Friend WithEvents txtSeasonYear As TextBox
    Friend WithEvents lstTeams As ListBox
    Friend WithEvents lstGPs As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDriver2 As Label
    Friend WithEvents lblDriver1 As Label
End Class
