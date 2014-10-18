<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 外業予定一覧Form
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SalesStaffIDComboBox = New System.Windows.Forms.ComboBox()
        Me.受注営業担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConstructionDataSet = New FujiSysForFactory3.ConstructionDataSet()
        Me.LabelOutWorkNum = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ConstructionCompleteTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonOpenConstrucitonComplete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PmStaffIDComboBox = New System.Windows.Forms.ComboBox()
        Me.工事生管担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputedDateBMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonOpenDateDialog = New System.Windows.Forms.Button()
        Me.InputedDateAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonOpenConstDialog = New System.Windows.Forms.Button()
        Me.ConstructionNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.外業予定一覧DataGridView = New System.Windows.Forms.DataGridView()
        Me.詳細 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.工程予算ＮＯDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事番号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.取引先ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.工事取引先最新dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工程期間始DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程期間終DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事責任者DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程備考１DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事完了日DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.営業社員ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.生管社員ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.部署ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.外業予定一覧dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.外業予定一覧dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.外業予定一覧dtblTableAdapter()
        Me.TableAdapterManager = New FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager()
        Me.工事生管担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter()
        Me.受注営業担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter()
        Me.工事取引先最新dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstructionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.外業予定一覧DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事取引先最新dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.外業予定一覧dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SalesStaffIDComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelOutWorkNum)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConstructionCompleteTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenConstrucitonComplete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PmStaffIDComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateBMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenDateDialog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateAMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenConstDialog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConstructionNoMaskedTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.VScrollBar1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.外業予定一覧DataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1254, 662)
        Me.SplitContainer1.SplitterDistance = 88
        Me.SplitContainer1.TabIndex = 0
        '
        'SalesStaffIDComboBox
        '
        Me.SalesStaffIDComboBox.DataSource = Me.受注営業担当dtblBindingSource
        Me.SalesStaffIDComboBox.DisplayMember = "社員名"
        Me.SalesStaffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SalesStaffIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SalesStaffIDComboBox.FormattingEnabled = True
        Me.SalesStaffIDComboBox.Location = New System.Drawing.Point(636, 15)
        Me.SalesStaffIDComboBox.Name = "SalesStaffIDComboBox"
        Me.SalesStaffIDComboBox.Size = New System.Drawing.Size(147, 27)
        Me.SalesStaffIDComboBox.TabIndex = 91
        Me.SalesStaffIDComboBox.ValueMember = "社員ＩＤ"
        '
        '受注営業担当dtblBindingSource
        '
        Me.受注営業担当dtblBindingSource.DataMember = "受注営業担当dtbl"
        Me.受注営業担当dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        'ConstructionDataSet
        '
        Me.ConstructionDataSet.DataSetName = "ConstructionDataSet"
        Me.ConstructionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelOutWorkNum
        '
        Me.LabelOutWorkNum.BackColor = System.Drawing.Color.Gray
        Me.LabelOutWorkNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOutWorkNum.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelOutWorkNum.ForeColor = System.Drawing.Color.White
        Me.LabelOutWorkNum.Location = New System.Drawing.Point(993, 14)
        Me.LabelOutWorkNum.Name = "LabelOutWorkNum"
        Me.LabelOutWorkNum.Size = New System.Drawing.Size(158, 32)
        Me.LabelOutWorkNum.TabIndex = 99
        Me.LabelOutWorkNum.Text = "外業件数：0"
        Me.LabelOutWorkNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(1168, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(85, 69)
        Me.ButtonClose.TabIndex = 98
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ConstructionCompleteTextBox
        '
        Me.ConstructionCompleteTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ConstructionCompleteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConstructionCompleteTextBox.Location = New System.Drawing.Point(466, 13)
        Me.ConstructionCompleteTextBox.Name = "ConstructionCompleteTextBox"
        Me.ConstructionCompleteTextBox.ReadOnly = True
        Me.ConstructionCompleteTextBox.Size = New System.Drawing.Size(60, 26)
        Me.ConstructionCompleteTextBox.TabIndex = 96
        Me.ConstructionCompleteTextBox.Text = "未完"
        '
        'ButtonOpenConstrucitonComplete
        '
        Me.ButtonOpenConstrucitonComplete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenConstrucitonComplete.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstrucitonComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstrucitonComplete.Location = New System.Drawing.Point(329, 10)
        Me.ButtonOpenConstrucitonComplete.Name = "ButtonOpenConstrucitonComplete"
        Me.ButtonOpenConstrucitonComplete.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenConstrucitonComplete.TabIndex = 95
        Me.ButtonOpenConstrucitonComplete.Text = "工事完了："
        Me.ButtonOpenConstrucitonComplete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(541, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "生管担当："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(541, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "営業担当："
        '
        'PmStaffIDComboBox
        '
        Me.PmStaffIDComboBox.DataSource = Me.工事生管担当dtblBindingSource
        Me.PmStaffIDComboBox.DisplayMember = "社員名"
        Me.PmStaffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PmStaffIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PmStaffIDComboBox.FormattingEnabled = True
        Me.PmStaffIDComboBox.Location = New System.Drawing.Point(636, 54)
        Me.PmStaffIDComboBox.Name = "PmStaffIDComboBox"
        Me.PmStaffIDComboBox.Size = New System.Drawing.Size(147, 27)
        Me.PmStaffIDComboBox.TabIndex = 92
        Me.PmStaffIDComboBox.ValueMember = "社員ＩＤ"
        '
        '工事生管担当dtblBindingSource
        '
        Me.工事生管担当dtblBindingSource.DataMember = "工事生管担当dtbl"
        Me.工事生管担当dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(324, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 19)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "～"
        '
        'InputedDateBMaskedTextBox
        '
        Me.InputedDateBMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateBMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateBMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateBMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateBMaskedTextBox.Location = New System.Drawing.Point(362, 52)
        Me.InputedDateBMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateBMaskedTextBox.Name = "InputedDateBMaskedTextBox"
        Me.InputedDateBMaskedTextBox.ReadOnly = True
        Me.InputedDateBMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.InputedDateBMaskedTextBox.TabIndex = 89
        Me.InputedDateBMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateBMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonOpenDateDialog
        '
        Me.ButtonOpenDateDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenDateDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenDateDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenDateDialog.Location = New System.Drawing.Point(16, 51)
        Me.ButtonOpenDateDialog.Name = "ButtonOpenDateDialog"
        Me.ButtonOpenDateDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenDateDialog.TabIndex = 88
        Me.ButtonOpenDateDialog.Text = "外業始："
        Me.ButtonOpenDateDialog.UseVisualStyleBackColor = True
        '
        'InputedDateAMaskedTextBox
        '
        Me.InputedDateAMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateAMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateAMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateAMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateAMaskedTextBox.Location = New System.Drawing.Point(153, 51)
        Me.InputedDateAMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateAMaskedTextBox.Name = "InputedDateAMaskedTextBox"
        Me.InputedDateAMaskedTextBox.ReadOnly = True
        Me.InputedDateAMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.InputedDateAMaskedTextBox.TabIndex = 87
        Me.InputedDateAMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonOpenConstDialog
        '
        Me.ButtonOpenConstDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenConstDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstDialog.Location = New System.Drawing.Point(16, 11)
        Me.ButtonOpenConstDialog.Name = "ButtonOpenConstDialog"
        Me.ButtonOpenConstDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenConstDialog.TabIndex = 86
        Me.ButtonOpenConstDialog.Text = "工事番号："
        Me.ButtonOpenConstDialog.UseVisualStyleBackColor = True
        '
        'ConstructionNoMaskedTextBox
        '
        Me.ConstructionNoMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ConstructionNoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConstructionNoMaskedTextBox.Enabled = False
        Me.ConstructionNoMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ConstructionNoMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ConstructionNoMaskedTextBox.Location = New System.Drawing.Point(153, 11)
        Me.ConstructionNoMaskedTextBox.Mask = ">00A-&000-00"
        Me.ConstructionNoMaskedTextBox.Name = "ConstructionNoMaskedTextBox"
        Me.ConstructionNoMaskedTextBox.ReadOnly = True
        Me.ConstructionNoMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.ConstructionNoMaskedTextBox.TabIndex = 85
        Me.ConstructionNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(1210, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(44, 570)
        Me.VScrollBar1.TabIndex = 1
        '
        '外業予定一覧DataGridView
        '
        Me.外業予定一覧DataGridView.AllowUserToAddRows = False
        Me.外業予定一覧DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.外業予定一覧DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.外業予定一覧DataGridView.AutoGenerateColumns = False
        Me.外業予定一覧DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.外業予定一覧DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.詳細, Me.工程予算ＮＯDataGridViewTextBoxColumn, Me.工事番号DataGridViewTextBoxColumn, Me.工事名DataGridViewTextBoxColumn, Me.取引先ＩＤDataGridViewTextBoxColumn, Me.工程期間始DataGridViewTextBoxColumn, Me.工程期間終DataGridViewTextBoxColumn, Me.工事責任者DataGridViewTextBoxColumn, Me.工程備考１DataGridViewTextBoxColumn, Me.工事完了日DataGridViewTextBoxColumn, Me.営業社員ＩＤDataGridViewTextBoxColumn, Me.生管社員ＩＤDataGridViewTextBoxColumn, Me.部署ＩＤDataGridViewTextBoxColumn, Me.工程ＩＤDataGridViewTextBoxColumn})
        Me.外業予定一覧DataGridView.DataSource = Me.外業予定一覧dtblBindingSource
        Me.外業予定一覧DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.外業予定一覧DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.外業予定一覧DataGridView.Name = "外業予定一覧DataGridView"
        Me.外業予定一覧DataGridView.RowHeadersWidth = 15
        Me.外業予定一覧DataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.外業予定一覧DataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.外業予定一覧DataGridView.RowTemplate.Height = 45
        Me.外業予定一覧DataGridView.Size = New System.Drawing.Size(1254, 570)
        Me.外業予定一覧DataGridView.TabIndex = 0
        '
        '詳細
        '
        Me.詳細.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.詳細.HeaderText = "詳細"
        Me.詳細.Name = "詳細"
        Me.詳細.Width = 60
        '
        '工程予算ＮＯDataGridViewTextBoxColumn
        '
        Me.工程予算ＮＯDataGridViewTextBoxColumn.DataPropertyName = "工程予算ＮＯ"
        Me.工程予算ＮＯDataGridViewTextBoxColumn.HeaderText = "工程予算ＮＯ"
        Me.工程予算ＮＯDataGridViewTextBoxColumn.Name = "工程予算ＮＯDataGridViewTextBoxColumn"
        Me.工程予算ＮＯDataGridViewTextBoxColumn.ReadOnly = True
        Me.工程予算ＮＯDataGridViewTextBoxColumn.Visible = False
        '
        '工事番号DataGridViewTextBoxColumn
        '
        Me.工事番号DataGridViewTextBoxColumn.DataPropertyName = "工事番号"
        Me.工事番号DataGridViewTextBoxColumn.HeaderText = "工事番号"
        Me.工事番号DataGridViewTextBoxColumn.Name = "工事番号DataGridViewTextBoxColumn"
        Me.工事番号DataGridViewTextBoxColumn.Width = 125
        '
        '工事名DataGridViewTextBoxColumn
        '
        Me.工事名DataGridViewTextBoxColumn.DataPropertyName = "工事名"
        Me.工事名DataGridViewTextBoxColumn.HeaderText = "工事名"
        Me.工事名DataGridViewTextBoxColumn.Name = "工事名DataGridViewTextBoxColumn"
        Me.工事名DataGridViewTextBoxColumn.Width = 150
        '
        '取引先ＩＤDataGridViewTextBoxColumn
        '
        Me.取引先ＩＤDataGridViewTextBoxColumn.DataPropertyName = "取引先ＩＤ"
        Me.取引先ＩＤDataGridViewTextBoxColumn.DataSource = Me.工事取引先最新dtblBindingSource
        Me.取引先ＩＤDataGridViewTextBoxColumn.DisplayMember = "取引先略称"
        Me.取引先ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.取引先ＩＤDataGridViewTextBoxColumn.HeaderText = "取引先"
        Me.取引先ＩＤDataGridViewTextBoxColumn.Name = "取引先ＩＤDataGridViewTextBoxColumn"
        Me.取引先ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.取引先ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.取引先ＩＤDataGridViewTextBoxColumn.ValueMember = "取引先ＩＤ"
        Me.取引先ＩＤDataGridViewTextBoxColumn.Width = 130
        '
        '工事取引先最新dtblBindingSource
        '
        Me.工事取引先最新dtblBindingSource.DataMember = "工事取引先最新dtbl"
        Me.工事取引先最新dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        '工程期間始DataGridViewTextBoxColumn
        '
        Me.工程期間始DataGridViewTextBoxColumn.DataPropertyName = "工程期間始"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "MM/dd"
        Me.工程期間始DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.工程期間始DataGridViewTextBoxColumn.HeaderText = "外業始"
        Me.工程期間始DataGridViewTextBoxColumn.Name = "工程期間始DataGridViewTextBoxColumn"
        Me.工程期間始DataGridViewTextBoxColumn.Width = 65
        '
        '工程期間終DataGridViewTextBoxColumn
        '
        Me.工程期間終DataGridViewTextBoxColumn.DataPropertyName = "工程期間終"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "MM/dd"
        Me.工程期間終DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.工程期間終DataGridViewTextBoxColumn.HeaderText = "外業終"
        Me.工程期間終DataGridViewTextBoxColumn.Name = "工程期間終DataGridViewTextBoxColumn"
        Me.工程期間終DataGridViewTextBoxColumn.Width = 60
        '
        '工事責任者DataGridViewTextBoxColumn
        '
        Me.工事責任者DataGridViewTextBoxColumn.DataPropertyName = "工事責任者"
        Me.工事責任者DataGridViewTextBoxColumn.HeaderText = "工事責任者"
        Me.工事責任者DataGridViewTextBoxColumn.Name = "工事責任者DataGridViewTextBoxColumn"
        Me.工事責任者DataGridViewTextBoxColumn.Width = 130
        '
        '工程備考１DataGridViewTextBoxColumn
        '
        Me.工程備考１DataGridViewTextBoxColumn.DataPropertyName = "工程備考１"
        Me.工程備考１DataGridViewTextBoxColumn.HeaderText = "工程備考"
        Me.工程備考１DataGridViewTextBoxColumn.Name = "工程備考１DataGridViewTextBoxColumn"
        Me.工程備考１DataGridViewTextBoxColumn.Width = 150
        '
        '工事完了日DataGridViewTextBoxColumn
        '
        Me.工事完了日DataGridViewTextBoxColumn.DataPropertyName = "工事完了日"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "MM/dd"
        Me.工事完了日DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.工事完了日DataGridViewTextBoxColumn.HeaderText = "工完日"
        Me.工事完了日DataGridViewTextBoxColumn.Name = "工事完了日DataGridViewTextBoxColumn"
        Me.工事完了日DataGridViewTextBoxColumn.Width = 70
        '
        '営業社員ＩＤDataGridViewTextBoxColumn
        '
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DataPropertyName = "営業社員ＩＤ"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DataSource = Me.受注営業担当dtblBindingSource
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DisplayMember = "社員名"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.営業社員ＩＤDataGridViewTextBoxColumn.HeaderText = "営業担当"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.Name = "営業社員ＩＤDataGridViewTextBoxColumn"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.営業社員ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.営業社員ＩＤDataGridViewTextBoxColumn.ValueMember = "社員ＩＤ"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.Width = 85
        '
        '生管社員ＩＤDataGridViewTextBoxColumn
        '
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DataPropertyName = "生管社員ＩＤ"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DataSource = Me.工事生管担当dtblBindingSource
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DisplayMember = "社員名"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.生管社員ＩＤDataGridViewTextBoxColumn.HeaderText = "生管担当"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.Name = "生管社員ＩＤDataGridViewTextBoxColumn"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.生管社員ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.生管社員ＩＤDataGridViewTextBoxColumn.ValueMember = "社員ＩＤ"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.Width = 85
        '
        '部署ＩＤDataGridViewTextBoxColumn
        '
        Me.部署ＩＤDataGridViewTextBoxColumn.DataPropertyName = "部署ＩＤ"
        Me.部署ＩＤDataGridViewTextBoxColumn.HeaderText = "予定部署"
        Me.部署ＩＤDataGridViewTextBoxColumn.Name = "部署ＩＤDataGridViewTextBoxColumn"
        Me.部署ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.部署ＩＤDataGridViewTextBoxColumn.Visible = False
        '
        '工程ＩＤDataGridViewTextBoxColumn
        '
        Me.工程ＩＤDataGridViewTextBoxColumn.DataPropertyName = "工程ＩＤ"
        Me.工程ＩＤDataGridViewTextBoxColumn.HeaderText = "工程ＩＤ"
        Me.工程ＩＤDataGridViewTextBoxColumn.Name = "工程ＩＤDataGridViewTextBoxColumn"
        Me.工程ＩＤDataGridViewTextBoxColumn.Visible = False
        '
        '外業予定一覧dtblBindingSource
        '
        Me.外業予定一覧dtblBindingSource.DataMember = "外業予定一覧dtbl"
        Me.外業予定一覧dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        '外業予定一覧dtblTableAdapter
        '
        Me.外業予定一覧dtblTableAdapter.ClearBeforeFill = True
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
        '工事生管担当dtblTableAdapter
        '
        Me.工事生管担当dtblTableAdapter.ClearBeforeFill = True
        '
        '受注営業担当dtblTableAdapter
        '
        Me.受注営業担当dtblTableAdapter.ClearBeforeFill = True
        '
        '工事取引先最新dtblTableAdapter
        '
        Me.工事取引先最新dtblTableAdapter.ClearBeforeFill = True
        '
        '外業予定一覧Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "外業予定一覧Form"
        Me.Text = "外業予定一覧"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstructionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.外業予定一覧DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事取引先最新dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.外業予定一覧dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SalesStaffIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LabelOutWorkNum As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ConstructionCompleteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOpenConstrucitonComplete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PmStaffIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InputedDateBMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonOpenDateDialog As System.Windows.Forms.Button
    Friend WithEvents InputedDateAMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonOpenConstDialog As System.Windows.Forms.Button
    Friend WithEvents ConstructionNoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents 外業予定一覧DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ConstructionDataSet As FujiSysForFactory3.ConstructionDataSet
    Friend WithEvents 外業予定一覧dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 外業予定一覧dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.外業予定一覧dtblTableAdapter
    Friend WithEvents TableAdapterManager As FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 工事生管担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事生管担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter
    Friend WithEvents 受注営業担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 受注営業担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents 工事取引先最新dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事取引先最新dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter
    Friend WithEvents 詳細 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents 工程予算ＮＯDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事番号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 取引先ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 工程期間始DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程期間終DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事責任者DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程備考１DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事完了日DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 営業社員ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 生管社員ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 部署ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
