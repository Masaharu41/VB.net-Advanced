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
        Me.OutcomeLabel = New System.Windows.Forms.Label()
        Me.Player2Label = New System.Windows.Forms.Label()
        Me.Player1Label = New System.Windows.Forms.Label()
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DealButton
        '
        Me.DealButton.Location = New System.Drawing.Point(153, 437)
        Me.DealButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DealButton.Name = "DealButton"
        Me.DealButton.Size = New System.Drawing.Size(137, 35)
        Me.DealButton.TabIndex = 0
        Me.DealButton.Text = "Play New Game"
        Me.DealButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(38, 437)
        Me.PlayButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(111, 35)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'Player2PictureBox
        '
        Me.Player2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Player2PictureBox.Location = New System.Drawing.Point(404, 66)
        Me.Player2PictureBox.Name = "Player2PictureBox"
        Me.Player2PictureBox.Size = New System.Drawing.Size(252, 353)
        Me.Player2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player2PictureBox.TabIndex = 2
        Me.Player2PictureBox.TabStop = False
        '
        'Player1PictureBox
        '
        Me.Player1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Player1PictureBox.Location = New System.Drawing.Point(38, 66)
        Me.Player1PictureBox.Name = "Player1PictureBox"
        Me.Player1PictureBox.Size = New System.Drawing.Size(252, 353)
        Me.Player1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player1PictureBox.TabIndex = 3
        Me.Player1PictureBox.TabStop = False
        '
        'OutcomeLabel
        '
        Me.OutcomeLabel.AutoSize = True
        Me.OutcomeLabel.Location = New System.Drawing.Point(333, 444)
        Me.OutcomeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OutcomeLabel.Name = "OutcomeLabel"
        Me.OutcomeLabel.Size = New System.Drawing.Size(323, 20)
        Me.OutcomeLabel.TabIndex = 4
        Me.OutcomeLabel.Text = "Hello! Press Play New Game to begin playing"
        '
        'Player2Label
        '
        Me.Player2Label.AutoSize = True
        Me.Player2Label.Location = New System.Drawing.Point(400, 30)
        Me.Player2Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Player2Label.Name = "Player2Label"
        Me.Player2Label.Size = New System.Drawing.Size(65, 20)
        Me.Player2Label.TabIndex = 5
        Me.Player2Label.Text = "Player 2"
        '
        'Player1Label
        '
        Me.Player1Label.AutoSize = True
        Me.Player1Label.Location = New System.Drawing.Point(34, 30)
        Me.Player1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Player1Label.Name = "Player1Label"
        Me.Player1Label.Size = New System.Drawing.Size(65, 20)
        Me.Player1Label.TabIndex = 6
        Me.Player1Label.Text = "Player 1"
        '
        'WarCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 554)
        Me.Controls.Add(Me.Player1Label)
        Me.Controls.Add(Me.Player2Label)
        Me.Controls.Add(Me.OutcomeLabel)
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
        Me.PerformLayout()

    End Sub

    Friend WithEvents DealButton As Button
    Friend WithEvents PlayButton As Button
    Friend WithEvents Player2PictureBox As PictureBox
    Friend WithEvents Player1PictureBox As PictureBox
    Friend WithEvents OutcomeLabel As Label
    Friend WithEvents Player2Label As Label
    Friend WithEvents Player1Label As Label
End Class
