Public Class Form1
    Dim exp As String = Nothing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        exp = TextBox1.Text()
        exp += "1"
        UpdateText()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        exp = TextBox1.Text()
        exp += "2"
        UpdateText()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        exp = TextBox1.Text()
        exp += "3"
        UpdateText()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        exp = TextBox1.Text()
        exp += "4"
        UpdateText()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        exp = TextBox1.Text()
        exp += "5"
        UpdateText()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        exp = TextBox1.Text()
        exp += "6"
        UpdateText()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        exp = TextBox1.Text()
        exp += "7"
        UpdateText()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        exp = TextBox1.Text()
        exp += "8"
        UpdateText()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        exp = TextBox1.Text()
        exp += "9"
        UpdateText()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        exp = TextBox1.Text()
        exp += "0"
        UpdateText()
    End Sub

    Private Sub Dot_Click(sender As Object, e As EventArgs) Handles Dot.Click
        exp = TextBox1.Text()
        exp += "."
        UpdateText()
    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        exp = TextBox1.Text()
        exp += " + "
        UpdateText()
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        exp = TextBox1.Text()
        exp += " - "
        UpdateText()
    End Sub

    Private Sub Multiplication_Click(sender As Object, e As EventArgs) Handles Multiplication.Click
        exp = TextBox1.Text()
        exp += " * "
        UpdateText()
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        exp = TextBox1.Text()
        exp += " / "
        UpdateText()
    End Sub

    Private Sub ParenthesesLeft_Click(sender As Object, e As EventArgs) Handles ParenthesesLeft.Click
        exp = TextBox1.Text()
        exp += "("
        UpdateText()
    End Sub

    Private Sub ParenthesesRight_Click(sender As Object, e As EventArgs) Handles ParenthesesRight.Click
        exp = TextBox1.Text()
        exp += ")"
        UpdateText()
    End Sub

    Private Sub UpdateText()
        TextBox1.Clear()
        TextBox1.AppendText(exp)
    End Sub

    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click
        exp = TextBox1.Text()
        Try
            Dim res = New DataTable().Compute(exp, Nothing)
            exp = Nothing
            TextBox1.Clear()
            TextBox1.AppendText(res)
        Catch
            exp = Nothing
            TextBox1.Clear()
            TextBox1.AppendText("ERROR")
        End Try
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        exp = Nothing
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            exp = TextBox1.Text()
            Try
                Dim res = New DataTable().Compute(exp, Nothing)
                exp = Nothing
                TextBox1.Clear()
                TextBox1.AppendText(res)
            Catch
                exp = Nothing
                TextBox1.Clear()
                TextBox1.AppendText("ERROR")
            End Try
        End If
    End Sub
End Class
