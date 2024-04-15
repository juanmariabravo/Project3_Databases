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
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.txtDriver1 = New System.Windows.Forms.TextBox()
        Me.txtDriver2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.LstSeasonTeams = New System.Windows.Forms.ListBox()
        Me.txtNumberteams = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMainMenuSeasons = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(41, 80)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(196, 22)
        Me.txtYear.TabIndex = 0
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
        Me.Label1.Location = New System.Drawing.Point(37, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First, select the year for the season"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(589, 80)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(100, 28)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtTeam
        '
        Me.txtTeam.Location = New System.Drawing.Point(41, 220)
        Me.txtTeam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(196, 22)
        Me.txtTeam.TabIndex = 4
        '
        'txtDriver1
        '
        Me.txtDriver1.Location = New System.Drawing.Point(41, 308)
        Me.txtDriver1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDriver1.Name = "txtDriver1"
        Me.txtDriver1.Size = New System.Drawing.Size(196, 22)
        Me.txtDriver1.TabIndex = 5
        '
        'txtDriver2
        '
        Me.txtDriver2.Location = New System.Drawing.Point(41, 382)
        Me.txtDriver2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDriver2.Name = "txtDriver2"
        Me.txtDriver2.Size = New System.Drawing.Size(196, 22)
        Me.txtDriver2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Insert the id of the team "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 274)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Insert the id of driver 1 "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 351)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Insert the id of driver 2"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(41, 463)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 42)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear fields"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(189, 463)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(117, 42)
        Me.btnInsert.TabIndex = 11
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(333, 463)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(117, 42)
        Me.btnDone.TabIndex = 12
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'LstSeasonTeams
        '
        Me.LstSeasonTeams.FormattingEnabled = True
        Me.LstSeasonTeams.ItemHeight = 16
        Me.LstSeasonTeams.Location = New System.Drawing.Point(788, 44)
        Me.LstSeasonTeams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LstSeasonTeams.Name = "LstSeasonTeams"
        Me.LstSeasonTeams.Size = New System.Drawing.Size(329, 452)
        Me.LstSeasonTeams.TabIndex = 13
        '
        'txtNumberteams
        '
        Me.txtNumberteams.Location = New System.Drawing.Point(333, 80)
        Me.txtNumberteams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumberteams.Name = "txtNumberteams"
        Me.txtNumberteams.Size = New System.Drawing.Size(196, 22)
        Me.txtNumberteams.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 44)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(333, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Now, select how many teams do you want to participate"
        '
        'btnMainMenuSeasons
        '
        Me.btnMainMenuSeasons.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenuSeasons.Location = New System.Drawing.Point(514, 451)
        Me.btnMainMenuSeasons.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnMainMenuSeasons.Name = "btnMainMenuSeasons"
        Me.btnMainMenuSeasons.Size = New System.Drawing.Size(120, 66)
        Me.btnMainMenuSeasons.TabIndex = 26
        Me.btnMainMenuSeasons.Text = "Go to main menu"
        Me.btnMainMenuSeasons.UseVisualStyleBackColor = False
        '
        'frmSeasons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 554)
        Me.Controls.Add(Me.btnMainMenuSeasons)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumberteams)
        Me.Controls.Add(Me.LstSeasonTeams)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDriver2)
        Me.Controls.Add(Me.txtDriver1)
        Me.Controls.Add(Me.txtTeam)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYear)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSeasons"
        Me.Text = "frmSeasons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtYear As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents txtTeam As TextBox
    Friend WithEvents txtDriver1 As TextBox
    Friend WithEvents txtDriver2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents LstSeasonTeams As ListBox
    Friend WithEvents txtNumberteams As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnMainMenuSeasons As Button
End Class
