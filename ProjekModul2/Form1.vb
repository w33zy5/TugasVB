Public Class Form1
    Dim i As Integer
    Dim zodiak As String
    Dim nama As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 31
            ComboBox1.Items.Add(i)
        Next
        For i = 1 To 12
            ComboBox2.Items.Add(MonthName(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nama = TextBox1.Text
        If ComboBox1.SelectedIndex > 21 And ComboBox2.SelectedItem = "December" Or ComboBox1.SelectedIndex < 20 And ComboBox2.SelectedItem = "January" Then
            zodiak = "Capricorn"
        ElseIf ComboBox1.SelectedIndex > 19 And ComboBox2.SelectedItem = "January" Or ComboBox1.SelectedIndex < 18 And ComboBox2.SelectedItem = "February" Then
            zodiak = "Aquarius"
        ElseIf ComboBox1.SelectedIndex > 17 And ComboBox2.SelectedItem = "February" Or ComboBox1.SelectedIndex < 20 And ComboBox2.SelectedItem = "March" Then
            zodiak = "Pisces"
        ElseIf ComboBox1.SelectedIndex > 19 And ComboBox2.SelectedItem = "March" Or ComboBox1.SelectedIndex < 20 And ComboBox2.SelectedItem = "April" Then
            zodiak = "Aries"
        ElseIf ComboBox1.SelectedIndex > 19 And ComboBox2.SelectedItem = "April" Or ComboBox1.SelectedIndex < 20 And ComboBox2.SelectedItem = "May" Then
            zodiak = "Taurus"
        ElseIf ComboBox1.SelectedIndex > 19 And ComboBox2.SelectedItem = "May" Or ComboBox1.SelectedIndex < 21 And ComboBox2.SelectedItem = "June" Then
            zodiak = "Gemini"
        ElseIf ComboBox1.SelectedIndex > 20 And ComboBox2.SelectedItem = "June" Or ComboBox1.SelectedIndex < 22 And ComboBox2.SelectedItem = "July" Then
            zodiak = "Cancer"
        ElseIf ComboBox1.SelectedIndex > 21 And ComboBox2.SelectedItem = "July" Or ComboBox1.SelectedIndex < 23 And ComboBox2.SelectedItem = "August" Then
            zodiak = "Leo"
        ElseIf ComboBox1.SelectedIndex > 22 And ComboBox2.SelectedItem = "August" Or ComboBox1.SelectedIndex < 22 And ComboBox2.SelectedItem = "September" Then
            zodiak = "Virgo"
        ElseIf ComboBox1.SelectedIndex > 21 And ComboBox2.SelectedItem = "September" Or ComboBox1.SelectedIndex < 23 And ComboBox2.SelectedItem = "October" Then
            zodiak = "Libra"
        ElseIf ComboBox1.SelectedIndex > 22 And ComboBox2.SelectedItem = "October" Or ComboBox1.SelectedIndex < 22 And ComboBox2.SelectedItem = "November" Then
            zodiak = "Scorpio"
        ElseIf ComboBox1.SelectedIndex > 21 And ComboBox2.SelectedItem = "November" Or ComboBox1.SelectedIndex < 22 And ComboBox2.SelectedItem = "December" Then
            zodiak = "Sagitarius"
        End If

        TextBox1.Text = nama & ", anda lahir pada " & ComboBox1.Text & " bulan " & ComboBox2.Text & " berzodiak " & zodiak
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each a As Control In Me.Controls
            If TypeOf (a) Is TextBox Or TypeOf (a) Is ComboBox Then
                a.Text = ""
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form2 As New Form2
        Me.Hide()
        form2.Show()
    End Sub
End Class
