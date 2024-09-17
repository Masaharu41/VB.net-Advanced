'Owen Fujii
'RLC Calculator


Option Explicit On
Option Strict On


Public Class RLCCalculator

    Function C2Calculator() As Double
        Dim C2 As Double               ' Calculate the reactance of c2
        Dim pi As Double = Math.PI



        C2 = 1 / (2 * (pi) * CInt(FreqTextBox.Text) * CInt(C2TextBox.Text))

        Return C2
    End Function
    Function C1Calculator() As Double
        Dim C1 As Double           ' Calculate the reactance of C1
        Dim pi As Double = Math.PI

        C1 = 1 / (2 * pi * CInt(FreqTextBox.Text) * CInt(C1TextBox.Text))
        Return C1

    End Function

    Function L1Calcator() As Double
        Dim L1 As Double            ' Calculate the reactance of L1
        Dim pi As Double = Math.PI

        L1 = (2 * pi * CInt(FreqTextBox.Text) * CInt(L1TextBox.Text))
        Return L1
    End Function

    Function Branch1() As Double()
        Dim sendArray(1) As Double   ' Solve the impedance of the inductor branch and return as an array
        Dim l1Value As Double = L1Calcator()

        sendArray(0) = Math.Sqrt((l1Value ^ 2) + (CDbl(SeriesRTextBox.Text) ^ 2))
        sendArray(1) = Math.Atan(l1Value / CDbl(SeriesRTextBox.Text))

        Return sendArray
    End Function

    Function Branch2() As Double()
        Dim sendArray(1) As Double   ' Solve the impedance of the capacitor branch and return as an array
        Dim c2Value As Double = C2Calculator()

        sendArray(0) = Math.Sqrt((c2Value ^ 2) + (CDbl(R2TextBox.Text) ^ 2))
        sendArray(1) = Math.Atan(c2Value / CDbl(R2TextBox.Text))

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

        multtemp = branchOne(0) * branchTwo(0)

        rectAngle = branchOneAngle * branchTwoAngle

        demoniatorRect = CDbl(R2TextBox.Text) + CDbl(SeriesRTextBox.Text)
        demoniatorAngle = CDbl(L1TextBox.Text) + CDbl(C2TextBox.Text)

        temp(0) = Math.Sqrt((demoniatorAngle ^ 2) + (demoniatorRect ^ 2))
        temp(1) = Math.Atan(demoniatorRect / demoniatorAngle)

        sendArray(0) = demoniatorRect / temp(0)
        sendArray(1) = demoniatorAngle - temp(1)
        sendArray(2) = sendArray(0) * Math.Cos(sendArray(1))
        sendArray(3) = sendArray(0) * Math.Sin(sendArray(1))

        Return sendArray
    End Function

    Function TotalReactace() As Double()
        Dim sendArray(3) As Double           ' solve for total reactance and return an array with both polar and rect.
        Dim parallel() As Double = ParallelArray()
        Dim seriesCap As Double = C1Calculator()
        Dim seriesRes As Double = CDbl(R1TextBox.Text)

        sendArray(2) = seriesRes + parallel(2)
        sendArray(3) = -seriesCap + parallel(3)
        sendArray(0) = Math.Sqrt((sendArray(2) ^ 2) + (sendArray(3) ^ 2))
        sendArray(1) = Math.Atan(sendArray(3) / sendArray(2))

        Return sendArray

    End Function

    Function TotalCurrents() As Double
        Dim reactance() As Double = TotalReactace()   ' solve for series current
        Dim voltageGen As Double = CDbl(VoltTextBox.Text)




    End Function

    Function ValidData() As Boolean

    End Function
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

    End Sub
End Class
