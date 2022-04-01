Public Class Receipt
    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call Nomorfakturotomatis()
    End Sub
    Private Sub txt_Kode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_IdMovie.KeyPress
        If e.KeyChar = Chr(13) Then
            'Chr(13) itu Tombol ENTER
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("Select * from Movie where ID_Movie ='" & txt_IdMovie.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                MsgBox("ID Movie Tidak Ada")
            Else
                txt_IdMovie.Text = DM.Item("ID_Movie")
                txtjudul.Text = DM.Item("Judul")
                txtharga.Text = DM.Item("Harga")
                txtjumlah.Enabled = True
                txtjumlah.Focus()
            End If
        End If
    End Sub
    Sub RumusGrandTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            txtGrandtotal.Text = hitung
            txtsubtotal.Text = hitung
        Next
    End Sub
    Private Sub txtbayar_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtbayar.Text) < Val(txtGrandtotal.Text) Then
                MsgBox("Uang Pembayaran Kurang")
            ElseIf Val(txtbayar.Text) = Val(txtGrandtotal.Text) Then
                txtchange.Text = 0
            ElseIf Val(txtbayar.Text) > Val(txtGrandtotal.Text) Then
                txtchange.Text = Val(txtbayar.Text) - Val(txtGrandtotal.Text)
                btn_save.Focus()
            End If
        End If
    End Sub
    Sub kosongkanitem()
        txt_IdMovie.Text = ""
        txtjudul.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
    End Sub
    Sub kondisiawal()
        tgltayang.Text = Today
        jamtayang.Text = TimeOfDay
        txtcrew.Text = Login.txtUN.Text
    End Sub

    Private Sub txtjumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtjudul.Text = "" Or txtharga.Text = "" Then
                MsgBox("Masukkan ID Movie dan tekan enter ")
            Else
                DataGridView1.Rows.Add(New String() {txt_IdMovie.Text,
                 txtjudul.Text, txtharga.Text, txtjumlah.Text, Val(txtharga.Text) * Val(txtjumlah.Text)})
                Call RumusGrandTotal()
                Call kosongkanitem()
                txt_IdMovie.Focus()
                Call carijumlahitem()
            End If
        End If
    End Sub

    Sub Nomorfakturotomatis()
        Call koneksiDB()
        CMD = New OleDb.OleDbCommand("Select * from Receipt where ID_Receipt in (select max(ID_Receipt) from Receipt)", Conn)
        Dim urutankode As String
        Dim hitung As Long
        DM = CMD.ExecuteReader
        DM.Read()

        If Not DM.HasRows Then
            urutankode = "J" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(DM.GetString(0), 9) + 1
            urutankode = "J" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung.ToString, 3)
        End If
        txtidreceipt.Text = urutankode
        Dim BR_Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        BR_Generator.IncludeLabel = True
        BR_Generator.CustomLabel = txtidreceipt.Text
        Try
            PictureBox1.Image = BR_Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, txtidreceipt.Text)
            'PictureBox1.Image = New Bitmap(BR_Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.ISBN, TextBox2.Text))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtidcustomer_TextChanged(sender As Object, e As EventArgs) Handles txtidcustomer.TextChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Customer where ID_Customer ='" & txtidcustomer.Text & "'", Conn)
            DM = CMD.ExecuteReader

            If DM.HasRows = True Then
                DM.Read()
                txtidcustomer.Text = DM.Item("ID_Customer")
                txtnamacustomer.Text = DM.Item("Nama_Customer")
                txtidcustomer.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data Customer tidak ada")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call kosongkanitem()
    End Sub
    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
    End Sub
    Sub Barcode1()
        PictureBox1.ImageLocation = ""
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim Barcode As String
        Barcode = ("C:\Users\ASUS\Pictures\Foto Karyawan\")
        Barcode = Barcode + txtidreceipt.Text + ".jpg"
        PictureBox1.Image.Save(Barcode)
        If txtchange.Text = "" Or txtGrandtotal.Text = "" Then
            MsgBox("Data Receipt Belum Lengkap")
            'Pengecekan , apabila transaksi belum terjadi maka tidak bisa di ENTER
        Else
            Dim Simpantransaksi As String = "Insert into Receipt values ('" &
txtidreceipt.Text & "', '" & txtidcustomer.Text & "', '" & txtGrandtotal.Text & "', '" & tgltayang.Text & "', '" & jamtayang.Text &
 "', '" & txtcrew.Text & "', '" & txtitems.Text & "','" & txtbayar.Text & "','" & txtchange.Text & "', '" & Barcode & "')"
            CMD = New OleDb.OleDbCommand(Simpantransaksi, Conn)
            CMD.ExecuteNonQuery()
            Call Barcode1()
            'Data disimpan di tabel Receipt

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim Simpandetail As String = "Insert into Ticket values ('" & txtidreceipt.Text & "', '" &
                DataGridView1.Rows(baris).Cells(0).Value & "', '" &
                DataGridView1.Rows(baris).Cells(1).Value & "', '" &
                DataGridView1.Rows(baris).Cells(2).Value & "', '" &
                DataGridView1.Rows(baris).Cells(3).Value & "','" &
                DataGridView1.Rows(baris).Cells(4).Value & "'," ' &
                'Get Random(1111, 99999).ToString() & ")"
                CMD = New OleDb.OleDbCommand(Simpandetail, Conn)
                CMD.ExecuteNonQuery()

                CMD = New OleDb.OleDbCommand("select * from Movie where ID_Movie = '" &
                DataGridView1.Rows(baris).Cells(0).Value & "'", Conn)
                DM = CMD.ExecuteReader
                DM.Read()
                Dim kurangistok As String = "Update Movie set Stok = '" &
                DM.Item("Stok") - DataGridView1.Rows(baris).Cells(3).Value & "' where ID_Movie = '" &
                DataGridView1.Rows(baris).Cells(0).Value & "'"
                CMD = New OleDb.OleDbCommand(kurangistok, Conn)
                CMD.ExecuteNonQuery()
            Next
            MsgBox("Receipt Telah Tersimpan")
            DataGridView1.Rows.Clear()
            Call kosongkanitem()
            Call kondisiawal()
            Nomorfakturotomatis()

        End If
        'Receipt.Report_Nota_Struk.SetParameterValue("ID_Receipt", txtidreceipt.Text)
        'Receipt.Show()
    End Sub
    Sub carijumlahitem()
        Dim hitungitem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitungitem = hitungitem + DataGridView1.Rows(i).Cells(3).Value
            txtitems.Text = hitungitem
        Next
    End Sub

    Private Sub Btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim Total_Akhir As Integer
        Dim Hitung As Integer
        Total_Akhir = (Val(txtGrandtotal.Text))
        txtGrandtotal.Text = Total_Akhir
        Hitung = txtbayar.Text - txtGrandtotal.Text
        txtchange.Text = Hitung
    End Sub

    Private Sub txtidcrew_TextChanged(sender As Object, e As EventArgs) Handles txtidcrew.TextChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Crew_Ticketing where ID_Crew ='" & txtidcrew.Text & "'", Conn)
            DM = CMD.ExecuteReader
            If DM.HasRows = True Then
                DM.Read()
                txtidcrew.Text = DM.Item("ID_Crew")
                txtcrew.Text = DM.Item("Nama_Crew")
                txtidcrew.Focus()
            End If
        Catch ex As Exception
            MsgBox(" Data Crew Tidak Tersedia")
        End Try
    End Sub


    Private Sub jamtayang_ValueChanged(sender As Object, e As EventArgs) Handles jamtayang.ValueChanged
        Dim format As String = "dddd"
        'Debug.WriteLine(tgltayang.Value.ToString(format))
        'txthari.Text = tgltayang.Value.ToString(format)
        If tgltayang.Value.ToString(format) = "Minggu" Then txtharga.Text = "50.000" Else If tgltayang.Value.ToString(format) = "Sabtu" Then txtharga.Text = "50.000" Else txtharga.Text = "35.000"

    End Sub
End Class