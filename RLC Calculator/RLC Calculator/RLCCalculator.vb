'Owen Fujii
'RLC Calculator


Option Explicit On
Option Strict On


Public Class RLCCalculator

    Public massArray(38) As Double

    Function C2Calculator() As Double
        Dim C2 As Double = CDbl(C2TextBox.Text) ' = C2Unit()           ' Calculate the reactance of c2

        Dim pi As Double = Math.PI

        C2 = 1 / (2 * (pi) * CDbl(FreqTextBox.Text) * C2)
        massArray(3) = C2 ' store impedance c2
        Return C2
    End Function
    Function C1Calculator() As Double
        Dim C1 As Double           ' Calculate the reactance of C1
        Dim pi As Double = Math.PI

        C1 = 1 / (2 * pi * CDbl(FreqTextBox.Text) * CDbl(C1TextBox.Text))
        massArray(0) = C1 ' store impedance c1
        Return C1

    End Function

    Function L1Calcator() As Double
        Dim L1 As Double            ' Calculate the reactance of L1
        Dim pi As Double = Math.PI

        L1 = (2 * pi * CDbl(FreqTextBox.Text) * CDbl(L1TextBox.Text))
        massArray(6) = L1 ' store impedance l1
        Return L1
    End Function

    Function Branch1() As Double()
        Dim sendArray(1) As Double   ' Solve the impedance of the inductor branch and return as an array
        Dim l1Value As Double = L1Calcator()
        Dim pi As Double = Math.PI

        sendArray(0) = Math.Sqrt((l1Value ^ 2) + (CDbl(SeriesRTextBox.Text) ^ 2))
        sendArray(1) = (Math.Atan((l1Value / CDbl(SeriesRTextBox.Text))) * 180 / pi)
        massArray(9) = sendArray(0) ' store branch reatance as polar 
        massArray(10) = sendArray(1) ' store branch angle
        Return sendArray
    End Function

    Function Branch2() As Double()
        Dim sendArray(1) As Double   ' Solve the impedance of the capacitor branch and return as an array
        Dim c2Value As Double = C2Calculator()
        Dim pi As Double = Math.PI

        sendArray(0) = Math.Sqrt((c2Value ^ 2) + (CDbl(R2TextBox.Text) ^ 2))
        sendArray(1) = (Math.Atan(-c2Value / CDbl(R2TextBox.Text)) * 180 / pi)
        massArray(13) = sendArray(0)  ' store branch 2 reactance as polar
        massArray(14) = sendArray(1) ' store branch2 angle
        Return sendArray
    End Function

    Function ParallelArray() As Double()
        Dim sendArray(3) As Double                ' calculate both branches total impedance and return array with polar and rect.
        Dim branchTwo() As Double = Branch2()
        Dim branchOne() As Double = Branch1()
        Dim multtemp As Double
        Dim rectAngle As Double
        Dim demoniatorRect As Double
        Dim demoniatorAngle As Double
        Dim temp(1) As Double
        Dim branchOneAngle As Double = branchOne(1)
        Dim branchTwoAngle As Double = branchTwo(1)
        Dim pi As Double = Math.PI

        multtemp = branchOne(0) * branchTwo(0)

        rectAngle = branchOneAngle + branchTwoAngle

        demoniatorRect = CDbl(R2TextBox.Text) + CDbl(SeriesRTextBox.Text)
        demoniatorAngle = massArray(6) - massArray(3)

        temp(0) = Math.Sqrt((demoniatorAngle ^ 2) + (demoniatorRect ^ 2))
        temp(1) = (Math.Atan(demoniatorAngle / demoniatorRect) * 180 / pi)

        sendArray(0) = multtemp / temp(0)
        sendArray(1) = rectAngle - temp(1)
        sendArray(2) = sendArray(0) * (Math.Cos(sendArray(1) * pi / 180))
        sendArray(3) = sendArray(0) * (Math.Sin(sendArray(1) * pi / 180))
        massArray(17) = sendArray(0)  ' store polar
        massArray(18) = sendArray(1)    ' store polar angle
        massArray(19) = sendArray(2)    ' store real
        massArray(20) = sendArray(3)    ' store imaginary


        Return sendArray
    End Function

    Function TotalReactaces() As Double()
        Dim sendArray(3) As Double           ' solve for total reactance and return an array with both polar and rect.
        Dim parallel() As Double = ParallelArray()
        Dim seriesCap As Double = C1Calculator()
        Dim seriesRes As Double = CDbl(R1TextBox.Text)
        Dim pi As Double = Math.PI

        sendArray(2) = seriesRes + parallel(2)
        sendArray(3) = -seriesCap + parallel(3)
        sendArray(0) = Math.Sqrt((sendArray(2) ^ 2) + (sendArray(3) ^ 2))
        sendArray(1) = (Math.Atan(sendArray(3) / sendArray(2)) * 180 / pi)
        massArray(22) = sendArray(0)  ' store polar
        massArray(23) = sendArray(1)    ' store angle
        massArray(24) = sendArray(2)    ' store real
        massArray(25) = sendArray(3)    ' store imaginary


        Return sendArray

    End Function

    Sub TotalCurrents()
        Dim reactance() As Double = TotalReactaces()   ' solve for series current
        Dim voltageGen As Double = CDbl(VoltTextBox.Text)
        Dim sender As Double

        sender = voltageGen / reactance(0)
        massArray(26) = sender
        massArray(27) = 0 - massArray(23)

    End Sub

    Sub BigCalculator()
        ' final sub that finishes voltage and current calcs
        TotalCurrents()
        Dim c1React As Double = massArray(0)
        Dim c2React As Double = massArray(3)
        Dim l1React As Double = massArray(6)
        Dim r1 As Double = CDbl(R1TextBox.Text)
        Dim r2 As Double = CDbl(R2TextBox.Text)
        Dim rSeries As Double = CDbl(SeriesRTextBox.Text)

        massArray(1) = massArray(26) * massArray(0) ' store c1 voltage
        massArray(28) = massArray(27) - 90 ' store c1 angle
        massArray(2) = massArray(26) * r1 ' store r1 voltage
        massArray(4) = massArray(26) * massArray(17) ' store parallel voltage 
        massArray(29) = massArray(27) + massArray(18) 'store parallel angle
        massArray(11) = massArray(4) / massArray(9) ' store branch 1 current
        massArray(30) = massArray(29) - massArray(10) ' store branch 1 angle
        massArray(15) = massArray(4) / massArray(13) 'store branch 2 current
        massArray(32) = massArray(29) - massArray(14) ' store branch 2 angle
        massArray(7) = massArray(11) * massArray(6) ' store l1 voltage
        massArray(31) = massArray(30) + 90 ' store l1 angle
        massArray(8) = massArray(11) * rSeries
        massArray(5) = massArray(15) * massArray(3) ' store c2 voltage
        massArray(33) = massArray(32) - 90
        massArray(12) = massArray(15) * r2 ' store r2 voltage



    End Sub

    Sub DisplayCalcs()
        BigCalculator()
        ' clear list box before writing new data
        RLCListBox.Items.Clear()
        RLCListBox.Items.Add($"Generator Voltage = {VoltTextBox.Text}")
        RLCListBox.Items.Add($"Frequency = {FreqTextBox.Text}")
        RLCListBox.Items.Add($"Total Current = {massArray(26)} at {massArray(27)} degrees")
        RLCListBox.Items.Add($"Total Impedance = {massArray(22)} at {massArray(27)}")
        RLCListBox.Items.Add($"C1 Reactance = {massArray(0)} at -90 Degrees")
        RLCListBox.Items.Add($"C1 Voltage = {massArray(1)} at {massArray(28) } degress")
        RLCListBox.Items.Add($"R1 Value = {R1TextBox.Text}")
        RLCListBox.Items.Add($"R1 Voltage = {massArray(2)} at {massArray(27) }")
        RLCListBox.Items.Add($"Parallel Impedance = {massArray(17)} at {massArray(18)} degrees")
        RLCListBox.Items.Add($"Parallel Voltage = {massArray(4)} at {massArray(29)} degrees")
        RLCListBox.Items.Add($"Branch 1 Impedance = {massArray(9)} as {massArray(10)} degrees")
        RLCListBox.Items.Add($"Branch 1 Current = {massArray(11)} at {massArray(30) } degrees")
        RLCListBox.Items.Add($"L1 Reactance = {massArray(6)}")
        RLCListBox.Items.Add($"L1 Voltage = {massArray(7)} at {massArray(31) } degrees")
        RLCListBox.Items.Add($"Rseries = {SeriesRTextBox.Text}")
        RLCListBox.Items.Add($"Rseries Voltage = {massArray(8)} at {massArray(30) } degrees")
        RLCListBox.Items.Add($"Branch 2 Impedance = {massArray(13)} as {massArray(14)} degrees")
        RLCListBox.Items.Add($"Branch 2 Current = {massArray(15)} at {massArray(32) } degrees")
        RLCListBox.Items.Add($"C2 Reactance = {massArray(3)}")
        RLCListBox.Items.Add($"C2 Voltage = {massArray(5)} at {massArray(33) } degrees")
        RLCListBox.Items.Add($"R2 Resitance = {R2TextBox.Text}")
        RLCListBox.Items.Add($"R2 Voltage = {massArray(12)} at {massArray(32) } degrees")

    End Sub
    ' still need todo
    ' {*} add full polar calculations // missing angles
    ' {*} add output file
    Sub StoreCalcs()

        Try
            FileOpen(1, "..\..\RLC_Data.txt", OpenMode.Append)

        Catch ex As Exception
            FileOpen(2, "..\..\Errorlog.txt", OpenMode.Append)
            Write(2, CStr($"Error: {Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try
        Print(1, vbNewLine + $"Calculated on {TimeOfDay}" + vbNewLine)
        For i = 0 To 18
            RLCListBox.SelectedIndex() = i
            Print(1, CStr(RLCListBox.SelectedItem) + vbNewLine)
        Next
        Print(1, "PlaceHolder" + vbNewLine)
        FileClose(1)
    End Sub
    ''' <summary>
    ''' Sub that checks that all inputs are valid for numeric operations
    ''' </summary>
    ''' <returns></returns> returns a true value is errors are found and math will not execute
    Function ValidData() As Boolean
        Dim errorBool As Boolean = False
        Dim errorMsg As String = "The Following Errors Have Occured"
        Dim volt As Double
        Dim freq As Double
        Dim cOne As Double, rOne As Double
        Dim lOne As Double, rSeries As Double
        Dim ctwo As Double, rTwo As Double

        Try
            volt = CDbl(VoltTextBox.Text)

        Catch ex As Exception
            errorBool = True
            errorMsg = errorMsg + vbNewLine + "Volt is not valid"
        End Try


        Try
            freq = CDbl(FreqTextBox.Text)

        Catch ex As Exception
            errorBool = True
            errorMsg = errorMsg + vbNewLine + "Frequency is not valid"
        End Try

        Try
            cOne = CDbl(C1TextBox.Text)

        Catch ex As Exception
            errorBool = True
            errorMsg = errorMsg + vbNewLine + "C1 is not valid"
        End Try

        Try
            rOne = CDbl(R1TextBox.Text)

        Catch ex As Exception
            errorBool = True
            errorMsg = errorMsg + vbNewLine + "R1 is not valid"
        End Try

        Try
            lOne = CDbl(L1TextBox.Text)

        Catch ex As Exception
            errorBool = True
            errorMsg = errorMsg + vbNewLine + "L1 is not valid"
        End Try

        Try
            rSeries = CDbl(SeriesRTextBox.Text)

        Catch ex As Exception
            errorBool = True
            errorMsg = errorMsg + vbNewLine + "Winding Resitance is not valid"
        End Try

        Try
            ctwo = CDbl(C2TextBox.Text)

        Catch ex As Exception
            errorBool = True
            errorMsg = errorMsg + vbNewLine + "C2 is not valid"
        End Try

        Try
            rTwo = CDbl(R2TextBox.Text)

        Catch ex As Exception
            errorBool = True
            errorMsg = errorMsg + vbNewLine + "R2 is not valid"
        End Try
        If errorBool = True Then
            MsgBox(errorMsg)
        End If

        Return errorBool
    End Function
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If ValidData() = False Then
            DisplayCalcs()
            StoreCalcs()
        Else

        End If
        MsgBox(EngineeringMath.EngineeringConverter(111111))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class
