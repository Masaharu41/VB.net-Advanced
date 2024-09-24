Public Class Shuffler
    'Sub NewGame(ByRef tracker(,) As Boolean)
    '    Console.Clear()
    '    ReDim tracker(12, 3)
    'End Sub

    Public Shared Sub DrawCard(ByRef player1(,) As Integer, ByRef player2(,) As Integer)
        Dim player1Deal As Boolean = True
        Dim dealer As Boolean
        Dim i%, e%
        ' loop until we get a ball that has not been drawn yet
        ' update tracker marking the ball
        Do
            If player1Deal = True Then
                player1(i, 0) = RandomNumberZero(12)
                player1(i, 1) = RandomNumberZero(3)
                player1Deal = False
                i += 1
            Else
                player2(e, 0) = RandomNumberZero(12)
                player2(e, 1) = RandomNumberZero(3)
                player1Deal = True
                e += 1
            End If
            If i = 26 And e = 26 Then
                dealer = True
            Else
                dealer = False
            End If
        Loop Until dealer = True


    End Sub

    Public Shared Function RandomNumberZero(max%) As Integer
        Dim _randomNumber As Integer
        Randomize()
        _randomNumber = CInt(Math.Floor(Rnd() * (max + 1)))
        Return _randomNumber
    End Function

    'Sub Display(tracker(,) As Boolean)

    '    Dim temp(12, 3) As Boolean

    '    temp = tracker
    '    Dim header() = {$"{Chr(3)}", $"{Chr(4)}", $"{Chr(5)}", $"{Chr(6)}"}
    '    Dim math As Integer
    '    Dim antiMath As Integer
    '    For Each letter In header
    '        Console.Write(letter.PadLeft(4))
    '    Next
    '    Console.WriteLine()

    '    For row = 0 To 12
    '        For column = 0 To 3
    '            If temp(row, column) Then
    '                math = (column * 13) + (row + 1)
    '                If math <= 13 Then
    '                    Select Case math
    '                        Case 11
    '                            Console.Write("J".PadLeft(4))
    '                        Case 12
    '                            Console.Write("Q".PadLeft(4))
    '                        Case 13
    '                            Console.Write("K".PadLeft(4))
    '                        Case Else
    '                            Console.Write($"{math}".PadLeft(4))
    '                    End Select
    '                ElseIf 13 > math < 27 Then
    '                    antiMath = math - (column * 13)
    '                    Select Case antiMath
    '                        Case 11
    '                            Console.Write("J".PadLeft(4))
    '                        Case 12
    '                            Console.Write("Q".PadLeft(4))
    '                        Case 13
    '                            Console.Write("K".PadLeft(4))
    '                        Case Else
    '                            Console.Write($"{antiMath}".PadLeft(4))
    '                    End Select
    '                ElseIf 27 > math < 40 Then
    '                    antiMath = math - (column * 13)
    '                    Select Case antiMath
    '                        Case 11
    '                            Console.Write("J".PadLeft(4))
    '                        Case 12
    '                            Console.Write("Q".PadLeft(4))
    '                        Case 13
    '                            Console.Write("K".PadLeft(4))
    '                        Case Else
    '                            Console.Write($"{antiMath}".PadLeft(4))
    '                    End Select
    '                ElseIf 40 > math < 52 Then
    '                    antiMath = math - (column * 13)
    '                    Select Case antiMath
    '                        Case 11
    '                            Console.Write("J".PadLeft(4))
    '                        Case 12
    '                            Console.Write("Q".PadLeft(4))
    '                        Case 13
    '                            Console.Write("K".PadLeft(4))
    '                        Case Else
    '                            Console.Write($"{antiMath}".PadLeft(4))
    '                    End Select
    '                End If
    '            Else
    '                Console.Write("X".PadLeft(4))
    '            End If
    '        Next
    '        Console.WriteLine()
    '    Next
    'End Sub
End Class
