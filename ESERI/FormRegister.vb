Imports MySql.Data.MySqlClient
Public Class FormRegister

    Private Sub BTRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTRegister.Click
        Dim jk As String

        If RBLaki.Checked Then
            jk = "L"
        Else
            jk = "P"
        End If

        Try
            Call openConnection()
            CMD = New MySqlCommand("SELECT `username` from akun WHERE `username` = '" & TBUsername.Text & "' ", Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                MsgBox("Maaf akun sudah dipakai", MsgBoxStyle.Exclamation, "Peringatan")
                Me.Close()
                FormLogin.Visible = True
            Else
                Call openConnection()
                insert = "INSERT INTO `akun`(`nama_depan`, `nama_belakang`, `tanggal_lahir`, `berat_badan`, `tinggi_badan`, `jenis_kelamin`, `username`, `password`) VALUES(?,?,?,?,?,?,?,?)"
                CMD = Conn.CreateCommand
                With CMD
                    .CommandText = insert
                    .Connection = Conn
                    .Parameters.Add("p1", MySqlDbType.VarChar, 20).Value = TBNamaDepan.Text
                    .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = TBNamaBelakang.Text
                    .Parameters.Add("p3", MySqlDbType.Date).Value = Convert.ToDateTime(dtpTTL.Text)
                    .Parameters.Add("p4", MySqlDbType.Int24, 4).Value = TBBerat.Text
                    .Parameters.Add("p5", MySqlDbType.Int24, 4).Value = TBTinggi.Text
                    .Parameters.Add("p6", MySqlDbType.VarChar, 1).Value = jk
                    .Parameters.Add("p7", MySqlDbType.VarChar, 50).Value = TBUsername.Text
                    .Parameters.Add("p8", MySqlDbType.VarChar, 255).Value = TBPassword.Text
                    .ExecuteNonQuery()
                End With

                MsgBox("Berhasil daftar")
                Me.Visible = False
                FormLogin.Visible = True

            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub
End Class