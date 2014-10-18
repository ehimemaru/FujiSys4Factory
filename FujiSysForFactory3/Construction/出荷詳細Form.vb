Public Class 出荷詳細Form

    Private _PROCESSBUDGETNO As Integer

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _PROCESSBUDGETNO = 0
    End Sub


    Friend Overloads Sub Show(ByVal probugno As Integer)
        _PROCESSBUDGETNO = probugno
        MyBase.Show()

    End Sub


    Private Sub 出荷詳細Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        'TODO: このコード行はデータを 'ConstructionDataSet1.工事歴代社員dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.工事歴代社員dtblTableAdapter.Fill(Me.ConstructionDataSet1.工事歴代社員dtbl)
        'TODO: このコード行はデータを 'ConstructionDataSet1.工事部署dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.工事部署dtblTableAdapter.Fill(Me.ConstructionDataSet1.工事部署dtbl)
        'TODO: このコード行はデータを 'ConstructionDataSet1.受注営業担当dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.受注営業担当dtblTableAdapter.Fill(Me.ConstructionDataSet1.受注営業担当dtbl)
        'TODO: このコード行はデータを 'ConstructionDataSet1.工事生管担当dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.工事生管担当dtblTableAdapter.Fill(Me.ConstructionDataSet1.工事生管担当dtbl)
        Me.工事取引先最新dtblTableAdapter1.Fill(Me.ConstructionDataSet1.工事取引先最新dtbl)



        Me.出荷詳細dtblTableAdapter1.FillBy工程予算ＮＯ(Me.ConstructionDataSet1.出荷詳細dtbl, _PROCESSBUDGETNO)

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub 出荷詳細Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class