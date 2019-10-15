<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKendaraan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKendaraan))
        Me.gbdaftarkendaraan = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.dgvkendaraan = New System.Windows.Forms.DataGridView()
        Me.gbpenjualan = New System.Windows.Forms.GroupBox()
        Me.panelcash = New System.Windows.Forms.Panel()
        Me.lblhrgjual = New System.Windows.Forms.Label()
        Me.tbhargajual = New System.Windows.Forms.TextBox()
        Me.panelkredit = New System.Windows.Forms.Panel()
        Me.lblleasing = New System.Windows.Forms.Label()
        Me.tbleasing = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.lblrefund = New System.Windows.Forms.Label()
        Me.tbrefund = New System.Windows.Forms.TextBox()
        Me.lblcair = New System.Windows.Forms.Label()
        Me.tbcair = New System.Windows.Forms.TextBox()
        Me.lbluangmuka = New System.Windows.Forms.Label()
        Me.tbuangmuka = New System.Windows.Forms.TextBox()
        Me.dtptgljual = New System.Windows.Forms.DateTimePicker()
        Me.chktransaksi = New System.Windows.Forms.CheckBox()
        Me.panelprofit = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbpersentase = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbkeuntungan = New System.Windows.Forms.TextBox()
        Me.tbmodal = New System.Windows.Forms.TextBox()
        Me.cbcarabayar = New System.Windows.Forms.ComboBox()
        Me.lblcarabayar = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbmaintenance = New System.Windows.Forms.GroupBox()
        Me.lbltotalmt = New System.Windows.Forms.Label()
        Me.btnmtbatal = New System.Windows.Forms.Button()
        Me.btnmthapus = New System.Windows.Forms.Button()
        Me.btnmtedit = New System.Windows.Forms.Button()
        Me.btnmttambah = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbnominal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvmaintenance = New System.Windows.Forms.DataGridView()
        Me.tbdeskripsi = New System.Windows.Forms.TextBox()
        Me.gbinfokendaraan = New System.Windows.Forms.GroupBox()
        Me.dtptglpembelian = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbstatusbpkb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbhargabeli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbvendor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbdatapenjual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbwarna = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbtahun = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbmerktipe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbnopol = New System.Windows.Forms.TextBox()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.gbdaftarkendaraan.SuspendLayout()
        CType(Me.dgvkendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbpenjualan.SuspendLayout()
        Me.panelcash.SuspendLayout()
        Me.panelkredit.SuspendLayout()
        Me.panelprofit.SuspendLayout()
        Me.gbmaintenance.SuspendLayout()
        CType(Me.dgvmaintenance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbinfokendaraan.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbdaftarkendaraan
        '
        Me.gbdaftarkendaraan.Controls.Add(Me.Label1)
        Me.gbdaftarkendaraan.Controls.Add(Me.tbcari)
        Me.gbdaftarkendaraan.Controls.Add(Me.dgvkendaraan)
        Me.gbdaftarkendaraan.Location = New System.Drawing.Point(12, 12)
        Me.gbdaftarkendaraan.Name = "gbdaftarkendaraan"
        Me.gbdaftarkendaraan.Size = New System.Drawing.Size(562, 637)
        Me.gbdaftarkendaraan.TabIndex = 0
        Me.gbdaftarkendaraan.TabStop = False
        Me.gbdaftarkendaraan.Text = "Daftar Kendaraan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari No. Polisi / Merek Tipe :"
        '
        'tbcari
        '
        Me.tbcari.Location = New System.Drawing.Point(155, 24)
        Me.tbcari.MaxLength = 64
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(401, 20)
        Me.tbcari.TabIndex = 0
        '
        'dgvkendaraan
        '
        Me.dgvkendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkendaraan.Location = New System.Drawing.Point(6, 55)
        Me.dgvkendaraan.Name = "dgvkendaraan"
        Me.dgvkendaraan.Size = New System.Drawing.Size(550, 576)
        Me.dgvkendaraan.TabIndex = 1
        '
        'gbpenjualan
        '
        Me.gbpenjualan.Controls.Add(Me.panelcash)
        Me.gbpenjualan.Controls.Add(Me.panelkredit)
        Me.gbpenjualan.Controls.Add(Me.dtptgljual)
        Me.gbpenjualan.Controls.Add(Me.chktransaksi)
        Me.gbpenjualan.Controls.Add(Me.panelprofit)
        Me.gbpenjualan.Controls.Add(Me.tbmodal)
        Me.gbpenjualan.Controls.Add(Me.cbcarabayar)
        Me.gbpenjualan.Controls.Add(Me.lblcarabayar)
        Me.gbpenjualan.Controls.Add(Me.Label14)
        Me.gbpenjualan.Location = New System.Drawing.Point(580, 323)
        Me.gbpenjualan.Name = "gbpenjualan"
        Me.gbpenjualan.Size = New System.Drawing.Size(692, 245)
        Me.gbpenjualan.TabIndex = 3
        Me.gbpenjualan.TabStop = False
        Me.gbpenjualan.Text = "Transaksi Penjualan"
        '
        'panelcash
        '
        Me.panelcash.Controls.Add(Me.lblhrgjual)
        Me.panelcash.Controls.Add(Me.tbhargajual)
        Me.panelcash.Location = New System.Drawing.Point(3, 79)
        Me.panelcash.Name = "panelcash"
        Me.panelcash.Size = New System.Drawing.Size(333, 39)
        Me.panelcash.TabIndex = 37
        '
        'lblhrgjual
        '
        Me.lblhrgjual.AutoSize = True
        Me.lblhrgjual.Location = New System.Drawing.Point(7, 11)
        Me.lblhrgjual.Name = "lblhrgjual"
        Me.lblhrgjual.Size = New System.Drawing.Size(64, 13)
        Me.lblhrgjual.TabIndex = 35
        Me.lblhrgjual.Text = "Harga Jual :"
        '
        'tbhargajual
        '
        Me.tbhargajual.Location = New System.Drawing.Point(114, 8)
        Me.tbhargajual.MaxLength = 12
        Me.tbhargajual.Name = "tbhargajual"
        Me.tbhargajual.Size = New System.Drawing.Size(200, 20)
        Me.tbhargajual.TabIndex = 4
        '
        'panelkredit
        '
        Me.panelkredit.Controls.Add(Me.lblleasing)
        Me.panelkredit.Controls.Add(Me.tbleasing)
        Me.panelkredit.Controls.Add(Me.lbltotal)
        Me.panelkredit.Controls.Add(Me.tbtotal)
        Me.panelkredit.Controls.Add(Me.lblrefund)
        Me.panelkredit.Controls.Add(Me.tbrefund)
        Me.panelkredit.Controls.Add(Me.lblcair)
        Me.panelkredit.Controls.Add(Me.tbcair)
        Me.panelkredit.Controls.Add(Me.lbluangmuka)
        Me.panelkredit.Controls.Add(Me.tbuangmuka)
        Me.panelkredit.Location = New System.Drawing.Point(368, 50)
        Me.panelkredit.Name = "panelkredit"
        Me.panelkredit.Size = New System.Drawing.Size(323, 158)
        Me.panelkredit.TabIndex = 36
        '
        'lblleasing
        '
        Me.lblleasing.AutoSize = True
        Me.lblleasing.Location = New System.Drawing.Point(3, 9)
        Me.lblleasing.Name = "lblleasing"
        Me.lblleasing.Size = New System.Drawing.Size(50, 13)
        Me.lblleasing.TabIndex = 33
        Me.lblleasing.Text = "Leasing :"
        '
        'tbleasing
        '
        Me.tbleasing.Location = New System.Drawing.Point(106, 6)
        Me.tbleasing.MaxLength = 32
        Me.tbleasing.Name = "tbleasing"
        Me.tbleasing.Size = New System.Drawing.Size(200, 20)
        Me.tbleasing.TabIndex = 5
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(3, 133)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(37, 13)
        Me.lbltotal.TabIndex = 27
        Me.lbltotal.Text = "Total :"
        '
        'tbtotal
        '
        Me.tbtotal.Enabled = False
        Me.tbtotal.Location = New System.Drawing.Point(106, 130)
        Me.tbtotal.MaxLength = 12
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.Size = New System.Drawing.Size(200, 20)
        Me.tbtotal.TabIndex = 9
        '
        'lblrefund
        '
        Me.lblrefund.AutoSize = True
        Me.lblrefund.Location = New System.Drawing.Point(3, 102)
        Me.lblrefund.Name = "lblrefund"
        Me.lblrefund.Size = New System.Drawing.Size(48, 13)
        Me.lblrefund.TabIndex = 25
        Me.lblrefund.Text = "Refund :"
        '
        'tbrefund
        '
        Me.tbrefund.Location = New System.Drawing.Point(106, 99)
        Me.tbrefund.MaxLength = 12
        Me.tbrefund.Name = "tbrefund"
        Me.tbrefund.Size = New System.Drawing.Size(200, 20)
        Me.tbrefund.TabIndex = 8
        '
        'lblcair
        '
        Me.lblcair.AutoSize = True
        Me.lblcair.Location = New System.Drawing.Point(3, 71)
        Me.lblcair.Name = "lblcair"
        Me.lblcair.Size = New System.Drawing.Size(31, 13)
        Me.lblcair.TabIndex = 23
        Me.lblcair.Text = "Cair :"
        '
        'tbcair
        '
        Me.tbcair.Location = New System.Drawing.Point(106, 68)
        Me.tbcair.MaxLength = 12
        Me.tbcair.Name = "tbcair"
        Me.tbcair.Size = New System.Drawing.Size(200, 20)
        Me.tbcair.TabIndex = 7
        '
        'lbluangmuka
        '
        Me.lbluangmuka.AutoSize = True
        Me.lbluangmuka.Location = New System.Drawing.Point(3, 40)
        Me.lbluangmuka.Name = "lbluangmuka"
        Me.lbluangmuka.Size = New System.Drawing.Size(69, 13)
        Me.lbluangmuka.TabIndex = 20
        Me.lbluangmuka.Text = "Uang Muka :"
        '
        'tbuangmuka
        '
        Me.tbuangmuka.Location = New System.Drawing.Point(106, 37)
        Me.tbuangmuka.MaxLength = 12
        Me.tbuangmuka.Name = "tbuangmuka"
        Me.tbuangmuka.Size = New System.Drawing.Size(200, 20)
        Me.tbuangmuka.TabIndex = 6
        '
        'dtptgljual
        '
        Me.dtptgljual.Location = New System.Drawing.Point(474, 24)
        Me.dtptgljual.Name = "dtptgljual"
        Me.dtptgljual.Size = New System.Drawing.Size(200, 20)
        Me.dtptgljual.TabIndex = 2
        '
        'chktransaksi
        '
        Me.chktransaksi.AutoSize = True
        Me.chktransaksi.Location = New System.Drawing.Point(374, 26)
        Me.chktransaksi.Name = "chktransaksi"
        Me.chktransaksi.Size = New System.Drawing.Size(72, 17)
        Me.chktransaksi.TabIndex = 1
        Me.chktransaksi.Text = "Transaksi"
        Me.chktransaksi.UseVisualStyleBackColor = True
        '
        'panelprofit
        '
        Me.panelprofit.BackColor = System.Drawing.Color.LimeGreen
        Me.panelprofit.Controls.Add(Me.Label23)
        Me.panelprofit.Controls.Add(Me.tbpersentase)
        Me.panelprofit.Controls.Add(Me.Label20)
        Me.panelprofit.Controls.Add(Me.tbkeuntungan)
        Me.panelprofit.Location = New System.Drawing.Point(0, 208)
        Me.panelprofit.Name = "panelprofit"
        Me.panelprofit.Size = New System.Drawing.Size(692, 37)
        Me.panelprofit.TabIndex = 10
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(371, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Persentase :"
        '
        'tbpersentase
        '
        Me.tbpersentase.Enabled = False
        Me.tbpersentase.Location = New System.Drawing.Point(474, 9)
        Me.tbpersentase.MaxLength = 12
        Me.tbpersentase.Name = "tbpersentase"
        Me.tbpersentase.Size = New System.Drawing.Size(200, 20)
        Me.tbpersentase.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Keuntungan :"
        '
        'tbkeuntungan
        '
        Me.tbkeuntungan.Enabled = False
        Me.tbkeuntungan.Location = New System.Drawing.Point(117, 9)
        Me.tbkeuntungan.MaxLength = 12
        Me.tbkeuntungan.Name = "tbkeuntungan"
        Me.tbkeuntungan.Size = New System.Drawing.Size(200, 20)
        Me.tbkeuntungan.TabIndex = 0
        '
        'tbmodal
        '
        Me.tbmodal.Enabled = False
        Me.tbmodal.Location = New System.Drawing.Point(117, 24)
        Me.tbmodal.MaxLength = 12
        Me.tbmodal.Name = "tbmodal"
        Me.tbmodal.Size = New System.Drawing.Size(200, 20)
        Me.tbmodal.TabIndex = 0
        '
        'cbcarabayar
        '
        Me.cbcarabayar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcarabayar.FormattingEnabled = True
        Me.cbcarabayar.Items.AddRange(New Object() {"CASH", "KREDIT"})
        Me.cbcarabayar.Location = New System.Drawing.Point(117, 56)
        Me.cbcarabayar.Name = "cbcarabayar"
        Me.cbcarabayar.Size = New System.Drawing.Size(154, 21)
        Me.cbcarabayar.TabIndex = 3
        '
        'lblcarabayar
        '
        Me.lblcarabayar.AutoSize = True
        Me.lblcarabayar.Location = New System.Drawing.Point(10, 59)
        Me.lblcarabayar.Name = "lblcarabayar"
        Me.lblcarabayar.Size = New System.Drawing.Size(97, 13)
        Me.lblcarabayar.TabIndex = 20
        Me.lblcarabayar.Text = "Cara Pembayaran :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Total Modal :"
        '
        'gbmaintenance
        '
        Me.gbmaintenance.Controls.Add(Me.lbltotalmt)
        Me.gbmaintenance.Controls.Add(Me.btnmtbatal)
        Me.gbmaintenance.Controls.Add(Me.btnmthapus)
        Me.gbmaintenance.Controls.Add(Me.btnmtedit)
        Me.gbmaintenance.Controls.Add(Me.btnmttambah)
        Me.gbmaintenance.Controls.Add(Me.Label12)
        Me.gbmaintenance.Controls.Add(Me.tbnominal)
        Me.gbmaintenance.Controls.Add(Me.Label11)
        Me.gbmaintenance.Controls.Add(Me.dgvmaintenance)
        Me.gbmaintenance.Controls.Add(Me.tbdeskripsi)
        Me.gbmaintenance.Location = New System.Drawing.Point(957, 12)
        Me.gbmaintenance.Name = "gbmaintenance"
        Me.gbmaintenance.Size = New System.Drawing.Size(315, 305)
        Me.gbmaintenance.TabIndex = 2
        Me.gbmaintenance.TabStop = False
        Me.gbmaintenance.Text = "Maintenance"
        '
        'lbltotalmt
        '
        Me.lbltotalmt.Location = New System.Drawing.Point(6, 275)
        Me.lbltotalmt.Name = "lbltotalmt"
        Me.lbltotalmt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltotalmt.Size = New System.Drawing.Size(303, 13)
        Me.lbltotalmt.TabIndex = 26
        Me.lbltotalmt.Text = "Total Maintenance : 0"
        Me.lbltotalmt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnmtbatal
        '
        Me.btnmtbatal.Location = New System.Drawing.Point(236, 84)
        Me.btnmtbatal.Name = "btnmtbatal"
        Me.btnmtbatal.Size = New System.Drawing.Size(70, 23)
        Me.btnmtbatal.TabIndex = 5
        Me.btnmtbatal.Text = "Batal"
        Me.btnmtbatal.UseVisualStyleBackColor = True
        '
        'btnmthapus
        '
        Me.btnmthapus.Location = New System.Drawing.Point(160, 84)
        Me.btnmthapus.Name = "btnmthapus"
        Me.btnmthapus.Size = New System.Drawing.Size(70, 23)
        Me.btnmthapus.TabIndex = 4
        Me.btnmthapus.Text = "Hapus"
        Me.btnmthapus.UseVisualStyleBackColor = True
        '
        'btnmtedit
        '
        Me.btnmtedit.Location = New System.Drawing.Point(84, 84)
        Me.btnmtedit.Name = "btnmtedit"
        Me.btnmtedit.Size = New System.Drawing.Size(70, 23)
        Me.btnmtedit.TabIndex = 3
        Me.btnmtedit.Text = "Edit"
        Me.btnmtedit.UseVisualStyleBackColor = True
        '
        'btnmttambah
        '
        Me.btnmttambah.Location = New System.Drawing.Point(8, 84)
        Me.btnmttambah.Name = "btnmttambah"
        Me.btnmttambah.Size = New System.Drawing.Size(70, 23)
        Me.btnmttambah.TabIndex = 2
        Me.btnmttambah.Text = "Tambah"
        Me.btnmttambah.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Nominal :"
        '
        'tbnominal
        '
        Me.tbnominal.Location = New System.Drawing.Point(68, 55)
        Me.tbnominal.MaxLength = 12
        Me.tbnominal.Name = "tbnominal"
        Me.tbnominal.Size = New System.Drawing.Size(241, 20)
        Me.tbnominal.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Deskripsi :"
        '
        'dgvmaintenance
        '
        Me.dgvmaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmaintenance.Location = New System.Drawing.Point(6, 117)
        Me.dgvmaintenance.Name = "dgvmaintenance"
        Me.dgvmaintenance.Size = New System.Drawing.Size(303, 144)
        Me.dgvmaintenance.TabIndex = 6
        '
        'tbdeskripsi
        '
        Me.tbdeskripsi.Location = New System.Drawing.Point(68, 24)
        Me.tbdeskripsi.MaxLength = 32
        Me.tbdeskripsi.Name = "tbdeskripsi"
        Me.tbdeskripsi.Size = New System.Drawing.Size(241, 20)
        Me.tbdeskripsi.TabIndex = 0
        '
        'gbinfokendaraan
        '
        Me.gbinfokendaraan.Controls.Add(Me.dtptglpembelian)
        Me.gbinfokendaraan.Controls.Add(Me.Label10)
        Me.gbinfokendaraan.Controls.Add(Me.tbstatusbpkb)
        Me.gbinfokendaraan.Controls.Add(Me.Label9)
        Me.gbinfokendaraan.Controls.Add(Me.tbhargabeli)
        Me.gbinfokendaraan.Controls.Add(Me.Label8)
        Me.gbinfokendaraan.Controls.Add(Me.Label7)
        Me.gbinfokendaraan.Controls.Add(Me.tbvendor)
        Me.gbinfokendaraan.Controls.Add(Me.Label6)
        Me.gbinfokendaraan.Controls.Add(Me.tbdatapenjual)
        Me.gbinfokendaraan.Controls.Add(Me.Label5)
        Me.gbinfokendaraan.Controls.Add(Me.tbwarna)
        Me.gbinfokendaraan.Controls.Add(Me.Label4)
        Me.gbinfokendaraan.Controls.Add(Me.tbtahun)
        Me.gbinfokendaraan.Controls.Add(Me.Label3)
        Me.gbinfokendaraan.Controls.Add(Me.tbmerktipe)
        Me.gbinfokendaraan.Controls.Add(Me.Label2)
        Me.gbinfokendaraan.Controls.Add(Me.tbnopol)
        Me.gbinfokendaraan.Location = New System.Drawing.Point(584, 12)
        Me.gbinfokendaraan.Name = "gbinfokendaraan"
        Me.gbinfokendaraan.Size = New System.Drawing.Size(367, 305)
        Me.gbinfokendaraan.TabIndex = 1
        Me.gbinfokendaraan.TabStop = False
        Me.gbinfokendaraan.Text = "Informasi Kendaraan"
        '
        'dtptglpembelian
        '
        Me.dtptglpembelian.Location = New System.Drawing.Point(109, 210)
        Me.dtptglpembelian.Name = "dtptglpembelian"
        Me.dtptglpembelian.Size = New System.Drawing.Size(200, 20)
        Me.dtptglpembelian.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Status BPKB :"
        '
        'tbstatusbpkb
        '
        Me.tbstatusbpkb.Location = New System.Drawing.Point(109, 272)
        Me.tbstatusbpkb.MaxLength = 32
        Me.tbstatusbpkb.Name = "tbstatusbpkb"
        Me.tbstatusbpkb.Size = New System.Drawing.Size(250, 20)
        Me.tbstatusbpkb.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Harga Beli :"
        '
        'tbhargabeli
        '
        Me.tbhargabeli.Location = New System.Drawing.Point(109, 241)
        Me.tbhargabeli.MaxLength = 12
        Me.tbhargabeli.Name = "tbhargabeli"
        Me.tbhargabeli.Size = New System.Drawing.Size(200, 20)
        Me.tbhargabeli.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tgl. Pembelian :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Vendor :"
        '
        'tbvendor
        '
        Me.tbvendor.Location = New System.Drawing.Point(109, 179)
        Me.tbvendor.MaxLength = 32
        Me.tbvendor.Name = "tbvendor"
        Me.tbvendor.Size = New System.Drawing.Size(250, 20)
        Me.tbvendor.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Data Penjual :"
        '
        'tbdatapenjual
        '
        Me.tbdatapenjual.Location = New System.Drawing.Point(109, 148)
        Me.tbdatapenjual.MaxLength = 32
        Me.tbdatapenjual.Name = "tbdatapenjual"
        Me.tbdatapenjual.Size = New System.Drawing.Size(250, 20)
        Me.tbdatapenjual.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Warna :"
        '
        'tbwarna
        '
        Me.tbwarna.Location = New System.Drawing.Point(109, 117)
        Me.tbwarna.MaxLength = 16
        Me.tbwarna.Name = "tbwarna"
        Me.tbwarna.Size = New System.Drawing.Size(150, 20)
        Me.tbwarna.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tahun :"
        '
        'tbtahun
        '
        Me.tbtahun.Location = New System.Drawing.Point(109, 86)
        Me.tbtahun.MaxLength = 4
        Me.tbtahun.Name = "tbtahun"
        Me.tbtahun.Size = New System.Drawing.Size(97, 20)
        Me.tbtahun.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Merek / Tipe :"
        '
        'tbmerktipe
        '
        Me.tbmerktipe.Location = New System.Drawing.Point(109, 55)
        Me.tbmerktipe.MaxLength = 64
        Me.tbmerktipe.Name = "tbmerktipe"
        Me.tbmerktipe.Size = New System.Drawing.Size(250, 20)
        Me.tbmerktipe.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Polisi :"
        '
        'tbnopol
        '
        Me.tbnopol.Location = New System.Drawing.Point(109, 24)
        Me.tbnopol.MaxLength = 10
        Me.tbnopol.Name = "tbnopol"
        Me.tbnopol.Size = New System.Drawing.Size(97, 20)
        Me.tbnopol.TabIndex = 0
        '
        'btncetak
        '
        Me.btncetak.Image = CType(resources.GetObject("btncetak.Image"), System.Drawing.Image)
        Me.btncetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncetak.Location = New System.Drawing.Point(580, 574)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(75, 75)
        Me.btncetak.TabIndex = 4
        Me.btncetak.Text = "Cetak"
        Me.btncetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Image = CType(resources.GetObject("btnbatal.Image"), System.Drawing.Image)
        Me.btnbatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbatal.Location = New System.Drawing.Point(1197, 574)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 75)
        Me.btnbatal.TabIndex = 8
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnhapus.Location = New System.Drawing.Point(1116, 574)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 75)
        Me.btnhapus.TabIndex = 7
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnedit.Location = New System.Drawing.Point(1035, 574)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 75)
        Me.btnedit.TabIndex = 6
        Me.btnedit.Text = "Update"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Image = CType(resources.GetObject("btntambah.Image"), System.Drawing.Image)
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btntambah.Location = New System.Drawing.Point(954, 574)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 75)
        Me.btntambah.TabIndex = 5
        Me.btntambah.Text = "Tambah"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'FormKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.gbpenjualan)
        Me.Controls.Add(Me.gbmaintenance)
        Me.Controls.Add(Me.gbinfokendaraan)
        Me.Controls.Add(Me.gbdaftarkendaraan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Kendaraan"
        Me.gbdaftarkendaraan.ResumeLayout(False)
        Me.gbdaftarkendaraan.PerformLayout()
        CType(Me.dgvkendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbpenjualan.ResumeLayout(False)
        Me.gbpenjualan.PerformLayout()
        Me.panelcash.ResumeLayout(False)
        Me.panelcash.PerformLayout()
        Me.panelkredit.ResumeLayout(False)
        Me.panelkredit.PerformLayout()
        Me.panelprofit.ResumeLayout(False)
        Me.panelprofit.PerformLayout()
        Me.gbmaintenance.ResumeLayout(False)
        Me.gbmaintenance.PerformLayout()
        CType(Me.dgvmaintenance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbinfokendaraan.ResumeLayout(False)
        Me.gbinfokendaraan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbdaftarkendaraan As System.Windows.Forms.GroupBox
    Friend WithEvents dgvkendaraan As System.Windows.Forms.DataGridView
    Friend WithEvents gbpenjualan As System.Windows.Forms.GroupBox
    Friend WithEvents gbmaintenance As System.Windows.Forms.GroupBox
    Friend WithEvents gbinfokendaraan As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbcari As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbwarna As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbmerktipe As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbnopol As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbdatapenjual As System.Windows.Forms.TextBox
    Friend WithEvents btnmtbatal As System.Windows.Forms.Button
    Friend WithEvents btnmthapus As System.Windows.Forms.Button
    Friend WithEvents btnmtedit As System.Windows.Forms.Button
    Friend WithEvents btnmttambah As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbnominal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvmaintenance As System.Windows.Forms.DataGridView
    Friend WithEvents tbdeskripsi As System.Windows.Forms.TextBox
    Friend WithEvents dtptglpembelian As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbstatusbpkb As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbhargabeli As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbvendor As System.Windows.Forms.TextBox
    Friend WithEvents tbtahun As System.Windows.Forms.TextBox
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents lbltotalmt As System.Windows.Forms.Label
    Friend WithEvents lblhrgjual As System.Windows.Forms.Label
    Friend WithEvents tbhargajual As System.Windows.Forms.TextBox
    Friend WithEvents lblleasing As System.Windows.Forms.Label
    Friend WithEvents tbleasing As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbkeuntungan As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents tbtotal As System.Windows.Forms.TextBox
    Friend WithEvents lblrefund As System.Windows.Forms.Label
    Friend WithEvents tbrefund As System.Windows.Forms.TextBox
    Friend WithEvents lblcair As System.Windows.Forms.Label
    Friend WithEvents tbcair As System.Windows.Forms.TextBox
    Friend WithEvents lbluangmuka As System.Windows.Forms.Label
    Friend WithEvents cbcarabayar As System.Windows.Forms.ComboBox
    Friend WithEvents tbuangmuka As System.Windows.Forms.TextBox
    Friend WithEvents lblcarabayar As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbmodal As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tbpersentase As System.Windows.Forms.TextBox
    Friend WithEvents panelprofit As System.Windows.Forms.Panel
    Friend WithEvents chktransaksi As System.Windows.Forms.CheckBox
    Friend WithEvents dtptgljual As System.Windows.Forms.DateTimePicker
    Friend WithEvents panelkredit As System.Windows.Forms.Panel
    Friend WithEvents panelcash As System.Windows.Forms.Panel

End Class
