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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ComToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.PortStatusToolStripLabel = New System.Windows.Forms.ToolStripLabel()
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
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComToolStripComboBox, Me.PortStatusToolStripLabel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 40)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ComToolStripComboBox
        '
        Me.ComToolStripComboBox.Name = "ComToolStripComboBox"
        Me.ComToolStripComboBox.Size = New System.Drawing.Size(121, 40)
        Me.ComToolStripComboBox.Text = "Com1"
        '
        'PortStatusToolStripLabel
        '
        Me.PortStatusToolStripLabel.Name = "PortStatusToolStripLabel"
        Me.PortStatusToolStripLabel.Size = New System.Drawing.Size(127, 34)
        Me.PortStatusToolStripLabel.Text = "Port Status"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Black
        Me.ErrorLabel.Location = New System.Drawing.Point(275, 260)
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
        '
        'HouseTempTextBox
        '
        Me.HouseTempTextBox.Location = New System.Drawing.Point(211, 143)
        Me.HouseTempTextBox.Name = "HouseTempTextBox"
        Me.HouseTempTextBox.ReadOnly = True
        Me.HouseTempTextBox.Size = New System.Drawing.Size(100, 31)
        Me.HouseTempTextBox.TabIndex = 4
        '
        'DecButton
        '
        Me.DecButton.Location = New System.Drawing.Point(129, 143)
        Me.DecButton.Name = "DecButton"
        Me.DecButton.Size = New System.Drawing.Size(76, 43)
        Me.DecButton.TabIndex = 5
        Me.DecButton.Text = "<"
        Me.DecButton.UseVisualStyleBackColor = True
        '
        'IncButton
        '
        Me.IncButton.Location = New System.Drawing.Point(317, 143)
        Me.IncButton.Name = "IncButton"
        Me.IncButton.Size = New System.Drawing.Size(91, 43)
        Me.IncButton.TabIndex = 6
        Me.IncButton.Text = ">"
        Me.IncButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(607, 382)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(73, 35)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UnitTempTextBox
        '
        Me.UnitTempTextBox.Location = New System.Drawing.Point(455, 180)
        Me.UnitTempTextBox.Name = "UnitTempTextBox"
        Me.UnitTempTextBox.Size = New System.Drawing.Size(100, 31)
        Me.UnitTempTextBox.TabIndex = 8
        '
        'HVACGuiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UnitTempTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.IncButton)
        Me.Controls.Add(Me.DecButton)
        Me.Controls.Add(Me.HouseTempTextBox)
        Me.Controls.Add(Me.SystemTempTextBox)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "HVACGuiForm"
        Me.Text = "Smart Home"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
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
End Class
