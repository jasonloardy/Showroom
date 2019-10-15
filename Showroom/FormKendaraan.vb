Imports System.Data.OleDb

Public Class FormKendaraan
    Public mode As String
    Public mode_mt As String
    Public id_data As String
    Public id_data_mt As String
    Public total As Decimal = 0
    Public totalmt As Decimal = 0
    Private Sub FormKendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        isidgvkendaraan()
        reset()
    End Sub
    Sub isidgvkendaraan()
        Dim query As String = "SELECT * FROM tbl_kendaraan ORDER BY status ASC"
        Dim da As New OleDbDataAdapter(query, Conn)
        Dim ds As New DataSet()
        With dgvkendaraan
            If da.Fill(ds) Then
                .DataSource = ds.Tables(0)
                .Refresh()
            Else
                .DataSource = Nothing
            End If
            If .RowCount > 0 Then
                juduldgvkendaraan()
            End If
        End With
        totalkendaraan()
    End Sub
    Sub juduldgvkendaraan()
        With dgvkendaraan
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            .AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "No. Polisi"
            .Columns(1).Width = 90
            .Columns(2).HeaderText = "Merk / Tipe"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Tahun"
            .Columns(3).Width = 50
            .Columns(4).HeaderText = "Warna"
            .Columns(4).Width = 70
            For i = 5 To 6
                .Columns(i).Visible = False
            Next
            .Columns(7).HeaderText = "Tgl. Beli"
            .Columns(7).Width = 75
            .Columns(7).DefaultCellStyle.Format = "dd/MM/yyyy"
            For i = 8 To 9
                .Columns(i).Visible = False
            Next
            .Columns(10).HeaderText = "Status"
            .Columns(10).Width = 50
            For i = 11 To 19
                .Columns(i).Visible = False
            Next
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub
    Sub totalkendaraan()
        Dim ready As Integer
        Dim sold As Integer
        Dim all As Integer
        With dgvkendaraan
            For index As Integer = 0 To .RowCount - 1
                If .Rows(index).Cells(10).Value = "READY" Then
                    ready += 1
                    all += 1
                ElseIf .Rows(index).Cells(10).Value = "SOLD" Then
                    sold += 1
                    all += 1
                End If
            Next
        End With
        lblcount.Text = "Ready : " & ready & " unit          Sold : " & sold & " unit          Total : " & all & " unit"
    End Sub
    Sub isidgvmaintenance()
        Dim query As String = "SELECT * FROM tbl_maintenance WHERE id_kendaraan = " & id_data
        Dim da As New OleDbDataAdapter(query, Conn)
        Dim ds As New DataSet()
        With dgvmaintenance
            If da.Fill(ds) Then
                .DataSource = ds.Tables(0)
                .Refresh()
            Else
                .DataSource = Nothing
            End If
            If .RowCount > 0 Then
                juduldgvmaintenance()
            End If
        End With
        hitungtotalmt()
        hitungmodal()
        queryedit2()
    End Sub
    Sub hitungtotalmt()
        totalmt = 0
        For index As Integer = 0 To dgvmaintenance.RowCount - 1
            totalmt += Convert.ToInt32(dgvmaintenance.Rows(index).Cells(3).Value)
        Next
        lbltotalmt.Text = "Total Maintenance : " & FormatNumber(totalmt, 0)
    End Sub
    Sub juduldgvmaintenance()
        With dgvmaintenance
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            .AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).HeaderText = "Deskripsi"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Nominal"
            .Columns(3).DefaultCellStyle.Format = "n0"
            .Columns(3).Width = 80
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub
    Sub bersihmt()
        tbdeskripsi.Clear()
        tbnominal.Clear()
    End Sub
    Sub bersihpembayaran()
        tbhargajual.Clear()
        tbleasing.Clear()
        tbuangmuka.Clear()
        tbcair.Clear()
        tbrefund.Clear()
        tbtotal.Clear()
        tbkeuntungan.Clear()
        tbpersentase.Clear()
    End Sub
    Sub bersih()
        tbnopol.Clear()
        tbmerktipe.Clear()
        tbtahun.Clear()
        tbwarna.Clear()
        tbdatapenjual.Clear()
        tbvendor.Clear()
        dtptglpembelian.Value = DateTime.Now
        dtptgljual.Value = DateTime.Now
        tbhargabeli.Clear()
        tbstatusbpkb.Clear()
        bersihmt()
        lbltotalmt.Text = "Total Maintenance : 0"
        total = 0
        tbmodal.Clear()
        chktransaksi.Checked = False
        bersihpembayaran()
        cbcarabayar.SelectedIndex = -1
    End Sub
    Sub reset()
        gbinfokendaraan.Enabled = False
        gbmaintenance.Enabled = False
        dgvmaintenance.DataSource = Nothing
        gbpenjualan.Enabled = False
        lblcarabayar.Visible = False
        cbcarabayar.Visible = False
        panelcash.Visible = False
        panelkredit.Visible = False
        panelprofit.Visible = False
        bersih()
        btntambah.Text = "Tambah"
        btntambah.Enabled = True
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btncetak.Enabled = False
    End Sub
    Sub resetmt()
        tbdeskripsi.Enabled = False
        tbnominal.Enabled = False
        bersihmt()
        btnmttambah.Text = "Tambah"
        btnmttambah.Enabled = True
        btnmtedit.Enabled = False
        btnmthapus.Enabled = False
    End Sub
    Sub modesimpan()
        gbinfokendaraan.Enabled = True
        gbpenjualan.Enabled = True
        btntambah.Text = "Simpan"
        btntambah.Enabled = True
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btncetak.Enabled = False
    End Sub
    Sub modesimpanmt()
        tbdeskripsi.Enabled = True
        tbnominal.Enabled = True
        btnmttambah.Text = "Simpan"
        btnmttambah.Enabled = True
        btnmtedit.Enabled = False
        btnmthapus.Enabled = False
    End Sub
    Sub gridtotextbox()
        With dgvkendaraan
            .Refresh()
            If .RowCount > 0 Then
                Dim baris As Integer
                baris = .CurrentRow.Index
                id_data = .Item(0, baris).Value
                tbnopol.Text = .Item(1, baris).Value
                tbmerktipe.Text = .Item(2, baris).Value
                tbtahun.Text = .Item(3, baris).Value
                tbwarna.Text = .Item(4, baris).Value
                tbdatapenjual.Text = .Item(5, baris).Value
                tbvendor.Text = .Item(6, baris).Value
                dtptglpembelian.Value = .Item(7, baris).Value
                tbhargabeli.Text = FormatNumber(Val(.Item(8, baris).Value), 0)
                tbstatusbpkb.Text = .Item(9, baris).Value
                If .Item(10, baris).Value = "SOLD" Then
                    chktransaksi.Checked = True
                    dtptgljual.Value = .Item(11, baris).Value
                    cbcarabayar.Text = .Item(12, baris).Value
                    tbleasing.Text = .Item(13, baris).Value
                    tbuangmuka.Text = FormatNumber(Val(.Item(14, baris).Value), 0)
                    tbcair.Text = FormatNumber(Val(.Item(15, baris).Value), 0)
                    tbrefund.Text = FormatNumber(Val(.Item(16, baris).Value), 0)
                    tbhargajual.Text = FormatNumber(Val(.Item(17, baris).Value), 0)
                    tbtotal.Text = FormatNumber(Val(.Item(17, baris).Value), 0)
                    panelprofit.Visible = True
                    tbkeuntungan.Text = FormatNumber(Val(.Item(18, baris).Value), 0)
                    tbpersentase.Text = FormatNumber(Val(.Item(19, baris).Value), 0)
                Else
                    panelprofit.Visible = False
                    chktransaksi.Checked = False
                End If
            End If
        End With
        isidgvmaintenance()
    End Sub
    Sub gridmttotextbox()
        With dgvmaintenance
            .Refresh()
            If .RowCount > 0 Then
                Dim baris As Integer
                baris = .CurrentRow.Index
                id_data_mt = .Item(0, baris).Value
                tbdeskripsi.Text = .Item(2, baris).Value
                tbnominal.Text = .Item(3, baris).Value
            End If
        End With
    End Sub
    Sub querytambah()
        Dim query As String = "INSERT INTO tbl_kendaraan (nopol, merk_tipe, tahun, " _
                            & "warna, data_penjual, vendor, tgl_beli, " _
                            & "hrg_beli, status_bpkb, status, tgl_jual, " _
                            & "cara_bayar, leasing, uang_muka, cair, " _
                            & "refund, total, keuntungan, persentase) VALUES (@nopol, @merk_tipe, @tahun, " _
                            & "@warna, @data_penjual, @vendor, @tgl_beli, " _
                            & "@hrg_beli, @status_bpkb, @status, @tgl_jual, " _
                            & "@cara_bayar, @leasing, @uang_muka, @cair, " _
                            & "@refund, @total, @keuntungan, @persentase)"
        Dim status As String
        If chktransaksi.Checked Then
            status = "SOLD"
        Else
            status = "READY"
        End If
        QueryKendaraan(query, tbnopol.Text.ToUpper, tbmerktipe.Text.ToUpper, tbtahun.Text.ToUpper, _
                       tbwarna.Text.ToUpper, tbdatapenjual.Text.ToUpper, tbvendor.Text.ToUpper, dtptglpembelian.Value, _
                       Val(tbhargabeli.Text.Replace(".", "")), tbstatusbpkb.Text.ToUpper, status, dtptgljual.Value, _
                       cbcarabayar.Text, tbleasing.Text.ToUpper, Val(tbuangmuka.Text.Replace(".", "")), Val(tbcair.Text.Replace(".", "")), _
                       Val(tbrefund.Text.Replace(".", "")), total, Val(tbkeuntungan.Text.Replace(".", "")), Val(tbpersentase.Text.Replace(".", "")))
        MsgBox("Berhasil tambah data!", MsgBoxStyle.Information, "Informasi")
        isidgvkendaraan()
    End Sub
    Sub queryedit()
        Dim query As String = "UPDATE tbl_kendaraan SET nopol=@nopol, merk_tipe=@merk_tipe, tahun=@tahun, " _
                              & "warna=@warna, data_penjual=@data_penjual, vendor=@vendor, tgl_beli=@tgl_beli, " _
                              & "hrg_beli=@hrg_beli, status_bpkb=@status_bpkb, status=@status, tgl_jual=@tgl_jual, " _
                              & "cara_bayar=@cara_bayar, leasing=@leasing, uang_muka=@uang_muka, cair=@cair, " _
                              & "refund=@refund, total=@total, keuntungan=@keuntungan, persentase=@persentase " _
                              & "WHERE id_kendaraan=" & id_data
        Dim status As String
        If chktransaksi.Checked Then
            status = "SOLD"
        Else
            status = "READY"
        End If
        QueryKendaraan(query, tbnopol.Text.ToUpper, tbmerktipe.Text.ToUpper, tbtahun.Text.ToUpper, _
                       tbwarna.Text.ToUpper, tbdatapenjual.Text.ToUpper, tbvendor.Text.ToUpper, dtptglpembelian.Value, _
                       Val(tbhargabeli.Text.Replace(".", "")), tbstatusbpkb.Text.ToUpper, status, dtptgljual.Value, _
                       cbcarabayar.Text, tbleasing.Text.ToUpper, Val(tbuangmuka.Text.Replace(".", "")), Val(tbcair.Text.Replace(".", "")), _
                       Val(tbrefund.Text.Replace(".", "")), total, Val(tbkeuntungan.Text.Replace(".", "")), Val(tbpersentase.Text.Replace(".", "")))
        isidgvkendaraan()
        MsgBox("Berhasil update data!", MsgBoxStyle.Information, "Informasi")
    End Sub
    Sub queryedit2()
        Dim query As String = "UPDATE tbl_kendaraan SET nopol=@nopol, merk_tipe=@merk_tipe, tahun=@tahun, " _
                              & "warna=@warna, data_penjual=@data_penjual, vendor=@vendor, tgl_beli=@tgl_beli, " _
                              & "hrg_beli=@hrg_beli, status_bpkb=@status_bpkb, status=@status, tgl_jual=@tgl_jual, " _
                              & "cara_bayar=@cara_bayar, leasing=@leasing, uang_muka=@uang_muka, cair=@cair, " _
                              & "refund=@refund, total=@total, keuntungan=@keuntungan, persentase=@persentase " _
                              & "WHERE id_kendaraan=" & id_data
        Dim status As String
        If chktransaksi.Checked Then
            status = "SOLD"
        Else
            status = "READY"
        End If
        QueryKendaraan(query, tbnopol.Text.ToUpper, tbmerktipe.Text.ToUpper, tbtahun.Text.ToUpper, _
                       tbwarna.Text.ToUpper, tbdatapenjual.Text.ToUpper, tbvendor.Text.ToUpper, dtptglpembelian.Value, _
                       Val(tbhargabeli.Text.Replace(".", "")), tbstatusbpkb.Text.ToUpper, status, dtptgljual.Value, _
                       cbcarabayar.Text, tbleasing.Text.ToUpper, Val(tbuangmuka.Text.Replace(".", "")), Val(tbcair.Text.Replace(".", "")), _
                       Val(tbrefund.Text.Replace(".", "")), total, Val(tbkeuntungan.Text.Replace(".", "")), Val(tbpersentase.Text.Replace(".", "")))
    End Sub
    Sub queryhapus()
        Dim qhapus As String = "DELETE FROM tbl_kendaraan WHERE id_kendaraan=" & id_data
        Query(qhapus)
        isidgvkendaraan()
        MsgBox("Berhasil hapus data!", MsgBoxStyle.Information, "Informasi")
    End Sub
    Sub querytambahmt()
            Dim query As String = "INSERT INTO tbl_maintenance (id_kendaraan, deskripsi, nominal) VALUES (@id_kendaraan, @deskripsi, @nominal)"
            QueryMaintenance(query, id_data, tbdeskripsi.Text.ToUpper, Val(tbnominal.Text.Replace(".", "")))
            isidgvmaintenance()
    End Sub
    Sub queryeditmt()
        Dim query As String = "UPDATE tbl_maintenance SET id_kendaraan=@id_kendaraan, deskripsi=@deskripsi, nominal=@nominal WHERE id_maintenance=" & id_data_mt
        QueryMaintenance(query, id_data, tbdeskripsi.Text.ToUpper, Val(tbnominal.Text.Replace(".", "")))
        isidgvmaintenance()
    End Sub
    Sub queryhapusmt()
        Dim qhapus As String = "DELETE FROM tbl_maintenance WHERE id_maintenance=" & id_data_mt
        Query(qhapus)
        isidgvmaintenance()
    End Sub
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Tambah" Then
            mode = "tambah"
            modesimpan()
            bersih()
            tbnopol.Focus()
        Else
            If tbnopol.Text = "" Or tbmerktipe.Text = "" Or tbtahun.Text = "" Or tbwarna.Text = "" _
                Or tbdatapenjual.Text = "" Or tbhargabeli.Text = "" Or tbstatusbpkb.Text = "" _
                Or ((chktransaksi.Checked And cbcarabayar.SelectedIndex = -1) Or (cbcarabayar.SelectedIndex = 0 And tbhargajual.Text = "") _
                    Or (cbcarabayar.SelectedIndex = 1 And tbleasing.Text = "" And tbtotal.Text = "")) Then
                MsgBox("Lengkapi data yang kosong!", 16, "Informasi")
            Else
                If mode = "tambah" Then
                    querytambah()
                    reset()
                Else
                    queryedit()
                    reset()
                End If
            End If
        End If
    End Sub
    Private Sub dgvkendaraan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkendaraan.CellDoubleClick
        reset()
        gridtotextbox()
        btntambah.Enabled = False
        btnedit.Enabled = True
        btnhapus.Enabled = True
        btncetak.Enabled = True
    End Sub

    Private Sub cbcarabayar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcarabayar.SelectedIndexChanged
        If cbcarabayar.SelectedIndex = -1 Then
            panelcash.Visible = False
            panelkredit.Visible = False
        ElseIf cbcarabayar.Text = "CASH" Then
            panelcash.Visible = True
            panelkredit.Visible = False
        ElseIf cbcarabayar.Text = "KREDIT" Then
            panelcash.Visible = False
            panelkredit.Visible = True
        End If
        bersihpembayaran()
    End Sub

    Private Sub chktransaksi_CheckedChanged(sender As Object, e As EventArgs) Handles chktransaksi.CheckedChanged
        If chktransaksi.Checked Then
            lblcarabayar.Visible = True
            cbcarabayar.Visible = True
            cbcarabayar.SelectedIndex = -1
            panelprofit.Visible = True
        Else
            lblcarabayar.Visible = False
            cbcarabayar.Visible = False
            panelcash.Visible = False
            panelkredit.Visible = False
            panelprofit.Visible = False
            total = 0
            tbkeuntungan.Text = 0
            tbpersentase.Text = 0
        End If
    End Sub
    Sub hitungmodal()
        tbmodal.Text = FormatNumber(Val(tbhargabeli.Text.Replace(".", "")) + totalmt, 0)
    End Sub
    Private Sub tbhargabeli_TextChanged(sender As Object, e As EventArgs) Handles tbhargabeli.TextChanged
        If Len(tbhargabeli.Text) > 0 Then
            tbhargabeli.Text = FormatNumber(tbhargabeli.Text, 0)
            tbhargabeli.SelectionStart = Len(tbhargabeli.Text)
            hitungmodal()
        End If
    End Sub
    Sub hitungprofitcash()
        tbkeuntungan.Text = FormatNumber(Val(tbhargajual.Text.Replace(".", "")) - Val(tbmodal.Text.Replace(".", "")), 0)
        tbpersentase.Text = FormatNumber(Val(tbkeuntungan.Text.Replace(".", "")) / 2, 0)
    End Sub
    Private Sub tbhargajual_TextChanged(sender As Object, e As EventArgs) Handles tbhargajual.TextChanged
        If Len(tbhargajual.Text) > 0 Then
            tbhargajual.Text = FormatNumber(tbhargajual.Text, 0)
            tbhargajual.SelectionStart = Len(tbhargajual.Text)
            total = Val(tbhargajual.Text.Replace(".", ""))
            hitungprofitcash()
        End If
    End Sub
    Sub hitungprofitkredit()
        tbtotal.Text = FormatNumber(Val(tbuangmuka.Text.Replace(".", "")) + Val(tbcair.Text.Replace(".", "")) + Val(tbrefund.Text.Replace(".", "")), 0)
        tbkeuntungan.Text = FormatNumber(Val(tbtotal.Text.Replace(".", "")) - Val(tbmodal.Text.Replace(".", "")), 0)
        tbpersentase.Text = FormatNumber(Val(tbkeuntungan.Text.Replace(".", "")) / 2, 0)
    End Sub

    Private Sub tbmodal_TextChanged(sender As Object, e As EventArgs) Handles tbmodal.TextChanged
        If cbcarabayar.Text = "CASH" Then
            hitungprofitcash()
        ElseIf cbcarabayar.Text = "KREDIT" Then
            hitungprofitkredit()
        End If
    End Sub

    Private Sub tbuangmuka_TextChanged(sender As Object, e As EventArgs) Handles tbuangmuka.TextChanged
        If Len(tbuangmuka.Text) > 0 Then
            tbuangmuka.Text = FormatNumber(tbuangmuka.Text, 0)
            tbuangmuka.SelectionStart = Len(tbuangmuka.Text)
            hitungprofitkredit()
        End If
    End Sub

    Private Sub tbcair_TextChanged(sender As Object, e As EventArgs) Handles tbcair.TextChanged
        If Len(tbcair.Text) > 0 Then
            tbcair.Text = FormatNumber(tbcair.Text, 0)
            tbcair.SelectionStart = Len(tbcair.Text)
            hitungprofitkredit()
        End If
    End Sub

    Private Sub tbrefund_TextChanged(sender As Object, e As EventArgs) Handles tbrefund.TextChanged
        If Len(tbrefund.Text) > 0 Then
            tbrefund.Text = FormatNumber(tbrefund.Text, 0)
            tbrefund.SelectionStart = Len(tbrefund.Text)
            hitungprofitkredit()
        End If
    End Sub

    Private Sub tbtotal_TextChanged(sender As Object, e As EventArgs) Handles tbtotal.TextChanged
        total = Val(tbtotal.Text.Replace(".", ""))
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        mode = "edit"
        modesimpan()
        gbmaintenance.Enabled = True
        tbnopol.Focus()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim nhps As Integer
        nhps = MsgBox("Yakin hapus data ini ?", 48 + 4 + 256, "Konfirmasi")
        If nhps = 6 Then
            queryhapus()
            reset()
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        reset()
    End Sub

    Private Sub gbinfokendaraan_EnabledChanged(sender As Object, e As EventArgs) Handles gbinfokendaraan.EnabledChanged
        resetmt()
    End Sub

    Private Sub btnmttambah_Click(sender As Object, e As EventArgs) Handles btnmttambah.Click
        If btnmttambah.Text = "Tambah" Then
            mode_mt = "tambah"
            modesimpanmt()
            bersihmt()
        Else
            If tbdeskripsi.Text = "" Or tbnominal.Text = "" Then
                MsgBox("Lengkapi data yang kosong!", 16, "Informasi")
            Else
                If mode_mt = "tambah" Then
                    querytambahmt()
                    resetmt()
                Else
                    queryeditmt()
                    resetmt()
                End If
            End If
        End If
    End Sub

    Private Sub btnmtbatal_Click(sender As Object, e As EventArgs) Handles btnmtbatal.Click
        resetmt()
    End Sub

    Private Sub dgvmaintenance_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmaintenance.CellDoubleClick
        resetmt()
        gridmttotextbox()
        btnmttambah.Enabled = False
        btnmtedit.Enabled = True
        btnmthapus.Enabled = True
    End Sub

    Private Sub btnmtedit_Click(sender As Object, e As EventArgs) Handles btnmtedit.Click
        mode_mt = "edit"
        modesimpanmt()
        tbdeskripsi.Focus()
    End Sub

    Private Sub btnmthapus_Click(sender As Object, e As EventArgs) Handles btnmthapus.Click
        Dim nhps As Integer
        nhps = MsgBox("Yakin hapus data ini ?", 48 + 4 + 256, "Konfirmasi")
        If nhps = 6 Then
            queryhapusmt()
            resetmt()
        End If
    End Sub

    Private Sub tbnominal_TextChanged(sender As Object, e As EventArgs) Handles tbnominal.TextChanged
        If Len(tbnominal.Text) > 0 Then
            tbnominal.Text = FormatNumber(tbnominal.Text, 0)
            tbnominal.SelectionStart = Len(tbnominal.Text)
        End If
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        If cbcarabayar.Text = "CASH" Then
            FormViewCR.CetakKendaraanCash()
        Else
            FormViewCR.CetakKendaraanKredit()
        End If
        FormViewCR.ShowDialog()
    End Sub

    Private Sub tbcari_TextChanged(sender As Object, e As EventArgs) Handles tbcari.TextChanged
        Dim query As String = "SELECT * FROM tbl_kendaraan WHERE (nopol LIKE '%" & tbcari.Text & "%' OR " _
                            & "merk_tipe LIKE '%" & tbcari.Text & "%') ORDER BY status ASC"
        Dim da As New OleDbDataAdapter(query, Conn)
        Dim ds As New DataSet()
        With dgvkendaraan
            If da.Fill(ds) Then
                .DataSource = ds.Tables(0)
                .Refresh()
            Else
                .DataSource = Nothing
            End If
            If .RowCount > 0 Then
                juduldgvkendaraan()
            End If
        End With
    End Sub

    Private Sub tbcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcari.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbtahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbtahun.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbhargabeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbhargabeli.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbhargajual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbhargajual.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbnominal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnominal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbuangmuka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbuangmuka.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbcair_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcair.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbrefund_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbrefund.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
