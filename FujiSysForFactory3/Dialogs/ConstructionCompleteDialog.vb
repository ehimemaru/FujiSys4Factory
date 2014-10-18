Public Class ConstructionCompleteDialog

    Private _COMPLETEVALUE As String

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _COMPLETEVALUE = Space(0)
    End Sub

    Friend Property CompleteString As String
        Get
            Return _COMPLETEVALUE
        End Get
        Set(value As String)
            _COMPLETEVALUE = value
        End Set
    End Property


    Private Sub GoInput()

        For Each Ctl As Control In Me.ConstructionCompleteGroupBox.Controls
            If TypeOf Ctl Is RadioButton Then
                If DirectCast(Ctl, RadioButton).Checked Then
                    _COMPLETEVALUE = Ctl.Text
                End If
            End If
        Next

        Me.Close()
    End Sub


    Private Sub ConstructionCompleteDialog_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Select Case _COMPLETEVALUE
            Case "完了"
                Me.RadioButtonComplete.Checked = True
            Case "未完"
                Me.RadioButtonNotComplete.Checked = True
            Case "全て"
                Me.RadioButtonAll.Checked = True
            Case Else
                Me.RadioButtonAll.Checked = True
        End Select

    End Sub

    Private Sub RadioBtnClick(sender As Object, e As EventArgs) Handles RadioButtonAll.Click, RadioButtonComplete.Click, RadioButtonNotComplete.Click
        If TypeOf e Is System.Windows.Forms.MouseEventArgs Then
            GoInput()
        End If
    End Sub
End Class