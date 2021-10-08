Public Class FormMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If InStr(TextBox1.Text, "Console.WriteLine();") Then
            TextBox2.Text = TextBox2.Text & "Test"
        End If
    End Sub
End Class
