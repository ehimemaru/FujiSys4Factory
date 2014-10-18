<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 外業詳細Form
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
        Dim 取引先ＩＤLabel As System.Windows.Forms.Label
        Dim 営業社員ＩＤLabel As System.Windows.Forms.Label
        Dim 工事番号Label As System.Windows.Forms.Label
        Dim 工事名Label As System.Windows.Forms.Label
        Dim 数量Label As System.Windows.Forms.Label
        Dim 工事範囲Label As System.Windows.Forms.Label
        Dim 生管社員ＩＤLabel As System.Windows.Forms.Label
        Dim 工程期間始Label As System.Windows.Forms.Label
        Dim 工程期間終Label As System.Windows.Forms.Label
        Dim 社内工数Label As System.Windows.Forms.Label
        Dim 工程備考１Label As System.Windows.Forms.Label
        Dim 外業客先名Label As System.Windows.Forms.Label
        Dim 外業先住所Label As System.Windows.Forms.Label
        Dim 外業先担当Label As System.Windows.Forms.Label
        Dim 外業連絡先Label As System.Windows.Forms.Label
        Dim 外業作業名称Label As System.Windows.Forms.Label
        Dim 工事責任者Label As System.Windows.Forms.Label
        Dim 工事作業者Label As System.Windows.Forms.Label
        Dim 工事内容Label As System.Windows.Forms.Label
        Dim 注意事項Label As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.ConstructionDataSet = New FujiSysForFactory3.ConstructionDataSet()
        Me.工事生管担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事生管担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter()
        Me.TableAdapterManager = New FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager()
        Me.受注営業担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.受注営業担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter()
        Me.外業詳細dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.外業詳細dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.外業詳細dtblTableAdapter()
        Me.工事取引先最新dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事取引先最新dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter()
        Me.取引先ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.営業社員ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.工事番号TextBox = New System.Windows.Forms.TextBox()
        Me.工事名TextBox = New System.Windows.Forms.TextBox()
        Me.数量TextBox = New System.Windows.Forms.TextBox()
        Me.工事範囲TextBox = New System.Windows.Forms.TextBox()
        Me.生管社員ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.工程期間始TextBox = New System.Windows.Forms.TextBox()
        Me.工程期間終TextBox = New System.Windows.Forms.TextBox()
        Me.社内工数TextBox = New System.Windows.Forms.TextBox()
        Me.工程備考１TextBox = New System.Windows.Forms.TextBox()
        Me.外業客先名TextBox = New System.Windows.Forms.TextBox()
        Me.外業先住所TextBox = New System.Windows.Forms.TextBox()
        Me.外業先担当TextBox = New System.Windows.Forms.TextBox()
        Me.外業連絡先TextBox = New System.Windows.Forms.TextBox()
        Me.外業作業名称TextBox = New System.Windows.Forms.TextBox()
        Me.工事責任者TextBox = New System.Windows.Forms.TextBox()
        Me.工事作業者TextBox = New System.Windows.Forms.TextBox()
        Me.工事内容TextBox = New System.Windows.Forms.TextBox()
        Me.注意事項TextBox = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        取引先ＩＤLabel = New System.Windows.Forms.Label()
        営業社員ＩＤLabel = New System.Windows.Forms.Label()
        工事番号Label = New System.Windows.Forms.Label()
        工事名Label = New System.Windows.Forms.Label()
        数量Label = New System.Windows.Forms.Label()
        工事範囲Label = New System.Windows.Forms.Label()
        生管社員ＩＤLabel = New System.Windows.Forms.Label()
        工程期間始Label = New System.Windows.Forms.Label()
        工程期間終Label = New System.Windows.Forms.Label()
        社内工数Label = New System.Windows.Forms.Label()
        工程備考１Label = New System.Windows.Forms.Label()
        外業客先名Label = New System.Windows.Forms.Label()
        外業先住所Label = New System.Windows.Forms.Label()
        外業先担当Label = New System.Windows.Forms.Label()
        外業連絡先Label = New System.Windows.Forms.Label()
        外業作業名称Label = New System.Windows.Forms.Label()
        工事責任者Label = New System.Windows.Forms.Label()
        工事作業者Label = New System.Windows.Forms.Label()
        工事内容Label = New System.Windows.Forms.Label()
        注意事項Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.ConstructionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.外業詳細dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事取引先最新dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '取引先ＩＤLabel
        '
        取引先ＩＤLabel.AutoSize = True
        取引先ＩＤLabel.Location = New System.Drawing.Point(45, 105)
        取引先ＩＤLabel.Name = "取引先ＩＤLabel"
        取引先ＩＤLabel.Size = New System.Drawing.Size(70, 19)
        取引先ＩＤLabel.TabIndex = 0
        取引先ＩＤLabel.Text = "取引先:"
        '
        '営業社員ＩＤLabel
        '
        営業社員ＩＤLabel.AutoSize = True
        営業社員ＩＤLabel.Location = New System.Drawing.Point(26, 138)
        営業社員ＩＤLabel.Name = "営業社員ＩＤLabel"
        営業社員ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        営業社員ＩＤLabel.TabIndex = 2
        営業社員ＩＤLabel.Text = "営業担当:"
        '
        '工事番号Label
        '
        工事番号Label.AutoSize = True
        工事番号Label.Location = New System.Drawing.Point(26, 41)
        工事番号Label.Name = "工事番号Label"
        工事番号Label.Size = New System.Drawing.Size(89, 19)
        工事番号Label.TabIndex = 4
        工事番号Label.Text = "工事番号:"
        '
        '工事名Label
        '
        工事名Label.AutoSize = True
        工事名Label.Location = New System.Drawing.Point(364, 41)
        工事名Label.Name = "工事名Label"
        工事名Label.Size = New System.Drawing.Size(70, 19)
        工事名Label.TabIndex = 6
        工事名Label.Text = "工事名:"
        '
        '数量Label
        '
        数量Label.AutoSize = True
        数量Label.Location = New System.Drawing.Point(64, 73)
        数量Label.Name = "数量Label"
        数量Label.Size = New System.Drawing.Size(51, 19)
        数量Label.TabIndex = 8
        数量Label.Text = "数量:"
        '
        '工事範囲Label
        '
        工事範囲Label.AutoSize = True
        工事範囲Label.Location = New System.Drawing.Point(345, 73)
        工事範囲Label.Name = "工事範囲Label"
        工事範囲Label.Size = New System.Drawing.Size(89, 19)
        工事範囲Label.TabIndex = 10
        工事範囲Label.Text = "工事範囲:"
        '
        '生管社員ＩＤLabel
        '
        生管社員ＩＤLabel.AutoSize = True
        生管社員ＩＤLabel.Location = New System.Drawing.Point(26, 171)
        生管社員ＩＤLabel.Name = "生管社員ＩＤLabel"
        生管社員ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        生管社員ＩＤLabel.TabIndex = 12
        生管社員ＩＤLabel.Text = "生管担当:"
        '
        '工程期間始Label
        '
        工程期間始Label.AutoSize = True
        工程期間始Label.Location = New System.Drawing.Point(45, 253)
        工程期間始Label.Name = "工程期間始Label"
        工程期間始Label.Size = New System.Drawing.Size(70, 19)
        工程期間始Label.TabIndex = 14
        工程期間始Label.Text = "外業始:"
        '
        '工程期間終Label
        '
        工程期間終Label.AutoSize = True
        工程期間終Label.Location = New System.Drawing.Point(45, 286)
        工程期間終Label.Name = "工程期間終Label"
        工程期間終Label.Size = New System.Drawing.Size(70, 19)
        工程期間終Label.TabIndex = 16
        工程期間終Label.Text = "外業終:"
        '
        '社内工数Label
        '
        社内工数Label.AutoSize = True
        社内工数Label.Location = New System.Drawing.Point(26, 318)
        社内工数Label.Name = "社内工数Label"
        社内工数Label.Size = New System.Drawing.Size(89, 19)
        社内工数Label.TabIndex = 18
        社内工数Label.Text = "予定工数:"
        '
        '工程備考１Label
        '
        工程備考１Label.AutoSize = True
        工程備考１Label.Location = New System.Drawing.Point(26, 350)
        工程備考１Label.Name = "工程備考１Label"
        工程備考１Label.Size = New System.Drawing.Size(89, 19)
        工程備考１Label.TabIndex = 20
        工程備考１Label.Text = "工程備考:"
        '
        '外業客先名Label
        '
        外業客先名Label.AutoSize = True
        外業客先名Label.Location = New System.Drawing.Point(390, 199)
        外業客先名Label.Name = "外業客先名Label"
        外業客先名Label.Size = New System.Drawing.Size(108, 19)
        外業客先名Label.TabIndex = 22
        外業客先名Label.Text = "外業客先名:"
        '
        '外業先住所Label
        '
        外業先住所Label.AutoSize = True
        外業先住所Label.Location = New System.Drawing.Point(390, 231)
        外業先住所Label.Name = "外業先住所Label"
        外業先住所Label.Size = New System.Drawing.Size(108, 19)
        外業先住所Label.TabIndex = 24
        外業先住所Label.Text = "外業先住所:"
        '
        '外業先担当Label
        '
        外業先担当Label.AutoSize = True
        外業先担当Label.Location = New System.Drawing.Point(873, 263)
        外業先担当Label.Name = "外業先担当Label"
        外業先担当Label.Size = New System.Drawing.Size(108, 19)
        外業先担当Label.TabIndex = 26
        外業先担当Label.Text = "外業先担当:"
        '
        '外業連絡先Label
        '
        外業連絡先Label.AutoSize = True
        外業連絡先Label.Location = New System.Drawing.Point(873, 295)
        外業連絡先Label.Name = "外業連絡先Label"
        外業連絡先Label.Size = New System.Drawing.Size(108, 19)
        外業連絡先Label.TabIndex = 28
        外業連絡先Label.Text = "外業連絡先:"
        '
        '外業作業名称Label
        '
        外業作業名称Label.AutoSize = True
        外業作業名称Label.Location = New System.Drawing.Point(371, 263)
        外業作業名称Label.Name = "外業作業名称Label"
        外業作業名称Label.Size = New System.Drawing.Size(127, 19)
        外業作業名称Label.TabIndex = 30
        外業作業名称Label.Text = "外業作業名称:"
        '
        '工事責任者Label
        '
        工事責任者Label.AutoSize = True
        工事責任者Label.Location = New System.Drawing.Point(390, 295)
        工事責任者Label.Name = "工事責任者Label"
        工事責任者Label.Size = New System.Drawing.Size(108, 19)
        工事責任者Label.TabIndex = 32
        工事責任者Label.Text = "工事責任者:"
        '
        '工事作業者Label
        '
        工事作業者Label.AutoSize = True
        工事作業者Label.Location = New System.Drawing.Point(390, 327)
        工事作業者Label.Name = "工事作業者Label"
        工事作業者Label.Size = New System.Drawing.Size(108, 19)
        工事作業者Label.TabIndex = 34
        工事作業者Label.Text = "工事作業者:"
        '
        '工事内容Label
        '
        工事内容Label.AutoSize = True
        工事内容Label.Location = New System.Drawing.Point(409, 360)
        工事内容Label.Name = "工事内容Label"
        工事内容Label.Size = New System.Drawing.Size(89, 19)
        工事内容Label.TabIndex = 36
        工事内容Label.Text = "工事内容:"
        '
        '注意事項Label
        '
        注意事項Label.AutoSize = True
        注意事項Label.Location = New System.Drawing.Point(409, 460)
        注意事項Label.Name = "注意事項Label"
        注意事項Label.Size = New System.Drawing.Size(89, 19)
        注意事項Label.TabIndex = 38
        注意事項Label.Text = "注意事項:"
        '
        'Label1
        '
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label1.Location = New System.Drawing.Point(12, 22)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(327, 200)
        Label1.TabIndex = 40
        '
        'Label2
        '
        Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label2.Location = New System.Drawing.Point(12, 221)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(327, 200)
        Label2.TabIndex = 41
        '
        'Label3
        '
        Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label3.Location = New System.Drawing.Point(338, 22)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(797, 154)
        Label3.TabIndex = 42
        '
        'Label4
        '
        Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label4.Location = New System.Drawing.Point(338, 175)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(904, 416)
        Label4.TabIndex = 43
        '
        'ConstructionDataSet
        '
        Me.ConstructionDataSet.DataSetName = "ConstructionDataSet"
        Me.ConstructionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '工事生管担当dtblBindingSource
        '
        Me.工事生管担当dtblBindingSource.DataMember = "工事生管担当dtbl"
        Me.工事生管担当dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        '工事生管担当dtblTableAdapter
        '
        Me.工事生管担当dtblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.工事工程dtblTableAdapter = Nothing
        Me.TableAdapterManager.工事工程予算dtblTableAdapter = Nothing
        Me.TableAdapterManager.工事製造範囲dtblTableAdapter = Nothing
        Me.TableAdapterManager.工事部署dtblTableAdapter = Nothing
        '
        '受注営業担当dtblBindingSource
        '
        Me.受注営業担当dtblBindingSource.DataMember = "受注営業担当dtbl"
        Me.受注営業担当dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        '受注営業担当dtblTableAdapter
        '
        Me.受注営業担当dtblTableAdapter.ClearBeforeFill = True
        '
        '外業詳細dtblBindingSource
        '
        Me.外業詳細dtblBindingSource.DataMember = "外業詳細dtbl"
        Me.外業詳細dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        '外業詳細dtblTableAdapter
        '
        Me.外業詳細dtblTableAdapter.ClearBeforeFill = True
        '
        '工事取引先最新dtblBindingSource
        '
        Me.工事取引先最新dtblBindingSource.DataMember = "工事取引先最新dtbl"
        Me.工事取引先最新dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        '工事取引先最新dtblTableAdapter
        '
        Me.工事取引先最新dtblTableAdapter.ClearBeforeFill = True
        '
        '取引先ＩＤComboBox
        '
        Me.取引先ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.取引先ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.外業詳細dtblBindingSource, "取引先ＩＤ", True))
        Me.取引先ＩＤComboBox.DataSource = Me.工事取引先最新dtblBindingSource
        Me.取引先ＩＤComboBox.DisplayMember = "取引先略称"
        Me.取引先ＩＤComboBox.Enabled = False
        Me.取引先ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.取引先ＩＤComboBox.FormattingEnabled = True
        Me.取引先ＩＤComboBox.Location = New System.Drawing.Point(121, 102)
        Me.取引先ＩＤComboBox.Name = "取引先ＩＤComboBox"
        Me.取引先ＩＤComboBox.Size = New System.Drawing.Size(201, 27)
        Me.取引先ＩＤComboBox.TabIndex = 1
        Me.取引先ＩＤComboBox.ValueMember = "取引先ＩＤ"
        '
        '営業社員ＩＤComboBox
        '
        Me.営業社員ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.営業社員ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.外業詳細dtblBindingSource, "営業社員ＩＤ", True))
        Me.営業社員ＩＤComboBox.DataSource = Me.受注営業担当dtblBindingSource
        Me.営業社員ＩＤComboBox.DisplayMember = "社員名"
        Me.営業社員ＩＤComboBox.Enabled = False
        Me.営業社員ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.営業社員ＩＤComboBox.FormattingEnabled = True
        Me.営業社員ＩＤComboBox.Location = New System.Drawing.Point(121, 135)
        Me.営業社員ＩＤComboBox.Name = "営業社員ＩＤComboBox"
        Me.営業社員ＩＤComboBox.Size = New System.Drawing.Size(170, 27)
        Me.営業社員ＩＤComboBox.TabIndex = 3
        Me.営業社員ＩＤComboBox.ValueMember = "社員ＩＤ"
        '
        '工事番号TextBox
        '
        Me.工事番号TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事番号TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事番号TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "工事番号", True))
        Me.工事番号TextBox.Location = New System.Drawing.Point(121, 38)
        Me.工事番号TextBox.Name = "工事番号TextBox"
        Me.工事番号TextBox.ReadOnly = True
        Me.工事番号TextBox.Size = New System.Drawing.Size(201, 26)
        Me.工事番号TextBox.TabIndex = 5
        '
        '工事名TextBox
        '
        Me.工事名TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事名TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "工事名", True))
        Me.工事名TextBox.Location = New System.Drawing.Point(440, 38)
        Me.工事名TextBox.Name = "工事名TextBox"
        Me.工事名TextBox.ReadOnly = True
        Me.工事名TextBox.Size = New System.Drawing.Size(617, 26)
        Me.工事名TextBox.TabIndex = 7
        '
        '数量TextBox
        '
        Me.数量TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.数量TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.数量TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "数量", True))
        Me.数量TextBox.Location = New System.Drawing.Point(121, 70)
        Me.数量TextBox.Name = "数量TextBox"
        Me.数量TextBox.ReadOnly = True
        Me.数量TextBox.Size = New System.Drawing.Size(201, 26)
        Me.数量TextBox.TabIndex = 9
        '
        '工事範囲TextBox
        '
        Me.工事範囲TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事範囲TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事範囲TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "工事範囲", True))
        Me.工事範囲TextBox.Location = New System.Drawing.Point(440, 70)
        Me.工事範囲TextBox.Multiline = True
        Me.工事範囲TextBox.Name = "工事範囲TextBox"
        Me.工事範囲TextBox.ReadOnly = True
        Me.工事範囲TextBox.Size = New System.Drawing.Size(690, 87)
        Me.工事範囲TextBox.TabIndex = 11
        '
        '生管社員ＩＤComboBox
        '
        Me.生管社員ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.生管社員ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.外業詳細dtblBindingSource, "生管社員ＩＤ", True))
        Me.生管社員ＩＤComboBox.DataSource = Me.工事生管担当dtblBindingSource
        Me.生管社員ＩＤComboBox.DisplayMember = "社員名"
        Me.生管社員ＩＤComboBox.Enabled = False
        Me.生管社員ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.生管社員ＩＤComboBox.FormattingEnabled = True
        Me.生管社員ＩＤComboBox.Location = New System.Drawing.Point(121, 168)
        Me.生管社員ＩＤComboBox.Name = "生管社員ＩＤComboBox"
        Me.生管社員ＩＤComboBox.Size = New System.Drawing.Size(170, 27)
        Me.生管社員ＩＤComboBox.TabIndex = 13
        Me.生管社員ＩＤComboBox.ValueMember = "社員ＩＤ"
        '
        '工程期間始TextBox
        '
        Me.工程期間始TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工程期間始TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工程期間始TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "工程期間始", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "M"))
        Me.工程期間始TextBox.Location = New System.Drawing.Point(121, 250)
        Me.工程期間始TextBox.Name = "工程期間始TextBox"
        Me.工程期間始TextBox.ReadOnly = True
        Me.工程期間始TextBox.Size = New System.Drawing.Size(135, 26)
        Me.工程期間始TextBox.TabIndex = 15
        Me.工程期間始TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '工程期間終TextBox
        '
        Me.工程期間終TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工程期間終TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工程期間終TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "工程期間終", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "M"))
        Me.工程期間終TextBox.Location = New System.Drawing.Point(121, 283)
        Me.工程期間終TextBox.Name = "工程期間終TextBox"
        Me.工程期間終TextBox.ReadOnly = True
        Me.工程期間終TextBox.Size = New System.Drawing.Size(135, 26)
        Me.工程期間終TextBox.TabIndex = 17
        Me.工程期間終TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '社内工数TextBox
        '
        Me.社内工数TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.社内工数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.社内工数TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "社内工数", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.社内工数TextBox.Location = New System.Drawing.Point(121, 315)
        Me.社内工数TextBox.Name = "社内工数TextBox"
        Me.社内工数TextBox.ReadOnly = True
        Me.社内工数TextBox.Size = New System.Drawing.Size(135, 26)
        Me.社内工数TextBox.TabIndex = 19
        Me.社内工数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '工程備考１TextBox
        '
        Me.工程備考１TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工程備考１TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工程備考１TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "工程備考１", True))
        Me.工程備考１TextBox.Location = New System.Drawing.Point(121, 347)
        Me.工程備考１TextBox.Name = "工程備考１TextBox"
        Me.工程備考１TextBox.ReadOnly = True
        Me.工程備考１TextBox.Size = New System.Drawing.Size(201, 26)
        Me.工程備考１TextBox.TabIndex = 21
        '
        '外業客先名TextBox
        '
        Me.外業客先名TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.外業客先名TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.外業客先名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "外業客先名", True))
        Me.外業客先名TextBox.Location = New System.Drawing.Point(504, 196)
        Me.外業客先名TextBox.Name = "外業客先名TextBox"
        Me.外業客先名TextBox.ReadOnly = True
        Me.外業客先名TextBox.Size = New System.Drawing.Size(717, 26)
        Me.外業客先名TextBox.TabIndex = 23
        Me.外業客先名TextBox.TabStop = False
        '
        '外業先住所TextBox
        '
        Me.外業先住所TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.外業先住所TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.外業先住所TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "外業先住所", True))
        Me.外業先住所TextBox.Location = New System.Drawing.Point(504, 228)
        Me.外業先住所TextBox.Name = "外業先住所TextBox"
        Me.外業先住所TextBox.ReadOnly = True
        Me.外業先住所TextBox.Size = New System.Drawing.Size(717, 26)
        Me.外業先住所TextBox.TabIndex = 25
        Me.外業先住所TextBox.TabStop = False
        '
        '外業先担当TextBox
        '
        Me.外業先担当TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.外業先担当TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.外業先担当TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "外業先担当", True))
        Me.外業先担当TextBox.Location = New System.Drawing.Point(987, 260)
        Me.外業先担当TextBox.Name = "外業先担当TextBox"
        Me.外業先担当TextBox.ReadOnly = True
        Me.外業先担当TextBox.Size = New System.Drawing.Size(234, 26)
        Me.外業先担当TextBox.TabIndex = 27
        Me.外業先担当TextBox.TabStop = False
        '
        '外業連絡先TextBox
        '
        Me.外業連絡先TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.外業連絡先TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.外業連絡先TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "外業連絡先", True))
        Me.外業連絡先TextBox.Location = New System.Drawing.Point(987, 292)
        Me.外業連絡先TextBox.Name = "外業連絡先TextBox"
        Me.外業連絡先TextBox.ReadOnly = True
        Me.外業連絡先TextBox.Size = New System.Drawing.Size(234, 26)
        Me.外業連絡先TextBox.TabIndex = 29
        Me.外業連絡先TextBox.TabStop = False
        '
        '外業作業名称TextBox
        '
        Me.外業作業名称TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.外業作業名称TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.外業作業名称TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "外業作業名称", True))
        Me.外業作業名称TextBox.Location = New System.Drawing.Point(504, 260)
        Me.外業作業名称TextBox.Name = "外業作業名称TextBox"
        Me.外業作業名称TextBox.ReadOnly = True
        Me.外業作業名称TextBox.Size = New System.Drawing.Size(358, 26)
        Me.外業作業名称TextBox.TabIndex = 31
        Me.外業作業名称TextBox.TabStop = False
        '
        '工事責任者TextBox
        '
        Me.工事責任者TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事責任者TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事責任者TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "工事責任者", True))
        Me.工事責任者TextBox.Location = New System.Drawing.Point(504, 292)
        Me.工事責任者TextBox.Name = "工事責任者TextBox"
        Me.工事責任者TextBox.ReadOnly = True
        Me.工事責任者TextBox.Size = New System.Drawing.Size(358, 26)
        Me.工事責任者TextBox.TabIndex = 33
        Me.工事責任者TextBox.TabStop = False
        '
        '工事作業者TextBox
        '
        Me.工事作業者TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事作業者TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事作業者TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "工事作業者", True))
        Me.工事作業者TextBox.Location = New System.Drawing.Point(504, 324)
        Me.工事作業者TextBox.Name = "工事作業者TextBox"
        Me.工事作業者TextBox.ReadOnly = True
        Me.工事作業者TextBox.Size = New System.Drawing.Size(717, 26)
        Me.工事作業者TextBox.TabIndex = 35
        Me.工事作業者TextBox.TabStop = False
        '
        '工事内容TextBox
        '
        Me.工事内容TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事内容TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事内容TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "工事内容", True))
        Me.工事内容TextBox.Location = New System.Drawing.Point(504, 357)
        Me.工事内容TextBox.Multiline = True
        Me.工事内容TextBox.Name = "工事内容TextBox"
        Me.工事内容TextBox.ReadOnly = True
        Me.工事内容TextBox.Size = New System.Drawing.Size(717, 94)
        Me.工事内容TextBox.TabIndex = 37
        Me.工事内容TextBox.TabStop = False
        '
        '注意事項TextBox
        '
        Me.注意事項TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.注意事項TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.注意事項TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.外業詳細dtblBindingSource, "注意事項", True))
        Me.注意事項TextBox.Location = New System.Drawing.Point(504, 457)
        Me.注意事項TextBox.Multiline = True
        Me.注意事項TextBox.Name = "注意事項TextBox"
        Me.注意事項TextBox.ReadOnly = True
        Me.注意事項TextBox.Size = New System.Drawing.Size(717, 122)
        Me.注意事項TextBox.TabIndex = 39
        Me.注意事項TextBox.TabStop = False
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(1141, 38)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(101, 91)
        Me.ButtonClose.TabIndex = 67
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        '外業詳細Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 612)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(注意事項Label)
        Me.Controls.Add(Me.注意事項TextBox)
        Me.Controls.Add(工事内容Label)
        Me.Controls.Add(Me.工事内容TextBox)
        Me.Controls.Add(工事作業者Label)
        Me.Controls.Add(Me.工事作業者TextBox)
        Me.Controls.Add(工事責任者Label)
        Me.Controls.Add(Me.工事責任者TextBox)
        Me.Controls.Add(外業作業名称Label)
        Me.Controls.Add(Me.外業作業名称TextBox)
        Me.Controls.Add(外業連絡先Label)
        Me.Controls.Add(Me.外業連絡先TextBox)
        Me.Controls.Add(外業先担当Label)
        Me.Controls.Add(Me.外業先担当TextBox)
        Me.Controls.Add(外業先住所Label)
        Me.Controls.Add(Me.外業先住所TextBox)
        Me.Controls.Add(外業客先名Label)
        Me.Controls.Add(Me.外業客先名TextBox)
        Me.Controls.Add(工程備考１Label)
        Me.Controls.Add(Me.工程備考１TextBox)
        Me.Controls.Add(社内工数Label)
        Me.Controls.Add(Me.社内工数TextBox)
        Me.Controls.Add(工程期間終Label)
        Me.Controls.Add(Me.工程期間終TextBox)
        Me.Controls.Add(工程期間始Label)
        Me.Controls.Add(Me.工程期間始TextBox)
        Me.Controls.Add(生管社員ＩＤLabel)
        Me.Controls.Add(Me.生管社員ＩＤComboBox)
        Me.Controls.Add(工事範囲Label)
        Me.Controls.Add(Me.工事範囲TextBox)
        Me.Controls.Add(数量Label)
        Me.Controls.Add(Me.数量TextBox)
        Me.Controls.Add(工事名Label)
        Me.Controls.Add(Me.工事名TextBox)
        Me.Controls.Add(工事番号Label)
        Me.Controls.Add(Me.工事番号TextBox)
        Me.Controls.Add(営業社員ＩＤLabel)
        Me.Controls.Add(Me.営業社員ＩＤComboBox)
        Me.Controls.Add(取引先ＩＤLabel)
        Me.Controls.Add(Me.取引先ＩＤComboBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label4)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "外業詳細Form"
        Me.Text = "外業詳細"
        CType(Me.ConstructionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.外業詳細dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事取引先最新dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConstructionDataSet As FujiSysForFactory3.ConstructionDataSet
    Friend WithEvents 工事生管担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事生管担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter
    Friend WithEvents TableAdapterManager As FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 受注営業担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 受注営業担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter
    Friend WithEvents 外業詳細dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 外業詳細dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.外業詳細dtblTableAdapter
    Friend WithEvents 工事取引先最新dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事取引先最新dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter
    Friend WithEvents 取引先ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 営業社員ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 工事番号TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事名TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 数量TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事範囲TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 生管社員ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 工程期間始TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工程期間終TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 社内工数TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工程備考１TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 外業客先名TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 外業先住所TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 外業先担当TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 外業連絡先TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 外業作業名称TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事責任者TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事作業者TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事内容TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 注意事項TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
End Class
