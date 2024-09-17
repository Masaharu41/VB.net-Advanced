'Owen Fujii
'RLC Calculator


Option Explicit On
Option Strict On


Public Class RLCCalculator

    Public massArray(30) As Double

    Function C2Calculator() As Double
        Dim C2 As Double               ' Calculate the reactance of c2
        Dim pi As Double = Math.PI
        C2 = 1 / (2 * (pi) * CInt(FreqTextBox.Text) * CInt(C2TextBox.Text))
        massArray(3) = C2 ' store impedance c2
        Return C2
    End Function
    Function C1Calculator() As Double
        Dim C1 As Double           ' Calculate the reactance of C1
        Dim pi As Double = Math.PI

        C1 = 1 / (2 * pi * CInt(FreqTextBox.Text) * CInt(C1TextBox.Text))
        massArray(0) = C1 ' store impedance c1
        Return C1

    End Function

    Function L1Calcator() As Double
        Dim L1 As Double            ' Calculate the reactance of L1
        Dim pi As Double = Math.PI

        L1 = (2 * pi * CInt(FreqTextBox.Text) * CInt(L1TextBox.Text))
        massArray(6) = L1 ' store impedance l1
        Return L1
    End Function

    Function Branch1() As Double()
        Dim sendArray(1) As Double   ' Solve the impedance of the inductor branch and return as an array
        Dim l1Value As Double = L1Calcator()

        sendArray(0) = Math.Sqrt((l1Value ^ 2) + (CDbl(SeriesRTextBox.Text) ^ 2))
        sendArray(1) = Math.Atan(l1Value / CDbl(SeriesRTextBox.Text))
        massArray(9) = sendArray(0) ' store branch reatance as polar 
        massArray(10) = sendArray(1) ' store branch angle
        Return sendArray
    End Function

    Function Branch2() As Double()
        Dim sendArray(1) As Double   ' Solve the impedance of the capacitor branch and return as an array
        Dim c2Value As Double = C2Calculator()

        sendArray(0) = Math.Sqrt((c2Value ^ 2) + (CDbl(R2TextBox.Text) ^ 2))
        sendArray(1) = Math.Atan(-c2Value / CDbl(R2TextBox.Text))
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

        multtemp = branchOne(0) * branchTwo(0)

        rectAngle = branchOneAngle + branchTwoAngle

        demoniatorRect = CDbl(R2TextBox.Text) + CDbl(SeriesRTextBox.Text)
        demoniatorAngle = CDbl(L1TextBox.Text) + CDbl(C2TextBox.Text)

        temp(0) = Math.Sqrt((demoniatorAngle ^ 2) + (demoniatorRect ^ 2))
        temp(1) = Math.Atan(demoniatorRect / demoniatorAngle)

        sendArray(0) = multtemp / temp(0)
        sendArray(1) = rectAngle - temp(1)
        sendArray(2) = sendArray(0) * Math.Cos(sendArray(1))
        sendArray(3) = sendArray(0) * Math.Sin(sendArray(1))
        massArray(17) = sendArray(0)  ' store parallel real
        massArray(18) = sendArray(1)    ' store parallel imaginary
        massArray(19) = sendArray(2)    ' store parallel polar
        massArray(20) = sendArray(3)    ' store polar angle


        Return sendArray
    End Function

    Function TotalReactaces() As Double()
        Dim sendArray(3) As Double           ' solve for total reactance and return an array with both polar and rect.
        Dim parallel() As Double = ParallelArray()
        Dim seriesCap As Double = C1Calculator()
        Dim seriesRes As Double = CDbl(R1TextBox.Text)

        sendArray(2) = seriesRes + parallel(2)
        sendArray(3) = -seriesCap + parallel(3)
        sendArray(0) = Math.Sqrt((sendArray(2) ^ 2) + (sendArray(3) ^ 2))
        sendArray(1) = Math.Atan(sendArray(3) / sendArray(2))
        massArray(22) = sendArray(0)
        massArray(23) = sendArray(1)
        massArray(24) = sendArray(2)
        massArray(25) = sendArray(3)


        Return sendArray

    End Function

    Sub TotalCurrents()
        Dim reactance() As Double = TotalReactaces()   ' solve for series current
        Dim voltageGen As Double = CDbl(VoltTextBox.Text)
        Dim sender As Double

        sender = voltageGen / reactance(0)
        massArray(26) = sender

    End Sub

    Sub BigCalculator()
        ' final sub that finishes voltage and current calcs
        Dim c1React As Double = massArray(0)
        Dim c2React As Double = massArray(3)
        Dim l1React As Double = massArray(6)
        Dim r1 As Double = CDbl(R1TextBox.Text)
        Dim r2 As Double = CDbl(R2TextBox.Text)
        Dim rSeries As Double = CDbl(SeriesRTextBox.Text)

        massArray(1) = massArray(26) * massArray(0) ' store c1 voltage
        massArray(2) = massArray(26) * r1 ' store r1 voltage
        massArray(4) = massArray(26) * massArray(19) ' store parallel voltage
        massArray(11) = massArray(4) / massArray(9) ' store branch 1 current
        massArray(15) = massArray(4) / massArray(13) 'store branch 2 current
        massArray(7) = massArray(11) * massArray(6) ' store l1 voltage
        massArray(8) = massArray(11) * rSeries
        massArray(5) = massArray(15) * massArray(3) ' store c2 voltage
        massArray(12) = massArray(15) * r2 ' store r2 voltage



    End Sub

    Sub DisplayCalcs()
        BigCalculator()


    End Sub

    Sub StoreCalcs()

    End Sub
    'Function ValidData() As Boolean

    'End Function
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

    End Sub


End Class
