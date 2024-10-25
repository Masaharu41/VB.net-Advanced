Option Explicit On
Option Strict On
' Owen Fujii
' RCET 3371
' Data Logger
' Started on 10/24/2024
' TODO
' {} Create Gui with full interface and display
' {*} Serial communication to Pic/Qy@ board
' {*} Add serial verify for port state
' {} Graphical display of entire data history
' {} Graphical display for last 30 second history
' {} Multiple analog channels
' {*} Default sample rate for 10 samples a second
' {*} Add variable sample select from 1 to 100 samp/sec
' {} Store analog data in an external file using below format
' "$$AN1",<HighByte>,<LowByte>,<timestamp>
' log_YYMMDDHH.log >> File name style
' {} Write to file every hour

Imports System.IO.Ports

Public Class DataForm

    Dim port As Boolean
    Dim msb As Byte
    Dim lsb As Byte
    Dim anCh As String
    Dim store(1) As String
    Dim storeAll(1) As Integer
    Dim store30(1) As Integer
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
        SampleComboBox.Text = "10"
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
        anCh = "$$AN1"
    End Sub

    Sub WriteStoredData()
        ' Static currentUser As String


        Try
            FileOpen(1, $"..\..\Logged Data\log_{DateTime.Now.ToString("yyMMddhh")}.log", OpenMode.Append)

        Catch ex As Exception
            FileOpen(2, "..\..\Errorlog.txt", OpenMode.Append)
            Write(2, CStr($"Error: {Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try
        For e = LBound(store) To UBound(store)

            Write(1, $"{store(e)}")
        Next
        FileClose(1)

    End Sub


    Private Sub DataSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles DataSerialPort.DataReceived
        Try
            Dim data(DataSerialPort.BytesToRead) As Byte
            DataSerialPort.Read(data, 0, DataSerialPort.BytesToRead)
            msb = data(0)
            lsb = data(1)
            Console.WriteLine(msb)
            Console.WriteLine(lsb >> 6)
            displayAN1()
        Catch ex As Exception

        End Try

    End Sub
    Sub DisplayAN1()
        DataPictureBox.Image = Nothing
        plot(ShiftArrayAN1(ByteToInt))
        StoreData()
    End Sub

    Sub StoreData(Optional reset As Boolean = False)
        Static i As Integer

        If reset Then
            i = 0
        Else
            store(i) = $"{anCh},{msb},{lsb >> 6},{DateTime.Now.ToString("ddhhmmss")}{DateTime.UtcNow.Millisecond}"
            i += 1
            ReDim Preserve store(i)
        End If

    End Sub


    Sub plot(plotdata() As Integer)
        Dim g As Graphics = DataPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim height As Double = DataPictureBox.Height / 1030
        Dim oldX%, oldY%
        Dim widthUnit% = CInt(DataPictureBox.Width / 100)
        g.ScaleTransform(CSng(DataPictureBox.Width / 100), 1)
        For x = 0 To UBound(plotdata)
            g.DrawLine(pen, oldX, oldY, x, CInt(plotdata(x) * height))
            oldX = x
            oldY = CInt(plotdata(x) * height)
        Next
    End Sub

    Function ByteToInt() As Integer
        Dim byteAsInt%

        byteAsInt = CInt(msb) * 4 + CInt(lsb >> 6)
        ' DataPictureBox.Refresh()

        Return byteAsInt
    End Function
    Function ShiftArrayAN1(newdata As Integer, Optional scale As Integer = 100, Optional display As Boolean = True) As Integer()
        '  Static Dim data(99) As Integer
        Static e As Integer
        ReDim Preserve storeAll(e)
        ReDim Preserve store30(scale)
        If display Then

            For i = LBound(storeAll) To UBound(storeAll) - 1
                storeAll(i) = storeAll(i + 1)
            Next
            storeAll(UBound(storeAll)) = newdata
            'Console.Read()
            Return storeAll
        Else
            For i = LBound(store30) To UBound(store30) - 1
                store30(i) = store30(i + 1)
            Next
            store30(UBound(store30)) = newdata
            Return store30()
        End If
        e += 1
    End Function

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        PollTimer.Enabled = True
        WriteTimer.Enabled = True
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

    Private Sub SampleButton_Click(sender As Object, e As EventArgs) Handles SampleButton.Click
        PollTimer.Enabled = False
        PollTimer.Interval = CalculatePoll()
        PollTimer.Enabled = True
    End Sub

    Function CalculatePoll() As Integer
        Dim pollRate%
        If CInt(SampleComboBox.Text) <= 100 Then

            pollRate = CInt(1000 / CInt(SampleComboBox.Text))
        Else
            MsgBox("Sample Rate cannot be greater than 100")
            pollRate = 10
        End If

        Return pollRate
    End Function

    Private Sub WriteTimer_Tick(sender As Object, e As EventArgs) Handles WriteTimer.Tick
        WriteStoredData()
    End Sub
End Class
