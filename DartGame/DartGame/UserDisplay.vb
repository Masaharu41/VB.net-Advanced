﻿
Option Explicit On
Option Strict On
Option Compare Text

Public Class UserDisplay
    'Sub PastUsers()
    '    Dim pastUser As String
    '    Dim scoreOne As String, scoreTwo As String, scoreThree As String

    '    Try
    '        FileOpen(1, "..\..\Replay.txt", OpenMode.Input)

    '    Catch ex As Exception
    '        FileOpen(2, "..\..\Errorlog.txt", OpenMode.Append)
    '        Write(2, CStr($"Error: {Err.Number}, {Err.Description} {vbNewLine}"))
    '        FileClose(2)
    '    End Try

    '    Do Until EOF(1)

    '    Loop


    '    FileClose(1)
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Me.Hide()
        DartBoard.Show()
        DartBoard.WritePlayerData("0", "0", "0", UserTextBox.Text, False)
    End Sub


End Class