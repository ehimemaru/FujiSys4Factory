Public Class IFFRMOPENTHENCLOSE


    Friend Sub DoIfFrmOpenThenClose(ByRef TargetForm As Form)
        'Dim FormText As String = TargetForm.Text
        'Dim StrMsg As String = "選択された画面は既に開かれています。『" & FormText & "』" & _
        '    System.Environment.NewLine & "開き直してもよろしいですか？"

        If TargetForm.Visible Then
            TargetForm.Close()
        End If

    End Sub

End Class
