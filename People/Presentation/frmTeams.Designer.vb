<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeams
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
        Me.txtcountryid = New System.Windows.Forms.TextBox()
        Me.lblTeamCountry = New System.Windows.Forms.Label()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.lblTeamID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lstTeams = New System.Windows.Forms.ListBox()
        Me.txtCreationDate = New System.Windows.Forms.TextBox()
        Me.lblCreationDate = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcountryid
        '
        Me.txtcountryid.Location = New System.Drawing.Point(468, 358)
        Me.txtcountryid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcountryid.Name = "txtcountryid"
        Me.txtcountryid.Size = New System.Drawing.Size(225, 22)
        Me.txtcountryid.TabIndex = 35
        '
        'lblTeamCountry
        '
        Me.lblTeamCountry.AutoSize = True
        Me.lblTeamCountry.Location = New System.Drawing.Point(460, 324)
        Me.lblTeamCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeamCountry.Name = "lblTeamCountry"
        Me.lblTeamCountry.Size = New System.Drawing.Size(52, 16)
        Me.lblTeamCountry.TabIndex = 34
        Me.lblTeamCountry.Text = "Country"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Location = New System.Drawing.Point(459, 220)
        Me.lblTeamName.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(80, 16)
        Me.lblTeamName.TabIndex = 33
        Me.lblTeamName.Text = "TeamName"
        '
        'lblTeamID
        '
        Me.lblTeamID.AutoSize = True
        Me.lblTeamID.Location = New System.Drawing.Point(459, 100)
        Me.lblTeamID.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTeamID.Name = "lblTeamID"
        Me.lblTeamID.Size = New System.Drawing.Size(56, 16)
        Me.lblTeamID.TabIndex = 32
        Me.lblTeamID.Text = "TeamID"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(1044, 100)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 66)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(1044, 261)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 66)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(781, 261)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 66)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(781, 100)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 66)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(463, 261)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(231, 22)
        Me.txtName.TabIndex = 27
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(463, 141)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(231, 22)
        Me.txtID.TabIndex = 26
        '
        'lstTeams
        '
        Me.lstTeams.FormattingEnabled = True
        Me.lstTeams.ItemHeight = 16
        Me.lstTeams.Location = New System.Drawing.Point(29, 100)
        Me.lstTeams.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lstTeams.Name = "lstTeams"
        Me.lstTeams.Size = New System.Drawing.Size(381, 356)
        Me.lstTeams.TabIndex = 25
        '
        'txtCreationDate
        '
        Me.txtCreationDate.Location = New System.Drawing.Point(468, 434)
        Me.txtCreationDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCreationDate.Name = "txtCreationDate"
        Me.txtCreationDate.Size = New System.Drawing.Size(225, 22)
        Me.txtCreationDate.TabIndex = 37
        '
        'lblCreationDate
        '
        Me.lblCreationDate.AutoSize = True
        Me.lblCreationDate.Location = New System.Drawing.Point(460, 400)
        Me.lblCreationDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCreationDate.Name = "lblCreationDate"
        Me.lblCreationDate.Size = New System.Drawing.Size(89, 16)
        Me.lblCreationDate.TabIndex = 36
        Me.lblCreationDate.Text = "Creation Date"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenu.Location = New System.Drawing.Point(884, 390)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(120, 66)
        Me.btnMainMenu.TabIndex = 43
        Me.btnMainMenu.Text = "Go to main menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frmTeams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 588)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.txtCreationDate)
        Me.Controls.Add(Me.lblCreationDate)
        Me.Controls.Add(Me.txtcountryid)
        Me.Controls.Add(Me.lblTeamCountry)
        Me.Controls.Add(Me.lblTeamName)
        Me.Controls.Add(Me.lblTeamID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lstTeams)
        Me.Name = "frmTeams"
        Me.Text = "frmTeams"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcountryid As TextBox
    Friend WithEvents lblTeamCountry As Label
    Friend WithEvents lblTeamName As Label
    Friend WithEvents lblTeamID As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lstTeams As ListBox
    Friend WithEvents txtCreationDate As TextBox
    Friend WithEvents lblCreationDate As Label
    Friend WithEvents btnMainMenu As Button
End Class
