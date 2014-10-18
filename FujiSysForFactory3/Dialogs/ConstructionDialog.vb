Public Class ConstructionDialog

    Private _CONSTRUCTIONNO As String

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _CONSTRUCTIONNO = Space(0)
    End Sub

    Friend Property InputedConstructionNo As String
        Get
            Return _CONSTRUCTIONNO
        End Get
        Set(value As String)
            _CONSTRUCTIONNO = value
        End Set
    End Property


    Private Sub TextClearButton_Click(sender As Object, e As EventArgs) Handles TextClearButton.Click
        Me.InputedConstNoMaskedTextBox.Text = Space(0)

    End Sub


    Private Sub BtnClick(sender As Object, e As EventArgs) Handles ChrAButton.Click, ChrBButton.Click, ChrCButton.Click, ChrDButton.Click, ChrEButton.Click, ChrFButton.Click, ChrGButton.Click, _
        ChrHButton.Click, ChrIButton.Click, ChrJButton.Click, ChrKButton.Click, ChrLButton.Click, ChrMButton.Click, ChrNButton.Click, ChrOButton.Click, ChrPButton.Click, ChrQButton.Click, _
        ChrRButton.Click, ChrSButton.Click, ChrTButton.Click, ChrUButton.Click, ChrVButton.Click, ChrWButton.Click, ChrXButton.Click, ChrYButton.Click, ChrZButton.Click, _
        Num0Button.Click, NUm1Button.Click, Num2Button.Click, Num3Button.Click, Num4Button.Click, Num5Button.Click, Num6Button.Click, Num7Button.Click, Num8Button.Click, Num9Button.Click

        Dim InputedConstructionNo As String = Me.InputedConstNoMaskedTextBox.Text
        InputedConstructionNo = InputedConstructionNo.Trim.Replace(" ", "").Replace("-", "")

        If InputedConstructionNo.Length <> 11 Then
            InputedConstructionNo &= DirectCast(sender, Button).Name.Substring(3, 1)

            Me.InputedConstNoMaskedTextBox.Text = InputedConstructionNo
        End If

    End Sub


    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()

    End Sub

    Private Sub GoInputButton_Click(sender As Object, e As EventArgs) Handles GoInputButton.Click
        _CONSTRUCTIONNO = Me.InputedConstNoMaskedTextBox.Text.Replace("-", "")
        Me.Close()

    End Sub

    Private Sub GoDeleteButton_Click(sender As Object, e As EventArgs) Handles GoDeleteButton.Click
        Me.InputedConstNoMaskedTextBox.Text = Space(0)
        _CONSTRUCTIONNO = Space(0)
        Me.Close()

    End Sub
End Class