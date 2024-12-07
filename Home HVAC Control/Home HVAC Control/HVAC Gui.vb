' Owen Fujii
' RCET 3372
' 11/16/2024
' Smart Home Controller
Option Strict On
Option Explicit On
Option Compare Binary

'TODO
'{*} Create GUI with toolstrip for serial setup
'{} Display active time on GUI 
'{*} Display Temperature with state of cooling, heat, and fan
'{*} Allow user to adjust 0.5 degree increments in a high and low setpoint boxes 
'{*} Only allow room temperature to be applied from 50 to 90 degrees farenheit
'{*} Analog Input 1 as the overall temperature of from
'{*} Analog Input 2 as the temperature of the heating and cooling system
'{*} Poll heating and cooling temperature every 2 min
'{*} Thermal protection that shutsdown unit if temperature does not perform as desired
'{*} Digital Input 1 handles safety interlock // low = error // Display error on GUI
'{*} Display safety interlock error on Digital Output 1
'{} Digital Input 2 controls heating function
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Media
Imports System.Threading.Thread
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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
        HomeToolStrip.BackColor = Roarange
        ExitButton.BackColor = GrowlGreyLight
        ExitButton.ForeColor = BengalBlack
        shutdown = False
        HouseTempTextBox.Text = "70"    ' set default temp to 70
        ErrorLabel.Text = Nothing
        RestoreSettings()
        OpenPort(True)
        If port Then
            TwoTimer.Enabled = True
            SampleSensors()
        Else
            TwoTimer.Enabled = False
        End If
        FiveTimer.Enabled = False
        CoolingPictureBox.Visible = False
        HeaterPictureBox.Visible = False
        FanPictureBox.Visible = False
        TimeToolStripLabel.Text = DateTime.Now.ToString("m")
    End Sub

    Sub OpenPort(Optional force As Boolean = False)
        Dim portValid As Boolean = False
        Dim serialError As Boolean = True
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
            For i = 0 To 20

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
            EndPanic()
            ComToolStripComboBox.Text = portName
            port = True

        Else
            PortStatusToolStripLabel.Text = "Port Is Closed"
            Panic(serialError)
            FiveTimer.Enabled = True
            port = False
        End If
    End Sub

    Sub RestoreSettings()
        Dim oldCom() As String
        Dim oldTemp() As String
        Dim temp As String

        Try
            FileOpen(1, "..\..\HVAC Settings.log", OpenMode.Input)

        Catch ex As Exception
            FileOpen(2, "..\..\FileError.log", OpenMode.Append)
            Write(2, CStr($"Error:{Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try

        temp = LineInput(1)
        oldCom = Split(temp, "COM$$:")
        ComToolStripComboBox.Text = oldCom(1)
        temp = LineInput(1)
        oldTemp = Split(temp, "TEMP$$:")
        HouseTempTextBox.Text = oldTemp(1)


        FileClose(1)

    End Sub

    Sub PollAN1()
        ' Sends byte to get the adc result for ADC1
        Dim x(0) As Byte
        x(0) = &H51
        If port Then
            Try

                SmartSerialPort.Write(x, 0, 1)
            Catch ex As Exception
                ' try to reconnect port automatically
                OpenPort()

            End Try



        Else

        End If

    End Sub

    Sub PollAN2()
        ' Sends byte to get the adc result for ADC2
        Dim x(0) As Byte
        x(0) = &H52
        If port Then
            Try

                SmartSerialPort.Write(x, 0, 1)
            Catch ex As Exception
                OpenPort()

            End Try
        Else

        End If


    End Sub

    Sub PollDigital()
        Dim temp(0) As Byte
        temp(0) = &H30
        If port Then
            Try

                SmartSerialPort.Write(temp, 0, 1)
            Catch ex As Exception
                OpenPort()
            End Try
        Else

        End If


    End Sub

    Sub SetDigital(output As Byte)
        Dim digByte(1) As Byte
        digByte(0) = &H20
        digByte(1) = output
        If port Then
            Try
                SmartSerialPort.Write(digByte, 0, 2)
            Catch ex As Exception
                OpenPort()

            End Try
        Else

        End If

    End Sub


    Function ReceiveData() As Byte()
        Sleep(5) ' wait for data to be recieved from Qy@ board
        Dim recievedData(SmartSerialPort.BytesToRead) As Byte

        SmartSerialPort.Read(recievedData, 0, SmartSerialPort.BytesToRead)

        Return recievedData

    End Function

    Private Sub TwoTimer_Tick(sender As Object, e As EventArgs) Handles TwoTimer.Tick
        If port Then
            SampleSensors()
            SetOutputs()
        Else
            TwoTimer.Enabled = False
            FiveTimer.Enabled = False
        End If
    End Sub

    Sub SampleSensors()
        Dim temp() As Byte

        PollAN1()                       ' poll house temperature
        If port Then
            temp = ReceiveData()
            houseTemp = CSng(Math.Round(ConvertToTemp(temp), 1)) ' convert byte to integer representation 
            SystemTempTextBox.Text = CStr(houseTemp)
        Else

        End If

        PollAN2()
        If port Then
            temp = ReceiveData()
            unitTemp = CSng(Math.Round(ConvertToTemp(temp), 1))
            UnitTempTextBox.Text = CStr(unitTemp)
        Else

        End If
    End Sub

    Function ConvertToTemp(temp() As Byte) As Double
        '  converts a two byte array to the temperature of the sensor based upon the 
        Dim int As Double

        int = CSng((CInt(temp(0)) * 4 + CInt(temp(1) >> 6) * 4.888) / 6.666)

        Return int
    End Function

    Sub SetOutputs()

        If port Then
            If houseTemp >= CSng(HouseTempTextBox.Text) + 2 Then
                EnableCooler()
            ElseIf houseTemp <= CSng(HouseTempTextBox.Text) - 2 Then
                EnableHeater()
            Else
                InterlockCheck()
                DisableUnit()
            End If
        Else

        End If

    End Sub


    Sub DisableUnit()
        SetDigital(&H4)
        FiveTimer.Enabled = True        ' enable 5 second wait
        wait = True
        HeaterPictureBox.Visible = False
        CoolingPictureBox.Visible = False
        cooling = Not cooling
    End Sub

    Sub EnableCooler()
        HeaterPictureBox.Visible = False
        If InterlockCheck() Then
            If unitTemp >= 40 Then
                If cooling = True Then
                    SetDigital(&HC)
                    CoolingPictureBox.Visible = True
                    ' system is currently enabled keep cooling until low limit has been reached.
                Else
                    wait = False
                    cooling = True
                    FanPictureBox.Visible = True
                    SetDigital(&H4)
                    FiveTimer.Enabled = True
                End If
            Else
                CoolingPictureBox.Visible = False
                FanPictureBox.Visible = True
                SetDigital(&H4)
            End If
        Else
            TwoTimer.Enabled = False
        End If
    End Sub


    Sub EnableHeater()
        CoolingPictureBox.Visible = False
        If InterlockCheck() Then
            If unitTemp <= 110 Then
                If cooling = False Then
                    HeaterPictureBox.Visible = True
                    SetDigital(&H6)
                    ' heater is currently active
                Else
                    wait = False
                    cooling = False

                    SetDigital(&H4)
                    FanPictureBox.Visible = True
                    FiveTimer.Enabled = True
                End If
            Else
                ' disable heater if temperature is greater than 110 degrees
                HeaterPictureBox.Visible = False
                FanPictureBox.Visible = True
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

    Sub Panic(Optional serial As Boolean = False)
        If serial Then
            ErrorLabel.Text = $"External System Disconnected {vbNewLine} Potential Fire Hazard!!!"
        Else
            ErrorLabel.Text = $"Interlock Issue Has Occured {vbNewLine} System Service Mandatory!!!"
            SetDigital(&H2)
        End If
        Me.BackColor = Color.Red
        Try
            My.Computer.Audio.Play("..\..\siren2.wav", AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MsgBox("no audio found")
        End Try
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
                EndPanic()
            Else
            End If
        ElseIf port = False Then
            OpenPort()
            If port Then
                EndPanic()
            Else

            End If
        Else
            If wait Then
                FanPictureBox.Visible = False
                SetDigital(&H0)
            Else
                If cooling Then
                    ' enable cooling system
                    CoolingPictureBox.Visible = True
                    SetDigital(&HC)
                Else
                    HeaterPictureBox.Visible = True
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

    Sub EndPanic()
        FiveTimer.Enabled = False
        ErrorLabel.Text = Nothing
        TwoTimer.Enabled = True
        Me.BackColor = GrowlGrey    ' restore background color
        My.Computer.Audio.Stop()    ' stop audio
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ConnectToolStripButton.Click
        Dim force As Boolean = True
        OpenPort(force)
    End Sub

    Private Sub HVACGuiForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveStatus()
    End Sub

    Sub SaveStatus()
        Dim status As String
        status = $"COM$$:{ComToolStripComboBox.Text}{vbNewLine}TEMP$$:{HouseTempTextBox.Text}"
        Try
            FileOpen(1, "..\..\HVAC Settings.log", OpenMode.Output)
            Print(1, status)
        Catch ex As Exception
            FileOpen(2, "..\..\FileError.log", OpenMode.Append)
            Write(2, CStr($"Error:{Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try

        FileClose(1)
    End Sub


End Class
