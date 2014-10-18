Public Class 月別日報集計表Form

    Private Sub 月別日報集計表Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Dim iYear As Integer = Today.Year
        Dim ListTerms As New List(Of String)
        ListTerms.Add(iYear.ToString)
        ListTerms.Add((iYear - 1).ToString)
        ListTerms.Add((iYear - 2).ToString)
        Me.SelectTermComboBox.DataSource = ListTerms

        Me.日報部署dtblTableAdapter1.Fill(Me.DailyWorksDataSet.日報部署dtbl)

        Dim iNum As Integer = 0
        Dim NumByPart As New NumberOfPeopleByPartClass
        iNum = NumByPart.部署人数tableSet(Me.部署人数DataGridView)
        Me.合計人数TextBox.Text = iNum.ToString("N0")
        Me.部署人数DataGridView.ClearSelection()

    End Sub


    Private Sub CountingGo()

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim SelectedYear As String = Me.SelectTermComboBox.Text

            Dim DateA As Date = Date.ParseExact(SelectedYear & "/05/01", "yyyy/MM/dd", Nothing)
            Dim DateB As Date = DateA.AddYears(1).AddDays(-1)

            Me.月別工数集計部署一覧TOPdtblTableAdapter.Fill(Me.DailyWorksDataSet.月別工数集計部署一覧TOPdtbl, DateA, DateB, 3)
            Me.月別工数集計部署別dtblTableAdapter.Fill(Me.DailyWorksDataSet.月別工数集計部署別dtbl, DateA, DateB, 3)



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub FilterGo(ByVal PartID As String)

        Try
            Me.Cursor = Cursors.WaitCursor

            Me.DailyWorksDataSet.月別工数集計表示用dtbl.Clear()

            If Space(0).Equals(PartID) Then
                '全体

                '新規行を作成（１．工数計、２.人数、３．平均、４．外業、５．ＸＹＺ）
                Dim drNew1 As DailyWorksDataSet.月別工数集計表示用dtblRow = Me.DailyWorksDataSet.月別工数集計表示用dtbl.New月別工数集計表示用dtblRow
                drNew1.項目 = "１．工数計"
                Dim drNew2 As DailyWorksDataSet.月別工数集計表示用dtblRow = Me.DailyWorksDataSet.月別工数集計表示用dtbl.New月別工数集計表示用dtblRow
                drNew2.項目 = "２．人数"
                Dim drNew3 As DailyWorksDataSet.月別工数集計表示用dtblRow = Me.DailyWorksDataSet.月別工数集計表示用dtbl.New月別工数集計表示用dtblRow
                drNew3.項目 = "３．平均"
                Dim drNew4 As DailyWorksDataSet.月別工数集計表示用dtblRow = Me.DailyWorksDataSet.月別工数集計表示用dtbl.New月別工数集計表示用dtblRow
                drNew4.項目 = "４．外業"
                Dim drNew5 As DailyWorksDataSet.月別工数集計表示用dtblRow = Me.DailyWorksDataSet.月別工数集計表示用dtbl.New月別工数集計表示用dtblRow
                drNew5.項目 = "５．XYZ"
                Dim drNew6 As DailyWorksDataSet.月別工数集計表示用dtblRow = Me.DailyWorksDataSet.月別工数集計表示用dtbl.New月別工数集計表示用dtblRow
                drNew6.項目 = "６．工場内"

                For Each drow As DailyWorksDataSet.月別工数集計部署一覧TOPdtblRow In Me.DailyWorksDataSet.月別工数集計部署一覧TOPdtbl.Rows
                    Dim ColName As String = drow.月.ToString
                    drNew1.Item(ColName) = drow.合計
                    drNew2.Item(ColName) = drow.人数
                    drNew3.Item(ColName) = drow.平均
                    drNew4.Item(ColName) = drow.外業工数
                    drNew5.Item(ColName) = drow.XYZ工数
                    drNew6.Item(ColName) = drow.工場内工数
                Next

                '行追加
                With Me.DailyWorksDataSet.月別工数集計表示用dtbl
                    .Add月別工数集計表示用dtblRow(drNew1)
                    .Add月別工数集計表示用dtblRow(drNew2)
                    .Add月別工数集計表示用dtblRow(drNew3)
                    .Add月別工数集計表示用dtblRow(drNew4)
                    .Add月別工数集計表示用dtblRow(drNew5)
                    .Add月別工数集計表示用dtblRow(drNew6)
                End With


                Me.部署人数DataGridView.ClearSelection()

            Else
                '部署別
                Dim drResults = From drow In Me.DailyWorksDataSet.月別工数集計部署別dtbl.AsEnumerable _
                               Where drow.部署ＩＤ = PartID _
                               Select drow

                For Each drResult In drResults
                    Dim drNew As DailyWorksDataSet.月別工数集計表示用dtblRow = Me.DailyWorksDataSet.月別工数集計表示用dtbl.New月別工数集計表示用dtblRow
                    drNew.項目 = drResult.項目

                    For i As Integer = 1 To 12 Step 1
                        Dim ColName As String = i.ToString
                        drNew.Item(ColName) = drResult.Item(ColName)
                    Next

                    Me.DailyWorksDataSet.月別工数集計表示用dtbl.Add月別工数集計表示用dtblRow(drNew)
                Next

                Dim drNew6 As DailyWorksDataSet.月別工数集計表示用dtblRow = Me.DailyWorksDataSet.月別工数集計表示用dtbl.New月別工数集計表示用dtblRow
                drNew6.項目 = "６．工場内"

                Dim MonthValue(11) As Decimal
                Dim iChk As Integer = 0
                For Each dr As DailyWorksDataSet.月別工数集計表示用dtblRow In Me.DailyWorksDataSet.月別工数集計表示用dtbl.Rows
                    Select Case dr.項目
                        Case "１．工数計"
                            iChk = 1
                        Case "４．外業", "５．XYZ"
                            iChk = -1
                        Case Else
                            iChk = 0
                    End Select

                    For i As Integer = 1 To 12 Step 1
                        Dim ColName As String = i.ToString
                        Dim DValue As Decimal = 0

                        If IsDBNull(dr.Item(ColName)) = False Then
                            DValue = CDec(dr.Item(ColName))
                        End If


                        If DValue <> 0 AndAlso iChk = 1 Then
                            MonthValue(i - 1) += DValue
                        ElseIf DValue <> 0 AndAlso iChk = -1 Then
                            MonthValue(i - 1) -= DValue
                        End If
                    Next
                Next

                For i As Integer = 1 To 12 Step 1
                    Dim ColName As String = i.ToString
                    If IsNumeric(MonthValue(i - 1)) = True Then
                        If MonthValue(i - 1) = 0 Then
                            drNew6.Item(ColName) = DBNull.Value
                        Else
                            drNew6.Item(ColName) = MonthValue(i - 1)
                        End If
                    End If
                Next

                Me.DailyWorksDataSet.月別工数集計表示用dtbl.Add月別工数集計表示用dtblRow(drNew6)

            End If


            グラフ表示()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub 月別日報集計表Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CountingGo()
        FilterGo(Space(0))

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub 部署人数DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 部署人数DataGridView.CellClick
        If e.RowIndex = 0 And e.ColumnIndex > -1 Then
            Dim PartID As String = Space(0)
            Dim PartName As String = Me.部署人数DataGridView.Columns(e.ColumnIndex).HeaderText
            Dim PartIDs = (From dr In Me.DailyWorksDataSet.日報部署dtbl.AsEnumerable _
                                      Where dr.部署名 = PartName _
                                      Select dr.部署ＩＤ)

            'System.Console.WriteLine(PartID(0))
            PartID = PartIDs(0).ToString

            FilterGo(PartID)

        End If
    End Sub

    Private Sub DisplayAllButton_Click(sender As Object, e As EventArgs) Handles DisplayAllButton.Click
        FilterGo(Space(0))

    End Sub

    Private Sub SelectTermComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectTermComboBox.SelectedIndexChanged
        CountingGo()
        FilterGo(Space(0))

    End Sub


    Private Sub グラフ表示()
        Dim MyChart As System.Windows.Forms.DataVisualization.Charting.Chart = DirectCast(Me.月別日報集計表Chart, System.Windows.Forms.DataVisualization.Charting.Chart)

        'グラフ表示
        Dim YMaxValue As Decimal = 0D
        MyChart.Series.Clear()
        For Each dr As DailyWorksDataSet.月別工数集計表示用dtblRow In Me.DailyWorksDataSet.月別工数集計表示用dtbl.Rows

            If "２．人数".Equals(dr.項目) = False AndAlso "３．平均".Equals(dr.項目) = False Then
                Dim SeriesNew As New System.Windows.Forms.DataVisualization.Charting.Series

                Dim RowName As String = dr.項目

                Select Case RowName
                    Case "１．工数計"
                        SeriesNew.ChartType = DataVisualization.Charting.SeriesChartType.Column
                        Dim ListMax As New List(Of Decimal)
                        For iCol As Integer = 1 To Me.DailyWorksDataSet.月別工数集計表示用dtbl.Columns.Count - 1
                            Dim drValue As Decimal = 0D
                            If Decimal.TryParse(dr(iCol).ToString, drValue) = True Then
                                ListMax.Add(drValue)
                            End If
                        Next
                        YMaxValue = ListMax.Max

                    Case "４．外業", "５．XYZ", "６．工場内"
                        SeriesNew.ChartType = DataVisualization.Charting.SeriesChartType.Line
                        SeriesNew.BorderWidth = 5
                        SeriesNew.MarkerSize = 10
                        'Case "３．平均"
                        '    SeriesNew.ChartType = DataVisualization.Charting.SeriesChartType.Line
                        '    SeriesNew.YAxisType = DataVisualization.Charting.AxisType.Secondary
                        '    SeriesNew.BorderWidth = 5
                        '    SeriesNew.MarkerSize = 10
                End Select

                SeriesNew.Name = dr.項目.ToString

                SeriesNew.MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                For Each DgvCol As DataColumn In Me.DailyWorksDataSet.月別工数集計表示用dtbl.Columns
                    Dim ColName As String = DgvCol.ColumnName
                    If "項目".Equals(ColName) = False Then
                        SeriesNew.Points.AddXY(ColName, dr(ColName))
                    End If
                Next

                SeriesNew.LegendText = dr.項目
                MyChart.Series.Add(SeriesNew)
            End If

            YMaxValue /= 1000
            YMaxValue = Math.Ceiling(YMaxValue)
            YMaxValue *= 1000

            MyChart.ChartAreas(0).AxisY.Maximum = YMaxValue
            MyChart.ChartAreas(0).AxisX.Interval = 1
            'MyChart.ChartAreas(0).AxisY2.Maximum = 11
        Next
    End Sub


    Private Sub 月別日報集計表Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class