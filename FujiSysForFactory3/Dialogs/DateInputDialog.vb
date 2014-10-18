Public Class DateInputDialog

    Private _DATEASTR As String
    Private _DATEBSTR As String

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _DATEASTR = Space(0)
        _DATEBSTR = Space(0)
    End Sub


    Friend Property DateAStr As String
        Get
            Return _DATEASTR
        End Get
        Set(value As String)
            _DATEASTR = value
        End Set
    End Property


    Friend Property DateBStr As String
        Get
            Return _DATEBSTR
        End Get
        Set(value As String)
            _DATEBSTR = value
        End Set
    End Property


    Private Sub DateInputDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.会社休日dtblTableAdapter1.Fill(Me.DialogsDataSet1.会社休日dtbl)


        Dim YearStrA As String = Today.Year.ToString
        Dim MonthStrA As String = Today.Month.ToString

        If Space(0).Equals(_DATEASTR) = False Then
            YearStrA = _DATEASTR.Substring(0, 4)
            MonthStrA = _DATEASTR.Substring(5, 2)
            Me.InputedDateAMaskedTextBox.Text = _DATEASTR
        End If

        Me.TextBoxDateAYear.Text = YearStrA
        Me.TextBoxDateAMonth.Text = MonthStrA


        Dim YearStrB As String = Today.Year.ToString
        Dim MonthStrB As String = Today.Month.ToString

        If Space(0).Equals(_DATEBSTR) = False Then
            YearStrB = _DATEBSTR.Substring(0, 4)
            MonthStrB = _DATEBSTR.Substring(5, 2)
            Me.InputedDateBMaskedTextBox.Text = _DATEBSTR
        End If

        Me.TextBoxDateBYear.Text = YearStrB
        Me.TextBoxDateBMonth.Text = MonthStrB



        RefreshDateAMonthCalender()
        RefreshDateBMonthCalender()


        If Space(0).Equals(_DATEASTR) = False Then
            WhenLoadBtnColorChange(Me.TableLayoutPanel2, CInt(_DATEASTR.Substring(8, 2)).ToString)
        End If
        If Space(0).Equals(_DATEBSTR) = False Then
            WhenLoadBtnColorChange(Me.TableLayoutPanel3, CInt(_DATEBSTR.Substring(8, 2)).ToString)
        End If

    End Sub


    Private Sub RefreshDateAMonthCalender()
        If Me.TextBoxDateAYear.Text.Length <> 4 Then
            Exit Sub
        ElseIf Me.TextBoxDateAMonth.Text.Length = 0 OrElse Me.TextBoxDateAMonth.Text.Length > 2 Then
            Exit Sub
        End If

        Dim iYear As Integer = Convert.ToInt32(Me.TextBoxDateAYear.Text)
        Dim iMonth As Integer = Convert.ToInt32(Me.TextBoxDateAMonth.Text)

        Dim CalenderDateA As Date = DateSerial(iYear, iMonth, 1)
        Dim CalenderDateB As Date = CalenderDateA.AddMonths(1).AddDays(-1)

        Dim ShowStartDate As Date = CalenderDateA.AddDays(CalenderDateA.DayOfWeek * -1)

        For i As Integer = 1 To 42 Step 1
            Dim BtnName As String = "Button" & i.ToString.PadLeft(2, "0"c)
            Dim DateX As Date = ShowStartDate.AddDays(i - 1)

            Dim BoolBtnEnable As Boolean = False
            Dim TextColor As Color = Color.Gainsboro
            Dim BckColor As Color = Color.WhiteSmoke
            If DateX >= CalenderDateA AndAlso DateX <= CalenderDateB Then
                BoolBtnEnable = True
                TextColor = Color.Black
            End If

            If DateX.DayOfWeek = DayOfWeek.Sunday Then
                TextColor = Color.Red
                BckColor = Color.Gainsboro
            Else
                Dim dr As DialogsDataSet.会社休日dtblRow = Me.DialogsDataSet1.会社休日dtbl.FindBy休日(DateX)
                If IsNothing(dr) = False Then
                    TextColor = Color.Blue
                End If
            End If


            For Each Ctl As Control In Me.TableLayoutPanel2.Controls
                If BtnName.Equals(Ctl.Name) Then
                    Dim BtnX As Button = DirectCast(Ctl, Button)
                    BtnX.Text = DateX.Day.ToString
                    BtnX.Enabled = BoolBtnEnable
                    BtnX.ForeColor = TextColor
                    BtnX.BackColor = BckColor
                End If
            Next
        Next
    End Sub


    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()

    End Sub

    Private Sub ButtonYearPre_Click(sender As Object, e As EventArgs) Handles ButtonYearPre.Click
        Dim InputedYear As String = Me.TextBoxDateAYear.Text
        If InputedYear.Length <> 4 Then
            InputedYear = Today.Year.ToString
        End If

        InputedYear = (Convert.ToInt32(InputedYear) - 1).ToString
        Me.TextBoxDateAYear.Text = InputedYear

        RefreshDateAMonthCalender()
    End Sub

    Private Sub ButtonYearNext_Click(sender As Object, e As EventArgs) Handles ButtonYearNext.Click
        Dim InputedYear As String = Me.TextBoxDateAYear.Text
        If InputedYear.Length <> 4 Then
            InputedYear = Today.Year.ToString
        End If

        InputedYear = (Convert.ToInt32(InputedYear) + 1).ToString
        Me.TextBoxDateAYear.Text = InputedYear

        RefreshDateAMonthCalender()
    End Sub

    Private Sub ButtonMonthPre_Click(sender As Object, e As EventArgs) Handles ButtonMonthPre.Click
        Dim InputedMonth As String = Me.TextBoxDateAMonth.Text
        If InputedMonth.Length = 0 Then
            InputedMonth = Today.Month.ToString
        End If

        InputedMonth = (Convert.ToInt32(InputedMonth) - 1).ToString

        If "0".Equals(InputedMonth) Then
            InputedMonth = "12"
            Dim InputedYear As String = (Convert.ToInt32(Me.TextBoxDateAYear.Text) - 1).ToString
            Me.TextBoxDateAYear.Text = InputedYear
        End If

        Me.TextBoxDateAMonth.Text = InputedMonth

        RefreshDateAMonthCalender()
    End Sub

    Private Sub ButtonMonthNext_Click(sender As Object, e As EventArgs) Handles ButtonMonthNext.Click
        Dim InputedMonth As String = Me.TextBoxDateAMonth.Text
        If InputedMonth.Length = 0 Then
            InputedMonth = Today.Month.ToString
        End If

        InputedMonth = (Convert.ToInt32(InputedMonth) + 1).ToString

        If "13".Equals(InputedMonth) Then
            InputedMonth = "1"
            Dim InputedYear As String = (Convert.ToInt32(Me.TextBoxDateAYear.Text) + 1).ToString
            Me.TextBoxDateAYear.Text = InputedYear
        End If

        Me.TextBoxDateAMonth.Text = InputedMonth

        RefreshDateAMonthCalender()
    End Sub


    Private Sub BtnDateAClick(sender As Object, e As EventArgs) Handles Button01.Click, Button02.Click, Button03.Click, Button04.Click, Button05.Click, Button06.Click, Button07.Click, _
        Button08.Click, Button09.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, _
        Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, _
        Button30.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button37.Click, Button38.Click, Button39.Click, Button40.Click, _
        Button41.Click, Button42.Click

        Dim StrDay As String = DirectCast(sender, Button).Text.PadLeft(2, "0"c)
        Dim SelectedDay As String = Me.TextBoxDateAYear.Text & "/" & Me.TextBoxDateAMonth.Text.PadLeft(2, "0"c) & "/" & StrDay

        Me.InputedDateAMaskedTextBox.Text = SelectedDay

        WhenBtnClickColorChange(Me.TableLayoutPanel2, DirectCast(sender, Button), Me.TextBoxDateAYear.Text, TextBoxDateAMonth.Text)

    End Sub

    Private Sub GoInputButton_Click(sender As Object, e As EventArgs) Handles GoInputButton.Click
        If Me.InputedDateAMaskedTextBox.Text.Length = 10 Then
            _DATEASTR = Me.InputedDateAMaskedTextBox.Text
        Else
            _DATEASTR = Space(0)
        End If

        If Me.InputedDateBMaskedTextBox.Text.Length = 10 Then
            _DATEBSTR = Me.InputedDateBMaskedTextBox.Text
        Else
            _DATEBSTR = Space(0)
        End If

        Me.Close()
    End Sub

    Private Sub GoDeleteButton_Click(sender As Object, e As EventArgs) Handles GoDeleteButton.Click
        Me.InputedDateAMaskedTextBox.Text = Space(0)
        _DATEASTR = Space(0)

        Me.InputedDateBMaskedTextBox.Text = Space(0)
        _DATEBSTR = Space(0)

        Me.Close()
    End Sub


    '------終了日の設定等↓

    Private Sub RefreshDateBMonthCalender()
        If Me.TextBoxDateBYear.Text.Length <> 4 Then
            Exit Sub
        ElseIf Me.TextBoxDateBMonth.Text.Length = 0 OrElse Me.TextBoxDateBMonth.Text.Length > 2 Then
            Exit Sub
        End If

        Dim iYear As Integer = Convert.ToInt32(Me.TextBoxDateBYear.Text)
        Dim iMonth As Integer = Convert.ToInt32(Me.TextBoxDateBMonth.Text)

        Dim CalenderDateA As Date = DateSerial(iYear, iMonth, 1)
        Dim CalenderDateB As Date = CalenderDateA.AddMonths(1).AddDays(-1)

        Dim ShowStartDate As Date = CalenderDateA.AddDays(CalenderDateA.DayOfWeek * -1)

        For i As Integer = 1 To 42 Step 1
            Dim BtnName As String = "Btn" & i.ToString.PadLeft(2, "0"c)
            Dim DateX As Date = ShowStartDate.AddDays(i - 1)

            Dim BoolBtnEnable As Boolean = False
            Dim TextColor As Color = Color.Gainsboro
            Dim BckColor As Color = Color.WhiteSmoke
            If DateX >= CalenderDateA AndAlso DateX <= CalenderDateB Then
                BoolBtnEnable = True
                TextColor = Color.Black
            End If

            If DateX.DayOfWeek = DayOfWeek.Sunday Then
                TextColor = Color.Red
                BckColor = Color.Gainsboro
            Else
                Dim dr As DialogsDataSet.会社休日dtblRow = Me.DialogsDataSet1.会社休日dtbl.FindBy休日(DateX)
                If IsNothing(dr) = False Then
                    TextColor = Color.Blue
                End If
            End If


            For Each Ctl As Control In Me.TableLayoutPanel3.Controls
                If BtnName.Equals(Ctl.Name) Then
                    Dim BtnX As Button = DirectCast(Ctl, Button)
                    BtnX.Text = DateX.Day.ToString
                    BtnX.Enabled = BoolBtnEnable
                    BtnX.ForeColor = TextColor
                    BtnX.BackColor = BckColor
                End If
            Next
        Next
    End Sub


    Private Sub ButtonYear2Pre_Click(sender As Object, e As EventArgs) Handles ButtonYear2Pre.Click
        Dim InputedYear As String = Me.TextBoxDateBYear.Text
        If InputedYear.Length <> 4 Then
            InputedYear = Today.Year.ToString
        End If

        InputedYear = (Convert.ToInt32(InputedYear) - 1).ToString
        Me.TextBoxDateBYear.Text = InputedYear

        RefreshDateBMonthCalender()
    End Sub


    Private Sub ButtonYear2Next_Click(sender As Object, e As EventArgs) Handles ButtonYear2Next.Click
        Dim InputedYear As String = Me.TextBoxDateBYear.Text
        If InputedYear.Length <> 4 Then
            InputedYear = Today.Year.ToString
        End If

        InputedYear = (Convert.ToInt32(InputedYear) + 1).ToString
        Me.TextBoxDateBYear.Text = InputedYear

        RefreshDateBMonthCalender()
    End Sub

    Private Sub ButtonMonth2Pre_Click(sender As Object, e As EventArgs) Handles ButtonMonth2Pre.Click
        Dim InputedMonth As String = Me.TextBoxDateBMonth.Text
        If InputedMonth.Length = 0 Then
            InputedMonth = Today.Month.ToString
        End If

        InputedMonth = (Convert.ToInt32(InputedMonth) - 1).ToString

        If "0".Equals(InputedMonth) Then
            InputedMonth = "12"
            Dim InputedYear As String = (Convert.ToInt32(Me.TextBoxDateBYear.Text) - 1).ToString
            Me.TextBoxDateBYear.Text = InputedYear
        End If

        Me.TextBoxDateBMonth.Text = InputedMonth

        RefreshDateBMonthCalender()
    End Sub

    Private Sub ButtonMonth2Next_Click(sender As Object, e As EventArgs) Handles ButtonMonth2Next.Click
        Dim InputedMonth As String = Me.TextBoxDateBMonth.Text
        If InputedMonth.Length = 0 Then
            InputedMonth = Today.Month.ToString
        End If

        InputedMonth = (Convert.ToInt32(InputedMonth) + 1).ToString

        If "13".Equals(InputedMonth) Then
            InputedMonth = "1"
            Dim InputedYear As String = (Convert.ToInt32(Me.TextBoxDateBYear.Text) + 1).ToString
            Me.TextBoxDateBYear.Text = InputedYear
        End If

        Me.TextBoxDateBMonth.Text = InputedMonth

        RefreshDateBMonthCalender()
    End Sub

    Private Sub BtnDateBClick(sender As Object, e As EventArgs) Handles Btn01.Click, Btn02.Click, Btn03.Click, Btn04.Click, Btn05.Click, Btn06.Click, Btn07.Click, _
        Btn08.Click, Btn09.Click, Btn10.Click, Btn11.Click, Btn12.Click, Btn13.Click, Btn14.Click, Btn15.Click, Btn16.Click, Btn17.Click, Btn18.Click, _
        Btn19.Click, Btn20.Click, Btn21.Click, Btn22.Click, Btn23.Click, Btn24.Click, Btn25.Click, Btn26.Click, Btn27.Click, Btn28.Click, Btn29.Click, _
        Btn30.Click, Btn31.Click, Btn32.Click, Btn33.Click, Btn34.Click, Btn35.Click, Btn36.Click, Btn37.Click, Btn38.Click, Btn39.Click, Btn40.Click, _
        Btn41.Click, Btn42.Click

        Dim StrDay As String = DirectCast(sender, Button).Text.PadLeft(2, "0"c)
        Dim SelectedDay As String = Me.TextBoxDateBYear.Text & "/" & Me.TextBoxDateBMonth.Text.PadLeft(2, "0"c) & "/" & StrDay

        Me.InputedDateBMaskedTextBox.Text = SelectedDay

        WhenBtnClickColorChange(Me.TableLayoutPanel3, DirectCast(sender, Button), Me.TextBoxDateBYear.Text, TextBoxDateBMonth.Text)
    End Sub



    Private Sub WhenLoadBtnColorChange(ByRef TblLP As TableLayoutPanel, ByRef DayStr As String)
        For Each Ctl As Control In TblLP.Controls
            If TypeOf Ctl Is Button Then
                If Ctl.Enabled = True AndAlso DayStr.Equals(Ctl.Text) Then
                    Ctl.BackColor = Color.Khaki
                End If
            End If
        Next
    End Sub

    Private Sub WhenBtnClickColorChange(ByRef TblLP As TableLayoutPanel, ByRef ClickedBtn As Button, ByVal StrYear As String, ByVal StrMonth As String)
        For Each Ctl As Control In TblLP.Controls
            If TypeOf Ctl Is Button Then
                If Ctl.BackColor = Color.Khaki Then
                    Dim Dt As Date = Date.ParseExact(StrYear & StrMonth.PadLeft(2, "0"c) & Ctl.Text.PadLeft(2, "0"c), "yyyyMMdd", Nothing)
                    Dim BckColor As Color = Color.WhiteSmoke
                    If Dt.DayOfWeek = DayOfWeek.Sunday Then
                        BckColor = Color.Gainsboro
                    End If
                    Ctl.BackColor = BckColor
                End If
            End If
        Next

        ClickedBtn.BackColor = Color.Khaki
    End Sub

End Class