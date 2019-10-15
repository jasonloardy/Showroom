Public Class FormLogin
    Function cek_login()
        koneksi()
        cmd.CommandText = "SELECT * FROM tbl_password WHERE id = 'pass' and password = '" & tbpassword.Text & "'"
        cmd.Connection = Conn
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            dr.Close()
            Return True
        Else
            dr.Close()
            MsgBox("Password Salah!", 16, "Perhatian")
            tbpassword.Focus()
            Return False
        End If
    End Function
    Sub login()
        If tbpassword.Text = "" Then
            MsgBox("Silahkan Isi Password!", 16, "Perhatian")
        Else
            If cek_login() Then
                tbpassword.Clear()
                Me.Hide()
                FormUtama.Show()
            End If
        End If
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        login()
    End Sub

    Private Sub tbpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tbpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class