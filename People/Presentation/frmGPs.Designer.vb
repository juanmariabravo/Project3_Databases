<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGPs
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
        Me.lstGPs = New System.Windows.Forms.ListBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblGPID = New System.Windows.Forms.Label()
        Me.lblGPName = New System.Windows.Forms.Label()
        Me.lblGPCountry = New System.Windows.Forms.Label()
        Me.txtcountryid = New System.Windows.Forms.TextBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstGPs
        '
        Me.lstGPs.FormattingEnabled = True
        Me.lstGPs.ItemHeight = 16
        Me.lstGPs.Location = New System.Drawing.Point(19, 57)
        Me.lstGPs.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lstGPs.Name = "lstGPs"
        Me.lstGPs.Size = New System.Drawing.Size(381, 356)
        Me.lstGPs.TabIndex = 13
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(453, 98)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(231, 22)
        Me.txtID.TabIndex = 14
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(453, 218)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(231, 22)
        Me.txtName.TabIndex = 15
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(933, 57)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 66)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(933, 218)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 66)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(1196, 218)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 66)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(1196, 57)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 66)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblGPID
        '
        Me.lblGPID.AutoSize = True
        Me.lblGPID.Location = New System.Drawing.Point(449, 57)
        Me.lblGPID.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblGPID.Name = "lblGPID"
        Me.lblGPID.Size = New System.Drawing.Size(39, 16)
        Me.lblGPID.TabIndex = 20
        Me.lblGPID.Text = "GPID"
        '
        'lblGPName
        '
        Me.lblGPName.AutoSize = True
        Me.lblGPName.Location = New System.Drawing.Point(449, 177)
        Me.lblGPName.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblGPName.Name = "lblGPName"
        Me.lblGPName.Size = New System.Drawing.Size(63, 16)
        Me.lblGPName.TabIndex = 21
        Me.lblGPName.Text = "GPName"
        '
        'lblGPCountry
        '
        Me.lblGPCountry.AutoSize = True
        Me.lblGPCountry.Location = New System.Drawing.Point(449, 335)
        Me.lblGPCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGPCountry.Name = "lblGPCountry"
        Me.lblGPCountry.Size = New System.Drawing.Size(52, 16)
        Me.lblGPCountry.TabIndex = 23
        Me.lblGPCountry.Text = "Country"
        '
        'txtcountryid
        '
        Me.txtcountryid.Location = New System.Drawing.Point(457, 369)
        Me.txtcountryid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcountryid.Name = "txtcountryid"
        Me.txtcountryid.Size = New System.Drawing.Size(225, 22)
        Me.txtcountryid.TabIndex = 24
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Enabled = True
        Me.btnMainMenu.Location = New System.Drawing.Point(1067, 369)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(120, 66)
        Me.btnMainMenu.TabIndex = 25
        Me.btnMainMenu.Text = "Go to main menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'frmGPs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1417, 554)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.txtcountryid)
        Me.Controls.Add(Me.lblGPCountry)
        Me.Controls.Add(Me.lblGPName)
        Me.Controls.Add(Me.lblGPID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lstGPs)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGPs"
        Me.Text = "GPs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGPs As ListBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblGPID As Label
    Friend WithEvents lblGPName As Label
    Friend WithEvents lblGPCountry As Label
    Friend WithEvents txtcountryid As TextBox
    Friend WithEvents btnMainMenu As Button
End Class
