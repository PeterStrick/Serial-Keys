Public Class SerialKeysOnline
    Private Sub SerialKeysOnline_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SerialKeysUI.Show()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        WebBrowser1.Navigate("findserialnumber.net")
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ForwardBtn_Click(sender As Object, e As EventArgs) Handles ForwardBtn.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub OpenSerialKeysBtn_Click(sender As Object, e As EventArgs) Handles OpenSerialKeysBtn.Click
        Process.Start(Application.StartupPath + "\SerialKeys.exe")
    End Sub
End Class