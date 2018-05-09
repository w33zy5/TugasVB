Public Class FormDataTable
    Dim xTable As DataTable

    Public Sub Bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus() 'To focus cursor to textbox1
    End Sub

    Public Sub BuatKolom()
        xTable = New DataTable
        xTable.Columns.Add("nama", CStr("0").GetType)
        xTable.Columns.Add("alamat", CStr("0").GetType)
        xTable.Columns.Add("telp", CStr("0").GetType)
        xTable.Columns.Add("email", CStr("0").GetType)
    End Sub

    Public Function simpanDataTable(a As String, b As String, c As String, d As String)
        Dim status As Boolean = False

        Try
            Dim xRow As DataRow = xTable.NewRow
            xRow(0) = a
            xRow(1) = b
            xRow(2) = c
            xRow(3) = d
            xTable.Rows.Add(xRow)
            status = True
            MessageBox.Show("Data berhasil tersimpan")
        Catch ex As Exception
            status = False
            MessageBox.Show("Data tidak tersimpan")
        End Try

        Return status
    End Function

    Private Sub FormDataTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bersih()
        BuatKolom()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Bersih()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        simpanDataTable(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        DataGridView1.DataSource = xTable
        DataGridView1.Refresh()
    End Sub
End Class
