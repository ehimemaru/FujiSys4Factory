<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 工事別予算消費Form
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
        Dim 生管社員ＩＤLabel As System.Windows.Forms.Label
        Dim 営業社員ＩＤLabel As System.Windows.Forms.Label
        Dim 工事範囲Label As System.Windows.Forms.Label
        Dim 工事名Label As System.Windows.Forms.Label
        Dim 数量Label As System.Windows.Forms.Label
        Dim 工事番号Label As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 0.0R)
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.生管社員ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.工事詳細簡易dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConstructionDataSet = New FujiSysForFactory3.ConstructionDataSet()
        Me.工事生管担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.営業社員ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.受注営業担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.工事範囲TextBox = New System.Windows.Forms.TextBox()
        Me.工事名TextBox = New System.Windows.Forms.TextBox()
        Me.数量TextBox = New System.Windows.Forms.TextBox()
        Me.工事番号TextBox = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.合計DataGridView = New System.Windows.Forms.DataGridView()
        Me.項目名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.値DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.工事別予算消費グラフBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConstructionWorkAndDateDataSet = New FujiSysForFactory3.ConstructionWorkAndDateDataSet()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.工事別実績予定日付一覧表示用DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.工事部署dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事別実績予定日付一覧表示用dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.工事別予算消費工程別dtblDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.工場工程dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事別予算消費工程別dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事詳細簡易dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事詳細簡易dtblTableAdapter()
        Me.TableAdapterManager = New FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager()
        Me.工事部署dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事部署dtblTableAdapter()
        Me.工事生管担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter()
        Me.受注営業担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter()
        Me.工事別実績予定日付一覧dtblTableAdapter1 = New FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.工事別実績予定日付一覧dtblTableAdapter()
        Me.工事別予算消費工程別dtblTableAdapter = New FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.工事別予算消費工程別dtblTableAdapter()
        Me.TableAdapterManager1 = New FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.TableAdapterManager()
        Me.工場工程dtblTableAdapter = New FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.工場工程dtblTableAdapter()
        生管社員ＩＤLabel = New System.Windows.Forms.Label()
        営業社員ＩＤLabel = New System.Windows.Forms.Label()
        工事範囲Label = New System.Windows.Forms.Label()
        工事名Label = New System.Windows.Forms.Label()
        数量Label = New System.Windows.Forms.Label()
        工事番号Label = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.工事詳細簡易dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstructionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.合計DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事別予算消費グラフBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstructionWorkAndDateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.工事別実績予定日付一覧表示用DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事部署dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事別実績予定日付一覧表示用dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.工事別予算消費工程別dtblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工場工程dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事別予算消費工程別dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '生管社員ＩＤLabel
        '
        生管社員ＩＤLabel.AutoSize = True
        生管社員ＩＤLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        生管社員ＩＤLabel.Location = New System.Drawing.Point(989, 104)
        生管社員ＩＤLabel.Name = "生管社員ＩＤLabel"
        生管社員ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        生管社員ＩＤLabel.TabIndex = 79
        生管社員ＩＤLabel.Text = "生管担当:"
        '
        '営業社員ＩＤLabel
        '
        営業社員ＩＤLabel.AutoSize = True
        営業社員ＩＤLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        営業社員ＩＤLabel.Location = New System.Drawing.Point(989, 71)
        営業社員ＩＤLabel.Name = "営業社員ＩＤLabel"
        営業社員ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        営業社員ＩＤLabel.TabIndex = 77
        営業社員ＩＤLabel.Text = "営業担当:"
        '
        '工事範囲Label
        '
        工事範囲Label.AutoSize = True
        工事範囲Label.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事範囲Label.Location = New System.Drawing.Point(18, 80)
        工事範囲Label.Name = "工事範囲Label"
        工事範囲Label.Size = New System.Drawing.Size(98, 21)
        工事範囲Label.TabIndex = 75
        工事範囲Label.Text = "工事範囲:"
        '
        '工事名Label
        '
        工事名Label.AutoSize = True
        工事名Label.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事名Label.Location = New System.Drawing.Point(39, 47)
        工事名Label.Name = "工事名Label"
        工事名Label.Size = New System.Drawing.Size(77, 21)
        工事名Label.TabIndex = 73
        工事名Label.Text = "工事名:"
        '
        '数量Label
        '
        数量Label.AutoSize = True
        数量Label.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        数量Label.Location = New System.Drawing.Point(359, 14)
        数量Label.Name = "数量Label"
        数量Label.Size = New System.Drawing.Size(56, 21)
        数量Label.TabIndex = 71
        数量Label.Text = "数量:"
        '
        '工事番号Label
        '
        工事番号Label.AutoSize = True
        工事番号Label.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事番号Label.Location = New System.Drawing.Point(18, 14)
        工事番号Label.Name = "工事番号Label"
        工事番号Label.Size = New System.Drawing.Size(98, 21)
        工事番号Label.TabIndex = 69
        工事番号Label.Text = "工事番号:"
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1254, 662)
        Me.SplitContainer1.SplitterDistance = 130
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
        Me.生管社員ＩＤComboBox.Location = New System.Drawing.Point(1079, 101)
        Me.生管社員ＩＤComboBox.Name = "生管社員ＩＤComboBox"
        Me.生管社員ＩＤComboBox.Size = New System.Drawing.Size(155, 27)
        Me.生管社員ＩＤComboBox.TabIndex = 81
        Me.生管社員ＩＤComboBox.ValueMember = "社員ＩＤ"
        '
        '工事詳細簡易dtblBindingSource
        '
        Me.工事詳細簡易dtblBindingSource.DataMember = "工事詳細簡易dtbl"
        Me.工事詳細簡易dtblBindingSource.DataSource = Me.ConstructionDataSet
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
        Me.営業社員ＩＤComboBox.Location = New System.Drawing.Point(1079, 68)
        Me.営業社員ＩＤComboBox.Name = "営業社員ＩＤComboBox"
        Me.営業社員ＩＤComboBox.Size = New System.Drawing.Size(155, 27)
        Me.営業社員ＩＤComboBox.TabIndex = 80
        Me.営業社員ＩＤComboBox.ValueMember = "社員ＩＤ"
        '
        '受注営業担当dtblBindingSource
        '
        Me.受注営業担当dtblBindingSource.DataMember = "受注営業担当dtbl"
        Me.受注営業担当dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(978, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(256, 41)
        Me.ButtonClose.TabIndex = 78
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        '工事範囲TextBox
        '
        Me.工事範囲TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事範囲TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事範囲TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細簡易dtblBindingSource, "工事範囲", True))
        Me.工事範囲TextBox.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事範囲TextBox.Location = New System.Drawing.Point(122, 78)
        Me.工事範囲TextBox.Multiline = True
        Me.工事範囲TextBox.Name = "工事範囲TextBox"
        Me.工事範囲TextBox.ReadOnly = True
        Me.工事範囲TextBox.Size = New System.Drawing.Size(807, 50)
        Me.工事範囲TextBox.TabIndex = 76
        '
        '工事名TextBox
        '
        Me.工事名TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事名TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細簡易dtblBindingSource, "工事名", True))
        Me.工事名TextBox.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事名TextBox.Location = New System.Drawing.Point(122, 44)
        Me.工事名TextBox.Name = "工事名TextBox"
        Me.工事名TextBox.ReadOnly = True
        Me.工事名TextBox.Size = New System.Drawing.Size(807, 28)
        Me.工事名TextBox.TabIndex = 74
        '
        '数量TextBox
        '
        Me.数量TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.数量TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.数量TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細簡易dtblBindingSource, "数量", True))
        Me.数量TextBox.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.数量TextBox.Location = New System.Drawing.Point(421, 12)
        Me.数量TextBox.Name = "数量TextBox"
        Me.数量TextBox.ReadOnly = True
        Me.数量TextBox.Size = New System.Drawing.Size(508, 28)
        Me.数量TextBox.TabIndex = 72
        '
        '工事番号TextBox
        '
        Me.工事番号TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事番号TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事番号TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細簡易dtblBindingSource, "工事番号", True))
        Me.工事番号TextBox.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事番号TextBox.Location = New System.Drawing.Point(122, 12)
        Me.工事番号TextBox.Name = "工事番号TextBox"
        Me.工事番号TextBox.ReadOnly = True
        Me.工事番号TextBox.Size = New System.Drawing.Size(202, 28)
        Me.工事番号TextBox.TabIndex = 70
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.合計DataGridView)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Chart1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1254, 528)
        Me.SplitContainer2.SplitterDistance = 335
        Me.SplitContainer2.TabIndex = 0
        '
        '合計DataGridView
        '
        Me.合計DataGridView.AllowUserToAddRows = False
        Me.合計DataGridView.AllowUserToDeleteRows = False
        Me.合計DataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.合計DataGridView.AutoGenerateColumns = False
        Me.合計DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.合計DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.項目名DataGridViewTextBoxColumn, Me.値DataGridViewTextBoxColumn})
        Me.合計DataGridView.DataSource = Me.工事別予算消費グラフBindingSource
        Me.合計DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.合計DataGridView.Name = "合計DataGridView"
        Me.合計DataGridView.ReadOnly = True
        Me.合計DataGridView.RowTemplate.Height = 38
        Me.合計DataGridView.Size = New System.Drawing.Size(330, 116)
        Me.合計DataGridView.TabIndex = 1
        '
        '項目名DataGridViewTextBoxColumn
        '
        Me.項目名DataGridViewTextBoxColumn.DataPropertyName = "項目名"
        Me.項目名DataGridViewTextBoxColumn.HeaderText = "項目名"
        Me.項目名DataGridViewTextBoxColumn.Name = "項目名DataGridViewTextBoxColumn"
        Me.項目名DataGridViewTextBoxColumn.ReadOnly = True
        Me.項目名DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.項目名DataGridViewTextBoxColumn.Width = 130
        '
        '値DataGridViewTextBoxColumn
        '
        Me.値DataGridViewTextBoxColumn.DataPropertyName = "値"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Format = "N1"
        Me.値DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.値DataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.値DataGridViewTextBoxColumn.HeaderText = "値"
        Me.値DataGridViewTextBoxColumn.Name = "値DataGridViewTextBoxColumn"
        Me.値DataGridViewTextBoxColumn.ReadOnly = True
        Me.値DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        '工事別予算消費グラフBindingSource
        '
        Me.工事別予算消費グラフBindingSource.DataMember = "工事別予算消費グラフdtbl"
        Me.工事別予算消費グラフBindingSource.DataSource = Me.ConstructionWorkAndDateDataSet
        '
        'ConstructionWorkAndDateDataSet
        '
        Me.ConstructionWorkAndDateDataSet.DataSetName = "ConstructionWorkAndDateDataSet"
        Me.ConstructionWorkAndDateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.工事別予算消費グラフBindingSource
        Me.Chart1.Location = New System.Drawing.Point(3, 125)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Series1"
        DataPoint1.BorderColor = System.Drawing.Color.Empty
        DataPoint1.IsVisibleInLegend = False
        Series1.Points.Add(DataPoint1)
        Series1.XValueMember = "項目名"
        Series1.YValueMembers = "値"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(329, 403)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(915, 528)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.VScrollBar1)
        Me.TabPage1.Controls.Add(Me.工事別実績予定日付一覧表示用DataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(907, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "部署別"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(869, 3)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(35, 489)
        Me.VScrollBar1.TabIndex = 2
        '
        '工事別実績予定日付一覧表示用DataGridView
        '
        Me.工事別実績予定日付一覧表示用DataGridView.AllowUserToAddRows = False
        Me.工事別実績予定日付一覧表示用DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.工事別実績予定日付一覧表示用DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.工事別実績予定日付一覧表示用DataGridView.AutoGenerateColumns = False
        Me.工事別実績予定日付一覧表示用DataGridView.ColumnHeadersHeight = 35
        Me.工事別実績予定日付一覧表示用DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn1})
        Me.工事別実績予定日付一覧表示用DataGridView.DataSource = Me.工事別実績予定日付一覧表示用dtblBindingSource
        Me.工事別実績予定日付一覧表示用DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.工事別実績予定日付一覧表示用DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.工事別実績予定日付一覧表示用DataGridView.Name = "工事別実績予定日付一覧表示用DataGridView"
        Me.工事別実績予定日付一覧表示用DataGridView.ReadOnly = True
        Me.工事別実績予定日付一覧表示用DataGridView.RowTemplate.Height = 35
        Me.工事別実績予定日付一覧表示用DataGridView.Size = New System.Drawing.Size(901, 489)
        Me.工事別実績予定日付一覧表示用DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "部署ＩＤ"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.工事部署dtblBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "部署名"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.DividerWidth = 2
        Me.DataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn2.HeaderText = "部署"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "部署ＩＤ"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        '工事部署dtblBindingSource
        '
        Me.工事部署dtblBindingSource.DataMember = "工事部署dtbl"
        Me.工事部署dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "実績工数"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle3.Format = "N2"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "実績工数"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "予算工数"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle4.Format = "N2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.DividerWidth = 2
        Me.DataGridViewTextBoxColumn4.HeaderText = "予算工数"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 110
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "予定始"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "MM/dd"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "予定始"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "予定終"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "MM/dd"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.HeaderText = "予定終"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "工事名"
        Me.DataGridViewTextBoxColumn7.HeaderText = "工事名"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "数量"
        Me.DataGridViewTextBoxColumn8.HeaderText = "数量"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "工事番号"
        Me.DataGridViewTextBoxColumn1.HeaderText = "工事番号"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        '工事別実績予定日付一覧表示用dtblBindingSource
        '
        Me.工事別実績予定日付一覧表示用dtblBindingSource.DataMember = "工事別実績予定日付一覧表示用dtbl"
        Me.工事別実績予定日付一覧表示用dtblBindingSource.DataSource = Me.ConstructionWorkAndDateDataSet
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.工事別予算消費工程別dtblDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(907, 502)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "工程別"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        '工事別予算消費工程別dtblDataGridView
        '
        Me.工事別予算消費工程別dtblDataGridView.AllowUserToAddRows = False
        Me.工事別予算消費工程別dtblDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.工事別予算消費工程別dtblDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.工事別予算消費工程別dtblDataGridView.AutoGenerateColumns = False
        Me.工事別予算消費工程別dtblDataGridView.ColumnHeadersHeight = 35
        Me.工事別予算消費工程別dtblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn9})
        Me.工事別予算消費工程別dtblDataGridView.DataSource = Me.工事別予算消費工程別dtblBindingSource
        Me.工事別予算消費工程別dtblDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.工事別予算消費工程別dtblDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.工事別予算消費工程別dtblDataGridView.Name = "工事別予算消費工程別dtblDataGridView"
        Me.工事別予算消費工程別dtblDataGridView.ReadOnly = True
        Me.工事別予算消費工程別dtblDataGridView.RowHeadersWidth = 35
        Me.工事別予算消費工程別dtblDataGridView.RowTemplate.Height = 35
        Me.工事別予算消費工程別dtblDataGridView.Size = New System.Drawing.Size(901, 496)
        Me.工事別予算消費工程別dtblDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "工程パス"
        Me.DataGridViewTextBoxColumn10.DataSource = Me.工場工程dtblBindingSource
        Me.DataGridViewTextBoxColumn10.DisplayMember = "工程名"
        Me.DataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn10.DividerWidth = 2
        Me.DataGridViewTextBoxColumn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn10.HeaderText = "大工程"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.ValueMember = "工程ＩＤ"
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        '工場工程dtblBindingSource
        '
        Me.工場工程dtblBindingSource.DataMember = "工場工程dtbl"
        Me.工場工程dtblBindingSource.DataSource = Me.ConstructionWorkAndDateDataSet
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "実績工数"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle8.Format = "N1"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn11.HeaderText = "実績工数"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 110
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "予算工数"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle9.Format = "N1"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn12.DividerWidth = 2
        Me.DataGridViewTextBoxColumn12.HeaderText = "予算工数"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 110
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "予定始"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "MM/dd"
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn13.HeaderText = "予定始"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "予定終"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "MM/dd"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn14.HeaderText = "予定終"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "工事名"
        Me.DataGridViewTextBoxColumn15.HeaderText = "工事名"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "数量"
        Me.DataGridViewTextBoxColumn16.HeaderText = "数量"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "工事番号"
        Me.DataGridViewTextBoxColumn9.HeaderText = "工事番号"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        '工事別予算消費工程別dtblBindingSource
        '
        Me.工事別予算消費工程別dtblBindingSource.DataMember = "工事別予算消費工程別dtbl"
        Me.工事別予算消費工程別dtblBindingSource.DataSource = Me.ConstructionWorkAndDateDataSet
        '
        '工事詳細簡易dtblTableAdapter
        '
        Me.工事詳細簡易dtblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.工事工程dtblTableAdapter = Nothing
        Me.TableAdapterManager.工事工程予算dtblTableAdapter = Nothing
        Me.TableAdapterManager.工事製造範囲dtblTableAdapter = Nothing
        Me.TableAdapterManager.工事部署dtblTableAdapter = Me.工事部署dtblTableAdapter
        '
        '工事部署dtblTableAdapter
        '
        Me.工事部署dtblTableAdapter.ClearBeforeFill = True
        '
        '工事生管担当dtblTableAdapter
        '
        Me.工事生管担当dtblTableAdapter.ClearBeforeFill = True
        '
        '受注営業担当dtblTableAdapter
        '
        Me.受注営業担当dtblTableAdapter.ClearBeforeFill = True
        '
        '工事別実績予定日付一覧dtblTableAdapter1
        '
        Me.工事別実績予定日付一覧dtblTableAdapter1.ClearBeforeFill = True
        '
        '工事別予算消費工程別dtblTableAdapter
        '
        Me.工事別予算消費工程別dtblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.工場工程dtblTableAdapter = Nothing
        '
        '工場工程dtblTableAdapter
        '
        Me.工場工程dtblTableAdapter.ClearBeforeFill = True
        '
        '工事別予算消費Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "工事別予算消費Form"
        Me.Text = "予算消費状況"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.工事詳細簡易dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstructionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.合計DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事別予算消費グラフBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstructionWorkAndDateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.工事別実績予定日付一覧表示用DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事部署dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事別実績予定日付一覧表示用dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.工事別予算消費工程別dtblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工場工程dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事別予算消費工程別dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ConstructionDataSet As FujiSysForFactory3.ConstructionDataSet
    Friend WithEvents 工事詳細簡易dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事詳細簡易dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事詳細簡易dtblTableAdapter
    Friend WithEvents TableAdapterManager As FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 生管社員ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 営業社員ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents 工事範囲TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事名TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 数量TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事番号TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事生管担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事生管担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter
    Friend WithEvents 受注営業担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 受注営業担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter
    Friend WithEvents 工事部署dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事部署dtblTableAdapter
    Friend WithEvents 工事部署dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事別実績予定日付一覧表示用DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 工事別実績予定日付一覧表示用dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConstructionWorkAndDateDataSet As FujiSysForFactory3.ConstructionWorkAndDateDataSet
    Friend WithEvents 工事別実績予定日付一覧dtblTableAdapter1 As FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.工事別実績予定日付一覧dtblTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents 工事別予算消費グラフBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents 合計DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 工事別予算消費工程別dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事別予算消費工程別dtblTableAdapter As FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.工事別予算消費工程別dtblTableAdapter
    Friend WithEvents TableAdapterManager1 As FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 工事別予算消費工程別dtblDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 工場工程dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工場工程dtblTableAdapter As FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.工場工程dtblTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 項目名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 値DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
End Class
