Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("Tolong masukkan salah satu kolom", "Validasi Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Login Sukses", "Konfirmasi Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Close()
            Else
                TextBox1.Text = ""
                TextBox2.Text = ""
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
