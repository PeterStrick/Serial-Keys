Public Class DevelopmentLogoForm
    Private Sub ShowMainFormInSeconds_Tick(sender As Object, e As EventArgs) Handles ShowMainFormInSeconds.Tick
        masterKeyForm.Show()
        Close()
    End Sub
    Private Sub DevelopmentLogoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowMainFormInSeconds.Start()
    End Sub
End Class