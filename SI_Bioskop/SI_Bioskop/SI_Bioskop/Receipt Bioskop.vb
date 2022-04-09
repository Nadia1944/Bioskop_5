Public Class Receipt_Bioskop
    Dim BR_Generator As New MessagingToolkit.Barcode.BarcodeEncoder
    Dim lokasiBR As String

    Sub CetakBC()
        BR_Generator.IncludeLabel = True
        BR_Generator.CustomLabel = txtidreceipt.Text
        Try
            PictureBox1.Image = BR_Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, txtidreceipt.Text)
        Catch ex As Exception
        End Try
    End Sub
    Sub Nomorfakturotomatis()
        Call koneksiDB()
        CMD = New OleDb.OleDbCommand("Select * from Receipt where ID_Receipt in (select max(ID_Receipt) from Receipt)", Conn)
        Dim urutankode As String
        Dim hitung As Long
        DM = CMD.ExecuteReader
        DM.Read()
        If Not DM.HasRows Then
            urutankode = "CIN" + Format(Now, "ddMMyy") + "001"
            'huruf "J" diatas yang dimaksud adalah transaksi penjualan , huruf bisa diganti sesuai dengan keinginan
        Else
            hitung = Microsoft.VisualBasic.Right(DM.GetString(0), 9) + 1
            urutankode = "CIN" + Format(Now, "ddMMyy") +
            Microsoft.VisualBasic.Right("000" & hitung, 3)
            'Koding ini maksudnya , setelah huruf J , akan ditambahkan tanggal , tahun ,dan bulan dengan format yyMMdd dan 000
            'misalnya J181221001
        End If
        txtidreceipt.Text = urutankode
    End Sub

    Private Sub txtidcust_TextChanged(sender As Object, e As EventArgs) Handles txtidcust.TextChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Customer where ID_Customer ='" & txtidcust.Text & "'", Conn)
            DM = CMD.ExecuteReader
            'Disini saya menggunakan tabel karyawan , karena saya tidak memiliki tabel member
            If DM.HasRows = True Then
                DM.Read()
                txtnamacust.Text = DM.Item("Nama_Customer")
                txtidmovie.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data Customer Tidak Ditemukan")
        End Try
    End Sub

    Private Sub Receipt_Bioskop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call Nomorfakturotomatis()
    End Sub
    Sub KosongkanForm()
        txtidreceipt.Text = ""
        txtidcust.Text = ""
        txtnamacust.Text = ""
        txtnamacrew.Text = ""
        txtidmovie.Text = ""
        txtjudul.Text = ""
        txtidkursi.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txtgrandtotal.Text = ""
        txtitems.Text = ""
        txtbayar.Text = ""
        txtchange.Text = ""
        txtidcust.Focus()
        'Coding diatas ada untuk mengosongkan Form yang sudah kita buat , jadi ketika form pertama kali di load kondisi form sudah dalam keadaan kosong
    End Sub
    Sub kondisiawal()
        tgltransaksi.Text = Today
        jamtransaksi.Text = TimeOfDay
        txtnamacrew.Text = Login.txtUN.Text
        txtidcrew.Text = Login.txtPass.Text
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        jamtransaksi.Text = TimeOfDay
    End Sub
    Private Sub txtidmovie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtidmovie.KeyPress
        If e.KeyChar = Chr(13) Then
            'Chr(13) itu Tombol ENTER
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("Select * from Movie where ID_Movie ='" &
            txtidmovie.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                MsgBox("Movie Tidak/Belum Tersedia Saat Ini")
            Else
                txtjudul.Text = DM.Item("Judul")
                txtrate.Text = DM.Item("Rate")
                txtstudio.Text = DM.Item("Studio")
                jamtayang.Text = DM.Item("Jam_Tayang")
                txtidkursi.Enabled = True
                txtidkursi.Focus()
                'coding txtjumlah.Focus maksudnya ketika tombol Enter dipencet , maka kursor keyboard akan langsung mengarah ke txtjumlah
            End If
        End If
    End Sub
    Private Sub tgltransaksi_ValueChanged(sender As Object, e As EventArgs) Handles tgltransaksi.ValueChanged
        Dim format As String = "dddd"
        If tgltransaksi.Value.ToString(format) = "Minggu" Then txtharga.Text = "50.000" Else If tgltransaksi.Value.ToString(format) = "Sabtu" Then txtharga.Text = "50.000" Else txtharga.Text = "35.000"
    End Sub

    Private Sub txtidkursi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtidkursi.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("Select * from Kursi where ID_Kursi ='" &
            txtidkursi.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                MsgBox("ID Kursi Tidak Ditemukan")
            Else
                txtjumlah.Text = DM.Item("Stok")
            End If
        End If
    End Sub
    Private Sub txtjumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtidmovie.Text = "" Or txtidkursi.Text = "" Then
                MsgBox("Inputkan Movie dan Kursi Anda")
            Else
                DataGridView1.Rows.Add(New String() {txtidmovie.Text, txtjudul.Text, txtrate.Text, txtstudio.Text, jamtayang.Text, txtidkursi.Text, txtharga.Text, txtjumlah.Text})
                Call RumusGrandTotal()
                Call kosongkanitem()
                Call kondisiawal()
                txtidmovie.Focus()
                Call carijumlahitem()
            End If
        End If
    End Sub
    Sub RumusGrandTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(6).Value
            txtgrandtotal.Text = hitung
        Next
    End Sub
    Sub kosongkanitem()
        txtidmovie.Text = ""
        txtjudul.Text = ""
        txtrate.Text = ""
        txtstudio.Text = ""
        jamtayang.Text = ""
        txtidkursi.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
    End Sub
    Sub bersihkanform()
        txtidcust.Text = ""
        txtnamacust.Text = ""
        txtidcrew.Text = ""
        txtgrandtotal.Text = ""
        txtitems.Text = ""
        txtbayar.Text = ""
        txtchange.Text = ""
        txtidmovie.Text = ""
        txtjudul.Text = ""
        txtrate.Text = ""
        txtstudio.Text = ""
        jamtayang.Text = ""
        txtidkursi.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        'DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        DataGridView1.Rows.Clear()
    End Sub
    Sub carijumlahitem()
        Dim hitungitem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitungitem = hitungitem + DataGridView1.Rows(i).Cells(7).Value
            txtitems.Text = hitungitem
        Next
    End Sub
    Private Sub txtbayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtbayar.Text) < Val(txtgrandtotal.Text) Then
                MsgBox("Maaf Uang Pembayaran Kurang")
            ElseIf Val(txtbayar.Text) = Val(txtgrandtotal.Text) Then
                txtchange.Text = 0
                Call CetakBC()
            ElseIf Val(txtbayar.Text) > Val(txtgrandtotal.Text) Then
                txtchange.Text = Val(txtbayar.Text) - Val(txtgrandtotal.Text)
                Call CetakBC()
                btnsimpan.Focus()
            End If
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtchange.Text = "" Or txtgrandtotal.Text = "" Then
            MsgBox("Data Transaksi Belum Lengkap")
            'Pengecekan , apabila transaksi belum terjadi maka tidak bisa di ENTER
        Else
            Dim SD As New SaveFileDialog
            SD.Filter = "Image File (*.jpeg;*.jpg;*.png;*.bmp;)|*.jpeg;*.jpg;*.png;*.bmp;"
            If SD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'SD.Filter = "Image File (*.jpeg;*jpg;*.png;*.bmp;)| *.jpeg;*jpg;*.png;*.bmp;"
                Try
                    PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                lokasiBR = SD.FileName
            Else
                MsgBox("Barcode Harus Disimpan")
                Exit Sub
            End If

            Dim simpanreceipt As String = $"Insert into Receipt values('{txtidreceipt.Text}','{txtidcust.Text}','{txtidcrew.Text}','{txtnamacust.Text}','{txtnamacrew.Text}','{tgltransaksi.Value.ToString()}','{jamtransaksi.Value.ToString()}','{txtgrandtotal.Text}','{txtitems.Text}','{txtbayar.Text}','{txtchange.Text}','{lokasiBR}')"
            '$"insert into Ticket values ('{nama textbox-nya}', '{nama textbox-nya}')"
            CMD = New OleDb.OleDbCommand(simpanreceipt, Conn)
            CMD.ExecuteNonQuery()
            'Data disimpan di tabel Receipt_Naili

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim Simpandetail As String = "Insert into Detail_Receipt values ('" &
                txtidreceipt.Text & "', '" & DataGridView1.Rows(baris).Cells(0).Value & "', '" &
                DataGridView1.Rows(baris).Cells(1).Value & "', '" &
                DataGridView1.Rows(baris).Cells(2).Value & "', '" &
                DataGridView1.Rows(baris).Cells(3).Value & "', '" &
                DataGridView1.Rows(baris).Cells(4).Value & "','" &
                DataGridView1.Rows(baris).Cells(5).Value & "', '" &
                DataGridView1.Rows(baris).Cells(6).Value & "', '" &
                DataGridView1.Rows(baris).Cells(7).Value & "')"
                CMD = New OleDb.OleDbCommand(Simpandetail, Conn)
                CMD.ExecuteNonQuery()
                'Data disimpan di tabel detail penjualan
                ' DataGridView1.Rows(baris).Cells(0).Value artinya data di cell pertama, kedua , ketiga , keempat

                CMD = New OleDb.OleDbCommand("select * from Kursi where ID_Kursi = '" &
    DataGridView1.Rows(baris).Cells(5).Value & "'", Conn)
                DM = CMD.ExecuteReader
                DM.Read()
                Dim kurangistok As String = "Update Kursi set Stok = '" &
                DM.Item("Stok") - DataGridView1.Rows(baris).Cells(3).Value & "' where ID_Kursi = '" &
                DataGridView1.Rows(baris).Cells(5).Value & "'"
                CMD = New OleDb.OleDbCommand(kurangistok, Conn)
                CMD.ExecuteNonQuery()
                'Coding ini maksudnya , stok barang akan dikurangi sesuai dengan jumlah barang yang sudah terjual
            Next
            MsgBox("Receipt Telah Tersimpan")
            Call bersihkanform()
            Call kondisiawal()
            Call Nomorfakturotomatis()
            Print_Ticket.Show()
            'Report_Ticket1.SelectionFormula = "totext ({Detail_Receipt.ID_Receipt})= '" & txtidreceipt.Text & "'"
            'Report_Ticket1.ReportSource = Nothing
            'Report_Ticket1.RefreshReport()
            'Report_Ticket1.ReportSource = LaporanBuku_Tglmasuk3
            'Report_Ticket1.RefreshReport()
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Call kosongkanitem()
    End Sub

    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Me.Close()
        Main_Menu.Show()
    End Sub
End Class