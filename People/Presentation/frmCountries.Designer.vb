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
        Me.txtCountryPopulation = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCountryID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCountryName = New System.Windows.Forms.TextBox()
        Me.txtCountryID = New System.Windows.Forms.TextBox()
        Me.lstCountries = New System.Windows.Forms.ListBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPopulation
        '
        Me.lblPopulation.AutoSize = True
        Me.lblPopulation.Location = New System.Drawing.Point(380, 277)
        Me.lblPopulation.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPopulation.Name = "lblPopulation"
        Me.lblPopulation.Size = New System.Drawing.Size(71, 16)
        Me.lblPopulation.TabIndex = 25
        Me.lblPopulation.Text = "Population"
        '
        'txtCountryPopulation
        '
        Me.txtCountryPopulation.Location = New System.Drawing.Point(383, 304)
        Me.txtCountryPopulation.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCountryPopulation.Name = "txtCountryPopulation"
        Me.txtCountryPopulation.Size = New System.Drawing.Size(174, 22)
        Me.txtCountryPopulation.TabIndex = 24
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(380, 188)
        Me.lblName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(89, 16)
        Me.lblName.TabIndex = 23
        Me.lblName.Text = "Country name"
        '
        'lblCountryID
        '
        Me.lblCountryID.AutoSize = True
        Me.lblCountryID.Location = New System.Drawing.Point(380, 105)
        Me.lblCountryID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCountryID.Name = "lblCountryID"
        Me.lblCountryID.Size = New System.Drawing.Size(65, 16)
        Me.lblCountryID.TabIndex = 22
        Me.lblCountryID.Text = "CountryID"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(686, 288)
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
        Me.btnClear.Location = New System.Drawing.Point(874, 277)
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
        Me.btnUpdate.Location = New System.Drawing.Point(874, 169)
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
        Me.btnAdd.Location = New System.Drawing.Point(686, 169)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 54)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtCountryName
        '
        Me.txtCountryName.Location = New System.Drawing.Point(383, 216)
        Me.txtCountryName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCountryName.Name = "txtCountryName"
        Me.txtCountryName.Size = New System.Drawing.Size(174, 22)
        Me.txtCountryName.TabIndex = 17
        '
        'txtCountryID
        '
        Me.txtCountryID.Location = New System.Drawing.Point(383, 132)
        Me.txtCountryID.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCountryID.Name = "txtCountryID"
        Me.txtCountryID.Size = New System.Drawing.Size(174, 22)
        Me.txtCountryID.TabIndex = 16
        '
        'lstCountries
        '
        Me.lstCountries.FormattingEnabled = True
        Me.lstCountries.ItemHeight = 16
        Me.lstCountries.Location = New System.Drawing.Point(66, 132)
        Me.lstCountries.Margin = New System.Windows.Forms.Padding(5)
        Me.lstCountries.Name = "lstCountries"
        Me.lstCountries.Size = New System.Drawing.Size(287, 212)
        Me.lstCountries.TabIndex = 15
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenu.Location = New System.Drawing.Point(773, 392)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(120, 66)
        Me.btnMainMenu.TabIndex = 43
        Me.btnMainMenu.Text = "Go to main menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frmCountries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 481)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblPopulation)
        Me.Controls.Add(Me.txtCountryPopulation)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCountryID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCountryName)
        Me.Controls.Add(Me.txtCountryID)
        Me.Controls.Add(Me.lstCountries)
        Me.Name = "frmCountries"
        Me.Text = "Countries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPopulation As Label
    Friend WithEvents txtCountryPopulation As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblCountryID As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtCountryName As TextBox
    Friend WithEvents txtCountryID As TextBox
    Friend WithEvents lstCountries As ListBox
    Friend WithEvents btnMainMenu As Button
End Class
