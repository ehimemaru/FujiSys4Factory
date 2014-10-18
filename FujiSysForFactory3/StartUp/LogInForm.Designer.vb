<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LogInForm
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.StaffIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PasswordMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StaffNameLabel = New System.Windows.Forms.Label()
        Me.TextClearButton = New System.Windows.Forms.Button()
        Me.Num0Button = New System.Windows.Forms.Button()
        Me.Num3Button = New System.Windows.Forms.Button()
        Me.Num2Button = New System.Windows.Forms.Button()
        Me.NUm1Button = New System.Windows.Forms.Button()
        Me.Num6Button = New System.Windows.Forms.Button()
        Me.Num5Button = New System.Windows.Forms.Button()
        Me.Num4Button = New System.Windows.Forms.Button()
        Me.Num9Button = New System.Windows.Forms.Button()
        Me.Num8Button = New System.Windows.Forms.Button()
        Me.Num7Button = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextClearButton2 = New System.Windows.Forms.Button()
        Me.Num0Button2 = New System.Windows.Forms.Button()
        Me.Num3Button2 = New System.Windows.Forms.Button()
        Me.Num2Button2 = New System.Windows.Forms.Button()
        Me.Num1Button2 = New System.Windows.Forms.Button()
        Me.Num6Button2 = New System.Windows.Forms.Button()
        Me.Num5Button2 = New System.Windows.Forms.Button()
        Me.Num4Button2 = New System.Windows.Forms.Button()
        Me.Num9Button2 = New System.Windows.Forms.Button()
        Me.Num8Button2 = New System.Windows.Forms.Button()
        Me.Num7Button2 = New System.Windows.Forms.Button()
        Me.StartUpDataSet1 = New FujiSysForFactory3.StartUpDataSet()
        Me.権限有社員パスdtblTableAdapter1 = New FujiSysForFactory3.StartUpDataSetTableAdapters.権限有社員パスdtblTableAdapter()
        Me.社員権限画面dtblTableAdapter1 = New FujiSysForFactory3.StartUpDataSetTableAdapters.社員権限画面dtblTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.StartUpDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(0, 12)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "社員番号"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(0, 12)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "パスワード"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StaffIDMaskedTextBox
        '
        Me.StaffIDMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffIDMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StaffIDMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.StaffIDMaskedTextBox.Location = New System.Drawing.Point(4, 38)
        Me.StaffIDMaskedTextBox.Mask = "0000"
        Me.StaffIDMaskedTextBox.Name = "StaffIDMaskedTextBox"
        Me.StaffIDMaskedTextBox.Size = New System.Drawing.Size(135, 31)
        Me.StaffIDMaskedTextBox.TabIndex = 6
        Me.StaffIDMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordMaskedTextBox
        '
        Me.PasswordMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PasswordMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.PasswordMaskedTextBox.Location = New System.Drawing.Point(4, 38)
        Me.PasswordMaskedTextBox.Mask = "0000"
        Me.PasswordMaskedTextBox.Name = "PasswordMaskedTextBox"
        Me.PasswordMaskedTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordMaskedTextBox.Size = New System.Drawing.Size(206, 31)
        Me.PasswordMaskedTextBox.TabIndex = 7
        Me.PasswordMaskedTextBox.Text = "3811"
        Me.PasswordMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.StaffNameLabel)
        Me.Panel1.Controls.Add(Me.TextClearButton)
        Me.Panel1.Controls.Add(Me.Num0Button)
        Me.Panel1.Controls.Add(Me.Num3Button)
        Me.Panel1.Controls.Add(Me.Num2Button)
        Me.Panel1.Controls.Add(Me.NUm1Button)
        Me.Panel1.Controls.Add(Me.Num6Button)
        Me.Panel1.Controls.Add(Me.Num5Button)
        Me.Panel1.Controls.Add(Me.Num4Button)
        Me.Panel1.Controls.Add(Me.Num9Button)
        Me.Panel1.Controls.Add(Me.Num8Button)
        Me.Panel1.Controls.Add(Me.Num7Button)
        Me.Panel1.Controls.Add(Me.StaffIDMaskedTextBox)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Location = New System.Drawing.Point(28, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 409)
        Me.Panel1.TabIndex = 8
        '
        'StaffNameLabel
        '
        Me.StaffNameLabel.BackColor = System.Drawing.Color.Gainsboro
        Me.StaffNameLabel.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StaffNameLabel.Location = New System.Drawing.Point(145, 41)
        Me.StaffNameLabel.Name = "StaffNameLabel"
        Me.StaffNameLabel.Size = New System.Drawing.Size(177, 23)
        Me.StaffNameLabel.TabIndex = 21
        Me.StaffNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextClearButton
        '
        Me.TextClearButton.BackColor = System.Drawing.Color.Gainsboro
        Me.TextClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TextClearButton.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextClearButton.Location = New System.Drawing.Point(110, 288)
        Me.TextClearButton.Name = "TextClearButton"
        Me.TextClearButton.Size = New System.Drawing.Size(206, 52)
        Me.TextClearButton.TabIndex = 20
        Me.TextClearButton.TabStop = False
        Me.TextClearButton.Text = "クリア"
        Me.TextClearButton.UseVisualStyleBackColor = False
        '
        'Num0Button
        '
        Me.Num0Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Num0Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num0Button.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num0Button.Location = New System.Drawing.Point(4, 288)
        Me.Num0Button.Name = "Num0Button"
        Me.Num0Button.Size = New System.Drawing.Size(100, 52)
        Me.Num0Button.TabIndex = 18
        Me.Num0Button.TabStop = False
        Me.Num0Button.Text = "0"
        Me.Num0Button.UseVisualStyleBackColor = False
        '
        'Num3Button
        '
        Me.Num3Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Num3Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num3Button.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num3Button.Location = New System.Drawing.Point(216, 222)
        Me.Num3Button.Name = "Num3Button"
        Me.Num3Button.Size = New System.Drawing.Size(100, 52)
        Me.Num3Button.TabIndex = 17
        Me.Num3Button.TabStop = False
        Me.Num3Button.Text = "3"
        Me.Num3Button.UseVisualStyleBackColor = False
        '
        'Num2Button
        '
        Me.Num2Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Num2Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num2Button.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num2Button.Location = New System.Drawing.Point(110, 222)
        Me.Num2Button.Name = "Num2Button"
        Me.Num2Button.Size = New System.Drawing.Size(100, 52)
        Me.Num2Button.TabIndex = 16
        Me.Num2Button.TabStop = False
        Me.Num2Button.Text = "2"
        Me.Num2Button.UseVisualStyleBackColor = False
        '
        'NUm1Button
        '
        Me.NUm1Button.BackColor = System.Drawing.Color.Gainsboro
        Me.NUm1Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NUm1Button.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NUm1Button.Location = New System.Drawing.Point(4, 222)
        Me.NUm1Button.Name = "NUm1Button"
        Me.NUm1Button.Size = New System.Drawing.Size(100, 52)
        Me.NUm1Button.TabIndex = 15
        Me.NUm1Button.TabStop = False
        Me.NUm1Button.Text = "1"
        Me.NUm1Button.UseVisualStyleBackColor = False
        '
        'Num6Button
        '
        Me.Num6Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Num6Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num6Button.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num6Button.Location = New System.Drawing.Point(216, 159)
        Me.Num6Button.Name = "Num6Button"
        Me.Num6Button.Size = New System.Drawing.Size(100, 52)
        Me.Num6Button.TabIndex = 14
        Me.Num6Button.TabStop = False
        Me.Num6Button.Text = "6"
        Me.Num6Button.UseVisualStyleBackColor = False
        '
        'Num5Button
        '
        Me.Num5Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Num5Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num5Button.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num5Button.Location = New System.Drawing.Point(110, 159)
        Me.Num5Button.Name = "Num5Button"
        Me.Num5Button.Size = New System.Drawing.Size(100, 52)
        Me.Num5Button.TabIndex = 13
        Me.Num5Button.TabStop = False
        Me.Num5Button.Text = "5"
        Me.Num5Button.UseVisualStyleBackColor = False
        '
        'Num4Button
        '
        Me.Num4Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Num4Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num4Button.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num4Button.Location = New System.Drawing.Point(4, 159)
        Me.Num4Button.Name = "Num4Button"
        Me.Num4Button.Size = New System.Drawing.Size(100, 52)
        Me.Num4Button.TabIndex = 12
        Me.Num4Button.TabStop = False
        Me.Num4Button.Text = "4"
        Me.Num4Button.UseVisualStyleBackColor = False
        '
        'Num9Button
        '
        Me.Num9Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Num9Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num9Button.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num9Button.Location = New System.Drawing.Point(216, 97)
        Me.Num9Button.Name = "Num9Button"
        Me.Num9Button.Size = New System.Drawing.Size(100, 52)
        Me.Num9Button.TabIndex = 11
        Me.Num9Button.TabStop = False
        Me.Num9Button.Text = "9"
        Me.Num9Button.UseVisualStyleBackColor = False
        '
        'Num8Button
        '
        Me.Num8Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Num8Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num8Button.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num8Button.Location = New System.Drawing.Point(110, 97)
        Me.Num8Button.Name = "Num8Button"
        Me.Num8Button.Size = New System.Drawing.Size(100, 52)
        Me.Num8Button.TabIndex = 10
        Me.Num8Button.TabStop = False
        Me.Num8Button.Text = "8"
        Me.Num8Button.UseVisualStyleBackColor = False
        '
        'Num7Button
        '
        Me.Num7Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Num7Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num7Button.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num7Button.Location = New System.Drawing.Point(4, 97)
        Me.Num7Button.Name = "Num7Button"
        Me.Num7Button.Size = New System.Drawing.Size(100, 52)
        Me.Num7Button.TabIndex = 9
        Me.Num7Button.TabStop = False
        Me.Num7Button.Text = "7"
        Me.Num7Button.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextClearButton2)
        Me.Panel2.Controls.Add(Me.Num0Button2)
        Me.Panel2.Controls.Add(Me.PasswordMaskedTextBox)
        Me.Panel2.Controls.Add(Me.Num3Button2)
        Me.Panel2.Controls.Add(Me.Num2Button2)
        Me.Panel2.Controls.Add(Me.PasswordLabel)
        Me.Panel2.Controls.Add(Me.Num1Button2)
        Me.Panel2.Controls.Add(Me.Num6Button2)
        Me.Panel2.Controls.Add(Me.Num5Button2)
        Me.Panel2.Controls.Add(Me.Num4Button2)
        Me.Panel2.Controls.Add(Me.Num9Button2)
        Me.Panel2.Controls.Add(Me.Num8Button2)
        Me.Panel2.Controls.Add(Me.Num7Button2)
        Me.Panel2.Location = New System.Drawing.Point(376, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 409)
        Me.Panel2.TabIndex = 9
        '
        'TextClearButton2
        '
        Me.TextClearButton2.BackColor = System.Drawing.Color.Gainsboro
        Me.TextClearButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TextClearButton2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextClearButton2.Location = New System.Drawing.Point(110, 288)
        Me.TextClearButton2.Name = "TextClearButton2"
        Me.TextClearButton2.Size = New System.Drawing.Size(206, 52)
        Me.TextClearButton2.TabIndex = 20
        Me.TextClearButton2.TabStop = False
        Me.TextClearButton2.Text = "クリア"
        Me.TextClearButton2.UseVisualStyleBackColor = False
        '
        'Num0Button2
        '
        Me.Num0Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Num0Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num0Button2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num0Button2.Location = New System.Drawing.Point(4, 288)
        Me.Num0Button2.Name = "Num0Button2"
        Me.Num0Button2.Size = New System.Drawing.Size(100, 52)
        Me.Num0Button2.TabIndex = 18
        Me.Num0Button2.TabStop = False
        Me.Num0Button2.Text = "0"
        Me.Num0Button2.UseVisualStyleBackColor = False
        '
        'Num3Button2
        '
        Me.Num3Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Num3Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num3Button2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num3Button2.Location = New System.Drawing.Point(216, 222)
        Me.Num3Button2.Name = "Num3Button2"
        Me.Num3Button2.Size = New System.Drawing.Size(100, 52)
        Me.Num3Button2.TabIndex = 17
        Me.Num3Button2.TabStop = False
        Me.Num3Button2.Text = "3"
        Me.Num3Button2.UseVisualStyleBackColor = False
        '
        'Num2Button2
        '
        Me.Num2Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Num2Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num2Button2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num2Button2.Location = New System.Drawing.Point(110, 222)
        Me.Num2Button2.Name = "Num2Button2"
        Me.Num2Button2.Size = New System.Drawing.Size(100, 52)
        Me.Num2Button2.TabIndex = 16
        Me.Num2Button2.TabStop = False
        Me.Num2Button2.Text = "2"
        Me.Num2Button2.UseVisualStyleBackColor = False
        '
        'Num1Button2
        '
        Me.Num1Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Num1Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num1Button2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num1Button2.Location = New System.Drawing.Point(4, 222)
        Me.Num1Button2.Name = "Num1Button2"
        Me.Num1Button2.Size = New System.Drawing.Size(100, 52)
        Me.Num1Button2.TabIndex = 15
        Me.Num1Button2.TabStop = False
        Me.Num1Button2.Text = "1"
        Me.Num1Button2.UseVisualStyleBackColor = False
        '
        'Num6Button2
        '
        Me.Num6Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Num6Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num6Button2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num6Button2.Location = New System.Drawing.Point(216, 159)
        Me.Num6Button2.Name = "Num6Button2"
        Me.Num6Button2.Size = New System.Drawing.Size(100, 52)
        Me.Num6Button2.TabIndex = 14
        Me.Num6Button2.TabStop = False
        Me.Num6Button2.Text = "6"
        Me.Num6Button2.UseVisualStyleBackColor = False
        '
        'Num5Button2
        '
        Me.Num5Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Num5Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num5Button2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num5Button2.Location = New System.Drawing.Point(110, 159)
        Me.Num5Button2.Name = "Num5Button2"
        Me.Num5Button2.Size = New System.Drawing.Size(100, 52)
        Me.Num5Button2.TabIndex = 13
        Me.Num5Button2.TabStop = False
        Me.Num5Button2.Text = "5"
        Me.Num5Button2.UseVisualStyleBackColor = False
        '
        'Num4Button2
        '
        Me.Num4Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Num4Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num4Button2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num4Button2.Location = New System.Drawing.Point(4, 159)
        Me.Num4Button2.Name = "Num4Button2"
        Me.Num4Button2.Size = New System.Drawing.Size(100, 52)
        Me.Num4Button2.TabIndex = 12
        Me.Num4Button2.TabStop = False
        Me.Num4Button2.Text = "4"
        Me.Num4Button2.UseVisualStyleBackColor = False
        '
        'Num9Button2
        '
        Me.Num9Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Num9Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num9Button2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num9Button2.Location = New System.Drawing.Point(216, 97)
        Me.Num9Button2.Name = "Num9Button2"
        Me.Num9Button2.Size = New System.Drawing.Size(100, 52)
        Me.Num9Button2.TabIndex = 11
        Me.Num9Button2.TabStop = False
        Me.Num9Button2.Text = "9"
        Me.Num9Button2.UseVisualStyleBackColor = False
        '
        'Num8Button2
        '
        Me.Num8Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Num8Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num8Button2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num8Button2.Location = New System.Drawing.Point(110, 97)
        Me.Num8Button2.Name = "Num8Button2"
        Me.Num8Button2.Size = New System.Drawing.Size(100, 52)
        Me.Num8Button2.TabIndex = 10
        Me.Num8Button2.TabStop = False
        Me.Num8Button2.Text = "8"
        Me.Num8Button2.UseVisualStyleBackColor = False
        '
        'Num7Button2
        '
        Me.Num7Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Num7Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num7Button2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Num7Button2.Location = New System.Drawing.Point(4, 97)
        Me.Num7Button2.Name = "Num7Button2"
        Me.Num7Button2.Size = New System.Drawing.Size(100, 52)
        Me.Num7Button2.TabIndex = 9
        Me.Num7Button2.TabStop = False
        Me.Num7Button2.Text = "7"
        Me.Num7Button2.UseVisualStyleBackColor = False
        '
        'StartUpDataSet1
        '
        Me.StartUpDataSet1.DataSetName = "StartUpDataSet"
        Me.StartUpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '権限有社員パスdtblTableAdapter1
        '
        Me.権限有社員パスdtblTableAdapter1.ClearBeforeFill = True
        '
        '社員権限画面dtblTableAdapter1
        '
        Me.社員権限画面dtblTableAdapter1.ClearBeforeFill = True
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 465)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LogInForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ログイン"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.StartUpDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StaffIDMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PasswordMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextClearButton As System.Windows.Forms.Button
    Friend WithEvents Num0Button As System.Windows.Forms.Button
    Friend WithEvents Num3Button As System.Windows.Forms.Button
    Friend WithEvents Num2Button As System.Windows.Forms.Button
    Friend WithEvents NUm1Button As System.Windows.Forms.Button
    Friend WithEvents Num6Button As System.Windows.Forms.Button
    Friend WithEvents Num5Button As System.Windows.Forms.Button
    Friend WithEvents Num4Button As System.Windows.Forms.Button
    Friend WithEvents Num9Button As System.Windows.Forms.Button
    Friend WithEvents Num8Button As System.Windows.Forms.Button
    Friend WithEvents Num7Button As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextClearButton2 As System.Windows.Forms.Button
    Friend WithEvents Num0Button2 As System.Windows.Forms.Button
    Friend WithEvents Num3Button2 As System.Windows.Forms.Button
    Friend WithEvents Num2Button2 As System.Windows.Forms.Button
    Friend WithEvents Num1Button2 As System.Windows.Forms.Button
    Friend WithEvents Num6Button2 As System.Windows.Forms.Button
    Friend WithEvents Num5Button2 As System.Windows.Forms.Button
    Friend WithEvents Num4Button2 As System.Windows.Forms.Button
    Friend WithEvents Num9Button2 As System.Windows.Forms.Button
    Friend WithEvents Num8Button2 As System.Windows.Forms.Button
    Friend WithEvents Num7Button2 As System.Windows.Forms.Button
    Friend WithEvents StartUpDataSet1 As FujiSysForFactory3.StartUpDataSet
    Friend WithEvents StaffNameLabel As System.Windows.Forms.Label
    Friend WithEvents 権限有社員パスdtblTableAdapter1 As FujiSysForFactory3.StartUpDataSetTableAdapters.権限有社員パスdtblTableAdapter
    Friend WithEvents 社員権限画面dtblTableAdapter1 As FujiSysForFactory3.StartUpDataSetTableAdapters.社員権限画面dtblTableAdapter

End Class
