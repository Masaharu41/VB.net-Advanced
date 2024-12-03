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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SmartSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TwoTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FiveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HouseTempComboBox = New System.Windows.Forms.ComboBox()
        Me.SystemTempTextBox = New System.Windows.Forms.TextBox()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(293, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'TwoTimer
        '
        Me.TwoTimer.Interval = 20000
        '
        'FiveTimer
        '
        Me.FiveTimer.Interval = 5000
        '
        'HouseTempComboBox
        '
        Me.HouseTempComboBox.FormattingEnabled = True
        Me.HouseTempComboBox.Items.AddRange(New Object() {"50", "50.5"})
        Me.HouseTempComboBox.Location = New System.Drawing.Point(89, 141)
        Me.HouseTempComboBox.Name = "HouseTempComboBox"
        Me.HouseTempComboBox.Size = New System.Drawing.Size(121, 33)
        Me.HouseTempComboBox.TabIndex = 2
        '
        'SystemTempTextBox
        '
        Me.SystemTempTextBox.Location = New System.Drawing.Point(455, 143)
        Me.SystemTempTextBox.Name = "SystemTempTextBox"
        Me.SystemTempTextBox.ReadOnly = True
        Me.SystemTempTextBox.Size = New System.Drawing.Size(100, 31)
        Me.SystemTempTextBox.TabIndex = 3
        '
        'HVACGuiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SystemTempTextBox)
        Me.Controls.Add(Me.HouseTempComboBox)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents ComToolStripComboBox As ToolStripComboBox
    Friend WithEvents SmartSerialPort As IO.Ports.SerialPort
    Friend WithEvents PortStatusToolStripLabel As ToolStripLabel
    Friend WithEvents TwoTimer As Timer
    Friend WithEvents FiveTimer As Timer
    Friend WithEvents HouseTempComboBox As ComboBox
    Friend WithEvents SystemTempTextBox As TextBox
End Class
