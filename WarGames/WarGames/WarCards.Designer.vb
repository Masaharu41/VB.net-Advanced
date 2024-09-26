<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarCards
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
        Me.DealButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.Player2PictureBox = New System.Windows.Forms.PictureBox()
        Me.Player1PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DealButton
        '
        Me.DealButton.Location = New System.Drawing.Point(250, 18)
        Me.DealButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DealButton.Name = "DealButton"
        Me.DealButton.Size = New System.Drawing.Size(82, 31)
        Me.DealButton.TabIndex = 0
        Me.DealButton.Text = "Deal"
        Me.DealButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(229, 179)
        Me.PlayButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(111, 35)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'Player2PictureBox
        '
        Me.Player2PictureBox.Location = New System.Drawing.Point(367, 66)
        Me.Player2PictureBox.Name = "Player2PictureBox"
        Me.Player2PictureBox.Size = New System.Drawing.Size(179, 259)
        Me.Player2PictureBox.TabIndex = 2
        Me.Player2PictureBox.TabStop = False
        '
        'Player1PictureBox
        '
        Me.Player1PictureBox.Location = New System.Drawing.Point(28, 66)
        Me.Player1PictureBox.Name = "Player1PictureBox"
        Me.Player1PictureBox.Size = New System.Drawing.Size(177, 259)
        Me.Player1PictureBox.TabIndex = 3
        Me.Player1PictureBox.TabStop = False
        '
        'WarCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 360)
        Me.Controls.Add(Me.Player1PictureBox)
        Me.Controls.Add(Me.Player2PictureBox)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.DealButton)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "WarCards"
        Me.Text = "Form1"
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DealButton As Button
    Friend WithEvents PlayButton As Button
    Friend WithEvents Player2PictureBox As PictureBox
    Friend WithEvents Player1PictureBox As PictureBox
End Class
