<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataForm
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
        Me.DataSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.ComComboBox = New System.Windows.Forms.ComboBox()
        Me.PortLabel = New System.Windows.Forms.Label()
        Me.DataMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.PortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalogChannelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AN1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AN2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AN3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AN4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortConLabel = New System.Windows.Forms.Label()
        Me.ManualCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.DataPictureBox = New System.Windows.Forms.PictureBox()
        Me.AnalogLabel = New System.Windows.Forms.Label()
        Me.PollTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SampleComboBox = New System.Windows.Forms.ComboBox()
        Me.SampleButton = New System.Windows.Forms.Button()
        Me.WriteTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AllRadioButton = New System.Windows.Forms.RadioButton()
        Me.ThirtyRadioButton = New System.Windows.Forms.RadioButton()
        Me.DisplayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SerialGroupBox = New System.Windows.Forms.GroupBox()
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.DataMenuStrip.SuspendLayout()
        CType(Me.DataPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SerialGroupBox.SuspendLayout()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.DisplayGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSerialPort
        '
        '
        'ComComboBox
        '
        Me.ComComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComComboBox.FormattingEnabled = True
        Me.ComComboBox.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10"})
        Me.ComComboBox.Location = New System.Drawing.Point(10, 54)
        Me.ComComboBox.Name = "ComComboBox"
        Me.ComComboBox.Size = New System.Drawing.Size(113, 33)
        Me.ComComboBox.TabIndex = 0
        '
        'PortLabel
        '
        Me.PortLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PortLabel.AutoSize = True
        Me.PortLabel.Location = New System.Drawing.Point(129, 54)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(118, 25)
        Me.PortLabel.TabIndex = 1
        Me.PortLabel.Text = "Port Status"
        '
        'DataMenuStrip
        '
        Me.DataMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.DataMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.DataMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PortToolStripMenuItem, Me.AnalogChannelToolStripMenuItem})
        Me.DataMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.DataMenuStrip.Name = "DataMenuStrip"
        Me.DataMenuStrip.Size = New System.Drawing.Size(963, 40)
        Me.DataMenuStrip.TabIndex = 2
        Me.DataMenuStrip.Text = "Data Logger"
        '
        'PortToolStripMenuItem
        '
        Me.PortToolStripMenuItem.Name = "PortToolStripMenuItem"
        Me.PortToolStripMenuItem.Size = New System.Drawing.Size(76, 36)
        Me.PortToolStripMenuItem.Text = "Port"
        '
        'AnalogChannelToolStripMenuItem
        '
        Me.AnalogChannelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AN1ToolStripMenuItem, Me.AN2ToolStripMenuItem, Me.AN3ToolStripMenuItem, Me.AN4ToolStripMenuItem})
        Me.AnalogChannelToolStripMenuItem.Name = "AnalogChannelToolStripMenuItem"
        Me.AnalogChannelToolStripMenuItem.Size = New System.Drawing.Size(204, 36)
        Me.AnalogChannelToolStripMenuItem.Text = "Analog Channel"
        '
        'AN1ToolStripMenuItem
        '
        Me.AN1ToolStripMenuItem.Name = "AN1ToolStripMenuItem"
        Me.AN1ToolStripMenuItem.Size = New System.Drawing.Size(193, 44)
        Me.AN1ToolStripMenuItem.Text = "AN1"
        '
        'AN2ToolStripMenuItem
        '
        Me.AN2ToolStripMenuItem.Name = "AN2ToolStripMenuItem"
        Me.AN2ToolStripMenuItem.Size = New System.Drawing.Size(193, 44)
        Me.AN2ToolStripMenuItem.Text = "AN2"
        '
        'AN3ToolStripMenuItem
        '
        Me.AN3ToolStripMenuItem.Name = "AN3ToolStripMenuItem"
        Me.AN3ToolStripMenuItem.Size = New System.Drawing.Size(193, 44)
        Me.AN3ToolStripMenuItem.Text = "AN3"
        '
        'AN4ToolStripMenuItem
        '
        Me.AN4ToolStripMenuItem.Name = "AN4ToolStripMenuItem"
        Me.AN4ToolStripMenuItem.Size = New System.Drawing.Size(193, 44)
        Me.AN4ToolStripMenuItem.Text = "AN4"
        '
        'PortConLabel
        '
        Me.PortConLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PortConLabel.AutoSize = True
        Me.PortConLabel.Location = New System.Drawing.Point(5, 26)
        Me.PortConLabel.Name = "PortConLabel"
        Me.PortConLabel.Size = New System.Drawing.Size(222, 25)
        Me.PortConLabel.TabIndex = 3
        Me.PortConLabel.Text = "Port Name and Status"
        '
        'ManualCheckBox
        '
        Me.ManualCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ManualCheckBox.AutoSize = True
        Me.ManualCheckBox.Location = New System.Drawing.Point(10, 107)
        Me.ManualCheckBox.Name = "ManualCheckBox"
        Me.ManualCheckBox.Size = New System.Drawing.Size(201, 29)
        Me.ManualCheckBox.TabIndex = 4
        Me.ManualCheckBox.Text = "Manual Connect"
        Me.ManualCheckBox.UseVisualStyleBackColor = True
        '
        'ConnectButton
        '
        Me.ConnectButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectButton.AutoSize = True
        Me.ConnectButton.Location = New System.Drawing.Point(217, 104)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(116, 52)
        Me.ConnectButton.TabIndex = 5
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'DataPictureBox
        '
        Me.DataPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataPictureBox.BackColor = System.Drawing.Color.Black
        Me.DataPictureBox.Location = New System.Drawing.Point(12, 97)
        Me.DataPictureBox.Name = "DataPictureBox"
        Me.DataPictureBox.Size = New System.Drawing.Size(927, 279)
        Me.DataPictureBox.TabIndex = 6
        Me.DataPictureBox.TabStop = False
        '
        'AnalogLabel
        '
        Me.AnalogLabel.AutoSize = True
        Me.AnalogLabel.Location = New System.Drawing.Point(7, 69)
        Me.AnalogLabel.Name = "AnalogLabel"
        Me.AnalogLabel.Size = New System.Drawing.Size(183, 25)
        Me.AnalogLabel.TabIndex = 7
        Me.AnalogLabel.Text = "Analog Channel 1"
        '
        'PollTimer
        '
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartButton.Location = New System.Drawing.Point(21, 42)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(117, 57)
        Me.StartButton.TabIndex = 8
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopButton.Location = New System.Drawing.Point(144, 39)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(117, 57)
        Me.StopButton.TabIndex = 9
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(144, 105)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(117, 57)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SampleComboBox
        '
        Me.SampleComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleComboBox.FormattingEnabled = True
        Me.SampleComboBox.Items.AddRange(New Object() {"1", "5", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.SampleComboBox.Location = New System.Drawing.Point(77, 126)
        Me.SampleComboBox.Name = "SampleComboBox"
        Me.SampleComboBox.Size = New System.Drawing.Size(121, 33)
        Me.SampleComboBox.TabIndex = 11
        Me.SampleComboBox.Text = "10"
        '
        'SampleButton
        '
        Me.SampleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleButton.Location = New System.Drawing.Point(21, 105)
        Me.SampleButton.Name = "SampleButton"
        Me.SampleButton.Size = New System.Drawing.Size(117, 57)
        Me.SampleButton.TabIndex = 12
        Me.SampleButton.Text = "Sample"
        Me.SampleButton.UseVisualStyleBackColor = True
        '
        'WriteTimer
        '
        Me.WriteTimer.Interval = 60000
        '
        'AllRadioButton
        '
        Me.AllRadioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllRadioButton.AutoSize = True
        Me.AllRadioButton.Location = New System.Drawing.Point(8, 54)
        Me.AllRadioButton.Name = "AllRadioButton"
        Me.AllRadioButton.Size = New System.Drawing.Size(144, 29)
        Me.AllRadioButton.TabIndex = 13
        Me.AllRadioButton.TabStop = True
        Me.AllRadioButton.Text = "Display All"
        Me.AllRadioButton.UseVisualStyleBackColor = True
        '
        'ThirtyRadioButton
        '
        Me.ThirtyRadioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThirtyRadioButton.AutoSize = True
        Me.ThirtyRadioButton.Location = New System.Drawing.Point(8, 89)
        Me.ThirtyRadioButton.Name = "ThirtyRadioButton"
        Me.ThirtyRadioButton.Size = New System.Drawing.Size(204, 29)
        Me.ThirtyRadioButton.TabIndex = 14
        Me.ThirtyRadioButton.TabStop = True
        Me.ThirtyRadioButton.Text = "Last 30 Seconds"
        Me.ThirtyRadioButton.UseVisualStyleBackColor = True
        '
        'DisplayTimer
        '
        Me.DisplayTimer.Interval = 10
        '
        'SerialGroupBox
        '
        Me.SerialGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SerialGroupBox.Controls.Add(Me.ConnectButton)
        Me.SerialGroupBox.Controls.Add(Me.ManualCheckBox)
        Me.SerialGroupBox.Controls.Add(Me.PortConLabel)
        Me.SerialGroupBox.Controls.Add(Me.PortLabel)
        Me.SerialGroupBox.Controls.Add(Me.ComComboBox)
        Me.SerialGroupBox.Location = New System.Drawing.Point(12, 400)
        Me.SerialGroupBox.Name = "SerialGroupBox"
        Me.SerialGroupBox.Size = New System.Drawing.Size(369, 185)
        Me.SerialGroupBox.TabIndex = 15
        Me.SerialGroupBox.TabStop = False
        Me.SerialGroupBox.Text = "Serial Functions"
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.Controls.Add(Me.SampleButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.StopButton)
        Me.ButtonsGroupBox.Controls.Add(Me.StartButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(629, 410)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(289, 175)
        Me.ButtonsGroupBox.TabIndex = 16
        Me.ButtonsGroupBox.TabStop = False
        Me.ButtonsGroupBox.Text = "Buttons"
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.ThirtyRadioButton)
        Me.DisplayGroupBox.Controls.Add(Me.AllRadioButton)
        Me.DisplayGroupBox.Controls.Add(Me.SampleComboBox)
        Me.DisplayGroupBox.Location = New System.Drawing.Point(387, 410)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(222, 175)
        Me.DisplayGroupBox.TabIndex = 17
        Me.DisplayGroupBox.TabStop = False
        Me.DisplayGroupBox.Text = "Display"
        '
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(963, 597)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.Controls.Add(Me.SerialGroupBox)
        Me.Controls.Add(Me.AnalogLabel)
        Me.Controls.Add(Me.DataPictureBox)
        Me.Controls.Add(Me.DataMenuStrip)
        Me.MainMenuStrip = Me.DataMenuStrip
        Me.Name = "DataForm"
        Me.Text = "Data Logger"
        Me.DataMenuStrip.ResumeLayout(False)
        Me.DataMenuStrip.PerformLayout()
        CType(Me.DataPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SerialGroupBox.ResumeLayout(False)
        Me.SerialGroupBox.PerformLayout()
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSerialPort As IO.Ports.SerialPort
    Friend WithEvents ComComboBox As ComboBox
    Friend WithEvents DataMenuStrip As MenuStrip
    Friend WithEvents PortToolStripMenuItem As ToolStripMenuItem
    Public WithEvents PortLabel As Label
    Friend WithEvents PortConLabel As Label
    Friend WithEvents ManualCheckBox As CheckBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents DataPictureBox As PictureBox
    Friend WithEvents AnalogLabel As Label
    Friend WithEvents PollTimer As Timer
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SampleComboBox As ComboBox
    Friend WithEvents SampleButton As Button
    Friend WithEvents WriteTimer As Timer
    Friend WithEvents AllRadioButton As RadioButton
    Friend WithEvents ThirtyRadioButton As RadioButton
    Friend WithEvents DisplayTimer As Timer
    Friend WithEvents SerialGroupBox As GroupBox
    Friend WithEvents ButtonsGroupBox As GroupBox
    Friend WithEvents DisplayGroupBox As GroupBox
    Friend WithEvents AnalogChannelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AN1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AN2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AN3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AN4ToolStripMenuItem As ToolStripMenuItem
End Class
