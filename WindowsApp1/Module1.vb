Module Module1
    Public value As Integer

    Public Function getValue()
        Dim MyValue As Integer
        Dim lop As Integer
        Randomize()

        Do
            lop += 1
            MyValue = CInt(Int(6 * Rnd()) + 0)
            If MyValue = value Then
                Exit Do
            End If
        Loop
        MsgBox("Value " & MyValue & "looping ke " & lop)
    End Function



End Module
