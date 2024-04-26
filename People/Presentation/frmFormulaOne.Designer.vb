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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOpenRaces = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOpenClassifications = New System.Windows.Forms.Button()
        Me.btnOpenHistory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenGPs
        '
        Me.btnOpenGPs.Enabled = False
        Me.btnOpenGPs.Location = New System.Drawing.Point(248, 195)
        Me.btnOpenGPs.Name = "btnOpenGPs"
        Me.btnOpenGPs.Size = New System.Drawing.Size(137, 46)
        Me.btnOpenGPs.TabIndex = 12
        Me.btnOpenGPs.Text = "GPs"
        Me.btnOpenGPs.UseVisualStyleBackColor = True
        '
        'BtnOpenDrivers
        '
        Me.BtnOpenDrivers.Enabled = False
        Me.BtnOpenDrivers.Location = New System.Drawing.Point(248, 293)
        Me.BtnOpenDrivers.Name = "BtnOpenDrivers"
        Me.BtnOpenDrivers.Size = New System.Drawing.Size(137, 46)
        Me.BtnOpenDrivers.TabIndex = 13
        Me.BtnOpenDrivers.Text = "Drivers"
        Me.BtnOpenDrivers.UseVisualStyleBackColor = True
        '
        'btnOpenTeams
        '
        Me.btnOpenTeams.Enabled = False
        Me.btnOpenTeams.Location = New System.Drawing.Point(47, 293)
        Me.btnOpenTeams.Name = "btnOpenTeams"
        Me.btnOpenTeams.Size = New System.Drawing.Size(137, 46)
        Me.btnOpenTeams.TabIndex = 14
        Me.btnOpenTeams.Text = "Teams"
        Me.btnOpenTeams.UseVisualStyleBackColor = True
        '
        'btnConnectDB
        '
        Me.btnConnectDB.Location = New System.Drawing.Point(57, 46)
        Me.btnConnectDB.Name = "btnConnectDB"
        Me.btnConnectDB.Size = New System.Drawing.Size(211, 47)
        Me.btnConnectDB.TabIndex = 15
        Me.btnConnectDB.Text = "Connect to Database!"
        Me.btnConnectDB.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Gadugi", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(52, 145)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(319, 27)
        Me.lblMsg.TabIndex = 16
        Me.lblMsg.Text = "Management of Information"
        '
        'btnOpenCountries
        '
        Me.btnOpenCountries.Enabled = False
        Me.btnOpenCountries.Location = New System.Drawing.Point(47, 195)
        Me.btnOpenCountries.Name = "btnOpenCountries"
        Me.btnOpenCountries.Size = New System.Drawing.Size(137, 46)
        Me.btnOpenCountries.TabIndex = 17
        Me.btnOpenCountries.Text = "Countries"
        Me.btnOpenCountries.UseVisualStyleBackColor = True
        '
        'btnOpenSeasons
        '
        Me.btnOpenSeasons.Enabled = False
        Me.btnOpenSeasons.Location = New System.Drawing.Point(551, 238)
        Me.btnOpenSeasons.Name = "btnOpenSeasons"
        Me.btnOpenSeasons.Size = New System.Drawing.Size(137, 46)
        Me.btnOpenSeasons.TabIndex = 18
        Me.btnOpenSeasons.Text = "Seasons"
        Me.btnOpenSeasons.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(443, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(520, 27)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Generation of Seasons And Simulation of Races"
        '
        'btnOpenRaces
        '
        Me.btnOpenRaces.Enabled = False
        Me.btnOpenRaces.Location = New System.Drawing.Point(744, 238)
        Me.btnOpenRaces.Name = "btnOpenRaces"
        Me.btnOpenRaces.Size = New System.Drawing.Size(137, 46)
        Me.btnOpenRaces.TabIndex = 20
        Me.btnOpenRaces.Text = "Races"
        Me.btnOpenRaces.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1078, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 27)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Reports ans Histories"
        '
        'btnOpenClassifications
        '
        Me.btnOpenClassifications.Enabled = False
        Me.btnOpenClassifications.Location = New System.Drawing.Point(1073, 195)
        Me.btnOpenClassifications.Name = "btnOpenClassifications"
        Me.btnOpenClassifications.Size = New System.Drawing.Size(261, 46)
        Me.btnOpenClassifications.TabIndex = 22
        Me.btnOpenClassifications.Text = "Classifications and Champions"
        Me.btnOpenClassifications.UseVisualStyleBackColor = True
        '
        'btnOpenHistory
        '
        Me.btnOpenHistory.Enabled = False
        Me.btnOpenHistory.Location = New System.Drawing.Point(1073, 293)
        Me.btnOpenHistory.Name = "btnOpenHistory"
        Me.btnOpenHistory.Size = New System.Drawing.Size(261, 46)
        Me.btnOpenHistory.TabIndex = 23
        Me.btnOpenHistory.Text = "Drivers and Teams History"
        Me.btnOpenHistory.UseVisualStyleBackColor = True
        '
        'frmFormulaOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1435, 562)
        Me.Controls.Add(Me.btnOpenHistory)
        Me.Controls.Add(Me.btnOpenClassifications)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOpenRaces)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOpenRaces As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOpenClassifications As Button
    Friend WithEvents btnOpenHistory As Button
End Class
