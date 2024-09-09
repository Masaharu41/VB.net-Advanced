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
        Me.SuspendLayout()
        '
        'RecordsListBox
        '
        Me.RecordsListBox.FormattingEnabled = True
        Me.RecordsListBox.Location = New System.Drawing.Point(42, 30)
        Me.RecordsListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RecordsListBox.Name = "RecordsListBox"
        Me.RecordsListBox.Size = New System.Drawing.Size(282, 407)
        Me.RecordsListBox.TabIndex = 0
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(370, 70)
        Me.UserTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(137, 20)
        Me.UserTextBox.TabIndex = 1
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Location = New System.Drawing.Point(367, 44)
        Me.UserNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(88, 13)
        Me.UserNameLabel.TabIndex = 2
        Me.UserNameLabel.Text = "Enter Your Name"
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(370, 111)
        Me.PlayButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(82, 40)
        Me.PlayButton.TabIndex = 3
        Me.PlayButton.Text = "Begin Playing"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'RecordsButton
        '
        Me.RecordsButton.Location = New System.Drawing.Point(375, 161)
        Me.RecordsButton.Name = "RecordsButton"
        Me.RecordsButton.Size = New System.Drawing.Size(76, 37)
        Me.RecordsButton.TabIndex = 4
        Me.RecordsButton.Text = "Leaderboard"
        Me.RecordsButton.UseVisualStyleBackColor = True
        '
        'ReplayButton
        '
        Me.ReplayButton.Location = New System.Drawing.Point(375, 204)
        Me.ReplayButton.Name = "ReplayButton"
        Me.ReplayButton.Size = New System.Drawing.Size(76, 37)
        Me.ReplayButton.TabIndex = 5
        Me.ReplayButton.Text = "Replay"
        Me.ReplayButton.UseVisualStyleBackColor = True
        '
        'UserDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 472)
        Me.Controls.Add(Me.ReplayButton)
        Me.Controls.Add(Me.RecordsButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.RecordsListBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
End Class
