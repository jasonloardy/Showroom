Public Class FormUtama

    Private Sub DataKendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKendaraanToolStripMenuItem.Click
        FormKendaraan.ShowDialog()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        FormLaporan.ShowDialog()
    End Sub
End Class