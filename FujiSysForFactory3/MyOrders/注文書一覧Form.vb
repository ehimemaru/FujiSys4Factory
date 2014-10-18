Public Class 注文書一覧Form

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

    Private Sub 注文書一覧Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If Space(0).Equals(CONSTRUCTIONNO) Then
            Me.InputedDateAMaskedTextBox.Text = Today.ToShortDateString
            Me.InputedDateBMaskedTextBox.Text = Today.ToShortDateString
            Me.入荷状態ComboBox.Text = "全て"
        Else
            Me.ConstructionNoMaskedTextBox.Text = CONSTRUCTIONNO
            Me.入荷状態ComboBox.Text = "全て"
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



    Private Sub SearchGo()
        Dim ConstructionNo As String = Space(0)
        If Me.ConstructionNoMaskedTextBox.Text.Trim.Length >= 9 Then
            ConstructionNo = Me.ConstructionNoMaskedTextBox.Text.Trim
        End If

        Dim DateA As Date = DateSerial(2000, 1, 1)
        Dim DateB As Date = DateSerial(2100, 1, 1)
        If Me.InputedDateAMaskedTextBox.Text.Trim.Length = 10 Then
            DateA = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
        End If
        If Me.InputedDateBMaskedTextBox.Text.Trim.Length = 10 Then
            DateB = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
        End If

        If Space(0).Equals(ConstructionNo) And ((DateA = DateSerial(2000, 1, 1)) OrElse (DateB = DateSerial(2100, 1, 1))) Then
            Me.VScrollBar1.Maximum = 0
            Me.VScrollBar1.Value = 0
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor


            Dim OrderItemIDsTbl As New DataTable
            OrderItemIDsTbl.Clear()
            OrderItemIDsTbl.Columns.Add("注文項目ＩＤ", GetType(String))
            If Me.購入品項目CheckBox.Checked Then
                OrderItemIDsTbl.Rows.Add(New Object() {"200"})
                OrderItemIDsTbl.Rows.Add(New Object() {"201"})
            End If
            If Me.材料項目CheckBox.Checked Then
                OrderItemIDsTbl.Rows.Add(New Object() {"100"})
                OrderItemIDsTbl.Rows.Add(New Object() {"110"})
                OrderItemIDsTbl.Rows.Add(New Object() {"120"})
            End If
            If Me.外注項目CheckBox.Checked Then
                OrderItemIDsTbl.Rows.Add(New Object() {"300"})
            End If
            If Me.社外運搬項目CheckBox.Checked Then
                OrderItemIDsTbl.Rows.Add(New Object() {"310"})
            End If
            If Me.出荷項目CheckBox.Checked Then
                OrderItemIDsTbl.Rows.Add(New Object() {"315"})
            End If
            If Me.レンタル項目CheckBox.Checked Then
                OrderItemIDsTbl.Rows.Add(New Object() {"961"})
            End If
            If Me.他項目CheckBox.Checked Then
                OrderItemIDsTbl.Rows.Add(New Object() {"910"})
                OrderItemIDsTbl.Rows.Add(New Object() {"911"})
                OrderItemIDsTbl.Rows.Add(New Object() {"912"})
                OrderItemIDsTbl.Rows.Add(New Object() {"913"})
                OrderItemIDsTbl.Rows.Add(New Object() {"914"})
                OrderItemIDsTbl.Rows.Add(New Object() {"915"})
                OrderItemIDsTbl.Rows.Add(New Object() {"916"})
                OrderItemIDsTbl.Rows.Add(New Object() {"917"})
                OrderItemIDsTbl.Rows.Add(New Object() {"920"})
                OrderItemIDsTbl.Rows.Add(New Object() {"940"})
                OrderItemIDsTbl.Rows.Add(New Object() {"941"})
                OrderItemIDsTbl.Rows.Add(New Object() {"942"})
                OrderItemIDsTbl.Rows.Add(New Object() {"943"})
                OrderItemIDsTbl.Rows.Add(New Object() {"944"})
                OrderItemIDsTbl.Rows.Add(New Object() {"945"})
                OrderItemIDsTbl.Rows.Add(New Object() {"950"})
                OrderItemIDsTbl.Rows.Add(New Object() {"960"})
                OrderItemIDsTbl.Rows.Add(New Object() {"970"})
                OrderItemIDsTbl.Rows.Add(New Object() {"971"})
                OrderItemIDsTbl.Rows.Add(New Object() {"972"})
                OrderItemIDsTbl.Rows.Add(New Object() {"980"})
                OrderItemIDsTbl.Rows.Add(New Object() {"990"})
                OrderItemIDsTbl.Rows.Add(New Object() {"991"})
            End If

            If OrderItemIDsTbl.Rows.Count = 0 Then
                OrderItemIDsTbl.Rows.Add(New Object() {"100"})
                OrderItemIDsTbl.Rows.Add(New Object() {"110"})
                OrderItemIDsTbl.Rows.Add(New Object() {"120"})
                OrderItemIDsTbl.Rows.Add(New Object() {"200"})
                OrderItemIDsTbl.Rows.Add(New Object() {"201"})
                OrderItemIDsTbl.Rows.Add(New Object() {"300"})
                OrderItemIDsTbl.Rows.Add(New Object() {"310"})
                OrderItemIDsTbl.Rows.Add(New Object() {"315"})
                OrderItemIDsTbl.Rows.Add(New Object() {"961"})
                OrderItemIDsTbl.Rows.Add(New Object() {"910"})
                OrderItemIDsTbl.Rows.Add(New Object() {"911"})
                OrderItemIDsTbl.Rows.Add(New Object() {"912"})
                OrderItemIDsTbl.Rows.Add(New Object() {"913"})
                OrderItemIDsTbl.Rows.Add(New Object() {"914"})
                OrderItemIDsTbl.Rows.Add(New Object() {"915"})
                OrderItemIDsTbl.Rows.Add(New Object() {"916"})
                OrderItemIDsTbl.Rows.Add(New Object() {"917"})
                OrderItemIDsTbl.Rows.Add(New Object() {"920"})
                OrderItemIDsTbl.Rows.Add(New Object() {"940"})
                OrderItemIDsTbl.Rows.Add(New Object() {"941"})
                OrderItemIDsTbl.Rows.Add(New Object() {"942"})
                OrderItemIDsTbl.Rows.Add(New Object() {"943"})
                OrderItemIDsTbl.Rows.Add(New Object() {"944"})
                OrderItemIDsTbl.Rows.Add(New Object() {"945"})
                OrderItemIDsTbl.Rows.Add(New Object() {"950"})
                OrderItemIDsTbl.Rows.Add(New Object() {"960"})
                OrderItemIDsTbl.Rows.Add(New Object() {"970"})
                OrderItemIDsTbl.Rows.Add(New Object() {"971"})
                OrderItemIDsTbl.Rows.Add(New Object() {"972"})
                OrderItemIDsTbl.Rows.Add(New Object() {"980"})
                OrderItemIDsTbl.Rows.Add(New Object() {"990"})
                OrderItemIDsTbl.Rows.Add(New Object() {"991"})
            End If


            If Space(0).Equals(ConstructionNo) = False OrElse Date.Compare(DateA, DateSerial(2000, 1, 1)) <> 0 OrElse Date.Compare(DateB, DateSerial(2100, 1, 1)) <> 0 Then
                Me.注文書一覧dtblTableAdapter.Fill(Me.MyOrdersDataSet.注文書一覧dtbl, ConstructionNo, DateA, DateB, OrderItemIDsTbl)
            End If

            OrderItemIDsTbl = Nothing

            ClearFilterAndCombobox()


            '絞込用データ取得
            GetRefineData(Me.MyOrdersDataSet.注文書一覧dtbl)

            Me.VScrollBar1.Maximum = Me.MyOrdersDataSet.注文書一覧dtbl.Rows.Count
            Me.VScrollBar1.Value = 0


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try



    End Sub


    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub



    Private Sub GetRefineData(ByRef DataTbl As MyOrdersDataSet.注文書一覧dtblDataTable)
        If DataTbl.Rows.Count = 0 Then
            Exit Sub
        End If

        '図面番号
        Dim ListDrowingNo As New List(Of String)
        ListDrowingNo.Add(Space(0))

        Dim ResultDrowingNos = (From drow In DataTbl.AsEnumerable _
                                Where drow.Is図面番号Null = False AndAlso Space(0).Equals(drow.図面番号) = False _
                                     Select drow.図面番号).Distinct
        For Each ResultDrowingNo In ResultDrowingNos
            ListDrowingNo.Add(ResultDrowingNo)
        Next

        Me.図面番号ComboBox.DataSource = ListDrowingNo


        '注文先
        Dim ListSuppliers As New List(Of String)
        ListSuppliers.Add(Space(0))

        Dim ResultSuppliers = (From drow In DataTbl.AsEnumerable _
                                      Select drow.取引先略称).Distinct
        For Each ResultSupplier In ResultSuppliers
            ListSuppliers.Add(ResultSupplier)
        Next

        Me.注文先ComboBox.DataSource = ListSuppliers



        '注文者
        Dim ListDicOrderer As New List(Of KeyValuePair(Of String, String))
        Dim NewOrderer As New KeyValuePair(Of String, String)(Space(0), Space(0))
        ListDicOrderer.Add(NewOrderer)

        Dim ResultOrderers = (From drow In DataTbl.AsEnumerable _
                              Select drow.注文者ＩＤ, drow.注文者).Distinct
        For Each ResultOrderer In ResultOrderers
            ListDicOrderer.Add(New KeyValuePair(Of String, String)(ResultOrderer.注文者ＩＤ, ResultOrderer.注文者))
        Next

        Me.注文者ComboBox.DataSource = ListDicOrderer
        Me.注文者ComboBox.DisplayMember = "Value"
        Me.注文者ComboBox.ValueMember = "Key"




    End Sub


    Private Sub ConstructionNoMaskedTextBox_TextChanged(sender As Object, e As EventArgs) _
        Handles ConstructionNoMaskedTextBox.TextChanged, InputedDateAMaskedTextBox.TextChanged, InputedDateBMaskedTextBox.TextChanged _
        , 購入品項目CheckBox.CheckedChanged, 材料項目CheckBox.CheckedChanged, 外注項目CheckBox.CheckedChanged, _
        社外運搬項目CheckBox.CheckedChanged, 出荷項目CheckBox.CheckedChanged, レンタル項目CheckBox.CheckedChanged, 他項目CheckBox.CheckedChanged

        SearchGo()

    End Sub


    Private Sub FilterGo() Handles 図面番号ComboBox.SelectedIndexChanged, 注文先ComboBox.SelectedIndexChanged, 注文者ComboBox.SelectedIndexChanged, 入荷状態ComboBox.SelectedIndexChanged
        If Me.MyOrdersDataSet.注文書一覧dtbl.Rows.Count = 0 Then
            Exit Sub
        End If


        Dim ListFilters As New List(Of String)

        If Me.図面番号ComboBox.Text.Length > 0 Then
            ListFilters.Add("AND (図面番号 like '%" & Me.図面番号ComboBox.Text & "%') ")
        End If

        If Me.注文先ComboBox.Text.Length > 0 Then
            ListFilters.Add("AND (取引先略称 like '%" & Me.注文先ComboBox.Text & "%') ")
        End If

        If Me.注文者ComboBox.Text.Length > 0 Then
            ListFilters.Add("AND (注文者ＩＤ = '" & Me.注文者ComboBox.SelectedValue.ToString & "') ")
        End If

        If Me.入荷状態ComboBox.Text = "入荷済" Then
            ListFilters.Add("AND (Not (入荷日 is Null)) ")
        ElseIf Me.入荷状態ComboBox.Text = "未入荷" Then
            ListFilters.Add("AND (入荷日 is Null) ")
        End If


        If ListFilters.Count = 0 Then
            Me.注文書一覧dtblBindingSource.RemoveFilter()
        Else
            Dim SbFilter As New System.Text.StringBuilder
            For Each ListFilter In ListFilters
                SbFilter.Append(ListFilter)
            Next

            Dim FilterString As String = SbFilter.ToString.Substring(4)
            Me.注文書一覧dtblBindingSource.Filter = FilterString
        End If

        Me.VScrollBar1.Maximum = Me.注文書一覧dtblBindingSource.Count
        Me.VScrollBar1.Value = 0

    End Sub


    Private Sub ClearFilterAndCombobox()
        Me.注文書一覧dtblBindingSource.RemoveFilter()

        Me.図面番号ComboBox.DataSource = Nothing
        Me.図面番号ComboBox.Text = Space(0)
        Me.注文先ComboBox.DataSource = Nothing
        Me.注文先ComboBox.Text = Space(0)
        Me.注文者ComboBox.DataSource = Nothing
        Me.注文者ComboBox.Text = Space(0)
        Me.入荷状態ComboBox.Text = "全て"

    End Sub


    Private Sub ButtonRemoveFilter_Click(sender As Object, e As EventArgs) Handles ButtonRemoveFilter.Click
        ClearFilter()

    End Sub

    Private Sub ClearFilter()
        Me.注文書一覧dtblBindingSource.RemoveFilter()

        Me.図面番号ComboBox.Text = Space(0)
        Me.注文先ComboBox.Text = Space(0)
        Me.注文者ComboBox.Text = Space(0)
        Me.入荷状態ComboBox.Text = "全て"
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        If e.NewValue > 0 Then
            Me.注文書一覧dtblDataGridView.FirstDisplayedScrollingRowIndex = e.NewValue
        End If

    End Sub

    Private Sub 注文書一覧dtblDataGridView_Scroll(sender As Object, e As ScrollEventArgs) Handles 注文書一覧dtblDataGridView.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Me.VScrollBar1.Value = e.NewValue
        End If
    End Sub

    Private Sub 注文書一覧Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub 注文書一覧Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class