
Option Explicit On
Option Strict On
Option Compare Text

Public Class UserDisplay

    Dim shots(2, 500) As String
    Sub PastUsersDisplay()
        Dim pastUser() As String
        Dim scoreOne() As String, scoreTwo() As String, scoreThree() As String
        Dim players As String
        Dim temp() As String
        Dim display As String
        RecordsListBox.Items.Clear()
        Dim e As Integer = 0

        Try
            FileOpen(1, "..\..\Replay.txt", OpenMode.Input)

        Catch ex As Exception
            FileOpen(2, "..\..\Errorlog.txt", OpenMode.Append)
            Write(2, CStr($"Error: {Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try

        Do Until EOF(1)
            players = LineInput(1)
            players = players.Replace(Chr(34), " ")


            temp = Split(players, ":")
            If temp.Length = 1 Then
            Else

                pastUser = Split(temp(0), " User$$")
                scoreOne = Split(temp(1), "Play1##")
                scoreTwo = Split(temp(2), "Play2##")
                scoreThree = Split(temp(3), "Play3##")
                display = $"{pastUser(1)} 1, {scoreOne(1)}: 2, {scoreTwo(1)}: 3, {scoreThree(1)} "
                RecordsListBox.Items.Add(display)
                shots(0, e) = scoreOne(1)
                shots(1, e) = scoreTwo(1)
                shots(2, e) = scoreThree(1)
                e = e + 1

            End If
            ReDim Preserve shots(2, e)
        Loop


        FileClose(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If String.IsNullOrEmpty(UserTextBox.Text) Then
            MsgBox("Please enter your Name")
        Else
            Me.Hide()
            DartBoard.Show()

            DartBoard.WritePlayerData("0", "0", "0", UserTextBox.Text, False)
        End If

    End Sub

    Private Sub RecordsButton_Click(sender As Object, e As EventArgs) Handles RecordsButton.Click
        PastUsersDisplay()
    End Sub

    Private Sub ExitButton1_Click(sender As Object, e As EventArgs) Handles ExitButton1.Click
        Me.Close()
    End Sub

    Private Sub ReplayButton_Click(sender As Object, e As EventArgs) Handles ReplayButton.Click
        Dim play1 As String, play2 As String, play3 As String
        Dim temp As Integer
        temp = RecordsListBox.SelectedIndex
        play1 = shots(0, temp)
        play2 = shots(1, temp)
        play3 = shots(2, temp)
        Me.Hide()
        DartBoard.Show()
        DartBoard.GameReplay(play1, play2, play3)


    End Sub
End Class