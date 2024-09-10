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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(84, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(559, 779)
        Me.ListBox1.TabIndex = 0
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(739, 135)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(270, 31)
        Me.UserTextBox.TabIndex = 1
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Location = New System.Drawing.Point(734, 85)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(177, 25)
        Me.UserNameLabel.TabIndex = 2
        Me.UserNameLabel.Text = "Enter Your Name"
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(739, 214)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(165, 77)
        Me.PlayButton.TabIndex = 3
        Me.PlayButton.Text = "Begin Playing"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'UserDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 907)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "UserDisplay"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents PlayButton As Button
End Class
