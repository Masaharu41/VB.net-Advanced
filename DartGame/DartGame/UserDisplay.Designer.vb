<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDisplay
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
        Me.RecordsListBox = New System.Windows.Forms.ListBox()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.RecordsButton = New System.Windows.Forms.Button()
        Me.ReplayButton = New System.Windows.Forms.Button()
        Me.ExitButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RecordsListBox
        '
        Me.RecordsListBox.FormattingEnabled = True
        Me.RecordsListBox.ItemHeight = 24
        Me.RecordsListBox.Location = New System.Drawing.Point(77, 56)
        Me.RecordsListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RecordsListBox.Name = "RecordsListBox"
        Me.RecordsListBox.Size = New System.Drawing.Size(514, 748)
        Me.RecordsListBox.TabIndex = 0
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(678, 130)
        Me.UserTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(248, 29)
        Me.UserTextBox.TabIndex = 1
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Location = New System.Drawing.Point(673, 82)
        Me.UserNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(161, 25)
        Me.UserNameLabel.TabIndex = 2
        Me.UserNameLabel.Text = "Enter Your Name"
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.Lime
        Me.PlayButton.Location = New System.Drawing.Point(688, 204)
        Me.PlayButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(141, 74)
        Me.PlayButton.TabIndex = 3
        Me.PlayButton.Text = "Begin Playing"
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'RecordsButton
        '
        Me.RecordsButton.Location = New System.Drawing.Point(688, 298)
        Me.RecordsButton.Margin = New System.Windows.Forms.Padding(6)
        Me.RecordsButton.Name = "RecordsButton"
        Me.RecordsButton.Size = New System.Drawing.Size(139, 68)
        Me.RecordsButton.TabIndex = 4
        Me.RecordsButton.Text = "Leaderboard"
        Me.RecordsButton.UseVisualStyleBackColor = True
        '
        'ReplayButton
        '
        Me.ReplayButton.Location = New System.Drawing.Point(688, 376)
        Me.ReplayButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ReplayButton.Name = "ReplayButton"
        Me.ReplayButton.Size = New System.Drawing.Size(139, 68)
        Me.ReplayButton.TabIndex = 5
        Me.ReplayButton.Text = "Replay"
        Me.ReplayButton.UseVisualStyleBackColor = True
        '
        'ExitButton1
        '
        Me.ExitButton1.BackColor = System.Drawing.Color.IndianRed
        Me.ExitButton1.Location = New System.Drawing.Point(688, 456)
        Me.ExitButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.ExitButton1.Name = "ExitButton1"
        Me.ExitButton1.Size = New System.Drawing.Size(139, 68)
        Me.ExitButton1.TabIndex = 6
        Me.ExitButton1.Text = "Exit"
        Me.ExitButton1.UseVisualStyleBackColor = False
        '
        'UserDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 872)
        Me.Controls.Add(Me.ExitButton1)
        Me.Controls.Add(Me.ReplayButton)
        Me.Controls.Add(Me.RecordsButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.RecordsListBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserDisplay"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecordsListBox As ListBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents PlayButton As Button
    Friend WithEvents RecordsButton As Button
    Friend WithEvents ReplayButton As Button
    Friend WithEvents ExitButton1 As Button
End Class
