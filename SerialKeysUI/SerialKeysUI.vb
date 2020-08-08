Public Class SerialKeysUI
    Private Sub ShowOwnDBBtn_Click(sender As Object, e As EventArgs) Handles ShowOwnDBBtn.Click
        MsgBox("A few elements and error messages are in German. To find a translation, go to my Github page github.com/peterstrick/serial-keys")
        Process.Start(Application.StartupPath + "\SerialKeys.exe")
        Close()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        SerialKeysOnline.Show()
        Close()
    End Sub

    Private Sub SampleDBBtn_Click(sender As Object, e As EventArgs) Handles SampleDBBtn.Click
        SampleDb.Show()
        Close()
    End Sub
End Class
