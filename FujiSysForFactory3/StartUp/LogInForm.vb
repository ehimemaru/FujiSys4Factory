Public Class LogInForm

    ' TODO: 指定されたユーザー名およびパスワードを使用して、カスタム認証を実行するコードを挿入します 
    ' ( http://go.microsoft.com/fwlink/?LinkId=35339 を参照してください)。  
    ' カスタム プリンシパルは、以下のように現在のスレッドのプリンシパルにアタッチできます: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' この場合 CustomPrincipal は、認証を実行するのに使われる IPrincipal 実装です。 
    ' これにより My.User は、ユーザー名および表示名などの CustomPrincipal オブジェクトに要約された ID 情報を
    ' 返します。


    Private Sub StaffIDBtnClick(sender As Object, e As EventArgs) Handles Num0Button.Click, NUm1Button.Click, Num2Button.Click, Num3Button.Click, Num4Button.Click, Num5Button.Click, Num6Button.Click, Num7Button.Click, Num8Button.Click, Num9Button.Click
        Dim InputD As String = Me.StaffIDMaskedTextBox.Text

        If InputD.Length < 4 Then
            Dim CtlNameNum As String = DirectCast(sender, Button).Name.Substring(3, 1)
            InputD &= CtlNameNum

            Me.StaffIDMaskedTextBox.Text = InputD

        End If

    End Sub

    Private Sub StaffIDMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles StaffIDMaskedTextBox.TextChanged
        Dim InputStaffID As String = Me.StaffIDMaskedTextBox.Text
        If InputStaffID.Length = 4 Then
            Dim StaffName As String = Space(0)

            Dim dr As StartUpDataSet.権限有社員パスdtblRow = Me.StartUpDataSet1.権限有社員パスdtbl.FindBy社員ＩＤ(InputStaffID)

            If IsNothing(dr) = False Then
                StaffName = dr.社員名
                Me.StaffNameLabel.Text = StaffName

                ChkStaffIDandPass()
            Else
                Me.StaffNameLabel.Text = StaffName
            End If
        End If
    End Sub

    Private Sub TextClearButton_Click(sender As Object, e As EventArgs) Handles TextClearButton.Click
        Me.StaffIDMaskedTextBox.Text = Space(0)
        Me.StaffNameLabel.Text = Space(0)

    End Sub


    Private Sub StaffIDBtnClick2(sender As Object, e As EventArgs) Handles Num0Button2.Click, Num1Button2.Click, Num2Button2.Click, Num3Button2.Click, Num4Button2.Click, Num5Button2.Click, Num6Button2.Click, Num7Button2.Click, Num8Button2.Click, Num9Button2.Click
        Dim InputPass As String = Me.PasswordMaskedTextBox.Text

        If InputPass.Length < 4 Then
            Dim CtlNameNum As String = DirectCast(sender, Button).Name.Substring(3, 1)
            InputPass &= CtlNameNum

            Me.PasswordMaskedTextBox.Text = InputPass

        End If

    End Sub

    Private Sub TextClearButton2_Click(sender As Object, e As EventArgs) Handles TextClearButton2.Click
        Me.PasswordMaskedTextBox.Text = Space(0)

    End Sub

    Private Sub PasswordMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordMaskedTextBox.TextChanged
        Dim InputPass As String = Me.PasswordMaskedTextBox.Text

        If InputPass.Length = 4 Then
            ChkStaffIDandPass()

        End If

    End Sub


    Private Sub ChkStaffIDandPass()
        If Me.StaffNameLabel.Text.Length > 0 AndAlso Me.PasswordMaskedTextBox.Text.Length = 4 Then
            Dim InputPass As String = Me.PasswordMaskedTextBox.Text

            Dim Result = From dr In Me.StartUpDataSet1.権限有社員パスdtbl.AsEnumerable _
                         Where dr.PASSWORD = InputPass _
                         Select dr


            If Result.Count = 0 Then
                Exit Sub

            Else
                Dim StaffID As String = Me.StaffIDMaskedTextBox.Text
                AddMenuStrips(StaffID, Me.StaffNameLabel.Text)

            End If

        End If

    End Sub


    Private Sub AddMenuStrips(ByVal _StaffID As String, ByVal _StaffName As String)
        Me.社員権限画面dtblTableAdapter1.FillBy社員ＩＤ(Me.StartUpDataSet1.社員権限画面dtbl, _StaffID)

        Dim LargeItems = (From drow In Me.StartUpDataSet1.社員権限画面dtbl.AsEnumerable _
                         Select drow.分類名).Distinct


        For Each item In LargeItems
            Dim MenuDropDownBtn As New ToolStripDropDownButton
            MenuDropDownBtn.Name = item
            MenuDropDownBtn.Text = item

            Dim SubItems = From drow In Me.StartUpDataSet1.社員権限画面dtbl.AsEnumerable _
                            Where drow.分類名 = item _
                            Select drow.画面名

            For Each SubItem In SubItems
                Dim SubToolItem As New ToolStripMenuItem
                SubToolItem.Name = SubItem
                SubToolItem.Text = SubItem

                AddHandler SubToolItem.Click, AddressOf ClickMenuOpenForm

                MenuDropDownBtn.DropDownItems.Add(SubToolItem)
            Next

            My.Forms.MainForm.MainMenuStrip.Items.Add(MenuDropDownBtn)
        Next

        'ログイン社員名を表示
        Dim MenuStaffName As New ToolStripLabel
        MenuStaffName.Text = "(" & _StaffName & ")"
        My.Forms.MainForm.MainMenuStrip.Items.Add(MenuStaffName)

        'バージョンを表示
        Dim MenuAppVersion As New ToolStripLabel
        MenuAppVersion.Text = "Ver " & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString
        My.Forms.MainForm.MainMenuStrip.Items.Add(MenuAppVersion)

        Me.Close()

    End Sub




    Private Sub LogInForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        '--実運用では下記を使用不可に
        'Me.権限有社員パスdtblTableAdapter1.Fill(Me.StartUpDataSet1.権限有社員パスdtbl)

        '実運用用　権限800　or　990
        Me.権限有社員パスdtblTableAdapter1.FillBy権限800(Me.StartUpDataSet1.権限有社員パスdtbl)


    End Sub
End Class
