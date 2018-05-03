Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Class1
    'Deklarasi Koneksi
    Dim MySQLconn As MySqlConnection
    Dim comdString As String = "server=localhost;user id=root;password=;database=dblatihan;SslMode=none"

    'Deklarasi Data Terkoneksi
    Dim MySqlAdapter As MySqlDataAdapter
    Dim xDataset As DataSet

    Public Function cekKoneksi()
        Dim xConn As Boolean = True
        Try
            MySQLconn = New MySqlConnection(comdString)
            If MySQLconn.State = ConnectionState.Closed Then
                MySQLconn.Open()
                MessageBox.Show("Data Terkoneksi")
                xConn = True
            End If
        Catch ex As Exception
            xConn = False
            MessageBox.Show("Aplikasi tidak dapat terhubung dengan box")
        End Try
        Return xConn
    End Function

    Public Function xFungsiQuery(Qry As String) As DataTable
        Dim xTabel As DataTable
        Try
            If cekKoneksi() = True Then
                MySqlAdapter = New MySqlDataAdapter(Qry, MySQLconn)
                xDataset = New DataSet
                xDataset.Clear()
                MySqlAdapter.Fill(xDataset, "tb_user_login")
                xTabel = xDataset.Tables("tb_user_login")
            End If
        Catch ex As Exception
            MessageBox.Show("Query Tidak dijalankan oleh DBMS")
        End Try
        Return xTabel
    End Function
End Class