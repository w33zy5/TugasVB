Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Koneksi
    'Deklarasi Koneksi
    Dim MySQLconn As MySqlConnection
    Dim comdString As String = "server=localhost;user id=root;password=;database=dblatihankuisvb;SslMode=none"

    'Deklarasi Data Terkoneksi
    Dim MySqlAdapter As MySqlDataAdapter
    Dim xDataset As DataSet

    Public Function CekKoneksi()
        Dim konek As Boolean
        Try
            MySQLconn = New MySqlConnection(comdString)
            If MySQLconn.State = ConnectionState.Closed Then
                MySQLconn.Open()
                konek = True
            End If
        Catch ex As Exception
            konek = False
            MessageBox.Show("Aplikasi tidak dapat terhubung dengan box")
        End Try
        Return konek
    End Function

    Public Function xFungsiQuery(Qry As String) As DataTable
        Dim xTabel As DataTable
        Try
            If CekKoneksi() = True Then
                MySqlAdapter = New MySqlDataAdapter(Qry, MySQLconn)
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
