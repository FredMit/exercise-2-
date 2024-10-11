Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim i As Integer
        i = txtNumber.Text()
        If i > 0 Then
            MessageBox.Show("Postive number")
        End If
        If i < 0 Then
            MessageBox.Show("Negative number")
        End If
        If i = 0 Then
            MessageBox.Show("Zero")
        End If
    End Sub
End Class
