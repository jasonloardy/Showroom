<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPassword))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbpasslama = New System.Windows.Forms.TextBox()
        Me.tbpassbaru = New System.Windows.Forms.TextBox()
        Me.tbpassbaru2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbpassbaru2)
        Me.GroupBox1.Controls.Add(Me.tbpassbaru)
        Me.GroupBox1.Controls.Add(Me.tbpasslama)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ganti Password"
        '
        'tbpasslama
        '
        Me.tbpasslama.Location = New System.Drawing.Point(153, 24)
        Me.tbpasslama.MaxLength = 64
        Me.tbpasslama.Name = "tbpasslama"
        Me.tbpasslama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tbpasslama.Size = New System.Drawing.Size(201, 20)
        Me.tbpasslama.TabIndex = 0
        '
        'tbpassbaru
        '
        Me.tbpassbaru.Location = New System.Drawing.Point(153, 76)
        Me.tbpassbaru.MaxLength = 64
        Me.tbpassbaru.Name = "tbpassbaru"
        Me.tbpassbaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tbpassbaru.Size = New System.Drawing.Size(201, 20)
        Me.tbpassbaru.TabIndex = 1
        '
        'tbpassbaru2
        '
        Me.tbpassbaru2.Location = New System.Drawing.Point(153, 102)
        Me.tbpassbaru2.MaxLength = 64
        Me.tbpassbaru2.Name = "tbpassbaru2"
        Me.tbpassbaru2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tbpassbaru2.Size = New System.Drawing.Size(201, 20)
        Me.tbpassbaru2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Masukkan Password Lama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Masukkan Password Baru :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Konfirmasi Password Baru :"
        '
        'btnedit
        '
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnedit.Location = New System.Drawing.Point(297, 149)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 75)
        Me.btnedit.TabIndex = 7
        Me.btnedit.Text = "Update"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'FormPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 231)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbpassbaru2 As System.Windows.Forms.TextBox
    Friend WithEvents tbpassbaru As System.Windows.Forms.TextBox
    Friend WithEvents tbpasslama As System.Windows.Forms.TextBox
    Friend WithEvents btnedit As System.Windows.Forms.Button
End Class
