Public Class 工事詳細Form

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


    Private Sub 工事詳細Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'ConstructionDataSet1.受注営業担当dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.受注営業担当dtblTableAdapter.Fill(Me.ConstructionDataSet1.受注営業担当dtbl)
        'TODO: このコード行はデータを 'ConstructionDataSet1.工事生管担当dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.工事生管担当dtblTableAdapter.Fill(Me.ConstructionDataSet1.工事生管担当dtbl)
        Me.工事取引先最新dtblTableAdapter1.Fill(Me.ConstructionDataSet1.工事取引先最新dtbl)
        Me.工事製造範囲dtblTableAdapter1.Fill(Me.ConstructionDataSet1.工事製造範囲dtbl)

        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub 工事詳細Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        If Space(0).Equals(_CONSTRUCTIONNO) = False Then
            Me.工事詳細dtblTableAdapter1.FillBy工事番号(Me.ConstructionDataSet1.工事詳細dtbl, _CONSTRUCTIONNO)
        End If


    End Sub


    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub ButtonBudgetOpen_Click(sender As Object, e As EventArgs) Handles ButtonBudgetOpen.Click
        Dim ConstNo As String = Me.工事番号TextBox.Text

        Dim IFOpnFrm As New IFFRMOPENTHENCLOSE
        IFOpnFrm.DoIfFrmOpenThenClose(DirectCast(My.Forms.工程予算Form, Form))

        Dim FrmConstBudget As New 工程予算Form
        My.Forms.工程予算Form.MdiParent = MainForm
        My.Forms.工程予算Form.Show(ConstNo)

    End Sub

    Private Sub ButtonMyOrderOpen_Click(sender As Object, e As EventArgs) Handles ButtonMyOrderOpen.Click
        Dim ConstNo As String = Me.工事番号TextBox.Text

        Dim IFOpnFrm As New IFFRMOPENTHENCLOSE
        IFOpnFrm.DoIfFrmOpenThenClose(DirectCast(My.Forms.注文書一覧Form, 注文書一覧Form))

        Dim FrmOrderSummary As New 注文書一覧Form
        My.Forms.注文書一覧Form.MdiParent = MainForm
        My.Forms.注文書一覧Form.Show(ConstNo)
    End Sub

    Private Sub ButtonDayWorksOpen_Click(sender As Object, e As EventArgs) Handles ButtonDayWorksOpen.Click
        If Me.実績工数TextBox.Text.Length = 0 OrElse CInt(Me.実績工数TextBox.Text) = 0 Then
            Exit Sub
        End If

        Dim ConstNo As String = Me.工事番号TextBox.Text

        Dim IFOpnFrm As New IFFRMOPENTHENCLOSE
        IFOpnFrm.DoIfFrmOpenThenClose(DirectCast(My.Forms.工事別日報予算Form, 工事別日報予算Form))
        Dim FrmConstDayWorks As New 工事別日報予算Form
        My.Forms.工事別日報予算Form.MdiParent = MainForm
        My.Forms.工事別日報予算Form.Show(ConstNo)
    End Sub

    Private Sub ButtonBudgetDetailOpen_Click(sender As Object, e As EventArgs) Handles ButtonBudgetDetailOpen.Click
        Dim ConstNo As String = Me.工事番号TextBox.Text

        Dim IfFrmOpen As New IFFRMOPENTHENCLOSE
        IfFrmOpen.DoIfFrmOpenThenClose(DirectCast(My.Forms.工事別予算消費Form, 工事別予算消費Form))
        Dim ConstructionBudgetWork As New 工事別予算消費Form
        My.Forms.工事別予算消費Form.MdiParent = MainForm
        My.Forms.工事別予算消費Form.Show(ConstNo)
    End Sub

    Private Sub ButtonShipmentOpen_Click(sender As Object, e As EventArgs) Handles ButtonShipmentOpen.Click
        Dim ConstNo As String = Me.工事番号TextBox.Text

        Dim IfFrmOpen As New IFFRMOPENTHENCLOSE
        IfFrmOpen.DoIfFrmOpenThenClose(DirectCast(My.Forms.出荷予定一覧Form, 出荷予定一覧Form))
        Dim ShipSummaryFrm As New 出荷予定一覧Form
        My.Forms.出荷予定一覧Form.MdiParent = MainForm
        My.Forms.出荷予定一覧Form.Show(ConstNo)
    End Sub

    Private Sub ButtonOutWorkOpen_Click(sender As Object, e As EventArgs) Handles ButtonOutWorkOpen.Click
        Dim ConstNo As String = Me.工事番号TextBox.Text

        Dim IfFrmOpen As New IFFRMOPENTHENCLOSE
        IfFrmOpen.DoIfFrmOpenThenClose(DirectCast(My.Forms.外業予定一覧Form, 外業予定一覧Form))
        Dim OutWorkSummaryFrm As New 外業予定一覧Form
        My.Forms.外業予定一覧Form.MdiParent = MainForm
        My.Forms.外業予定一覧Form.Show(ConstNo)

    End Sub

    Private Sub 工事詳細Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)

    End Sub
End Class