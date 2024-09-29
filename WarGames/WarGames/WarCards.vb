Option Strict On
Option Explicit On
'Owen Fujii
'War Card Game
'TODO
'{*} Create a random deck for each player using standard 52 card deck 50/50
'{} Display Cards Graphically
'{*} Track Results of each card turn
'

Imports WarGames.My.Resources

Public Class WarCards
    Dim player1(26, 1) As Integer
    Dim player2(26, 1) As Integer
    Dim player1Wins(52) As Integer
    Dim player2Wins(52) As Integer

    Private Sub Deal_Button_Click(sender As Object, e As EventArgs) Handles DealButton.Click
        Shuffler.DrawCard(player1, player2) ' distribute cards to each player
    End Sub

    ''' <summary>
    ''' Compares the two cards from each player's array based on the play count
    ''' There is a single catch for equal instances.
    ''' </summary>
    ''' <returns></returns>
    Function PlayGame() As Integer

        Static Dim playCount%, twoWin%, oneWin%, dummmyCount%
        Dim player1Card%, player2Card%
        Dim tie As Boolean = False

        If playCount <= 26 Then
            player1Card = player1(playCount, 0)
            player2Card = player2(playCount, 0)
        Else
            ReDim Preserve player2Wins(twoWin - 1)
            ReDim Preserve player1Wins(oneWin - 1)
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
            playCount += 1
        End If

        Return playCount
    End Function

    Sub DisplayCards()
        Dim playCount% = PlayGame()
        'Dim imageOne As String
        Player1PictureBox.Refresh()
        Player2PictureBox.Refresh()

        Player1PictureBox.Image = Image.FromFile($"..\..\Card Images\{DisplayPlayer1(playCount)}.png")
        Player2PictureBox.Image = Image.FromFile($"..\..\Card Images\{DisplayPlayer2(playCount)}.png")


    End Sub

    Private Sub Play_Button_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        DisplayCards()
    End Sub

    Function DisplayPlayer1(index%) As String
        Dim card As String
        Dim suit As String
        Select Case player1(index, 0)
            Case 0
                card = "Ace"
            Case 1
                card = "Two"
            Case 3
                card = "Three"
            Case 4
                card = "Four"
            Case 5
                card = "Five"
            Case 6
                card = "Six"
            Case 7
                card = "Seven"
            Case 8
                card = "Eight"
            Case 9
                card = "Nine"
            Case 10
                card = "Ten"
            Case 11
                card = "Joker"
            Case 12
                card = "Queen"
            Case 13
                card = "King"
        End Select

        Select Case player1(index, 1)
            Case 0
                suit = "Hearts"
            Case 1
                suit = "Clubs"
            Case 2
                suit = "Diamonds"
            Case 3
                suit = "Spades"
        End Select
        Return $"{card} {suit}"
    End Function

    Function DisplayPlayer2(index%) As String
        Dim card As String
        Dim suit As String
        Select Case player2(index, 0)
            Case 0
                card = "Ace"
            Case 1
                card = "Two"
            Case 3
                card = "Three"
            Case 4
                card = "Four"
            Case 5
                card = "Five"
            Case 6
                card = "Six"
            Case 7
                card = "Seven"
            Case 8
                card = "Eight"
            Case 9
                card = "Nine"
            Case 10
                card = "Ten"
            Case 11
                card = "Joker"
            Case 12
                card = "Queen"
            Case 13
                card = "King"
        End Select

        Select Case player2(index, 1)
            Case 0
                suit = "Hearts"
            Case 1
                suit = "Clubs"
            Case 2
                suit = "Diamonds"
            Case 3
                suit = "Spades"
        End Select
        Return $"{card} {suit}"
    End Function

End Class
