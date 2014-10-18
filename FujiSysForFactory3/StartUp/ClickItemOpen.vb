Module ClickItemOpen


    Friend Sub ClickMenuOpenForm(sender As Object, e As EventArgs)
        Dim ClickStripItem As ToolStripItem = DirectCast(sender, ToolStripItem)
        Dim ClickItemName As String = ClickStripItem.Text

        Dim IfFrmOpenThenClose As New IFFRMOPENTHENCLOSE

        Select Case ClickItemName

            Case "工事一覧"
                IfFrmOpenThenClose.DoIfFrmOpenThenClose(DirectCast(My.Forms.工事一覧Form, 工事一覧Form))
                Dim FrmConstructionSummary As New 工事一覧Form
                My.Forms.工事一覧Form.MdiParent = MainForm
                My.Forms.工事一覧Form.Show()

            Case "出荷予定一覧"
                IfFrmOpenThenClose.DoIfFrmOpenThenClose(DirectCast(My.Forms.出荷予定一覧Form, 出荷予定一覧Form))
                Dim FrmShippingSummary As New 出荷予定一覧Form
                My.Forms.出荷予定一覧Form.MdiParent = MainForm
                My.Forms.出荷予定一覧Form.Show()

            Case "外業予定一覧"
                IfFrmOpenThenClose.DoIfFrmOpenThenClose(DirectCast(My.Forms.外業予定一覧Form, 外業予定一覧Form))
                Dim FrmOutworksSummary As New 外業予定一覧Form
                My.Forms.外業予定一覧Form.MdiParent = MainForm
                My.Forms.外業予定一覧Form.Show()


            Case "工場負荷"
                IfFrmOpenThenClose.DoIfFrmOpenThenClose(DirectCast(My.Forms.工場負荷, 工場負荷))
                Dim FrmFacLoad As New 工場負荷
                My.Forms.工場負荷.MdiParent = MainForm
                My.Forms.工場負荷.Show()


            Case "工事別日程一覧"
                IfFrmOpenThenClose.DoIfFrmOpenThenClose(DirectCast(My.Forms.工事別日程予算一覧Form, 工事別日程予算一覧Form))
                Dim FrmConstDateLoad As New 工事別日程予算一覧Form
                My.Forms.工事別日程予算一覧Form.MdiParent = MainForm
                My.Forms.工事別日程予算一覧Form.Show()


            Case "日報一覧表示"
                IfFrmOpenThenClose.DoIfFrmOpenThenClose(DirectCast(My.Forms.日報一覧Form, 日報一覧Form))
                Dim FrmConstDateLoad As New 日報一覧Form
                My.Forms.日報一覧Form.MdiParent = MainForm
                My.Forms.日報一覧Form.Show()


            Case "日報月別一覧表示"
                IfFrmOpenThenClose.DoIfFrmOpenThenClose(DirectCast(My.Forms.日報月一覧Form, 日報月一覧Form))
                Dim FrmConstDateLoadByMonth As New 日報月一覧Form
                My.Forms.日報月一覧Form.MdiParent = MainForm
                My.Forms.日報月一覧Form.Show()


            Case "工事別労務予算実績一覧"
                IfFrmOpenThenClose.DoIfFrmOpenThenClose(DirectCast(My.Forms.工事別日報予算Form, 工事別日報予算Form))
                Dim FrmConstDateLoadByWorker As New 工事別日報予算Form
                My.Forms.工事別日報予算Form.MdiParent = MainForm
                My.Forms.工事別日報予算Form.Show()


            Case "月別日報集計表"
                IfFrmOpenThenClose.DoIfFrmOpenThenClose(DirectCast(My.Forms.月別日報集計表Form, 月別日報集計表Form))
                Dim FrmByMonthTotalWorks As New 月別日報集計表Form
                My.Forms.月別日報集計表Form.MdiParent = MainForm
                My.Forms.月別日報集計表Form.Show()


            Case "注文書一覧"
                IfFrmOpenThenClose.DoIfFrmOpenThenClose(DirectCast(My.Forms.注文書一覧Form, 注文書一覧Form))
                Dim FrmMyOrderSummary As New 注文書一覧Form
                My.Forms.注文書一覧Form.MdiParent = MainForm
                My.Forms.注文書一覧Form.Show()



            Case Else

                MessageBox.Show(ClickItemName)

        End Select




    End Sub

End Module
