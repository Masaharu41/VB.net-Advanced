<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RLCCalculator
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
        Me.VoltTextBox = New System.Windows.Forms.TextBox()
        Me.FreqTextBox = New System.Windows.Forms.TextBox()
        Me.C1TextBox = New System.Windows.Forms.TextBox()
        Me.R1TextBox = New System.Windows.Forms.TextBox()
        Me.L1TextBox = New System.Windows.Forms.TextBox()
        Me.C2TextBox = New System.Windows.Forms.TextBox()
        Me.R2TextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.VoltLabel = New System.Windows.Forms.Label()
        Me.FreqLabel = New System.Windows.Forms.Label()
        Me.C1Label = New System.Windows.Forms.Label()
        Me.R1Label = New System.Windows.Forms.Label()
        Me.L1Label = New System.Windows.Forms.Label()
        Me.C2Label = New System.Windows.Forms.Label()
        Me.R2Label = New System.Windows.Forms.Label()
        Me.SeriesRTextBox = New System.Windows.Forms.TextBox()
        Me.RLCListBox = New System.Windows.Forms.ListBox()
        Me.RLCPictureBox = New System.Windows.Forms.PictureBox()
        Me.SeriesRLabel = New System.Windows.Forms.Label()
        CType(Me.RLCPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VoltTextBox
        '
        Me.VoltTextBox.Location = New System.Drawing.Point(25, 435)
        Me.VoltTextBox.Name = "VoltTextBox"
        Me.VoltTextBox.Size = New System.Drawing.Size(157, 31)
        Me.VoltTextBox.TabIndex = 0
        '
        'FreqTextBox
        '
        Me.FreqTextBox.Location = New System.Drawing.Point(25, 517)
        Me.FreqTextBox.Name = "FreqTextBox"
        Me.FreqTextBox.Size = New System.Drawing.Size(157, 31)
        Me.FreqTextBox.TabIndex = 1
        '
        'C1TextBox
        '
        Me.C1TextBox.Location = New System.Drawing.Point(188, 435)
        Me.C1TextBox.Name = "C1TextBox"
        Me.C1TextBox.Size = New System.Drawing.Size(157, 31)
        Me.C1TextBox.TabIndex = 2
        '
        'R1TextBox
        '
        Me.R1TextBox.Location = New System.Drawing.Point(188, 517)
        Me.R1TextBox.Name = "R1TextBox"
        Me.R1TextBox.Size = New System.Drawing.Size(157, 31)
        Me.R1TextBox.TabIndex = 3
        '
        'L1TextBox
        '
        Me.L1TextBox.Location = New System.Drawing.Point(351, 435)
        Me.L1TextBox.Name = "L1TextBox"
        Me.L1TextBox.Size = New System.Drawing.Size(157, 31)
        Me.L1TextBox.TabIndex = 4
        '
        'C2TextBox
        '
        Me.C2TextBox.Location = New System.Drawing.Point(516, 435)
        Me.C2TextBox.Name = "C2TextBox"
        Me.C2TextBox.Size = New System.Drawing.Size(157, 31)
        Me.C2TextBox.TabIndex = 5
        '
        'R2TextBox
        '
        Me.R2TextBox.Location = New System.Drawing.Point(516, 517)
        Me.R2TextBox.Name = "R2TextBox"
        Me.R2TextBox.Size = New System.Drawing.Size(157, 31)
        Me.R2TextBox.TabIndex = 6
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(25, 563)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(185, 84)
        Me.CalculateButton.TabIndex = 7
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'VoltLabel
        '
        Me.VoltLabel.AutoSize = True
        Me.VoltLabel.Location = New System.Drawing.Point(20, 407)
        Me.VoltLabel.Name = "VoltLabel"
        Me.VoltLabel.Size = New System.Drawing.Size(91, 25)
        Me.VoltLabel.TabIndex = 8
        Me.VoltLabel.Text = "Voltage "
        '
        'FreqLabel
        '
        Me.FreqLabel.AutoSize = True
        Me.FreqLabel.Location = New System.Drawing.Point(20, 489)
        Me.FreqLabel.Name = "FreqLabel"
        Me.FreqLabel.Size = New System.Drawing.Size(114, 25)
        Me.FreqLabel.TabIndex = 9
        Me.FreqLabel.Text = "Frequency"
        '
        'C1Label
        '
        Me.C1Label.AutoSize = True
        Me.C1Label.Location = New System.Drawing.Point(183, 407)
        Me.C1Label.Name = "C1Label"
        Me.C1Label.Size = New System.Drawing.Size(39, 25)
        Me.C1Label.TabIndex = 10
        Me.C1Label.Text = "C1"
        '
        'R1Label
        '
        Me.R1Label.AutoSize = True
        Me.R1Label.Location = New System.Drawing.Point(183, 485)
        Me.R1Label.Name = "R1Label"
        Me.R1Label.Size = New System.Drawing.Size(39, 25)
        Me.R1Label.TabIndex = 11
        Me.R1Label.Text = "R1"
        '
        'L1Label
        '
        Me.L1Label.AutoSize = True
        Me.L1Label.Location = New System.Drawing.Point(346, 407)
        Me.L1Label.Name = "L1Label"
        Me.L1Label.Size = New System.Drawing.Size(36, 25)
        Me.L1Label.TabIndex = 12
        Me.L1Label.Text = "L1"
        '
        'C2Label
        '
        Me.C2Label.AutoSize = True
        Me.C2Label.Location = New System.Drawing.Point(511, 407)
        Me.C2Label.Name = "C2Label"
        Me.C2Label.Size = New System.Drawing.Size(39, 25)
        Me.C2Label.TabIndex = 13
        Me.C2Label.Text = "C2"
        '
        'R2Label
        '
        Me.R2Label.AutoSize = True
        Me.R2Label.Location = New System.Drawing.Point(511, 492)
        Me.R2Label.Name = "R2Label"
        Me.R2Label.Size = New System.Drawing.Size(39, 25)
        Me.R2Label.TabIndex = 14
        Me.R2Label.Text = "R2"
        '
        'SeriesRTextBox
        '
        Me.SeriesRTextBox.Location = New System.Drawing.Point(351, 517)
        Me.SeriesRTextBox.Name = "SeriesRTextBox"
        Me.SeriesRTextBox.Size = New System.Drawing.Size(157, 31)
        Me.SeriesRTextBox.TabIndex = 15
        '
        'RLCListBox
        '
        Me.RLCListBox.FormattingEnabled = True
        Me.RLCListBox.ItemHeight = 25
        Me.RLCListBox.Location = New System.Drawing.Point(730, 18)
        Me.RLCListBox.Name = "RLCListBox"
        Me.RLCListBox.Size = New System.Drawing.Size(382, 629)
        Me.RLCListBox.TabIndex = 16
        '
        'RLCPictureBox
        '
        Me.RLCPictureBox.Image = Global.RLC_Calculator.My.Resources.Resources.RLC_Circuit
        Me.RLCPictureBox.Location = New System.Drawing.Point(12, 11)
        Me.RLCPictureBox.Name = "RLCPictureBox"
        Me.RLCPictureBox.Size = New System.Drawing.Size(712, 388)
        Me.RLCPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.RLCPictureBox.TabIndex = 17
        Me.RLCPictureBox.TabStop = False
        '
        'SeriesRLabel
        '
        Me.SeriesRLabel.AutoSize = True
        Me.SeriesRLabel.Location = New System.Drawing.Point(346, 489)
        Me.SeriesRLabel.Name = "SeriesRLabel"
        Me.SeriesRLabel.Size = New System.Drawing.Size(164, 25)
        Me.SeriesRLabel.TabIndex = 18
        Me.SeriesRLabel.Text = "Rwinding/series"
        '
        'RLCCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1925, 1097)
        Me.Controls.Add(Me.SeriesRLabel)
        Me.Controls.Add(Me.RLCPictureBox)
        Me.Controls.Add(Me.RLCListBox)
        Me.Controls.Add(Me.SeriesRTextBox)
        Me.Controls.Add(Me.R2Label)
        Me.Controls.Add(Me.C2Label)
        Me.Controls.Add(Me.L1Label)
        Me.Controls.Add(Me.R1Label)
        Me.Controls.Add(Me.C1Label)
        Me.Controls.Add(Me.FreqLabel)
        Me.Controls.Add(Me.VoltLabel)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.R2TextBox)
        Me.Controls.Add(Me.C2TextBox)
        Me.Controls.Add(Me.L1TextBox)
        Me.Controls.Add(Me.R1TextBox)
        Me.Controls.Add(Me.C1TextBox)
        Me.Controls.Add(Me.FreqTextBox)
        Me.Controls.Add(Me.VoltTextBox)
        Me.Name = "RLCCalculator"
        Me.Text = "Form1"
        CType(Me.RLCPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VoltTextBox As TextBox
    Friend WithEvents FreqTextBox As TextBox
    Friend WithEvents C1TextBox As TextBox
    Friend WithEvents R1TextBox As TextBox
    Friend WithEvents L1TextBox As TextBox
    Friend WithEvents C2TextBox As TextBox
    Friend WithEvents R2TextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents VoltLabel As Label
    Friend WithEvents FreqLabel As Label
    Friend WithEvents C1Label As Label
    Friend WithEvents R1Label As Label
    Friend WithEvents L1Label As Label
    Friend WithEvents C2Label As Label
    Friend WithEvents R2Label As Label
    Friend WithEvents SeriesRTextBox As TextBox
    Friend WithEvents RLCListBox As ListBox
    Friend WithEvents RLCPictureBox As PictureBox
    Friend WithEvents SeriesRLabel As Label
End Class
