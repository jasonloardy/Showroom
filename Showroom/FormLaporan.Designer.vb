<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.rbperiode = New System.Windows.Forms.RadioButton()
        Me.cbtahun2 = New System.Windows.Forms.ComboBox()
        Me.rbtahun = New System.Windows.Forms.RadioButton()
        Me.cbtahun1 = New System.Windows.Forms.ComboBox()
        Me.cbbulan = New System.Windows.Forms.ComboBox()
        Me.rbbulan = New System.Windows.Forms.RadioButton()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp2)
        Me.GroupBox1.Controls.Add(Me.dtp1)
        Me.GroupBox1.Controls.Add(Me.rbperiode)
        Me.GroupBox1.Controls.Add(Me.cbtahun2)
        Me.GroupBox1.Controls.Add(Me.rbtahun)
        Me.GroupBox1.Controls.Add(Me.cbtahun1)
        Me.GroupBox1.Controls.Add(Me.cbbulan)
        Me.GroupBox1.Controls.Add(Me.rbbulan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 111)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilih Periode :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "-"
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(212, 24)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(90, 20)
        Me.dtp2.TabIndex = 9
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(102, 24)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(88, 20)
        Me.dtp1.TabIndex = 8
        '
        'rbperiode
        '
        Me.rbperiode.AutoSize = True
        Me.rbperiode.Checked = True
        Me.rbperiode.Location = New System.Drawing.Point(6, 24)
        Me.rbperiode.Name = "rbperiode"
        Me.rbperiode.Size = New System.Drawing.Size(67, 17)
        Me.rbperiode.TabIndex = 7
        Me.rbperiode.TabStop = True
        Me.rbperiode.Text = "Periode :"
        Me.rbperiode.UseVisualStyleBackColor = True
        '
        'cbtahun2
        '
        Me.cbtahun2.FormattingEnabled = True
        Me.cbtahun2.Location = New System.Drawing.Point(102, 76)
        Me.cbtahun2.Name = "cbtahun2"
        Me.cbtahun2.Size = New System.Drawing.Size(73, 21)
        Me.cbtahun2.TabIndex = 6
        '
        'rbtahun
        '
        Me.rbtahun.AutoSize = True
        Me.rbtahun.Location = New System.Drawing.Point(6, 77)
        Me.rbtahun.Name = "rbtahun"
        Me.rbtahun.Size = New System.Drawing.Size(74, 17)
        Me.rbtahun.TabIndex = 5
        Me.rbtahun.Text = "Tahunan :"
        Me.rbtahun.UseVisualStyleBackColor = True
        '
        'cbtahun1
        '
        Me.cbtahun1.FormattingEnabled = True
        Me.cbtahun1.Location = New System.Drawing.Point(102, 50)
        Me.cbtahun1.Name = "cbtahun1"
        Me.cbtahun1.Size = New System.Drawing.Size(73, 21)
        Me.cbtahun1.TabIndex = 4
        '
        'cbbulan
        '
        Me.cbbulan.DisplayMember = "asd"
        Me.cbbulan.FormattingEnabled = True
        Me.cbbulan.Location = New System.Drawing.Point(181, 50)
        Me.cbbulan.Name = "cbbulan"
        Me.cbbulan.Size = New System.Drawing.Size(121, 21)
        Me.cbbulan.TabIndex = 3
        Me.cbbulan.ValueMember = "1"
        '
        'rbbulan
        '
        Me.rbbulan.AutoSize = True
        Me.rbbulan.Location = New System.Drawing.Point(6, 50)
        Me.rbbulan.Name = "rbbulan"
        Me.rbbulan.Size = New System.Drawing.Size(70, 17)
        Me.rbbulan.TabIndex = 2
        Me.rbbulan.Text = "Bulanan :"
        Me.rbbulan.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.Image = CType(resources.GetObject("btncetak.Image"), System.Drawing.Image)
        Me.btncetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncetak.Location = New System.Drawing.Point(249, 129)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(75, 75)
        Me.btncetak.TabIndex = 5
        Me.btncetak.Text = "Cetak"
        Me.btncetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 211)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbperiode As System.Windows.Forms.RadioButton
    Friend WithEvents cbtahun2 As System.Windows.Forms.ComboBox
    Friend WithEvents rbtahun As System.Windows.Forms.RadioButton
    Friend WithEvents cbtahun1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbbulan As System.Windows.Forms.ComboBox
    Friend WithEvents rbbulan As System.Windows.Forms.RadioButton
    Friend WithEvents btncetak As System.Windows.Forms.Button
End Class
