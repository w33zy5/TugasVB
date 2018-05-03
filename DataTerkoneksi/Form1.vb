Public Class Form1
    Dim konek As New Class1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Test As DataTable = konek.xFungsiQuery("SELECT * FROM tb_user_login")
        DataGridView1.DataSource = Test
        DataGridView1.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If konek.cekKoneksi() = True Then
            MessageBox.Show("Data Terkoneksi")
        End If
    End Sub
End Class
