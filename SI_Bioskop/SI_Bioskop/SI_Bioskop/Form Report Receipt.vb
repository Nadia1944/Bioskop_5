﻿Imports CrystalDecisions.CrystalReports.Engine

Public Class Form_Report_Receipt
    Public Form_Report_Receipt As New ReportDocument
    'isi nomor faktur otomatis berdasarkan Access
    Sub nofaktur()
        Call koneksiDB()
        Try
            'Penjualan = Tabel Transaksi
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
        Form_Report_Receipt.Load("C:\Users\Anggis\Documents\S M T R  6 ! !\Prak APSI\Bioskop_5\SI_Bioskop\SI_Bioskop\SI_Bioskop\Report Receipt.rpt")
        Form_Report_Receipt.RecordSelectionFormula = ""
        CrystalReportViewer1.ReportSource = Form_Report_Receipt
        Call nofaktur()
    End Sub

    Private Sub Tampilkan_Click(sender As Object, e As EventArgs) Handles Tampilkan.Click
        CrystalReportViewer1.SelectionFormula = "totext ({Receipt.ID_Receipt})= '" &
ComboBox1.Text & "'"
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.ReportSource = Form_Report_Receipt
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QR_Code_reader_Webcam.Show()
    End Sub
End Class