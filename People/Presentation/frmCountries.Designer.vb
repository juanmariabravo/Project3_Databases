<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountries
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
        Me.lblPopulation = New System.Windows.Forms.Label()
        Me.txtPopulation = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCountryID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lstCountries = New System.Windows.Forms.ListBox()
        Me.btnOpenDB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPopulation
        '
        Me.lblPopulation.AutoSize = True
        Me.lblPopulation.Location = New System.Drawing.Point(989, 273)
        Me.lblPopulation.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPopulation.Name = "lblPopulation"
        Me.lblPopulation.Size = New System.Drawing.Size(71, 16)
        Me.lblPopulation.TabIndex = 25
        Me.lblPopulation.Text = "Population"
        '
        'txtPopulation
        '
        Me.txtPopulation.Location = New System.Drawing.Point(943, 229)
        Me.txtPopulation.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtPopulation.Name = "txtPopulation"
        Me.txtPopulation.Size = New System.Drawing.Size(174, 22)
        Me.txtPopulation.TabIndex = 24
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(739, 273)
        Me.lblName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 23
        Me.lblName.Text = "Name"
        '
        'lblCountryID
        '
        Me.lblCountryID.AutoSize = True
        Me.lblCountryID.Location = New System.Drawing.Point(456, 273)
        Me.lblCountryID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCountryID.Name = "lblCountryID"
        Me.lblCountryID.Size = New System.Drawing.Size(65, 16)
        Me.lblCountryID.TabIndex = 22
        Me.lblCountryID.Text = "CountryID"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(781, 429)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 54)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(978, 429)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 54)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(582, 429)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 54)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(386, 429)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 54)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(680, 229)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(174, 22)
        Me.txtName.TabIndex = 17
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(417, 229)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(174, 22)
        Me.txtID.TabIndex = 16
        '
        'lstCountries
        '
        Me.lstCountries.FormattingEnabled = True
        Me.lstCountries.ItemHeight = 16
        Me.lstCountries.Location = New System.Drawing.Point(91, 135)
        Me.lstCountries.Margin = New System.Windows.Forms.Padding(5)
        Me.lstCountries.Name = "lstCountries"
        Me.lstCountries.Size = New System.Drawing.Size(287, 212)
        Me.lstCountries.TabIndex = 15
        '
        'btnOpenDB
        '
        Me.btnOpenDB.Location = New System.Drawing.Point(156, 422)
        Me.btnOpenDB.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOpenDB.Name = "btnOpenDB"
        Me.btnOpenDB.Size = New System.Drawing.Size(161, 68)
        Me.btnOpenDB.TabIndex = 14
        Me.btnOpenDB.Text = "Connect to database!"
        Me.btnOpenDB.UseVisualStyleBackColor = True
        '
        'frmCountries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 601)
        Me.Controls.Add(Me.lblPopulation)
        Me.Controls.Add(Me.txtPopulation)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCountryID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lstCountries)
        Me.Controls.Add(Me.btnOpenDB)
        Me.Name = "frmCountries"
        Me.Text = "Countries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPopulation As Label
    Friend WithEvents txtPopulation As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblCountryID As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lstCountries As ListBox
    Friend WithEvents btnOpenDB As Button
End Class
