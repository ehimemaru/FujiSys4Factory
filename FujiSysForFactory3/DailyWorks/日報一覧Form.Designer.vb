<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 日報一覧Form
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
        Dim 表示用Label As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.作業時間合計TextBox = New System.Windows.Forms.TextBox()
        Me.DisplayAllButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.合計人数TextBox = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.現社員表示用ComboBox = New System.Windows.Forms.ComboBox()
        Me.日報現社員dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DailyWorksDataSet = New FujiSysForFactory3.DailyWorksDataSet()
        Me.InputedDateAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.InputedDateBMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.部署人数DataGridView = New System.Windows.Forms.DataGridView()
        Me.ConstructionNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonOpenDateDialog = New System.Windows.Forms.Button()
        Me.ButtonOpenConstDialog = New System.Windows.Forms.Button()
        Me.日報一覧dtblDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.日報歴代社員dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日報一覧dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.日報現社員dtblTableAdapter = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報現社員dtblTableAdapter()
        Me.TableAdapterManager = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.TableAdapterManager()
        Me.日報一覧dtblTableAdapter = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報一覧dtblTableAdapter()
        Me.日報工程dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.日報工程dtblTableAdapter = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報工程dtblTableAdapter()
        Me.日報部署dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.日報部署dtblTableAdapter = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報部署dtblTableAdapter()
        Me.日報不適合dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.日報不適合dtblTableAdapter = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報不適合dtblTableAdapter()
        Me.日報歴代社員dtblTableAdapter = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報歴代社員dtblTableAdapter()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        表示用Label = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.日報現社員dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.部署人数DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報一覧dtblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報歴代社員dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報一覧dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報工程dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報部署dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報不適合dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '表示用Label
        '
        表示用Label.AutoSize = True
        表示用Label.Location = New System.Drawing.Point(12, 118)
        表示用Label.Name = "表示用Label"
        表示用Label.Size = New System.Drawing.Size(51, 19)
        表示用Label.TabIndex = 60
        表示用Label.Text = "社員:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.作業時間合計TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DisplayAllButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.合計人数TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonClose)
        Me.SplitContainer1.Panel1.Controls.Add(表示用Label)
        Me.SplitContainer1.Panel1.Controls.Add(Me.現社員表示用ComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateAMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateBMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.部署人数DataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConstructionNoMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenDateDialog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenConstDialog)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.VScrollBar1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.日報一覧dtblDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1254, 662)
        Me.SplitContainer1.SplitterDistance = 149
        Me.SplitContainer1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(377, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 19)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "作業時間合計"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '作業時間合計TextBox
        '
        Me.作業時間合計TextBox.BackColor = System.Drawing.Color.White
        Me.作業時間合計TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.作業時間合計TextBox.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.作業時間合計TextBox.Location = New System.Drawing.Point(381, 116)
        Me.作業時間合計TextBox.Name = "作業時間合計TextBox"
        Me.作業時間合計TextBox.ReadOnly = True
        Me.作業時間合計TextBox.Size = New System.Drawing.Size(119, 28)
        Me.作業時間合計TextBox.TabIndex = 69
        Me.作業時間合計TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DisplayAllButton
        '
        Me.DisplayAllButton.BackColor = System.Drawing.Color.Gainsboro
        Me.DisplayAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.DisplayAllButton.FlatAppearance.BorderSize = 2
        Me.DisplayAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayAllButton.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DisplayAllButton.Location = New System.Drawing.Point(707, 14)
        Me.DisplayAllButton.Name = "DisplayAllButton"
        Me.DisplayAllButton.Size = New System.Drawing.Size(101, 30)
        Me.DisplayAllButton.TabIndex = 68
        Me.DisplayAllButton.Text = "部署解除"
        Me.DisplayAllButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(515, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "合計人数"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '合計人数TextBox
        '
        Me.合計人数TextBox.BackColor = System.Drawing.Color.White
        Me.合計人数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.合計人数TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.合計人数TextBox.Location = New System.Drawing.Point(600, 16)
        Me.合計人数TextBox.Name = "合計人数TextBox"
        Me.合計人数TextBox.ReadOnly = True
        Me.合計人数TextBox.Size = New System.Drawing.Size(101, 26)
        Me.合計人数TextBox.TabIndex = 66
        Me.合計人数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(1184, 50)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(69, 88)
        Me.ButtonClose.TabIndex = 65
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        '現社員表示用ComboBox
        '
        Me.現社員表示用ComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.現社員表示用ComboBox.DataSource = Me.日報現社員dtblBindingSource
        Me.現社員表示用ComboBox.DisplayMember = "表示用"
        Me.現社員表示用ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.現社員表示用ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.現社員表示用ComboBox.FormattingEnabled = True
        Me.現社員表示用ComboBox.Location = New System.Drawing.Point(69, 115)
        Me.現社員表示用ComboBox.Name = "現社員表示用ComboBox"
        Me.現社員表示用ComboBox.Size = New System.Drawing.Size(239, 27)
        Me.現社員表示用ComboBox.TabIndex = 61
        Me.現社員表示用ComboBox.ValueMember = "社員ＩＤ"
        '
        '日報現社員dtblBindingSource
        '
        Me.日報現社員dtblBindingSource.DataMember = "日報現社員dtbl"
        Me.日報現社員dtblBindingSource.DataSource = Me.DailyWorksDataSet
        '
        'DailyWorksDataSet
        '
        Me.DailyWorksDataSet.DataSetName = "DailyWorksDataSet"
        Me.DailyWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InputedDateAMaskedTextBox
        '
        Me.InputedDateAMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateAMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateAMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateAMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateAMaskedTextBox.Location = New System.Drawing.Point(144, 41)
        Me.InputedDateAMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateAMaskedTextBox.Name = "InputedDateAMaskedTextBox"
        Me.InputedDateAMaskedTextBox.ReadOnly = True
        Me.InputedDateAMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.InputedDateAMaskedTextBox.TabIndex = 57
        Me.InputedDateAMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'InputedDateBMaskedTextBox
        '
        Me.InputedDateBMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InputedDateBMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateBMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateBMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateBMaskedTextBox.Location = New System.Drawing.Point(336, 41)
        Me.InputedDateBMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateBMaskedTextBox.Name = "InputedDateBMaskedTextBox"
        Me.InputedDateBMaskedTextBox.ReadOnly = True
        Me.InputedDateBMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.InputedDateBMaskedTextBox.TabIndex = 59
        Me.InputedDateBMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateBMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 19)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "～"
        '
        '部署人数DataGridView
        '
        Me.部署人数DataGridView.AllowUserToAddRows = False
        Me.部署人数DataGridView.AllowUserToDeleteRows = False
        Me.部署人数DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.部署人数DataGridView.Location = New System.Drawing.Point(506, 49)
        Me.部署人数DataGridView.Name = "部署人数DataGridView"
        Me.部署人数DataGridView.ReadOnly = True
        Me.部署人数DataGridView.RowTemplate.Height = 35
        Me.部署人数DataGridView.Size = New System.Drawing.Size(673, 93)
        Me.部署人数DataGridView.TabIndex = 0
        '
        'ConstructionNoMaskedTextBox
        '
        Me.ConstructionNoMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ConstructionNoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConstructionNoMaskedTextBox.Enabled = False
        Me.ConstructionNoMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ConstructionNoMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ConstructionNoMaskedTextBox.Location = New System.Drawing.Point(144, 78)
        Me.ConstructionNoMaskedTextBox.Mask = ">00A-&000-00"
        Me.ConstructionNoMaskedTextBox.Name = "ConstructionNoMaskedTextBox"
        Me.ConstructionNoMaskedTextBox.ReadOnly = True
        Me.ConstructionNoMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.ConstructionNoMaskedTextBox.TabIndex = 55
        Me.ConstructionNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonOpenDateDialog
        '
        Me.ButtonOpenDateDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenDateDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenDateDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenDateDialog.Location = New System.Drawing.Point(7, 41)
        Me.ButtonOpenDateDialog.Name = "ButtonOpenDateDialog"
        Me.ButtonOpenDateDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenDateDialog.TabIndex = 58
        Me.ButtonOpenDateDialog.Text = "作業日："
        Me.ButtonOpenDateDialog.UseVisualStyleBackColor = False
        '
        'ButtonOpenConstDialog
        '
        Me.ButtonOpenConstDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenConstDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstDialog.Location = New System.Drawing.Point(7, 78)
        Me.ButtonOpenConstDialog.Name = "ButtonOpenConstDialog"
        Me.ButtonOpenConstDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenConstDialog.TabIndex = 56
        Me.ButtonOpenConstDialog.Text = "工事番号："
        Me.ButtonOpenConstDialog.UseVisualStyleBackColor = False
        '
        '日報一覧dtblDataGridView
        '
        Me.日報一覧dtblDataGridView.AllowUserToAddRows = False
        Me.日報一覧dtblDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.日報一覧dtblDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.日報一覧dtblDataGridView.AutoGenerateColumns = False
        Me.日報一覧dtblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.日報一覧dtblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.日報一覧dtblDataGridView.DataSource = Me.日報一覧dtblBindingSource
        Me.日報一覧dtblDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.日報一覧dtblDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.日報一覧dtblDataGridView.Name = "日報一覧dtblDataGridView"
        Me.日報一覧dtblDataGridView.ReadOnly = True
        Me.日報一覧dtblDataGridView.RowTemplate.Height = 35
        Me.日報一覧dtblDataGridView.Size = New System.Drawing.Size(1254, 509)
        Me.日報一覧dtblDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "作業日"
        Me.DataGridViewTextBoxColumn1.HeaderText = "作業日"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "表示順"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "順"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 55
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "社員ＩＤ"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.日報歴代社員dtblBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "社員名"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn3.HeaderText = "社員"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "社員ＩＤ"
        Me.DataGridViewTextBoxColumn3.Width = 160
        '
        '日報歴代社員dtblBindingSource
        '
        Me.日報歴代社員dtblBindingSource.DataMember = "日報歴代社員dtbl"
        Me.日報歴代社員dtblBindingSource.DataSource = Me.DailyWorksDataSet
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "工事番号"
        Me.DataGridViewTextBoxColumn4.HeaderText = "工事番号"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "作業時間"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "作業時間"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "工程ＩＤ"
        Me.DataGridViewTextBoxColumn6.HeaderText = "工程ＩＤ"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "工程名"
        Me.DataGridViewTextBoxColumn7.HeaderText = "工程名"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "部署ＩＤ"
        Me.DataGridViewTextBoxColumn8.HeaderText = "部署ＩＤ"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "部署名"
        Me.DataGridViewTextBoxColumn9.HeaderText = "部署名"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 120
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "不適合ＩＤ"
        Me.DataGridViewTextBoxColumn10.HeaderText = "不適合ＩＤ"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "不適合名"
        Me.DataGridViewTextBoxColumn11.HeaderText = "不適合名"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 130
        '
        '日報一覧dtblBindingSource
        '
        Me.日報一覧dtblBindingSource.DataMember = "日報一覧dtbl"
        Me.日報一覧dtblBindingSource.DataSource = Me.DailyWorksDataSet
        '
        '日報現社員dtblTableAdapter
        '
        Me.日報現社員dtblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = FujiSysForFactory3.DailyWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.日報不適合dtblTableAdapter = Nothing
        Me.TableAdapterManager.日報会社休日dtblTableAdapter = Nothing
        Me.TableAdapterManager.日報工程dtblTableAdapter = Nothing
        Me.TableAdapterManager.日報工程予算dtblTableAdapter = Nothing
        Me.TableAdapterManager.日報部署dtblTableAdapter = Nothing
        '
        '日報一覧dtblTableAdapter
        '
        Me.日報一覧dtblTableAdapter.ClearBeforeFill = True
        '
        '日報工程dtblBindingSource
        '
        Me.日報工程dtblBindingSource.DataMember = "日報工程dtbl"
        Me.日報工程dtblBindingSource.DataSource = Me.DailyWorksDataSet
        '
        '日報工程dtblTableAdapter
        '
        Me.日報工程dtblTableAdapter.ClearBeforeFill = True
        '
        '日報部署dtblBindingSource
        '
        Me.日報部署dtblBindingSource.DataMember = "日報部署dtbl"
        Me.日報部署dtblBindingSource.DataSource = Me.DailyWorksDataSet
        '
        '日報部署dtblTableAdapter
        '
        Me.日報部署dtblTableAdapter.ClearBeforeFill = True
        '
        '日報不適合dtblBindingSource
        '
        Me.日報不適合dtblBindingSource.DataMember = "日報不適合dtbl"
        Me.日報不適合dtblBindingSource.DataSource = Me.DailyWorksDataSet
        '
        '日報不適合dtblTableAdapter
        '
        Me.日報不適合dtblTableAdapter.ClearBeforeFill = True
        '
        '日報歴代社員dtblTableAdapter
        '
        Me.日報歴代社員dtblTableAdapter.ClearBeforeFill = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(1219, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(35, 509)
        Me.VScrollBar1.TabIndex = 1
        '
        '日報一覧Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "日報一覧Form"
        Me.Text = "日報一覧"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.日報現社員dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.部署人数DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報一覧dtblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報歴代社員dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報一覧dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報工程dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報部署dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報不適合dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents 部署人数DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InputedDateBMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ConstructionNoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonOpenDateDialog As System.Windows.Forms.Button
    Friend WithEvents InputedDateAMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonOpenConstDialog As System.Windows.Forms.Button
    Friend WithEvents DailyWorksDataSet As FujiSysForFactory3.DailyWorksDataSet
    Friend WithEvents 日報現社員dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 日報現社員dtblTableAdapter As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報現社員dtblTableAdapter
    Friend WithEvents TableAdapterManager As FujiSysForFactory3.DailyWorksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 現社員表示用ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 日報一覧dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 日報一覧dtblTableAdapter As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報一覧dtblTableAdapter
    Friend WithEvents 日報一覧dtblDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 日報工程dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 日報工程dtblTableAdapter As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報工程dtblTableAdapter
    Friend WithEvents 日報部署dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 日報部署dtblTableAdapter As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報部署dtblTableAdapter
    Friend WithEvents 日報不適合dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 日報不適合dtblTableAdapter As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報不適合dtblTableAdapter
    Friend WithEvents 日報歴代社員dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 日報歴代社員dtblTableAdapter As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報歴代社員dtblTableAdapter
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisplayAllButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents 合計人数TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents 作業時間合計TextBox As System.Windows.Forms.TextBox
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
End Class
