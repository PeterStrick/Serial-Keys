Public Class SampleDb
    Private Sub SampleDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = My.Resources.SampleDb
    End Sub

    Private Sub SampleDb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SerialKeysUI.Show()
    End Sub
End Class