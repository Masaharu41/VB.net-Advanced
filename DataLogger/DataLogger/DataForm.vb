Option Explicit On
Option Strict On
' Owen Fujii
' RCET 3371
' Data Logger
' Started on 10/24/2024
' TODO
' {} Create Gui with full interface and display
' {*} Serial communication to Pic/Qy@ board
' {} Add serial verify for port state
' {} Graphical display of entire data history
' {} Graphical display for last 30 second history
' {} Multiple analog channels
' {} Default sample rate for 10 samples a second
' {} Add variable sample select from 1 to 100 samp/sec
' {} Store analog data in an external file using below format
' "$$AN1",<HighByte>,<LowByte>,<timestamp>
' log_YYMMDDHH.log >> File name style
' {} Write to file every hour

Imports System.IO.Ports

Public Class DataForm

    Dim port As Boolean
    Dim msb As Byte
    Dim lsb As Byte

    Sub OpenPort(Optional force As Boolean = False)
        Dim portValid As Boolean = False
        Dim portName As String
        ' auto test "all" COM port values until a valid connection or nothing reports back
        If force = True Then
            Try
                portName = ComComboBox.Text
                DataSerialPort.PortName = portName
                DataSerialPort.BaudRate = 115200
                DataSerialPort.Open()
                portValid = True
            Catch ex As Exception
                portValid = False
            End Try
        Else
            For i = 0 To 50

                portName = $"COM{i}"
                Try
                    DataSerialPort.PortName = portName
                    DataSerialPort.BaudRate = 115200
                    DataSerialPort.Open()
                    portValid = True
                    Exit For
                Catch ex As Exception
                    ' MsgBox("Com was not Valid")
                    portValid = False

                End Try
            Next
        End If

        If portValid = True Then
            PortLabel.Text = "Port Is Open"
            ComComboBox.SelectedText = portName
            port = True
        Else
            PortLabel.Text = "Port Is Closed"
            port = False
        End If
    End Sub

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenPort()
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        If ManualCheckBox.Checked Then
            OpenPort(True)
        Else
            OpenPort()
        End If
    End Sub

    Sub PollAN1()
        ' Sends byte to get the adc result for ADC1
        Dim x(1) As Byte
        x(0) = &H51
        Try

            DataSerialPort.Write(x, 0, 2)
        Catch ex As Exception
            OpenPort()
            MsgBox($"Port was disconnected {vbNewLine} Please check connection")
        End Try
    End Sub

    Private Sub DataSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles DataSerialPort.DataReceived
        Dim data(DataSerialPort.BytesToRead) As Byte
        DataSerialPort.Read(data, 0, DataSerialPort.BytesToRead)
        Try
            msb = data(0)
            lsb = data(1)
            ByteToInt()
        Catch ex As Exception

        End Try

    End Sub

    Sub plot(plotdata() As Integer)
        Dim g As Graphics = DataPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim height% = DataPictureBox.Height
        Dim oldX%, oldY%
        Dim widthUnit% = CInt(DataPictureBox.Width / 1024)
        g.ScaleTransform(CSng(DataPictureBox.Width / 1024), 1)
        For x = 0 To UBound(plotdata)
            g.DrawLine(pen, oldX, oldY, x, plotdata(x))
            oldX = x
            oldY = plotdata(x)
        Next
    End Sub

    Sub ByteToInt()
        Dim byteAsInt%

        byteAsInt = CInt(msb) * 4 + CInt(lsb >> 6)
        plot(ShiftArrayAN1(byteAsInt))

    End Sub
    Function ShiftArrayAN1(newdata As Integer) As Integer()
        Static Dim data(99) As Integer

        For i = LBound(data) To UBound(data) - 1
            data(i) = data(i + 1)
        Next
        data(UBound(data)) = newdata
        'Console.Read()
        Return data
    End Function

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        PollTimer.Enabled = True
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        PollTimer.Enabled = False
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PollTimer_Tick(sender As Object, e As EventArgs) Handles PollTimer.Tick
        If port Then
            PollAN1()
        End If
    End Sub
End Class
