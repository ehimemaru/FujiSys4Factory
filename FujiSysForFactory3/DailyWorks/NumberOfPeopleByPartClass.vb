Public Class NumberOfPeopleByPartClass


    Friend Function 部署人数tableSet(ByRef NumByPartDGV As DataGridView) As Integer
        Dim iReturn As Integer = 0

        Dim NumOfPeopleByPartadp As New DailyWorksDataSetTableAdapters.日報工場部署人数dtblTableAdapter
        Dim NumOfPartDtbl As New DailyWorksDataSet.日報工場部署人数dtblDataTable
        NumOfPeopleByPartadp.Fill(NumOfPartDtbl)

        Dim dtDisplay As New DataTable

        For Each dr As DailyWorksDataSet.日報工場部署人数dtblRow In NumOfPartDtbl.Rows
            dtDisplay.Columns.Add(dr.部署名, GetType(Integer))
        Next

        Dim drN As DataRow = dtDisplay.NewRow
        For i As Integer = 0 To NumOfPartDtbl.Rows.Count - 1
            Dim drX As DailyWorksDataSet.日報工場部署人数dtblRow = DirectCast(NumOfPartDtbl.Rows(i), DailyWorksDataSet.日報工場部署人数dtblRow)
            drN.Item(i) = drX.人数
        Next
        dtDisplay.Rows.Add(drN)

        'Dim BtnColType As New Windows.Forms.DataGridViewButtonColumn
        'Me.部署人数DataGridView.Columns.Add(BtnColType)
        NumByPartDGV.DataSource = dtDisplay
        For Each DgvCol As DataGridViewColumn In NumByPartDGV.Columns
            DgvCol.Width = 85
            DgvCol.DefaultCellStyle.Format = "N0"
            DgvCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next
        NumByPartDGV.ClearSelection()


        iReturn = (From dr In NumOfPartDtbl.AsEnumerable _
                   Select dr.人数).Sum


        Return iReturn
    End Function




End Class
