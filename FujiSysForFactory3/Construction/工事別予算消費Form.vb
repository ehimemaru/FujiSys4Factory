Public Class 工事別予算消費Form

    Private _CONSTRUCTIONNO As String

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _CONSTRUCTIONNO = Space(0)
    End Sub

    Friend Overloads Sub Show(ByVal ConstNo As String)
        _CONSTRUCTIONNO = ConstNo
        MyBase.Show()

    End Sub

    Private Sub 工事別予算消費Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'ConstructionWorkAndDateDataSet.工場工程dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.工場工程dtblTableAdapter.Fill(Me.ConstructionWorkAndDateDataSet.工場工程dtbl)
        Me.工事部署dtblTableAdapter.Fill(Me.ConstructionDataSet.工事部署dtbl)
        Me.受注営業担当dtblTableAdapter.Fill(Me.ConstructionDataSet.受注営業担当dtbl)
        Me.工事生管担当dtblTableAdapter.Fill(Me.ConstructionDataSet.工事生管担当dtbl)


        SimpleConstSearch()
        SearchGo()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub SearchGo()

        Try
            Me.Cursor = Cursors.WaitCursor


            '全体をサーバーから検索
            Dim DaA As Date = DateSerial(2000, 1, 1)
            Dim DaB As Date = DateSerial(2100, 1, 1)
            Me.工事別実績予定日付一覧dtblTableAdapter1.Fill(Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtbl, DaA, DaB, Space(0), Space(0), _CONSTRUCTIONNO, -1)
            Me.工事別予算消費工程別dtblTableAdapter.Fill(Me.ConstructionWorkAndDateDataSet.工事別予算消費工程別dtbl, DaA, DaB, Space(0), Space(0), _CONSTRUCTIONNO, -1)


            '集計表示
            If Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtbl.Rows.Count = 0 Then
                Exit Sub
            Else
                Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Clear()
            End If

            For Each drBase As ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtblRow In Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtbl.Rows
                If drBase.予算工数 > 0 OrElse drBase.実績工数 > 0 Then
                    Dim drNew As ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtblRow = Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.New工事別実績予定日付一覧表示用dtblRow

                    For i As Integer = 0 To Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧dtbl.Columns.Count - 1
                        drNew(i) = drBase(i)
                    Next

                    Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Add工事別実績予定日付一覧表示用dtblRow(drNew)
                End If
            Next

            'グラフ表示
            Me.ConstructionWorkAndDateDataSet.工事別予算消費グラフdtbl.Clear()
            If Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Rows.Count > 0 Then
                Dim PlanValue As Nullable(Of Decimal) = (From dr In Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.AsEnumerable _
                                                         Select dr.予算工数).Sum
                If PlanValue.HasValue = False Then
                    PlanValue = 0
                End If
                Dim drNewPlan As ConstructionWorkAndDateDataSet.工事別予算消費グラフdtblRow = Me.ConstructionWorkAndDateDataSet.工事別予算消費グラフdtbl.New工事別予算消費グラフdtblRow
                drNewPlan.項目名 = "予定工数計"
                drNewPlan.値 = PlanValue.Value
                Me.ConstructionWorkAndDateDataSet.工事別予算消費グラフdtbl.Add工事別予算消費グラフdtblRow(drNewPlan)


                Dim WorkValue As Nullable(Of Decimal) = (From dr In Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.AsEnumerable _
                                                         Select dr.実績工数).Sum
                If WorkValue.HasValue = False Then
                    WorkValue = 0
                End If
                Dim drNewWork As ConstructionWorkAndDateDataSet.工事別予算消費グラフdtblRow = Me.ConstructionWorkAndDateDataSet.工事別予算消費グラフdtbl.New工事別予算消費グラフdtblRow
                drNewWork.項目名 = "実績工数計"
                drNewWork.値 = WorkValue.Value
                Me.ConstructionWorkAndDateDataSet.工事別予算消費グラフdtbl.Add工事別予算消費グラフdtblRow(drNewWork)

            End If




            Me.工事別実績予定日付一覧表示用dtblBindingSource.Sort = "予定始 ASC"
            Me.VScrollBar1.Maximum = Me.ConstructionWorkAndDateDataSet.工事別実績予定日付一覧表示用dtbl.Rows.Count - 1
            Me.VScrollBar1.Value = 0


            '---工程別
            For i As Integer = 0 To Me.ConstructionWorkAndDateDataSet.工事別予算消費工程別dtbl.Rows.Count - 1
                Dim drow As ConstructionWorkAndDateDataSet.工事別予算消費工程別dtblRow = _
                    DirectCast(Me.ConstructionWorkAndDateDataSet.工事別予算消費工程別dtbl.Rows(i), ConstructionWorkAndDateDataSet.工事別予算消費工程別dtblRow)
                If drow.実績工数 = 0 AndAlso drow.予算工数 = 0 Then
                    drow.Delete()
                End If
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    
    Private Sub SimpleConstSearch()
        Me.工事詳細簡易dtblTableAdapter.FillBy工事番号(Me.ConstructionDataSet.工事詳細簡易dtbl, _CONSTRUCTIONNO)


    End Sub


    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Me.工事別実績予定日付一覧表示用DataGridView.FirstDisplayedScrollingRowIndex = e.NewValue

    End Sub

    Private Sub 工事別実績予定日付一覧表示用DataGridView_Scroll(sender As Object, e As ScrollEventArgs) Handles 工事別実績予定日付一覧表示用DataGridView.Scroll
        Me.VScrollBar1.Value = e.NewValue

    End Sub



    Private Sub 合計DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 合計DataGridView.CellClick
        If e.RowIndex > -1 AndAlso e.ColumnIndex = 1 Then
            Dim Col0Value As String = Me.合計DataGridView.Rows(e.RowIndex).Cells(0).Value.ToString
            If "予定工数計".Equals(Col0Value) Then

                Dim ConstNo As String = Me.工事番号TextBox.Text

                Dim IFOpnFrm As New IFFRMOPENTHENCLOSE
                IFOpnFrm.DoIfFrmOpenThenClose(DirectCast(My.Forms.工程予算Form, Form))
                Dim FrmConstBudget As New 工程予算Form
                My.Forms.工程予算Form.MdiParent = MainForm
                My.Forms.工程予算Form.Show(ConstNo)


            ElseIf "実績工数計".Equals(Col0Value) Then

                Dim ConstNo As String = Me.工事番号TextBox.Text

                Dim IFOpnFrm As New IFFRMOPENTHENCLOSE
                IFOpnFrm.DoIfFrmOpenThenClose(DirectCast(My.Forms.工事別日報予算Form, 工事別日報予算Form))
                Dim FrmConstDayWorks As New 工事別日報予算Form
                My.Forms.工事別日報予算Form.MdiParent = MainForm
                My.Forms.工事別日報予算Form.Show(ConstNo)

            End If
        End If
    End Sub

    Private Sub 工事別予算消費Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class