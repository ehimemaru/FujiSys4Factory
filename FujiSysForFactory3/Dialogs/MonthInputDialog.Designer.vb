<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthInputDialog
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.YearGroupBox = New System.Windows.Forms.GroupBox()
        Me.YearRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.YearRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.YearRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.MonthGroupBox = New System.Windows.Forms.GroupBox()
        Me.MonthRadioButton12 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton8 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton4 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton11 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton7 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton10 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton6 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton9 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton5 = New System.Windows.Forms.RadioButton()
        Me.MonthRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.GoDeleteButton = New System.Windows.Forms.Button()
        Me.GoInputButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.YearGroupBox.SuspendLayout()
        Me.MonthGroupBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'YearGroupBox
        '
        Me.YearGroupBox.BackColor = System.Drawing.Color.DarkGray
        Me.YearGroupBox.Controls.Add(Me.YearRadioButton3)
        Me.YearGroupBox.Controls.Add(Me.YearRadioButton2)
        Me.YearGroupBox.Controls.Add(Me.YearRadioButton1)
        Me.YearGroupBox.Location = New System.Drawing.Point(19, 80)
        Me.YearGroupBox.Name = "YearGroupBox"
        Me.YearGroupBox.Size = New System.Drawing.Size(200, 243)
        Me.YearGroupBox.TabIndex = 0
        Me.YearGroupBox.TabStop = False
        Me.YearGroupBox.Text = "年"
        '
        'YearRadioButton3
        '
        Me.YearRadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.YearRadioButton3.BackColor = System.Drawing.Color.SeaShell
        Me.YearRadioButton3.FlatAppearance.BorderSize = 3
        Me.YearRadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.YearRadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YearRadioButton3.Location = New System.Drawing.Point(19, 174)
        Me.YearRadioButton3.Name = "YearRadioButton3"
        Me.YearRadioButton3.Size = New System.Drawing.Size(162, 51)
        Me.YearRadioButton3.TabIndex = 2
        Me.YearRadioButton3.TabStop = True
        Me.YearRadioButton3.Text = "RadioButton3"
        Me.YearRadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.YearRadioButton3.UseVisualStyleBackColor = False
        '
        'YearRadioButton2
        '
        Me.YearRadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.YearRadioButton2.BackColor = System.Drawing.Color.SeaShell
        Me.YearRadioButton2.FlatAppearance.BorderSize = 3
        Me.YearRadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.YearRadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YearRadioButton2.Location = New System.Drawing.Point(19, 106)
        Me.YearRadioButton2.Name = "YearRadioButton2"
        Me.YearRadioButton2.Size = New System.Drawing.Size(162, 51)
        Me.YearRadioButton2.TabIndex = 1
        Me.YearRadioButton2.TabStop = True
        Me.YearRadioButton2.Text = "RadioButton2"
        Me.YearRadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.YearRadioButton2.UseVisualStyleBackColor = False
        '
        'YearRadioButton1
        '
        Me.YearRadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.YearRadioButton1.BackColor = System.Drawing.Color.SeaShell
        Me.YearRadioButton1.FlatAppearance.BorderSize = 3
        Me.YearRadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.YearRadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YearRadioButton1.Location = New System.Drawing.Point(19, 39)
        Me.YearRadioButton1.Name = "YearRadioButton1"
        Me.YearRadioButton1.Size = New System.Drawing.Size(162, 51)
        Me.YearRadioButton1.TabIndex = 0
        Me.YearRadioButton1.TabStop = True
        Me.YearRadioButton1.Text = "RadioButton1"
        Me.YearRadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.YearRadioButton1.UseVisualStyleBackColor = False
        '
        'MonthGroupBox
        '
        Me.MonthGroupBox.BackColor = System.Drawing.Color.DarkGray
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton12)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton8)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton4)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton11)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton7)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton3)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton10)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton6)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton2)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton9)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton5)
        Me.MonthGroupBox.Controls.Add(Me.MonthRadioButton1)
        Me.MonthGroupBox.Location = New System.Drawing.Point(218, 80)
        Me.MonthGroupBox.Name = "MonthGroupBox"
        Me.MonthGroupBox.Size = New System.Drawing.Size(554, 243)
        Me.MonthGroupBox.TabIndex = 1
        Me.MonthGroupBox.TabStop = False
        Me.MonthGroupBox.Text = "月"
        '
        'MonthRadioButton12
        '
        Me.MonthRadioButton12.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton12.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton12.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton12.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton12.Location = New System.Drawing.Point(417, 174)
        Me.MonthRadioButton12.Name = "MonthRadioButton12"
        Me.MonthRadioButton12.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton12.TabIndex = 12
        Me.MonthRadioButton12.TabStop = True
        Me.MonthRadioButton12.Text = "12"
        Me.MonthRadioButton12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton12.UseVisualStyleBackColor = False
        '
        'MonthRadioButton8
        '
        Me.MonthRadioButton8.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton8.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton8.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton8.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton8.Location = New System.Drawing.Point(417, 106)
        Me.MonthRadioButton8.Name = "MonthRadioButton8"
        Me.MonthRadioButton8.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton8.TabIndex = 11
        Me.MonthRadioButton8.TabStop = True
        Me.MonthRadioButton8.Text = "8"
        Me.MonthRadioButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton8.UseVisualStyleBackColor = False
        '
        'MonthRadioButton4
        '
        Me.MonthRadioButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton4.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton4.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton4.Location = New System.Drawing.Point(417, 39)
        Me.MonthRadioButton4.Name = "MonthRadioButton4"
        Me.MonthRadioButton4.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton4.TabIndex = 10
        Me.MonthRadioButton4.TabStop = True
        Me.MonthRadioButton4.Text = "4"
        Me.MonthRadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton4.UseVisualStyleBackColor = False
        '
        'MonthRadioButton11
        '
        Me.MonthRadioButton11.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton11.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton11.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton11.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton11.Location = New System.Drawing.Point(283, 174)
        Me.MonthRadioButton11.Name = "MonthRadioButton11"
        Me.MonthRadioButton11.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton11.TabIndex = 9
        Me.MonthRadioButton11.TabStop = True
        Me.MonthRadioButton11.Text = "11"
        Me.MonthRadioButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton11.UseVisualStyleBackColor = False
        '
        'MonthRadioButton7
        '
        Me.MonthRadioButton7.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton7.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton7.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton7.Location = New System.Drawing.Point(283, 106)
        Me.MonthRadioButton7.Name = "MonthRadioButton7"
        Me.MonthRadioButton7.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton7.TabIndex = 8
        Me.MonthRadioButton7.TabStop = True
        Me.MonthRadioButton7.Text = "7"
        Me.MonthRadioButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton7.UseVisualStyleBackColor = False
        '
        'MonthRadioButton3
        '
        Me.MonthRadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton3.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton3.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton3.Location = New System.Drawing.Point(283, 39)
        Me.MonthRadioButton3.Name = "MonthRadioButton3"
        Me.MonthRadioButton3.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton3.TabIndex = 7
        Me.MonthRadioButton3.TabStop = True
        Me.MonthRadioButton3.Text = "3"
        Me.MonthRadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton3.UseVisualStyleBackColor = False
        '
        'MonthRadioButton10
        '
        Me.MonthRadioButton10.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton10.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton10.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton10.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton10.Location = New System.Drawing.Point(150, 174)
        Me.MonthRadioButton10.Name = "MonthRadioButton10"
        Me.MonthRadioButton10.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton10.TabIndex = 6
        Me.MonthRadioButton10.TabStop = True
        Me.MonthRadioButton10.Text = "10"
        Me.MonthRadioButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton10.UseVisualStyleBackColor = False
        '
        'MonthRadioButton6
        '
        Me.MonthRadioButton6.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton6.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton6.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton6.Location = New System.Drawing.Point(150, 106)
        Me.MonthRadioButton6.Name = "MonthRadioButton6"
        Me.MonthRadioButton6.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton6.TabIndex = 5
        Me.MonthRadioButton6.TabStop = True
        Me.MonthRadioButton6.Text = "6"
        Me.MonthRadioButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton6.UseVisualStyleBackColor = False
        '
        'MonthRadioButton2
        '
        Me.MonthRadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton2.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton2.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton2.Location = New System.Drawing.Point(150, 39)
        Me.MonthRadioButton2.Name = "MonthRadioButton2"
        Me.MonthRadioButton2.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton2.TabIndex = 4
        Me.MonthRadioButton2.TabStop = True
        Me.MonthRadioButton2.Text = "2"
        Me.MonthRadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton2.UseVisualStyleBackColor = False
        '
        'MonthRadioButton9
        '
        Me.MonthRadioButton9.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton9.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton9.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton9.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton9.Location = New System.Drawing.Point(17, 174)
        Me.MonthRadioButton9.Name = "MonthRadioButton9"
        Me.MonthRadioButton9.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton9.TabIndex = 3
        Me.MonthRadioButton9.TabStop = True
        Me.MonthRadioButton9.Text = "9"
        Me.MonthRadioButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton9.UseVisualStyleBackColor = False
        '
        'MonthRadioButton5
        '
        Me.MonthRadioButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton5.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton5.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton5.Location = New System.Drawing.Point(17, 106)
        Me.MonthRadioButton5.Name = "MonthRadioButton5"
        Me.MonthRadioButton5.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton5.TabIndex = 2
        Me.MonthRadioButton5.TabStop = True
        Me.MonthRadioButton5.Text = "5"
        Me.MonthRadioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton5.UseVisualStyleBackColor = False
        '
        'MonthRadioButton1
        '
        Me.MonthRadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.MonthRadioButton1.BackColor = System.Drawing.Color.SeaShell
        Me.MonthRadioButton1.FlatAppearance.BorderSize = 3
        Me.MonthRadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthRadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthRadioButton1.Location = New System.Drawing.Point(17, 39)
        Me.MonthRadioButton1.Name = "MonthRadioButton1"
        Me.MonthRadioButton1.Size = New System.Drawing.Size(118, 51)
        Me.MonthRadioButton1.TabIndex = 1
        Me.MonthRadioButton1.TabStop = True
        Me.MonthRadioButton1.Text = "1"
        Me.MonthRadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MonthRadioButton1.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CancelButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GoDeleteButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GoInputButton, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(19, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 52)
        Me.TableLayoutPanel1.TabIndex = 54
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.CancelButton.FlatAppearance.BorderSize = 2
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Location = New System.Drawing.Point(399, 3)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(198, 46)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "キャンセル"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'GoDeleteButton
        '
        Me.GoDeleteButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GoDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GoDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.GoDeleteButton.FlatAppearance.BorderSize = 2
        Me.GoDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoDeleteButton.Location = New System.Drawing.Point(201, 3)
        Me.GoDeleteButton.Name = "GoDeleteButton"
        Me.GoDeleteButton.Size = New System.Drawing.Size(192, 46)
        Me.GoDeleteButton.TabIndex = 1
        Me.GoDeleteButton.Text = "削除"
        Me.GoDeleteButton.UseVisualStyleBackColor = False
        '
        'GoInputButton
        '
        Me.GoInputButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GoInputButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GoInputButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.GoInputButton.FlatAppearance.BorderSize = 2
        Me.GoInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoInputButton.Location = New System.Drawing.Point(3, 3)
        Me.GoInputButton.Name = "GoInputButton"
        Me.GoInputButton.Size = New System.Drawing.Size(192, 46)
        Me.GoInputButton.TabIndex = 0
        Me.GoInputButton.Text = "入力"
        Me.GoInputButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(4, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(783, 4)
        Me.Label1.TabIndex = 55
        '
        'MonthInputDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 327)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthGroupBox)
        Me.Controls.Add(Me.YearGroupBox)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "MonthInputDialog"
        Me.Text = "対象月入力"
        Me.YearGroupBox.ResumeLayout(False)
        Me.MonthGroupBox.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents YearGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents YearRadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents YearRadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents YearRadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MonthRadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents MonthRadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents GoDeleteButton As System.Windows.Forms.Button
    Friend WithEvents GoInputButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
