Option Strict On
Option Explicit On
'Owen Fujii
'War Card Game
'TODO
'{*} Create a random deck for each player using standard 52 card deck 50/50
'{*} Display Cards Graphically
'{*} Track Results of each card turn
'{} Determine winner
'{} Display Winner 

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

        If player1Card > player2Card Then
            OutcomeLabel.Text = "Player2 Wins This Round"
            player2Wins(twoWin) = player2Card
            twoWin += twoWin
            player2Wins(twoWin) = player1Card
            twoWin += twoWin
        ElseIf player1Card = player2Card Then
            OutcomeLabel.Text = "There Has been a Tie"
            playCount += 3
            tie = True
            player1Card = player1(playCount, 0)
            player2Card = player2(playCount, 0)
            If player1Card > player2Card Then
                OutcomeLabel.Text = "Player 2 Wins the Draw"
                Do
                    dummmyCount = playCount - 3
                    player2Wins(twoWin) = player1(dummmyCount, 0)
                    twoWin += twoWin
                    player2Wins(twoWin) = player2(dummmyCount, 0)
                    twoWin += twoWin
                    dummmyCount += dummmyCount
                Loop Until playCount = dummmyCount
            ElseIf player2Card > player1Card Then
                OutcomeLabel.Text = "Player 1 Wins the Draw"
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
            OutcomeLabel.Text = "Player 1 Wins This Round"
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
        Player1PictureBox.Refresh()
        Player2PictureBox.Refresh()

        Player1PictureBox.Image = Image.FromFile($"..\..\Card Images\{CardSuit(player1(playCount, 0), player1(playCount, 1))}.png")
        Player2PictureBox.Image = Image.FromFile($"..\..\Card Images\{CardSuit(player2(playCount, 0), player2(playCount, 1))}.png")


    End Sub

    Private Sub Play_Button_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        DisplayCards()
    End Sub
    ''' <summary>
    ''' A function to decode the integers into a string for the file name of the corresponding card
    ''' </summary>
    ''' <param name="indexCard%"></param>
    ''' <param name="suitIndex%"></param>
    ''' <returns></returns>
    ''' returns a string that is the string of the file that will be selected. 
    Function CardSuit(indexCard%, suitIndex%) As String

        Dim card As String
        Dim suit As String
        Select Case indexCard
            Case 0
                card = "Ace"
            Case 1
                card = "Two"
            Case 2
                card = "Three"
            Case 3
                card = "Four"
            Case 4
                card = "Five"
            Case 5
                card = "Six"
            Case 6
                card = "Seven"
            Case 7
                card = "Eight"
            Case 8
                card = "Nine"
            Case 9
                card = "Ten"
            Case 10
                card = "Joker"
            Case 11
                card = "Queen"
            Case 12
                card = "King"
        End Select

        Select Case suitIndex
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
