Imports MySql.Data.MySqlClient
Public Class FormRegister

    Private Sub BTRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTRegister.Click
        Dim jk As String

        If cekRegister() = False Then
            MsgBox("Data Kosong")
        ElseIf cekLength() = False Then
            MsgBox("Username dan password minimal 8 karakter")
        Else
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
        End If

        
    End Sub

    Function cekRegister() As Boolean
        If TBNamaDepan.Text = "" Then
            Return False
        ElseIf TBNamaBelakang.Text = "" Then
            Return False
        ElseIf TBTinggi.Text = "" Then
            Return False
        ElseIf TBBerat.Text = "" Then
            Return False
        ElseIf TBUsername.Text = "" Then
            Return False
        ElseIf TBPassword.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function


    Function cekLength() As Boolean

        If TBUsername.Text.Length < 8 Then
            Return False
        ElseIf TBPassword.Text.Length < 8 Then
            Return False
        Else
            Return True
        End If

        Return 0
    End Function


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        FormLogin.Visible = True
    End Sub

    Private Sub FormRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RBLaki.Checked = True
    End Sub
End Class