Public Class WarningForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        FormTime.Timer1.Enabled = True

        FormTime.durasi = waktuDuduk
        FormTime.Timer2.Enabled = True
        Dim inJam, inMenit As Integer
        Dim temp As Integer = 0
        Dim jam, menit, detik As String
        inJam = TimeOfDay.Hour
        inMenit = TimeOfDay.Minute + 1 'waktuDuduk/(9*60)

        If inMenit = 60 Then
            temp += 1
        End If

        menit = inMenit Mod 60
        If inMenit Mod 60 < 10 Then
            menit = "0" + menit
        End If

        inJam += temp
        jam = inJam
        If inJam < 10 Then
            jam = "0" + jam
        End If

        detik = TimeOfDay.Second Mod 60

        If TimeOfDay.Second Mod 60 < 10 Then
            detik = "0" + detik
        End If

        FormTime.TextBox1.Text = jam + "." + menit + "." + detik
        FormTime.Label4.Text = FormTime.TextBox1.Text

        My.Computer.Audio.Stop()
        FormTime.durasi = waktuDuduk
        FormTime.Timer3.Enabled = True
    End Sub

    Private Sub WarningForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If jenisKelamin = "L" Then
            PictureBox1.Image = My.Resources.giphy
        Else
            PictureBox1.Image = My.Resources.dansers003
        End If
    End Sub
End Class