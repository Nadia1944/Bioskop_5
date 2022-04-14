﻿Imports CrystalDecisions.CrystalReports.Engine

Public Class Form_Report_Receipt
    Public CRTransaksi As New ReportDocument
    'isi nomor faktur otomatis berdasarkan Access
    Sub nofaktur()
        Call koneksiDB()
        Try
            'Penjualan = Tabel Receipt
            CMD = New OleDb.OleDbCommand("select * from Receipt", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            ComboBox1.Items.Clear()
            Do While DM.Read = True
                'Menambahkan isi combo box dari field/kolom No_faktur
                ComboBox1.Items.Add(DM.Item("ID_Receipt"))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Load form
    Private Sub Form_Report_Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CRTransaksi.Load("C:\Users\ASUS\Music\Bioskop_5\SI_Bioskop\SI_Bioskop\SI_Bioskop\Report Receipt.rpt")
        CRTransaksi.RecordSelectionFormula = ""
        CrystalReportViewer1.ReportSource = CRTransaksi
        Call nofaktur()
    End Sub

    Private Sub Tampilkan_Click(sender As Object, e As EventArgs) Handles Tampilkan.Click
        CrystalReportViewer1.SelectionFormula = "totext ({Receipt.ID_Receipt})= '" & ComboBox1.Text & "'"
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.ReportSource = CRTransaksi
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QR_Code_reader_Webcam.Show()
    End Sub
End Class