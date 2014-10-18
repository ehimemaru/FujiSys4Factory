Public Class 工事別日程予算一覧Form

    Private _DATA As Nullable(Of Date)
    Private _DATB As Nullable(Of Date)
    Private iCloseingChk As Integer

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _DATA = Nothing
        _DATB = Nothing
        iCloseingChk = 0
    End Sub

    Friend Overloads Sub Show(ByVal DaA As Date, ByVal DaB As Date)
        _DATA = DaA
        _DATB = DaB
        MyBase.Show()

    End Sub


    Private Sub 工事別日程予算一覧Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Me.工場内部署人数dtblTableAdapter.Fill(Me.ConstructionWorkAndDateDataSet.工場内部署人数dtbl)
        Me.受注営業担当dtblTableAdapter.Fill(Me.ConstructionDataSet.受注営業担当dtbl)
        Dim drNew As ConstructionDataSet.受注営業担当dtblRow = Me.ConstructionDataSet.受注営業担当dtbl.New受注営業担当dtblRow
        With drNew
            .社員ＩＤ = Space(0)
            .社員名 = Space(0)
        End With
        Me.ConstructionDataSet.受注営業担当dtbl.Rows.InsertAt(drNew, 0)
        Me.SalesStaffIDComboBox.SelectedValue = Space(0)

        Me.工事生管担当dtblTableAdapter.Fill(Me.ConstructionDataSet.工事生管担当dtbl)
        Dim drNew2 As ConstructionDataSet.工事生管担当dtblRow = Me.ConstructionDataSet.工事生管担当dtbl.New工事生管担当dtblRow
        With drNew2
            .社員ＩＤ = Space(0)
            .社員名 = Space(0)
        End With
        Me.ConstructionDataSet.工事生管担当dtbl.Rows.InsertAt(drNew2, 0)
        Me.PmStaffIDComboBox.SelectedValue = Space(0)

        Me.工事取引先最新dtblTableAdapter.Fill(Me.ConstructionDataSet.工事取引先最新dtbl)

        '日付の初期値を入力
        If _DATA.HasValue Then
            Me.InputedDateAMaskedTextBox.Text = _DATA.Value.ToShortDateString
        Else
            Me.InputedDateAMaskedTextBox.Text = Today.AddDays(-10).ToShortDateString
        End If
        If _DATB.HasValue Then
            Me.InputedDateBMaskedTextBox.Text = _DATB.Value.ToShortDateString
        Else
            Me.InputedDateBMaskedTextBox.Text = Today.AddDays(5).ToShortDateString
        End If



        '部署人数表示用
        Me.工場内部署人数dtblTableAdapter.Fill(Me.ConstructionWorkAndDateDataSet.工場内部署人数dtbl)

        Me.合計人数TextBox.Text = (From dr In Me.ConstructionWorkAndDateDataSet.工場内部署人数dtbl.AsEnumerable _
                               Select dr.人数).Sum().ToString

        Dim dtDisplay As New DataTable

        For Each dr As ConstructionWorkAndDateDataSet.工場内部署人数dtblRow In Me.ConstructionWorkAndDateDataSet.工場内部署人数dtbl.Rows
            dtDisplay.Columns.Add(dr.部署名, GetType(Integer))
        Next
        Dim drN As DataRow = dtDisplay.NewRow
        For i As Integer = 0 To Me.ConstructionWorkAndDateDataSet.工場内部署人数dtbl.Rows.Count - 1
            Dim drX As ConstructionWorkAndDateDataSet.工場内部署人数dtblRow = DirectCast(Me.ConstructionWorkAndDateDataSet.工場内部署人数dtbl(i), ConstructionWorkAndDateDataSet.工場内部署人数dtblRow)
            drN.Item(i) = drX.人数
        Next
        dtDisplay.Rows.Add(drN)

        'Dim BtnColType As New Windows.Forms.DataGridViewButtonColumn
        'Me.部署人数DataGridView.Columns.Add(BtnColType)
        Me.部署人数DataGridView.DataSource = dtDisplay
        For Each DgvCol As DataGridViewColumn In Me.部署人数DataGridView.Columns
            DgvCol.Width = 85
            DgvCol.DefaultCellStyle.Format = "N0"
            DgvCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next
        Me.部署人数DataGridView.ClearSelection()


        SearchGo()
    End Sub


    Private Sub SearchGo()

        Try
            Me.Cursor = Cursors.WaitCursor

            '全体をサーバーから検索
            Dim ConstructionNo As String = Space(0)
            If Me.ConstructionNoMaskedTextBox.Text.Replace(" ", "").Length > 8 Then
                ConstructionNo = Me.ConstructionNoMaskedTextBox.Text
            End If

            Dim DaA As Date = DateSerial(2000, 1, 1)
            Dim DaB As Date = DateSerial(2050, 1, 1)
            If Me.InputedDateAMaskedTextBox.Text.Length = 10 AndAlso Me.InputedDateBMaskedTextBox.Text.Length = 10 Then
                If Me.InputedDateAMaskedTextBox.Text > Me.InputedDateBMaskedTextBox.Text Then
                    DaA = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                    DaB = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                Else
                    DaA = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                    DaB = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                End If
            ElseIf Me.InputedDateAMaskedTextBox.Text.Length <> 10 AndAlso Me.InputedDateBMaskedTextBox.Text.Length = 10 Then
                DaA = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                DaB = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
            ElseIf Me.InputedDateAMaskedTextBox.Text.Length = 10 AndAlso Me.InputedDateBMaskedTextBox.Text.Length <> 10 Then
                DaA = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                DaB = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
            End If


            If Space(0).Equals(ConstructionNo) AndAlso Date.Compare(DaA, DateSerial(2000, 1, 1)) = 0 Then
                Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Clear()
                Exit Sub
            End If



            Dim SalesStaffID As String = Space(0)
            If Me.SalesStaffIDComboBox.Text.Length > 0 Then
                SalesStaffID = Me.SalesStaffIDComboBox.SelectedValue.ToString
            End If

            Dim PmStaffID As String = Space(0)
            If Me.PmStaffIDComboBox.Text.Length > 0 Then
                PmStaffID = Me.PmStaffIDComboBox.SelectedValue.ToString
            End If

            Dim ConstComplete As Integer = -1
            Select Case Me.ConstructionCompleteTextBox.Text
                Case "完了"
                    ConstComplete = 1
                Case "未完"
                    ConstComplete = 0
                Case "全て"
                    ConstComplete = -1
                Case Else
                    ConstComplete = -1
            End Select

            Me.工事別実績予定日付一覧dtblTableAdapter.Fill(Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtbl, DaA, DaB, SalesStaffID, PmStaffID, ConstructionNo, ConstComplete)


            '集計表示
            NoRefineGo()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub



    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtbl.Clear()
        iCloseingChk = 1
        Me.Close()

    End Sub

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click
        '--入力項目の確認処理
        Dim iCHk As Integer = 0
        If Me.ConstructionNoMaskedTextBox.Text.Replace(" ", "").Length > 8 Then
            iCHk += 1
        End If
        If Me.InputedDateAMaskedTextBox.Text.Length = 10 Then
            iCHk += 1
        End If
        If Me.ConstructionCompleteTextBox.Text = "未完" Then
            iCHk += 1
        End If

        If iCHk = 0 Then
            MessageBox.Show("検索条件不備", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If



        SearchGo()

    End Sub


    Private Sub RefineGoByPart(ByVal PartName As String)

        Try
            Me.Cursor = Cursors.WaitCursor


            If Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtbl.Rows.Count = 0 Then
                Exit Sub
            End If


            Dim PartID As String = Space(0)
            For Each dr As ConstructionWorkAndDateDataSet.工場内部署人数dtblRow In Me.ConstructionWorkAndDateDataSet.工場内部署人数dtbl.Rows
                If PartName.Equals(dr.部署名) Then
                    PartID = dr.部署ＩＤ
                End If
            Next

            If Space(0).Equals(PartID) Then
                Exit Sub
            End If


            '集計

            Dim dResult = From dr In Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtbl.AsEnumerable _
                          Where dr.部署ＩＤ = PartID _
                          Group dr By 工事番号 = dr.工事番号 Into g = Group _
                          Select New With _
                                 { _
                                     .工事番号 = 工事番号, _
                                     .実績工数 = g.Sum(Function(dr) dr.実績工数), _
                                     .予算工数 = g.Sum(Function(dr) dr.予算工数), _
                                     .予定始 = g.Min(Function(dr) dr.Field(Of Nullable(Of Date))("予定始")), _
                                     .予定終 = g.Max(Function(dr) dr.Field(Of Nullable(Of Date))("予定終")), _
                                     .工事名 = g.Max(Function(dr) dr.工事名), _
                                     .数量 = g.Max(Function(dr) dr.数量) _
                                }

            Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Clear()

            For Each drow In dResult
                Dim drNew As ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtblRow = Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.New工事別実績予定日付一覧表示用dtblRow
                With drNew
                    .工事番号 = drow.工事番号
                    .工事名 = drow.工事名
                    .実績工数 = drow.実績工数
                    .数量 = drow.数量
                    .予算工数 = drow.予算工数
                    If drow.予定始.HasValue Then
                        .予定始 = drow.予定始.Value
                    Else
                        .Set予定始Null()
                    End If
                    If drow.予定終.HasValue Then
                        .予定終 = drow.予定終.Value
                    Else
                        .Set予定終Null()
                    End If
                End With

                If drNew.実績工数 > 0 OrElse drNew.予算工数 > 0 Then
                    Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Add工事別実績予定日付一覧表示用dtblRow(drNew)
                End If
            Next

            Me.表示用BindingSource.Sort = "予定始 ASC"

            Me.VScrollBar1.Maximum = Me.一覧表示DataGridView.Rows.Count - 1
            Me.VScrollBar1.Value = 0
            Me.一覧表示DataGridView.ClearSelection()
            Me.LabelConstructionNum.Text = "工事件数：" & Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Rows.Count.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub 部署人数DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 部署人数DataGridView.CellClick
        If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 Then
            Dim Col As DataGridViewColumn = Me.部署人数DataGridView.Columns(e.ColumnIndex)
            Dim ColName As String = Col.Name

            RefineGoByPart(ColName)
        End If
    End Sub

    Private Sub ButtonOpenConstDialog_Click(sender As Object, e As EventArgs) Handles ButtonOpenConstDialog.Click
        Dim InputConstDialog As New ConstructionDialog
        My.Forms.ConstructionDialog.ShowDialog(Me)

        Me.ConstructionNoMaskedTextBox.Text = My.Forms.ConstructionDialog.InputedConstructionNo
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

    Private Sub ButtonOpenConstrucitonComplete_Click(sender As Object, e As EventArgs) Handles ButtonOpenConstrucitonComplete.Click
        Dim ConstCompDialog As New ConstructionCompleteDialog
        My.Forms.ConstructionCompleteDialog.CompleteString = Me.ConstructionCompleteTextBox.Text
        My.Forms.ConstructionCompleteDialog.ShowDialog(Me)

        Me.ConstructionCompleteTextBox.Text = My.Forms.ConstructionCompleteDialog.CompleteString
    End Sub


    Private Sub NoRefineGo()

        Try
            Me.Cursor = Cursors.WaitCursor


            If iCloseingChk <> 0 Then
                Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Clear()
                Exit Sub
            ElseIf Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtbl.Rows.Count = 0 Then
                Exit Sub
            End If


            '集計
            Dim dResult = From dr In Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtbl.AsEnumerable _
                          Group dr By 工事番号 = dr.工事番号 Into g = Group _
                          Select New With _
                                 { _
                                     .工事番号 = 工事番号, _
                                     .実績工数 = g.Sum(Function(dr) dr.実績工数), _
                                     .予算工数 = g.Sum(Function(dr) dr.予算工数), _
                                     .予定始 = g.Min(Function(dr) dr.Field(Of Nullable(Of Date))("予定始")), _
                                     .予定終 = g.Max(Function(dr) dr.Field(Of Nullable(Of Date))("予定終")), _
                                     .工事名 = g.Max(Function(dr) dr.工事名), _
                                     .数量 = g.Max(Function(dr) dr.数量) _
                                }

            Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Clear()

            For Each drow In dResult
                Dim drNew As ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtblRow = Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.New工事別実績予定日付一覧表示用dtblRow
                With drNew
                    .工事番号 = drow.工事番号
                    .工事名 = drow.工事名
                    .実績工数 = drow.実績工数
                    .数量 = drow.数量
                    .予算工数 = drow.予算工数
                    If drow.予定始.HasValue Then
                        .予定始 = drow.予定始.Value
                    Else
                        .Set予定始Null()
                    End If
                    If drow.予定終.HasValue Then
                        .予定終 = drow.予定終.Value
                    Else
                        .Set予定終Null()
                    End If
                End With

                If drNew.実績工数 > 0 OrElse drNew.予算工数 > 0 Then
                    Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Add工事別実績予定日付一覧表示用dtblRow(drNew)
                End If
            Next

            Me.表示用BindingSource.Sort = "予定始 ASC"

            Me.VScrollBar1.Maximum = Me.一覧表示DataGridView.Rows.Count
            Me.VScrollBar1.Value = 0
            Me.一覧表示DataGridView.ClearSelection()
            Me.LabelConstructionNum.Text = "工事件数：" & Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Rows.Count.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub DisplayAllButton_Click(sender As Object, e As EventArgs) Handles DisplayAllButton.Click
        NoRefineGo()

        Me.部署人数DataGridView.ClearSelection()
    End Sub

    Private Sub 一覧表示DataGridView_Scroll(sender As Object, e As ScrollEventArgs) Handles 一覧表示DataGridView.Scroll
        Me.VScrollBar1.Value = e.NewValue

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Me.一覧表示DataGridView.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub

    Private Sub 一覧表示DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 一覧表示DataGridView.CellClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex > -1 Then
            Dim ConstNo As String = Me.一覧表示DataGridView.Rows(e.RowIndex).Cells(1).Value.ToString

            Dim IfFrmOpen As New IFFRMOPENTHENCLOSE
            IfFrmOpen.DoIfFrmOpenThenClose(DirectCast(My.Forms.工事別予算消費Form, 工事別予算消費Form))
            Dim ConstructionBudgetWork As New 工事別予算消費Form
            My.Forms.工事別予算消費Form.MdiParent = MainForm
            My.Forms.工事別予算消費Form.Show(ConstNo)

        End If
    End Sub

    Private Sub 工事別日程予算一覧Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub

    Private Sub ConstructionNoMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConstructionNoMaskedTextBox.TextChanged, _
        InputedDateAMaskedTextBox.TextChanged, InputedDateBMaskedTextBox.TextChanged, _
        SalesStaffIDComboBox.SelectedIndexChanged, PmStaffIDComboBox.SelectedIndexChanged, ConstructionCompleteTextBox.TextChanged

        SearchGo()

    End Sub
End Class
