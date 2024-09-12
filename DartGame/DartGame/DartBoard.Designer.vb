<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DartBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DartButton = New System.Windows.Forms.Button()
        Me.DartBoardPictureBox = New System.Windows.Forms.PictureBox()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DartBoardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DartButton
        '
        Me.DartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DartButton.BackColor = System.Drawing.Color.SpringGreen
        Me.DartButton.Location = New System.Drawing.Point(34, 522)
        Me.DartButton.Name = "DartButton"
        Me.DartButton.Size = New System.Drawing.Size(163, 41)
        Me.DartButton.TabIndex = 1
        Me.DartButton.Text = "Throw Dart"
        Me.ToolTip1.SetToolTip(Me.DartButton, "Throw a Dart")
        Me.DartButton.UseVisualStyleBackColor = False
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
        Me.ToolTip1.SetToolTip(Me.DartBoardPictureBox, "Dart Board")
        '
        'HistoryButton
        '
        Me.HistoryButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HistoryButton.Location = New System.Drawing.Point(218, 522)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(109, 41)
        Me.HistoryButton.TabIndex = 2
        Me.HistoryButton.Text = "History"
        Me.ToolTip1.SetToolTip(Me.HistoryButton, "See the Leaderboard")
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.Color.Firebrick
        Me.ExitButton.Location = New System.Drawing.Point(347, 522)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(98, 41)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Leave Game")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DartBoard
        '
        Me.ClientSize = New System.Drawing.Size(1154, 581)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.HistoryButton)
        Me.Controls.Add(Me.DartBoardPictureBox)
        Me.Controls.Add(Me.DartButton)
        Me.Name = "DartBoard"
        CType(Me.DartBoardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DartBoard As PictureBox
    Friend WithEvents DartButton As Button
    Friend WithEvents DartBoardPictureBox As PictureBox
    Friend WithEvents HistoryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
