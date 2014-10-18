Public Class OutworExistenceDialog

    Private _OUTWORKEXITVALUE As String

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _OUTWORKEXITVALUE = Space(0)
    End Sub

    Friend Property OutworkExitString As String
        Get
            Return _OUTWORKEXITVALUE
        End Get
        Set(value As String)
            _OUTWORKEXITVALUE = value
        End Set
    End Property


    Private Sub GoInput()

        For Each Ctl As Control In Me.OutWorkExistenceGroupBox.Controls
            If TypeOf Ctl Is RadioButton Then
                If DirectCast(Ctl, RadioButton).Checked Then
                    _OUTWORKEXITVALUE = Ctl.Text
                End If
            End If
        Next

        Me.Close()
    End Sub



    Private Sub OutworExistencekDialog_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ''Select Case _OUTWORKEXITVALUE
        ''    Case "有り"
        ''        Me.RadioButtonExist.Checked = True
        ''    Case "無し"
        ''        Me.RadioButtonNotExist.Checked = True
        ''    Case "全て"
        ''        Me.RadioButtonAll.Checked = True
        ''    Case Else
        ''        Me.RadioButtonAll.Checked = True
        ''End Select

    End Sub

    Private Sub RadioBtnClick(sender As Object, e As EventArgs) Handles RadioButtonAll.Click, RadioButtonExist.Click, RadioButtonNotExist.Click
        If TypeOf e Is System.Windows.Forms.MouseEventArgs Then
            GoInput()
        End If
    End Sub


End Class