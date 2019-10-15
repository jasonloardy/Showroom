Imports System.Data.OleDb

Module ModuleDB
    Public LokasiDB As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb"
    Public Conn As OleDbConnection = New OleDbConnection(LokasiDB)
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As New OleDbCommand
    Public dt As DataTable
    Public dr As OleDbDataReader
    Public Function koneksi() As Boolean
        Try

            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Koneksi ke database bermasalah!", 48, "Perhatian")
            Application.Exit()
            Return False
        End Try
    End Function
    Sub Query(ByVal query As String)
        Try
            koneksi()
            Using cmd As New OleDbCommand
                cmd.CommandText = query
                cmd.Connection = Conn
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub
    Sub QueryKendaraan(ByVal query As String, ByVal nopol As String, ByVal merk_tipe As String, ByVal tahun As String,
                       ByVal warna As String, ByVal data_penjual As String, ByVal vendor As String, ByVal tgl_beli As String,
                       ByVal hrg_beli As String, ByVal status_bpkb As String, ByVal status As String, ByVal tgl_jual As String,
                       ByVal cara_bayar As String, ByVal leasing As String, ByVal uang_muka As String, ByVal cair As String,
                       ByVal refund As String, ByVal total As String, ByVal keuntungan As String, ByVal persentase As String)
        Try
            Using cmd As New OleDbCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@nopol", nopol)
                cmd.Parameters.AddWithValue("@merk_tipe", merk_tipe)
                cmd.Parameters.AddWithValue("@tahun", tahun)
                cmd.Parameters.AddWithValue("@warna", warna)
                cmd.Parameters.AddWithValue("@data_penjual", data_penjual)
                cmd.Parameters.AddWithValue("@vendor", vendor)
                cmd.Parameters.AddWithValue("@tgl_beli", tgl_beli)
                cmd.Parameters.AddWithValue("@hrg_beli", hrg_beli)
                cmd.Parameters.AddWithValue("@status_bpkb", status_bpkb)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@tgl_jual", tgl_jual)
                cmd.Parameters.AddWithValue("@cara_bayar", cara_bayar)
                cmd.Parameters.AddWithValue("@leasing", leasing)
                cmd.Parameters.AddWithValue("@uang_muka", uang_muka)
                cmd.Parameters.AddWithValue("@cair", cair)
                cmd.Parameters.AddWithValue("@refund", refund)
                cmd.Parameters.AddWithValue("@total", total)
                cmd.Parameters.AddWithValue("@keuntungan", keuntungan)
                cmd.Parameters.AddWithValue("@persentase", persentase)
                cmd.Connection = Conn
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub
    Sub QueryMaintenance(ByVal query As String, ByVal id_maintenance As String, ByVal deskripsi As String, ByVal nominal As String)
        Try
            Using cmd As New OleDbCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@id_maintenance", id_maintenance)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                cmd.Parameters.AddWithValue("@nominal", nominal)
                cmd.Connection = Conn
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub
    Function querycb(ByVal query As String)
        da = New OleDbDataAdapter(query, Conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        Return dt
    End Function
End Module
