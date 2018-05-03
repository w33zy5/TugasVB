Public Class Form1
    Dim nama As String
    Dim uts, uas, tugas As Integer
    Dim aSiswa(20, 3) As String
    Dim aNama(0) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 20
            If aSiswa(i, 0) Is Nothing Then
                TextBox1.Text = aSiswa(i, 0)
                TextBox2.Text = aSiswa(i, 1)
                TextBox3.Text = aSiswa(i, 2)
                TextBox4.Text = aSiswa(i, 3)
                ListBox1.Items.Add(aSiswa(i, 0) & vbTab & aSiswa(i, 1) & vbTab & aSiswa(i, 2) & vbTab & aSiswa(i, 3))
                Exit For
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
