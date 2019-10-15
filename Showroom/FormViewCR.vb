Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class FormViewCR
    Dim cryReport As New ReportDocument
    Dim RepLocation = Path.GetFullPath( _
            Path.Combine(Application.StartupPath, "..\.."))
    Sub CetakKendaraanCash()
        cryReport.Load(RepLocation & "\CRKendaraanCash.rpt")
        cryReport.RecordSelectionFormula = "{tbl_kendaraan.id_kendaraan} = " & FormKendaraan.id_data
        CrystalReportViewer1.ReportSource = cryReport
        cryReport.Refresh()
    End Sub
    Sub CetakKendaraanKredit()
        cryReport.Load(RepLocation & "\CRKendaraanKredit.rpt")
        cryReport.RecordSelectionFormula = "{tbl_kendaraan.id_kendaraan} = " & FormKendaraan.id_data
        CrystalReportViewer1.ReportSource = cryReport
        cryReport.Refresh()
    End Sub
    Sub CetakRekapPeriode()
        cryReport.Load(RepLocation & "\CRRekap.rpt")
        cryReport.Refresh()
        cryReport.SetParameterValue("periode", Format(FormLapPenjualan.dtp1.Value, "yyyy-MM-dd") & " s/d " & Format(FormLapPenjualan.dtp2.Value, "yyyy-MM-dd"))
        cryReport.RecordSelectionFormula = "{tbl_kendaraan.tgl_jual} >= Date('" & Format(FormLapPenjualan.dtp1.Value, "yyyy-MM-dd") & "') and " _
                                         & "{tbl_kendaraan.tgl_jual} <= Date('" & Format(FormLapPenjualan.dtp2.Value, "yyyy-MM-dd") & "') and " _
                                         & "{tbl_kendaraan.total} > $0"
        CrystalReportViewer1.ReportSource = cryReport
    End Sub
    Sub CetakRekapBulanan()
        cryReport.Load(RepLocation & "\CRRekap.rpt")
        cryReport.Refresh()
        cryReport.SetParameterValue("periode", "BULAN " & FormLapPenjualan.cbbulan.Text & " - " & FormLapPenjualan.cbtahun1.Text)
        cryReport.RecordSelectionFormula = "Month({tbl_kendaraan.tgl_jual}) = " & FormLapPenjualan.cbbulan.SelectedValue & " and " _
                                         & "Year({tbl_kendaraan.tgl_jual}) = " & FormLapPenjualan.cbtahun1.SelectedValue & " and " _
                                         & "{tbl_kendaraan.total} > $0"
        CrystalReportViewer1.ReportSource = cryReport
    End Sub
    Sub CetakRekapTahunan()
        cryReport.Load(RepLocation & "\CRRekap.rpt")
        cryReport.Refresh()
        cryReport.SetParameterValue("periode", "TAHUN " & FormLapPenjualan.cbtahun2.SelectedValue)
        cryReport.RecordSelectionFormula = "Year({tbl_kendaraan.tgl_jual}) = " & FormLapPenjualan.cbtahun2.SelectedValue & " and " _
                                         & "{tbl_kendaraan.total} > $0"
        CrystalReportViewer1.ReportSource = cryReport
    End Sub
    Sub CetakSeluruhPeriode()
        cryReport.Load(RepLocation & "\CRSeluruh.rpt")
        cryReport.Refresh()
        cryReport.SetParameterValue("periode", Format(FormLapSeluruh.dtp1.Value, "yyyy-MM-dd") & " s/d " & Format(FormLapSeluruh.dtp2.Value, "yyyy-MM-dd"))
        cryReport.RecordSelectionFormula = "{tbl_kendaraan.tgl_beli} >= Date('" & Format(FormLapSeluruh.dtp1.Value, "yyyy-MM-dd") & "') and " _
                                         & "{tbl_kendaraan.tgl_beli} <= Date('" & Format(FormLapSeluruh.dtp2.Value, "yyyy-MM-dd") & "')"
        CrystalReportViewer1.ReportSource = cryReport
    End Sub
    Sub CetakSeluruhBulanan()
        cryReport.Load(RepLocation & "\CRSeluruh.rpt")
        cryReport.Refresh()
        cryReport.SetParameterValue("periode", "BULAN " & FormLapSeluruh.cbbulan.Text & " - " & FormLapSeluruh.cbtahun1.Text)
        cryReport.RecordSelectionFormula = "Month({tbl_kendaraan.tgl_beli}) = " & FormLapSeluruh.cbbulan.SelectedValue & " and " _
                                         & "Year({tbl_kendaraan.tgl_beli}) = " & FormLapSeluruh.cbtahun1.SelectedValue
        CrystalReportViewer1.ReportSource = cryReport
    End Sub
    Sub CetakSeluruhTahunan()
        cryReport.Load(RepLocation & "\CRSeluruh.rpt")
        cryReport.Refresh()
        cryReport.SetParameterValue("periode", "TAHUN " & FormLapSeluruh.cbtahun2.SelectedValue)
        cryReport.RecordSelectionFormula = "Year({tbl_kendaraan.tgl_beli}) = " & FormLapSeluruh.cbtahun2.SelectedValue
        CrystalReportViewer1.ReportSource = cryReport
    End Sub
    Sub CetakStok()
        cryReport.Load(RepLocation & "\CRStok.rpt")
        cryReport.RecordSelectionFormula = "{tbl_kendaraan.total} = $0"
        CrystalReportViewer1.ReportSource = cryReport
        cryReport.Refresh()
    End Sub
End Class