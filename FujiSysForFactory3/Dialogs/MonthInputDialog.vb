Public Class MonthInputDialog

    Private _MONTHSTRING As String

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _MONTHSTRING = Space(0)
    End Sub


    Friend Property TargetMonthString As String
        Get
            Return _MONTHSTRING
        End Get
        Set(value As String)
            _MONTHSTRING = value
        End Set
    End Property



    'Friend Overloads Sub Show(ByVal MonthStr As String, ByRef WinFrm As System.Windows.Forms.IWin32Window)
    '    _MONTHSTRING = MonthStr
    '    MyBase.ShowDialog(WinFrm)

    'End Sub


    Private Sub MonthInputDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DatBase As Date = Today
        If Space(0).Equals(_MONTHSTRING) = False Then
            DatBase = DateSerial(CInt(_MONTHSTRING.Substring(0, 4)), CInt(_MONTHSTRING.Substring(5, 2)), 1)
        End If

        Dim DateX As Date = DateAdd(DateInterval.Year, -1, DatBase)
        Me.YearRadioButton1.Text = DateX.Year.ToString
        Me.YearRadioButton2.Text = DateX.AddYears(1).Year.ToString
        Me.YearRadioButton3.Text = DateX.AddYears(2).Year.ToString


        Dim YearString As String = DatBase.Year.ToString
        Dim MonthString As String = DatBase.Month.ToString.PadLeft(2, "0"c)

        For Each YearCtl As Control In Me.YearGroupBox.Controls
            If TypeOf YearCtl Is RadioButton AndAlso YearString.Equals(YearCtl.Text) Then
                DirectCast(YearCtl, RadioButton).Checked = True
            End If
        Next

        For Each MonthCtl As Control In MonthGroupBox.Controls
            If TypeOf MonthCtl Is RadioButton AndAlso MonthString.Equals(MonthCtl.Text.PadLeft(2, "0"c)) Then
                DirectCast(MonthCtl, RadioButton).Checked = True
            End If
        Next


        Me.CancelButton.Select()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()

    End Sub

    Private Sub GoInputButton_Click(sender As Object, e As EventArgs) Handles GoInputButton.Click
        Dim ChkedYear As String = Space(0)
        For Each YearCtl As Control In Me.YearGroupBox.Controls
            If TypeOf YearCtl Is RadioButton And DirectCast(YearCtl, RadioButton).Checked Then
                ChkedYear = YearCtl.Text
            End If
        Next

        Dim ChkedMonth As String = Space(0)
        For Each MonthCtl As Control In Me.MonthGroupBox.Controls
            If TypeOf MonthCtl Is RadioButton And DirectCast(MonthCtl, RadioButton).Checked Then
                ChkedMonth = MonthCtl.Text
            End If
        Next

        If Space(0).Equals(ChkedYear) OrElse Space(0).Equals(ChkedMonth) Then
            _MONTHSTRING = Space(0)
        Else
            _MONTHSTRING = ChkedYear & "/" & ChkedMonth.PadLeft(2, "0"c)
        End If

        Me.Close()
    End Sub
End Class