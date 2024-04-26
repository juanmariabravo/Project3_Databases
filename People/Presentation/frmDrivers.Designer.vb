<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrivers
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
        Me.txtBxDriverCountry = New System.Windows.Forms.TextBox()
        Me.lblDriverCountry = New System.Windows.Forms.Label()
        Me.lblDriverName = New System.Windows.Forms.Label()
        Me.lblDriverID = New System.Windows.Forms.Label()
        Me.txtBxDriverName = New System.Windows.Forms.TextBox()
        Me.txtBxDriverID = New System.Windows.Forms.TextBox()
        Me.lstDrivers = New System.Windows.Forms.ListBox()
        Me.lblDriverSurname = New System.Windows.Forms.Label()
        Me.txtBxDriverSurname = New System.Windows.Forms.TextBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnDeleteDriver = New System.Windows.Forms.Button()
        Me.btnClearDriverFields = New System.Windows.Forms.Button()
        Me.btnUpdateDriver = New System.Windows.Forms.Button()
        Me.btnAddDriver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBxDriverCountry
        '
        Me.txtBxDriverCountry.Location = New System.Drawing.Point(440, 406)
        Me.txtBxDriverCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxDriverCountry.Name = "txtBxDriverCountry"
        Me.txtBxDriverCountry.Size = New System.Drawing.Size(225, 22)
        Me.txtBxDriverCountry.TabIndex = 35
        '
        'lblDriverCountry
        '
        Me.lblDriverCountry.AutoSize = True
        Me.lblDriverCountry.Location = New System.Drawing.Point(439, 365)
        Me.lblDriverCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDriverCountry.Name = "lblDriverCountry"
        Me.lblDriverCountry.Size = New System.Drawing.Size(101, 16)
        Me.lblDriverCountry.TabIndex = 34
        Me.lblDriverCountry.Text = "Driver's Country"
        '
        'lblDriverName
        '
        Me.lblDriverName.AutoSize = True
        Me.lblDriverName.Location = New System.Drawing.Point(439, 189)
        Me.lblDriverName.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblDriverName.Name = "lblDriverName"
        Me.lblDriverName.Size = New System.Drawing.Size(93, 16)
        Me.lblDriverName.TabIndex = 33
        Me.lblDriverName.Text = "Driver's Name"
        '
        'lblDriverID
        '
        Me.lblDriverID.AutoSize = True
        Me.lblDriverID.Location = New System.Drawing.Point(438, 101)
        Me.lblDriverID.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblDriverID.Name = "lblDriverID"
        Me.lblDriverID.Size = New System.Drawing.Size(69, 16)
        Me.lblDriverID.TabIndex = 32
        Me.lblDriverID.Text = "Driver's ID"
        '
        'txtBxDriverName
        '
        Me.txtBxDriverName.Location = New System.Drawing.Point(442, 230)
        Me.txtBxDriverName.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtBxDriverName.Name = "txtBxDriverName"
        Me.txtBxDriverName.Size = New System.Drawing.Size(231, 22)
        Me.txtBxDriverName.TabIndex = 27
        '
        'txtBxDriverID
        '
        Me.txtBxDriverID.Location = New System.Drawing.Point(442, 142)
        Me.txtBxDriverID.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtBxDriverID.Name = "txtBxDriverID"
        Me.txtBxDriverID.Size = New System.Drawing.Size(231, 22)
        Me.txtBxDriverID.TabIndex = 26
        '
        'lstDrivers
        '
        Me.lstDrivers.FormattingEnabled = True
        Me.lstDrivers.ItemHeight = 16
        Me.lstDrivers.Location = New System.Drawing.Point(11, 87)
        Me.lstDrivers.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lstDrivers.Name = "lstDrivers"
        Me.lstDrivers.Size = New System.Drawing.Size(381, 356)
        Me.lstDrivers.TabIndex = 25
        '
        'lblDriverSurname
        '
        Me.lblDriverSurname.AutoSize = True
        Me.lblDriverSurname.Location = New System.Drawing.Point(438, 277)
        Me.lblDriverSurname.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblDriverSurname.Name = "lblDriverSurname"
        Me.lblDriverSurname.Size = New System.Drawing.Size(110, 16)
        Me.lblDriverSurname.TabIndex = 37
        Me.lblDriverSurname.Text = "Driver's Surname"
        '
        'txtBxDriverSurname
        '
        Me.txtBxDriverSurname.Location = New System.Drawing.Point(440, 318)
        Me.txtBxDriverSurname.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtBxDriverSurname.Name = "txtBxDriverSurname"
        Me.txtBxDriverSurname.Size = New System.Drawing.Size(231, 22)
        Me.txtBxDriverSurname.TabIndex = 36
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenu.Location = New System.Drawing.Point(840, 333)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(120, 66)
        Me.btnMainMenu.TabIndex = 42
        Me.btnMainMenu.Text = "Go to main menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnDeleteDriver
        '
        Me.btnDeleteDriver.Enabled = False
        Me.btnDeleteDriver.Location = New System.Drawing.Point(922, 150)
        Me.btnDeleteDriver.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnDeleteDriver.Name = "btnDeleteDriver"
        Me.btnDeleteDriver.Size = New System.Drawing.Size(120, 66)
        Me.btnDeleteDriver.TabIndex = 41
        Me.btnDeleteDriver.Text = "Delete Driver"
        Me.btnDeleteDriver.UseVisualStyleBackColor = True
        '
        'btnClearDriverFields
        '
        Me.btnClearDriverFields.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClearDriverFields.Location = New System.Drawing.Point(922, 241)
        Me.btnClearDriverFields.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnClearDriverFields.Name = "btnClearDriverFields"
        Me.btnClearDriverFields.Size = New System.Drawing.Size(120, 66)
        Me.btnClearDriverFields.TabIndex = 40
        Me.btnClearDriverFields.Text = "Clear Fields"
        Me.btnClearDriverFields.UseVisualStyleBackColor = True
        '
        'btnUpdateDriver
        '
        Me.btnUpdateDriver.Enabled = False
        Me.btnUpdateDriver.Location = New System.Drawing.Point(768, 241)
        Me.btnUpdateDriver.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnUpdateDriver.Name = "btnUpdateDriver"
        Me.btnUpdateDriver.Size = New System.Drawing.Size(120, 66)
        Me.btnUpdateDriver.TabIndex = 39
        Me.btnUpdateDriver.Text = "Update Driver"
        Me.btnUpdateDriver.UseVisualStyleBackColor = True
        '
        'btnAddDriver
        '
        Me.btnAddDriver.Enabled = False
        Me.btnAddDriver.Location = New System.Drawing.Point(768, 150)
        Me.btnAddDriver.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnAddDriver.Name = "btnAddDriver"
        Me.btnAddDriver.Size = New System.Drawing.Size(120, 66)
        Me.btnAddDriver.TabIndex = 38
        Me.btnAddDriver.Text = "Insert Driver"
        Me.btnAddDriver.UseVisualStyleBackColor = True
        '
        'frmDrivers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 530)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnDeleteDriver)
        Me.Controls.Add(Me.btnClearDriverFields)
        Me.Controls.Add(Me.btnUpdateDriver)
        Me.Controls.Add(Me.btnAddDriver)
        Me.Controls.Add(Me.lblDriverSurname)
        Me.Controls.Add(Me.txtBxDriverSurname)
        Me.Controls.Add(Me.txtBxDriverCountry)
        Me.Controls.Add(Me.lblDriverCountry)
        Me.Controls.Add(Me.lblDriverName)
        Me.Controls.Add(Me.lblDriverID)
        Me.Controls.Add(Me.txtBxDriverName)
        Me.Controls.Add(Me.txtBxDriverID)
        Me.Controls.Add(Me.lstDrivers)
        Me.Name = "frmDrivers"
        Me.Text = "Drivers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBxDriverCountry As TextBox
    Friend WithEvents lblDriverCountry As Label
    Friend WithEvents lblDriverName As Label
    Friend WithEvents lblDriverID As Label
    Friend WithEvents txtBxDriverName As TextBox
    Friend WithEvents txtBxDriverID As TextBox
    Friend WithEvents lstDrivers As ListBox
    Friend WithEvents lblDriverSurname As Label
    Friend WithEvents txtBxDriverSurname As TextBox
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnDeleteDriver As Button
    Friend WithEvents btnClearDriverFields As Button
    Friend WithEvents btnUpdateDriver As Button
    Friend WithEvents btnAddDriver As Button
End Class
