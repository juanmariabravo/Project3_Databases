﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRaces
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
        Me.btnPreviousfrm = New System.Windows.Forms.Button()
        Me.lstSeasons = New System.Windows.Forms.ListBox()
        Me.lblDriver1 = New System.Windows.Forms.Label()
        Me.lblDriver2 = New System.Windows.Forms.Label()
        Me.lblDriver3 = New System.Windows.Forms.Label()
        Me.lblDriver4 = New System.Windows.Forms.Label()
        Me.lblDriver5 = New System.Windows.Forms.Label()
        Me.lblDriver6 = New System.Windows.Forms.Label()
        Me.lblPositions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstGPs
        '
        Me.lstGPs.FormattingEnabled = True
        Me.lstGPs.ItemHeight = 16
        Me.lstGPs.Location = New System.Drawing.Point(343, 113)
        Me.lstGPs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstGPs.Name = "lstGPs"
        Me.lstGPs.Size = New System.Drawing.Size(200, 292)
        Me.lstGPs.TabIndex = 32
        '
        'btnPreviousfrm
        '
        Me.btnPreviousfrm.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnPreviousfrm.Location = New System.Drawing.Point(963, 475)
        Me.btnPreviousfrm.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnPreviousfrm.Name = "btnPreviousfrm"
        Me.btnPreviousfrm.Size = New System.Drawing.Size(120, 66)
        Me.btnPreviousfrm.TabIndex = 33
        Me.btnPreviousfrm.Text = "Go back"
        Me.btnPreviousfrm.UseVisualStyleBackColor = False
        '
        'lstSeasons
        '
        Me.lstSeasons.FormattingEnabled = True
        Me.lstSeasons.ItemHeight = 16
        Me.lstSeasons.Location = New System.Drawing.Point(52, 39)
        Me.lstSeasons.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSeasons.Name = "lstSeasons"
        Me.lstSeasons.Size = New System.Drawing.Size(248, 452)
        Me.lstSeasons.TabIndex = 40
        '
        'lblDriver1
        '
        Me.lblDriver1.AutoSize = True
        Me.lblDriver1.Location = New System.Drawing.Point(618, 230)
        Me.lblDriver1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDriver1.Name = "lblDriver1"
        Me.lblDriver1.Size = New System.Drawing.Size(53, 16)
        Me.lblDriver1.TabIndex = 41
        Me.lblDriver1.Text = "Driver 1"
        '
        'lblDriver2
        '
        Me.lblDriver2.AutoSize = True
        Me.lblDriver2.Location = New System.Drawing.Point(731, 230)
        Me.lblDriver2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDriver2.Name = "lblDriver2"
        Me.lblDriver2.Size = New System.Drawing.Size(53, 16)
        Me.lblDriver2.TabIndex = 42
        Me.lblDriver2.Text = "Driver 2"
        '
        'lblDriver3
        '
        Me.lblDriver3.AutoSize = True
        Me.lblDriver3.Location = New System.Drawing.Point(848, 230)
        Me.lblDriver3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDriver3.Name = "lblDriver3"
        Me.lblDriver3.Size = New System.Drawing.Size(53, 16)
        Me.lblDriver3.TabIndex = 43
        Me.lblDriver3.Text = "Driver 3"
        '
        'lblDriver4
        '
        Me.lblDriver4.AutoSize = True
        Me.lblDriver4.Location = New System.Drawing.Point(618, 306)
        Me.lblDriver4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDriver4.Name = "lblDriver4"
        Me.lblDriver4.Size = New System.Drawing.Size(53, 16)
        Me.lblDriver4.TabIndex = 44
        Me.lblDriver4.Text = "Driver 4"
        '
        'lblDriver5
        '
        Me.lblDriver5.AutoSize = True
        Me.lblDriver5.Location = New System.Drawing.Point(731, 306)
        Me.lblDriver5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDriver5.Name = "lblDriver5"
        Me.lblDriver5.Size = New System.Drawing.Size(53, 16)
        Me.lblDriver5.TabIndex = 45
        Me.lblDriver5.Text = "Driver 5"
        '
        'lblDriver6
        '
        Me.lblDriver6.AutoSize = True
        Me.lblDriver6.Location = New System.Drawing.Point(848, 306)
        Me.lblDriver6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDriver6.Name = "lblDriver6"
        Me.lblDriver6.Size = New System.Drawing.Size(53, 16)
        Me.lblDriver6.TabIndex = 46
        Me.lblDriver6.Text = "Driver 6"
        '
        'lblPositions
        '
        Me.lblPositions.AutoSize = True
        Me.lblPositions.Location = New System.Drawing.Point(714, 156)
        Me.lblPositions.Name = "lblPositions"
        Me.lblPositions.Size = New System.Drawing.Size(88, 16)
        Me.lblPositions.TabIndex = 47
        Me.lblPositions.Text = "TitlePositions"
        '
        'frmRaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 569)
        Me.Controls.Add(Me.lblPositions)
        Me.Controls.Add(Me.lblDriver6)
        Me.Controls.Add(Me.lblDriver5)
        Me.Controls.Add(Me.lblDriver4)
        Me.Controls.Add(Me.lblDriver3)
        Me.Controls.Add(Me.lblDriver2)
        Me.Controls.Add(Me.lblDriver1)
        Me.Controls.Add(Me.lstSeasons)
        Me.Controls.Add(Me.btnPreviousfrm)
        Me.Controls.Add(Me.lstGPs)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRaces"
        Me.Text = "frmRaces"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGPs As ListBox
    Friend WithEvents btnPreviousfrm As Button
    Friend WithEvents lstSeasons As ListBox
    Friend WithEvents lblDriver1 As Label
    Friend WithEvents lblDriver2 As Label
    Friend WithEvents lblDriver3 As Label
    Friend WithEvents lblDriver4 As Label
    Friend WithEvents lblDriver5 As Label
    Friend WithEvents lblDriver6 As Label
    Friend WithEvents lblPositions As Label
End Class
