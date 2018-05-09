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

        Catch ex As Exception

        End Try

        Return status
    End Function

    Private Sub FormDataTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
