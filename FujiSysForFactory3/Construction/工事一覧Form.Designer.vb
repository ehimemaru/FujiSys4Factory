<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 工事一覧Form
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PmStaffIDComboBox = New System.Windows.Forms.ComboBox()
        Me.工事生管担当BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConstructionDataSet1 = New FujiSysForFactory3.ConstructionDataSet()
        Me.SalesStaffIDComboBox = New System.Windows.Forms.ComboBox()
        Me.受注営業担当BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelConstructionNum = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.OutworkExitenceTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonOpenOutWork = New System.Windows.Forms.Button()
        Me.ConstructionCompleteTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonOpenConstrucitonComplete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputedDateBMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonOpenDateDialog = New System.Windows.Forms.Button()
        Me.InputedDateAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonOpenConstDialog = New System.Windows.Forms.Button()
        Me.ConstructionNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.工事一覧DataGridView = New System.Windows.Forms.DataGridView()
        Me.選択 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.工事番号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.取引先略称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.数量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.社内予算工数DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程始DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程終DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事完了日DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工場出荷分割数DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.営業社員ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.生管社員ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.設計有無DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.社外工事有無DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.入力日時DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.営業確定日時DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.生管確定日時DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事一覧BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事生管担当dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter()
        Me.受注営業担当dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter()
        Me.工事一覧dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事一覧dtblTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.工事生管担当BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstructionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.受注営業担当BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事一覧DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事一覧BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.PmStaffIDComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SalesStaffIDComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelConstructionNum)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OutworkExitenceTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenOutWork)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConstructionCompleteTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenConstrucitonComplete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateBMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenDateDialog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateAMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenConstDialog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConstructionNoMaskedTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.HScrollBar1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.VScrollBar1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.工事一覧DataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1261, 595)
        Me.SplitContainer1.SplitterDistance = 89
        Me.SplitContainer1.TabIndex = 0
        '
        'PmStaffIDComboBox
        '
        Me.PmStaffIDComboBox.DataSource = Me.工事生管担当BindingSource
        Me.PmStaffIDComboBox.DisplayMember = "社員名"
        Me.PmStaffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PmStaffIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PmStaffIDComboBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PmStaffIDComboBox.FormattingEnabled = True
        Me.PmStaffIDComboBox.Location = New System.Drawing.Point(618, 51)
        Me.PmStaffIDComboBox.Name = "PmStaffIDComboBox"
        Me.PmStaffIDComboBox.Size = New System.Drawing.Size(164, 27)
        Me.PmStaffIDComboBox.TabIndex = 56
        Me.PmStaffIDComboBox.ValueMember = "社員ＩＤ"
        '
        '工事生管担当BindingSource
        '
        Me.工事生管担当BindingSource.DataMember = "工事生管担当dtbl"
        Me.工事生管担当BindingSource.DataSource = Me.ConstructionDataSet1
        '
        'ConstructionDataSet1
        '
        Me.ConstructionDataSet1.DataSetName = "ConstructionDataSet"
        Me.ConstructionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesStaffIDComboBox
        '
        Me.SalesStaffIDComboBox.DataSource = Me.受注営業担当BindingSource
        Me.SalesStaffIDComboBox.DisplayMember = "社員名"
        Me.SalesStaffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SalesStaffIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SalesStaffIDComboBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SalesStaffIDComboBox.FormattingEnabled = True
        Me.SalesStaffIDComboBox.Location = New System.Drawing.Point(618, 14)
        Me.SalesStaffIDComboBox.Name = "SalesStaffIDComboBox"
        Me.SalesStaffIDComboBox.Size = New System.Drawing.Size(164, 27)
        Me.SalesStaffIDComboBox.TabIndex = 55
        Me.SalesStaffIDComboBox.ValueMember = "社員ＩＤ"
        '
        '受注営業担当BindingSource
        '
        Me.受注営業担当BindingSource.DataMember = "受注営業担当dtbl"
        Me.受注営業担当BindingSource.DataSource = Me.ConstructionDataSet1
        '
        'LabelConstructionNum
        '
        Me.LabelConstructionNum.BackColor = System.Drawing.Color.Gray
        Me.LabelConstructionNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConstructionNum.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelConstructionNum.ForeColor = System.Drawing.Color.White
        Me.LabelConstructionNum.Location = New System.Drawing.Point(868, 49)
        Me.LabelConstructionNum.Name = "LabelConstructionNum"
        Me.LabelConstructionNum.Size = New System.Drawing.Size(171, 32)
        Me.LabelConstructionNum.TabIndex = 65
        Me.LabelConstructionNum.Text = "工事件数：0"
        Me.LabelConstructionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(1168, 13)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(85, 69)
        Me.ButtonClose.TabIndex = 64
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'OutworkExitenceTextBox
        '
        Me.OutworkExitenceTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.OutworkExitenceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutworkExitenceTextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OutworkExitenceTextBox.Location = New System.Drawing.Point(939, 11)
        Me.OutworkExitenceTextBox.Name = "OutworkExitenceTextBox"
        Me.OutworkExitenceTextBox.ReadOnly = True
        Me.OutworkExitenceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.OutworkExitenceTextBox.TabIndex = 62
        Me.OutworkExitenceTextBox.Text = "全て"
        '
        'ButtonOpenOutWork
        '
        Me.ButtonOpenOutWork.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenOutWork.FlatAppearance.BorderSize = 2
        Me.ButtonOpenOutWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenOutWork.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonOpenOutWork.Location = New System.Drawing.Point(802, 9)
        Me.ButtonOpenOutWork.Name = "ButtonOpenOutWork"
        Me.ButtonOpenOutWork.Size = New System.Drawing.Size(131, 30)
        Me.ButtonOpenOutWork.TabIndex = 61
        Me.ButtonOpenOutWork.Text = "外業有無："
        Me.ButtonOpenOutWork.UseVisualStyleBackColor = False
        '
        'ConstructionCompleteTextBox
        '
        Me.ConstructionCompleteTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ConstructionCompleteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConstructionCompleteTextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ConstructionCompleteTextBox.Location = New System.Drawing.Point(454, 13)
        Me.ConstructionCompleteTextBox.Name = "ConstructionCompleteTextBox"
        Me.ConstructionCompleteTextBox.ReadOnly = True
        Me.ConstructionCompleteTextBox.Size = New System.Drawing.Size(60, 26)
        Me.ConstructionCompleteTextBox.TabIndex = 60
        Me.ConstructionCompleteTextBox.Text = "未完"
        '
        'ButtonOpenConstrucitonComplete
        '
        Me.ButtonOpenConstrucitonComplete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenConstrucitonComplete.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstrucitonComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstrucitonComplete.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonOpenConstrucitonComplete.Location = New System.Drawing.Point(317, 11)
        Me.ButtonOpenConstrucitonComplete.Name = "ButtonOpenConstrucitonComplete"
        Me.ButtonOpenConstrucitonComplete.Size = New System.Drawing.Size(131, 30)
        Me.ButtonOpenConstrucitonComplete.TabIndex = 59
        Me.ButtonOpenConstrucitonComplete.Text = "工事完了："
        Me.ButtonOpenConstrucitonComplete.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(522, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "生管担当："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(522, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "営業担当："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "～"
        '
        'InputedDateBMaskedTextBox
        '
        Me.InputedDateBMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateBMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateBMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateBMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateBMaskedTextBox.Location = New System.Drawing.Point(350, 52)
        Me.InputedDateBMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateBMaskedTextBox.Name = "InputedDateBMaskedTextBox"
        Me.InputedDateBMaskedTextBox.ReadOnly = True
        Me.InputedDateBMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.InputedDateBMaskedTextBox.TabIndex = 53
        Me.InputedDateBMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateBMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonOpenDateDialog
        '
        Me.ButtonOpenDateDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenDateDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenDateDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenDateDialog.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonOpenDateDialog.Location = New System.Drawing.Point(3, 53)
        Me.ButtonOpenDateDialog.Name = "ButtonOpenDateDialog"
        Me.ButtonOpenDateDialog.Size = New System.Drawing.Size(131, 30)
        Me.ButtonOpenDateDialog.TabIndex = 52
        Me.ButtonOpenDateDialog.Text = "工程始："
        Me.ButtonOpenDateDialog.UseVisualStyleBackColor = False
        '
        'InputedDateAMaskedTextBox
        '
        Me.InputedDateAMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateAMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateAMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateAMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateAMaskedTextBox.Location = New System.Drawing.Point(140, 52)
        Me.InputedDateAMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateAMaskedTextBox.Name = "InputedDateAMaskedTextBox"
        Me.InputedDateAMaskedTextBox.ReadOnly = True
        Me.InputedDateAMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.InputedDateAMaskedTextBox.TabIndex = 51
        Me.InputedDateAMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonOpenConstDialog
        '
        Me.ButtonOpenConstDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenConstDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstDialog.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonOpenConstDialog.Location = New System.Drawing.Point(3, 13)
        Me.ButtonOpenConstDialog.Name = "ButtonOpenConstDialog"
        Me.ButtonOpenConstDialog.Size = New System.Drawing.Size(131, 30)
        Me.ButtonOpenConstDialog.TabIndex = 11
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
        Me.ConstructionNoMaskedTextBox.Location = New System.Drawing.Point(140, 13)
        Me.ConstructionNoMaskedTextBox.Mask = ">00A-&000-00"
        Me.ConstructionNoMaskedTextBox.Name = "ConstructionNoMaskedTextBox"
        Me.ConstructionNoMaskedTextBox.ReadOnly = True
        Me.ConstructionNoMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.ConstructionNoMaskedTextBox.TabIndex = 10
        Me.ConstructionNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 458)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(1217, 44)
        Me.HScrollBar1.TabIndex = 2
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(1217, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(44, 502)
        Me.VScrollBar1.TabIndex = 1
        '
        '工事一覧DataGridView
        '
        Me.工事一覧DataGridView.AllowUserToAddRows = False
        Me.工事一覧DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.工事一覧DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.工事一覧DataGridView.AutoGenerateColumns = False
        Me.工事一覧DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.工事一覧DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.選択, Me.工事番号DataGridViewTextBoxColumn, Me.取引先略称DataGridViewTextBoxColumn, Me.工事名DataGridViewTextBoxColumn, Me.数量DataGridViewTextBoxColumn, Me.社内予算工数DataGridViewTextBoxColumn, Me.工程始DataGridViewTextBoxColumn, Me.工程終DataGridViewTextBoxColumn, Me.工事完了日DataGridViewTextBoxColumn, Me.工場出荷分割数DataGridViewTextBoxColumn, Me.営業社員ＩＤDataGridViewTextBoxColumn, Me.生管社員ＩＤDataGridViewTextBoxColumn, Me.設計有無DataGridViewTextBoxColumn, Me.社外工事有無DataGridViewTextBoxColumn, Me.入力日時DataGridViewTextBoxColumn, Me.営業確定日時DataGridViewTextBoxColumn, Me.生管確定日時DataGridViewTextBoxColumn})
        Me.工事一覧DataGridView.DataSource = Me.工事一覧BindingSource
        Me.工事一覧DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.工事一覧DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.工事一覧DataGridView.Name = "工事一覧DataGridView"
        Me.工事一覧DataGridView.ReadOnly = True
        Me.工事一覧DataGridView.RowHeadersWidth = 10
        Me.工事一覧DataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事一覧DataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.工事一覧DataGridView.RowTemplate.Height = 50
        Me.工事一覧DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.工事一覧DataGridView.Size = New System.Drawing.Size(1261, 502)
        Me.工事一覧DataGridView.TabIndex = 0
        '
        '選択
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.選択.DefaultCellStyle = DataGridViewCellStyle2
        Me.選択.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.選択.Frozen = True
        Me.選択.HeaderText = "選択"
        Me.選択.Name = "選択"
        Me.選択.ReadOnly = True
        Me.選択.Width = 60
        '
        '工事番号DataGridViewTextBoxColumn
        '
        Me.工事番号DataGridViewTextBoxColumn.DataPropertyName = "工事番号"
        Me.工事番号DataGridViewTextBoxColumn.Frozen = True
        Me.工事番号DataGridViewTextBoxColumn.HeaderText = "工事番号"
        Me.工事番号DataGridViewTextBoxColumn.Name = "工事番号DataGridViewTextBoxColumn"
        Me.工事番号DataGridViewTextBoxColumn.ReadOnly = True
        Me.工事番号DataGridViewTextBoxColumn.Width = 120
        '
        '取引先略称DataGridViewTextBoxColumn
        '
        Me.取引先略称DataGridViewTextBoxColumn.DataPropertyName = "取引先略称"
        Me.取引先略称DataGridViewTextBoxColumn.HeaderText = "取引先"
        Me.取引先略称DataGridViewTextBoxColumn.Name = "取引先略称DataGridViewTextBoxColumn"
        Me.取引先略称DataGridViewTextBoxColumn.ReadOnly = True
        '
        '工事名DataGridViewTextBoxColumn
        '
        Me.工事名DataGridViewTextBoxColumn.DataPropertyName = "工事名"
        Me.工事名DataGridViewTextBoxColumn.HeaderText = "工事名"
        Me.工事名DataGridViewTextBoxColumn.Name = "工事名DataGridViewTextBoxColumn"
        Me.工事名DataGridViewTextBoxColumn.ReadOnly = True
        Me.工事名DataGridViewTextBoxColumn.Width = 150
        '
        '数量DataGridViewTextBoxColumn
        '
        Me.数量DataGridViewTextBoxColumn.DataPropertyName = "数量"
        Me.数量DataGridViewTextBoxColumn.DividerWidth = 2
        Me.数量DataGridViewTextBoxColumn.HeaderText = "数量"
        Me.数量DataGridViewTextBoxColumn.Name = "数量DataGridViewTextBoxColumn"
        Me.数量DataGridViewTextBoxColumn.ReadOnly = True
        '
        '社内予算工数DataGridViewTextBoxColumn
        '
        Me.社内予算工数DataGridViewTextBoxColumn.DataPropertyName = "社内予算工数"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N1"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.社内予算工数DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.社内予算工数DataGridViewTextBoxColumn.HeaderText = "予算工数"
        Me.社内予算工数DataGridViewTextBoxColumn.Name = "社内予算工数DataGridViewTextBoxColumn"
        Me.社内予算工数DataGridViewTextBoxColumn.ReadOnly = True
        '
        '工程始DataGridViewTextBoxColumn
        '
        Me.工程始DataGridViewTextBoxColumn.DataPropertyName = "工程始"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "MM/dd"
        Me.工程始DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.工程始DataGridViewTextBoxColumn.HeaderText = "工程始"
        Me.工程始DataGridViewTextBoxColumn.Name = "工程始DataGridViewTextBoxColumn"
        Me.工程始DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程始DataGridViewTextBoxColumn.Width = 65
        '
        '工程終DataGridViewTextBoxColumn
        '
        Me.工程終DataGridViewTextBoxColumn.DataPropertyName = "工程終"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "MM/dd"
        Me.工程終DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.工程終DataGridViewTextBoxColumn.DividerWidth = 2
        Me.工程終DataGridViewTextBoxColumn.HeaderText = "工程終"
        Me.工程終DataGridViewTextBoxColumn.Name = "工程終DataGridViewTextBoxColumn"
        Me.工程終DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程終DataGridViewTextBoxColumn.Width = 65
        '
        '工事完了日DataGridViewTextBoxColumn
        '
        Me.工事完了日DataGridViewTextBoxColumn.DataPropertyName = "工事完了日"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "MM/dd"
        Me.工事完了日DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.工事完了日DataGridViewTextBoxColumn.HeaderText = "完了日"
        Me.工事完了日DataGridViewTextBoxColumn.Name = "工事完了日DataGridViewTextBoxColumn"
        Me.工事完了日DataGridViewTextBoxColumn.ReadOnly = True
        Me.工事完了日DataGridViewTextBoxColumn.Width = 65
        '
        '工場出荷分割数DataGridViewTextBoxColumn
        '
        Me.工場出荷分割数DataGridViewTextBoxColumn.DataPropertyName = "工場出荷分割数"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        Me.工場出荷分割数DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.工場出荷分割数DataGridViewTextBoxColumn.HeaderText = "出荷数"
        Me.工場出荷分割数DataGridViewTextBoxColumn.Name = "工場出荷分割数DataGridViewTextBoxColumn"
        Me.工場出荷分割数DataGridViewTextBoxColumn.ReadOnly = True
        Me.工場出荷分割数DataGridViewTextBoxColumn.Width = 65
        '
        '営業社員ＩＤDataGridViewTextBoxColumn
        '
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DataPropertyName = "営業社員ＩＤ"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DataSource = Me.受注営業担当BindingSource
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DisplayMember = "社員名"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.営業社員ＩＤDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.営業社員ＩＤDataGridViewTextBoxColumn.HeaderText = "営業社員"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.Name = "営業社員ＩＤDataGridViewTextBoxColumn"
        Me.営業社員ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.営業社員ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.営業社員ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.営業社員ＩＤDataGridViewTextBoxColumn.ValueMember = "社員ＩＤ"
        '
        '生管社員ＩＤDataGridViewTextBoxColumn
        '
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DataPropertyName = "生管社員ＩＤ"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DataSource = Me.工事生管担当BindingSource
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DisplayMember = "社員名"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.生管社員ＩＤDataGridViewTextBoxColumn.DividerWidth = 2
        Me.生管社員ＩＤDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.生管社員ＩＤDataGridViewTextBoxColumn.HeaderText = "生管社員"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.Name = "生管社員ＩＤDataGridViewTextBoxColumn"
        Me.生管社員ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.生管社員ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.生管社員ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.生管社員ＩＤDataGridViewTextBoxColumn.ValueMember = "社員ＩＤ"
        '
        '設計有無DataGridViewTextBoxColumn
        '
        Me.設計有無DataGridViewTextBoxColumn.DataPropertyName = "設計有無"
        Me.設計有無DataGridViewTextBoxColumn.FalseValue = "0"
        Me.設計有無DataGridViewTextBoxColumn.HeaderText = "設計"
        Me.設計有無DataGridViewTextBoxColumn.Name = "設計有無DataGridViewTextBoxColumn"
        Me.設計有無DataGridViewTextBoxColumn.ReadOnly = True
        Me.設計有無DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.設計有無DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.設計有無DataGridViewTextBoxColumn.TrueValue = "1"
        Me.設計有無DataGridViewTextBoxColumn.Width = 65
        '
        '社外工事有無DataGridViewTextBoxColumn
        '
        Me.社外工事有無DataGridViewTextBoxColumn.DataPropertyName = "社外工事有無"
        Me.社外工事有無DataGridViewTextBoxColumn.FalseValue = "0"
        Me.社外工事有無DataGridViewTextBoxColumn.HeaderText = "外業"
        Me.社外工事有無DataGridViewTextBoxColumn.Name = "社外工事有無DataGridViewTextBoxColumn"
        Me.社外工事有無DataGridViewTextBoxColumn.ReadOnly = True
        Me.社外工事有無DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.社外工事有無DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.社外工事有無DataGridViewTextBoxColumn.TrueValue = "1"
        Me.社外工事有無DataGridViewTextBoxColumn.Width = 65
        '
        '入力日時DataGridViewTextBoxColumn
        '
        Me.入力日時DataGridViewTextBoxColumn.DataPropertyName = "入力日時"
        DataGridViewCellStyle8.Format = "MM/dd"
        Me.入力日時DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.入力日時DataGridViewTextBoxColumn.HeaderText = "入力日"
        Me.入力日時DataGridViewTextBoxColumn.Name = "入力日時DataGridViewTextBoxColumn"
        Me.入力日時DataGridViewTextBoxColumn.ReadOnly = True
        Me.入力日時DataGridViewTextBoxColumn.Width = 65
        '
        '営業確定日時DataGridViewTextBoxColumn
        '
        Me.営業確定日時DataGridViewTextBoxColumn.DataPropertyName = "営業確定日時"
        DataGridViewCellStyle9.Format = "MM/dd"
        Me.営業確定日時DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.営業確定日時DataGridViewTextBoxColumn.HeaderText = "営確日"
        Me.営業確定日時DataGridViewTextBoxColumn.Name = "営業確定日時DataGridViewTextBoxColumn"
        Me.営業確定日時DataGridViewTextBoxColumn.ReadOnly = True
        Me.営業確定日時DataGridViewTextBoxColumn.Width = 65
        '
        '生管確定日時DataGridViewTextBoxColumn
        '
        Me.生管確定日時DataGridViewTextBoxColumn.DataPropertyName = "生管確定日時"
        DataGridViewCellStyle10.Format = "MM/dd"
        Me.生管確定日時DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.生管確定日時DataGridViewTextBoxColumn.HeaderText = "生確日"
        Me.生管確定日時DataGridViewTextBoxColumn.Name = "生管確定日時DataGridViewTextBoxColumn"
        Me.生管確定日時DataGridViewTextBoxColumn.ReadOnly = True
        Me.生管確定日時DataGridViewTextBoxColumn.Width = 65
        '
        '工事一覧BindingSource
        '
        Me.工事一覧BindingSource.DataMember = "工事一覧dtbl"
        Me.工事一覧BindingSource.DataSource = Me.ConstructionDataSet1
        '
        '工事生管担当dtblTableAdapter1
        '
        Me.工事生管担当dtblTableAdapter1.ClearBeforeFill = True
        '
        '受注営業担当dtblTableAdapter1
        '
        Me.受注営業担当dtblTableAdapter1.ClearBeforeFill = True
        '
        '工事一覧dtblTableAdapter1
        '
        Me.工事一覧dtblTableAdapter1.ClearBeforeFill = True
        '
        '工事一覧Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 595)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "工事一覧Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "工事一覧(製造のみ)"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.工事生管担当BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstructionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.受注営業担当BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事一覧DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事一覧BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ConstructionNoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonOpenConstDialog As System.Windows.Forms.Button
    Friend WithEvents ButtonOpenDateDialog As System.Windows.Forms.Button
    Friend WithEvents InputedDateAMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InputedDateBMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents 工事生管担当dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter
    Friend WithEvents 受注営業担当dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter
    Friend WithEvents ConstructionDataSet1 As FujiSysForFactory3.ConstructionDataSet
    Friend WithEvents 受注営業担当BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事生管担当BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesStaffIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PmStaffIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ConstructionCompleteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOpenConstrucitonComplete As System.Windows.Forms.Button
    Friend WithEvents OutworkExitenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOpenOutWork As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents 工事一覧DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 工事一覧BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事一覧dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事一覧dtblTableAdapter
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents LabelConstructionNum As System.Windows.Forms.Label
    Friend WithEvents 選択 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents 工事番号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 取引先略称DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 数量DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 社内予算工数DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程始DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程終DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事完了日DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工場出荷分割数DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 営業社員ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 生管社員ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 設計有無DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents 社外工事有無DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents 入力日時DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 営業確定日時DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 生管確定日時DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
