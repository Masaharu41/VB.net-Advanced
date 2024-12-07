' Owen Fujii
' RCET 3372
' 11/16/2024
' Smart Home Controller
Option Strict On
Option Explicit On
Option Compare Binary

'TODO
'{*} Create GUI with toolstrip for serial setup
'{*} Display active time on GUI 
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
Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Threading.Thread
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class HVACGuiForm


    ' set color variables for form
    Public GrowlGreyLight As Color = Color.FromArgb(230, 213, 232)
    Public GrowlGreyMed As Color = Color.FromArgb(167, 167, 167)
    Public GrowlGrey As Color = Color.FromArgb(130, 130, 130)
    Public Roarange As Color = Color.FromArgb(244, 121, 32)
    Public RoarangeL As Color = Color.FromArgb(246, 146, 64)
    Public BengalBlack As Color = Color.FromArgb(0, 0, 0)
    ' set global variables
    Dim port As Boolean
    Dim houseTemp As Single
    Dim unitTemp As Single
    Dim shutdown As Boolean
    Dim wait As Boolean
    Dim cooling As Boolean
    Dim farenheit As Boolean
    ''' <summary>
    ''' On form load
    ''' set form colors and variables
    ''' reloads the prior settings from last form close and opens com port
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub HVACGuiForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackColor = GrowlGrey
        Me.ForeColor = BengalBlack
        HomeToolStrip.BackColor = Roarange
        ExitButton.BackColor = GrowlGreyLight
        ExitButton.ForeColor = BengalBlack
        shutdown = False
        ErrorLabel.Text = Nothing
        If RestoreSettings() Then
            OpenPort(True)
        Else
            OpenPort()
            HouseTempTextBox.Text = "70"
        End If
        If port Then
            TwoTimer.Enabled = True
            SampleSensors()
            SetOutputs()
        Else
            TwoTimer.Enabled = False
        End If
        FiveTimer.Enabled = False
        CoolingPictureBox.Visible = False
        HeaterPictureBox.Visible = False
        FanPictureBox.Visible = False
        IsuPictureBox.Visible = True
        TimeToolStripLabel.Text = DateTime.Now.ToString
    End Sub
    ''' <summary>
    ''' a sub routine that is used to connect to a serial port
    ''' can either be auto connect or a manual connect based upon
    ''' the text box provided on the form
    ''' </summary>
    ''' <param name="force"></param>

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

    ''' <summary>
    ''' sub routine which opens the save file and then reads the saved settings
    ''' </summary>
    Function RestoreSettings() As Boolean
        Dim oldCom() As String
        Dim oldTemp() As String
        Dim oldType() As String
        Dim temp As String

        Try
            FileOpen(1, "..\..\HVAC Settings.log", OpenMode.Input)

            temp = LineInput(1)
            oldType = Split(temp, "TYPE$$:")
            CelsiusRadioButton.Checked = Not CBool(oldType(1))
            temp = LineInput(1)
            oldCom = Split(temp, "COM$$:")
            ComToolStripComboBox.Text = oldCom(1)
            temp = LineInput(1)
            oldTemp = Split(temp, "TEMP$$:")
            If String.IsNullOrEmpty(oldTemp(1)) Then
                FileClose(1)
                Return False
            Else
                If CelsiusRadioButton.Checked Then
                    HouseTempTextBox.Text = CStr(FtoC(CDbl(oldTemp(1))))
                Else
                    HouseTempTextBox.Text = oldTemp(1)
                End If
            End If

            FileClose(1)
            Return True
        Catch ex As Exception
            FileOpen(2, "..\..\FileError.log", OpenMode.Append)
            Write(2, CStr($"Error:{Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Polls analog input 1 from the external microcontroller
    ''' this input is to be connected to the overall house temperature sensor
    ''' </summary>
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

    ''' <summary>
    ''' Polls analog input 2 from the external microcontroller
    ''' this input is to be connected to the HVAC unit temperature sensor
    ''' </summary>

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

    ''' <summary>
    ''' polls digital input from external microcontroller
    ''' polling this data gives information on safety interlock and manual overrides
    ''' </summary>

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

    ''' <summary>
    ''' sets external digital outputs on external microcontroller
    ''' sets interlock error flag and controls the HVAC functions
    ''' </summary>
    ''' <param name="output"></param>

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

    ''' <summary>
    ''' A function which reads the serial port after a 5ms delay.
    ''' </summary>
    ''' <returns></returns>
    Function ReceiveData() As Byte()
        Sleep(5) ' wait for data to be recieved from Qy@ board
        Dim recievedData(SmartSerialPort.BytesToRead) As Byte

        SmartSerialPort.Read(recievedData, 0, SmartSerialPort.BytesToRead)

        Return recievedData

    End Function

    ''' <summary>
    ''' A sub routine that is based on the two second poll timer used to make adjustments to the HVAC system
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TwoTimer_Tick(sender As Object, e As EventArgs) Handles TwoTimer.Tick
        If port Then
            SampleSensors()
            SetOutputs()
        Else
            TwoTimer.Enabled = False
            FiveTimer.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' A subroutine which grabs the data from external sensors and sets appropriate globals as well as indication
    ''' </summary>

    Sub SampleSensors()
        Dim temp() As Byte

        PollAN1()                       ' poll house temperature
        If port Then
            temp = ReceiveData()
            houseTemp = CSng(Math.Round(ConvertToTemp(temp), 1)) ' convert byte to integer representation 
            If farenheit Then
            Else
                houseTemp = CSng(FtoC(houseTemp))
            End If
            SystemTempTextBox.Text = CStr(houseTemp)
        Else

        End If

        PollAN2()
        If port Then
            temp = ReceiveData()
            unitTemp = CSng(Math.Round(ConvertToTemp(temp), 1))
            If farenheit Then
            Else
                unitTemp = CSng(FtoC(unitTemp))
            End If
            UnitTempTextBox.Text = CStr(unitTemp)
        Else

        End If
    End Sub

    ''' <summary>
    ''' A function that converts the analog conversion in to a temperature
    ''' extenal sensor is configured with .6 gain
    ''' </summary>
    ''' <param name="temp"></param>
    ''' <returns></returns>

    Function ConvertToTemp(temp() As Byte) As Double
        '  converts a two byte array to the temperature of the sensor based upon the 
        Dim int As Double

        int = CSng((CInt(temp(0)) * 4 + CInt(temp(1) >> 6) * 4.888) / 6)
        Return int
    End Function

    Function FtoC(unit As Double) As Double

        Return Math.Round(((unit - 32) * 5 / 9), 1)

    End Function

    ''' <summary>
    ''' A sub routine which handles comparing the set home temperature to its actual
    ''' has a +/- 2 degree hysteresis curve to reduce system overshoot and safe costs
    ''' </summary>
    Sub SetOutputs()
        Static hold As Boolean
        If port Then
            If hold And houseTemp >= CSng(HouseTempTextBox.Text) - 1 Then
                EnableCooler()
            ElseIf hold And houseTemp <= CSng(HouseTempTextBox.Text) + 1 Then
                EnableHeater()
            ElseIf houseTemp >= CSng(HouseTempTextBox.Text) + 2 Then
                EnableCooler()
                hold = True
            ElseIf houseTemp <= CSng(HouseTempTextBox.Text) - 2 Then
                EnableHeater()
                hold = True
            Else
                hold = False
                InterlockCheck()
                DisableUnit()
            End If
        Else
            hold = False
        End If

    End Sub

    ''' <summary>
    ''' A sub routine that handles when the unit is to be disabled. 
    ''' The fan will be held an additional 5 seconds after the primary
    ''' HVAC system has been disabled.
    ''' </summary>
    Sub DisableUnit()
        SetDigital(&H4)
        FiveTimer.Enabled = True        ' enable 5 second wait
        wait = True
        HeaterPictureBox.Visible = False
        CoolingPictureBox.Visible = False
        cooling = Not cooling
    End Sub

    ''' <summary>
    ''' A subroutine that enables the HVAC's cooling system and ensures that the unit
    ''' does not become too cold as to cause damage or potential safety concerns
    ''' </summary>
    Sub EnableCooler()
        Dim minTemp As Double
        HeaterPictureBox.Visible = False
        If farenheit Then
            minTemp = 40
        Else
            minTemp = FtoC(40)
        End If
        If InterlockCheck() Then
            If unitTemp >= minTemp Then
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

    ''' <summary>
    ''' A subroutine that enables the HVAC's heating system and ensures that the unit
    ''' does not become too cold as to cause damage or potential safety concerns
    ''' </summary>
    Sub EnableHeater()
        CoolingPictureBox.Visible = False
        Dim maxTemp As Double
        If farenheit Then
            maxTemp = 110
        Else
            maxTemp = FtoC(110)
        End If
        If InterlockCheck() Then
            If unitTemp <= maxTemp Then
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

    ''' <summary>
    ''' a function that returns a boolean on whether the bit in the byte included
    ''' is a true or false statement
    ''' </summary>
    ''' <param name="byteA"></param>
    ''' <param name="bit"></param>
    ''' <returns></returns>
    Function TestBit(byteA As Byte, bit As Integer) As Boolean
        Dim bitarray As New BitArray({byteA}) ' {} brackets force conversion based upon the value of each bit in the byte. required!!!!
        If bitarray(bit) Then
            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' A sub routine that is called when a system error occurs that warns the user to 
    ''' service the system immediately to avoid damage and hazards
    ''' </summary>
    ''' <param name="serial"></param>

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

    ''' <summary>
    ''' A subroutine that saves when an interlock error has occured
    ''' </summary>
    Sub InterLockIssue()
        Dim errorS As String
        SetDigital(&H1)    ' Set digital 1 error indicator and clear other outputs
        errorS = $"{DateTime.Now.ToString("yyMMddhh")} Interlock Safety Switch Error: System Has Shutdown {vbNewLine}"
        ErrorLog(errorS)
        shutdown = True
        FiveTimer.Enabled = True
    End Sub

    ''' <summary>
    ''' a subroutine that saves a string to an Error.log file
    ''' </summary>
    ''' <param name="text"></param>
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

    ''' <summary>
    ''' A sub that is triggered at the end of a 5 second timer. 
    ''' primary purpose is to allow a delay from when the fan is enabled
    ''' to when the primary HVAC unit is enabled and disabled
    ''' This sub is also used to continually poll that a panic 
    ''' error has been properly addressed and that the system
    ''' can return to normal operations
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

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

    ''' <summary>
    ''' A sub used to decrement the text box used to set the house temperature in 0.5 degree changes
    ''' </summary>
    Sub DecrementTemp()
        Dim currentTemp As Double = CSng(HouseTempTextBox.Text)
        Dim celTemp As Double
        If farenheit Then
            celTemp = 50
        Else
            celTemp = FtoC(50)
        End If
        If currentTemp > celTemp Then
            currentTemp = currentTemp - 0.5
            HouseTempTextBox.Text = CStr(Math.Round(currentTemp, 1))
        Else

        End If

    End Sub

    Private Sub IncButton_Click(sender As Object, e As EventArgs) Handles IncButton.Click
        IncrementTemp()
    End Sub
    ''' <summary>
    ''' A sub used to increment the text box used to set the house temperature in 0.5 degree changes
    ''' </summary>
    Sub IncrementTemp()
        Dim currentTemp As Double = CSng(HouseTempTextBox.Text)
        Dim celtemp As Double
        If farenheit Then
            celtemp = 90
        Else
            celtemp = FtoC(90)
        End If
        If currentTemp < celtemp Then
            currentTemp += 0.5
            HouseTempTextBox.Text = CStr(Math.Round(currentTemp, 1))
        Else

        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' A sub for restoring system to normal after a system panic
    ''' </summary>
    Sub EndPanic()
        FiveTimer.Enabled = False
        ErrorLabel.Text = Nothing
        TwoTimer.Enabled = True
        Me.BackColor = GrowlGrey    ' restore background color
        My.Computer.Audio.Stop()    ' stop audio
    End Sub

    ''' <summary>
    ''' manual serial port connection feature
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ConnectToolStripButton.Click
        Dim force As Boolean = True
        OpenPort(force)
    End Sub

    ''' <summary>
    ''' On form closing the current temperature and serial connection are saved to a text file
    ''' text file is recreated each time to avoid calling prior settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub HVACGuiForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveStatus()
    End Sub

    Sub SaveStatus()
        Dim status As String
        status = $"TYPE$$:{Not CelsiusRadioButton.Checked}{vbNewLine}COM$$:{ComToolStripComboBox.Text}{vbNewLine}TEMP$$:{HouseTempTextBox.Text}"
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

    Private Sub TimeTimer_Tick(sender As Object, e As EventArgs) Handles TimeTimer.Tick
        TimeToolStripLabel.Text = DateTime.Now.ToString
        '  OutputOverride()
    End Sub

    ''' <summary>
    ''' allows user to manually enable a given HVAC output at the controller unit itself
    ''' </summary>
    Sub OutputOverride()
        Dim digByte() As Byte
        PollDigital()
        digByte = ReceiveData()

        If TestBit(digByte(0), 2) Then
            EnableHeater()
        ElseIf TestBit(digByte(0), 3) Then
            SetDigital(&H4)
        ElseIf TestBit(digByte(0), 4) Then
            EnableCooler()
        Else

        End If
    End Sub

    Private Sub CelsiusRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CelsiusRadioButton.CheckedChanged
        If CelsiusRadioButton.Checked Then
            farenheit = False
        Else
            farenheit = True
        End If
    End Sub
End Class
