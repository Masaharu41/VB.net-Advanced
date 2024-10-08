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
        Me.components = New System.ComponentModel.Container()
        Me.DealButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.Player2PictureBox = New System.Windows.Forms.PictureBox()
        Me.Player1PictureBox = New System.Windows.Forms.PictureBox()
        Me.OutcomeLabel = New System.Windows.Forms.Label()
        Me.Player2Label = New System.Windows.Forms.Label()
        Me.Player1Label = New System.Windows.Forms.Label()
        Me.PlayLabel = New System.Windows.Forms.Label()
        Me.PlaysLabel = New System.Windows.Forms.Label()
        Me.GameLabel = New System.Windows.Forms.Label()
        Me.GamesLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.WarToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.WarToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.AboutToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DealButton
        '
        Me.DealButton.BackColor = System.Drawing.Color.Ivory
        Me.DealButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DealButton.Location = New System.Drawing.Point(223, 575)
        Me.DealButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DealButton.Name = "DealButton"
        Me.DealButton.Size = New System.Drawing.Size(182, 44)
        Me.DealButton.TabIndex = 0
        Me.DealButton.Text = "Play New Game"
        Me.WarToolTip.SetToolTip(Me.DealButton, "Press to Deal Cards or press ""D""")
        Me.DealButton.UseVisualStyleBackColor = False
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.Ivory
        Me.PlayButton.Location = New System.Drawing.Point(69, 575)
        Me.PlayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(148, 44)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.Text = "Play"
        Me.WarToolTip.SetToolTip(Me.PlayButton, "Click to Start a war or press ""G""")
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'Player2PictureBox
        '
        Me.Player2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Player2PictureBox.Location = New System.Drawing.Point(557, 111)
        Me.Player2PictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Player2PictureBox.Name = "Player2PictureBox"
        Me.Player2PictureBox.Size = New System.Drawing.Size(336, 442)
        Me.Player2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player2PictureBox.TabIndex = 2
        Me.Player2PictureBox.TabStop = False
        Me.WarToolTip.SetToolTip(Me.Player2PictureBox, "Player 2 Card Display")
        '
        'Player1PictureBox
        '
        Me.Player1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Player1PictureBox.Location = New System.Drawing.Point(69, 111)
        Me.Player1PictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Player1PictureBox.Name = "Player1PictureBox"
        Me.Player1PictureBox.Size = New System.Drawing.Size(336, 442)
        Me.Player1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player1PictureBox.TabIndex = 3
        Me.Player1PictureBox.TabStop = False
        Me.WarToolTip.SetToolTip(Me.Player1PictureBox, "Player 1 Card Display")
        '
        'OutcomeLabel
        '
        Me.OutcomeLabel.AutoSize = True
        Me.OutcomeLabel.BackColor = System.Drawing.Color.White
        Me.OutcomeLabel.Location = New System.Drawing.Point(463, 584)
        Me.OutcomeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OutcomeLabel.Name = "OutcomeLabel"
        Me.OutcomeLabel.Size = New System.Drawing.Size(445, 25)
        Me.OutcomeLabel.TabIndex = 4
        Me.OutcomeLabel.Text = "Hello! Press Play New Game to begin playing"
        '
        'Player2Label
        '
        Me.Player2Label.AutoSize = True
        Me.Player2Label.BackColor = System.Drawing.Color.White
        Me.Player2Label.Location = New System.Drawing.Point(552, 67)
        Me.Player2Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Player2Label.Name = "Player2Label"
        Me.Player2Label.Size = New System.Drawing.Size(91, 25)
        Me.Player2Label.TabIndex = 5
        Me.Player2Label.Text = "Player 2"
        '
        'Player1Label
        '
        Me.Player1Label.AutoSize = True
        Me.Player1Label.BackColor = System.Drawing.Color.White
        Me.Player1Label.Location = New System.Drawing.Point(64, 67)
        Me.Player1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Player1Label.Name = "Player1Label"
        Me.Player1Label.Size = New System.Drawing.Size(91, 25)
        Me.Player1Label.TabIndex = 6
        Me.Player1Label.Text = "Player 1"
        '
        'PlayLabel
        '
        Me.PlayLabel.AutoSize = True
        Me.PlayLabel.BackColor = System.Drawing.Color.White
        Me.PlayLabel.Location = New System.Drawing.Point(913, 146)
        Me.PlayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlayLabel.Name = "PlayLabel"
        Me.PlayLabel.Size = New System.Drawing.Size(65, 25)
        Me.PlayLabel.TabIndex = 7
        Me.PlayLabel.Text = "Plays"
        '
        'PlaysLabel
        '
        Me.PlaysLabel.AutoSize = True
        Me.PlaysLabel.BackColor = System.Drawing.Color.White
        Me.PlaysLabel.Location = New System.Drawing.Point(913, 186)
        Me.PlaysLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlaysLabel.Name = "PlaysLabel"
        Me.PlaysLabel.Size = New System.Drawing.Size(53, 25)
        Me.PlaysLabel.TabIndex = 8
        Me.PlaysLabel.Text = "hold"
        '
        'GameLabel
        '
        Me.GameLabel.AutoSize = True
        Me.GameLabel.BackColor = System.Drawing.Color.White
        Me.GameLabel.Location = New System.Drawing.Point(913, 247)
        Me.GameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GameLabel.Name = "GameLabel"
        Me.GameLabel.Size = New System.Drawing.Size(80, 25)
        Me.GameLabel.TabIndex = 9
        Me.GameLabel.Text = "Games"
        '
        'GamesLabel
        '
        Me.GamesLabel.AutoSize = True
        Me.GamesLabel.BackColor = System.Drawing.Color.White
        Me.GamesLabel.Location = New System.Drawing.Point(913, 288)
        Me.GamesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GamesLabel.Name = "GamesLabel"
        Me.GamesLabel.Size = New System.Drawing.Size(53, 25)
        Me.GamesLabel.TabIndex = 10
        Me.GamesLabel.Text = "hold"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Ivory
        Me.ExitButton.Location = New System.Drawing.Point(69, 624)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(148, 42)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "Exit"
        Me.WarToolTip.SetToolTip(Me.ExitButton, "Press to Exit or press ""F""")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WarToolStripProgressBar, Me.AboutToolStripLabel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1150, 38)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'WarToolStripProgressBar
        '
        Me.WarToolStripProgressBar.Maximum = 26
        Me.WarToolStripProgressBar.Name = "WarToolStripProgressBar"
        Me.WarToolStripProgressBar.Size = New System.Drawing.Size(109, 32)
        '
        'AboutToolStripLabel
        '
        Me.AboutToolStripLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.AboutToolStripLabel.Name = "AboutToolStripLabel"
        Me.AboutToolStripLabel.Size = New System.Drawing.Size(79, 32)
        Me.AboutToolStripLabel.Text = "About"
        '
        'WarCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 693)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GamesLabel)
        Me.Controls.Add(Me.GameLabel)
        Me.Controls.Add(Me.PlaysLabel)
        Me.Controls.Add(Me.PlayLabel)
        Me.Controls.Add(Me.Player1Label)
        Me.Controls.Add(Me.Player2Label)
        Me.Controls.Add(Me.OutcomeLabel)
        Me.Controls.Add(Me.Player1PictureBox)
        Me.Controls.Add(Me.Player2PictureBox)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.DealButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "WarCards"
        Me.Text = "WarGame"
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents PlayLabel As Label
    Friend WithEvents PlaysLabel As Label
    Friend WithEvents GameLabel As Label
    Friend WithEvents GamesLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents WarToolTip As ToolTip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents WarToolStripProgressBar As ToolStripProgressBar
    Friend WithEvents AboutToolStripLabel As ToolStripLabel
End Class
