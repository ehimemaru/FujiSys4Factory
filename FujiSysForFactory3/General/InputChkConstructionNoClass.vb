Public Class InputChkConstructionNoClass

    Friend Function IfInputedThen(ByRef MTBox As MaskedTextBox) As String
        Dim ReturnConstNo As String = Space(0)
        Dim ListChk As New List(Of Integer)
        Dim InputedValue As String = MTBox.Text.Replace(" ", "~")
        InputedValue = InputedValue.PadRight(11, "~"c)
        For i As Integer = 0 To 10 Step 1
            If "~".Equals(InputedValue.Substring(i, 1)) Then
                ListChk.Add(0)
            Else
                ListChk.Add(1)
            End If
        Next

        If ListChk.Sum() = 11 Then
            ReturnConstNo = MTBox.Text
        Else
            For ii As Integer = 0 To 10 Step 1
                If ListChk.Item(ii) = 0 Then
                    If ii < 6 Then
                        ReturnConstNo = Space(0)
                        Exit For
                    Else
                        ReturnConstNo = MTBox.Text.Substring(0, ii)
                        Exit For
                    End If
                End If
            Next
        End If

        Return ReturnConstNo

    End Function



End Class
