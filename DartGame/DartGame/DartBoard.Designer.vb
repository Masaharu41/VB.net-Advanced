﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DartBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CircleButton = New System.Windows.Forms.Button()
        Me.DartBoardPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DartBoardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CircleButton
        '
        Me.CircleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CircleButton.Location = New System.Drawing.Point(28, 522)
        Me.CircleButton.Name = "CircleButton"
        Me.CircleButton.Size = New System.Drawing.Size(98, 41)
        Me.CircleButton.TabIndex = 0
        Me.CircleButton.Text = "Circle"
        Me.CircleButton.UseVisualStyleBackColor = True
        '
        'DartBoardPictureBox
        '
        Me.DartBoardPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DartBoardPictureBox.Location = New System.Drawing.Point(61, 36)
        Me.DartBoardPictureBox.Name = "DartBoardPictureBox"
        Me.DartBoardPictureBox.Size = New System.Drawing.Size(1016, 431)
        Me.DartBoardPictureBox.TabIndex = 1
        Me.DartBoardPictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 62)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DartBoard
        '
        Me.ClientSize = New System.Drawing.Size(1154, 581)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DartBoardPictureBox)
        Me.Controls.Add(Me.CircleButton)
        Me.Name = "DartBoard"
        CType(Me.DartBoardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DartBoard As PictureBox
    Friend WithEvents CircleButton As Button
    Friend WithEvents DartBoardPictureBox As PictureBox
    Friend WithEvents Button1 As Button
End Class
