<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 出荷予定一覧Form
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SalesStaffIDComboBox = New System.Windows.Forms.ComboBox()
        Me.営業担当BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConstructionDataSet = New FujiSysForFactory3.ConstructionDataSet()
        Me.PartsComboBox = New System.Windows.Forms.ComboBox()
        Me.部署BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelShippingNum = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ConstructionCompleteTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonOpenConstrucitonComplete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PmStaffIDComboBox = New System.Windows.Forms.ComboBox()
        Me.生管担当BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputedDateBMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonOpenDateDialog = New System.Windows.Forms.Button()
        Me.InputedDateAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonOpenConstDialog = New System.Windows.Forms.Button()
        Me.ConstructionNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.出荷予定一覧DataGridView = New System.Windows.Forms.DataGridView()
        Me.詳細 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.工程予算ＮＯ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事番号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.取引先ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.取引先最新BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工程期間始DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程期間終DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.部署ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.納品方法DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程備考１DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事完了日DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.営業社員ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.生管社員ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.工程パスDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.出荷予定一覧BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.工事生管担当dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter()
        Me.受注営業担当dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter()
        Me.工事部署dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事部署dtblTableAdapter()
        Me.出荷予定一覧2dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.出荷予定一覧2dtblTableAdapter()
        Me.工事取引先最新dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.営業担当BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstructionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.部署BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.生管担当BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.出荷予定一覧DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.取引先最新BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.出荷予定一覧BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SalesStaffIDComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PartsComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelShippingNum)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.出荷予定一覧DataGridView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.VScrollBar1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1254, 662)
        Me.SplitContainer1.SplitterDistance = 87
        Me.SplitContainer1.SplitterWidth = 7
        Me.SplitContainer1.TabIndex = 0
        '
        'SalesStaffIDComboBox
        '
        Me.SalesStaffIDComboBox.DataSource = Me.営業担当BindingSource
        Me.SalesStaffIDComboBox.DisplayMember = "社員名"
        Me.SalesStaffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SalesStaffIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SalesStaffIDComboBox.FormattingEnabled = True
        Me.SalesStaffIDComboBox.Location = New System.Drawing.Point(708, 13)
        Me.SalesStaffIDComboBox.Name = "SalesStaffIDComboBox"
        Me.SalesStaffIDComboBox.Size = New System.Drawing.Size(147, 29)
        Me.SalesStaffIDComboBox.TabIndex = 72
        Me.SalesStaffIDComboBox.ValueMember = "社員ＩＤ"
        '
        '営業担当BindingSource
        '
        Me.営業担当BindingSource.DataMember = "受注営業担当dtbl"
        Me.営業担当BindingSource.DataSource = Me.ConstructionDataSet
        '
        'ConstructionDataSet
        '
        Me.ConstructionDataSet.DataSetName = "ConstructionDataSet"
        Me.ConstructionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PartsComboBox
        '
        Me.PartsComboBox.DataSource = Me.部署BindingSource
        Me.PartsComboBox.DisplayMember = "部署名"
        Me.PartsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PartsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PartsComboBox.FormattingEnabled = True
        Me.PartsComboBox.Location = New System.Drawing.Point(1013, 15)
        Me.PartsComboBox.Name = "PartsComboBox"
        Me.PartsComboBox.Size = New System.Drawing.Size(147, 29)
        Me.PartsComboBox.TabIndex = 84
        Me.PartsComboBox.ValueMember = "部署ＩＤ"
        '
        '部署BindingSource
        '
        Me.部署BindingSource.DataMember = "工事部署dtbl"
        Me.部署BindingSource.DataSource = Me.ConstructionDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(861, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 21)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "実行予定部署："
        '
        'LabelShippingNum
        '
        Me.LabelShippingNum.BackColor = System.Drawing.Color.Gray
        Me.LabelShippingNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelShippingNum.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelShippingNum.ForeColor = System.Drawing.Color.White
        Me.LabelShippingNum.Location = New System.Drawing.Point(1002, 50)
        Me.LabelShippingNum.Name = "LabelShippingNum"
        Me.LabelShippingNum.Size = New System.Drawing.Size(158, 32)
        Me.LabelShippingNum.TabIndex = 82
        Me.LabelShippingNum.Text = "出荷件数：0"
        Me.LabelShippingNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(1166, 17)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(85, 69)
        Me.ButtonClose.TabIndex = 81
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ConstructionCompleteTextBox
        '
        Me.ConstructionCompleteTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ConstructionCompleteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConstructionCompleteTextBox.Location = New System.Drawing.Point(521, 13)
        Me.ConstructionCompleteTextBox.Name = "ConstructionCompleteTextBox"
        Me.ConstructionCompleteTextBox.ReadOnly = True
        Me.ConstructionCompleteTextBox.Size = New System.Drawing.Size(60, 28)
        Me.ConstructionCompleteTextBox.TabIndex = 77
        Me.ConstructionCompleteTextBox.Text = "未完"
        '
        'ButtonOpenConstrucitonComplete
        '
        Me.ButtonOpenConstrucitonComplete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.ButtonOpenConstrucitonComplete.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstrucitonComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstrucitonComplete.Location = New System.Drawing.Point(384, 11)
        Me.ButtonOpenConstrucitonComplete.Name = "ButtonOpenConstrucitonComplete"
        Me.ButtonOpenConstrucitonComplete.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenConstrucitonComplete.TabIndex = 76
        Me.ButtonOpenConstrucitonComplete.Text = "工事完了："
        Me.ButtonOpenConstrucitonComplete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 21)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "生管担当："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(600, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 21)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "営業担当："
        '
        'PmStaffIDComboBox
        '
        Me.PmStaffIDComboBox.DataSource = Me.生管担当BindingSource
        Me.PmStaffIDComboBox.DisplayMember = "社員名"
        Me.PmStaffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PmStaffIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PmStaffIDComboBox.FormattingEnabled = True
        Me.PmStaffIDComboBox.Location = New System.Drawing.Point(708, 53)
        Me.PmStaffIDComboBox.Name = "PmStaffIDComboBox"
        Me.PmStaffIDComboBox.Size = New System.Drawing.Size(147, 29)
        Me.PmStaffIDComboBox.TabIndex = 73
        Me.PmStaffIDComboBox.ValueMember = "社員ＩＤ"
        '
        '生管担当BindingSource
        '
        Me.生管担当BindingSource.DataMember = "工事生管担当dtbl"
        Me.生管担当BindingSource.DataSource = Me.ConstructionDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 21)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "～"
        '
        'InputedDateBMaskedTextBox
        '
        Me.InputedDateBMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateBMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateBMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateBMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateBMaskedTextBox.Location = New System.Drawing.Point(417, 52)
        Me.InputedDateBMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateBMaskedTextBox.Name = "InputedDateBMaskedTextBox"
        Me.InputedDateBMaskedTextBox.ReadOnly = True
        Me.InputedDateBMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.InputedDateBMaskedTextBox.TabIndex = 70
        Me.InputedDateBMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateBMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonOpenDateDialog
        '
        Me.ButtonOpenDateDialog.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.ButtonOpenDateDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenDateDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenDateDialog.Location = New System.Drawing.Point(72, 53)
        Me.ButtonOpenDateDialog.Name = "ButtonOpenDateDialog"
        Me.ButtonOpenDateDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenDateDialog.TabIndex = 69
        Me.ButtonOpenDateDialog.Text = "出荷始："
        Me.ButtonOpenDateDialog.UseVisualStyleBackColor = True
        '
        'InputedDateAMaskedTextBox
        '
        Me.InputedDateAMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateAMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateAMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateAMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateAMaskedTextBox.Location = New System.Drawing.Point(209, 52)
        Me.InputedDateAMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateAMaskedTextBox.Name = "InputedDateAMaskedTextBox"
        Me.InputedDateAMaskedTextBox.ReadOnly = True
        Me.InputedDateAMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.InputedDateAMaskedTextBox.TabIndex = 68
        Me.InputedDateAMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonOpenConstDialog
        '
        Me.ButtonOpenConstDialog.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.ButtonOpenConstDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstDialog.Location = New System.Drawing.Point(72, 11)
        Me.ButtonOpenConstDialog.Name = "ButtonOpenConstDialog"
        Me.ButtonOpenConstDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenConstDialog.TabIndex = 67
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
        Me.ConstructionNoMaskedTextBox.Location = New System.Drawing.Point(209, 11)
        Me.ConstructionNoMaskedTextBox.Mask = ">00A-&000-00"
        Me.ConstructionNoMaskedTextBox.Name = "ConstructionNoMaskedTextBox"
        Me.ConstructionNoMaskedTextBox.ReadOnly = True
        Me.ConstructionNoMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.ConstructionNoMaskedTextBox.TabIndex = 66
        Me.ConstructionNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '出荷予定一覧DataGridView
        '
        Me.出荷予定一覧DataGridView.AllowUserToAddRows = False
        Me.出荷予定一覧DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.出荷予定一覧DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.出荷予定一覧DataGridView.AutoGenerateColumns = False
        Me.出荷予定一覧DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.出荷予定一覧DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.出荷予定一覧DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.出荷予定一覧DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.詳細, Me.工程予算ＮＯ, Me.工事番号DataGridViewTextBoxColumn, Me.工事名DataGridViewTextBoxColumn, Me.取引先ＩＤDataGridViewTextBoxColumn, Me.工程期間始DataGridViewTextBoxColumn, Me.工程期間終DataGridViewTextBoxColumn, Me.部署ＩＤDataGridViewTextBoxColumn, Me.納品方法DataGridViewTextBoxColumn, Me.工程備考１DataGridViewTextBoxColumn, Me.工事完了日DataGridViewTextBoxColumn, Me.営業社員ＩＤDataGridViewTextBoxColumn, Me.生管社員ＩＤDataGridViewTextBoxColumn, Me.工程パスDataGridViewTextBoxColumn})
        Me.出荷予定一覧DataGridView.DataSource = Me.出荷予定一覧BindingSource
        Me.出荷予定一覧DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.出荷予定一覧DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.出荷予定一覧DataGridView.Name = "出荷予定一覧DataGridView"
        Me.出荷予定一覧DataGridView.ReadOnly = True
        Me.出荷予定一覧DataGridView.RowHeadersWidth = 20
        Me.出荷予定一覧DataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.出荷予定一覧DataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.出荷予定一覧DataGridView.RowTemplate.Height = 45
        Me.出荷予定一覧DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.出荷予定一覧DataGridView.Size = New System.Drawing.Size(1210, 568)
        Me.出荷予定一覧DataGridView.TabIndex = 0
        '
        '詳細
        '
        Me.詳細.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.詳細.HeaderText = "詳細"
        Me.詳細.Name = "詳細"
        Me.詳細.ReadOnly = True
        Me.詳細.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.詳細.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.詳細.Width = 60
        '
        '工程予算ＮＯ
        '
        Me.工程予算ＮＯ.DataPropertyName = "工程予算ＮＯ"
        Me.工程予算ＮＯ.HeaderText = "工程予算ＮＯ"
        Me.工程予算ＮＯ.Name = "工程予算ＮＯ"
        Me.工程予算ＮＯ.ReadOnly = True
        Me.工程予算ＮＯ.Visible = False
        '
        '工事番号DataGridViewTextBoxColumn
        '
        Me.工事番号DataGridViewTextBoxColumn.DataPropertyName = "工事番号"
        Me.工事番号DataGridViewTextBoxColumn.HeaderText = "工事番号"
        Me.工事番号DataGridViewTextBoxColumn.Name = "工事番号DataGridViewTextBoxColumn"
        Me.工事番号DataGridViewTextBoxColumn.ReadOnly = True
        Me.工事番号DataGridViewTextBoxColumn.Width = 125
        '
        '工事名DataGridViewTextBoxColumn
        '
        Me.工事名DataGridViewTextBoxColumn.DataPropertyName = "工事名"
        Me.工事名DataGridViewTextBoxColumn.HeaderText = "工事名"
        Me.工事名DataGridViewTextBoxColumn.Name = "工事名DataGridViewTextBoxColumn"
        Me.工事名DataGridViewTextBoxColumn.ReadOnly = True
        Me.工事名DataGridViewTextBoxColumn.Width = 150
        '
        '取引先ＩＤDataGridViewTextBoxColumn
        '
        Me.取引先ＩＤDataGridViewTextBoxColumn.DataPropertyName = "取引先ＩＤ"
        Me.取引先ＩＤDataGridViewTextBoxColumn.DataSource = Me.取引先最新BindingSource
        Me.取引先ＩＤDataGridViewTextBoxColumn.DisplayMember = "取引先略称"
        Me.取引先ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.取引先ＩＤDataGridViewTextBoxColumn.HeaderText = "取引先"
        Me.取引先ＩＤDataGridViewTextBoxColumn.Name = "取引先ＩＤDataGridViewTextBoxColumn"
        Me.取引先ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.取引先ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.取引先ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.取引先ＩＤDataGridViewTextBoxColumn.ValueMember = "取引先ＩＤ"
        Me.取引先ＩＤDataGridViewTextBoxColumn.Width = 130
        '
        '取引先最新BindingSource
        '
        Me.取引先最新BindingSource.DataMember = "工事取引先最新dtbl"
        Me.取引先最新BindingSource.DataSource = Me.ConstructionDataSet
        '
        '工程期間始DataGridViewTextBoxColumn
        '
        Me.工程期間始DataGridViewTextBoxColumn.DataPropertyName = "工程期間始"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "MM/dd"
        Me.工程期間始DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.工程期間始DataGridViewTextBoxColumn.HeaderText = "出荷始"
        Me.工程期間始DataGridViewTextBoxColumn.Name = "工程期間始DataGridViewTextBoxColumn"
        Me.工程期間始DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程期間始DataGridViewTextBoxColumn.Width = 70
        '
        '工程期間終DataGridViewTextBoxColumn
        '
        Me.工程期間終DataGridViewTextBoxColumn.DataPropertyName = "工程期間終"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "MM/dd"
        Me.工程期間終DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.工程期間終DataGridViewTextBoxColumn.HeaderText = "出荷終"
        Me.工程期間終DataGridViewTextBoxColumn.Name = "工程期間終DataGridViewTextBoxColumn"
        Me.工程期間終DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程期間終DataGridViewTextBoxColumn.Width = 70
        '
        '部署ＩＤDataGridViewTextBoxColumn
        '
        Me.部署ＩＤDataGridViewTextBoxColumn.DataPropertyName = "部署ＩＤ"
        Me.部署ＩＤDataGridViewTextBoxColumn.DataSource = Me.部署BindingSource
        Me.部署ＩＤDataGridViewTextBoxColumn.DisplayMember = "部署名"
        Me.部署ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.部署ＩＤDataGridViewTextBoxColumn.HeaderText = "実行予定部署"
        Me.部署ＩＤDataGridViewTextBoxColumn.Name = "部署ＩＤDataGridViewTextBoxColumn"
        Me.部署ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.部署ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.部署ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.部署ＩＤDataGridViewTextBoxColumn.ValueMember = "部署ＩＤ"
        '
        '納品方法DataGridViewTextBoxColumn
        '
        Me.納品方法DataGridViewTextBoxColumn.DataPropertyName = "納品方法"
        Me.納品方法DataGridViewTextBoxColumn.HeaderText = "納品方法"
        Me.納品方法DataGridViewTextBoxColumn.Name = "納品方法DataGridViewTextBoxColumn"
        Me.納品方法DataGridViewTextBoxColumn.ReadOnly = True
        Me.納品方法DataGridViewTextBoxColumn.Width = 130
        '
        '工程備考１DataGridViewTextBoxColumn
        '
        Me.工程備考１DataGridViewTextBoxColumn.DataPropertyName = "工程備考１"
        Me.工程備考１DataGridViewTextBoxColumn.HeaderText = "工程備考"
        Me.工程備考１DataGridViewTextBoxColumn.Name = "工程備考１DataGridViewTextBoxColumn"
        Me.工程備考１DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程備考１DataGridViewTextBoxColumn.Width = 150
        '
        '工事完了日DataGridViewTextBoxColumn
        '
        Me.工事完了日DataGridViewTextBoxColumn.DataPropertyName = "工事完了日"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "MM/dd"
        Me.工事完了日DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.工事完了日DataGridViewTextBoxColumn.HeaderText = "工完日"
        Me.工事完了日DataGridViewTextBoxColumn.Name = "工事完了日DataGridViewTextBoxColumn"
        Me.工事完了日DataGridViewTextBoxColumn.ReadOnly = True
        Me.工事完了日DataGridViewTextBoxColumn.Width = 70
        '
        '営業社員ＩＤDataGridViewTextBoxColumn
        '
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DataPropertyName = "営業社員ＩＤ"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DataSource = Me.営業担当BindingSource
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DisplayMember = "社員名"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.営業社員ＩＤDataGridViewTextBoxColumn.HeaderText = "営業担当"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.Name = "営業社員ＩＤDataGridViewTextBoxColumn"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.営業社員ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.営業社員ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.営業社員ＩＤDataGridViewTextBoxColumn.ValueMember = "社員ＩＤ"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.Width = 85
        '
        '生管社員ＩＤDataGridViewTextBoxColumn
        '
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DataPropertyName = "生管社員ＩＤ"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DataSource = Me.生管担当BindingSource
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DisplayMember = "社員名"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.生管社員ＩＤDataGridViewTextBoxColumn.HeaderText = "生管担当"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.Name = "生管社員ＩＤDataGridViewTextBoxColumn"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.生管社員ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.生管社員ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.生管社員ＩＤDataGridViewTextBoxColumn.ValueMember = "社員ＩＤ"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.Width = 85
        '
        '工程パスDataGridViewTextBoxColumn
        '
        Me.工程パスDataGridViewTextBoxColumn.DataPropertyName = "工程パス"
        Me.工程パスDataGridViewTextBoxColumn.HeaderText = "工程パス"
        Me.工程パスDataGridViewTextBoxColumn.Name = "工程パスDataGridViewTextBoxColumn"
        Me.工程パスDataGridViewTextBoxColumn.ReadOnly = True
        Me.工程パスDataGridViewTextBoxColumn.Visible = False
        '
        '出荷予定一覧BindingSource
        '
        Me.出荷予定一覧BindingSource.DataMember = "出荷予定一覧2dtbl"
        Me.出荷予定一覧BindingSource.DataSource = Me.ConstructionDataSet
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(1210, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(44, 568)
        Me.VScrollBar1.TabIndex = 1
        '
        '工事生管担当dtblTableAdapter1
        '
        Me.工事生管担当dtblTableAdapter1.ClearBeforeFill = True
        '
        '受注営業担当dtblTableAdapter1
        '
        Me.受注営業担当dtblTableAdapter1.ClearBeforeFill = True
        '
        '工事部署dtblTableAdapter1
        '
        Me.工事部署dtblTableAdapter1.ClearBeforeFill = True
        '
        '出荷予定一覧2dtblTableAdapter1
        '
        Me.出荷予定一覧2dtblTableAdapter1.ClearBeforeFill = True
        '
        '工事取引先最新dtblTableAdapter1
        '
        Me.工事取引先最新dtblTableAdapter1.ClearBeforeFill = True
        '
        '出荷予定一覧Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "出荷予定一覧Form"
        Me.Text = "出荷予定一覧"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.営業担当BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstructionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.部署BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.生管担当BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.出荷予定一覧DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.取引先最新BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.出荷予定一覧BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PartsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelShippingNum As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ConstructionCompleteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOpenConstrucitonComplete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PmStaffIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SalesStaffIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InputedDateBMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonOpenDateDialog As System.Windows.Forms.Button
    Friend WithEvents InputedDateAMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonOpenConstDialog As System.Windows.Forms.Button
    Friend WithEvents ConstructionNoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents 工事生管担当dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter
    Friend WithEvents 受注営業担当dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter
    Friend WithEvents 工事部署dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事部署dtblTableAdapter
    Friend WithEvents 生管担当BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConstructionDataSet As FujiSysForFactory3.ConstructionDataSet
    Friend WithEvents 営業担当BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 部署BindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents 出荷予定一覧dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.出荷予定一覧dtblTableAdapter
    Friend WithEvents 出荷予定一覧BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 出荷予定一覧DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 出荷予定一覧2dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.出荷予定一覧2dtblTableAdapter
    Friend WithEvents 工事取引先最新dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter
    Friend WithEvents 取引先最新BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents 詳細 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents 工程予算ＮＯ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事番号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 取引先ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 工程期間始DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程期間終DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 部署ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 納品方法DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程備考１DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事完了日DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 営業社員ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 生管社員ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 工程パスDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
