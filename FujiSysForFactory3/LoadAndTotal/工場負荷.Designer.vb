<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 工場負荷
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.部署人数DataGridView = New System.Windows.Forms.DataGridView()
        Me.InputedDateAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.InputedDateBMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonOpenDateDialog = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.全てRadioButton = New System.Windows.Forms.RadioButton()
        Me.生管確定のみRadioButton = New System.Windows.Forms.RadioButton()
        Me.DisplayAllButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.合計人数TextBox = New System.Windows.Forms.TextBox()
        Me.DisChangeButton = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.工場負荷集計DataGridView = New System.Windows.Forms.DataGridView()
        Me.日付DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.予算通常DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.予算外業DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.予算XYZDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.実績通常DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.実績外業DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.実績XYZDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.予算合計 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.実績合計 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.実績人数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工場負荷集計BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工場負荷DataSet1 = New FujiSysForFactory3.工場負荷DataSet()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.工場負荷Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.工場負荷工程予算dtblTadp1 = New FujiSysForFactory3.工場負荷DataSetTableAdapters.工場負荷工程予算dtblTadp()
        Me.工場負荷日報dtblTadp1 = New FujiSysForFactory3.工場負荷DataSetTableAdapters.工場負荷日報dtblTadp()
        Me.工場部署人数dtblTadp1 = New FujiSysForFactory3.工場負荷DataSetTableAdapters.工場部署人数dtblTadp()
        Me.工場部署人数BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工場実績人数dtblTadp1 = New FujiSysForFactory3.工場負荷DataSetTableAdapters.工場実績人数dtblTadp()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.部署人数DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.工場負荷集計DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工場負荷集計BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工場負荷DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.工場負荷Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工場部署人数BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer1.Panel1.Controls.Add(Me.部署人数DataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateAMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputedDateBMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenDateDialog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DisplayAllButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.合計人数TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DisChangeButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1254, 590)
        Me.SplitContainer1.SplitterDistance = 106
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 8
        '
        '部署人数DataGridView
        '
        Me.部署人数DataGridView.AllowUserToAddRows = False
        Me.部署人数DataGridView.AllowUserToDeleteRows = False
        Me.部署人数DataGridView.AllowUserToOrderColumns = True
        Me.部署人数DataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.部署人数DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.部署人数DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.部署人数DataGridView.Location = New System.Drawing.Point(490, 3)
        Me.部署人数DataGridView.Name = "部署人数DataGridView"
        Me.部署人数DataGridView.ReadOnly = True
        Me.部署人数DataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.部署人数DataGridView.RowTemplate.Height = 35
        Me.部署人数DataGridView.Size = New System.Drawing.Size(635, 95)
        Me.部署人数DataGridView.TabIndex = 12
        '
        'InputedDateAMaskedTextBox
        '
        Me.InputedDateAMaskedTextBox.BackColor = System.Drawing.Color.White
        Me.InputedDateAMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateAMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateAMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateAMaskedTextBox.Location = New System.Drawing.Point(193, 40)
        Me.InputedDateAMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateAMaskedTextBox.Name = "InputedDateAMaskedTextBox"
        Me.InputedDateAMaskedTextBox.ReadOnly = True
        Me.InputedDateAMaskedTextBox.Size = New System.Drawing.Size(148, 26)
        Me.InputedDateAMaskedTextBox.TabIndex = 55
        Me.InputedDateAMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'InputedDateBMaskedTextBox
        '
        Me.InputedDateBMaskedTextBox.BackColor = System.Drawing.Color.White
        Me.InputedDateBMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputedDateBMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputedDateBMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputedDateBMaskedTextBox.Location = New System.Drawing.Point(193, 74)
        Me.InputedDateBMaskedTextBox.Mask = "0000/00/00"
        Me.InputedDateBMaskedTextBox.Name = "InputedDateBMaskedTextBox"
        Me.InputedDateBMaskedTextBox.ReadOnly = True
        Me.InputedDateBMaskedTextBox.Size = New System.Drawing.Size(148, 26)
        Me.InputedDateBMaskedTextBox.TabIndex = 57
        Me.InputedDateBMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputedDateBMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "～"
        '
        'ButtonOpenDateDialog
        '
        Me.ButtonOpenDateDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenDateDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenDateDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenDateDialog.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonOpenDateDialog.Location = New System.Drawing.Point(162, 3)
        Me.ButtonOpenDateDialog.Name = "ButtonOpenDateDialog"
        Me.ButtonOpenDateDialog.Size = New System.Drawing.Size(179, 31)
        Me.ButtonOpenDateDialog.TabIndex = 56
        Me.ButtonOpenDateDialog.Text = "期間："
        Me.ButtonOpenDateDialog.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.全てRadioButton)
        Me.GroupBox1.Controls.Add(Me.生管確定のみRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(509, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(78, 35)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        '全てRadioButton
        '
        Me.全てRadioButton.AutoSize = True
        Me.全てRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.全てRadioButton.Location = New System.Drawing.Point(5, 21)
        Me.全てRadioButton.Name = "全てRadioButton"
        Me.全てRadioButton.Size = New System.Drawing.Size(43, 16)
        Me.全てRadioButton.TabIndex = 1
        Me.全てRadioButton.Text = "全て"
        Me.全てRadioButton.UseVisualStyleBackColor = True
        Me.全てRadioButton.Visible = False
        '
        '生管確定のみRadioButton
        '
        Me.生管確定のみRadioButton.AutoSize = True
        Me.生管確定のみRadioButton.Checked = True
        Me.生管確定のみRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.生管確定のみRadioButton.Location = New System.Drawing.Point(5, 8)
        Me.生管確定のみRadioButton.Name = "生管確定のみRadioButton"
        Me.生管確定のみRadioButton.Size = New System.Drawing.Size(91, 16)
        Me.生管確定のみRadioButton.TabIndex = 0
        Me.生管確定のみRadioButton.TabStop = True
        Me.生管確定のみRadioButton.Text = "生管確定のみ"
        Me.生管確定のみRadioButton.UseVisualStyleBackColor = True
        Me.生管確定のみRadioButton.Visible = False
        '
        'DisplayAllButton
        '
        Me.DisplayAllButton.BackColor = System.Drawing.Color.Gainsboro
        Me.DisplayAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.DisplayAllButton.FlatAppearance.BorderSize = 2
        Me.DisplayAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayAllButton.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DisplayAllButton.Location = New System.Drawing.Point(383, 69)
        Me.DisplayAllButton.Name = "DisplayAllButton"
        Me.DisplayAllButton.Size = New System.Drawing.Size(101, 30)
        Me.DisplayAllButton.TabIndex = 17
        Me.DisplayAllButton.Text = "部署解除"
        Me.DisplayAllButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(384, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 38)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "合計人数" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(本日現在)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '合計人数TextBox
        '
        Me.合計人数TextBox.BackColor = System.Drawing.Color.White
        Me.合計人数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.合計人数TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.合計人数TextBox.Location = New System.Drawing.Point(383, 42)
        Me.合計人数TextBox.Name = "合計人数TextBox"
        Me.合計人数TextBox.ReadOnly = True
        Me.合計人数TextBox.Size = New System.Drawing.Size(101, 26)
        Me.合計人数TextBox.TabIndex = 13
        Me.合計人数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DisChangeButton
        '
        Me.DisChangeButton.BackColor = System.Drawing.Color.Gainsboro
        Me.DisChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.DisChangeButton.FlatAppearance.BorderSize = 2
        Me.DisChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisChangeButton.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DisChangeButton.Location = New System.Drawing.Point(27, 71)
        Me.DisChangeButton.Name = "DisChangeButton"
        Me.DisChangeButton.Size = New System.Drawing.Size(116, 32)
        Me.DisChangeButton.TabIndex = 11
        Me.DisChangeButton.Text = "↓表示切替"
        Me.DisChangeButton.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnClose.FlatAppearance.BorderSize = 2
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(1135, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(116, 62)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "閉じる"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(0, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2754, 9)
        Me.Label1.TabIndex = 4
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.VScrollBar1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.工場負荷集計DataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.VScrollBar2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1254, 482)
        Me.SplitContainer2.SplitterDistance = 370
        Me.SplitContainer2.TabIndex = 3
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(335, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(35, 482)
        Me.VScrollBar1.TabIndex = 3
        '
        '工場負荷集計DataGridView
        '
        Me.工場負荷集計DataGridView.AllowUserToAddRows = False
        Me.工場負荷集計DataGridView.AllowUserToDeleteRows = False
        Me.工場負荷集計DataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.工場負荷集計DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.工場負荷集計DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.工場負荷集計DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.日付DataGridViewTextBoxColumn, Me.予算通常DataGridViewTextBoxColumn, Me.予算外業DataGridViewTextBoxColumn, Me.予算XYZDataGridViewTextBoxColumn, Me.実績通常DataGridViewTextBoxColumn, Me.実績外業DataGridViewTextBoxColumn, Me.実績XYZDataGridViewTextBoxColumn, Me.予算合計, Me.実績合計, Me.実績人数})
        Me.工場負荷集計DataGridView.DataSource = Me.工場負荷集計BindingSource
        Me.工場負荷集計DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.工場負荷集計DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.工場負荷集計DataGridView.Name = "工場負荷集計DataGridView"
        Me.工場負荷集計DataGridView.ReadOnly = True
        Me.工場負荷集計DataGridView.RowHeadersWidth = 20
        Me.工場負荷集計DataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工場負荷集計DataGridView.RowTemplate.Height = 30
        Me.工場負荷集計DataGridView.Size = New System.Drawing.Size(370, 482)
        Me.工場負荷集計DataGridView.TabIndex = 2
        '
        '日付DataGridViewTextBoxColumn
        '
        Me.日付DataGridViewTextBoxColumn.DataPropertyName = "日付"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "MM/dd"
        Me.日付DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.日付DataGridViewTextBoxColumn.DividerWidth = 2
        Me.日付DataGridViewTextBoxColumn.HeaderText = "日付"
        Me.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn"
        Me.日付DataGridViewTextBoxColumn.ReadOnly = True
        Me.日付DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.日付DataGridViewTextBoxColumn.Width = 70
        '
        '予算通常DataGridViewTextBoxColumn
        '
        Me.予算通常DataGridViewTextBoxColumn.DataPropertyName = "予算通常"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.予算通常DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.予算通常DataGridViewTextBoxColumn.HeaderText = "予算通常"
        Me.予算通常DataGridViewTextBoxColumn.Name = "予算通常DataGridViewTextBoxColumn"
        Me.予算通常DataGridViewTextBoxColumn.ReadOnly = True
        Me.予算通常DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.予算通常DataGridViewTextBoxColumn.Visible = False
        Me.予算通常DataGridViewTextBoxColumn.Width = 55
        '
        '予算外業DataGridViewTextBoxColumn
        '
        Me.予算外業DataGridViewTextBoxColumn.DataPropertyName = "予算外業"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle5.Format = "N0"
        Me.予算外業DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.予算外業DataGridViewTextBoxColumn.HeaderText = "予算外業"
        Me.予算外業DataGridViewTextBoxColumn.Name = "予算外業DataGridViewTextBoxColumn"
        Me.予算外業DataGridViewTextBoxColumn.ReadOnly = True
        Me.予算外業DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.予算外業DataGridViewTextBoxColumn.Visible = False
        Me.予算外業DataGridViewTextBoxColumn.Width = 55
        '
        '予算XYZDataGridViewTextBoxColumn
        '
        Me.予算XYZDataGridViewTextBoxColumn.DataPropertyName = "予算XYZ"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle6.Format = "N0"
        Me.予算XYZDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.予算XYZDataGridViewTextBoxColumn.DividerWidth = 2
        Me.予算XYZDataGridViewTextBoxColumn.HeaderText = "予算XYZ"
        Me.予算XYZDataGridViewTextBoxColumn.Name = "予算XYZDataGridViewTextBoxColumn"
        Me.予算XYZDataGridViewTextBoxColumn.ReadOnly = True
        Me.予算XYZDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.予算XYZDataGridViewTextBoxColumn.Visible = False
        Me.予算XYZDataGridViewTextBoxColumn.Width = 55
        '
        '実績通常DataGridViewTextBoxColumn
        '
        Me.実績通常DataGridViewTextBoxColumn.DataPropertyName = "実績通常"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle7.Format = "N0"
        Me.実績通常DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.実績通常DataGridViewTextBoxColumn.HeaderText = "実績通常"
        Me.実績通常DataGridViewTextBoxColumn.Name = "実績通常DataGridViewTextBoxColumn"
        Me.実績通常DataGridViewTextBoxColumn.ReadOnly = True
        Me.実績通常DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.実績通常DataGridViewTextBoxColumn.Visible = False
        Me.実績通常DataGridViewTextBoxColumn.Width = 55
        '
        '実績外業DataGridViewTextBoxColumn
        '
        Me.実績外業DataGridViewTextBoxColumn.DataPropertyName = "実績外業"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle8.Format = "N0"
        Me.実績外業DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.実績外業DataGridViewTextBoxColumn.HeaderText = "実績外業"
        Me.実績外業DataGridViewTextBoxColumn.Name = "実績外業DataGridViewTextBoxColumn"
        Me.実績外業DataGridViewTextBoxColumn.ReadOnly = True
        Me.実績外業DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.実績外業DataGridViewTextBoxColumn.Visible = False
        Me.実績外業DataGridViewTextBoxColumn.Width = 55
        '
        '実績XYZDataGridViewTextBoxColumn
        '
        Me.実績XYZDataGridViewTextBoxColumn.DataPropertyName = "実績XYZ"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle9.Format = "N0"
        Me.実績XYZDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.実績XYZDataGridViewTextBoxColumn.DividerWidth = 2
        Me.実績XYZDataGridViewTextBoxColumn.HeaderText = "実績XYZ"
        Me.実績XYZDataGridViewTextBoxColumn.Name = "実績XYZDataGridViewTextBoxColumn"
        Me.実績XYZDataGridViewTextBoxColumn.ReadOnly = True
        Me.実績XYZDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.実績XYZDataGridViewTextBoxColumn.Visible = False
        Me.実績XYZDataGridViewTextBoxColumn.Width = 55
        '
        '予算合計
        '
        Me.予算合計.DataPropertyName = "予算合計"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle10.Format = "N0"
        Me.予算合計.DefaultCellStyle = DataGridViewCellStyle10
        Me.予算合計.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.予算合計.HeaderText = "予算合計"
        Me.予算合計.Name = "予算合計"
        Me.予算合計.ReadOnly = True
        Me.予算合計.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.予算合計.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.予算合計.Width = 75
        '
        '実績合計
        '
        Me.実績合計.DataPropertyName = "実績合計"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle11.Format = "N0"
        Me.実績合計.DefaultCellStyle = DataGridViewCellStyle11
        Me.実績合計.HeaderText = "実績合計"
        Me.実績合計.Name = "実績合計"
        Me.実績合計.ReadOnly = True
        Me.実績合計.Width = 75
        '
        '実績人数
        '
        Me.実績人数.DataPropertyName = "実績人数"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle12.Format = "N0"
        Me.実績人数.DefaultCellStyle = DataGridViewCellStyle12
        Me.実績人数.HeaderText = "実績人数"
        Me.実績人数.Name = "実績人数"
        Me.実績人数.ReadOnly = True
        Me.実績人数.Width = 75
        '
        '工場負荷集計BindingSource
        '
        Me.工場負荷集計BindingSource.DataMember = "工場負荷集計dtbl"
        Me.工場負荷集計BindingSource.DataSource = Me.工場負荷DataSet1
        '
        '工場負荷DataSet1
        '
        Me.工場負荷DataSet1.DataSetName = "工場負荷DataSet"
        Me.工場負荷DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar2.Location = New System.Drawing.Point(845, 0)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(35, 482)
        Me.VScrollBar2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Controls.Add(Me.工場負荷Chart)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 1403)
        Me.Panel1.TabIndex = 1
        '
        '工場負荷Chart
        '
        ChartArea1.AxisX.IsReversed = True
        ChartArea1.AxisX.LabelStyle.Interval = 1.0R
        ChartArea1.AxisY.Maximum = 600.0R
        ChartArea1.AxisY2.Maximum = 600.0R
        ChartArea1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        ChartArea1.Name = "ChartArea1"
        Me.工場負荷Chart.ChartAreas.Add(ChartArea1)
        Me.工場負荷Chart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.工場負荷Chart.Legends.Add(Legend1)
        Me.工場負荷Chart.Location = New System.Drawing.Point(0, 0)
        Me.工場負荷Chart.Name = "工場負荷Chart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.工場負荷Chart.Series.Add(Series1)
        Me.工場負荷Chart.Size = New System.Drawing.Size(669, 1403)
        Me.工場負荷Chart.TabIndex = 0
        Me.工場負荷Chart.Text = "Chart1"
        '
        '工場負荷工程予算dtblTadp1
        '
        Me.工場負荷工程予算dtblTadp1.ClearBeforeFill = True
        '
        '工場負荷日報dtblTadp1
        '
        Me.工場負荷日報dtblTadp1.ClearBeforeFill = True
        '
        '工場部署人数dtblTadp1
        '
        Me.工場部署人数dtblTadp1.ClearBeforeFill = True
        '
        '工場部署人数BindingSource
        '
        Me.工場部署人数BindingSource.DataMember = "工場部署人数dtbl"
        Me.工場部署人数BindingSource.DataSource = Me.工場負荷DataSet1
        '
        '工場実績人数dtblTadp1
        '
        Me.工場実績人数dtblTadp1.ClearBeforeFill = True
        '
        '工場負荷
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 590)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "工場負荷"
        Me.Text = "工場負荷"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.部署人数DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.工場負荷集計DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工場負荷集計BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工場負荷DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.工場負荷Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工場部署人数BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents 工場負荷DataSet1 As FujiSysForFactory3.工場負荷DataSet
    Friend WithEvents 工場負荷工程予算dtblTadp1 As FujiSysForFactory3.工場負荷DataSetTableAdapters.工場負荷工程予算dtblTadp
    Friend WithEvents 工場負荷集計DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 工場負荷集計BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工場負荷日報dtblTadp1 As FujiSysForFactory3.工場負荷DataSetTableAdapters.工場負荷日報dtblTadp
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents 工場負荷Chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents DisChangeButton As System.Windows.Forms.Button
    Friend WithEvents 部署人数DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 工場部署人数dtblTadp1 As FujiSysForFactory3.工場負荷DataSetTableAdapters.工場部署人数dtblTadp
    Friend WithEvents 工場部署人数BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents 合計人数TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工場実績人数dtblTadp1 As FujiSysForFactory3.工場負荷DataSetTableAdapters.工場実績人数dtblTadp
    Friend WithEvents DisplayAllButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents 全てRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents 生管確定のみRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents InputedDateBMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonOpenDateDialog As System.Windows.Forms.Button
    Friend WithEvents InputedDateAMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents 日付DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 予算通常DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 予算外業DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 予算XYZDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 実績通常DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 実績外業DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 実績XYZDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 予算合計 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents 実績合計 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 実績人数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar2 As System.Windows.Forms.VScrollBar
End Class
