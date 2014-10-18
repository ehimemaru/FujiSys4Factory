Public Class 工場負荷

    Dim ListHolidays As List(Of Date)
    Dim ListCategory As List(Of String)

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        ListHolidays = New List(Of Date)

        ListCategory = New List(Of String)
        ListCategory.Add("予算通常")
        ListCategory.Add("予算外業")
        ListCategory.Add("予算XYZ")
        ListCategory.Add("実績通常")
        ListCategory.Add("実績外業")
        ListCategory.Add("実績XYZ")
    End Sub


    Private Sub 工場負荷_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Dim BaseDatA As Date = Today.AddDays(-10)
        Dim BaseDatB As Date = Today.AddDays(30)

        Me.InputedDateAMaskedTextBox.Text = BaseDatA.ToShortDateString
        Me.InputedDateBMaskedTextBox.Text = BaseDatB.ToShortDateString


        Me.Panel1.Width = Me.SplitContainer2.Panel2.Width - 40

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub


    Private Sub DisChangeButton_Click(sender As Object, e As EventArgs) Handles DisChangeButton.Click
        Dim iDistance As New List(Of Integer)
        With iDistance
            .Add(370)
            .Add(460)
        End With


        For i As Integer = 1 To 9 Step 1
            Dim Col As DataGridViewColumn = Me.工場負荷集計DataGridView.Columns(i)

            Col.Visible = Not Col.Visible
        Next


        If Me.SplitContainer2.SplitterDistance = iDistance.Item(0) Then
            Me.SplitContainer2.SplitterDistance = iDistance.Item(1)
        Else
            Me.SplitContainer2.SplitterDistance = iDistance.Item(0)
        End If

        Me.Panel1.Width = Me.SplitContainer2.Panel2.Width - 40
    End Sub

    Private Sub 工場負荷_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If InputCheck() = False Then
            Exit Sub
        End If

        表示実行()

        VScrollBarSetValue()

        'DGV書式設定()
        Me.Validate()

        DGV休日書式設定()

    End Sub

    Private Sub 表示実行()

        Dim BaseDatA As Date = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
        Dim BaseDatB As Date = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)

        If BaseDatA > BaseDatB Then
            Dim DatWork As Date = BaseDatA
            BaseDatA = BaseDatB
            BaseDatB = DatWork
        End If


        '工程予算
        Me.工場負荷工程予算dtblTadp1.Fill(Me.工場負荷DataSet1.工場負荷工程予算dtbl, BaseDatA, BaseDatB)
        '日報
        Me.工場負荷日報dtblTadp1.Fill(Me.工場負荷DataSet1.工場負荷日報dtbl, BaseDatA, BaseDatB)
        '日報人数
        Me.工場実績人数dtblTadp1.Fill(Me.工場負荷DataSet1.工場実績人数dtbl, BaseDatA, BaseDatB)
        '休日取得
        'ListHolidays = GetHolidays(BaseDatA, BaseDatB)
        Dim Holi As New HolidaysClass
        ListHolidays = Holi.GetListOfHolidays(BaseDatA, BaseDatB)

        Me.工場負荷DataSet1.工場負荷ワークdtbl.Clear()

        '工程予算 →　日別の工数情報へ
        日分割工程予算(Me.工場負荷DataSet1.工場負荷工程予算dtbl, Me.工場負荷DataSet1.工場負荷ワークdtbl, BaseDatA, BaseDatB)



        Try
            Me.Cursor = Cursors.WaitCursor
            '日報 → 日別の情報へ(Work)

            For Each drDayWork As 工場負荷DataSet.工場負荷日報dtblRow In Me.工場負荷DataSet1.工場負荷日報dtbl.Rows
                Dim drWork2 As 工場負荷DataSet.工場負荷ワークdtblRow = Me.工場負荷DataSet1.工場負荷ワークdtbl.New工場負荷ワークdtblRow

                drWork2.日付 = drDayWork.作業日
                Dim ConstructionNo As String = drDayWork.工事番号
                If ConstructionNo.Contains("X") OrElse ConstructionNo.Contains("Y") OrElse ConstructionNo.Contains("Z") Then
                    drWork2.種類 = ListCategory(5)
                Else
                    Dim ProcessID As String = drDayWork.工程ＩＤ
                    If "46".Equals(ProcessID.Substring(0, 2)) Then
                        drWork2.種類 = ListCategory(4)
                    Else
                        drWork2.種類 = ListCategory(3)
                    End If
                End If
                drWork2.日毎社工 = drDayWork.作業時間
                drWork2.部署ＩＤ = drDayWork.部署ＩＤ
                drWork2.生管確定日時 = Today

                Me.工場負荷DataSet1.工場負荷ワークdtbl.Add工場負荷ワークdtblRow(drWork2)
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try



        '生管確定後のみかどうか
        Dim FlgAfManageOnly As Integer = 1
        If Me.生管確定のみRadioButton.Checked = False Then
            FlgAfManageOnly = 0
        End If



        '集計　ワークテーブルより集計
        集計処理(Me.工場負荷DataSet1.工場負荷ワークdtbl, Me.工場負荷DataSet1.工場負荷集計dtbl, Me.工場負荷DataSet1.工場実績人数dtbl, _
              BaseDatA, BaseDatB, Space(0), FlgAfManageOnly)


        'グラフ描画
        グラフ表示処理(Me.工場負荷DataSet1.工場負荷集計dtbl)



        Try
            Me.Cursor = Cursors.WaitCursor

            '部署人数表示用
            Me.工場部署人数dtblTadp1.Fill(Me.工場負荷DataSet1.工場部署人数dtbl)

            Me.合計人数TextBox.Text = (From dr In Me.工場負荷DataSet1.工場部署人数dtbl.AsEnumerable _
                                   Select dr.人数).Sum().ToString

            Dim dtDisplay As New DataTable

            For Each dr As 工場負荷DataSet.工場部署人数dtblRow In Me.工場負荷DataSet1.工場部署人数dtbl.Rows
                dtDisplay.Columns.Add(dr.部署名, GetType(Integer))
            Next
            Dim drN As DataRow = dtDisplay.NewRow
            For i As Integer = 0 To Me.工場負荷DataSet1.工場部署人数dtbl.Rows.Count - 1
                Dim drX As 工場負荷DataSet.工場部署人数dtblRow = DirectCast(Me.工場負荷DataSet1.工場部署人数dtbl(i), 工場負荷DataSet.工場部署人数dtblRow)
                drN.Item(i) = drX.人数
            Next
            dtDisplay.Rows.Add(drN)

            Me.部署人数DataGridView.DataSource = dtDisplay
            For Each DgvCol As DataGridViewColumn In Me.部署人数DataGridView.Columns
                DgvCol.Width = 75
                DgvCol.DefaultCellStyle.Format = "N0"
                DgvCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub 日分割工程予算(ByRef BudgetTbl As 工場負荷DataSet.工場負荷工程予算dtblDataTable, ByRef WorkTbl As 工場負荷DataSet.工場負荷ワークdtblDataTable _
                        , ByVal BaseDatA As Date, ByVal BaseDatB As Date)

        Try

            '工程予算　→　日別の情報へ(Work)
            For Each drowBase As 工場負荷DataSet.工場負荷工程予算dtblRow In BudgetTbl.Rows

                Dim WorkDatA As Date = BaseDatA
                Dim WorkDatB As Date = BaseDatB

                If BaseDatA < drowBase.工程期間始 Then
                    WorkDatA = drowBase.工程期間始
                End If
                If BaseDatB > drowBase.工程期間終 Then
                    WorkDatB = drowBase.工程期間終
                End If

                Dim DatX As Date = WorkDatA
                Do While DatX <= WorkDatB
                    If ListHolidays.Contains(DatX) AndAlso drowBase.土曜含 = 0 Then

                    ElseIf DatX.DayOfWeek = DayOfWeek.Sunday AndAlso drowBase.日曜含 = 0 Then

                    Else
                        Dim drNewWork As 工場負荷DataSet.工場負荷ワークdtblRow = WorkTbl.New工場負荷ワークdtblRow
                        With drNewWork
                            Dim ConstructionNo As String = drowBase.工事番号
                            'XYZ
                            If ConstructionNo.Contains("X") OrElse ConstructionNo.Contains("Y") OrElse ConstructionNo.Contains("Z") Then
                                .種類 = ListCategory(2)
                            Else
                                Dim ProcessID As String = drowBase.工程ＩＤ
                                '外業
                                If "46".Equals(ProcessID.Substring(0, 2)) Then
                                    .種類 = ListCategory(1)
                                Else
                                    .種類 = ListCategory(0)
                                End If
                            End If

                            .日付 = DatX
                            .日毎社工 = drowBase.日毎社工
                            .部署ＩＤ = drowBase.部署ＩＤ
                            If drowBase.Is生管確定日時Null Then
                                .Set生管確定日時Null()
                            Else
                                .生管確定日時 = drowBase.生管確定日時
                            End If

                            WorkTbl.Add工場負荷ワークdtblRow(drNewWork)
                        End With
                    End If
                    DatX = DatX.AddDays(1)
                Loop
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub 集計処理(ByRef WorkTbl As 工場負荷DataSet.工場負荷ワークdtblDataTable, ByRef TotalTbl As 工場負荷DataSet.工場負荷集計dtblDataTable _
                     , ByRef WorkedNumOfPeoPleTbl As 工場負荷DataSet.工場実績人数dtblDataTable, _
                     ByVal BaseDatA As Date, ByVal BaseDatB As Date, ByVal PartID As String, ByVal FlgAfManageOnly As Integer)

        Try
            TotalTbl.Clear()


            Dim DatXX As Date = BaseDatA
            Do While DatXX <= BaseDatB
                Dim drNew As 工場負荷DataSet.工場負荷集計dtblRow = TotalTbl.New工場負荷集計dtblRow

                drNew.日付 = DatXX

                '条件処理
                For Each lt In ListCategory
                    Dim DecResult As Decimal = 0D
                    If Space(0).Equals(PartID) AndAlso FlgAfManageOnly = 1 Then
                        '部署無し、生管確定後のみ
                        DecResult = (From dr In WorkTbl.AsEnumerable _
                                                          Where dr.種類 = lt AndAlso dr.日付 = DatXX AndAlso Not dr.Is生管確定日時Null _
                                                          Select dr.日毎社工).Sum()
                    ElseIf Space(0).Equals(PartID) AndAlso FlgAfManageOnly = 0 Then
                        '部署無し、全て
                        DecResult = (From dr In WorkTbl.AsEnumerable _
                                                          Where dr.種類 = lt AndAlso dr.日付 = DatXX _
                                                          Select dr.日毎社工).Sum()

                    ElseIf FlgAfManageOnly = 1 Then
                        '部署有り、生管確定後のみ
                        DecResult = (From dr In WorkTbl.AsEnumerable _
                                                          Where dr.種類 = lt AndAlso dr.日付 = DatXX AndAlso dr.部署ＩＤ = PartID AndAlso Not dr.Is生管確定日時Null _
                                                          Select dr.日毎社工).Sum()
                    Else
                        '部署有り、全て
                        DecResult = (From dr In WorkTbl.AsEnumerable _
                                                          Where dr.種類 = lt AndAlso dr.日付 = DatXX AndAlso dr.部署ＩＤ = PartID _
                                                          Select dr.日毎社工).Sum()
                    End If

                    Dim DecX As Decimal = 0D
                    If IsNothing(DecResult) = False Then
                        DecX = DecResult
                    End If
                    drNew(lt) = DecX
                Next

                '日報よりの人数を追加
                Dim WorkedNumOfPeople As Decimal = 0D
                If Space(0).Equals(PartID) Then
                    WorkedNumOfPeople = (From dr In WorkedNumOfPeoPleTbl.AsEnumerable _
                                         Where dr.作業日 = DatXX _
                                         Select dr.人数).Sum()
                Else
                    WorkedNumOfPeople = (From dr In WorkedNumOfPeoPleTbl.AsEnumerable _
                                         Where dr.作業日 = DatXX AndAlso dr.部署ＩＤ = PartID _
                                         Select dr.人数).Sum()
                End If
                drNew.実績人数 = WorkedNumOfPeople

                'If IsNothing(drRowNum) = False Then
                '    drNew.実績人数 = drRowNum.人数
                'End If

                TotalTbl.Add工場負荷集計dtblRow(drNew)
                DatXX = DatXX.AddDays(1)
            Loop
            Me.工場負荷集計BindingSource.EndEdit()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub グラフ表示処理(ByRef TotalTbl As 工場負荷DataSet.工場負荷集計dtblDataTable)

        Try
            Me.工場負荷Chart.Series.Clear()

            '最大値を取得
            Dim MaxA As Decimal = (From dr In TotalTbl.AsEnumerable _
                                   Select dr.実績合計).Max

            Dim MaxB As Decimal = (From dr In TotalTbl.AsEnumerable _
                                   Select dr.予算合計).Max

            Dim MaxX As Decimal = MaxA
            If MaxB > MaxA Then
                MaxX = MaxB
            End If
            MaxA = Math.Ceiling(MaxX / 10) * 10


            Dim listSeries As New List(Of System.Windows.Forms.DataVisualization.Charting.Series)



            Dim SeriesBudgetNomal As New System.Windows.Forms.DataVisualization.Charting.Series
            SeriesBudgetNomal.Name = "予算通常"
            SeriesBudgetNomal.Color = Color.CornflowerBlue
            Dim SeriesBudgetOutWork As New System.Windows.Forms.DataVisualization.Charting.Series
            SeriesBudgetOutWork.Name = "予算外業"
            SeriesBudgetOutWork.Color = Color.LightSkyBlue
            Dim SeriesBudgetXYZ As New System.Windows.Forms.DataVisualization.Charting.Series
            SeriesBudgetXYZ.Name = "予算XYZ"
            SeriesBudgetXYZ.Color = Color.PaleTurquoise
            Dim SeriesResultNomal As New System.Windows.Forms.DataVisualization.Charting.Series
            SeriesResultNomal.YAxisType = DataVisualization.Charting.AxisType.Secondary
            SeriesResultNomal.Name = "実績通常"
            SeriesResultNomal.Color = Color.OrangeRed
            Dim SeriesResultOutwork As New System.Windows.Forms.DataVisualization.Charting.Series
            SeriesResultOutwork.YAxisType = DataVisualization.Charting.AxisType.Secondary
            SeriesResultOutwork.Name = "実績外業"
            SeriesResultOutwork.Color = Color.Salmon
            Dim SeriesResultXYZ As New System.Windows.Forms.DataVisualization.Charting.Series
            SeriesResultXYZ.YAxisType = DataVisualization.Charting.AxisType.Secondary
            SeriesResultXYZ.Name = "実績XYZ"
            SeriesResultXYZ.Color = Color.Orange

            listSeries.Add(SeriesBudgetNomal)
            listSeries.Add(SeriesBudgetOutWork)
            listSeries.Add(SeriesBudgetXYZ)
            listSeries.Add(SeriesResultNomal)
            listSeries.Add(SeriesResultOutwork)
            listSeries.Add(SeriesResultXYZ)

            For Each ls In listSeries
                ls.ChartType = DataVisualization.Charting.SeriesChartType.StackedBar
                ls.IsValueShownAsLabel = True
                ls.LabelFormat = "#,###"
            Next

            For Each drTotal As 工場負荷DataSet.工場負荷集計dtblRow In TotalTbl.Rows
                Dim DatX As Date = drTotal.日付

                With drTotal
                    listSeries(0).Points.AddXY(DatX, .予算通常)
                    listSeries(1).Points.AddXY(DatX, .予算外業)
                    listSeries(2).Points.AddXY(DatX, .予算XYZ)
                    listSeries(3).Points.AddXY(DatX, .実績通常)
                    listSeries(4).Points.AddXY(DatX, .実績外業)
                    listSeries(5).Points.AddXY(DatX, .実績XYZ)
                End With
            Next

            With Me.工場負荷Chart.Series
                For Each ls In listSeries
                    .Add(ls)
                Next
            End With

            Me.工場負荷Chart.ChartAreas(0).AxisY.Maximum = MaxX
            Me.工場負荷Chart.ChartAreas(0).AxisY2.Maximum = MaxX
            Me.工場負荷Chart.ChartAreas(0).AxisX.MajorGrid.Interval = 2
            Me.工場負荷Chart.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Silver
            Me.工場負荷Chart.ChartAreas(0).AxisY.MajorGrid.Interval = 100
            Me.工場負荷Chart.ChartAreas(0).AxisY.MinorGrid.Enabled = True
            Me.工場負荷Chart.ChartAreas(0).AxisY.MinorGrid.Interval = 25
            Me.工場負荷Chart.ChartAreas(0).AxisY.MinorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dot


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub DGV休日書式設定()
        Dim DgvCellNavaja As New DataGridViewCellStyle
        DgvCellNavaja.BackColor = Color.NavajoWhite

        Dim DgvCellSteelBlue As New DataGridViewCellStyle
        DgvCellSteelBlue.BackColor = Color.LightSteelBlue

        For Each DgvRow As DataGridViewRow In Me.工場負荷集計DataGridView.Rows
            Dim DatY As Date = DirectCast(DgvRow.Cells(0).Value, Date)

            If DatY.DayOfWeek = DayOfWeek.Sunday Then
                DgvRow.Cells(0).Style = DgvCellNavaja
            ElseIf ListHolidays.Contains(DatY) Then
                DgvRow.Cells(0).Style = DgvCellSteelBlue
            End If
        Next

        Me.ActiveControl = Me.工場負荷集計DataGridView
        Me.工場負荷集計DataGridView.ClearSelection()
        Me.工場負荷集計DataGridView.CurrentCell = Nothing

        Me.ActiveControl = Me.部署人数DataGridView
        Me.部署人数DataGridView.ClearSelection()
        Me.部署人数DataGridView.CurrentCell = Nothing

    End Sub


    Private Sub 部署人数DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 部署人数DataGridView.CellClick
        If e.ColumnIndex < 0 Then
            Exit Sub
        End If

        '部署絞込のため部署ＩＤを取得
        Dim PartID As String = Space(0)

        Dim iColNo As Integer = e.ColumnIndex
        Dim PartName As String = Me.部署人数DataGridView.Columns(iColNo).Name

        Dim result = From dr In Me.工場負荷DataSet1.工場部署人数dtbl.AsEnumerable _
                     Where dr.部署名 = PartName _
                     Select dr.部署ＩＤ

        PartID = result(0)

        Dim DatA As Date = (From dr In Me.工場負荷DataSet1.工場負荷ワークdtbl.AsEnumerable _
                            Select dr.日付).Min()

        Dim DatB As Date = (From dr In Me.工場負荷DataSet1.工場負荷ワークdtbl.AsEnumerable _
                            Select dr.日付).Max()


        '生管確定後のみかどうか
        Dim FlgAfManageOnly As Integer = 1
        If Me.生管確定のみRadioButton.Checked = False Then
            FlgAfManageOnly = 0
        End If


        '集計　ワークテーブルより集計
        集計処理(Me.工場負荷DataSet1.工場負荷ワークdtbl, Me.工場負荷DataSet1.工場負荷集計dtbl, Me.工場負荷DataSet1.工場実績人数dtbl, _
              DatA, DatB, PartID, FlgAfManageOnly)


        'グラフ描画
        グラフ表示処理(Me.工場負荷DataSet1.工場負荷集計dtbl)


        DGV休日書式設定()

    End Sub

    Private Sub DisplayAllButton_Click(sender As Object, e As EventArgs) Handles DisplayAllButton.Click
        Dim DatA As Date = (From dr In Me.工場負荷DataSet1.工場負荷ワークdtbl.AsEnumerable _
                            Select dr.日付).Min()

        Dim DatB As Date = (From dr In Me.工場負荷DataSet1.工場負荷ワークdtbl.AsEnumerable _
                            Select dr.日付).Max()


        '生管確定後のみかどうか
        Dim FlgAfManageOnly As Integer = 1
        If Me.生管確定のみRadioButton.Checked = False Then
            FlgAfManageOnly = 0
        End If


        '集計　ワークテーブルより集計
        集計処理(Me.工場負荷DataSet1.工場負荷ワークdtbl, Me.工場負荷DataSet1.工場負荷集計dtbl, Me.工場負荷DataSet1.工場実績人数dtbl, _
              DatA, DatB, Space(0), FlgAfManageOnly)


        'グラフ描画
        グラフ表示処理(Me.工場負荷DataSet1.工場負荷集計dtbl)


        DGV休日書式設定()
    End Sub

    Private Sub 工場負荷集計DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 工場負荷集計DataGridView.CellClick
        If e.ColumnIndex < 0 OrElse e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim DgvRow As DataGridViewRow = Me.工場負荷集計DataGridView.Rows(e.RowIndex)
        If "予算合計".Equals(Me.工場負荷集計DataGridView.Columns(e.ColumnIndex).Name) Then
            Dim DatX As Date = Convert.ToDateTime(DgvRow.Cells(0).Value)

            Dim IfFrmOpen As New IFFRMOPENTHENCLOSE
            IfFrmOpen.DoIfFrmOpenThenClose(DirectCast(My.Forms.工事別日程予算一覧Form, 工事別日程予算一覧Form))
            Dim FrmDateAndBudgetByConst As New 工事別日程予算一覧Form
            My.Forms.工事別日程予算一覧Form.MdiParent = MainForm
            My.Forms.工事別日程予算一覧Form.Show(DatX, DatX)

        End If
    End Sub


    Private Sub VScrollBarSetValue()
        Me.VScrollBar1.Maximum = Me.工場負荷DataSet1.工場負荷集計dtbl.Rows.Count
        Me.VScrollBar1.Minimum = 0
        Me.VScrollBar1.Value = 0

        Me.VScrollBar2.Value = 0
        Me.VScrollBar2.Minimum = 0
        Me.VScrollBar2.Maximum = Me.Panel1.Height
    End Sub



    Private Sub 工場負荷集計DataGridView_Scroll(sender As Object, e As ScrollEventArgs) Handles 工場負荷集計DataGridView.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Me.VScrollBar1.Value = e.NewValue
        End If
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Me.工場負荷集計DataGridView.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub

    Private Sub ButtonOpenDateDialog_Click(sender As Object, e As EventArgs) Handles ButtonOpenDateDialog.Click
        Dim InputDateDialog As New DateInputDialog
        If Me.InputedDateAMaskedTextBox.Text.Length = 10 Then
            My.Forms.DateInputDialog.DateAStr = Me.InputedDateAMaskedTextBox.Text
        End If
        If Me.InputedDateBMaskedTextBox.Text.Length = 10 Then
            My.Forms.DateInputDialog.DateBStr = Me.InputedDateBMaskedTextBox.Text
        End If

        My.Forms.DateInputDialog.ShowDialog(Me)

        Me.InputedDateAMaskedTextBox.Text = My.Forms.DateInputDialog.DateAStr
        Me.InputedDateBMaskedTextBox.Text = My.Forms.DateInputDialog.DateBStr

    End Sub

    Private Sub VScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar2.Scroll
        Me.Panel1.Top = -Me.VScrollBar2.Value

    End Sub

    Private Sub InputedDateAMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles InputedDateAMaskedTextBox.TextChanged, InputedDateBMaskedTextBox.TextChanged

        If InputCheck() = False Then
            Exit Sub
        End If


        表示実行()

        VScrollBarSetValue()

        DGV休日書式設定()
    End Sub

    Private Function InputCheck() As Boolean
        Dim ReturnValue As Boolean = False

        If Me.InputedDateAMaskedTextBox.Text.Length = 10 AndAlso Me.InputedDateBMaskedTextBox.Text.Length = 10 Then
            ReturnValue = True
        End If

        Return ReturnValue
    End Function


    Private Sub 工場負荷_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class