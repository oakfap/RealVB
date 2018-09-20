Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim id As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        If (id = "Admin") Then
            If (pass = "vb.net") Then
                MessageBox.Show("Welcome!!" & vbNewLine & "User ::  " & id)
                Me.Hide()
                Form2.Show()
            Else
                MessageBox.Show("Wrong ID or Password")
            End If
        Else
            MessageBox.Show("Wrong ID or Password")
        End If


    End Sub


End Class
