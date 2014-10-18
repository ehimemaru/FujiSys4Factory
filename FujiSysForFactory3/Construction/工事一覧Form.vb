Public Class 工事一覧Form

    Private Sub ButtonOpenConstDialog_Click(sender As Object, e As EventArgs) Handles ButtonOpenConstDialog.Click
        Dim InputConstDialog As New ConstructionDialog
        My.Forms.ConstructionDialog.ShowDialog(Me)

        Me.ConstructionNoMaskedTextBox.Text = My.Forms.ConstructionDialog.InputedConstructionNo

    End Sub

    Private Sub 工事一覧Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Me.受注営業担当dtblTableAdapter1.Fill(Me.ConstructionDataSet1.受注営業担当dtbl)
        Dim drNew As ConstructionDataSet.受注営業担当dtblRow = Me.ConstructionDataSet1.受注営業担当dtbl.New受注営業担当dtblRow
        With drNew
            .社員ＩＤ = Space(0)
            .社員名 = Space(0)
        End With
        Me.ConstructionDataSet1.受注営業担当dtbl.Rows.InsertAt(drNew, 0)

        Me.工事生管担当dtblTableAdapter1.Fill(Me.ConstructionDataSet1.工事生管担当dtbl)
        Dim drNew2 As ConstructionDataSet.工事生管担当dtblRow = Me.ConstructionDataSet1.工事生管担当dtbl.New工事生管担当dtblRow
        With drNew2
            .社員ＩＤ = Space(0)
            .社員名 = Space(0)
        End With
        Me.ConstructionDataSet1.工事生管担当dtbl.Rows.InsertAt(drNew2, 0)

        Me.SalesStaffIDComboBox.SelectedValue = Space(0)
        Me.PmStaffIDComboBox.SelectedValue = Space(0)
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

    Private Sub ButtonOpenOutWork_Click(sender As Object, e As EventArgs) Handles ButtonOpenOutWork.Click
        Dim OutworkDialog As New OutworExistenceDialog
        My.Forms.OutworExistenceDialog.OutworkExitString = Me.OutworkExitenceTextBox.Text
        My.Forms.OutworExistenceDialog.ShowDialog(Me)

        Me.OutworkExitenceTextBox.Text = My.Forms.OutworExistenceDialog.OutworkExitString
    End Sub

    Private Sub 工事一覧Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.InputedDateAMaskedTextBox.Text = Today.AddMonths(-2).ToShortDateString
        Me.InputedDateBMaskedTextBox.Text = Today.ToShortDateString

        SearchGo()
    End Sub


    Private Sub SearchGo()

        Try

            Me.Cursor = Cursors.WaitCursor

            Dim DateA As Date = DateSerial(2000, 1, 1)
            Dim DateB As Date = DateSerial(2100, 1, 1)

            If Me.InputedDateAMaskedTextBox.Text.Length = 10 AndAlso Me.InputedDateBMaskedTextBox.Text.Length = 10 Then
                Dim DaA As Date = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                Dim DaB As Date = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)

                If DaA > DaB Then
                    DateA = DaB
                    DateB = DaA
                Else
                    DateA = DaA
                    DateB = DaB
                End If
            ElseIf Me.InputedDateAMaskedTextBox.Text.Length = 10 AndAlso Me.InputedDateBMaskedTextBox.Text.Length <> 10 Then
                DateA = Date.ParseExact(Me.InputedDateAMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                DateB = DateA
            ElseIf Me.InputedDateAMaskedTextBox.Text.Length <> 10 AndAlso Me.InputedDateBMaskedTextBox.Text.Length = 10 Then
                DateA = Date.ParseExact(Me.InputedDateBMaskedTextBox.Text, "yyyy/MM/dd", Nothing)
                DateB = DateA
            End If

            Dim ConstructinNo As String = Space(0)
            If Me.ConstructionNoMaskedTextBox.Text.Replace(" ", "").Length > 8 Then
                ConstructinNo = "%" & Me.ConstructionNoMaskedTextBox.Text.Replace(" ", "") & "%"
            End If

            '入力チェック
            If Space(0).Equals(ConstructinNo) AndAlso Date.Compare(DateA, DateSerial(2000, 1, 1)) = 0 Then
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
            If "完了".Equals(Me.ConstructionCompleteTextBox.Text) Then
                ConstComplete = 1
            ElseIf "未完".Equals(Me.ConstructionCompleteTextBox.Text) Then
                ConstComplete = 0
            End If

            Dim OutWork As Integer = -1
            Select Case Me.OutworkExitenceTextBox.Text
                Case "有り"
                    OutWork = 1
                Case "無し"
                    OutWork = 0
                Case Else
                    OutWork = -1
            End Select

            If Space(0).Equals(ConstructinNo) AndAlso Space(0).Equals(SalesStaffID) AndAlso Space(0).Equals(PmStaffID) _
                AndAlso "2000/01/01".Equals(DateA.ToString("yyyy/MM/dd")) AndAlso "2100/01/01".Equals(DateB.ToString("yyyy/MM/dd")) _
                AndAlso "未完".Equals(Me.ConstructionCompleteTextBox.Text) = False Then
                Exit Sub
            End If

            Me.工事一覧dtblTableAdapter1.Fill(Me.ConstructionDataSet1.工事一覧dtbl, SalesStaffID, PmStaffID, OutWork, DateA, DateB, ConstructinNo, ConstComplete)

            If Me.ConstructionDataSet1.工事一覧dtbl.Rows.Count > 0 Then
                Me.LabelConstructionNum.Text = "工事件数：" & Me.ConstructionDataSet1.工事一覧dtbl.Rows.Count.ToString
            End If


            Me.VScrollBar1.Minimum = 0
            Me.VScrollBar1.Maximum = Me.ConstructionDataSet1.工事一覧dtbl.Rows.Count
            Me.VScrollBar1.Value = 0
            Me.HScrollBar1.Minimum = 0
            Me.HScrollBar1.Maximum = Me.工事一覧DataGridView.Columns.Count
            Me.HScrollBar1.Value = 0

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
        If Me.ConstructionDataSet1.工事一覧dtbl.Rows.Count > 0 Then
            Me.工事一覧DataGridView.FirstDisplayedScrollingRowIndex = Me.VScrollBar1.Value
        Else
            Me.VScrollBar1.Value = 0
        End If
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        If Me.ConstructionDataSet1.工事一覧dtbl.Rows.Count > 0 AndAlso Me.HScrollBar1.Value >= 2 Then
            Me.工事一覧DataGridView.FirstDisplayedScrollingColumnIndex = Me.HScrollBar1.Value
        Else
            Me.HScrollBar1.Value = 0
        End If

    End Sub

    Private Sub 工事一覧DataGridView_Scroll(sender As Object, e As ScrollEventArgs) Handles 工事一覧DataGridView.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Me.VScrollBar1.Value = e.NewValue
        Else
            'Me.HScrollBar1.Value = e.NewValue
        End If

    End Sub

    Private Sub 工事一覧DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 工事一覧DataGridView.CellClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            Dim ConstNo As String = Me.工事一覧DataGridView.Rows(e.RowIndex).Cells(1).Value.ToString

            Dim IfFrmOpen As New IFFRMOPENTHENCLOSE
            IfFrmOpen.DoIfFrmOpenThenClose(DirectCast(My.Forms.工事詳細Form, Form))
            Dim ConstructionDetail As New 工事詳細Form
            My.Forms.工事詳細Form.MdiParent = MainForm
            My.Forms.工事詳細Form.Show(ConstNo)

        End If
    End Sub

    Private Sub ConstructionNoMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConstructionNoMaskedTextBox.TextChanged,
        InputedDateAMaskedTextBox.TextChanged, InputedDateBMaskedTextBox.TextChanged, ConstructionCompleteTextBox.TextChanged, _
        OutworkExitenceTextBox.TextChanged, SalesStaffIDComboBox.SelectedIndexChanged, PmStaffIDComboBox.SelectedIndexChanged

        SearchGo()

    End Sub

    Private Sub 工事一覧Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class