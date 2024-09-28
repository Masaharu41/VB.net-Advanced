Public Class Shuffler

    ''' <summary>
    ''' Generates two decks of cards into arrays. array 1 is for player one
    ''' arrays are two column as each card has a number and suit associated with it
    ''' </summary>
    ''' <param name="player1"></param>
    ''' <param name="player2"></param>
    Public Shared Sub DrawCard(ByRef player1(,) As Integer, ByRef player2(,) As Integer)
        Dim player1Deal As Boolean = True
        Dim dealer As Boolean
        Dim i%, e%
        ' loop until we get a ball that has not been drawn yet

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
    ''' <summary>
    ''' generates a random number
    ''' </summary>
    ''' <param name="max%"></param>
    ''' <returns></returns> 
    ''' returns a random integer within the bounds set by max
    Public Shared Function RandomNumberZero(max%) As Integer
        Dim _randomNumber As Integer
        Randomize()
        _randomNumber = CInt(Math.Floor(Rnd() * (max + 1)))
        Return _randomNumber
    End Function



End Class
