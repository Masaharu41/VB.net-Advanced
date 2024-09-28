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
        Me.DealButton.Location = New System.Drawing.Point(333, 22)
        Me.DealButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DealButton.Name = "DealButton"
        Me.DealButton.Size = New System.Drawing.Size(109, 39)
        Me.DealButton.TabIndex = 0
        Me.DealButton.Text = "Deal"
        Me.DealButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(305, 224)
        Me.PlayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(148, 44)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'Player2PictureBox
        '
        Me.Player2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Player2PictureBox.Location = New System.Drawing.Point(489, 82)
        Me.Player2PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2PictureBox.Name = "Player2PictureBox"
        Me.Player2PictureBox.Size = New System.Drawing.Size(239, 324)
        Me.Player2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player2PictureBox.TabIndex = 2
        Me.Player2PictureBox.TabStop = False
        '
        'Player1PictureBox
        '
        Me.Player1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Player1PictureBox.Location = New System.Drawing.Point(50, 82)
        Me.Player1PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1PictureBox.Name = "Player1PictureBox"
        Me.Player1PictureBox.Size = New System.Drawing.Size(236, 324)
        Me.Player1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player1PictureBox.TabIndex = 3
        Me.Player1PictureBox.TabStop = False
        '
        'WarCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Player1PictureBox)
        Me.Controls.Add(Me.Player2PictureBox)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.DealButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
