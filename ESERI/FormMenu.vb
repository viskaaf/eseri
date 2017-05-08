Public Class FormMenu

    Private Sub BTTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTTime.Click
        Me.Visible = False
        FormTime.Visible = True
    End Sub

    Private Sub BTSound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSound.Click
        Me.Visible = False
        FormSound.Visible = True
    End Sub

    Private Sub BTLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTLogout.Click
        Me.Close()
        FormLogin.Visible = True
        FormLogin.TBUsername.Text = ""
        FormLogin.TBPassword.Text = ""
        FormLogin.TBUsername.Focus()
    End Sub

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lala As Double = hitungUmur(FormLogin.userDate)
        MsgBox(FormLogin.userDate + " " + Today.Date.ToString + " " + lala.ToString + " " + waktuDuduk.ToString)
    End Sub
End Class