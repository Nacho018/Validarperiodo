Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.MaxLength = 7

    End Sub



    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " - " Then

            e.Handled = True
            Exit Sub

        End If


        Dim pos As Integer = TextBox1.SelectionStart





        If e.KeyChar = " - " And pos <> 2 Then

            e.Handled = True

            Exit Sub

        End If

        If Char.IsNumber(e.KeyChar) And (pos = 2) Then
            e.Handled = True

            Exit Sub

        End If

    End Sub
End Class
