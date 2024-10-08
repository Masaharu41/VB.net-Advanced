﻿'Owen Fujii
'War Card Game
'RCET 3371
'TODO
'{*} Create a random deck for each player using standard 52 card deck 50/50
'{*} Display Cards Graphically
'{*} Track Results of each card turn
'{*} Determine winner
'{*} Display Winner 
'{*} Check for duplicate cards
'{*} Add hotkeys

Option Strict On
Option Explicit On
Imports System.ComponentModel
Imports WarGames.My.Resources

Public Class WarCards
    ' Dim the arrays that will be used for the storing decks
    ' and storing players win records
    Dim player1(25, 1) As Integer
    Dim player2(25, 1) As Integer
    Dim player1Wins(52) As Integer
    Dim player2Wins(52) As Integer
    Dim totalWinsOne%, totalWinsTwo%, totalPlays%

    Private Sub Deal_Button_Click(sender As Object, e As EventArgs) Handles DealButton.Click
        Shuffler.DrawCard(player1, player2) ' distribute cards to each player
        PlayButton.Enabled = True
        DealButton.Enabled = False

    End Sub

    ''' <summary>
    ''' Compares the two cards from each player's array based on the play count
    ''' There is a single catch for equal instances.
    ''' can operate independent of display but does handle some display responsibilities
    ''' </summary>
    ''' <returns></returns>
    ''' Returns the incremented playcount
    Function PlayGame() As Integer

        Static Dim playCount%, twoWin%, oneWin%, dummmyCount%
        Dim player1Card%, player2Card%
        Dim tie As Boolean = False

        If playCount <= 25 Then
            player1Card = player1(playCount, 0)
            player2Card = player2(playCount, 0)
        Else
            ReDim Preserve player2Wins(twoWin - 1)
            ReDim Preserve player1Wins(oneWin - 1)
            ReDim player1(25, 1)
            ReDim player2(25, 1)
            PlayButton.Enabled = False
            DealButton.Enabled = True

            playCount = 0
            twoWin = 0
            oneWin = 0
            Return -1
        End If

        If player1Card < player2Card Then
            OutcomeLabel.Text = "Player 2 Wins This Round"
            player2Wins(twoWin) = player2Card
            twoWin += 1
            player2Wins(twoWin) = player1Card
            twoWin += 1
        ElseIf player1Card = player2Card Then
            OutcomeLabel.Text = "There Has been a Tie"
            playCount += 3
            If playCount <= 25 Then
                tie = True
                player1Card = player1(playCount, 0)
                player2Card = player2(playCount, 0)
                If player1Card > player2Card Then
                    OutcomeLabel.Text = "Player 2 Wins the Draw"
                    dummmyCount = playCount - 3
                    Do
                        player2Wins(twoWin) = player1(dummmyCount, 0)
                        twoWin += 1
                        player2Wins(twoWin) = player2(dummmyCount, 0)
                        twoWin += 1
                        dummmyCount += 1
                    Loop Until playCount = dummmyCount
                ElseIf player2Card > player1Card Then
                    OutcomeLabel.Text = "Player 1 Wins the Draw"
                    dummmyCount = playCount - 3
                    Do
                        player1Wins(oneWin) = player1(dummmyCount, 0)
                        oneWin += 1
                        player1Wins(twoWin) = player2(dummmyCount, 0)
                        oneWin += 1
                        dummmyCount += 1
                    Loop Until playCount = dummmyCount
                Else
                    MsgBox("listen here Luck is not on your side")
                End If
            Else
                playCount = 25

            End If
        Else
            OutcomeLabel.Text = "Player 1 Wins This Round"
            player1Wins(oneWin) = player2Card
            oneWin += 1
            player2Wins(oneWin) = player1Card
            oneWin += 1
        End If

        If tie = True Then
        Else
            playCount += 1
        End If

        Return playCount
    End Function
    ''' <summary>
    ''' Handles the majority of display responsibilities for each card
    ''' </summary>
    Sub DisplayCards()

        Dim playCount% = PlayGame()
        Dim player1Result%, player2Result%
        Player1PictureBox.Refresh()
        Player2PictureBox.Refresh()


        If playCount = -1 Then
            player1Result = UBound(player1Wins)
            player2Result = UBound(player2Wins)

            If player1Result > player2Result Then
                OutcomeLabel.Text = "Player 1 is the master winner!"
                totalWinsOne += 1
            ElseIf player2Result > player1Result Then
                OutcomeLabel.Text = "Player 2 is the master winner!"
                totalWinsTwo += 1
            Else
                OutcomeLabel.Text = "Neither side wins"
            End If
            totalPlays += 1
            GamesLabel.Text = $"{totalPlays}"
            ReDim player1Wins(50)
            ReDim player2Wins(50)
        Else
            WarToolStripProgressBar.Value = playCount - 1
            PlaysLabel.Text = $"{playCount - 1}"
            Player1PictureBox.Image = Image.FromFile($"..\..\Card Images\{CardSuit(player1(playCount - 1, 0), player1(playCount - 1, 1))}.png")
            Player2PictureBox.Image = Image.FromFile($"..\..\Card Images\{CardSuit(player2(playCount - 1, 0), player2(playCount - 1, 1))}.png")
        End If



    End Sub
    ''' <summary>
    ''' Below Sub handles key events for each of the hotkeys avaible  
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Sub G_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.G And PlayButton.Enabled Then
            DisplayCards()
        ElseIf e.KeyCode = Keys.D Then
            Shuffler.DrawCard(player1, player2) ' distribute cards to each player
            PlayButton.Enabled = True
            DealButton.Enabled = False
        ElseIf e.KeyCode = Keys.F Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' When play button is pressed begin entering the first sub
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

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
            Case 12
                card = "Ace"
            Case 0
                card = "Two"
            Case 1
                card = "Three"
            Case 2
                card = "Four"
            Case 3
                card = "Five"
            Case 4
                card = "Six"
            Case 5
                card = "Seven"
            Case 6
                card = "Eight"
            Case 7
                card = "Nine"
            Case 8
                card = "Ten"
            Case 9
                card = "Joker"
            Case 10
                card = "Queen"
            Case 11
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

    ''' <summary>
    ''' When the from loads disable the ability to play until the deal button is pressed 
    ''' enable key events for hot keys
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub WarCards_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        PlayButton.Enabled = False
        DealButton.Enabled = True
        PlaysLabel.Text = ""
        GamesLabel.Text = ""
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        'Hide current form to Show About Form
        Me.Hide()
        AboutForm.Show()
    End Sub


    Private Sub WarCards_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Display the results of the games upon form close
        MsgBox($"There were {totalPlays} games played {vbNewLine} Player 1 won {totalWinsOne} times {vbNewLine} Player 2 won {totalWinsTwo} times")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
