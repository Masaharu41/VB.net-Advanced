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
'{*} Allow user to adjust 0.5 degree increments in a high and low setpoint boxes 
'{*} Only allow room temperature to be applied from 50 to 90 degrees farenheit
'{*} Analog Input 1 as the overall temperature of from
'{*} Analog Input 2 as the temperature of the heating and cooling system
'{*} Poll heating and cooling temperature every 2 min
'{*} Thermal protection that shutsdown unit if temperature does not perform as desired
'{} Digital Input 1 handles safety interlock // low = error // Display error on GUI
'{} Display safety interlock error on Digital Output 1
'{} Digital Input 2 controls heating function
Imports System.CodeDom.Compiler
Imports System.Media
Imports System.Threading.Thread
Public Class HVACGuiForm

    Public GrowlGreyLight As Color = Color.FromArgb(230, 213, 232)
    Public GrowlGreyMed As Color = Color.FromArgb(167, 167, 167)
    Public GrowlGrey As Color = Color.FromArgb(130, 130, 130)
    Public Roarange As Color = Color.FromArgb(244, 121, 32)
    Public RoarangeL As Color = Color.FromArgb(246, 146, 64)
    Public BengalBlack As Color = Color.FromArgb(0, 0, 0)

    Dim port As Boolean
    Dim houseTemp As Single
    Dim unitTemp As Single
    Dim shutdown As Boolean
    Dim wait As Boolean
    Dim cooling As Boolean

    Private Sub HVACGuiForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackColor = GrowlGrey
        Me.ForeColor = BengalBlack
        shutdown = False
        HouseTempTextBox.Text = "70"    ' set default temp to 70
        OpenPort()
        If port Then
            TwoTimer.Enabled = True
            SampleSensors()
        Else
            TwoTimer.Enabled = False
        End If
        FiveTimer.Enabled = False
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
                SmartSerialPort.Close()
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
                    portValid = False
                    SmartSerialPort.Close()
                End Try
            Next
        End If

        If portValid = True Then
            PortStatusToolStripLabel.Text = "Port Is Open"
            ComToolStripComboBox.Text = portName
            port = True

        Else
            PortStatusToolStripLabel.Text = "Port Is Closed"
            port = False
        End If
    End Sub

    Sub PollAN1()
        ' Sends byte to get the adc result for ADC1
        Dim x(0) As Byte
        x(0) = &H51
        Try

            SmartSerialPort.Write(x, 0, 1)
        Catch ex As Exception
            ' try to reconnect port automatically
            OpenPort()
            MsgBox($"Port was disconnected {vbNewLine} Please check connection")
        End Try

    End Sub

    Sub PollAN2()
        ' Sends byte to get the adc result for ADC2
        Dim x(0) As Byte
        x(0) = &H52
        Try

            SmartSerialPort.Write(x, 0, 1)
        Catch ex As Exception
            OpenPort()
            MsgBox($"Port was disconnected {vbNewLine} Please check connection")
        End Try


    End Sub

    Sub PollDigital()
        Dim temp(0) As Byte
        temp(0) = &H30
        Try

            SmartSerialPort.Write(temp, 0, 1)
        Catch ex As Exception
            OpenPort()
            MsgBox($"Port was disconnected {vbNewLine} Please check connection")
            port = False

        End Try


    End Sub

    Sub SetDigital(output As Byte)
        Dim digByte(1) As Byte
        digByte(0) = &H20
        digByte(1) = output
        Try
            SmartSerialPort.Write(digByte, 0, 2)
        Catch ex As Exception
        OpenPort()
        MsgBox($"Port was disconnected {vbNewLine} Please check connection")
        port = False
        End Try

    End Sub


    Function ReceiveData() As Byte()
        Sleep(5) ' wait for data to be recieved from Qy@ board
        Dim recievedData(SmartSerialPort.BytesToRead) As Byte

        SmartSerialPort.Read(recievedData, 0, SmartSerialPort.BytesToRead)

        Return recievedData

    End Function

    Private Sub TwoTimer_Tick(sender As Object, e As EventArgs) Handles TwoTimer.Tick
        SampleSensors()
        SetOutputs()
    End Sub

    Sub SampleSensors()
        Dim temp() As Byte
        PollAN1()                       ' poll house temperature
        temp = ReceiveData()
        houseTemp = ConvertToTemp(temp) ' convert byte to integer representation 
        SystemTempTextBox.Text = CStr(houseTemp)
        PollAN2()
        temp = ReceiveData()
        unitTemp = ConvertToTemp(temp)
    End Sub

    Function ConvertToTemp(temp() As Byte) As Single
        '  converts a two byte array to the temperature of the sensor based upon the 
        Dim int As Single

        int = CSng((CInt(temp(0)) * 4 + CInt(temp(1) >> 6) * 4.888) / 6.666)

        Return int
    End Function

    Sub SetOutputs()
        UnitTempTextBox.Text = CStr(unitTemp)
        If houseTemp >= CSng(HouseTempTextBox.Text) + 2 Then
            EnableCooler()
        ElseIf houseTemp <= CSng(HouseTempTextBox.Text) - 2 Then
            EnableHeater()
        Else
            InterlockCheck()
            DisableUnit()
        End If

    End Sub


    Sub DisableUnit()
        ' set output fan as true
        SetDigital(&H4)
        FiveTimer.Enabled = True        ' enable 5 second wait
        wait = True

    End Sub

    Sub EnableCooler()
        If InterlockCheck() Then
            If unitTemp >= 40 Then
                If cooling = True Then
                    ' system is currently enabled keep cooling until low limit has been reached.
                Else
                    wait = False
                    cooling = True

                    SetDigital(&H4)
                    FiveTimer.Enabled = True
                End If
            Else
                SetDigital(&H4)
            End If
        Else
            TwoTimer.Enabled = False
        End If
    End Sub

    'Function BytetoBit(byteConvert As Byte) As BitArray

    'End Function
    Sub EnableHeater()
        Dim heaterByte(0) As Byte
        If InterlockCheck() Then
            If unitTemp <= 110 Then
                If cooling = False Then
                    ' heater is currently active
                Else
                    wait = False
                    cooling = False
                    SetDigital(&H4)
                    FiveTimer.Enabled = True
                End If
            Else
                ' disable heater if temperature is greater than 110 degrees
                SetDigital(&H4)
            End If

        Else
            TwoTimer.Enabled = False
        End If
    End Sub


    ''' <summary>
    ''' Checks that the interlock switch on input 1 is high 
    ''' if status reports false the InterLockIssue sub saves the error
    ''' to a log file and they system enters a shutdown mode
    ''' </summary>
    ''' <returns></returns>

    Function InterlockCheck() As Boolean
        Dim byteArray() As Byte
        PollDigital()
        byteArray = ReceiveData()
        If TestBit(byteArray(0), 1) Then

            Return True
        Else
            InterLockIssue()
            Panic()

            Return False
        End If
    End Function

    Function TestBit(byteA As Byte, bit As Integer) As Boolean
        Dim bitarray As New BitArray({byteA}) ' {} brackets force conversion based upon the value of each bit in the byte. required!!!!
        If bitarray(bit) Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub Panic()
        ErrorLabel.Text = $"Interlock Issue Has Occured {vbNewLine} System Service Mandatory!!!"
        Me.BackColor = Color.Red
        Try
            My.Computer.Audio.Play("..\..\siren2.wav", AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MsgBox("no audio found")
        End Try
        SetDigital(&H2)
    End Sub

    Sub InterLockIssue()
        Dim errorS As String

        SetDigital(&H1)    ' Set digital 1 error indicator and clear other outputs
        errorS = $"{DateTime.Now.ToString("yyMMddhh")} Interlock Safety Switch Error: System Has Shutdown {vbNewLine}"
        ErrorLog(errorS)
        shutdown = True
        FiveTimer.Enabled = True
    End Sub


    Sub ErrorLog(text As String)
        Try
            FileOpen(1, "..\..\Error.log", OpenMode.Append)
            Write(1, text)
        Catch ex As Exception
            FileOpen(2, "..\..\FileError.log", OpenMode.Append)
            Write(2, CStr($"Error:{Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try

        FileClose(1)
    End Sub

    Private Sub FiveTimer_Tick(sender As Object, e As EventArgs) Handles FiveTimer.Tick

        If shutdown Then
            If InterlockCheck() Then
                shutdown = False
                FiveTimer.Enabled = False
                ErrorLabel.Text = Nothing
                Me.BackColor = GrowlGrey    ' restore background color
                My.Computer.Audio.Stop()    ' stop audio
            Else
            End If
        Else
            If wait Then

                SetDigital(&H0)
            Else
                If cooling Then
                    ' enable cooling system
                    SetDigital(&HC)
                Else
                    SetDigital(&H6)    ' enable heating system
                End If
            End If
            FiveTimer.Enabled = False
        End If
    End Sub

    Private Sub DecButton_Click(sender As Object, e As EventArgs) Handles DecButton.Click
        DecrementTemp()
    End Sub

    Sub DecrementTemp()
        Dim currentTemp As Double = CSng(HouseTempTextBox.Text)
        If currentTemp > 50 Then
            currentTemp = currentTemp - 0.5
            HouseTempTextBox.Text = CStr(currentTemp)
        Else

        End If

    End Sub

    Private Sub IncButton_Click(sender As Object, e As EventArgs) Handles IncButton.Click
        IncrementTemp()
    End Sub

    Sub IncrementTemp()
        Dim currentTemp As Double = CSng(HouseTempTextBox.Text)
        If currentTemp < 90 Then
            currentTemp += 0.5
            HouseTempTextBox.Text = CStr(currentTemp)
        Else

        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
