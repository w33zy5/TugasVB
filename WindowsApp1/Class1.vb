Public Class Class1

    Public nama As String
    Public tanggal As Integer
    Public bulan As String

    Public Function getData()
        Dim zodiak As String
        If tanggal > 21 And bulan = "December" Or tanggal < 20 And bulan = "January" Then
            zodiak = "Capricorn"
        ElseIf tanggal > 19 And bulan = "January" Or tanggal < 18 And bulan = "February" Then
            zodiak = "Aquarius"
        ElseIf tanggal > 17 And bulan = "February" Or tanggal < 20 And bulan = "March" Then
            zodiak = "Pisces"
        ElseIf tanggal > 19 And bulan = "March" Or tanggal < 20 And bulan = "April" Then
            zodiak = "Aries"
        ElseIf tanggal > 19 And bulan = "April" Or tanggal < 20 And bulan = "May" Then
            zodiak = "Taurus"
        ElseIf tanggal > 19 And bulan = "May" Or tanggal < 21 And bulan = "June" Then
            zodiak = "Gemini"
        ElseIf tanggal > 20 And bulan = "June" Or tanggal < 22 And bulan = "July" Then
            zodiak = "Cancer"
        ElseIf tanggal > 21 And bulan = "July" Or tanggal < 23 And bulan = "August" Then
            zodiak = "Leo"
        ElseIf tanggal > 22 And bulan = "August" Or tanggal < 22 And bulan = "September" Then
            zodiak = "Virgo"
        ElseIf tanggal > 21 And bulan = "September" Or tanggal < 23 And bulan = "October" Then
            zodiak = "Libra"
        ElseIf tanggal > 22 And bulan = "October" Or tanggal < 22 And bulan = "November" Then
            zodiak = "Scorpio"
        ElseIf tanggal > 21 And bulan = "November" Or tanggal < 22 And bulan = "December" Then
            zodiak = "Sagitarius"
        End If

        Return (nama & ", anda lahir pada " & tanggal & " bulan " & bulan & " berzodiak " & zodiak)

    End Function

End Class
