'Owen Fujii
'Dart Game
'TODO
'[*] Represent Dart Game Graphically
'[*] Show Each Dart Thrown
'[] Track Dart Throws
'[] Recall old Games
'[] Have Graphical replay
'[] 

Option Explicit On
Option Strict On

Public Class DartBoard
    Private Sub DefaultLoader(sender As Object, e As EventArgs) Handles Me.Load
        DrawDartBoard(True)
        Me.Hide()
        UserDisplay.Show()
    End Sub
    Sub DrawDartBoard(refresh As Boolean)
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black, 5)
        Dim x As Double, y As Double
        Dim pi As Double = Math.PI
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
            MsgBox("turn is over")
            WritePlayerData(throwOne, throwTwo, throwThree, "tim", True)
            throwCounter = 0
            newTurn = True
        End If

    End Sub

    Function DartThrow() As String
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics
        Dim pen As New Pen(Color.DarkRed, 5)
        Dim centerX As Integer, centerY As Integer
        Dim referenceX = DartBoardPictureBox.Width
        Dim referenceY = DartBoardPictureBox.Height
        Dim savedCord As String
        centerX = CInt(referenceX / 2) - DartCord()
        centerY = CInt(referenceY / 2) - DartCord()

        g.DrawLine(pen, centerX, centerY - 10, centerX, centerY + 10)
        g.DrawLine(pen, centerX - 10, centerY, centerX + 10, centerY)
        savedCord = ($"{centerX},{centerY}")
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

            Write(1, CStr($"User$${currentUser}Play1{playOne}Play2{playTwo}Play3{playThree}{vbNewLine}"))
            FileClose(1)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        UserDisplay.Show()
    End Sub
End Class
