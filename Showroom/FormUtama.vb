Public Class FormUtama

    Private Sub DataKendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKendaraanToolStripMenuItem.Click
        FormKendaraan.ShowDialog()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        FormLaporan.ShowDialog()
    End Sub

    Private Sub FormUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub SettingPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingPasswordToolStripMenuItem.Click
        FormPassword.ShowDialog()
    End Sub
End Class