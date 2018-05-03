Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim xConn As New koneksi

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.RowCount > 0 Then
            Dim baris As Integer
            With DataGridView1
                baris = .CurrentRow.Index
                TextBox1.Text = .Item(1, baris).Value
                TextBox2.Text = .Item(2, baris).Value
                ComboBox1.Text = .Item(3, baris).Value

                If .Item(4, baris).Value = 1 Then
                    CheckBox1.Checked = True
                ElseIf .Item(4, baris).Value = 0 Then
                    CheckBox1.Checked = False
                End If

                TextBox1.Enabled = True
                TextBox1.Focus()

            End With
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        CheckBox1.Text = ""
        ComboBox1.Text = ""
        CheckBox1.Checked = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            xConn.xFungsiQuery("INSERT INTO tb_user (username,password,level,flag) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.Text & "', '" & 1 & "')")
        Else
            xConn.xFungsiQuery("INSERT INTO tb_user (username,password,level,flag) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.Text & "', '" & 0 & "')")
        End If

        Dim xTabel As DataTable = xConn.xFungsiQuery("SELECT * FROM tb_user")
        DataGridView1.DataSource = xTabel
        DataGridView1.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xTabel As DataTable = xConn.xFungsiQuery("SELECT * FROM tb_user")
        DataGridView1.DataSource = xTabel
        DataGridView1.Refresh()

        'MySQLconn = New MySqlConnection(comdString)
        'If MySQLconn.State = ConnectionState.Closed Then
        '    MySQLconn.Open()
        '    MessageBox.Show("Data Terkoneksi")
        'End If
    End Sub
End Class
