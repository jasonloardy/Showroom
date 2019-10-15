Public Class FormUtama

    Private Sub DataKendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKendaraanToolStripMenuItem.Click
        FormKendaraan.ShowDialog()
    End Sub

    Private Sub FormUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub SettingPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingPasswordToolStripMenuItem.Click
        FormPassword.ShowDialog()
    End Sub

    Private Sub DataPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPenjualanToolStripMenuItem.Click
        FormLapPenjualan.ShowDialog()
    End Sub

    Private Sub DataStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataStokToolStripMenuItem.Click
        FormViewCR.CetakStok()
        FormViewCR.ShowDialog()
    End Sub

    Private Sub DataSeluruhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSeluruhToolStripMenuItem.Click
        FormLapSeluruh.ShowDialog()
    End Sub
End Class