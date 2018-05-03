Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        ComboBox1.Text = ""
        DateTimePicker1.Value = Now.Date
        ComboBox2.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        Button1.BackColor = Color.Orange
        Button2.BackColor = Color.DodgerBlue
        Button3.BackColor = Color.DodgerBlue
        Button4.BackColor = Color.DodgerBlue

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Enabled = True
        ComboBox1.Enabled = True
        DateTimePicker1.Enabled = True
        TextBox2.Enabled = True
        ComboBox2.Enabled = True
        TextBox3.Enabled = True

        Button1.BackColor = Color.DodgerBlue
        Button2.BackColor = Color.Orange
        Button3.BackColor = Color.DodgerBlue
        Button4.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Deklarasi
        Dim datalist As String = ""
        'Menggabungkan
        datalist = "Nama : " & TextBox1.Text & " | Tgl : " & CStr(Format(CDate(DateTimePicker1.Value), "mm-yyyy-dd")) & " | JK" & ComboBox1.Text & Format(Val(TextBox2.Text), "+62-(###)-(########)") & " | KAB : " & ComboBox2.Text & " | KD.Rahasia : " & TextBox3.Text

        'Save
        ListBox1.Items.Add(datalist)
        'Clean Data
        TextBox1.Text = ""
        ComboBox1.Text = ""
        DateTimePicker1.Value = Now.Date
        ComboBox2.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        TextBox1.Enabled = False
        ComboBox1.Enabled = False
        DateTimePicker1.Enabled = False
        TextBox2.Enabled = False
        ComboBox2.Enabled = False
        TextBox3.Enabled = False

        Button1.BackColor = Color.DodgerBlue
        Button2.BackColor = Color.DodgerBlue
        Button3.BackColor = Color.Orange
        Button4.BackColor = Color.DodgerBlue
    End Sub

    Private intIndex As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Button1.BackColor = Color.DodgerBlue
        Button2.BackColor = Color.DodgerBlue
        Button3.BackColor = Color.DodgerBlue
        Button4.BackColor = Color.Orange
    End Sub
End Class
