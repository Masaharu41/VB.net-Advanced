
Option Explicit On
Option Strict On
Option Compare Text

Public Class UserDisplay
    Sub PastUsersDisplay()
        Dim pastUser() As String
        Dim scoreOne() As String, scoreTwo() As String, scoreThree() As String
        Dim players As String
        Dim temp() As String
        Dim display As String
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
            pastUser = Split(temp(0), " User$$")
            scoreOne = Split(temp(1), "Play1##")
            scoreTwo = Split(temp(2), "Play2##")
            scoreThree = Split(temp(3), "Play3##")
            e = e + 1
        Loop
        For i = 1 To pastUser.Length - 2
            display = $"{pastUser(i)} 1, {scoreOne(i)}: 2, {scoreTwo(i)}: 3, {scoreThree(i)} "
            RecordsListBox.Items.Add(display)
        Next

        FileClose(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Me.Hide()
        DartBoard.Show()
        DartBoard.WritePlayerData("0", "0", "0", UserTextBox.Text, False)
    End Sub

    Private Sub RecordsButton_Click(sender As Object, e As EventArgs) Handles RecordsButton.Click
        PastUsersDisplay()
    End Sub
End Class