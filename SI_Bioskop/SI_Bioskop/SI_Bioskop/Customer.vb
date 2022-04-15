Public Class Customer
    Sub KosongkanForm()
        txt_idcustomer.Text = ""
        txt_namacustomer.Text = ""
        cmb_jk.Text = ""
        txt_hp.Text = ""
        txt_alamat.Text = ""
    End Sub
    Sub MatikanForm()
        txt_idcustomer.Enabled = False
        txt_namacustomer.Enabled = False
        cmb_jk.Enabled = False
        txt_hp.Enabled = False
        txt_alamat.Enabled = False
    End Sub
    Sub HidupkanForm()
        txt_idcustomer.Enabled = True
        txt_namacustomer.Enabled = True
        cmb_jk.Enabled = True
        txt_hp.Enabled = True
        txt_alamat.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Customer ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub
    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_idcustomer.Text = "" Or txt_namacustomer.Text = "" Or cmb_jk.Text = "" Or txt_hp.Text = "" Or txt_alamat.Text = "" Then
            MsgBox("Data Customer Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Customer where ID_Customer='" & txt_idcustomer.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Customer values ('" & txt_idcustomer.Text &
               "', '" & txt_namacustomer.Text & "',  '" & cmb_jk.Text & "', '" & txt_hp.Text & "', '" & txt_alamat.Text & "')"
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
        If txt_idcustomer.Text = "" Or txt_namacustomer.Text = "" Or cmb_jk.Text = "" Or txt_hp.Text = "" Or txt_alamat.Text = "" Then
            MsgBox("Data Customer Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Customer set Nama_Customer = '" &
           txt_namacustomer.Text & "', Jenis_Kelamin = '" & cmb_jk.Text & "', No_Hp = '" & txt_hp.Text & "', Alamat ='" &
           txt_alamat.Text & "' where ID_Customer ='" & txt_idcustomer.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txt_idcustomer.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Customer where ID_Customer = '" & txt_idcustomer.Text & "'", Conn)
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

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        txt_idcustomer.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_namacustomer.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        cmb_jk.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txt_hp.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txt_alamat.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Call HidupkanForm()
        txt_idcustomer.Enabled = False
    End Sub
End Class