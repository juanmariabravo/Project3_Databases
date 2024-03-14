<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFormulaOne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormulaOne))
        Me.btnOpenDB = New System.Windows.Forms.Button()
        Me.lstCountries = New System.Windows.Forms.ListBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblCountryID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtPopulation = New System.Windows.Forms.TextBox()
        Me.lblPopulation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOpenDB
        '
        Me.btnOpenDB.Location = New System.Drawing.Point(90, 370)
        Me.btnOpenDB.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOpenDB.Name = "btnOpenDB"
        Me.btnOpenDB.Size = New System.Drawing.Size(161, 68)
        Me.btnOpenDB.TabIndex = 0
        Me.btnOpenDB.Text = "Connect to database!"
        Me.btnOpenDB.UseVisualStyleBackColor = True
        '
        'lstCountries
        '
        Me.lstCountries.FormattingEnabled = True
        Me.lstCountries.ItemHeight = 21
        Me.lstCountries.Location = New System.Drawing.Point(25, 83)
        Me.lstCountries.Margin = New System.Windows.Forms.Padding(5)
        Me.lstCountries.Name = "lstCountries"
        Me.lstCountries.Size = New System.Drawing.Size(287, 235)
        Me.lstCountries.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(351, 177)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(174, 31)
        Me.txtID.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(614, 177)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(174, 31)
        Me.txtName.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(320, 377)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 54)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(516, 377)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 54)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(912, 377)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 54)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(715, 377)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 54)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblCountryID
        '
        Me.lblCountryID.AutoSize = True
        Me.lblCountryID.Location = New System.Drawing.Point(390, 221)
        Me.lblCountryID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCountryID.Name = "lblCountryID"
        Me.lblCountryID.Size = New System.Drawing.Size(91, 21)
        Me.lblCountryID.TabIndex = 8
        Me.lblCountryID.Text = "CountryID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(673, 221)
        Me.lblName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(57, 21)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Name"
        '
        'txtPopulation
        '
        Me.txtPopulation.Location = New System.Drawing.Point(877, 177)
        Me.txtPopulation.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtPopulation.Name = "txtPopulation"
        Me.txtPopulation.Size = New System.Drawing.Size(174, 31)
        Me.txtPopulation.TabIndex = 10
        '
        'lblPopulation
        '
        Me.lblPopulation.AutoSize = True
        Me.lblPopulation.Location = New System.Drawing.Point(923, 221)
        Me.lblPopulation.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPopulation.Name = "lblPopulation"
        Me.lblPopulation.Size = New System.Drawing.Size(96, 21)
        Me.lblPopulation.TabIndex = 11
        Me.lblPopulation.Text = "Population"
        '
        'frmFormulaOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(1093, 521)
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
        Me.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFormulaOne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormulaOne DB Project 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenDB As Button
    Friend WithEvents lstCountries As ListBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblCountryID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtPopulation As TextBox
    Friend WithEvents lblPopulation As Label
End Class
