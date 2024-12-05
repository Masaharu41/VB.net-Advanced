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
'{*} Analog Input 1 as the overall temperature of from
'{*} Analog Input 2 as the temperature of the heating and cooling system
'{*} Poll heating and cooling temperature every 2 min
'{*} Thermal protection that shutsdown unit if temperature does not perform as desired
'{} Digital Input 1 handles safety interlock // low = error // Display error on GUI
'{} Display safety interlock error on Digital Output 1
'{} Digital Input 2 controls heating function
Imports System.CodeDom.Compiler
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
                    ' MsgBox("Com was not Valid")
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
        Dim x(1) As Byte
        x(0) = &H51
        Try

            SmartSerialPort.Write(x, 0, 2)
        Catch ex As Exception
            ' try to reconnect port automatically
            OpenPort()
            MsgBox($"Port was disconnected {vbNewLine} Please check connection")
        End Try

    End Sub

    Sub PollAN2()
        ' Sends byte to get the adc result for ADC2
        Dim x(1) As Byte
        x(0) = &H52
        Try

            SmartSerialPort.Write(x, 0, 2)
        Catch ex As Exception
            OpenPort()
            MsgBox($"Port was disconnected {vbNewLine} Please check connection")
        End Try


    End Sub

    Sub PollDigital()
        Dim temp(1) As Byte
        temp(0) = &H30
        Try

            SmartSerialPort.Write(temp, 0, 2)
        Catch ex As Exception
            OpenPort()
            MsgBox($"Port was disconnected {vbNewLine} Please check connection")
            port = False

        End Try


    End Sub

    Sub SetDigital(temp() As Byte)
        Try
            SmartSerialPort.Write(temp, 0, 1)
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


        If houseTemp >= CSng(HouseTempComboBox.Text) + 2 Then
            EnableCooler()
        ElseIf houseTemp <= CSng(HouseTempComboBox.Text) - 2 Then
            EnableHeater()
        Else
            DisableUnit()

        End If


    End Sub


    Sub DisableUnit()
        Dim sendByte() As Byte
        sendByte(0) = &H4           ' set output fan as true
        SetDigital(sendByte)
        FiveTimer.Enabled = True        ' enable 5 second wait
        wait = True

    End Sub

    Sub EnableCooler()
        Dim coolerByte() As Byte
        If InterlockCheck() Then
            If unitTemp >= 40 Then
                wait = False
                cooling = True
                coolerByte(0) = &H4
                SetDigital(coolerByte)
            Else
                coolerByte(0) = &H4
                SetDigital(coolerByte)
            End If
        Else
            TwoTimer.Enabled = False
        End If
    End Sub

    Function BytetoBit(byteConvert As Byte) As BitArray

    End Function
    Sub EnableHeater()
        Dim heaterByte() As Byte
        If InterlockCheck() Then
            If unitTemp <= 110 Then
                wait = False
                cooling = False
                heaterByte(0) = &H4
                SetDigital(heaterByte)
                FiveTimer.Enabled = True
            Else
                heaterByte(0) = &H4   ' disable heater if temperature is greater than 110 degrees
                SetDigital(heaterByte)
            End If

        Else
                TwoTimer.Enabled = False
        End If
    End Sub

    Function InterlockCheck() As Boolean
        Dim byteArray() As Byte
        Dim bitArray As BitArray = New BitArray(8)
        PollDigital()
        byteArray = ReceiveData()
        bitArray = New BitArray(byteArray(0))
        If bitArray(0) = False Then
            InterLockIssue()
            Return False
        Else
            Return True
        End If
    End Function

    Sub InterLockIssue()
        Dim temp() As Byte
        Dim errorS As String
        temp(0) = &H1
        SetDigital(temp)    ' Set digital 1 error indicator and clear other outputs
        errorS = $"{DateTime.Now.ToString("yyMMddhh")} Interlock Safety Switch Error: System Has Shutdown {vbNewLine}"
        ErrorLog(errorS)
        shutdown = True
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
        Dim sendByte() As Byte
        If shutdown Then
            If InterlockCheck() Then
                shutdown = False
                FiveTimer.Enabled = False
            Else

            End If
        Else
            If wait Then
                sendByte(0) = &H0
                SetDigital(sendByte)
            Else
                sendByte(0) = &H6
                SetDigital(sendByte)
            End If
            FiveTimer.Enabled = False
        End If
    End Sub
End Class
