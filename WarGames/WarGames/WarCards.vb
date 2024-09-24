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

    Sub CreateDecks()
        Shuffler.DrawCard(player1, player2)
        Console.Read()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DealButton.Click
        CreateDecks()
    End Sub
End Class
