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
        Me.lblGPName = New System.Windows.Forms.Label()
        Me.lblGPID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lstGPs = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcountryid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblGPName
        '
        Me.lblGPName.AutoSize = True
        Me.lblGPName.Location = New System.Drawing.Point(337, 144)
        Me.lblGPName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGPName.Name = "lblGPName"
        Me.lblGPName.Size = New System.Drawing.Size(50, 13)
        Me.lblGPName.TabIndex = 21
        Me.lblGPName.Text = "GPName"
        '
        'lblGPID
        '
        Me.lblGPID.AutoSize = True
        Me.lblGPID.Location = New System.Drawing.Point(337, 46)
        Me.lblGPID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGPID.Name = "lblGPID"
        Me.lblGPID.Size = New System.Drawing.Size(33, 13)
        Me.lblGPID.TabIndex = 20
        Me.lblGPID.Text = "GPID"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(897, 46)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 54)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(897, 177)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 54)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(700, 177)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 54)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(700, 46)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 54)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(340, 177)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(174, 20)
        Me.txtName.TabIndex = 15
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(340, 80)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(174, 20)
        Me.txtID.TabIndex = 14
        '
        'lstGPs
        '
        Me.lstGPs.FormattingEnabled = True
        Me.lstGPs.Location = New System.Drawing.Point(14, 46)
        Me.lstGPs.Margin = New System.Windows.Forms.Padding(5)
        Me.lstGPs.Name = "lstGPs"
        Me.lstGPs.Size = New System.Drawing.Size(287, 290)
        Me.lstGPs.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Country"
        '
        'txtcountryid
        '
        Me.txtcountryid.Location = New System.Drawing.Point(343, 300)
        Me.txtcountryid.Name = "txtcountryid"
        Me.txtcountryid.Size = New System.Drawing.Size(170, 20)
        Me.txtcountryid.TabIndex = 24
        '
        'frmGPs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 450)
        Me.Controls.Add(Me.txtcountryid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGPName)
        Me.Controls.Add(Me.lblGPID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lstGPs)
        Me.Name = "frmGPs"
        Me.Text = "GPs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGPName As Label
    Friend WithEvents lblGPID As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lstGPs As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcountryid As TextBox
End Class
