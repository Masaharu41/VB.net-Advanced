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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VoltComboBox = New System.Windows.Forms.ComboBox()
        Me.FreqComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        CType(Me.RLCPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VoltTextBox
        '
        Me.VoltTextBox.Location = New System.Drawing.Point(19, 348)
        Me.VoltTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.VoltTextBox.Name = "VoltTextBox"
        Me.VoltTextBox.Size = New System.Drawing.Size(119, 26)
        Me.VoltTextBox.TabIndex = 0
        '
        'FreqTextBox
        '
        Me.FreqTextBox.Location = New System.Drawing.Point(19, 414)
        Me.FreqTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FreqTextBox.Name = "FreqTextBox"
        Me.FreqTextBox.Size = New System.Drawing.Size(119, 26)
        Me.FreqTextBox.TabIndex = 1
        '
        'C1TextBox
        '
        Me.C1TextBox.Location = New System.Drawing.Point(219, 350)
        Me.C1TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.C1TextBox.Name = "C1TextBox"
        Me.C1TextBox.Size = New System.Drawing.Size(119, 26)
        Me.C1TextBox.TabIndex = 2
        '
        'R1TextBox
        '
        Me.R1TextBox.Location = New System.Drawing.Point(219, 416)
        Me.R1TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R1TextBox.Name = "R1TextBox"
        Me.R1TextBox.Size = New System.Drawing.Size(119, 26)
        Me.R1TextBox.TabIndex = 3
        '
        'L1TextBox
        '
        Me.L1TextBox.Location = New System.Drawing.Point(19, 469)
        Me.L1TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.L1TextBox.Name = "L1TextBox"
        Me.L1TextBox.Size = New System.Drawing.Size(119, 26)
        Me.L1TextBox.TabIndex = 4
        '
        'C2TextBox
        '
        Me.C2TextBox.Location = New System.Drawing.Point(219, 469)
        Me.C2TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.C2TextBox.Name = "C2TextBox"
        Me.C2TextBox.Size = New System.Drawing.Size(119, 26)
        Me.C2TextBox.TabIndex = 6
        '
        'R2TextBox
        '
        Me.R2TextBox.Location = New System.Drawing.Point(219, 535)
        Me.R2TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R2TextBox.Name = "R2TextBox"
        Me.R2TextBox.Size = New System.Drawing.Size(119, 26)
        Me.R2TextBox.TabIndex = 7
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(20, 590)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(139, 67)
        Me.CalculateButton.TabIndex = 8
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'VoltLabel
        '
        Me.VoltLabel.AutoSize = True
        Me.VoltLabel.Location = New System.Drawing.Point(15, 326)
        Me.VoltLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VoltLabel.Name = "VoltLabel"
        Me.VoltLabel.Size = New System.Drawing.Size(68, 20)
        Me.VoltLabel.TabIndex = 8
        Me.VoltLabel.Text = "Voltage "
        '
        'FreqLabel
        '
        Me.FreqLabel.AutoSize = True
        Me.FreqLabel.Location = New System.Drawing.Point(15, 391)
        Me.FreqLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FreqLabel.Name = "FreqLabel"
        Me.FreqLabel.Size = New System.Drawing.Size(84, 20)
        Me.FreqLabel.TabIndex = 9
        Me.FreqLabel.Text = "Frequency"
        '
        'C1Label
        '
        Me.C1Label.AutoSize = True
        Me.C1Label.Location = New System.Drawing.Point(226, 328)
        Me.C1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.C1Label.Name = "C1Label"
        Me.C1Label.Size = New System.Drawing.Size(29, 20)
        Me.C1Label.TabIndex = 10
        Me.C1Label.Text = "C1"
        '
        'R1Label
        '
        Me.R1Label.AutoSize = True
        Me.R1Label.Location = New System.Drawing.Point(215, 390)
        Me.R1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.R1Label.Name = "R1Label"
        Me.R1Label.Size = New System.Drawing.Size(30, 20)
        Me.R1Label.TabIndex = 11
        Me.R1Label.Text = "R1"
        '
        'L1Label
        '
        Me.L1Label.AutoSize = True
        Me.L1Label.Location = New System.Drawing.Point(16, 447)
        Me.L1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L1Label.Name = "L1Label"
        Me.L1Label.Size = New System.Drawing.Size(27, 20)
        Me.L1Label.TabIndex = 12
        Me.L1Label.Text = "L1"
        '
        'C2Label
        '
        Me.C2Label.AutoSize = True
        Me.C2Label.Location = New System.Drawing.Point(215, 447)
        Me.C2Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.C2Label.Name = "C2Label"
        Me.C2Label.Size = New System.Drawing.Size(29, 20)
        Me.C2Label.TabIndex = 13
        Me.C2Label.Text = "C2"
        '
        'R2Label
        '
        Me.R2Label.AutoSize = True
        Me.R2Label.Location = New System.Drawing.Point(215, 515)
        Me.R2Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.R2Label.Name = "R2Label"
        Me.R2Label.Size = New System.Drawing.Size(30, 20)
        Me.R2Label.TabIndex = 14
        Me.R2Label.Text = "R2"
        '
        'SeriesRTextBox
        '
        Me.SeriesRTextBox.Location = New System.Drawing.Point(19, 535)
        Me.SeriesRTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SeriesRTextBox.Name = "SeriesRTextBox"
        Me.SeriesRTextBox.Size = New System.Drawing.Size(119, 26)
        Me.SeriesRTextBox.TabIndex = 5
        '
        'RLCListBox
        '
        Me.RLCListBox.FormattingEnabled = True
        Me.RLCListBox.ItemHeight = 20
        Me.RLCListBox.Location = New System.Drawing.Point(548, 14)
        Me.RLCListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RLCListBox.Name = "RLCListBox"
        Me.RLCListBox.Size = New System.Drawing.Size(430, 504)
        Me.RLCListBox.TabIndex = 16
        '
        'RLCPictureBox
        '
        Me.RLCPictureBox.BackgroundImage = Global.RLC_Calculator.My.Resources.Resources.RLC_Circuit
        Me.RLCPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RLCPictureBox.Location = New System.Drawing.Point(9, 9)
        Me.RLCPictureBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RLCPictureBox.Name = "RLCPictureBox"
        Me.RLCPictureBox.Size = New System.Drawing.Size(534, 310)
        Me.RLCPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.RLCPictureBox.TabIndex = 17
        Me.RLCPictureBox.TabStop = False
        '
        'SeriesRLabel
        '
        Me.SeriesRLabel.AutoSize = True
        Me.SeriesRLabel.Location = New System.Drawing.Point(16, 512)
        Me.SeriesRLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SeriesRLabel.Name = "SeriesRLabel"
        Me.SeriesRLabel.Size = New System.Drawing.Size(120, 20)
        Me.SeriesRLabel.TabIndex = 18
        Me.SeriesRLabel.Text = "Rwinding/series"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 590)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 67)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VoltComboBox
        '
        Me.VoltComboBox.FormattingEnabled = True
        Me.VoltComboBox.Items.AddRange(New Object() {"MV", "kV", "V", "mV", "uV", "nV", "pV"})
        Me.VoltComboBox.Location = New System.Drawing.Point(143, 348)
        Me.VoltComboBox.Name = "VoltComboBox"
        Me.VoltComboBox.Size = New System.Drawing.Size(71, 28)
        Me.VoltComboBox.TabIndex = 20
        Me.VoltComboBox.Text = "Unit"
        '
        'FreqComboBox
        '
        Me.FreqComboBox.FormattingEnabled = True
        Me.FreqComboBox.Items.AddRange(New Object() {"MHz", "KHz", "Hz", "mHz", "uHz", "nHz", "pHz"})
        Me.FreqComboBox.Location = New System.Drawing.Point(143, 414)
        Me.FreqComboBox.Name = "FreqComboBox"
        Me.FreqComboBox.Size = New System.Drawing.Size(71, 28)
        Me.FreqComboBox.TabIndex = 21
        Me.FreqComboBox.Text = "Unit"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MF", "kF", "F", "mF", "uF", "nF", "pF"})
        Me.ComboBox1.Location = New System.Drawing.Point(343, 348)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(71, 28)
        Me.ComboBox1.TabIndex = 22
        Me.ComboBox1.Text = "Unit"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"MOhms", "kOhms", "Ohms", "mOhms", "uOhms", "nOhms", "pOhms"})
        Me.ComboBox2.Location = New System.Drawing.Point(343, 416)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(71, 28)
        Me.ComboBox2.TabIndex = 23
        Me.ComboBox2.Text = "Unit"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"MF", "kF", "F", "mF", "uF", "nF", "pF"})
        Me.ComboBox3.Location = New System.Drawing.Point(343, 467)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(71, 28)
        Me.ComboBox3.TabIndex = 24
        Me.ComboBox3.Text = "Unit"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"MOhms", "kOhms", "Ohms", "mOhms", "uOhms", "nOhms", "pOhms"})
        Me.ComboBox4.Location = New System.Drawing.Point(343, 533)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(71, 28)
        Me.ComboBox4.TabIndex = 25
        Me.ComboBox4.Text = "Unit"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"MH", "kH", "H", "mH", "uH", "nH", "pH"})
        Me.ComboBox5.Location = New System.Drawing.Point(143, 470)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(71, 28)
        Me.ComboBox5.TabIndex = 26
        Me.ComboBox5.Text = "Unit"
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"MOhms", "kOhms", "Ohms", "mOhms", "uOhms", "nOhms", "pOhms"})
        Me.ComboBox6.Location = New System.Drawing.Point(143, 535)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(71, 28)
        Me.ComboBox6.TabIndex = 27
        Me.ComboBox6.Text = "Unit"
        '
        'RLCCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1444, 878)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.FreqComboBox)
        Me.Controls.Add(Me.VoltComboBox)
        Me.Controls.Add(Me.Button1)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RLCCalculator"
        Me.Text = "RLC Calculator"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents VoltComboBox As ComboBox
    Friend WithEvents FreqComboBox As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
End Class
