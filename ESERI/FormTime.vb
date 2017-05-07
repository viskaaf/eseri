Public Class FormTime

    Public Shared jam_alarm As String
    Public MyX, MyY, durasi As Integer
    'Dim s As Integer = 0

    Private Sub FormTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        durasi = waktuDuduk
        Timer2.Enabled = True
        Dim inJam, inMenit As Integer
        Dim temp As Integer = 0
        Dim jam, menit, detik As String
        inJam = TimeOfDay.Hour
        inMenit = TimeOfDay.Minute + 1

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

        TextBox1.Text = jam + "." + menit + "." + detik
        Label4.Text = TextBox1.Text
        TextBox1.Enabled = False
        Timer3.Start()
        'DateTimePicker1.Format = DateTimePickerFormat.Time
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Label1.Text = TimeOfDay
        'If Label1.Text = Label4.Text Then
        If durasi = 0 Then

            If FormSound.lagu = "kosong" Then
                My.Computer.Audio.Play(My.Resources.Ringing_clock, AudioPlayMode.Background)
            Else
                My.Computer.Audio.Play(FormSound.lagu, AudioPlayMode.Background)
            End If

            Timer3.Enabled = False
            Timer1.Enabled = False
            BTLogout.Enabled = True
            'My.Computer.Audio.Play(My.Resources.BTS___I_NEED_U, AudioPlayMode.Background)
            'System.Windows.Forms.MessageBox.Show("Stretching!!!")
            WarningForm.Show()
        End If

        'Try
        '    If TimeOfDay = DateTimePicker1.Text Then
        '        If s = 1 Then
        '            AxWindowsMediaPlayer1.URL = FormSound.TBSong.Text.ToString
        '        Else
        '            MsgBox(DateTimePicker1.Value)
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label4.Text = TextBox1.Text
        Button1.Enabled = False
        If Label4.Text = "" Then
            MsgBox("Please set alarm", MsgBoxStyle.Exclamation)
            Button1.Enabled = True
            TextBox1.Enabled = False
        End If
        TextBox1.Enabled = False

        Timer1.Start()
        Timer3.Start()
        'Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        MyX = Me.Location.X
        MyY = Me.Location.Y
        'Label1.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub BTStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTStop.Click
        'My.Computer.Audio.Stop()
        Timer3.Stop()
    End Sub

    Private Sub PBBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBack.Click
        Me.Close()
        FormMenu.Visible = True
    End Sub

    Private Sub BTLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTLogout.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Me.Visible = False
        FormLogin.Visible = True
        FormLogin.TBUsername.Text = ""
        FormLogin.TBPassword.Text = ""
        FormLogin.TBUsername.Focus()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        durasi = durasi - 1
        Label5.Text = durasi
    End Sub
End Class