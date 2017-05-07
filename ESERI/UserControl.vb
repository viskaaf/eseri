Imports MySql.Data.MySqlClient
Module UserControl
    Public waktuDuduk As Double
    Public jenisKelamin As String

    Public Function hitungUmur(ByVal tgl As String) As Integer
        Dim tahun As Integer = CInt(tgl.Substring(6, 4))
        Dim bulan As Integer = CInt(tgl.Substring(3, 2))

        Dim tahunSkg As Integer = CInt(Today.Year)
        Dim bulanSkg As Integer = CInt(Today.Month)

        Dim umur As Integer = 0

        umur += tahunSkg - tahun

        If bulanSkg < bulan Then
            umur -= 1
        End If

        Return umur
    End Function

    Public Function HitungDuduk(ByVal RD As MySqlDataReader) As Double
        Dim umur As Integer = hitungUmur(RD.Item(3))
        Dim bb As Double = CDbl(RD.Item(4))
        Dim bbIdeal As Double = CDbl(RD.Item(5) - 110)
        Dim waktu As Double = 15
        ' waktu default 15 menit
        ' jika laki laki kurangi 0.5 menit, jika perempuan kurangi 0.25 menit
        ' tiap 8kg selisih 5 menit (plus maupun minus)
        ' jika usia <= 30 waktu += 0
        ' jika usia <= 40 waktu += 5
        ' jika usia > 40 waktu += 15

        'itung berdasarkan jenis kelamin
        If RD.Item(6) = "L" Then
            waktu -= 0.5
        Else
            waktu -= 0.25
        End If

        'itung berdasarkan berat badan
        waktu += Math.Ceiling(bbIdeal - bb) * 5

        'usia

        If umur <= 30 Then
            waktu += 0
        ElseIf umur <= 40 Then
            waktu += 5
        Else
            waktu += 15
        End If

        waktu = waktu * 9 * 60

        Return waktu
    End Function


    Public Sub startAllActivity()
        FormTime.Timer1.Enabled = True
        FormTime.Timer2.Enabled = True
        FormTime.Timer3.Enabled = True
    End Sub


    Public Sub endAllActivity()
        FormTime.Timer1.Enabled = False
        FormTime.Timer2.Enabled = False
        FormTime.Timer3.Enabled = False
    End Sub



End Module
