Public Class Form2

    Dim t1, t2, t3, t4 As Integer
    Dim t5 As Double
    Dim s As String
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox4.Text = t4
        TextBox5.Text = t5
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        s = TextBox1.Text
        t1 = Val(s)
        t4 = t1 + t2 + t3
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        s = TextBox2.Text
        t2 = Val(s)
        t4 = t1 + t2 + t3
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        s = TextBox3.Text
        t3 = Val(s)
        t4 = t1 + t2 + t3
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox1.Modified = True
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

        TextBox1.Modified = True
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        t1 = t2 = t3 = t4 = t5 = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        t4 = t1 + t2 + t3
        TextBox4.Text = t4
        If (t4 >= 80) Then
            t5 = 4
        ElseIf (t4 >= 75) Then
            t5 = 3.5
        ElseIf (t4 >= 70) Then
            t5 = 3
        ElseIf (t4 >= 65) Then
            t5 = 2.5
        ElseIf (t4 >= 60) Then
            t5 = 2
        ElseIf (t4 >= 55) Then
            t5 = 1.5
        ElseIf (t4 >= 50) Then
            t5 = 1
        ElseIf (t4 >= 0) Then
            t5 = 0

        End If
        TextBox5.Text = t5
    End Sub

End Class