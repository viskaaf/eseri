Public Class FormSound
    'Dim s As Integer = 0
    ' by default lagu alarm adalah ringing clock gan :v
    Public lagu As String = "kosong"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            'TBSong.Text = ""
            TBSong.Text = OpenFileDialog1.FileName
            'My.Computer.Audio.Play(lagu, AudioPlayMode.Background)
            's = 1
        End If
    End Sub

    Private Sub CBSound_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBSound.SelectedIndexChanged
        If CBSound.Text = "Alarm 1" Then
            'My.Computer.Audio.Play(My.Resources.Ringing_clock, AudioPlayMode.Background)
            'lagu = My.Resources.Ringing_clock
        ElseIf CBSound.Text = "Alarm 2" Then
            'My.Computer.Audio.Play(My.Resources.Wake_up_sounds, AudioPlayMode.Background)
            'lagu = My.Resources.Wake_up_sounds.ToString
        Else
            'My.Computer.Audio.Play(My.Resources.good_morning, AudioPlayMode.Background)
            'lagu = My.Resources.good_morning.ToString
        End If
    End Sub

    Private Sub BTSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSet.Click
        Me.Visible = False
        FormTime.Visible = True
        lagu = TBSong.Text
    End Sub
  
    Private Sub PBBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBack.Click
        Me.Close()
        FormMenu.Visible = True
    End Sub

End Class