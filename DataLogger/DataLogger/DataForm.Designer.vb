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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortConLabel = New System.Windows.Forms.Label()
        Me.ManualCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.DataPictureBox = New System.Windows.Forms.PictureBox()
        Me.AnalogLabel = New System.Windows.Forms.Label()
        Me.PollTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSerialPort
        '
        '
        'ComComboBox
        '
        Me.ComComboBox.FormattingEnabled = True
        Me.ComComboBox.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10"})
        Me.ComComboBox.Location = New System.Drawing.Point(17, 377)
        Me.ComComboBox.Name = "ComComboBox"
        Me.ComComboBox.Size = New System.Drawing.Size(113, 33)
        Me.ComComboBox.TabIndex = 0
        '
        'PortLabel
        '
        Me.PortLabel.AutoSize = True
        Me.PortLabel.Location = New System.Drawing.Point(136, 377)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(118, 25)
        Me.PortLabel.TabIndex = 1
        Me.PortLabel.Text = "Port Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PortToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(867, 40)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PortToolStripMenuItem
        '
        Me.PortToolStripMenuItem.Name = "PortToolStripMenuItem"
        Me.PortToolStripMenuItem.Size = New System.Drawing.Size(76, 36)
        Me.PortToolStripMenuItem.Text = "Port"
        '
        'PortConLabel
        '
        Me.PortConLabel.AutoSize = True
        Me.PortConLabel.Location = New System.Drawing.Point(12, 349)
        Me.PortConLabel.Name = "PortConLabel"
        Me.PortConLabel.Size = New System.Drawing.Size(222, 25)
        Me.PortConLabel.TabIndex = 3
        Me.PortConLabel.Text = "Port Name and Status"
        '
        'ManualCheckBox
        '
        Me.ManualCheckBox.AutoSize = True
        Me.ManualCheckBox.Location = New System.Drawing.Point(17, 430)
        Me.ManualCheckBox.Name = "ManualCheckBox"
        Me.ManualCheckBox.Size = New System.Drawing.Size(201, 29)
        Me.ManualCheckBox.TabIndex = 4
        Me.ManualCheckBox.Text = "Manual Connect"
        Me.ManualCheckBox.UseVisualStyleBackColor = True
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(244, 407)
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
        Me.DataPictureBox.Location = New System.Drawing.Point(12, 97)
        Me.DataPictureBox.Name = "DataPictureBox"
        Me.DataPictureBox.Size = New System.Drawing.Size(831, 249)
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
        Me.PollTimer.Interval = 60
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(574, 364)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(117, 57)
        Me.StartButton.TabIndex = 8
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(697, 361)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(117, 57)
        Me.StopButton.TabIndex = 9
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(574, 430)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(117, 57)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 525)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.AnalogLabel)
        Me.Controls.Add(Me.DataPictureBox)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.ManualCheckBox)
        Me.Controls.Add(Me.PortConLabel)
        Me.Controls.Add(Me.PortLabel)
        Me.Controls.Add(Me.ComComboBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DataForm"
        Me.Text = "Data Logger"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSerialPort As IO.Ports.SerialPort
    Friend WithEvents ComComboBox As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
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
End Class
