Imports System.Threading.Thread
Public Class SplashForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        WarCards.Show()
        SplashTimer.Enabled = False
        Sleep(1000)
        Me.Close()
    End Sub
End Class