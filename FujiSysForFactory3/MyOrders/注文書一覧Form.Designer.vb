<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 注文書一覧Form
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonRemoveFilter = New System.Windows.Forms.Button()
        Me.入荷状態ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.注文者ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.注文先ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.図面番号ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.他項目CheckBox = New System.Windows.Forms.CheckBox()
        Me.購入品項目CheckBox = New System.Windows.Forms.CheckBox()
        Me.InputedDateAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.レンタル項目CheckBox = New System.Windows.Forms.CheckBox()
        Me.InputedDateBMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.社外運搬項目CheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.外注項目CheckBox = New System.Windows.Forms.CheckBox()
        Me.ConstructionNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.出荷項目CheckBox = New System.Windows.Forms.CheckBox()
        Me.ButtonOpenDateDialog = New System.Windows.Forms.Button()
        Me.材料項目CheckBox = New System.Windows.Forms.CheckBox()
        Me.ButtonOpenConstDialog = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.注文書一覧dtblDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.注文書一覧dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyOrdersDataSet = New FujiSysForFactory3.MyOrdersDataSet()
        Me.注文書一覧dtblTableAdapter = New FujiSysForFactory3.MyOrdersDataSetTableAdapters.注文書一覧dtblTableAdapter()
        Me.TableAdapterManager = New FujiSysForFactory3.MyOrdersDataSetTableAdapters.TableAdapterManager()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.注文書一覧dtblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.注文書一覧dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyOrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.他項目CheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.購入品項目CheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateAMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.レンタル項目CheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateBMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.社外運搬項目CheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.外注項目CheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConstructionNoMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.出荷項目CheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenDateDialog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.材料項目CheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenConstDialog)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.VScrollBar1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.注文書一覧dtblDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1254, 662)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 0
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(1070, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(98, 65)
        Me.ButtonClose.TabIndex = 77
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ButtonRemoveFilter)
        Me.Panel1.Controls.Add(Me.入荷状態ComboBox)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.注文者ComboBox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.注文先ComboBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.図面番号ComboBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1181, 64)
        Me.Panel1.TabIndex = 76
        '
        'ButtonRemoveFilter
        '
        Me.ButtonRemoveFilter.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonRemoveFilter.FlatAppearance.BorderSize = 2
        Me.ButtonRemoveFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRemoveFilter.Location = New System.Drawing.Point(1066, 9)
        Me.ButtonRemoveFilter.Name = "ButtonRemoveFilter"
        Me.ButtonRemoveFilter.Size = New System.Drawing.Size(98, 43)
        Me.ButtonRemoveFilter.TabIndex = 78
        Me.ButtonRemoveFilter.Text = "絞込解除"
        Me.ButtonRemoveFilter.UseVisualStyleBackColor = False
        '
        '入荷状態ComboBox
        '
        Me.入荷状態ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.入荷状態ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.入荷状態ComboBox.FormattingEnabled = True
        Me.入荷状態ComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.入荷状態ComboBox.Items.AddRange(New Object() {"全て", "入荷済", "未入荷"})
        Me.入荷状態ComboBox.Location = New System.Drawing.Point(909, 31)
        Me.入荷状態ComboBox.Name = "入荷状態ComboBox"
        Me.入荷状態ComboBox.Size = New System.Drawing.Size(137, 27)
        Me.入荷状態ComboBox.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(905, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "入荷状態"
        '
        '注文者ComboBox
        '
        Me.注文者ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.注文者ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.注文者ComboBox.FormattingEnabled = True
        Me.注文者ComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.注文者ComboBox.Location = New System.Drawing.Point(673, 31)
        Me.注文者ComboBox.Name = "注文者ComboBox"
        Me.注文者ComboBox.Size = New System.Drawing.Size(230, 27)
        Me.注文者ComboBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(669, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "注文者"
        '
        '注文先ComboBox
        '
        Me.注文先ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.注文先ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.注文先ComboBox.FormattingEnabled = True
        Me.注文先ComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.注文先ComboBox.Location = New System.Drawing.Point(338, 31)
        Me.注文先ComboBox.Name = "注文先ComboBox"
        Me.注文先ComboBox.Size = New System.Drawing.Size(329, 27)
        Me.注文先ComboBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "注文先"
        '
        '図面番号ComboBox
        '
        Me.図面番号ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.図面番号ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.図面番号ComboBox.FormattingEnabled = True
        Me.図面番号ComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.図面番号ComboBox.Location = New System.Drawing.Point(9, 31)
        Me.図面番号ComboBox.Name = "図面番号ComboBox"
        Me.図面番号ComboBox.Size = New System.Drawing.Size(301, 27)
        Me.図面番号ComboBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "図面番号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(563, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "大項目："
        '
        '他項目CheckBox
        '
        Me.他項目CheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.他項目CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.他項目CheckBox.FlatAppearance.BorderSize = 2
        Me.他項目CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.他項目CheckBox.Location = New System.Drawing.Point(912, 47)
        Me.他項目CheckBox.Name = "他項目CheckBox"
        Me.他項目CheckBox.Size = New System.Drawing.Size(112, 30)
        Me.他項目CheckBox.TabIndex = 74
        Me.他項目CheckBox.Text = "他"
        Me.他項目CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.他項目CheckBox.UseVisualStyleBackColor = True
        '
        '購入品項目CheckBox
        '
        Me.購入品項目CheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.購入品項目CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.購入品項目CheckBox.FlatAppearance.BorderSize = 2
        Me.購入品項目CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.購入品項目CheckBox.Location = New System.Drawing.Point(676, 12)
        Me.購入品項目CheckBox.Name = "購入品項目CheckBox"
        Me.購入品項目CheckBox.Size = New System.Drawing.Size(112, 30)
        Me.購入品項目CheckBox.TabIndex = 68
        Me.購入品項目CheckBox.Text = "購入品"
        Me.購入品項目CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.購入品項目CheckBox.UseVisualStyleBackColor = True
        '
        'InputedDateAMaskedTextBox
        '
        Me.InputedDateAMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateAMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateAMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateAMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateAMaskedTextBox.Location = New System.Drawing.Point(149, 49)
        Me.InputedDateAMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateAMaskedTextBox.Name = "InputedDateAMaskedTextBox"
        Me.InputedDateAMaskedTextBox.ReadOnly = True
        Me.InputedDateAMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.InputedDateAMaskedTextBox.TabIndex = 63
        Me.InputedDateAMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'レンタル項目CheckBox
        '
        Me.レンタル項目CheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.レンタル項目CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.レンタル項目CheckBox.FlatAppearance.BorderSize = 2
        Me.レンタル項目CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.レンタル項目CheckBox.Location = New System.Drawing.Point(794, 47)
        Me.レンタル項目CheckBox.Name = "レンタル項目CheckBox"
        Me.レンタル項目CheckBox.Size = New System.Drawing.Size(112, 30)
        Me.レンタル項目CheckBox.TabIndex = 73
        Me.レンタル項目CheckBox.Text = "レンタル"
        Me.レンタル項目CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.レンタル項目CheckBox.UseVisualStyleBackColor = True
        '
        'InputedDateBMaskedTextBox
        '
        Me.InputedDateBMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateBMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateBMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateBMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateBMaskedTextBox.Location = New System.Drawing.Point(341, 49)
        Me.InputedDateBMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateBMaskedTextBox.Name = "InputedDateBMaskedTextBox"
        Me.InputedDateBMaskedTextBox.ReadOnly = True
        Me.InputedDateBMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.InputedDateBMaskedTextBox.TabIndex = 65
        Me.InputedDateBMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateBMaskedTextBox.ValidatingType = GetType(Date)
        '
        '社外運搬項目CheckBox
        '
        Me.社外運搬項目CheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.社外運搬項目CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.社外運搬項目CheckBox.FlatAppearance.BorderSize = 2
        Me.社外運搬項目CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.社外運搬項目CheckBox.Location = New System.Drawing.Point(794, 12)
        Me.社外運搬項目CheckBox.Name = "社外運搬項目CheckBox"
        Me.社外運搬項目CheckBox.Size = New System.Drawing.Size(112, 30)
        Me.社外運搬項目CheckBox.TabIndex = 69
        Me.社外運搬項目CheckBox.Text = "社外運搬"
        Me.社外運搬項目CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.社外運搬項目CheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 19)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "～"
        '
        '外注項目CheckBox
        '
        Me.外注項目CheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.外注項目CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.外注項目CheckBox.FlatAppearance.BorderSize = 2
        Me.外注項目CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.外注項目CheckBox.Location = New System.Drawing.Point(676, 47)
        Me.外注項目CheckBox.Name = "外注項目CheckBox"
        Me.外注項目CheckBox.Size = New System.Drawing.Size(112, 30)
        Me.外注項目CheckBox.TabIndex = 72
        Me.外注項目CheckBox.Text = "外注"
        Me.外注項目CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.外注項目CheckBox.UseVisualStyleBackColor = True
        '
        'ConstructionNoMaskedTextBox
        '
        Me.ConstructionNoMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ConstructionNoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConstructionNoMaskedTextBox.Enabled = False
        Me.ConstructionNoMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ConstructionNoMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ConstructionNoMaskedTextBox.Location = New System.Drawing.Point(149, 12)
        Me.ConstructionNoMaskedTextBox.Mask = ">00A-&000-00"
        Me.ConstructionNoMaskedTextBox.Name = "ConstructionNoMaskedTextBox"
        Me.ConstructionNoMaskedTextBox.ReadOnly = True
        Me.ConstructionNoMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.ConstructionNoMaskedTextBox.TabIndex = 61
        Me.ConstructionNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '出荷項目CheckBox
        '
        Me.出荷項目CheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.出荷項目CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.出荷項目CheckBox.FlatAppearance.BorderSize = 2
        Me.出荷項目CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.出荷項目CheckBox.Location = New System.Drawing.Point(912, 12)
        Me.出荷項目CheckBox.Name = "出荷項目CheckBox"
        Me.出荷項目CheckBox.Size = New System.Drawing.Size(112, 30)
        Me.出荷項目CheckBox.TabIndex = 70
        Me.出荷項目CheckBox.Text = "出荷"
        Me.出荷項目CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.出荷項目CheckBox.UseVisualStyleBackColor = True
        '
        'ButtonOpenDateDialog
        '
        Me.ButtonOpenDateDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenDateDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenDateDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenDateDialog.Location = New System.Drawing.Point(12, 49)
        Me.ButtonOpenDateDialog.Name = "ButtonOpenDateDialog"
        Me.ButtonOpenDateDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenDateDialog.TabIndex = 64
        Me.ButtonOpenDateDialog.Text = "納期："
        Me.ButtonOpenDateDialog.UseVisualStyleBackColor = False
        '
        '材料項目CheckBox
        '
        Me.材料項目CheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.材料項目CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.材料項目CheckBox.FlatAppearance.BorderSize = 2
        Me.材料項目CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.材料項目CheckBox.Location = New System.Drawing.Point(558, 47)
        Me.材料項目CheckBox.Name = "材料項目CheckBox"
        Me.材料項目CheckBox.Size = New System.Drawing.Size(112, 30)
        Me.材料項目CheckBox.TabIndex = 71
        Me.材料項目CheckBox.Text = "材料"
        Me.材料項目CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.材料項目CheckBox.UseVisualStyleBackColor = True
        '
        'ButtonOpenConstDialog
        '
        Me.ButtonOpenConstDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenConstDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstDialog.Location = New System.Drawing.Point(12, 12)
        Me.ButtonOpenConstDialog.Name = "ButtonOpenConstDialog"
        Me.ButtonOpenConstDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenConstDialog.TabIndex = 62
        Me.ButtonOpenConstDialog.Text = "工事番号："
        Me.ButtonOpenConstDialog.UseVisualStyleBackColor = False
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(1219, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(35, 506)
        Me.VScrollBar1.TabIndex = 1
        '
        '注文書一覧dtblDataGridView
        '
        Me.注文書一覧dtblDataGridView.AllowUserToAddRows = False
        Me.注文書一覧dtblDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.注文書一覧dtblDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.注文書一覧dtblDataGridView.AutoGenerateColumns = False
        Me.注文書一覧dtblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.注文書一覧dtblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn20})
        Me.注文書一覧dtblDataGridView.DataSource = Me.注文書一覧dtblBindingSource
        Me.注文書一覧dtblDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.注文書一覧dtblDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.注文書一覧dtblDataGridView.Name = "注文書一覧dtblDataGridView"
        Me.注文書一覧dtblDataGridView.ReadOnly = True
        Me.注文書一覧dtblDataGridView.RowHeadersWidth = 18
        Me.注文書一覧dtblDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.注文書一覧dtblDataGridView.RowTemplate.Height = 42
        Me.注文書一覧dtblDataGridView.Size = New System.Drawing.Size(1254, 506)
        Me.注文書一覧dtblDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "部品材料名称"
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "名称"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "仕様型式"
        Me.DataGridViewTextBoxColumn5.DividerWidth = 2
        Me.DataGridViewTextBoxColumn5.Frozen = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "仕様型式"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "注文納期"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "MM/dd"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "納期"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "入荷日"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "MM/dd"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn14.DividerWidth = 2
        Me.DataGridViewTextBoxColumn14.Frozen = True
        Me.DataGridViewTextBoxColumn14.HeaderText = "入荷日"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 70
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "数量単位"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn26.HeaderText = "注文数量"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 80
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "入荷数量"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn15.DividerWidth = 2
        Me.DataGridViewTextBoxColumn15.HeaderText = "入荷数量"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "工事番号"
        Me.DataGridViewTextBoxColumn8.HeaderText = "工事番号"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "図番品番"
        Me.DataGridViewTextBoxColumn27.HeaderText = "図番品番"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "取引先略称"
        Me.DataGridViewTextBoxColumn2.HeaderText = "注文先"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "メーカ材質"
        Me.DataGridViewTextBoxColumn25.HeaderText = "メーカ<材質>"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "注文項目名"
        Me.DataGridViewTextBoxColumn17.HeaderText = "注文項目"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "注文番号"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.HeaderText = "注文番号"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "注文者"
        Me.DataGridViewTextBoxColumn19.HeaderText = "注文者"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "要求者"
        Me.DataGridViewTextBoxColumn21.HeaderText = "要求者"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "納入場所名"
        Me.DataGridViewTextBoxColumn22.HeaderText = "納入場所名"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "荷渡先"
        Me.DataGridViewTextBoxColumn23.HeaderText = "荷渡先"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "注文日"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "MM/dd"
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn24.HeaderText = "注文日"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "注文単位"
        Me.DataGridViewTextBoxColumn7.HeaderText = "注文単位"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "注文数量"
        Me.DataGridViewTextBoxColumn6.HeaderText = "注文数量"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "図面番号"
        Me.DataGridViewTextBoxColumn9.HeaderText = "図面番号"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "改正番号"
        Me.DataGridViewTextBoxColumn10.HeaderText = "改正番号"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "部品番号"
        Me.DataGridViewTextBoxColumn11.HeaderText = "部品番号"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "メーカ"
        Me.DataGridViewTextBoxColumn12.HeaderText = "メーカ"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "材質"
        Me.DataGridViewTextBoxColumn13.HeaderText = "材質"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "注文項目ＩＤ"
        Me.DataGridViewTextBoxColumn16.HeaderText = "注文項目ＩＤ"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "注文者ＩＤ"
        Me.DataGridViewTextBoxColumn18.HeaderText = "注文者ＩＤ"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "要求者ＩＤ"
        Me.DataGridViewTextBoxColumn20.HeaderText = "要求者ＩＤ"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        '注文書一覧dtblBindingSource
        '
        Me.注文書一覧dtblBindingSource.DataMember = "注文書一覧dtbl"
        Me.注文書一覧dtblBindingSource.DataSource = Me.MyOrdersDataSet
        '
        'MyOrdersDataSet
        '
        Me.MyOrdersDataSet.DataSetName = "MyOrdersDataSet"
        Me.MyOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '注文書一覧dtblTableAdapter
        '
        Me.注文書一覧dtblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = FujiSysForFactory3.MyOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        '注文書一覧Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "注文書一覧Form"
        Me.Text = "注文書一覧"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.注文書一覧dtblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.注文書一覧dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyOrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents InputedDateAMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents InputedDateBMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ConstructionNoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonOpenDateDialog As System.Windows.Forms.Button
    Friend WithEvents ButtonOpenConstDialog As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents 他項目CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 購入品項目CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents レンタル項目CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 社外運搬項目CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 外注項目CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 出荷項目CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 材料項目CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents 入荷状態ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents 注文者ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents 注文先ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents 図面番号ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MyOrdersDataSet As FujiSysForFactory3.MyOrdersDataSet
    Friend WithEvents 注文書一覧dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 注文書一覧dtblTableAdapter As FujiSysForFactory3.MyOrdersDataSetTableAdapters.注文書一覧dtblTableAdapter
    Friend WithEvents TableAdapterManager As FujiSysForFactory3.MyOrdersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 注文書一覧dtblDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonRemoveFilter As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
End Class
