Public Class Form2
    Dim MyValue As Integer
    Dim lop As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do
            lop += 1
            MyValue = CInt(Int(6 * Rnd()) + 0)
            If MyValue = TextBox1.Text Then
                Exit Do
            End If
        Loop
        MsgBox("Value " & MyValue & "looping ke " & lop)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form1 As New Form1
        Me.Hide()
        form1.Show()
    End Sub
End Class