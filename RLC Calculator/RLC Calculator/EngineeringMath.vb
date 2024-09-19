Public Class EngineeringMath


    Public Shared Function EngineeringConverter(SumValue As Double) As String
        Dim engNum As Double
        Dim notation As String
        Dim vale = EngForce(SumValue)
        notation = MetricPrefix(vale.exp)
        engNum = Math.Round(vale.enumber)
        Return $"{engNum}{notation}"
    End Function

    Public Shared Function EngForce(val As Double) As (enumber As Decimal, exp As Integer)
        Dim enumber As Decimal
        Dim exp As Integer

        If val <> 0 Then
            Dim expNumber() = Split(val.ToString("E"), "E")
            enumber = expNumber(0)
            exp = CInt(expNumber(1))

            If expNumber(1) > 0 Then
                Do Until exp = 0 Or exp = 3 Or exp = 6 Or exp = 9 Or exp = 12
                    exp += 1
                    enumber = enumber * 10
                Loop

            Else
                Do Until exp = 0 Or exp = -3 Or exp = -6 Or exp = -9 Or exp = -12
                    exp -= 1
                    enumber = enumber * 10
                Loop
            End If

            Return (enumber, exp)
        Else
            Return (0, 0)

        End If



    End Function

    Public Shared Function MetricPrefix(exponent%) As String
        Dim prefix$
        Select Case exponent
            Case 12
                prefix = "T"
            Case 9
                prefix = "G"
            Case 6
                prefix = "M"
            Case 3
                prefix = "k"
            Case 0
                prefix = ""
            Case -3
                prefix = "m"
            Case -6
                prefix = "u"
            Case -9
                prefix = "n"
            Case -12
                prefix = "p"
            Case Else
                prefix = ""
        End Select


        Return $"{prefix}{exponent}"

    End Function


End Class
