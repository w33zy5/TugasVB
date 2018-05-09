Public Class Form1
    Dim xConn As New koneksi
    Dim xTabel As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateTable()
    End Sub

    Function CreateTable()
        xTabel = New DataTable
        xTabel.Columns.Add("id", CStr("0").GetType)
        xTabel.Columns.Add("nama", CStr("0").GetType)
        xTabel.Columns.Add("alamat", CStr("0").GetType)

        Dim xRow As DataRow = xTabel.NewRow
        xRow(0) = "1"
        xRow(1) = "Adi"
        xRow(2) = "Budi"
        xTabel.Rows.Add(xRow)

        DataGridView1.DataSource = xTabel
        DataGridView1.Refresh()

    End Function

End Class
