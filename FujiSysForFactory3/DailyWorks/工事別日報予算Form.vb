Public Class 工事別日報予算Form

    Private CONSTRUCTIONNO As String

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        CONSTRUCTIONNO = Space(0)
    End Sub

    Friend Overloads Sub Show(ByVal _constructionno As String)
        CONSTRUCTIONNO = _constructionno
        MyBase.Show()
    End Sub


    Private Sub 工事別日報予算Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Me.日報会社休日dtblTableAdapter1.Fill(Me.DailyWorksDataSet.日報会社休日dtbl)
        Me.日報部署dtblTableAdapter1.FillBy全部(Me.DailyWorksDataSet.日報部署dtbl)
        Me.日報工程dtblTableAdapter1.FillBy全部(Me.DailyWorksDataSet.日報工程dtbl)


        Dim iNum As Integer = 0
        Dim NumByPart As New NumberOfPeopleByPartClass
        iNum = NumByPart.部署人数tableSet(Me.部署人数DataGridView)
        Me.合計人数TextBox.Text = iNum.ToString("N0")
        Me.部署人数DataGridView.ClearSelection()


    End Sub


    Private Sub SearchGo(ByVal ConstructionNo As String)

        Try
            Me.Cursor = Cursors.WaitCursor
            Me.SuspendLayout()


            Me.DailyWorksDataSet.日報工程予算dtbl.Clear()
            Me.DailyWorksDataSet.日報人実績一覧サブdtbl.Clear()
            'Me.DailyWorksDataSet.日報人実績一覧dtbl.Clear()

            'If Me.DailyWorksDataSet.日報人実績一覧dtbl.Columns.Count > 6 Then
            '    Dim iColMax As Integer = Me.DailyWorksDataSet.日報人実績一覧dtbl.Columns.Count - 1
            '    For ii As Integer = iColMax To 6 Step -1
            '        'Dim DgvColDelete As DataColumn = DirectCast(Me.DailyWorksDataSet.日報人実績一覧dtbl.Columns(ii), DataColumn)
            '        'Me.DailyWorksDataSet.日報人実績一覧dtbl.Columns.Remove(DgvColDelete)
            '        Me.DailyWorksDataSet.日報人実績一覧dtbl.Columns.RemoveAt(ii)
            '    Next
            'End If

            'Me.Cursor = Cursors.SizeAll

            '追加した列の削除が遅い為、その都度dtblをインスタンス化して使用
            Dim NewDTBL As New DailyWorksDataSet.日報人実績一覧dtblDataTable

            Me.日報工程予算dtblTableAdapter1.FillBy工事番号(Me.DailyWorksDataSet.日報工程予算dtbl, ConstructionNo)
            'Me.日報人実績一覧dtblTableAdapter1.FillBy工事番号(Me.DailyWorksDataSet.日報人実績一覧dtbl, ConstructionNo)
            Me.日報人実績一覧dtblTableAdapter1.FillBy工事番号(NewDTBL, ConstructionNo)
            Me.日報人実績一覧サブdtblTableAdapter1.FillBy工事番号(Me.DailyWorksDataSet.日報人実績一覧サブdtbl, ConstructionNo)

            'If Me.DailyWorksDataSet.日報人実績一覧dtbl.Rows.Count = 0 Then
            If NewDTBL.Rows.Count = 0 Then
                Exit Sub
            End If


            Me.日報人実績一覧BindingSource.RemoveFilter()

            '期間取得
            'Dim DateA As Date = (From dr In Me.DailyWorksDataSet.日報人実績一覧dtbl.AsEnumerable _
            '                     Select dr.最小人別).Min

            'Dim DateB As Date = (From dr In Me.DailyWorksDataSet.日報人実績一覧dtbl.AsEnumerable _
            '                     Select dr.最大人別).Max
            Dim DateA As Date = (From dr In NewDTBL.AsEnumerable _
                                 Select dr.最小人別).Min

            Dim DateB As Date = (From dr In NewDTBL.AsEnumerable _
                                 Select dr.最大人別).Max

            '休日取得
            Dim ListHolidays As New List(Of Date)
            ListHolidays = (From dr In Me.DailyWorksDataSet.日報会社休日dtbl.AsEnumerable _
                            Select dr.休日).ToList

            '検索用ディクショナリ設定
            Dim DictonaryDateAndColumnNum As New Dictionary(Of Date, Integer)

            'DGVの列を追加(datatableに列を追加し、DGVに反映)
            Dim DatX As Date = DateA
            Dim iColNum As Integer = 1

            Do While DatX <= DateB
                DictonaryDateAndColumnNum.Add(DatX, iColNum + 5)

                Dim NewColumn As New DataColumn
                With NewColumn
                    .DataType = GetType(Decimal)
                    .Namespace = iColNum.ToString
                    .Caption = iColNum.ToString
                End With

                DatX = DatX.AddDays(1)
                iColNum += 1

                'Me.DailyWorksDataSet.日報人実績一覧dtbl.Columns.Add(NewColumn)
                NewDTBL.Columns.Add(NewColumn)
            Loop

            Me.日報人実績一覧BindingSource.DataSource = NewDTBL

            With Me.日報実績DataGridView
                .AutoGenerateColumns = True
                .DataSource = Me.日報人実績一覧BindingSource
                .Refresh()
            End With

            'DGVの列書式を変更
            Dim DatXX As Date = DateA
            Dim iiColNum As Integer = 6
            Do While DatXX <= DateB
                Dim DgvCol As DataGridViewColumn = DirectCast(Me.日報実績DataGridView.Columns(iiColNum), DataGridViewColumn)
                With DgvCol
                    .Width = 35
                    If DatXX.Day = 1 OrElse iiColNum = 6 Then
                        .HeaderText = DatXX.Month.ToString & "/" & System.Environment.NewLine & DatXX.Day.ToString
                    Else
                        .HeaderText = DatXX.Day.ToString
                    End If
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .DefaultCellStyle.Format = "N1"
                    Dim ColumnColor As Color = Color.White
                    If DatXX.DayOfWeek = DayOfWeek.Sunday Then
                        ColumnColor = Color.NavajoWhite
                    ElseIf ListHolidays.Contains(DatXX) Then
                        ColumnColor = Color.LightSteelBlue
                    End If
                    .DefaultCellStyle.BackColor = ColumnColor
                End With

                DatXX = DatXX.AddDays(1)
                iiColNum += 1
            Loop

            '実データを転記
            'For Each drBase As DailyWorksDataSet.日報人実績一覧dtblRow In Me.DailyWorksDataSet.日報人実績一覧dtbl.Rows
            For Each drBase As DailyWorksDataSet.日報人実績一覧dtblRow In NewDTBL.Rows
                Dim StaffID As String = drBase.社員ＩＤ

                Dim SubResults = From dr In Me.DailyWorksDataSet.日報人実績一覧サブdtbl.AsEnumerable _
                                 Where dr.社員ＩＤ = StaffID _
                                 Select dr

                For Each drSub In SubResults
                    Dim iCellNumber As Integer = 0
                    DictonaryDateAndColumnNum.TryGetValue(drSub.作業日, iCellNumber)

                    drBase.Item(iCellNumber) = drSub.日工数計
                Next
            Next

            Me.ResumeLayout()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub ButtonOpenConstDialog_Click(sender As Object, e As EventArgs) Handles ButtonOpenConstDialog.Click
        Dim InputConstDialog As New ConstructionDialog
        My.Forms.ConstructionDialog.ShowDialog(Me)

        Me.ConstructionNoMaskedTextBox.Text = My.Forms.ConstructionDialog.InputedConstructionNo
    End Sub

    Private Sub ConstructionNoMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConstructionNoMaskedTextBox.TextChanged
        Dim InputedConstNo As String = Space(0)
        If Me.ConstructionNoMaskedTextBox.Text.Length = 11 Then
            InputedConstNo = Me.ConstructionNoMaskedTextBox.Text

            SearchGo(InputedConstNo)
            FilterGo(Space(0))

        End If

    End Sub


    Private Sub FilterGo(ByVal PartID As String)
        Dim NowDTBL As DailyWorksDataSet.日報人実績一覧dtblDataTable = DirectCast(Me.日報人実績一覧BindingSource.DataSource, DailyWorksDataSet.日報人実績一覧dtblDataTable)

        If Space(0).Equals(PartID) Then
            Me.日報人実績一覧BindingSource.RemoveFilter()
            Me.日報工程予算BindingSource.RemoveFilter()



            'Me.実績工数計TextBox.Text = (From dr In Me.DailyWorksDataSet.日報人実績一覧dtbl.AsEnumerable _
            '                        Where dr.Is部署ＩＤNull = False AndAlso dr.部署ＩＤ <> "300" _
            '                        Select dr.工数計).Sum().ToString("N2")
            Me.実績工数計TextBox.Text = (From dr In NowDTBL.AsEnumerable _
                                    Where dr.Is部署ＩＤNull = False AndAlso dr.部署ＩＤ <> "300" _
                                    Select dr.工数計).Sum().ToString("N2")

            Me.予算工数計TextBox.Text = (From dr In Me.DailyWorksDataSet.日報工程予算dtbl.AsEnumerable _
                                    Where dr.Is部署ＩＤNull = False AndAlso dr.部署ＩＤ <> "'300'" _
                                    Select dr.社内工数).Sum().ToString("N2")

            Me.部署人数DataGridView.ClearSelection()

        Else
            '実績のフィルタ
            Me.日報人実績一覧BindingSource.Filter = "部署ＩＤ = '" & PartID & "'"
            Me.日報工程予算BindingSource.Filter = "部署ＩＤ = '" & PartID & "'"

            'Me.実績工数計TextBox.Text = (From dr In Me.DailyWorksDataSet.日報人実績一覧dtbl.AsEnumerable _
            '                        Where dr.Is部署ＩＤNull = False AndAlso dr.部署ＩＤ = PartID _
            '                        Select dr.工数計).Sum().ToString("N2")
            Me.実績工数計TextBox.Text = (From dr In NowDTBL.AsEnumerable _
                                    Where dr.Is部署ＩＤNull = False AndAlso dr.部署ＩＤ = PartID _
                                    Select dr.工数計).Sum().ToString("N2")

            Me.予算工数計TextBox.Text = (From dr In Me.DailyWorksDataSet.日報工程予算dtbl.AsEnumerable _
                                    Where dr.Is部署ＩＤNull = False AndAlso dr.部署ＩＤ = PartID _
                                    Select dr.社内工数).Sum().ToString("N2")


        End If

    End Sub

    Private Sub 部署人数DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 部署人数DataGridView.CellClick
        If e.RowIndex = 0 And e.ColumnIndex > -1 Then
            Dim PartID As String = Space(0)
            Dim PartName As String = Me.部署人数DataGridView.Columns(e.ColumnIndex).HeaderText
            Dim PartIDs = (From dr In Me.DailyWorksDataSet.日報部署dtbl.AsEnumerable _
                                      Where dr.部署名 = PartName _
                                      Select dr.部署ＩＤ)
            PartID = PartIDs(0).ToString

            FilterGo(PartID)
        End If
    End Sub

    Private Sub DisplayAllButton_Click(sender As Object, e As EventArgs) Handles DisplayAllButton.Click
        FilterGo(Space(0))

    End Sub

    Private Sub 工事別日報予算Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ConstructionNoMaskedTextBox.Text = CONSTRUCTIONNO

    End Sub

    Private Sub 工事別日報予算Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class