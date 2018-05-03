Public Class Form1
    Dim nama As String
    Dim uts, uas, tugas As Integer
    Dim akhir As Double
    Dim aSiswa(2, 3) As String
    Dim aAkhir(0) As Double
    Dim aNama(0) As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        aSiswa(0, 0) = "Cahyo"
        aSiswa(0, 1) = "75"
        aSiswa(0, 2) = "67"
        aSiswa(0, 3) = "80"

        aSiswa(1, 0) = "Adi"
        aSiswa(1, 1) = "55"
        aSiswa(1, 2) = "95"
        aSiswa(1, 3) = "70"

        aSiswa(2, 0) = "Saori"
        aSiswa(2, 1) = "60"
        aSiswa(2, 2) = "90"
        aSiswa(2, 3) = "77"

        ListBox1.Items.Add(aSiswa(0, 0) & vbTab & aSiswa(0, 1) & vbTab & aSiswa(0, 2) & vbTab & aSiswa(0, 3))
        ListBox1.Items.Add(aSiswa(1, 0) & vbTab & aSiswa(1, 1) & vbTab & aSiswa(1, 2) & vbTab & aSiswa(1, 3))
        ListBox1.Items.Add(aSiswa(2, 0) & vbTab & aSiswa(2, 1) & vbTab & aSiswa(2, 2) & vbTab & aSiswa(2, 3))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        nama = aSiswa(TextBox1.Text - 1, 0)
        uts = aSiswa(TextBox1.Text - 1, 1)
        uas = aSiswa(TextBox1.Text - 1, 2)
        tugas = aSiswa(TextBox1.Text - 1, 3)

        TextBox2.Text = nama
        TextBox3.Text = uts
        TextBox4.Text = uas
        TextBox5.Text = tugas
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        akhir = (CDbl(uts * 0.3) + CDbl(uas * 0.4) + CDbl(tugas * 0.3))

        ReDim Preserve aNama(aNama.Length)
        aNama(aNama.Length - 1) = nama

        ReDim Preserve aAkhir(aAkhir.Length)
        aAkhir(aAkhir.Length - 1) = akhir

        ListBox2.Items.Add(aNama(aNama.Length - 1) & vbBack & aAkhir(aAkhir.Length - 1))
    End Sub

End Class
