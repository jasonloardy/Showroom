﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataKendaraanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSeluruhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKendaraanToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.SettingPasswordToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataKendaraanToolStripMenuItem
        '
        Me.DataKendaraanToolStripMenuItem.Name = "DataKendaraanToolStripMenuItem"
        Me.DataKendaraanToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.DataKendaraanToolStripMenuItem.Text = "Data Kendaraan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataStokToolStripMenuItem, Me.DataPenjualanToolStripMenuItem, Me.DataSeluruhToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.LaporanToolStripMenuItem.Text = "Data Laporan"
        '
        'DataStokToolStripMenuItem
        '
        Me.DataStokToolStripMenuItem.Name = "DataStokToolStripMenuItem"
        Me.DataStokToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DataStokToolStripMenuItem.Text = "Data Stok"
        '
        'DataPenjualanToolStripMenuItem
        '
        Me.DataPenjualanToolStripMenuItem.Name = "DataPenjualanToolStripMenuItem"
        Me.DataPenjualanToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DataPenjualanToolStripMenuItem.Text = "Data Penjualan"
        '
        'DataSeluruhToolStripMenuItem
        '
        Me.DataSeluruhToolStripMenuItem.Name = "DataSeluruhToolStripMenuItem"
        Me.DataSeluruhToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DataSeluruhToolStripMenuItem.Text = "Data Seluruh"
        '
        'SettingPasswordToolStripMenuItem
        '
        Me.SettingPasswordToolStripMenuItem.Name = "SettingPasswordToolStripMenuItem"
        Me.SettingPasswordToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.SettingPasswordToolStripMenuItem.Text = "Setting Password"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Showroom"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataKendaraanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataStokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSeluruhToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
