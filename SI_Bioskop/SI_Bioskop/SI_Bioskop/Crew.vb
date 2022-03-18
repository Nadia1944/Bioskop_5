Imports System.Diagnostics.Eventing.Reader
Public Class Crew
    Public Property OpenFileDialog1 As Object

    Sub KosongkanForm()
        id_crew.Text = ""
        nama_crew.Text = ""
        tempat_lahir.Text = ""
        umur_crew.Text = ""
        agama.Text = ""
        jenis_kelamin.Text = ""
        no_hp.Text = ""
        alamat.Text = ""
        status.Text = ""
        foto_diri.Text = ""
        id_crew.Focus()
    End Sub
    Sub MatikanForm()
        id_crew.Enabled = False
        nama_crew.Enabled = False
        tempat_lahir.Enabled = False
        DateTimePicker1.Enabled = False
        umur_crew.Enabled = False
        agama.Enabled = False
        jenis_kelamin.Enabled = False
        no_hp.Enabled = False
        alamat.Enabled = False
        status.Enabled = False
        foto_diri.Enabled = False
    End Sub
    Sub HidupkanForm()
        id_crew.Enabled = True
        nama_crew.Enabled = True
        tempat_lahir.Enabled = True
        DateTimePicker1.Enabled = True
        umur_crew.Enabled = True
        agama.Enabled = True
        jenis_kelamin.Enabled = True
        no_hp.Enabled = True
        alamat.Enabled = True
        status.Enabled = True
        foto_diri.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("Select * from Crew_Ticketing", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV2.DataSource = DS.Tables(0)
        DGV2.ReadOnly = True
    End Sub
    Sub Foto1()
        PictureBox1.ImageLocation = ""
    End Sub
    Private Sub Data_Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim Umur, TL, TS As Integer
        TL = Year(DateTimePicker1.Value)
        TS = Year(Now)
        Umur = TS - TL
        umur_crew.Text = (Umur & " Tahun ")
    End Sub
    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If id_crew.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Crew_Ticketing where ID_Crew = '" & id_crew.Text & "'", Conn)
                DM = CMD.ExecuteReader
                MsgBox("Data Berhasil Dihapus")
                Call MatikanForm()
                Call KosongkanForm()
                Call TampilkanData()
            Else
                Call KosongkanForm()
                Call TampilkanData()
            End If
        End If
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If id_crew.Text = "" Or nama_crew.Text = "" Or tempat_lahir.Text = "" Or
            jenis_kelamin.Text = "" Or agama.Text = "" Or no_hp.Text = "" Or alamat.Text = "" Or
           status.Text = "" Or foto_diri.Text = "" Then
            MsgBox("Data Crew Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Crew_Ticketing set Nama_Crew = '" & nama_crew.Text & "', Tempat_Lahir = '" & tempat_lahir.Text & "',
           Jenis_Kelamin = '" & jenis_kelamin.Text & "', Agama = '" & agama.Text & "',  No_Hp = '" &
           no_hp.Text & "', Alamat = '" & alamat.Text & "', Status = '" & status.Text & "' , Foto = '" & foto_diri.Text & "' Where ID_Crew = '" & id_crew.Text & "'", Conn)

            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub
    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If id_crew.Text = "" Or nama_crew.Text = "" Or tempat_lahir.Text = "" Or
             jenis_kelamin.Text = "" Or agama.Text = "" Or no_hp.Text = "" Or alamat.Text = "" Or status.Text = "" Or foto_diri.Text = "" Then
            MsgBox("Data Crew Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Crew_Ticketing where ID_Crew ='" & id_crew.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Crew_Ticketing values ('" & id_crew.Text & "', '" & nama_crew.Text & "', '" & tempat_lahir.Text & "','" & DateTimePicker1.Value & "','" & umur_crew.Text & "','" & jenis_kelamin.Text & "','" & agama.Text & "','" & no_hp.Text & "','" & alamat.Text & "', 
                          '" & status.Text & "','" & foto_diri.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
                Call Foto1()
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub
    Private Sub DGV2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellContentClick
        On Error Resume Next
        id_crew.Text = DGV2.Rows(e.RowIndex).Cells(0).Value
        nama_crew.Text = DGV2.Rows(e.RowIndex).Cells(1).Value
        tempat_lahir.Text = DGV2.Rows(e.RowIndex).Cells(2).Value
        DateTimePicker1.Value = DGV2.Rows(e.RowIndex).Cells(3).Value
        umur_crew.Text = DGV2.Rows(e.RowIndex).Cells(4).Value
        jenis_kelamin.Text = DGV2.Rows(e.RowIndex).Cells(5).Value
        agama.Text = DGV2.Rows(e.RowIndex).Cells(6).Value
        no_hp.Text = DGV2.Rows(e.RowIndex).Cells(7).Value
        alamat.Text = DGV2.Rows(e.RowIndex).Cells(8).Value
        status.Text = DGV2.Rows(e.RowIndex).Cells(9).Value
        foto_diri.Text = DGV2.Rows(e.RowIndex).Cells(10).Value
        Call HidupkanForm()
        id_crew.Enabled = False
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFile1.Filter = " Image File
    (*.jpeg;*jpg;*.png;*.bmp;*.gif)| *.jpeg;*jpg;*.png;*.bmp;*.gif"
        OpenFile1.RestoreDirectory = True
        OpenFile1.ShowDialog()
        If OpenFile1.FileName = "" Then Exit Sub
        PictureBox1.ImageLocation = OpenFile1.FileName
        foto_diri.Text = OpenFile1.FileName
    End Sub
    Private Sub id_kasir_TextChanged(sender As Object, e As EventArgs) Handles id_crew.TextChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Crew_Ticketing where ID_Crew ='" & id_crew.Text & "'", Conn)
            DM = CMD.ExecuteReader
            'DM.Read()
            If DM.HasRows = True Then
                DM.Read()
                'Dim row As DataRow
                'row = DS.Tables(0).Rows.Find(pegawai)
                id_crew.Text = DM.Item("ID_Crew")
                nama_crew.Text = DM.Item("Nama_Crew")
                tempat_lahir.Text = DM.Item("Tempat_Lahir")
                DateTimePicker1.Text = DM.Item("Tanggal_Lahir")
                umur_crew.Text = DM.Item("Usia")
                jenis_kelamin.Text = DM.Item("Jenis_Kelamin")
                agama.Text = DM.Item("Agama")
                no_hp.Text = DM.Item("No_Hp")
                alamat.Text = DM.Item("Alamat")
                status.Text = DM.Item("Status")
                foto_diri.Text = DM.Item("Foto")
                Dim nas As String
                nas = foto_diri.Text
                PictureBox1.ImageLocation = Replace((DM("Foto")), ";", "\")
                PictureBox1.Image = New Bitmap(nas)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btn_caridata_Click(sender As Object, e As EventArgs) Handles btn_caridata.Click
        Call HidupkanForm()
        Dim pegawai = InputBox("Silahkan Masukan ID Crew")
        Try
            DS.Tables(0).PrimaryKey = New DataColumn() {DS.Tables(0).Columns("ID_Crew")}

            Dim row As DataRow
            row = DS.Tables(0).Rows.Find(pegawai)
            id_crew.Text = row("ID_Crew")
            nama_crew.Text = row("Nama_Crew")
            tempat_lahir.Text = row("Tempat_Lahir")
            DateTimePicker1.Text = row("Tanggal_Lahir")
            jenis_kelamin.Text = row("Jenis_Kelamin")
            agama.Text = row("Agama")
            no_hp.Text = row("No_Telepon")
            alamat.Text = row("Alamat")
            status.Text = row("Status")
            foto_diri.Text = row("Photo")

            Refresh()

            MsgBox("Pencarian Sukses!")
            Refresh()

        Catch ex As Exception
            MsgBox("Anda Salah Memasukkan ID Crew / ID Crew Tersebut Belum Terdaftar!")
        End Try
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Call koneksiDB()

        DA = New OleDb.OleDbDataAdapter("SELECT * from Crew where
        ID_Crew like '%" & cari.Text.Replace("'", "''") & "%' or Nama_Crew 
        like '%" & cari.Text.Replace("'", "''") & "%' or Alamat like '%" &
        cari.Text.Replace("'", "''") & "%' ", Conn)

        DS = New DataSet
        Dim SRT As New DataTable
        SRT.Clear()
        DA.Fill(SRT)
        DGV2.DataSource = SRT
    End Sub
End Class
