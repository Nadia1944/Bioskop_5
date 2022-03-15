Imports System.Diagnostics.Eventing.Reader
Public Class Movie
    Private Sub Movie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub
    Public Property OpenFileDialog1 As Object

    Sub KosongkanForm()
        id_movie.Text = ""
        judul.Text = ""
        Rate.Text = ""
        studio.Text = ""
        jam_tayang.Text = ""
        id_movie.Focus()
    End Sub
    Sub MatikanForm()
        id_movie.Enabled = False
        judul.Enabled = False
        Rate.Enabled = False
        studio.Enabled = False
        jam_tayang.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub
    Sub HidupkanForm()
        id_movie.Enabled = True
        judul.Enabled = True
        Rate.Enabled = True
        studio.Enabled = True
        jam_tayang.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("Select * from Movie ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV1.DataSource = DS.Tables(0)
        DGV1.ReadOnly = True
    End Sub
    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim TL As Integer
        TL = Year(DateTimePicker1.Value)
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If id_movie.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Movie where ID_Movie = '" & id_movie.Text & "'", Conn)
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

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If id_movie.Text = "" Or judul.Text = "" Or Rate.Text = "" Or
                    studio.Text = "" Or jam_tayang.Text = "" Then
            MsgBox("Data Movie Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Movie where ID_Movie ='" & id_movie.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Movie values ('" & id_movie.Text & "', '" & judul.Text & "', '" & Rate.Text & "','" & studio.Text & "','" & DateTimePicker1.Value & "','" & jam_tayang.Text & "')"
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

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If id_movie.Text = "" Or judul.Text = "" Or Rate.Text = "" Or
                    studio.Text = "" Or jam_tayang.Text = "" Then
            MsgBox("Data Movie Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Movie set Judul = '" & judul.Text & "', Rate = '" & Rate.Text & "',
           Studio = '" & studio.Text & "', Tanggal_Tayang = '" & DateTimePicker1.Value & "', Jam_Tayang = '" & jam_tayang.Text & "' Where ID_Movie = '" & id_movie.Text & "'", Conn)

            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        On Error Resume Next
        id_movie.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
        judul.Text = DGV1.Rows(e.RowIndex).Cells(1).Value
        Rate.Text = DGV1.Rows(e.RowIndex).Cells(2).Value
        studio.Text = DGV1.Rows(e.RowIndex).Cells(3).Value
        DateTimePicker1.Value = DGV1.Rows(e.RowIndex).Cells(4).Value
        jam_tayang.Text = DGV1.Rows(e.RowIndex).Cells(5).Value
        Call HidupkanForm()
        id_movie.Enabled = False
    End Sub
End Class