﻿Public Class Login
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Call koneksiDB()
        Dim cek As String
        cek = "Select * From Crew_Ticketing Where Nama_Crew = '" & txtUN.Text & "'and ID_Crew = '" & txtPass.Text & "'"
        CMD = New OleDb.OleDbCommand(cek, Conn)
        CMD.ExecuteNonQuery()
        DM = CMD.ExecuteReader
        If DM.HasRows = True Then
            DM.Read()
            Main_Menu.Show()
            Me.Hide()
        Else
            MsgBox(" Maaf Username atau Password Anda Salah ")
            Me.Show()
        End If
        Crew.Label13.Text = txtUN.Text
        Movie.lblwelcome.Text = txtUN.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

End Class