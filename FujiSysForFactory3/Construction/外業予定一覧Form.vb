﻿Public Class 外業予定一覧Form

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


    Private Sub 外業予定一覧Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'ConstructionDataSet.工事取引先最新dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.工事取引先最新dtblTableAdapter.Fill(Me.ConstructionDataSet.工事取引先最新dtbl)
        'TODO: このコード行はデータを 'ConstructionDataSet.工事取引先最新dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.工事取引先最新dtblTableAdapter.Fill(Me.ConstructionDataSet.工事取引先最新dtbl)
        Me.WindowState = FormWindowState.Maximized

        Me.工事生管担当dtblTableAdapter.Fill(Me.ConstructionDataSet.工事生管担当dtbl)
        Dim drNew As ConstructionDataSet.工事生管担当dtblRow = Me.ConstructionDataSet.工事生管担当dtbl.New工事生管担当dtblRow
        With drNew
            .社員ＩＤ = Space(0)
            .社員名 = Space(0)
        End With
        Me.ConstructionDataSet.工事生管担当dtbl.Rows.InsertAt(drNew, 0)
        Me.PmStaffIDComboBox.SelectedValue = Space(0)


        Me.受注営業担当dtblTableAdapter.Fill(Me.ConstructionDataSet.受注営業担当dtbl)
        Dim drNew2 As ConstructionDataSet.受注営業担当dtblRow = Me.ConstructionDataSet.受注営業担当dtbl.New受注営業担当dtblRow
        With drNew2
            .社員ＩＤ = Space(0)
            .社員名 = Space(0)
        End With
        Me.ConstructionDataSet.受注営業担当dtbl.Rows.InsertAt(drNew2, 0)
        Me.SalesStaffIDComboBox.SelectedValue = Space(0)


        If Space(0).Equals(CONSTRUCTIONNO) Then
            Me.InputedDateAMaskedTextBox.Text = Today.AddDays(-3).ToShortDateString
            Me.InputedDateBMaskedTextBox.Text = Today.AddDays(10).ToShortDateString
        Else
            Me.ConstructionNoMaskedTextBox.Text = CONSTRUCTIONNO
        End If


        SearchGo()

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


    Private Sub SearchGo()

        Try
            Me.Cursor = Cursors.WaitCursor


        Dim ConstructionNo As String = Space(0)
        If Me.ConstructionNoMaskedTextBox.Text.Replace(" ", "").Length > 8 Then
            ConstructionNo = "%" & Me.ConstructionNoMaskedTextBox.Text & "%"
        End If

        Dim DaA As Date = DateSerial(2000, 1, 1)
        Dim DaB As Date = DateSerial(2100, 1, 1)
        If Me.InputedDateAMaskedTextBox.Text.Length = 10 AndAlso Me.InputedDateBMaskedTextBox.Text.Length = 10 Then
            If Me.InputedDateAMaskedTextBox.Text > Me.InputedDateBMaskedTextBox.Text Then
                DaA = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                DaB = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
            Else
                DaA = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                DaB = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
            End If
        ElseIf Me.InputedDateAMaskedTextBox.Text.Length = 10 AndAlso Me.InputedDateBMaskedTextBox.Text.Length <> 10 Then
            DaA = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
            DaB = DaA
        ElseIf Me.InputedDateAMaskedTextBox.Text.Length <> 10 AndAlso Me.InputedDateBMaskedTextBox.Text.Length = 10 Then
            DaA = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
            DaB = DaA
        End If

        '入力チェック
        If Space(0).Equals(ConstructionNo) AndAlso Date.Compare(DaA, DateSerial(2000, 1, 1)) = 0 Then
            Exit Sub
        End If



        Dim ConstComplete As Integer = 0
        Select Case Me.ConstructionCompleteTextBox.Text
            Case "完了"
                ConstComplete = 1
            Case "全て"
                ConstComplete = -1
            Case "未完"
                ConstComplete = 0
            Case Else
                ConstComplete = -1
        End Select

        Dim SalesStaffID As String = Space(0)
        If Me.SalesStaffIDComboBox.Text.Length > 0 Then
            SalesStaffID = Me.SalesStaffIDComboBox.SelectedValue.ToString
        End If

        Dim PmStaffID As String = Space(0)
        If Me.PmStaffIDComboBox.Text.Length > 0 Then
            PmStaffID = Me.PmStaffIDComboBox.SelectedValue.ToString
        End If


        Me.外業予定一覧dtblTableAdapter.Fill(Me.ConstructionDataSet.外業予定一覧dtbl, ConstructionNo, DaA, DaB, SalesStaffID, PmStaffID, ConstComplete)

        Me.LabelOutWorkNum.Text = "外業件数：" & Me.ConstructionDataSet.外業予定一覧dtbl.Rows.Count.ToString
        With Me.VScrollBar1
            .Minimum = 0
            .Maximum = Me.ConstructionDataSet.外業予定一覧dtbl.Rows.Count
            .Value = 0
        End With


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Me.外業予定一覧DataGridView.FirstDisplayedScrollingRowIndex = Me.VScrollBar1.Value

    End Sub

    Private Sub 外業予定一覧DataGridView_Scroll(sender As Object, e As ScrollEventArgs) Handles 外業予定一覧DataGridView.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Me.VScrollBar1.Value = e.NewValue
        End If
    End Sub

    Private Sub 外業予定一覧DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 外業予定一覧DataGridView.CellClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex > -1 Then
            Dim ProBudNo As Integer = CInt(Me.外業予定一覧DataGridView.Rows(e.RowIndex).Cells(1).Value)


            Dim IfFrmOpen As New IFFRMOPENTHENCLOSE
            IfFrmOpen.DoIfFrmOpenThenClose(DirectCast(My.Forms.外業詳細Form, 外業詳細Form))
            Dim OutWorkDetailFrm As New 外業詳細Form
            My.Forms.外業詳細Form.MdiParent = MainForm
            My.Forms.外業詳細Form.Show(ProBudNo)

        End If


    End Sub

    Private Sub ConstructionNoMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConstructionNoMaskedTextBox.TextChanged, _
        InputedDateAMaskedTextBox.TextChanged, InputedDateBMaskedTextBox.TextChanged, ConstructionCompleteTextBox.TextChanged, _
        SalesStaffIDComboBox.SelectedIndexChanged, PmStaffIDComboBox.SelectedIndexChanged

        SearchGo()

    End Sub

    Private Sub 外業予定一覧Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class