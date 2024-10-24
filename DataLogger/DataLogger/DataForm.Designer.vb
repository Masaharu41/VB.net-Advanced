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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComComboBox
        '
        Me.ComComboBox.FormattingEnabled = True
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
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 40)
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
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PortConLabel)
        Me.Controls.Add(Me.PortLabel)
        Me.Controls.Add(Me.ComComboBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DataForm"
        Me.Text = "Data Logger"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSerialPort As IO.Ports.SerialPort
    Friend WithEvents ComComboBox As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PortToolStripMenuItem As ToolStripMenuItem
    Public WithEvents PortLabel As Label
    Friend WithEvents PortConLabel As Label
End Class
