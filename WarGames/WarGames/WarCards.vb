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
        Static Dim playCount%, twoWin%, oneWin%
        Dim player1Card%, player2Card%

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
        ElseIf player1Card = player2Card Then

        Else
            player1Wins(playCount) = player2Card
            oneWin += oneWin
        End If

        playCount += playCount
        Return playCount
    End Function


End Class
