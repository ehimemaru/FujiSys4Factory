Public Class 工程予算Form

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

    Private Sub 工程予算Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'ConstructionDataSet1.工事生管担当dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.工事生管担当dtblTableAdapter.Fill(Me.ConstructionDataSet1.工事生管担当dtbl)
        'TODO: このコード行はデータを 'ConstructionDataSet1.受注営業担当dtbl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.受注営業担当dtblTableAdapter.Fill(Me.ConstructionDataSet1.受注営業担当dtbl)
        Me.工事工程dtblTableAdapter1.Fill(Me.ConstructionDataSet1.工事工程dtbl)
        Me.工事部署dtblTableAdapter1.Fill(Me.ConstructionDataSet1.工事部署dtbl)


        If Space(0).Equals(_CONSTRUCTIONNO) = False Then
            Me.工事詳細簡易dtblTableAdapter1.FillBy工事番号(Me.ConstructionDataSet1.工事詳細簡易dtbl, _CONSTRUCTIONNO)
            Me.工事工程予算dtblTableAdapter1.FillBy工事番号(Me.ConstructionDataSet1.工事工程予算dtbl, _CONSTRUCTIONNO)

            For Each dr As ConstructionDataSet.工事工程予算dtblRow In Me.ConstructionDataSet1.工事工程予算dtbl.Rows
                Dim SumValue As Decimal = dr.社外金額 + dr.社内金額
                If SumValue = 0 Then
                    dr.社外率 = 0
                    dr.社内率 = 0
                Else
                    dr.社内率 = CInt(Math.Floor(dr.社内金額 / SumValue * 100))
                    dr.社外率 = CInt(Math.Floor(dr.社外金額 / SumValue * 100))
                End If
            Next
        End If

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub 工程予算Form_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Dim FormName As String = Me.Text
        Dim ShowFName As New ShowFormNameToMenuClass
        ShowFName.ShowFrmNameMenu(FormName)
    End Sub
End Class