' Owen Fujii
' RCET 3372
' 11/16/2024
' Smart Home Controller
Option Strict On
Option Explicit On
Option Compare Binary

'TODO
'{} Create GUI with toolstrip for serial setup
'{} Display active time on GUI 
'{} Display Temperature with state of cooling, heat, and fan
'{} Allow user to adjust 0.5 degree increments in a high and low setpoint boxes 
'{} Only allow room temperature to be applied from 50 to 90 degrees farenheit
'{} Analog Input 1 as the overall temperature of from
'{} Analog Input 2 as the temperature of the heating and cooling system
'{} Poll heating and cooling temperature every 2 min
'{} Thermal protection that shutsdown unit if temperature does not perform as desired
'{} Digital Input 1 handles safety interlock // low = error // Display error on GUI
'{} Display safety interlock error on Digital Output 1
'{} Digital Input 2 controls heating function
Public Class HVACGuiForm

    Public GrowlGreyLight As Color = Color.FromArgb(230, 213, 232)
    Public GrowlGreyMed As Color = Color.FromArgb(167, 167, 167)
    Public GrowlGrey As Color = Color.FromArgb(130, 130, 130)
    Public Roarange As Color = Color.FromArgb(244, 121, 32)
    Public RoarangeL As Color = Color.FromArgb(246, 146, 64)
    Public BengalBlack As Color = Color.FromArgb(0, 0, 0)

    Dim port As Boolean

    Private Sub HVACGuiForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackColor = GrowlGrey
        Me.ForeColor = BengalBlack
        OpenPort()
    End Sub

    Sub OpenPort(Optional force As Boolean = False)
        Dim portValid As Boolean = False
        Dim portName As String
        ' auto test "all" COM port values until a valid connection or nothing reports back
        If force = True Then
            Try
                portName = ComToolStripComboBox.Text
                SmartSerialPort.PortName = portName
                SmartSerialPort.BaudRate = 115200
                SmartSerialPort.Open()
                portValid = True
            Catch ex As Exception
                portValid = False
            End Try
        Else
            For i = 0 To 50

                portName = $"COM{i}"
                Try
                    SmartSerialPort.PortName = portName
                    SmartSerialPort.BaudRate = 115200
                    SmartSerialPort.Open()
                    portValid = True
                    Exit For
                Catch ex As Exception
                    ' MsgBox("Com was not Valid")
                    portValid = False

                End Try
            Next
        End If

        If portValid = True Then
            PortStatustoolstripLabel.Text = "Port Is Open"
            ComToolStripComboBox.SelectedText = portName
            port = True
        Else
            PortStatusToolStripLabel.Text = "Port Is Closed"
            port = False
        End If
    End Sub




End Class
