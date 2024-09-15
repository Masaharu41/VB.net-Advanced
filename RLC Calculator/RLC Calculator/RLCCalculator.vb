'Owen Fujii
'RLC Calculator


Option Explicit On
Option Strict On


Public Class RLCCalculator

    Function C2Calculator() As Double
        Dim C2 As Double
        Dim pi As Double = Math.PI

        C2 = 1 / (2 * (pi) * CInt(FreqTextBox.Text) * CInt(C2TextBox.Text))
        Return C2

    End Function
    Function C1Calculator() As Double
        Dim C1 As Double
        Dim pi As Double = Math.PI

        C1 = 1 / (2 * pi * CInt(FreqTextBox.Text) * CInt(C1TextBox.Text))
        Return C1

    End Function

    Function L1Calcator() As Double
        Dim L1 As Double
        Dim pi As Double = Math.PI

        L1 = (2 * pi * CInt(FreqTextBox.Text) * CInt(L1TextBox.Text))
        Return L1
    End Function

    Function Branch1() As Double()
        Dim sendArray(1) As Double
        Dim l1Value As Double = L1Calcator()

        sendArray(0) = Math.Sqrt((l1Value ^ 2) + (CDbl(SeriesRTextBox.Text) ^ 2))
        sendArray(1) = Math.Atan(l1Value / CDbl(SeriesRTextBox.Text))

        Return sendArray
    End Function

    Function Branch2() As Double()
        Dim sendArray(1) As Double
        Dim c2Value As Double = C2Calculator()

        sendArray(0) = Math.Sqrt((c2Value ^ 2) + (CDbl(R2TextBox.Text) ^ 2))
        sendArray(1) = Math.Atan(c2Value / CDbl(R2TextBox.Text))

        Return sendArray
    End Function

    Function ParallelArray() As Array
        Dim sendArray(10) As Double
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



        Return sendArray
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

    End Sub
End Class
