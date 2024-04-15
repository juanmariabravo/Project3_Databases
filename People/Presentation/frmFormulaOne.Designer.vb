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
        Me.btnOpenGPs = New System.Windows.Forms.Button()
        Me.BtnOpenDrivers = New System.Windows.Forms.Button()
        Me.btnOpenTeams = New System.Windows.Forms.Button()
        Me.btnConnectDB = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnOpenCountries = New System.Windows.Forms.Button()
        Me.btnOpenSeasons = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenGPs
        '
        Me.btnOpenGPs.Enabled = False
        Me.btnOpenGPs.Location = New System.Drawing.Point(274, 349)
        Me.btnOpenGPs.Name = "btnOpenGPs"
        Me.btnOpenGPs.Size = New System.Drawing.Size(137, 46)
        Me.btnOpenGPs.TabIndex = 12
        Me.btnOpenGPs.Text = "GPs"
        Me.btnOpenGPs.UseVisualStyleBackColor = True
        '
        'BtnOpenDrivers
        '
        Me.BtnOpenDrivers.Enabled = False
        Me.BtnOpenDrivers.Location = New System.Drawing.Point(694, 349)
        Me.BtnOpenDrivers.Name = "BtnOpenDrivers"
        Me.BtnOpenDrivers.Size = New System.Drawing.Size(137, 46)
        Me.BtnOpenDrivers.TabIndex = 13
        Me.BtnOpenDrivers.Text = "Drivers"
        Me.BtnOpenDrivers.UseVisualStyleBackColor = True
        '
        'btnOpenTeams
        '
        Me.btnOpenTeams.Enabled = False
        Me.btnOpenTeams.Location = New System.Drawing.Point(485, 349)
        Me.btnOpenTeams.Name = "btnOpenTeams"
        Me.btnOpenTeams.Size = New System.Drawing.Size(137, 46)
        Me.btnOpenTeams.TabIndex = 14
        Me.btnOpenTeams.Text = "Teams"
        Me.btnOpenTeams.UseVisualStyleBackColor = True
        '
        'btnConnectDB
        '
        Me.btnConnectDB.Location = New System.Drawing.Point(452, 72)
        Me.btnConnectDB.Name = "btnConnectDB"
        Me.btnConnectDB.Size = New System.Drawing.Size(188, 101)
        Me.btnConnectDB.TabIndex = 15
        Me.btnConnectDB.Text = "Connect to Database!"
        Me.btnConnectDB.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(324, 275)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(452, 21)
        Me.lblMsg.TabIndex = 16
        Me.lblMsg.Text = "Select what type of information do you want to modify:"
        '
        'btnOpenCountries
        '
        Me.btnOpenCountries.Enabled = False
        Me.btnOpenCountries.Location = New System.Drawing.Point(57, 349)
        Me.btnOpenCountries.Name = "btnOpenCountries"
        Me.btnOpenCountries.Size = New System.Drawing.Size(137, 46)
        Me.btnOpenCountries.TabIndex = 17
        Me.btnOpenCountries.Text = "Country"
        Me.btnOpenCountries.UseVisualStyleBackColor = True
        '
        'btnOpenSeasons
        '
        Me.btnOpenSeasons.Enabled = False
        Me.btnOpenSeasons.Location = New System.Drawing.Point(885, 349)
        Me.btnOpenSeasons.Name = "btnOpenSeasons"
        Me.btnOpenSeasons.Size = New System.Drawing.Size(137, 46)
        Me.btnOpenSeasons.TabIndex = 18
        Me.btnOpenSeasons.Text = "Seasons"
        Me.btnOpenSeasons.UseVisualStyleBackColor = True
        '
        'frmFormulaOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1093, 465)
        Me.Controls.Add(Me.btnOpenSeasons)
        Me.Controls.Add(Me.btnOpenCountries)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnConnectDB)
        Me.Controls.Add(Me.btnOpenTeams)
        Me.Controls.Add(Me.BtnOpenDrivers)
        Me.Controls.Add(Me.btnOpenGPs)
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
    Friend WithEvents btnOpenGPs As Button
    Friend WithEvents BtnOpenDrivers As Button
    Friend WithEvents btnOpenTeams As Button
    Friend WithEvents btnConnectDB As Button
    Friend WithEvents lblMsg As Label
    Friend WithEvents btnOpenCountries As Button
    Friend WithEvents btnOpenSeasons As Button
End Class
