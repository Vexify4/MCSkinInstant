Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "https://mc-heads.net/player/" + TextBox1.Text
        WebBrowser1.Navigate(TextBox1.Text)
        TextBox1.Text = ""
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "https://mc-heads.net/download/" + TextBox1.Text
        WebBrowser2.Navigate(TextBox1.Text)
        TextBox1.Text = ""
    End Sub
End Class
