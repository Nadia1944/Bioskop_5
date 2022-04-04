Public Class Kursi
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksiDB()
        CMD = New OleDb.OleDbCommand($"SELECT * FROM Kursi WHERE ID_Kursi = '{TextBox1.Text}'", Conn)
        DM = CMD.ExecuteReader
        DM.Read()
        If Not DM.HasRows Then
            Call koneksiDB()
            Dim simpan As String
            simpan = $"insert into Kursi values ('{TextBox1.Text}','{TextBox2.Text}','{TextBox3.Text}')"
            CMD = New OleDb.OleDbCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Input Data Sukses")
        Else
            MsgBox("Data Sudah Ada")
        End If
        'Call MatikanForm()
        Call KosongkanForm()
        Call TampilkanData()
    End Sub
    Sub KosongkanForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

    Sub MatikanForm()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
    End Sub

    Sub HidupkanForm()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
    End Sub

    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Kursi", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
End Class