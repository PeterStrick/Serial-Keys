Public Class Logo
    Private Sub Logo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowMainFormInXSeconds.Interval = 4500 '4.5 seconds
        ShowMainFormInXSeconds.Start()
    End Sub

    Private Sub ShowMainFormInXSeconds_Tick(sender As Object, e As EventArgs) Handles ShowMainFormInXSeconds.Tick
        SerialKeysUI.Show()
        Close()
    End Sub
End Class