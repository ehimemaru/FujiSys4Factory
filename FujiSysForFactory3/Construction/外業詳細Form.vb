Public Class 外業詳細Form

    Private _PROCESSBUDGETNO As Integer

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _PROCESSBUDGETNO = 0
    End Sub


    Friend Overloads Sub Show(ByVal ProBudNo As Integer)
        _PROCESSBUDGETNO = ProBudNo
        MyBase.Show()

    End Sub


    Private Sub 外業詳細Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Me.工事取引先最新dtblTableAdapter.Fill(Me.ConstructionDataSet.工事取引先最新dtbl)
        Me.受注営業担当dtblTableAdapter.Fill(Me.ConstructionDataSet.受注営業担当dtbl)
        Me.工事生管担当dtblTableAdapter.Fill(Me.ConstructionDataSet.工事生管担当dtbl)


        SearchGo()

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub SearchGo()

        Try
            Me.Cursor = Cursors.WaitCursor

            Me.外業詳細dtblTableAdapter.FillBy工程予算ＮＯ(Me.ConstructionDataSet.外業詳細dtbl, _PROCESSBUDGETNO)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub 外業詳細Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class