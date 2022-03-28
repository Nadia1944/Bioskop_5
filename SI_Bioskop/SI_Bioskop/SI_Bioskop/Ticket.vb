Public Class Ticket
    Sub KosongkanForm()
        txtidticket.Text = ""
        txtidreceipt.Text = ""
        txtidcrew.Text = ""
        txtnamacrew.Text = ""
        txtidmovie.Text = ""
        txtjudul.Text = ""
        txtrate.Text = ""
        txtstudiomovie.Text = ""
        txtidkursi.Text = ""
        txtharga.Text = ""
        txtidticket.Focus()
        'Coding diatas ada untuk mengosongkan Form yang sudah kita buat , jadi ketika form pertama kali di load kondisi form sudah dalam keadaan kosong
    End Sub

    Sub MatikanForm()
        txtidticket.Enabled = False
        txtidreceipt.Enabled = False
        txtidcrew.Enabled = False
        txtnamacrew.Enabled = False
        txtidmovie.Enabled = False
        txtjudul.Enabled = False
        txtrate.Enabled = False
        txtstudiomovie.Enabled = False
        txtidkursi.Enabled = False
        txtharga.Enabled = False
        'Coding diatas untuk menutup atau mematikan form agar tidak dapat isi
    End Sub

    Sub HidupkanForm()
        txtidticket.Enabled = True
        txtidreceipt.Enabled = True
        txtidcrew.Enabled = True
        txtnamacrew.Enabled = True
        txtidmovie.Enabled = True
        txtjudul.Enabled = True
        txtrate.Enabled = True
        txtstudiomovie.Enabled = True
        txtidkursi.Enabled = True
        txtharga.Enabled = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub

    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Ticket", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
        'Coding diatas untuk menampilkan data dari Ms.Access yang sudah kita buat pada Data Grid View didalam form 
    End Sub

    Private Sub Ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub
    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txtidticket.Text = "" Or txtidreceipt.Text = "" Or txtidcrew.Text = "" Or txtnamacrew.Text = "" Or txtidmovie.Text = "" Or txtjudul.Text = "" Or txtrate.Text = "" Or txtstudiomovie.Text = "" Or txtidkursi.Text = "" Or txtharga.Text = "" Then
            MsgBox("Data Buku Belum Lengkap")
            Exit Sub
            'Coding ini berfungsi untuk mengecek jika salah satu field data ada yang kosong , atau belum diisi , maka akan tampil pesan bahwa data yang di input belum lengkap
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand($"SELECT * FROM Ticket WHERE ID_Ticket = '{txtidticket.Text}'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            'Coding ini berfungsi untuk mengecek jika di bagian id menu (primary key) ada inputan data yang sama , maka ke Else : data sudah ada
            'Jika data inputan tidak sama , maka ke If Not : masukkan inputan dari form ke database Ms.Access
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = $"insert into Ticket values ('{txtidticket.Text}','{txtidreceipt.Text}', '{txtidcrew.Text}', '{txtnamacrew.Text}', '{txtidmovie.Text}', '{txtjudul.Text}','{txtrate.Text}', '{txtstudiomovie.Text}','{tgltayang.Value.ToString()}', '{jamtayang.Value.ToString()}', '{txtidkursi.Text}', '{txtharga.Text}')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If txtidticket.Text = "" Or txtidreceipt.Text = "" Or txtidcrew.Text = "" Or txtnamacrew.Text = "" Or txtidmovie.Text = "" Or txtjudul.Text = "" Or txtrate.Text = "" Or txtstudiomovie.Text = "" Or txtidkursi.Text = "" Or txtharga.Text = "" Then
            MsgBox("Data Ticket Belum Lengkap")
            Exit Sub
            'Coding berfungsi untuk mengecek jika ada field yang belum terisi atau belum lengkap
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand($" update Ticket set ID_Ticket ='{txtidticket.Text}', ID_Receipt='{txtidreceipt.Text}', ID_Crew='{txtidcrew.Text}', Nama_Crew = '{txtnamacrew.Text}', ID_Movie = '{txtidmovie.Text}', Judul = '{txtjudul.Text}', Rate = '{txtrate.Text}', Studio = '{txtstudiomovie.Text}',Tanggal_Tayang= '{tgltayang.Value.ToString()}', Jam_Tayang = '{jamtayang.Value.ToString()}' , ID_Kursi = '{txtidkursi.Text}', Harga = '{txtharga.Text}'")
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
            'Coding berfungsi untuk mengedit dan mengupdate data yang dipilih untuk kemudian disimpan lagi di tabel Ms.Access yang sdh dibuat
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If txtidticket.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
            'Coding berfungsi untuk mengecek , jika tidak ada data yang dipilih untuk dihapus , maka akan tampil pesan diatas 
        Else
            If MessageBox.Show("Are you sure to delete this data ? ", "Konfirmasi", MessageBoxButtons.YesNoCancel) = System.Windows.Forms.DialogResult.Yes Then
                'Coding berfungsi untuk memberi konfirmasi ke user , apakah yakin untuk mendelete data 
                'Jika yakin , maka akan berjalan coding dibawah ini untuk mendelete data yang dipilih 
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Ticket where ID_Ticket ='" & txtidticket.Text & "'", Conn)
                DM = CMD.ExecuteReader
                MsgBox("Hapus Data Berhasil")
                Call MatikanForm()
                Call KosongkanForm()
                Call TampilkanData()
            Else
                Call KosongkanForm()
                Call TampilkanData()
            End If
        End If
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        On Error Resume Next
        txtidticket.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txtidreceipt.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txtidcrew.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txtnamacrew.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txtidmovie.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        txtjudul.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        txtrate.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        txtstudiomovie.Text = DGV.Rows(e.RowIndex).Cells(7).Value
        tgltayang.Text = DGV.Rows(e.RowIndex).Cells(8).Value
        jamtayang.Text = DGV.Rows(e.RowIndex).Cells(9).Value
        txtidkursi.Text = DGV.Rows(e.RowIndex).Cells(10).Value
        txtharga.Text = DGV.Rows(e.RowIndex).Cells(11).Value
        'Coding ini berfungsi , ketika kita mau mengedit data ,caranya kita arahkan mouse ke salah satu cell yang di Data Grid View , maka data dari cell tersebut akan masuk ke dalam field yang ada form
        'Cell(0) , Cell(1) dst artinya : dimulai dari Cell ke O , 1 dan eterusnya
        Call HidupkanForm()
        txtidticket.Enabled = False 'Ketika mengedit , kita tidak bisa mengedit kode buku nya , kita hanya bisa mengedit di field2 lainnya
    End Sub
    Private Sub tgltayang_ValueChanged(sender As Object, e As EventArgs) Handles tgltayang.ValueChanged
        Dim format As String = "dddd"
        'Debug.WriteLine(tgltayang.Value.ToString(format))
        'txthari.Text = tgltayang.Value.ToString(format)
        If tgltayang.Value.ToString(format) = "Minggu" Then txtharga.Text = "50.000" Else If tgltayang.Value.ToString(format) = "Sabtu" Then txtharga.Text = "50.000" Else txtharga.Text = "35.000"
    End Sub

    Private Sub txtidcrew_TextChanged(sender As Object, e As EventArgs) Handles txtidcrew.TextChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand($"select * from Crew_Ticketing where ID_Crew ='{txtidcrew.Text}'", Conn)
            'CMD = New OleDb.OleDbCommand($"SELECT * FROM Ticket WHERE ID_Ticket = '{txtidticket.Text}'", Conn)
            DM = CMD.ExecuteReader
            If DM.HasRows = True Then
                DM.Read()
                txtnamacrew.Text = DM.Item("Nama_Crew")
                txtidmovie.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data Crew Ticketing tidak ada")
        End Try
    End Sub

    Private Sub txtidmovie_TextChanged(sender As Object, e As EventArgs) Handles txtidmovie.TextChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand($"select * from Movie where ID_Movie ='{txtidmovie.Text}'", Conn)
            'CMD = New OleDb.OleDbCommand($"SELECT * FROM Ticket WHERE ID_Ticket = '{txtidticket.Text}'", Conn)
            DM = CMD.ExecuteReader
            If DM.HasRows = True Then
                DM.Read()
                txtjudul.Text = DM.Item("Judul")
                txtrate.Text = DM.Item("Rate")
                txtstudiomovie.Text = DM.Item("Studio")
                jamtayang.Text = DM.Item("Jam_Tayang")
                txtidkursi.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data Movie tidak ada")
        End Try
    End Sub

End Class