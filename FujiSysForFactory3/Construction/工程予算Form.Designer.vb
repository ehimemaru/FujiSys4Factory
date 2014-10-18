<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 工程予算Form
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
        Dim 工事番号Label As System.Windows.Forms.Label
        Dim 数量Label As System.Windows.Forms.Label
        Dim 工事名Label As System.Windows.Forms.Label
        Dim 工事範囲Label As System.Windows.Forms.Label
        Dim 営業社員ＩＤLabel As System.Windows.Forms.Label
        Dim 生管社員ＩＤLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.工事工程dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事工程dtblTableAdapter()
        Me.工事工程予算dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事工程予算dtblTableAdapter()
        Me.工事部署dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事部署dtblTableAdapter()
        Me.ConstructionDataSet1 = New FujiSysForFactory3.ConstructionDataSet()
        Me.工程BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工程予算BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.部署BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.生管社員ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.工事詳細簡易dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事生管担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.営業社員ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.受注営業担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.工事範囲TextBox = New System.Windows.Forms.TextBox()
        Me.工事名TextBox = New System.Windows.Forms.TextBox()
        Me.数量TextBox = New System.Windows.Forms.TextBox()
        Me.工事番号TextBox = New System.Windows.Forms.TextBox()
        Me.工程予算DataGridView = New System.Windows.Forms.DataGridView()
        Me.工事番号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.表示順DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程パスDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.工程ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.期間対象DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.予算対象DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.単価対象DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程期間始DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程期間終DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.部署ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.部署名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.単価金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.社内工数DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.社内金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.社外金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.更新日時DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程完了日DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.社内率DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.社外率DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程備考１DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程備考２DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程備考３DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.土曜含DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.日曜含DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.製作品詳細対象DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.設備コードDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.職種コードDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日毎社工DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程予算ＮＯDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事詳細簡易dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事詳細簡易dtblTableAdapter()
        Me.TableAdapterManager = New FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager()
        Me.受注営業担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter()
        Me.工事生管担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter()
        工事番号Label = New System.Windows.Forms.Label()
        数量Label = New System.Windows.Forms.Label()
        工事名Label = New System.Windows.Forms.Label()
        工事範囲Label = New System.Windows.Forms.Label()
        営業社員ＩＤLabel = New System.Windows.Forms.Label()
        生管社員ＩＤLabel = New System.Windows.Forms.Label()
        CType(Me.ConstructionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工程BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工程予算BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.部署BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.工事詳細簡易dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工程予算DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '工事番号Label
        '
        工事番号Label.AutoSize = True
        工事番号Label.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事番号Label.Location = New System.Drawing.Point(26, 14)
        工事番号Label.Name = "工事番号Label"
        工事番号Label.Size = New System.Drawing.Size(98, 21)
        工事番号Label.TabIndex = 0
        工事番号Label.Text = "工事番号:"
        '
        '数量Label
        '
        数量Label.AutoSize = True
        数量Label.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        数量Label.Location = New System.Drawing.Point(367, 14)
        数量Label.Name = "数量Label"
        数量Label.Size = New System.Drawing.Size(56, 21)
        数量Label.TabIndex = 2
        数量Label.Text = "数量:"
        '
        '工事名Label
        '
        工事名Label.AutoSize = True
        工事名Label.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事名Label.Location = New System.Drawing.Point(47, 47)
        工事名Label.Name = "工事名Label"
        工事名Label.Size = New System.Drawing.Size(77, 21)
        工事名Label.TabIndex = 4
        工事名Label.Text = "工事名:"
        '
        '工事範囲Label
        '
        工事範囲Label.AutoSize = True
        工事範囲Label.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事範囲Label.Location = New System.Drawing.Point(26, 80)
        工事範囲Label.Name = "工事範囲Label"
        工事範囲Label.Size = New System.Drawing.Size(98, 21)
        工事範囲Label.TabIndex = 6
        工事範囲Label.Text = "工事範囲:"
        '
        '営業社員ＩＤLabel
        '
        営業社員ＩＤLabel.AutoSize = True
        営業社員ＩＤLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        営業社員ＩＤLabel.Location = New System.Drawing.Point(997, 71)
        営業社員ＩＤLabel.Name = "営業社員ＩＤLabel"
        営業社員ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        営業社員ＩＤLabel.TabIndex = 66
        営業社員ＩＤLabel.Text = "営業担当:"
        '
        '生管社員ＩＤLabel
        '
        生管社員ＩＤLabel.AutoSize = True
        生管社員ＩＤLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        生管社員ＩＤLabel.Location = New System.Drawing.Point(997, 104)
        生管社員ＩＤLabel.Name = "生管社員ＩＤLabel"
        生管社員ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        生管社員ＩＤLabel.TabIndex = 67
        生管社員ＩＤLabel.Text = "生管担当:"
        '
        '工事工程dtblTableAdapter1
        '
        Me.工事工程dtblTableAdapter1.ClearBeforeFill = True
        '
        '工事工程予算dtblTableAdapter1
        '
        Me.工事工程予算dtblTableAdapter1.ClearBeforeFill = True
        '
        '工事部署dtblTableAdapter1
        '
        Me.工事部署dtblTableAdapter1.ClearBeforeFill = True
        '
        'ConstructionDataSet1
        '
        Me.ConstructionDataSet1.DataSetName = "ConstructionDataSet"
        Me.ConstructionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '工程BindingSource
        '
        Me.工程BindingSource.DataMember = "工事工程dtbl"
        Me.工程BindingSource.DataSource = Me.ConstructionDataSet1
        '
        '工程予算BindingSource
        '
        Me.工程予算BindingSource.DataMember = "工事工程予算dtbl"
        Me.工程予算BindingSource.DataSource = Me.ConstructionDataSet1
        '
        '部署BindingSource
        '
        Me.部署BindingSource.DataMember = "工事部署dtbl"
        Me.部署BindingSource.DataSource = Me.ConstructionDataSet1
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(生管社員ＩＤLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.生管社員ＩＤComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(営業社員ＩＤLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.営業社員ＩＤComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonClose)
        Me.SplitContainer1.Panel1.Controls.Add(工事範囲Label)
        Me.SplitContainer1.Panel1.Controls.Add(Me.工事範囲TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(工事名Label)
        Me.SplitContainer1.Panel1.Controls.Add(Me.工事名TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(数量Label)
        Me.SplitContainer1.Panel1.Controls.Add(Me.数量TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(工事番号Label)
        Me.SplitContainer1.Panel1.Controls.Add(Me.工事番号TextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.工程予算DataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1254, 662)
        Me.SplitContainer1.SplitterDistance = 132
        Me.SplitContainer1.TabIndex = 0
        '
        '生管社員ＩＤComboBox
        '
        Me.生管社員ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.生管社員ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.工事詳細簡易dtblBindingSource, "生管社員ＩＤ", True))
        Me.生管社員ＩＤComboBox.DataSource = Me.工事生管担当dtblBindingSource
        Me.生管社員ＩＤComboBox.DisplayMember = "社員名"
        Me.生管社員ＩＤComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.生管社員ＩＤComboBox.Enabled = False
        Me.生管社員ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.生管社員ＩＤComboBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.生管社員ＩＤComboBox.FormattingEnabled = True
        Me.生管社員ＩＤComboBox.Location = New System.Drawing.Point(1087, 101)
        Me.生管社員ＩＤComboBox.Name = "生管社員ＩＤComboBox"
        Me.生管社員ＩＤComboBox.Size = New System.Drawing.Size(155, 27)
        Me.生管社員ＩＤComboBox.TabIndex = 68
        Me.生管社員ＩＤComboBox.ValueMember = "社員ＩＤ"
        '
        '工事詳細簡易dtblBindingSource
        '
        Me.工事詳細簡易dtblBindingSource.DataMember = "工事詳細簡易dtbl"
        Me.工事詳細簡易dtblBindingSource.DataSource = Me.ConstructionDataSet1
        '
        '工事生管担当dtblBindingSource
        '
        Me.工事生管担当dtblBindingSource.DataMember = "工事生管担当dtbl"
        Me.工事生管担当dtblBindingSource.DataSource = Me.ConstructionDataSet1
        '
        '営業社員ＩＤComboBox
        '
        Me.営業社員ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.営業社員ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.工事詳細簡易dtblBindingSource, "営業社員ＩＤ", True))
        Me.営業社員ＩＤComboBox.DataSource = Me.受注営業担当dtblBindingSource
        Me.営業社員ＩＤComboBox.DisplayMember = "社員名"
        Me.営業社員ＩＤComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.営業社員ＩＤComboBox.Enabled = False
        Me.営業社員ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.営業社員ＩＤComboBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.営業社員ＩＤComboBox.FormattingEnabled = True
        Me.営業社員ＩＤComboBox.Location = New System.Drawing.Point(1087, 68)
        Me.営業社員ＩＤComboBox.Name = "営業社員ＩＤComboBox"
        Me.営業社員ＩＤComboBox.Size = New System.Drawing.Size(155, 27)
        Me.営業社員ＩＤComboBox.TabIndex = 67
        Me.営業社員ＩＤComboBox.ValueMember = "社員ＩＤ"
        '
        '受注営業担当dtblBindingSource
        '
        Me.受注営業担当dtblBindingSource.DataMember = "受注営業担当dtbl"
        Me.受注営業担当dtblBindingSource.DataSource = Me.ConstructionDataSet1
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(1030, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(212, 41)
        Me.ButtonClose.TabIndex = 66
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        '工事範囲TextBox
        '
        Me.工事範囲TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事範囲TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事範囲TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細簡易dtblBindingSource, "工事範囲", True))
        Me.工事範囲TextBox.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事範囲TextBox.Location = New System.Drawing.Point(130, 78)
        Me.工事範囲TextBox.Multiline = True
        Me.工事範囲TextBox.Name = "工事範囲TextBox"
        Me.工事範囲TextBox.ReadOnly = True
        Me.工事範囲TextBox.Size = New System.Drawing.Size(807, 50)
        Me.工事範囲TextBox.TabIndex = 7
        '
        '工事名TextBox
        '
        Me.工事名TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事名TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細簡易dtblBindingSource, "工事名", True))
        Me.工事名TextBox.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事名TextBox.Location = New System.Drawing.Point(130, 44)
        Me.工事名TextBox.Name = "工事名TextBox"
        Me.工事名TextBox.ReadOnly = True
        Me.工事名TextBox.Size = New System.Drawing.Size(807, 28)
        Me.工事名TextBox.TabIndex = 5
        '
        '数量TextBox
        '
        Me.数量TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.数量TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.数量TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細簡易dtblBindingSource, "数量", True))
        Me.数量TextBox.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.数量TextBox.Location = New System.Drawing.Point(429, 12)
        Me.数量TextBox.Name = "数量TextBox"
        Me.数量TextBox.ReadOnly = True
        Me.数量TextBox.Size = New System.Drawing.Size(508, 28)
        Me.数量TextBox.TabIndex = 3
        '
        '工事番号TextBox
        '
        Me.工事番号TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事番号TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事番号TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細簡易dtblBindingSource, "工事番号", True))
        Me.工事番号TextBox.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事番号TextBox.Location = New System.Drawing.Point(130, 12)
        Me.工事番号TextBox.Name = "工事番号TextBox"
        Me.工事番号TextBox.ReadOnly = True
        Me.工事番号TextBox.Size = New System.Drawing.Size(202, 28)
        Me.工事番号TextBox.TabIndex = 1
        '
        '工程予算DataGridView
        '
        Me.工程予算DataGridView.AllowUserToAddRows = False
        Me.工程予算DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.工程予算DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.工程予算DataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.工程予算DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.工程予算DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.工程予算DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.工事番号DataGridViewTextBoxColumn, Me.表示順DataGridViewTextBoxColumn, Me.工程パスDataGridViewTextBoxColumn, Me.工程ＩＤDataGridViewTextBoxColumn, Me.期間対象DataGridViewTextBoxColumn, Me.予算対象DataGridViewTextBoxColumn, Me.単価対象DataGridViewTextBoxColumn, Me.工程期間始DataGridViewTextBoxColumn, Me.工程期間終DataGridViewTextBoxColumn, Me.部署ＩＤDataGridViewTextBoxColumn, Me.部署名DataGridViewTextBoxColumn, Me.単価金額DataGridViewTextBoxColumn, Me.社内工数DataGridViewTextBoxColumn, Me.社内金額DataGridViewTextBoxColumn, Me.社外金額DataGridViewTextBoxColumn, Me.更新日時DataGridViewTextBoxColumn, Me.工程完了日DataGridViewTextBoxColumn, Me.社内率DataGridViewTextBoxColumn, Me.社外率DataGridViewTextBoxColumn, Me.工程備考１DataGridViewTextBoxColumn, Me.工程備考２DataGridViewTextBoxColumn, Me.工程備考３DataGridViewTextBoxColumn, Me.土曜含DataGridViewTextBoxColumn, Me.日曜含DataGridViewTextBoxColumn, Me.製作品詳細対象DataGridViewTextBoxColumn, Me.設備コードDataGridViewTextBoxColumn, Me.職種コードDataGridViewTextBoxColumn, Me.日毎社工DataGridViewTextBoxColumn, Me.工程予算ＮＯDataGridViewTextBoxColumn})
        Me.工程予算DataGridView.DataSource = Me.工程予算BindingSource
        Me.工程予算DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.工程予算DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.工程予算DataGridView.Name = "工程予算DataGridView"
        Me.工程予算DataGridView.ReadOnly = True
        Me.工程予算DataGridView.RowHeadersWidth = 35
        Me.工程予算DataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工程予算DataGridView.RowTemplate.Height = 35
        Me.工程予算DataGridView.Size = New System.Drawing.Size(1254, 526)
        Me.工程予算DataGridView.TabIndex = 0
        '
        '工事番号DataGridViewTextBoxColumn
        '
        Me.工事番号DataGridViewTextBoxColumn.DataPropertyName = "工事番号"
        Me.工事番号DataGridViewTextBoxColumn.HeaderText = "工事番号"
        Me.工事番号DataGridViewTextBoxColumn.Name = "工事番号DataGridViewTextBoxColumn"
        Me.工事番号DataGridViewTextBoxColumn.ReadOnly = True
        Me.工事番号DataGridViewTextBoxColumn.Visible = False
        '
        '表示順DataGridViewTextBoxColumn
        '
        Me.表示順DataGridViewTextBoxColumn.DataPropertyName = "表示順"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.表示順DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.表示順DataGridViewTextBoxColumn.HeaderText = "No"
        Me.表示順DataGridViewTextBoxColumn.Name = "表示順DataGridViewTextBoxColumn"
        Me.表示順DataGridViewTextBoxColumn.ReadOnly = True
        Me.表示順DataGridViewTextBoxColumn.Visible = False
        Me.表示順DataGridViewTextBoxColumn.Width = 50
        '
        '工程パスDataGridViewTextBoxColumn
        '
        Me.工程パスDataGridViewTextBoxColumn.DataPropertyName = "工程パス"
        Me.工程パスDataGridViewTextBoxColumn.DataSource = Me.工程BindingSource
        Me.工程パスDataGridViewTextBoxColumn.DisplayMember = "工程名"
        Me.工程パスDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.工程パスDataGridViewTextBoxColumn.HeaderText = "大工程"
        Me.工程パスDataGridViewTextBoxColumn.Name = "工程パスDataGridViewTextBoxColumn"
        Me.工程パスDataGridViewTextBoxColumn.ReadOnly = True
        Me.工程パスDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.工程パスDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.工程パスDataGridViewTextBoxColumn.ValueMember = "工程ＩＤ"
        Me.工程パスDataGridViewTextBoxColumn.Width = 130
        '
        '工程ＩＤDataGridViewTextBoxColumn
        '
        Me.工程ＩＤDataGridViewTextBoxColumn.DataPropertyName = "工程ＩＤ"
        Me.工程ＩＤDataGridViewTextBoxColumn.DataSource = Me.工程BindingSource
        Me.工程ＩＤDataGridViewTextBoxColumn.DisplayMember = "工程名"
        Me.工程ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.工程ＩＤDataGridViewTextBoxColumn.DividerWidth = 2
        Me.工程ＩＤDataGridViewTextBoxColumn.HeaderText = "詳細工程"
        Me.工程ＩＤDataGridViewTextBoxColumn.Name = "工程ＩＤDataGridViewTextBoxColumn"
        Me.工程ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.工程ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.工程ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.工程ＩＤDataGridViewTextBoxColumn.ValueMember = "工程ＩＤ"
        Me.工程ＩＤDataGridViewTextBoxColumn.Width = 130
        '
        '期間対象DataGridViewTextBoxColumn
        '
        Me.期間対象DataGridViewTextBoxColumn.DataPropertyName = "期間対象"
        Me.期間対象DataGridViewTextBoxColumn.HeaderText = "期間対象"
        Me.期間対象DataGridViewTextBoxColumn.Name = "期間対象DataGridViewTextBoxColumn"
        Me.期間対象DataGridViewTextBoxColumn.ReadOnly = True
        Me.期間対象DataGridViewTextBoxColumn.Visible = False
        '
        '予算対象DataGridViewTextBoxColumn
        '
        Me.予算対象DataGridViewTextBoxColumn.DataPropertyName = "予算対象"
        Me.予算対象DataGridViewTextBoxColumn.HeaderText = "予算対象"
        Me.予算対象DataGridViewTextBoxColumn.Name = "予算対象DataGridViewTextBoxColumn"
        Me.予算対象DataGridViewTextBoxColumn.ReadOnly = True
        Me.予算対象DataGridViewTextBoxColumn.Visible = False
        '
        '単価対象DataGridViewTextBoxColumn
        '
        Me.単価対象DataGridViewTextBoxColumn.DataPropertyName = "単価対象"
        Me.単価対象DataGridViewTextBoxColumn.HeaderText = "単価対象"
        Me.単価対象DataGridViewTextBoxColumn.Name = "単価対象DataGridViewTextBoxColumn"
        Me.単価対象DataGridViewTextBoxColumn.ReadOnly = True
        Me.単価対象DataGridViewTextBoxColumn.Visible = False
        '
        '工程期間始DataGridViewTextBoxColumn
        '
        Me.工程期間始DataGridViewTextBoxColumn.DataPropertyName = "工程期間始"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "MM/dd"
        Me.工程期間始DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.工程期間始DataGridViewTextBoxColumn.HeaderText = "期間始"
        Me.工程期間始DataGridViewTextBoxColumn.Name = "工程期間始DataGridViewTextBoxColumn"
        Me.工程期間始DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程期間始DataGridViewTextBoxColumn.Width = 80
        '
        '工程期間終DataGridViewTextBoxColumn
        '
        Me.工程期間終DataGridViewTextBoxColumn.DataPropertyName = "工程期間終"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "MM/dd"
        Me.工程期間終DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.工程期間終DataGridViewTextBoxColumn.DividerWidth = 2
        Me.工程期間終DataGridViewTextBoxColumn.HeaderText = "期間終"
        Me.工程期間終DataGridViewTextBoxColumn.Name = "工程期間終DataGridViewTextBoxColumn"
        Me.工程期間終DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程期間終DataGridViewTextBoxColumn.Width = 80
        '
        '部署ＩＤDataGridViewTextBoxColumn
        '
        Me.部署ＩＤDataGridViewTextBoxColumn.DataPropertyName = "部署ＩＤ"
        Me.部署ＩＤDataGridViewTextBoxColumn.DataSource = Me.部署BindingSource
        Me.部署ＩＤDataGridViewTextBoxColumn.DisplayMember = "部署名"
        Me.部署ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.部署ＩＤDataGridViewTextBoxColumn.HeaderText = "実行部署"
        Me.部署ＩＤDataGridViewTextBoxColumn.Name = "部署ＩＤDataGridViewTextBoxColumn"
        Me.部署ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.部署ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.部署ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.部署ＩＤDataGridViewTextBoxColumn.ValueMember = "部署ＩＤ"
        Me.部署ＩＤDataGridViewTextBoxColumn.Width = 120
        '
        '部署名DataGridViewTextBoxColumn
        '
        Me.部署名DataGridViewTextBoxColumn.DataPropertyName = "部署名"
        Me.部署名DataGridViewTextBoxColumn.HeaderText = "部署名"
        Me.部署名DataGridViewTextBoxColumn.Name = "部署名DataGridViewTextBoxColumn"
        Me.部署名DataGridViewTextBoxColumn.ReadOnly = True
        Me.部署名DataGridViewTextBoxColumn.Visible = False
        '
        '単価金額DataGridViewTextBoxColumn
        '
        Me.単価金額DataGridViewTextBoxColumn.DataPropertyName = "単価金額"
        Me.単価金額DataGridViewTextBoxColumn.HeaderText = "単価金額"
        Me.単価金額DataGridViewTextBoxColumn.Name = "単価金額DataGridViewTextBoxColumn"
        Me.単価金額DataGridViewTextBoxColumn.ReadOnly = True
        Me.単価金額DataGridViewTextBoxColumn.Visible = False
        '
        '社内工数DataGridViewTextBoxColumn
        '
        Me.社内工数DataGridViewTextBoxColumn.DataPropertyName = "社内工数"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.社内工数DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.社内工数DataGridViewTextBoxColumn.DividerWidth = 2
        Me.社内工数DataGridViewTextBoxColumn.HeaderText = "予算工数"
        Me.社内工数DataGridViewTextBoxColumn.Name = "社内工数DataGridViewTextBoxColumn"
        Me.社内工数DataGridViewTextBoxColumn.ReadOnly = True
        Me.社内工数DataGridViewTextBoxColumn.Width = 90
        '
        '社内金額DataGridViewTextBoxColumn
        '
        Me.社内金額DataGridViewTextBoxColumn.DataPropertyName = "社内金額"
        Me.社内金額DataGridViewTextBoxColumn.HeaderText = "社内金額"
        Me.社内金額DataGridViewTextBoxColumn.Name = "社内金額DataGridViewTextBoxColumn"
        Me.社内金額DataGridViewTextBoxColumn.ReadOnly = True
        Me.社内金額DataGridViewTextBoxColumn.Visible = False
        '
        '社外金額DataGridViewTextBoxColumn
        '
        Me.社外金額DataGridViewTextBoxColumn.DataPropertyName = "社外金額"
        Me.社外金額DataGridViewTextBoxColumn.HeaderText = "社外金額"
        Me.社外金額DataGridViewTextBoxColumn.Name = "社外金額DataGridViewTextBoxColumn"
        Me.社外金額DataGridViewTextBoxColumn.ReadOnly = True
        Me.社外金額DataGridViewTextBoxColumn.Visible = False
        '
        '更新日時DataGridViewTextBoxColumn
        '
        Me.更新日時DataGridViewTextBoxColumn.DataPropertyName = "更新日時"
        Me.更新日時DataGridViewTextBoxColumn.HeaderText = "更新日時"
        Me.更新日時DataGridViewTextBoxColumn.Name = "更新日時DataGridViewTextBoxColumn"
        Me.更新日時DataGridViewTextBoxColumn.ReadOnly = True
        Me.更新日時DataGridViewTextBoxColumn.Visible = False
        '
        '工程完了日DataGridViewTextBoxColumn
        '
        Me.工程完了日DataGridViewTextBoxColumn.DataPropertyName = "工程完了日"
        Me.工程完了日DataGridViewTextBoxColumn.HeaderText = "工程完了日"
        Me.工程完了日DataGridViewTextBoxColumn.Name = "工程完了日DataGridViewTextBoxColumn"
        Me.工程完了日DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程完了日DataGridViewTextBoxColumn.Visible = False
        '
        '社内率DataGridViewTextBoxColumn
        '
        Me.社内率DataGridViewTextBoxColumn.DataPropertyName = "社内率"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.社内率DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.社内率DataGridViewTextBoxColumn.HeaderText = "社内率"
        Me.社内率DataGridViewTextBoxColumn.Name = "社内率DataGridViewTextBoxColumn"
        Me.社内率DataGridViewTextBoxColumn.ReadOnly = True
        Me.社内率DataGridViewTextBoxColumn.Width = 70
        '
        '社外率DataGridViewTextBoxColumn
        '
        Me.社外率DataGridViewTextBoxColumn.DataPropertyName = "社外率"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.社外率DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.社外率DataGridViewTextBoxColumn.HeaderText = "社外率"
        Me.社外率DataGridViewTextBoxColumn.Name = "社外率DataGridViewTextBoxColumn"
        Me.社外率DataGridViewTextBoxColumn.ReadOnly = True
        Me.社外率DataGridViewTextBoxColumn.Width = 70
        '
        '工程備考１DataGridViewTextBoxColumn
        '
        Me.工程備考１DataGridViewTextBoxColumn.DataPropertyName = "工程備考１"
        Me.工程備考１DataGridViewTextBoxColumn.HeaderText = "工程備考"
        Me.工程備考１DataGridViewTextBoxColumn.Name = "工程備考１DataGridViewTextBoxColumn"
        Me.工程備考１DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程備考１DataGridViewTextBoxColumn.Width = 170
        '
        '工程備考２DataGridViewTextBoxColumn
        '
        Me.工程備考２DataGridViewTextBoxColumn.DataPropertyName = "工程備考２"
        Me.工程備考２DataGridViewTextBoxColumn.HeaderText = "工程備考２"
        Me.工程備考２DataGridViewTextBoxColumn.Name = "工程備考２DataGridViewTextBoxColumn"
        Me.工程備考２DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程備考２DataGridViewTextBoxColumn.Visible = False
        '
        '工程備考３DataGridViewTextBoxColumn
        '
        Me.工程備考３DataGridViewTextBoxColumn.DataPropertyName = "工程備考３"
        Me.工程備考３DataGridViewTextBoxColumn.HeaderText = "工程備考３"
        Me.工程備考３DataGridViewTextBoxColumn.Name = "工程備考３DataGridViewTextBoxColumn"
        Me.工程備考３DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程備考３DataGridViewTextBoxColumn.Visible = False
        '
        '土曜含DataGridViewTextBoxColumn
        '
        Me.土曜含DataGridViewTextBoxColumn.DataPropertyName = "土曜含"
        Me.土曜含DataGridViewTextBoxColumn.FalseValue = "0"
        Me.土曜含DataGridViewTextBoxColumn.HeaderText = "土曜含"
        Me.土曜含DataGridViewTextBoxColumn.Name = "土曜含DataGridViewTextBoxColumn"
        Me.土曜含DataGridViewTextBoxColumn.ReadOnly = True
        Me.土曜含DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.土曜含DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.土曜含DataGridViewTextBoxColumn.TrueValue = "1"
        Me.土曜含DataGridViewTextBoxColumn.Width = 50
        '
        '日曜含DataGridViewTextBoxColumn
        '
        Me.日曜含DataGridViewTextBoxColumn.DataPropertyName = "日曜含"
        Me.日曜含DataGridViewTextBoxColumn.FalseValue = "0"
        Me.日曜含DataGridViewTextBoxColumn.HeaderText = "日曜含"
        Me.日曜含DataGridViewTextBoxColumn.Name = "日曜含DataGridViewTextBoxColumn"
        Me.日曜含DataGridViewTextBoxColumn.ReadOnly = True
        Me.日曜含DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.日曜含DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.日曜含DataGridViewTextBoxColumn.TrueValue = "1"
        Me.日曜含DataGridViewTextBoxColumn.Width = 50
        '
        '製作品詳細対象DataGridViewTextBoxColumn
        '
        Me.製作品詳細対象DataGridViewTextBoxColumn.DataPropertyName = "製作品詳細対象"
        Me.製作品詳細対象DataGridViewTextBoxColumn.HeaderText = "製作品詳細対象"
        Me.製作品詳細対象DataGridViewTextBoxColumn.Name = "製作品詳細対象DataGridViewTextBoxColumn"
        Me.製作品詳細対象DataGridViewTextBoxColumn.ReadOnly = True
        Me.製作品詳細対象DataGridViewTextBoxColumn.Visible = False
        '
        '設備コードDataGridViewTextBoxColumn
        '
        Me.設備コードDataGridViewTextBoxColumn.DataPropertyName = "設備コード"
        Me.設備コードDataGridViewTextBoxColumn.HeaderText = "設備コード"
        Me.設備コードDataGridViewTextBoxColumn.Name = "設備コードDataGridViewTextBoxColumn"
        Me.設備コードDataGridViewTextBoxColumn.ReadOnly = True
        Me.設備コードDataGridViewTextBoxColumn.Visible = False
        '
        '職種コードDataGridViewTextBoxColumn
        '
        Me.職種コードDataGridViewTextBoxColumn.DataPropertyName = "職種コード"
        Me.職種コードDataGridViewTextBoxColumn.HeaderText = "職種コード"
        Me.職種コードDataGridViewTextBoxColumn.Name = "職種コードDataGridViewTextBoxColumn"
        Me.職種コードDataGridViewTextBoxColumn.ReadOnly = True
        Me.職種コードDataGridViewTextBoxColumn.Visible = False
        '
        '日毎社工DataGridViewTextBoxColumn
        '
        Me.日毎社工DataGridViewTextBoxColumn.DataPropertyName = "日毎社工"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.日毎社工DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.日毎社工DataGridViewTextBoxColumn.HeaderText = "時/日"
        Me.日毎社工DataGridViewTextBoxColumn.Name = "日毎社工DataGridViewTextBoxColumn"
        Me.日毎社工DataGridViewTextBoxColumn.ReadOnly = True
        Me.日毎社工DataGridViewTextBoxColumn.Width = 75
        '
        '工程予算ＮＯDataGridViewTextBoxColumn
        '
        Me.工程予算ＮＯDataGridViewTextBoxColumn.DataPropertyName = "工程予算ＮＯ"
        Me.工程予算ＮＯDataGridViewTextBoxColumn.HeaderText = "工程予算ＮＯ"
        Me.工程予算ＮＯDataGridViewTextBoxColumn.Name = "工程予算ＮＯDataGridViewTextBoxColumn"
        Me.工程予算ＮＯDataGridViewTextBoxColumn.ReadOnly = True
        Me.工程予算ＮＯDataGridViewTextBoxColumn.Visible = False
        '
        '工事詳細簡易dtblTableAdapter1
        '
        Me.工事詳細簡易dtblTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.工事工程dtblTableAdapter = Me.工事工程dtblTableAdapter1
        Me.TableAdapterManager.工事工程予算dtblTableAdapter = Me.工事工程予算dtblTableAdapter1
        Me.TableAdapterManager.工事製造範囲dtblTableAdapter = Nothing
        Me.TableAdapterManager.工事部署dtblTableAdapter = Me.工事部署dtblTableAdapter1
        '
        '受注営業担当dtblTableAdapter
        '
        Me.受注営業担当dtblTableAdapter.ClearBeforeFill = True
        '
        '工事生管担当dtblTableAdapter
        '
        Me.工事生管担当dtblTableAdapter.ClearBeforeFill = True
        '
        '工程予算Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "工程予算Form"
        Me.Text = "工程予算"
        CType(Me.ConstructionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工程BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工程予算BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.部署BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.工事詳細簡易dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工程予算DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 工事工程dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事工程dtblTableAdapter
    Friend WithEvents 工事工程予算dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事工程予算dtblTableAdapter
    Friend WithEvents 工事部署dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事部署dtblTableAdapter
    Friend WithEvents ConstructionDataSet1 As FujiSysForFactory3.ConstructionDataSet
    Friend WithEvents 工程BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工程予算BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 部署BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents 工程予算DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 工事番号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 表示順DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程パスDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 工程ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 期間対象DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 予算対象DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 単価対象DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程期間始DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程期間終DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 部署ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 部署名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 単価金額DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 社内工数DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 社内金額DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 社外金額DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 更新日時DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程完了日DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 社内率DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 社外率DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程備考１DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程備考２DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程備考３DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 土曜含DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents 日曜含DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents 製作品詳細対象DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 設備コードDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 職種コードDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 日毎社工DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程予算ＮＯDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事範囲TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事詳細簡易dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事名TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 数量TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事番号TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事詳細簡易dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事詳細簡易dtblTableAdapter
    Friend WithEvents TableAdapterManager As FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents 生管社員ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 営業社員ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 受注営業担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 受注営業担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter
    Friend WithEvents 工事生管担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事生管担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter
End Class
