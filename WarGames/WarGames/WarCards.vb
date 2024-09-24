'Owen Fujii
'War Card Game
'TODO
'{} Create a random deck for each player using standard 52 card deck 50/50
'{} Display Cards Graphically
'{} Track Results of each card turn
'

Option Strict On
Option Explicit On

Public Class WarCards
    Dim player1(26, 1) As Integer
    Dim player2(26, 1) As Integer
    Dim player1Wins() As Integer
    Dim player2Wins() As Integer

    Sub CreateDecks()
        Shuffler.DrawCard(player1, player2)
        Console.Read()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DealButton.Click
        CreateDecks()
    End Sub

    Function PlayGame() As Integer
        Static Dim playCount%, twoWin%, oneWin%, dummmyCount%
        Dim player1Card%, player2Card%
        Dim tie As Boolean = False

        If playCount <= 26 Then
            player1Card = player1(playCount, 0)
            player2Card = player2(playCount, 0)
        Else
            playCount = 0
            twoWin = 0
            oneWin = 0
            Return -1
        End If

        If player1Card < player2Card Then
            player2Wins(twoWin) = player2Card
            twoWin += twoWin
            player2Wins(twoWin) = player1Card
            twoWin += twoWin
        ElseIf player1Card = player2Card Then
            playCount += 3
            tie = True
            player1Card = player1(playCount, 0)
            player2Card = player2(playCount, 0)
            If player1Card < player2Card Then
                Do
                    dummmyCount = playCount - 3
                    player2Wins(twoWin) = player1(dummmyCount, 0)
                    twoWin += twoWin
                    player2Wins(twoWin) = player2(dummmyCount, 0)
                    twoWin += twoWin
                    dummmyCount += dummmyCount
                Loop Until playCount = dummmyCount
            ElseIf player2Card < player1Card Then
                Do
                    dummmyCount = playCount - 3
                    player1Wins(oneWin) = player1(dummmyCount, 0)
                    oneWin += oneWin
                    player1Wins(twoWin) = player2(dummmyCount, 0)
                    oneWin += oneWin
                    dummmyCount += dummmyCount
                Loop Until playCount = dummmyCount
            Else
                MsgBox("listen here Luck is not on your side")
            End If
        Else
            player1Wins(oneWin) = player2Card
            oneWin += oneWin
            player2Wins(oneWin) = player1Card
            oneWin += oneWin
        End If
        If tie = True Then

        Else
            playCount += playCount
        End If

        Return playCount
    End Function


End Class
