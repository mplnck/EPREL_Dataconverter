﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LB_Log = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LB_Log
        '
        Me.LB_Log.FormattingEnabled = True
        Me.LB_Log.Location = New System.Drawing.Point(25, 11)
        Me.LB_Log.Name = "LB_Log"
        Me.LB_Log.Size = New System.Drawing.Size(486, 420)
        Me.LB_Log.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 450)
        Me.Controls.Add(Me.LB_Log)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.Text = "Log"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LB_Log As ListBox
End Class
