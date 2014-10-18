Public Class HolidaysClass

    Friend Function GetListOfHolidays(ByVal _DaA As Date, ByVal _DaB As Date) As List(Of Date)
        Dim ReturnList As New List(Of Date)

        Dim StrSql As String = "SELECT 休日 FROM Fuji.Ｍ会社休日 WHERE (休日 BETWEEN @DateA AND @DateB) ORDER BY 休日"

        Using Cnn As New SqlClient.SqlConnection(My.Settings.FujiSysConnectionString)
            Using Cmd As New SqlClient.SqlCommand(StrSql, Cnn)
                With Cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@DateA", _DaA)
                    .Parameters.AddWithValue("@DateB", _DaB)
                End With

                Cnn.Open()
                Dim dReader As SqlClient.SqlDataReader = Cmd.ExecuteReader
                If dReader.HasRows Then
                    Do While dReader.Read
                        ReturnList.Add(dReader.GetDateTime(0))
                    Loop
                End If
            End Using
        End Using

        Return ReturnList
    End Function


End Class
