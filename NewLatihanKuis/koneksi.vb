Imports MySql.Data.MySqlClient
Public Class koneksi
    Dim MySqlconn As MySqlConnection
    Dim comdString As String = "server=localhost;userid=root;password=;database=dblatihankuisvb;SslMode=none"
    Dim MySqlAdapter As MySqlDataAdapter
    Dim xDataset As DataSet

    Public Function cekKoneksi()
        Dim konek As Boolean = True
        Try

            MySqlconn = New MySqlConnection(comdString)
            If MySqlconn.State = ConnectionState.Closed Then
                MySqlconn.Open()
                konek = True
            End If

        Catch ex As Exception
            konek = False
            MessageBox.Show("Aplikasi Tidak Terhubung dengan Basis Data")

        End Try
        Return konek
    End Function
    Public Function xFungsiQuery(Qry As String) As DataTable
        Dim xTabel As DataTable
        Try
            If cekKoneksi() = True Then
                MySqlAdapter = New MySqlDataAdapter(Qry, MySqlconn)
                xDataset = New DataSet
                xDataset.Clear()
                MySqlAdapter.Fill(xDataset, "tb_user")
                xTabel = xDataset.Tables("tb_user")
            End If
        Catch ex As Exception
            MessageBox.Show("Data Tidak Tereksekusi oleh DBMS")

        End Try
        Return xTabel
    End Function
End Class
