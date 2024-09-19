Public Class EngineeringMath


    'Public Function EngineeringConverter(SumValue As Double) As String

    'End Function

    Public Shared Function EngForce(val As Double) As (enumber As Decimal, exp As String)
        Dim enumber As Decimal
        Dim exp As String

        If val <> 0 Then
            Dim expNumber() = Split(val.ToString("E"), "E")
            enumber = expNumber(0)
            exp = expNumber(1)

            If expNumber(1) < 0 Then
                Do Until enumber = 3 <> 0

                Loop


            Else

            End If




            Return (enumber, exp)
        Else
            Return (0, 0)

        End If



    End Function

End Class
