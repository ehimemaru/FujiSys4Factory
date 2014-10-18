<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 工事別日程予算一覧Form
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
        Me.LabelConstructionNum = New System.Windows.Forms.Label()
        Me.ConstructionCompleteTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonOpenConstrucitonComplete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PmStaffIDComboBox = New System.Windows.Forms.ComboBox()
        Me.工事生管担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConstructionDataSet = New FujiSysForFactory3.ConstructionDataSet()
        Me.SalesStaffIDComboBox = New System.Windows.Forms.ComboBox()
        Me.受注営業担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputedDateBMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonOpenDateDialog = New System.Windows.Forms.Button()
        Me.InputedDateAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonOpenConstDialog = New System.Windows.Forms.Button()
        Me.ConstructionNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.工事取引先最新dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事取引先最新dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter()
        Me.TableAdapterManager = New FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager()
        Me.工事生管担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter()
        Me.受注営業担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter()
        Me.ConstructionWorkAndDateDataSet = New FujiSysForFactory3.ConstructionWorkAndDateDataSet()
        Me.工場内部署人数dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工場内部署人数dtblTableAdapter = New FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.工場内部署人数dtblTableAdapter()
        Me.TableAdapterManager1 = New FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.TableAdapterManager()
        Me.工事別実績予定日付一覧dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事別実績予定日付一覧dtblTableAdapter = New FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.工事別実績予定日付一覧dtblTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonGo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.部署人数DataGridView = New System.Windows.Forms.DataGridView()
        Me.DisplayAllButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.合計人数TextBox = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.一覧表示DataGridView = New System.Windows.Forms.DataGridView()
        Me.詳細 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.工事番号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.数量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.実績工数DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.予算工数DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.予定始DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.予定終DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.部署ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.表示用BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstructionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事取引先最新dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstructionWorkAndDateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工場内部署人数dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事別実績予定日付一覧dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.部署人数DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.一覧表示DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.表示用BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelConstructionNum
        '
        Me.LabelConstructionNum.BackColor = System.Drawing.Color.Gray
        Me.LabelConstructionNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConstructionNum.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelConstructionNum.ForeColor = System.Drawing.Color.White
        Me.LabelConstructionNum.Location = New System.Drawing.Point(12, 9)
        Me.LabelConstructionNum.Name = "LabelConstructionNum"
        Me.LabelConstructionNum.Size = New System.Drawing.Size(171, 32)
        Me.LabelConstructionNum.TabIndex = 78
        Me.LabelConstructionNum.Text = "工事件数：0"
        Me.LabelConstructionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ConstructionCompleteTextBox
        '
        Me.ConstructionCompleteTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ConstructionCompleteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConstructionCompleteTextBox.Location = New System.Drawing.Point(12, 424)
        Me.ConstructionCompleteTextBox.Name = "ConstructionCompleteTextBox"
        Me.ConstructionCompleteTextBox.ReadOnly = True
        Me.ConstructionCompleteTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ConstructionCompleteTextBox.TabIndex = 77
        Me.ConstructionCompleteTextBox.Text = "未完"
        '
        'ButtonOpenConstrucitonComplete
        '
        Me.ButtonOpenConstrucitonComplete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenConstrucitonComplete.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstrucitonComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstrucitonComplete.Location = New System.Drawing.Point(12, 387)
        Me.ButtonOpenConstrucitonComplete.Name = "ButtonOpenConstrucitonComplete"
        Me.ButtonOpenConstrucitonComplete.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenConstrucitonComplete.TabIndex = 76
        Me.ButtonOpenConstrucitonComplete.Text = "工事完了："
        Me.ButtonOpenConstrucitonComplete.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "生管担当："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "営業担当："
        '
        'PmStaffIDComboBox
        '
        Me.PmStaffIDComboBox.DataSource = Me.工事生管担当dtblBindingSource
        Me.PmStaffIDComboBox.DisplayMember = "社員名"
        Me.PmStaffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PmStaffIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PmStaffIDComboBox.FormattingEnabled = True
        Me.PmStaffIDComboBox.Location = New System.Drawing.Point(12, 354)
        Me.PmStaffIDComboBox.Name = "PmStaffIDComboBox"
        Me.PmStaffIDComboBox.Size = New System.Drawing.Size(164, 27)
        Me.PmStaffIDComboBox.TabIndex = 73
        Me.PmStaffIDComboBox.ValueMember = "社員ＩＤ"
        '
        '工事生管担当dtblBindingSource
        '
        Me.工事生管担当dtblBindingSource.DataMember = "工事生管担当dtbl"
        Me.工事生管担当dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        'ConstructionDataSet
        '
        Me.ConstructionDataSet.DataSetName = "ConstructionDataSet"
        Me.ConstructionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesStaffIDComboBox
        '
        Me.SalesStaffIDComboBox.DataSource = Me.受注営業担当dtblBindingSource
        Me.SalesStaffIDComboBox.DisplayMember = "社員名"
        Me.SalesStaffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SalesStaffIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SalesStaffIDComboBox.FormattingEnabled = True
        Me.SalesStaffIDComboBox.Location = New System.Drawing.Point(12, 291)
        Me.SalesStaffIDComboBox.Name = "SalesStaffIDComboBox"
        Me.SalesStaffIDComboBox.Size = New System.Drawing.Size(164, 27)
        Me.SalesStaffIDComboBox.TabIndex = 72
        Me.SalesStaffIDComboBox.ValueMember = "社員ＩＤ"
        '
        '受注営業担当dtblBindingSource
        '
        Me.受注営業担当dtblBindingSource.DataMember = "受注営業担当dtbl"
        Me.受注営業担当dtblBindingSource.DataSource = Me.ConstructionDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 19)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "～"
        '
        'InputedDateBMaskedTextBox
        '
        Me.InputedDateBMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateBMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateBMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateBMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateBMaskedTextBox.Location = New System.Drawing.Point(12, 223)
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
        Me.ButtonOpenDateDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenDateDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenDateDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenDateDialog.Location = New System.Drawing.Point(12, 136)
        Me.ButtonOpenDateDialog.Name = "ButtonOpenDateDialog"
        Me.ButtonOpenDateDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenDateDialog.TabIndex = 69
        Me.ButtonOpenDateDialog.Text = "予定始："
        Me.ButtonOpenDateDialog.UseVisualStyleBackColor = False
        '
        'InputedDateAMaskedTextBox
        '
        Me.InputedDateAMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateAMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateAMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateAMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateAMaskedTextBox.Location = New System.Drawing.Point(12, 173)
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
        Me.ButtonOpenConstDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenConstDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstDialog.Location = New System.Drawing.Point(12, 62)
        Me.ButtonOpenConstDialog.Name = "ButtonOpenConstDialog"
        Me.ButtonOpenConstDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenConstDialog.TabIndex = 67
        Me.ButtonOpenConstDialog.Text = "工事番号："
        Me.ButtonOpenConstDialog.UseVisualStyleBackColor = False
        '
        'ConstructionNoMaskedTextBox
        '
        Me.ConstructionNoMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ConstructionNoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConstructionNoMaskedTextBox.Enabled = False
        Me.ConstructionNoMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ConstructionNoMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ConstructionNoMaskedTextBox.Location = New System.Drawing.Point(12, 99)
        Me.ConstructionNoMaskedTextBox.Mask = ">00A-&000-00"
        Me.ConstructionNoMaskedTextBox.Name = "ConstructionNoMaskedTextBox"
        Me.ConstructionNoMaskedTextBox.ReadOnly = True
        Me.ConstructionNoMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.ConstructionNoMaskedTextBox.TabIndex = 66
        Me.ConstructionNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'ConstructionWorkAndDateDataSet
        '
        Me.ConstructionWorkAndDateDataSet.DataSetName = "ConstructionWorkAndDateDataSet"
        Me.ConstructionWorkAndDateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '工場内部署人数dtblBindingSource
        '
        Me.工場内部署人数dtblBindingSource.DataMember = "工場内部署人数dtbl"
        Me.工場内部署人数dtblBindingSource.DataSource = Me.ConstructionWorkAndDateDataSet
        '
        '工場内部署人数dtblTableAdapter
        '
        Me.工場内部署人数dtblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.工場工程dtblTableAdapter = Nothing
        '
        '工事別実績予定日付一覧dtblBindingSource
        '
        Me.工事別実績予定日付一覧dtblBindingSource.DataMember = "工事別実績予定日付一覧dtbl"
        Me.工事別実績予定日付一覧dtblBindingSource.DataSource = Me.ConstructionWorkAndDateDataSet
        '
        '工事別実績予定日付一覧dtblTableAdapter
        '
        Me.工事別実績予定日付一覧dtblTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonGo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenConstDialog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelConstructionNum)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConstructionNoMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConstructionCompleteTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenDateDialog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PmStaffIDComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenConstrucitonComplete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SalesStaffIDComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateAMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateBMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1254, 662)
        Me.SplitContainer1.SplitterDistance = 217
        Me.SplitContainer1.TabIndex = 79
        '
        'ButtonGo
        '
        Me.ButtonGo.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonGo.FlatAppearance.BorderSize = 2
        Me.ButtonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGo.Location = New System.Drawing.Point(189, 9)
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(21, 32)
        Me.ButtonGo.TabIndex = 79
        Me.ButtonGo.Text = "検索"
        Me.ButtonGo.UseVisualStyleBackColor = False
        Me.ButtonGo.Visible = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(7, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 408)
        Me.Label6.TabIndex = 80
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.部署人数DataGridView)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DisplayAllButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.合計人数TextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ButtonClose)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.VScrollBar1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.一覧表示DataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(1033, 662)
        Me.SplitContainer2.SplitterDistance = 112
        Me.SplitContainer2.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(878, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 19)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "←クリックして絞込"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '部署人数DataGridView
        '
        Me.部署人数DataGridView.AllowUserToAddRows = False
        Me.部署人数DataGridView.AllowUserToDeleteRows = False
        Me.部署人数DataGridView.AllowUserToOrderColumns = True
        Me.部署人数DataGridView.AllowUserToResizeRows = False
        Me.部署人数DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.部署人数DataGridView.Location = New System.Drawing.Point(122, 12)
        Me.部署人数DataGridView.Name = "部署人数DataGridView"
        Me.部署人数DataGridView.ReadOnly = True
        Me.部署人数DataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.部署人数DataGridView.RowTemplate.Height = 35
        Me.部署人数DataGridView.Size = New System.Drawing.Size(750, 95)
        Me.部署人数DataGridView.TabIndex = 81
        '
        'DisplayAllButton
        '
        Me.DisplayAllButton.BackColor = System.Drawing.Color.Gainsboro
        Me.DisplayAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.DisplayAllButton.FlatAppearance.BorderSize = 2
        Me.DisplayAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayAllButton.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DisplayAllButton.Location = New System.Drawing.Point(15, 80)
        Me.DisplayAllButton.Name = "DisplayAllButton"
        Me.DisplayAllButton.Size = New System.Drawing.Size(101, 29)
        Me.DisplayAllButton.TabIndex = 84
        Me.DisplayAllButton.Text = "絞込解除"
        Me.DisplayAllButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 38)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "合計人数" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(本日現在)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '合計人数TextBox
        '
        Me.合計人数TextBox.BackColor = System.Drawing.Color.White
        Me.合計人数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.合計人数TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.合計人数TextBox.Location = New System.Drawing.Point(15, 53)
        Me.合計人数TextBox.Name = "合計人数TextBox"
        Me.合計人数TextBox.ReadOnly = True
        Me.合計人数TextBox.Size = New System.Drawing.Size(101, 26)
        Me.合計人数TextBox.TabIndex = 82
        Me.合計人数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(898, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(123, 51)
        Me.ButtonClose.TabIndex = 80
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.LargeChange = 1
        Me.VScrollBar1.Location = New System.Drawing.Point(998, 0)
        Me.VScrollBar1.Maximum = 0
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(35, 546)
        Me.VScrollBar1.TabIndex = 1
        '
        '一覧表示DataGridView
        '
        Me.一覧表示DataGridView.AllowUserToAddRows = False
        Me.一覧表示DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.一覧表示DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.一覧表示DataGridView.AutoGenerateColumns = False
        Me.一覧表示DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.一覧表示DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.詳細, Me.工事番号DataGridViewTextBoxColumn, Me.工事名DataGridViewTextBoxColumn, Me.数量DataGridViewTextBoxColumn, Me.実績工数DataGridViewTextBoxColumn, Me.予算工数DataGridViewTextBoxColumn, Me.予定始DataGridViewTextBoxColumn, Me.予定終DataGridViewTextBoxColumn, Me.部署ＩＤDataGridViewTextBoxColumn})
        Me.一覧表示DataGridView.DataSource = Me.表示用BindingSource
        Me.一覧表示DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.一覧表示DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.一覧表示DataGridView.Name = "一覧表示DataGridView"
        Me.一覧表示DataGridView.ReadOnly = True
        Me.一覧表示DataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.一覧表示DataGridView.RowTemplate.Height = 42
        Me.一覧表示DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.一覧表示DataGridView.Size = New System.Drawing.Size(1033, 546)
        Me.一覧表示DataGridView.TabIndex = 0
        '
        '詳細
        '
        Me.詳細.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.詳細.HeaderText = "詳細"
        Me.詳細.Name = "詳細"
        Me.詳細.ReadOnly = True
        Me.詳細.Width = 70
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
        Me.工事名DataGridViewTextBoxColumn.Width = 200
        '
        '数量DataGridViewTextBoxColumn
        '
        Me.数量DataGridViewTextBoxColumn.DataPropertyName = "数量"
        Me.数量DataGridViewTextBoxColumn.DividerWidth = 2
        Me.数量DataGridViewTextBoxColumn.HeaderText = "数量"
        Me.数量DataGridViewTextBoxColumn.Name = "数量DataGridViewTextBoxColumn"
        Me.数量DataGridViewTextBoxColumn.ReadOnly = True
        '
        '実績工数DataGridViewTextBoxColumn
        '
        Me.実績工数DataGridViewTextBoxColumn.DataPropertyName = "実績工数"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle2.Format = "N1"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.実績工数DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.実績工数DataGridViewTextBoxColumn.HeaderText = "実績工数"
        Me.実績工数DataGridViewTextBoxColumn.Name = "実績工数DataGridViewTextBoxColumn"
        Me.実績工数DataGridViewTextBoxColumn.ReadOnly = True
        '
        '予算工数DataGridViewTextBoxColumn
        '
        Me.予算工数DataGridViewTextBoxColumn.DataPropertyName = "予算工数"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.Format = "N1"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.予算工数DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.予算工数DataGridViewTextBoxColumn.DividerWidth = 2
        Me.予算工数DataGridViewTextBoxColumn.HeaderText = "予算工数"
        Me.予算工数DataGridViewTextBoxColumn.Name = "予算工数DataGridViewTextBoxColumn"
        Me.予算工数DataGridViewTextBoxColumn.ReadOnly = True
        '
        '予定始DataGridViewTextBoxColumn
        '
        Me.予定始DataGridViewTextBoxColumn.DataPropertyName = "予定始"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "MM/dd"
        Me.予定始DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.予定始DataGridViewTextBoxColumn.HeaderText = "予定始"
        Me.予定始DataGridViewTextBoxColumn.Name = "予定始DataGridViewTextBoxColumn"
        Me.予定始DataGridViewTextBoxColumn.ReadOnly = True
        '
        '予定終DataGridViewTextBoxColumn
        '
        Me.予定終DataGridViewTextBoxColumn.DataPropertyName = "予定終"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "MM/dd"
        Me.予定終DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.予定終DataGridViewTextBoxColumn.HeaderText = "予定終"
        Me.予定終DataGridViewTextBoxColumn.Name = "予定終DataGridViewTextBoxColumn"
        Me.予定終DataGridViewTextBoxColumn.ReadOnly = True
        '
        '部署ＩＤDataGridViewTextBoxColumn
        '
        Me.部署ＩＤDataGridViewTextBoxColumn.DataPropertyName = "部署ＩＤ"
        Me.部署ＩＤDataGridViewTextBoxColumn.HeaderText = "部署ＩＤ"
        Me.部署ＩＤDataGridViewTextBoxColumn.Name = "部署ＩＤDataGridViewTextBoxColumn"
        Me.部署ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.部署ＩＤDataGridViewTextBoxColumn.Visible = False
        '
        '表示用BindingSource
        '
        Me.表示用BindingSource.DataMember = "工事別実績予定日付一覧表示用dtbl"
        Me.表示用BindingSource.DataSource = Me.ConstructionWorkAndDateDataSet
        '
        '工事別日程予算一覧Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "工事別日程予算一覧Form"
        Me.Text = "工事別日程予算実績一覧"
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstructionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事取引先最新dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstructionWorkAndDateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工場内部署人数dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事別実績予定日付一覧dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.部署人数DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.一覧表示DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.表示用BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelConstructionNum As System.Windows.Forms.Label
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
    Friend WithEvents ConstructionDataSet As FujiSysForFactory3.ConstructionDataSet
    Friend WithEvents 工事取引先最新dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事取引先最新dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter
    Friend WithEvents TableAdapterManager As FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 工事生管担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事生管担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter
    Friend WithEvents 受注営業担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 受注営業担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter
    Friend WithEvents ConstructionWorkAndDateDataSet As FujiSysForFactory3.ConstructionWorkAndDateDataSet
    Friend WithEvents 工場内部署人数dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工場内部署人数dtblTableAdapter As FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.工場内部署人数dtblTableAdapter
    Friend WithEvents TableAdapterManager1 As FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 工事別実績予定日付一覧dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事別実績予定日付一覧dtblTableAdapter As FujiSysForFactory3.ConstructionWorkAndDateDataSetTableAdapters.工事別実績予定日付一覧dtblTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ButtonGo As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents 部署人数DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DisplayAllButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents 合計人数TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 表示用BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 一覧表示DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents 詳細 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents 工事番号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 数量DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 実績工数DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 予算工数DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 予定始DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 予定終DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 部署ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
