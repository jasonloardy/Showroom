Public Class FormLaporan
    Sub cb_tahun()
        Dim q As String = "SELECT DISTINCT Year(tgl_jual) AS tahun from tbl_kendaraan"
        cbtahun2.DataSource = querycb(q)
        cbtahun2.ValueMember = "tahun"
        cbtahun2.DisplayMember = "tahun"

        cbtahun1.DataSource = querycb(q)
        cbtahun1.ValueMember = "tahun"
        cbtahun1.DisplayMember = "tahun"
    End Sub
    Sub cb_bulan()
        Dim q As String = "SELECT DISTINCT Month(tgl_jual) AS no_bulan " _
                        & "FROM tbl_kendaraan " _
                        & "WHERE year(tgl_jual) = '" & cbtahun1.Text & "'"
        cbbulan.DataSource = querycb(q)
        cbbulan.ValueMember = "no_bulan"
        cbbulan.DisplayMember = "no_bulan"
    End Sub

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_tahun()
        cbtahun1.Text = Date.Today.Year
        cbtahun2.Text = Date.Today.Year
        cb_bulan()
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        If rbperiode.Checked Then
            FormViewCR.CetakRekapPeriode()
            FormViewCR.ShowDialog()
        ElseIf rbbulan.Checked Then
            FormViewCR.CetakRekapBulanan()
            FormViewCR.ShowDialog()
        ElseIf rbtahun.Checked Then
            FormViewCR.CetakRekapTahunan()
            FormViewCR.ShowDialog()
        End If
    End Sub

    Private Sub cbtahun1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtahun1.SelectedIndexChanged
        cb_bulan()
    End Sub
End Class