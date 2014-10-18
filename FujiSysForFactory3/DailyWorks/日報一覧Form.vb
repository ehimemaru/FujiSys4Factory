Public Class 日報一覧Form

    Private StaffID As String
    Private DateA As Date

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        StaffID = Space(0)
        DateA = Date.MinValue
    End Sub

    Friend Overloads Sub Show(ByVal _staffid As String, _datea As Date)
        StaffID = _staffid
        DateA = _datea
        MyBase.Show()

    End Sub


    Private Sub 日報一覧Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        'TODO: このコード行はデータを 'DailyWorksDataSet.日報歴代社員dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.日報歴代社員dtblTableAdapter.Fill(Me.DailyWorksDataSet.日報歴代社員dtbl)
        Me.日報不適合dtblTableAdapter.Fill(Me.DailyWorksDataSet.日報不適合dtbl)
        Me.日報部署dtblTableAdapter.Fill(Me.DailyWorksDataSet.日報部署dtbl)
        Me.日報工程dtblTableAdapter.Fill(Me.DailyWorksDataSet.日報工程dtbl)

        Me.日報現社員dtblTableAdapter.Fill(Me.DailyWorksDataSet.日報現社員dtbl)
        Dim drNew As DailyWorksDataSet.日報現社員dtblRow = Me.DailyWorksDataSet.日報現社員dtbl.New日報現社員dtblRow
        With drNew
            For i As Integer = 0 To Me.DailyWorksDataSet.日報現社員dtbl.Columns.Count - 1
                drNew.Item(i) = Space(0)
            Next
        End With
        Me.DailyWorksDataSet.日報現社員dtbl.Rows.InsertAt(drNew, 0)
        Me.現社員表示用ComboBox.SelectedIndex = 0
        Me.現社員表示用ComboBox.Text = Space(0)


        Dim iNum As Integer = 0
        Dim NumByPart As New NumberOfPeopleByPartClass
        iNum = NumByPart.部署人数tableSet(Me.部署人数DataGridView)
        Me.合計人数TextBox.Text = iNum.ToString("N0")
        Me.部署人数DataGridView.ClearSelection()

    End Sub


    Private Sub SearchGo()
        Dim DaA As Nullable(Of Date)
        Dim DaB As Nullable(Of Date)
        Dim ConstructionNo As String = Space(0)
        Dim StaffID As String = Space(0)

        Try
            Me.Cursor = Cursors.WaitCursor


            If Me.現社員表示用ComboBox.Text.Length > 0 Then
                StaffID = Me.現社員表示用ComboBox.SelectedValue.ToString
            End If


            Dim InputedConstNoClass As New InputChkConstructionNoClass
            ConstructionNo = InputedConstNoClass.IfInputedThen(Me.ConstructionNoMaskedTextBox)



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

            '判断
            If DaA.HasValue = False AndAlso ConstructionNo = Space(0) Then
                'MessageBox.Show("検索条件入力不備","確認",MessageBoxButtons.OK,MessageBoxIcon.Information)
                Me.VScrollBar1.Maximum = 0
                Me.VScrollBar1.Value = 0
                Exit Sub
            ElseIf DaA.HasValue = False Then
                DaA = DateSerial(2000, 1, 1)
                DaB = DateSerial(2100, 1, 1)
            End If


            'FILL実行
            Me.日報一覧dtblTableAdapter.Fill(Me.DailyWorksDataSet.日報一覧dtbl, DaA, DaB, StaffID, ConstructionNo)

            If Me.DailyWorksDataSet.日報一覧dtbl.Rows.Count = 0 Then
                Me.作業時間合計TextBox.Text = "0"
            Else
                Me.作業時間合計TextBox.Text = (From dr In Me.DailyWorksDataSet.日報一覧dtbl.AsEnumerable _
                                         Select dr.作業時間).Sum.ToString("N2")
            End If


            Me.VScrollBar1.Maximum = Me.DailyWorksDataSet.日報一覧dtbl.Rows.Count
            Me.VScrollBar1.Value = 0


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub



    Private Sub ConstructionNoMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConstructionNoMaskedTextBox.TextChanged
        If Me.ConstructionNoMaskedTextBox.Text.Substring(0, 6).Replace(" ", "").Length = 6 Then
            SearchGo()
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

    Private Sub InputedDateAMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles InputedDateAMaskedTextBox.TextChanged
        If Me.InputedDateAMaskedTextBox.Text.Length = 10 Then
            SearchGo()
        End If
    End Sub


    Private Sub InputedDateBMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles InputedDateBMaskedTextBox.TextChanged
        If DirectCast(Me.InputedDateBMaskedTextBox, MaskedTextBox).Text.Length = 10 Then
            SearchGo()
        End If
    End Sub


    Private Sub 現社員表示用ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles 現社員表示用ComboBox.SelectedIndexChanged
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            SearchGo()
        End If

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub 部署人数DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 部署人数DataGridView.CellClick
        If e.RowIndex = 0 AndAlso e.ColumnIndex > -1 Then
            Dim DgvCol As DataGridViewColumn = Me.部署人数DataGridView.Columns(e.ColumnIndex)
            Dim PartName As String = DgvCol.Name
            Dim PartID As String = Space(0)

            For Each dr As DailyWorksDataSet.日報部署dtblRow In Me.DailyWorksDataSet.日報部署dtbl.Rows
                If PartName.Equals(dr.部署名) Then
                    PartID = dr.部署ＩＤ
                End If
            Next

            If Space(0).Equals(PartID) = False Then
                Me.日報一覧dtblBindingSource.Filter = "部署ＩＤ = '" & PartID & "'"
                Me.作業時間合計TextBox.Text = (From dr In Me.DailyWorksDataSet.日報一覧dtbl.AsEnumerable _
                                         Where dr.部署ＩＤ = PartID _
                                         Select dr.作業時間).Sum.ToString("N2")

            Else
                Me.日報一覧dtblBindingSource.RemoveFilter()
            End If


        End If
    End Sub

    Private Sub DisplayAllButton_Click(sender As Object, e As EventArgs) Handles DisplayAllButton.Click
        Me.日報一覧dtblBindingSource.RemoveFilter()
        Me.作業時間合計TextBox.Text = (From dr In Me.DailyWorksDataSet.日報一覧dtbl.AsEnumerable _
                                     Select dr.作業時間).Sum.ToString("N2")

        Me.日報一覧dtblDataGridView.ClearSelection()

    End Sub

    Private Sub 日報一覧Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Space(0).Equals(StaffID) = False Then
            Me.現社員表示用ComboBox.SelectedValue = StaffID
        End If

        If Date.MinValue <> DateA Then
            Me.InputedDateAMaskedTextBox.Text = DateA.ToShortDateString
            Me.InputedDateBMaskedTextBox.Text = DateA.ToShortDateString
        End If

    End Sub

    Private Sub 日報一覧Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Me.日報一覧dtblDataGridView.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub

    Private Sub 日報一覧dtblDataGridView_Scroll(sender As Object, e As ScrollEventArgs) Handles 日報一覧dtblDataGridView.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Me.VScrollBar1.Value = e.NewValue
        End If
    End Sub
End Class