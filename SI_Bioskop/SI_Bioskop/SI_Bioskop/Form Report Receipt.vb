Imports CrystalDecisions.CrystalReports.Engine

Public Class Form_Report_Receipt
    ' Public Report Receipt As New ReportDocument

    'isi nomor faktur otomatis berdasarkan Access
    Sub nofaktur()
        Call koneksiDB()
        Try
            'Penjualan = Tabel Transaksi
            CMD = New OleDb.OleDbCommand("select * from Receipt_Naili", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            ComboBox1.Items.Clear()
            Do While DM.Read = True
                'Menambahkan isi combo box dari field/kolom No_faktur
                ComboBox1.Items.Add(DM.Item("No_faktur"))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'Load form

    'Private Sub Form_Report_Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    'Private Sub Tampilkan_Click(sender As Object, e As EventArgs) Handles Tampilkan.Click
    'Form_Report_Receipt.SelectionFormula = "totext ({Penjualan.No_faktur})= '" &
    'ComboBox1.Text & "'"
    'CrystalReportViewer1.ReportSource = Nothing
    ' CrystalReportViewer1.RefreshReport()
    ' CrystalReportViewer1.ReportSource = CRTransaksi
    ' CrystalReportViewer1.RefreshReport()



End Class