Public Class FormPassword
    Sub reset()
        tbpasslama.Clear()
        tbpassbaru.Clear()
        tbpassbaru2.Clear()
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        cmd.CommandText = "SELECT * FROM tbl_password WHERE id = 'pass' and password = '" & tbpasslama.Text & "'"
        cmd.Connection = Conn
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            dr.Close()
            If tbpassbaru.Text = tbpassbaru2.Text Then
                Dim update As String = "UPDATE tbl_password SET [password]=@password WHERE id='pass'"
                QueryPassword(update, tbpassbaru.Text)
                MsgBox("Password Berhasil di Ganti!")
                reset()
            Else
                MsgBox("Konfirmasi Password Baru Salah!")
                tbpassbaru2.Focus()
            End If
        Else
            dr.Close()
            MsgBox("Password Lama Salah!")
            tbpasslama.Focus()
        End If
    End Sub

    Private Sub FormPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
End Class