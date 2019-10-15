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
        cryReport.SetParameterValue("periode", Format(FormLaporan.dtp1.Value, "yyyy-MM-dd") & " s/d " & Format(FormLaporan.dtp2.Value, "yyyy-MM-dd"))
        cryReport.RecordSelectionFormula = "{tbl_kendaraan.tgl_jual} >= Date('" & Format(FormLaporan.dtp1.Value, "yyyy-MM-dd") & "') and " _
                                         & "{tbl_kendaraan.tgl_jual} <= Date('" & Format(FormLaporan.dtp2.Value, "yyyy-MM-dd") & "') and " _
                                         & "{tbl_kendaraan.total} > $0"
        CrystalReportViewer1.ReportSource = cryReport
    End Sub
    Sub CetakRekapBulanan()
        cryReport.Load(RepLocation & "\CRRekap.rpt")
        cryReport.Refresh()
        cryReport.SetParameterValue("periode", "Bulan " & FormLaporan.cbbulan.Text & " - " & FormLaporan.cbtahun1.Text)
        cryReport.RecordSelectionFormula = "Month({tbl_kendaraan.tgl_jual}) = " & FormLaporan.cbbulan.SelectedValue & " and " _
                                         & "Year({tbl_kendaraan.tgl_jual}) = " & FormLaporan.cbtahun1.SelectedValue & " and " _
                                         & "{tbl_kendaraan.total} > $0"
        CrystalReportViewer1.ReportSource = cryReport
    End Sub
    Sub CetakRekapTahunan()
        cryReport.Load(RepLocation & "\CRRekap.rpt")
        cryReport.Refresh()
        cryReport.SetParameterValue("periode", "Tahun " & FormLaporan.cbtahun2.SelectedValue)
        cryReport.RecordSelectionFormula = "Year({tbl_kendaraan.tgl_jual}) = " & FormLaporan.cbtahun2.SelectedValue & " and " _
                                         & "{tbl_kendaraan.total} > $0"
        CrystalReportViewer1.ReportSource = cryReport
    End Sub
End Class