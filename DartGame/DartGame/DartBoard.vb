'Owen Fujii
'Dart Game
'TODO
'[*] Represent Dart Game Graphically
'[*] Show Each Dart Thrown
'[*] Track Dart Throws
'[*] Recall old Games
'[*] Have Graphical replay


Option Explicit On
Option Strict On

Imports System.Threading
Imports System.Runtime.InteropServices

Public Class DartBoard
    Private Sub DefaultLoader(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Thread.Sleep(100)
        DrawDartBoard(True)

    End Sub


    Sub DrawDartBoard(refresh As Boolean)
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black, 5)
        Dim x As Double, y As Double
        ' Dim pi As Double = Math.PI
        Dim screenWidth = DartBoardPictureBox.Width
        Dim screenHeight = DartBoardPictureBox.Height
        Static oldWidth As Integer = 0, oldHeight As Integer = 0
        If refresh = True Then
            DartBoardPictureBox.Refresh()
        ElseIf oldWidth = screenWidth And oldHeight = screenHeight Then
        Else
            DartBoardPictureBox.Refresh()
            oldWidth = screenWidth
            oldHeight = screenHeight
        End If

        If screenHeight < screenWidth Then
            Dim rect As New Rectangle(CInt((screenWidth - screenHeight) / 2), 0, screenHeight, screenHeight)
            g.DrawEllipse(pen, rect)
        Else
            Dim rect As New Rectangle(0, CInt((screenHeight - screenWidth) / 2), screenWidth, screenWidth)
            g.DrawEllipse(pen, rect)
        End If


    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        DartStacker()
    End Sub

    Sub DartStacker()
        Static throwCounter As Integer = 0
        Static newTurn As Boolean
        Static throwOne As String, throwTwo As String, throwThree As String

        DrawDartBoard(newTurn)

        If throwCounter <= 2 Then
            newTurn = False
            If throwCounter = 0 Then
                throwOne = DartThrow()
            ElseIf throwCounter = 1 Then
                throwTwo = DartThrow()
            Else
                throwThree = DartThrow()
            End If
            throwCounter = throwCounter + 1
        Else
            Dim result As MsgBoxResult = MsgBox("Want to Go Again?", MsgBoxStyle.YesNo)
            Select Case result
                Case MsgBoxResult.Yes

                    WritePlayerData(throwOne, throwTwo, throwThree, "tim", True)
                    throwCounter = 0
                    newTurn = True
                Case MsgBoxResult.No
                    WritePlayerData(throwOne, throwTwo, throwThree, "tim", True)
                    throwCounter = 0
                    newTurn = True
                    Me.Hide()
                    UserDisplay.Show()

            End Select
        End If

    End Sub

    Sub SpacePress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            DartStacker()
        Else

        End If
    End Sub

    Function DartThrow() As String
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics
        Dim pen As New Pen(Color.DarkRed, 5)
        Dim pen2 As New Pen(Color.Black, 4)
        Dim centerX As Integer, centerY As Integer
        Dim referenceX = DartBoardPictureBox.Width
        Dim referenceY = DartBoardPictureBox.Height
        Dim savedCord As String
        centerX = CInt(referenceX / 2) - DartCord()
        centerY = CInt(referenceY / 2) - DartCord()
        g.DrawLine(pen, centerX, centerY - 10, centerX, centerY + 10)
        g.DrawLine(pen, centerX - 10, centerY, centerX + 10, centerY)
        g.DrawEllipse(pen2, centerX - 2, centerY - 2, 4, 4)
        savedCord = ($"{centerX};{centerY}")
        Return savedCord

    End Function

    Function DartCord() As Integer
        Dim temp As Integer
        Dim screenWidth = DartBoardPictureBox.Width
        Dim screenHeight = DartBoardPictureBox.Height
        Dim polarity As Integer
        If screenWidth < screenHeight Then
            Randomize()
            temp = CInt(Rnd() * ((screenWidth - (screenWidth * (1 / 8))) / 4))
        Else
            Randomize()
            temp = CInt(Rnd() * ((screenHeight - (screenHeight * (1 / 8))) / 4))
        End If
        polarity = CInt(Rnd())
        If polarity = 1 Then
            temp = -temp
        Else

        End If

        Return temp
    End Function

    Sub GameReplay(play1 As String, play2 As String, play3 As String)
        Dim multiCord() As String, multicord2() As String, multicord3() As String
        Dim firstX As Integer, firstY As Integer
        Dim secondX As Integer, secondY As Integer
        Dim thirdX As Integer, thirdY As Integer
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics
        Dim pen As New Pen(Color.DarkRed, 5)
        DrawDartBoard(True)
        multiCord = Split(play1, ";")
        multicord2 = Split(play2, ";")
        multicord3 = Split(play3, ";")

        firstX = CInt(multiCord(0))
        firstY = CInt(multiCord(1))

        secondX = CInt(multicord2(0))
        secondY = CInt(multicord2(1))

        thirdX = CInt(multicord3(0))
        thirdY = CInt(multicord3(1))




        g.DrawLine(pen, firstX, firstY - 10, firstX, firstY + 10)
        g.DrawLine(pen, firstX - 10, firstY, firstX + 10, firstY)

        g.DrawLine(pen, secondX, secondY - 10, secondX, secondY + 10)
        g.DrawLine(pen, secondX - 10, secondY, secondX + 10, secondY)

        g.DrawLine(pen, thirdX, thirdY - 10, thirdX, thirdY + 10)
        g.DrawLine(pen, thirdX - 10, thirdY, thirdX + 10, thirdY)
    End Sub

    Sub WritePlayerData(playOne As String, playTwo As String, playThree As String, user As String, writeT As Boolean)
        Static currentUser As String
        If writeT = False Then
            currentUser = user

        Else
            Try
                FileOpen(1, "..\..\Replay.txt", OpenMode.Append)

            Catch ex As Exception
                FileOpen(2, "..\..\Errorlog.txt", OpenMode.Append)
                Write(2, CStr($"Error: {Err.Number}, {Err.Description} {vbNewLine}"))
                FileClose(2)
            End Try

            Write(1, CStr($"User$${currentUser}:" + $"Play1##{playOne}:" + $"Play2##{playTwo}:" + $"Play3##{playThree}" + vbNewLine))
            FileClose(1)
        End If
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        Me.Hide()
        UserDisplay.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        UserDisplay.Close()
    End Sub
End Class
