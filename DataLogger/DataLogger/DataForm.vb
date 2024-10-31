Option Explicit On
Option Strict On
' Owen Fujii
' RCET 3371
' Data Logger
' Started on 10/24/2024
' TODO
' {*} Create Gui with full interface and display
' {*} Serial communication to Pic/Qy@ board
' {*} Add serial verify for port state
' {*} Graphical display of entire data history
' {*} Graphical display for last 30 second history
' {*} Multiple analog channels
' {*} Default sample rate for 10 samples a second
' {*} Add variable sample select from 1 to 100 samp/sec
' {*} Store analog data in an external file using below format
' "$$AN1",<HighByte>,<LowByte>,<timestamp>
' log_YYMMDDHH.log >> File name style
' {*} Write to file every hour

' Notes: Current GUI display does have some "ghosting" effect
' unable to resolve the ghosting but 


Imports System.IO.Ports

Public Class DataForm

    Dim port As Boolean
    Dim msb As Byte
    Dim lsb As Byte
    Dim anCh As String
    Dim disScale As Integer
    Dim anOne As Boolean
    Dim anTwo As Boolean
    Dim anThree As Boolean
    Dim anFour As Boolean
    Dim store(1) As String

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
        ' on form load try to open serial port automatically
        ' enable analog one as the default and 10 samples a second
        OpenPort()
        SampleComboBox.Text = "10"
        AllRadioButton.Checked = True
        DisplayTimer.Enabled = False
        anOne = True
        anTwo = False
        anThree = False
        anFour = False
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        ' allows user to connect to serial port with button connect.
        ' auto connect or manual selection of the com port is allowed
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
            PollTimer.Enabled = False
        End Try
        anCh = "$$AN1"
    End Sub


    Sub PollAN2()
        ' Sends byte to get the adc result for ADC2
        Dim x(1) As Byte
        x(0) = &H52
        Try

            DataSerialPort.Write(x, 0, 2)
        Catch ex As Exception
            OpenPort()
            MsgBox($"Port was disconnected {vbNewLine} Please check connection")
            PollTimer.Enabled = False
        End Try
        anCh = "$$AN2"
    End Sub

    Sub PollAN3()
        ' Sends byte to get the adc result for ADC3
        Dim x(1) As Byte
        x(0) = &H54
        Try

            DataSerialPort.Write(x, 0, 2)
        Catch ex As Exception
            OpenPort()
            MsgBox($"Port was disconnected {vbNewLine} Please check connection")
            PollTimer.Enabled = False
        End Try
        anCh = "$$AN3"
    End Sub

    Sub PollAN4()
        ' Sends byte to get the adc result for ADC4
        Dim x(1) As Byte
        x(0) = &H58
        Try

            DataSerialPort.Write(x, 0, 2)
        Catch ex As Exception
            OpenPort()
            MsgBox($"Port was disconnected {vbNewLine} Please check connection")
            PollTimer.Enabled = False
        End Try
        anCh = "$$AN4"
    End Sub

    Sub WriteStoredData()
        ' open file to write data to

        Try
            FileOpen(1, $"..\..\Logged Data\log_{DateTime.Now.ToString("yyMMddhh")}.log", OpenMode.Output)

        Catch ex As Exception
            FileOpen(2, "..\..\Errorlog.txt", OpenMode.Append)
            Write(2, CStr($"Error: {Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try
        ' loop to enter all values stored
        For e = LBound(store) To UBound(store)

            Print(1, $"{store(e)}")
        Next
        FileClose(1)

    End Sub


    Private Sub DataSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles DataSerialPort.DataReceived

        Try
            Dim data(DataSerialPort.BytesToRead) As Byte
            DataSerialPort.Read(data, 0, DataSerialPort.BytesToRead)
            If CInt(data(0)) = 0 And CInt(data(1)) = 0 Then
                Console.WriteLine(data(0))
                Console.WriteLine(data(1))
            Else
                msb = data(0)
                lsb = data(1)
                Console.WriteLine(msb)
                Console.WriteLine(lsb >> 6)

                DisplayAnalog()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub DisplayAnalog()
        Dim scale As Integer
        Dim text As String
        Dim anString(1) As String
        ' DataPictureBox.Image = Nothing
        DisplayTimer.Enabled = True
        If ThirtyRadioButton.Checked Then
            If Me.SampleComboBox.InvokeRequired Then

                Me.SampleComboBox.Invoke(New MethodInvoker(Sub() text = SampleComboBox.Text))
            Else
                text = SampleComboBox.Text
            End If
            scale = CInt(CInt(text) * 30)
            disScale = scale
            ShiftArrayAN1(ByteToInt, scale, False)

        Else
            ShiftArrayAN1(ByteToInt)

        End If
        anString = Split(anCh, "$$")
        If Me.AnalogLabel.InvokeRequired Then
            Me.AnalogLabel.Invoke(New MethodInvoker(Sub() AnalogLabel.Text = anString(1)))
        Else

            AnalogLabel.Text = anString(1)
        End If
        StoreData()
    End Sub

    Sub StoreData(Optional reset As Boolean = False)
        ' generate an expanding array that stores all the values collected
        ' stores the channel, msb, lsb, day hour minute second millisecond for each record
        Static i As Integer

        If reset Then
            i = 0
        Else
            store(i) = $"{Chr(34)}{anCh}{Chr(34)},{msb},{lsb >> 6},{DateTime.Now.ToString("ddhhmmss")}.{DateTime.UtcNow.Millisecond}{vbNewLine}"
            i += 1
            ReDim Preserve store(i)
        End If

    End Sub

    Function AnalogColor() As Color
        '
        If anOne Then
            Return Color.Chartreuse
        ElseIf anTwo Then
            Return Color.Cyan
        ElseIf anThree Then
            Return Color.Red
        Else
            Return Color.Magenta
        End If
    End Function

    Sub plot(plotdata() As Integer, Optional length As Integer = 100)
        Dim g As Graphics = DataPictureBox.CreateGraphics
        Dim pen As New Pen(AnalogColor)
        Dim pen2 As New Pen(DataPictureBox.BackColor)
        Dim height As Double = DataPictureBox.Height / 1030
        Dim oldX%, oldY%

        '   Dim widthUnit% = CInt(DataPictureBox.Width / length)
        g.ScaleTransform(CSng(DataPictureBox.Width / length), 1)
        For x = 0 To UBound(plotdata)
            g.DrawLine(pen2, x, 0, x, CSng(DataPictureBox.Height))
            g.DrawLine(pen2, x, 0, x, CSng(DataPictureBox.Height))
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
        Static storeAll(99) As Integer
        Static store30(scale) As Integer
        e += 1
        ReDim Preserve storeAll(e)
        storeAll(UBound(storeAll)) = newdata
        For i = LBound(storeAll) To UBound(storeAll) - 1
            storeAll(i) = storeAll(i + 1)
        Next

        If display Then
            disScale = e
            ' disScale = 100
            'Console.Read()
            Return storeAll
        Else
            For i = LBound(store30) To UBound(store30) - 1
                store30(i) = store30(i + 1)
            Next
            store30(UBound(store30)) = newdata
            ReDim Preserve store30(scale)

            Return store30
        End If
    End Function

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        PollTimer.Enabled = True
        WriteTimer.Enabled = True
        DisplayTimer.Enabled = True
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        PollTimer.Enabled = False
        DisplayTimer.Enabled = False

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PollTimer_Tick(sender As Object, e As EventArgs) Handles PollTimer.Tick
        If port And anOne Then
            PollAN1()
        ElseIf port And anTwo Then
            PollAN2()
        ElseIf port And anThree Then
            PollAN3()
        ElseIf port And anFour Then
            PollAN4()
        Else

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

    Private Sub DisplayTimer_Tick(sender As Object, e As EventArgs) Handles DisplayTimer.Tick
        '    DataPictureBox.Image = Nothing
        If ThirtyRadioButton.Checked Then

            ' ShiftArrayAN1(ByteToInt, Scale, False)
            plot(ShiftArrayAN1(ByteToInt, disScale, False), disScale)
        Else

            plot(ShiftArrayAN1(ByteToInt), disScale)
        End If
    End Sub

    Private Sub AN1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AN1ToolStripMenuItem.Click
        anOne = True
        anTwo = False
        anThree = False
        anFour = False
    End Sub

    Private Sub AN2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AN2ToolStripMenuItem.Click
        anTwo = True
        anOne = False
        anThree = False
        anFour = False
    End Sub

    Private Sub ComComboBox_TextChanged(sender As Object, e As EventArgs) Handles ComComboBox.TextChanged
        DataPictureBox.Refresh()
    End Sub

    Private Sub AN3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AN3ToolStripMenuItem.Click
        anOne = False
        anTwo = False
        anThree = True
        anFour = False
    End Sub

    Private Sub AN4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AN4ToolStripMenuItem.Click
        anOne = False
        anTwo = False
        anThree = False
        anFour = True
    End Sub
End Class
