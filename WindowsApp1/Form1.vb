Public Class Form1

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_user.Text = "kevin" And txt_pass.Text = "itbi" Then
            Dim frm As New FormMENU
            frm.Show()
        Else
            MsgBox("MAAF user dan password yang kamu masukkan salah")
        End If
    End Sub
End Class
