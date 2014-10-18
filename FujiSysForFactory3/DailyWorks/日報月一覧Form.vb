Public Class 日報月一覧Form

    Private Sub 日報月一覧Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Me.日報会社休日dtblTableAdapter1.Fill(Me.DailyWorksDataSet.日報会社休日dtbl)
        Me.日報部署dtblTableAdapter1.Fill(Me.DailyWorksDataSet.日報部署dtbl)


        Dim iNum As Integer = 0
        Dim NumByPart As New NumberOfPeopleByPartClass
        iNum = NumByPart.部署人数tableSet(Me.部署人数DataGridView)
        Me.合計人数TextBox.Text = iNum.ToString("N0")
        Me.部署人数DataGridView.ClearSelection()

    End Sub

    Private Sub InputMonthButton_Click(sender As Object, e As EventArgs) Handles InputMonthButton.Click
        Dim InputedMonth As String = Space(0)
        If Me.TargetMonthTextBox.Text.Length > 0 Then
            InputedMonth = Me.TargetMonthTextBox.Text
        End If

        Dim InputMonthDialog As New MonthInputDialog
        My.Forms.MonthInputDialog.TargetMonthString = InputedMonth
        My.Forms.MonthInputDialog.ShowDialog(Me)

        Me.TargetMonthTextBox.Text = My.Forms.MonthInputDialog.TargetMonthString

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub TargetMonthTextBox_TextChanged(sender As Object, e As EventArgs) Handles TargetMonthTextBox.TextChanged
        If Me.TargetMonthTextBox.Text.Length = 0 Then
            Exit Sub
        End If

        Dim dString As String = Me.TargetMonthTextBox.Text & "/01"
        SearchByMonth(dString)

    End Sub


    Private Sub SearchByMonth(ByVal _TDateString As String)
        '月一覧
        Dim TargetDate As Date = Date.ParseExact(_TDateString, "yyyy/MM/dd", Nothing)
        Me.日報月一覧dtblTableAdapter1.Fill(Me.DailyWorksDataSet.日報月一覧dtbl, TargetDate)

        '集計
        GoFilter(Space(0))

    End Sub

    Private Sub SplitContainer2_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel2.Paint

    End Sub

    Private Sub 日報月一覧dtblDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 日報月一覧dtblDataGridView.CellClick
        If e.RowIndex > -1 AndAlso e.ColumnIndex = 0 Then
            Me.日報月一覧dtblDataGridView.Rows(e.RowIndex).Selected = True

            Dim dString As String = Me.TargetMonthTextBox.Text & "/01"
            Dim dDate As Date = Date.ParseExact(dString, "yyyy/MM/dd", Nothing)
            Dim StaffID As String = Me.日報月一覧dtblDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString

            Me.日報人別月一覧dtblTableAdapter1.Fill(Me.DailyWorksDataSet.日報人別月一覧dtbl, dDate, StaffID)
            '集計表示
            Me.DaysByManTextBox.Text = (From dr In Me.DailyWorksDataSet.日報人別月一覧dtbl.AsEnumerable _
                                        Where dr.時間計 > 0 _
                                        Select dr).Count.ToString("N0")

            Me.TotalTimesByManTextBox.Text = (From dr In Me.DailyWorksDataSet.日報人別月一覧dtbl.AsEnumerable _
                                              Select dr.時間計).Sum.ToString("N2")

            Me.AveTimesByManTextBox.Text = (From dr In Me.DailyWorksDataSet.日報人別月一覧dtbl.AsEnumerable _
                                            Select dr.時間計).Average.ToString("N2")



            '曜日での書式設定
            Dim HolidayColor As Color = Color.LightSteelBlue
            Dim SundayColor As Color = Color.Bisque

            For Each dr As DataGridViewRow In Me.日報人別月一覧dtblDataGridView.Rows
                Dim DatX As Date = Convert.ToDateTime(dr.Cells(0).Value)
                If DatX.DayOfWeek = DayOfWeek.Sunday Then
                    dr.DefaultCellStyle.BackColor = SundayColor
                Else
                    Dim drTarget As DailyWorksDataSet.日報会社休日dtblRow = Me.DailyWorksDataSet.日報会社休日dtbl.FindBy休日(DatX)
                    If IsNothing(drTarget) = False Then
                        dr.DefaultCellStyle.BackColor = HolidayColor
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub 日報人別月一覧dtblDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles 日報人別月一覧dtblDataGridView.CellClick
        If e.RowIndex > -1 AndAlso e.ColumnIndex = 0 Then
            Dim SelectedStaffID As String = Space(0)
            Dim SelectedDgvRow As DataGridViewRow = Me.日報月一覧dtblDataGridView.SelectedRows(0)
            SelectedStaffID = SelectedDgvRow.Cells(1).Value.ToString

            Dim SelectedDate As Date = Date.ParseExact(Me.日報人別月一覧dtblDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString, "yyyy/MM/dd h:mm:ss", Nothing)


            'Debug.Print(Me.日報人別月一覧dtblDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString)
            Dim IfFrmOpenThenClose As New IFFRMOPENTHENCLOSE
            IFFRMOPENTHENCLOSE.DoIfFrmOpenThenClose(DirectCast(My.Forms.日報一覧Form, 日報一覧Form))
            Dim FrmConstDateLoad As New 日報一覧Form
            My.Forms.日報一覧Form.MdiParent = MainForm
            My.Forms.日報一覧Form.Show(SelectedStaffID, SelectedDate)


        End If
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

            GoFilter(PartID)

        End If
    End Sub


    Private Sub GoFilter(ByVal PartID As String)
        If Space(0).Equals(PartID) Then

            If Me.DailyWorksDataSet.日報月一覧dtbl.Rows.Count = 0 Then
                Exit Sub
            End If

            Me.日報月一覧BindingSource.RemoveFilter()
            Me.TotalNumOfPeoTextBox.Text = Me.DailyWorksDataSet.日報月一覧dtbl.Rows.Count.ToString
            Me.TotalTimesTextBox.Text = (From dr In Me.DailyWorksDataSet.日報月一覧dtbl.AsEnumerable _
                                         Select dr.時間計).Sum.ToString("N0")

            Me.AveTimesTextBox.Text = (From dr In Me.DailyWorksDataSet.日報月一覧dtbl.AsEnumerable _
                                       Select dr.時間計).Average.ToString("N0")

            Me.部署人数DataGridView.ClearSelection()
            Me.日報月一覧dtblDataGridView.ClearSelection()


        Else
            Me.日報月一覧BindingSource.Filter = "部署ＩＤ = '" & PartID & "'"

            Me.TotalNumOfPeoTextBox.Text = (From dr In Me.DailyWorksDataSet.日報月一覧dtbl.AsEnumerable _
                                         Where dr.部署ＩＤ = PartID _
                                         Select dr).Count.ToString("N0")

            Me.TotalTimesTextBox.Text = (From dr In Me.DailyWorksDataSet.日報月一覧dtbl.AsEnumerable _
                                         Where dr.部署ＩＤ = PartID _
                                         Select dr.時間計).Sum.ToString("N0")

            Me.AveTimesTextBox.Text = (From dr In Me.DailyWorksDataSet.日報月一覧dtbl.AsEnumerable _
                                       Where dr.部署ＩＤ = PartID _
                                       Select dr.時間計).Average.ToString("N0")

            Me.日報月一覧dtblDataGridView.ClearSelection()

        End If


    End Sub

    Private Sub DisplayAllButton_Click(sender As Object, e As EventArgs) Handles DisplayAllButton.Click
        GoFilter(Space(0))

    End Sub

    Private Sub 日報月一覧Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class