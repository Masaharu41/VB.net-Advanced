<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HVACGuiForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HVACGuiForm))
        Me.HomeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ComToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.PortStatusToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ConnectToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TimeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.SmartSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TwoTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FiveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SystemTempTextBox = New System.Windows.Forms.TextBox()
        Me.HouseTempTextBox = New System.Windows.Forms.TextBox()
        Me.DecButton = New System.Windows.Forms.Button()
        Me.IncButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UnitTempTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CoolingPictureBox = New System.Windows.Forms.PictureBox()
        Me.HeaterPictureBox = New System.Windows.Forms.PictureBox()
        Me.FanPictureBox = New System.Windows.Forms.PictureBox()
        Me.SetTempLabel = New System.Windows.Forms.Label()
        Me.IsuPictureBox = New System.Windows.Forms.PictureBox()
        Me.TimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HouseToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.HomeToolStrip.SuspendLayout()
        CType(Me.CoolingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaterPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FanPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsuPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeToolStrip
        '
        Me.HomeToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.HomeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComToolStripComboBox, Me.PortStatusToolStripLabel, Me.ConnectToolStripButton, Me.TimeToolStripLabel})
        Me.HomeToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.HomeToolStrip.Name = "HomeToolStrip"
        Me.HomeToolStrip.Size = New System.Drawing.Size(800, 42)
        Me.HomeToolStrip.TabIndex = 0
        Me.HomeToolStrip.Text = "ToolStrip1"
        '
        'ComToolStripComboBox
        '
        Me.ComToolStripComboBox.Items.AddRange(New Object() {"COM0", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10"})
        Me.ComToolStripComboBox.Name = "ComToolStripComboBox"
        Me.ComToolStripComboBox.Size = New System.Drawing.Size(121, 42)
        Me.ComToolStripComboBox.Text = "Com1"
        Me.ComToolStripComboBox.ToolTipText = "Com Identification"
        '
        'PortStatusToolStripLabel
        '
        Me.PortStatusToolStripLabel.Name = "PortStatusToolStripLabel"
        Me.PortStatusToolStripLabel.Size = New System.Drawing.Size(127, 36)
        Me.PortStatusToolStripLabel.Text = "Port Status"
        '
        'ConnectToolStripButton
        '
        Me.ConnectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConnectToolStripButton.Image = CType(resources.GetObject("ConnectToolStripButton.Image"), System.Drawing.Image)
        Me.ConnectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConnectToolStripButton.Name = "ConnectToolStripButton"
        Me.ConnectToolStripButton.Size = New System.Drawing.Size(46, 36)
        Me.ConnectToolStripButton.Text = "Connect"
        Me.ConnectToolStripButton.ToolTipText = "Manual Connect to External Device"
        '
        'TimeToolStripLabel
        '
        Me.TimeToolStripLabel.Name = "TimeToolStripLabel"
        Me.TimeToolStripLabel.Size = New System.Drawing.Size(132, 36)
        Me.TimeToolStripLabel.Text = "ActiveTime"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Black
        Me.ErrorLabel.Location = New System.Drawing.Point(271, 382)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(77, 25)
        Me.ErrorLabel.TabIndex = 1
        Me.ErrorLabel.Text = "Label1"
        '
        'TwoTimer
        '
        Me.TwoTimer.Interval = 10000
        '
        'FiveTimer
        '
        Me.FiveTimer.Interval = 5000
        '
        'SystemTempTextBox
        '
        Me.SystemTempTextBox.Location = New System.Drawing.Point(455, 143)
        Me.SystemTempTextBox.Name = "SystemTempTextBox"
        Me.SystemTempTextBox.ReadOnly = True
        Me.SystemTempTextBox.Size = New System.Drawing.Size(100, 31)
        Me.SystemTempTextBox.TabIndex = 3
        Me.SystemTempTextBox.TabStop = False
        Me.HouseToolTip.SetToolTip(Me.SystemTempTextBox, "Current House Temperature")
        '
        'HouseTempTextBox
        '
        Me.HouseTempTextBox.Location = New System.Drawing.Point(211, 143)
        Me.HouseTempTextBox.Name = "HouseTempTextBox"
        Me.HouseTempTextBox.ReadOnly = True
        Me.HouseTempTextBox.Size = New System.Drawing.Size(100, 31)
        Me.HouseTempTextBox.TabIndex = 4
        Me.HouseTempTextBox.TabStop = False
        Me.HouseToolTip.SetToolTip(Me.HouseTempTextBox, "Desired House Temperature")
        '
        'DecButton
        '
        Me.DecButton.Location = New System.Drawing.Point(129, 143)
        Me.DecButton.Name = "DecButton"
        Me.DecButton.Size = New System.Drawing.Size(76, 43)
        Me.DecButton.TabIndex = 1
        Me.DecButton.Text = "<"
        Me.HouseToolTip.SetToolTip(Me.DecButton, "Decrease House Temperature")
        Me.DecButton.UseVisualStyleBackColor = True
        '
        'IncButton
        '
        Me.IncButton.Location = New System.Drawing.Point(317, 143)
        Me.IncButton.Name = "IncButton"
        Me.IncButton.Size = New System.Drawing.Size(91, 43)
        Me.IncButton.TabIndex = 2
        Me.IncButton.Text = ">"
        Me.HouseToolTip.SetToolTip(Me.IncButton, "Increase House Temperature")
        Me.IncButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(607, 371)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(84, 46)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UnitTempTextBox
        '
        Me.UnitTempTextBox.Location = New System.Drawing.Point(455, 211)
        Me.UnitTempTextBox.Name = "UnitTempTextBox"
        Me.UnitTempTextBox.ReadOnly = True
        Me.UnitTempTextBox.Size = New System.Drawing.Size(100, 31)
        Me.UnitTempTextBox.TabIndex = 8
        Me.UnitTempTextBox.TabStop = False
        Me.HouseToolTip.SetToolTip(Me.UnitTempTextBox, "HVAC Unit Temperature")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(450, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "House Temperature"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Unit Temperature"
        '
        'CoolingPictureBox
        '
        Me.CoolingPictureBox.BackgroundImage = CType(resources.GetObject("CoolingPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.CoolingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CoolingPictureBox.Location = New System.Drawing.Point(129, 211)
        Me.CoolingPictureBox.Name = "CoolingPictureBox"
        Me.CoolingPictureBox.Size = New System.Drawing.Size(279, 127)
        Me.CoolingPictureBox.TabIndex = 11
        Me.CoolingPictureBox.TabStop = False
        '
        'HeaterPictureBox
        '
        Me.HeaterPictureBox.BackgroundImage = CType(resources.GetObject("HeaterPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.HeaterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaterPictureBox.Location = New System.Drawing.Point(129, 211)
        Me.HeaterPictureBox.Name = "HeaterPictureBox"
        Me.HeaterPictureBox.Size = New System.Drawing.Size(279, 127)
        Me.HeaterPictureBox.TabIndex = 12
        Me.HeaterPictureBox.TabStop = False
        '
        'FanPictureBox
        '
        Me.FanPictureBox.BackgroundImage = CType(resources.GetObject("FanPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.FanPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FanPictureBox.Location = New System.Drawing.Point(455, 248)
        Me.FanPictureBox.Name = "FanPictureBox"
        Me.FanPictureBox.Size = New System.Drawing.Size(100, 90)
        Me.FanPictureBox.TabIndex = 13
        Me.FanPictureBox.TabStop = False
        '
        'SetTempLabel
        '
        Me.SetTempLabel.AutoSize = True
        Me.SetTempLabel.Location = New System.Drawing.Point(176, 115)
        Me.SetTempLabel.Name = "SetTempLabel"
        Me.SetTempLabel.Size = New System.Drawing.Size(172, 25)
        Me.SetTempLabel.TabIndex = 14
        Me.SetTempLabel.Text = "Set Temperature"
        '
        'IsuPictureBox
        '
        Me.IsuPictureBox.BackgroundImage = CType(resources.GetObject("IsuPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.IsuPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IsuPictureBox.Location = New System.Drawing.Point(23, 362)
        Me.IsuPictureBox.Name = "IsuPictureBox"
        Me.IsuPictureBox.Size = New System.Drawing.Size(242, 67)
        Me.IsuPictureBox.TabIndex = 15
        Me.IsuPictureBox.TabStop = False
        '
        'TimeTimer
        '
        Me.TimeTimer.Enabled = True
        Me.TimeTimer.Interval = 1000
        '
        'HVACGuiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IsuPictureBox)
        Me.Controls.Add(Me.SetTempLabel)
        Me.Controls.Add(Me.FanPictureBox)
        Me.Controls.Add(Me.HeaterPictureBox)
        Me.Controls.Add(Me.CoolingPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UnitTempTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.IncButton)
        Me.Controls.Add(Me.DecButton)
        Me.Controls.Add(Me.HouseTempTextBox)
        Me.Controls.Add(Me.SystemTempTextBox)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.HomeToolStrip)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "HVACGuiForm"
        Me.Text = "Smart Home"
        Me.HomeToolStrip.ResumeLayout(False)
        Me.HomeToolStrip.PerformLayout()
        CType(Me.CoolingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaterPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FanPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsuPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeToolStrip As ToolStrip
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents ComToolStripComboBox As ToolStripComboBox
    Friend WithEvents SmartSerialPort As IO.Ports.SerialPort
    Friend WithEvents PortStatusToolStripLabel As ToolStripLabel
    Friend WithEvents TwoTimer As Timer
    Friend WithEvents FiveTimer As Timer
    Friend WithEvents SystemTempTextBox As TextBox
    Friend WithEvents HouseTempTextBox As TextBox
    Friend WithEvents DecButton As Button
    Friend WithEvents IncButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UnitTempTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CoolingPictureBox As PictureBox
    Friend WithEvents HeaterPictureBox As PictureBox
    Friend WithEvents FanPictureBox As PictureBox
    Friend WithEvents ConnectToolStripButton As ToolStripButton
    Friend WithEvents SetTempLabel As Label
    Friend WithEvents TimeToolStripLabel As ToolStripLabel
    Friend WithEvents IsuPictureBox As PictureBox
    Friend WithEvents TimeTimer As Timer
    Friend WithEvents HouseToolTip As ToolTip
End Class
