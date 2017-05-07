Imports MySql.Data.MySqlClient
Public Class FormLogin

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Visible = False
        FormRegister.Visible = True
    End Sub



    Private Sub BTLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTLogin.Click
        If cekLogin() Then
            Try
                Call openConnection()
                CMD = New MySqlCommand("SELECT * FROM `akun` WHERE `username` = '" & TBUsername.Text & "' AND `password` = '" & TBPassword.Text & "'", Conn)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows Then 'jika ada akun
                    jenisKelamin = RD.Item(6)
                    MsgBox("Selamat datang, " & RD.Item(1) & " " & RD.Item(2) & "!")
                    Me.Visible = False
                    FormMenu.Visible = True
                    waktuDuduk = HitungDuduk(RD)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        Else
            MsgBox("Isi username dan password!")
        End If

        

    End Sub

    Function cekLogin() As Boolean
        If TBUsername.Text = "" Then
            Return False
        ElseIf TBPassword.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
