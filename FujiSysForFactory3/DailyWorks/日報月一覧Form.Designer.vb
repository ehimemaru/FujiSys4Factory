<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 日報月一覧Form
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AveTimesTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTimesTextBox = New System.Windows.Forms.TextBox()
        Me.TotalNumOfPeoTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TargetMonthTextBox = New System.Windows.Forms.TextBox()
        Me.InputMonthButton = New System.Windows.Forms.Button()
        Me.DisplayAllButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.合計人数TextBox = New System.Windows.Forms.TextBox()
        Me.部署人数DataGridView = New System.Windows.Forms.DataGridView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.日報月一覧dtblDataGridView = New System.Windows.Forms.DataGridView()
        Me.選択 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日報月一覧BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DailyWorksDataSet = New FujiSysForFactory3.DailyWorksDataSet()
        Me.日報人別月一覧dtblDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日報人別月一覧BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AveTimesByManTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTimesByManTextBox = New System.Windows.Forms.TextBox()
        Me.DaysByManTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.日報月一覧dtblTableAdapter1 = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報月一覧dtblTableAdapter()
        Me.日報人別月一覧dtblTableAdapter1 = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報人別月一覧dtblTableAdapter()
        Me.TableAdapterManager = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.TableAdapterManager()
        Me.日報会社休日dtblTableAdapter1 = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報会社休日dtblTableAdapter()
        Me.日報部署dtblTableAdapter1 = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報部署dtblTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.部署人数DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.日報月一覧dtblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報月一覧BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報人別月一覧dtblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報人別月一覧BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TargetMonthTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputMonthButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DisplayAllButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.合計人数TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.部署人数DataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1254, 662)
        Me.SplitContainer1.SplitterDistance = 110
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AveTimesTextBox, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalTimesTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalNumOfPeoTextBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 55)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(354, 49)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'AveTimesTextBox
        '
        Me.AveTimesTextBox.BackColor = System.Drawing.Color.White
        Me.AveTimesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AveTimesTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AveTimesTextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AveTimesTextBox.Location = New System.Drawing.Point(232, 22)
        Me.AveTimesTextBox.Name = "AveTimesTextBox"
        Me.AveTimesTextBox.ReadOnly = True
        Me.AveTimesTextBox.Size = New System.Drawing.Size(119, 26)
        Me.AveTimesTextBox.TabIndex = 78
        Me.AveTimesTextBox.TabStop = False
        Me.AveTimesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalTimesTextBox
        '
        Me.TotalTimesTextBox.BackColor = System.Drawing.Color.White
        Me.TotalTimesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalTimesTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalTimesTextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TotalTimesTextBox.Location = New System.Drawing.Point(109, 22)
        Me.TotalTimesTextBox.Name = "TotalTimesTextBox"
        Me.TotalTimesTextBox.ReadOnly = True
        Me.TotalTimesTextBox.Size = New System.Drawing.Size(117, 26)
        Me.TotalTimesTextBox.TabIndex = 77
        Me.TotalTimesTextBox.TabStop = False
        Me.TotalTimesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalNumOfPeoTextBox
        '
        Me.TotalNumOfPeoTextBox.BackColor = System.Drawing.Color.White
        Me.TotalNumOfPeoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalNumOfPeoTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalNumOfPeoTextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TotalNumOfPeoTextBox.Location = New System.Drawing.Point(3, 22)
        Me.TotalNumOfPeoTextBox.Name = "TotalNumOfPeoTextBox"
        Me.TotalNumOfPeoTextBox.ReadOnly = True
        Me.TotalNumOfPeoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TotalNumOfPeoTextBox.TabIndex = 76
        Me.TotalNumOfPeoTextBox.TabStop = False
        Me.TotalNumOfPeoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "平均時間"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 19)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "合計時間"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "人数"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(1185, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(69, 88)
        Me.ButtonClose.TabIndex = 75
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'TargetMonthTextBox
        '
        Me.TargetMonthTextBox.BackColor = System.Drawing.Color.White
        Me.TargetMonthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TargetMonthTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TargetMonthTextBox.Location = New System.Drawing.Point(156, 19)
        Me.TargetMonthTextBox.Name = "TargetMonthTextBox"
        Me.TargetMonthTextBox.ReadOnly = True
        Me.TargetMonthTextBox.Size = New System.Drawing.Size(145, 31)
        Me.TargetMonthTextBox.TabIndex = 74
        Me.TargetMonthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InputMonthButton
        '
        Me.InputMonthButton.BackColor = System.Drawing.Color.Gainsboro
        Me.InputMonthButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.InputMonthButton.FlatAppearance.BorderSize = 2
        Me.InputMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InputMonthButton.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputMonthButton.Location = New System.Drawing.Point(12, 16)
        Me.InputMonthButton.Name = "InputMonthButton"
        Me.InputMonthButton.Size = New System.Drawing.Size(143, 35)
        Me.InputMonthButton.TabIndex = 73
        Me.InputMonthButton.Text = "対象月選択"
        Me.InputMonthButton.UseVisualStyleBackColor = False
        '
        'DisplayAllButton
        '
        Me.DisplayAllButton.BackColor = System.Drawing.Color.Gainsboro
        Me.DisplayAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.DisplayAllButton.FlatAppearance.BorderSize = 2
        Me.DisplayAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayAllButton.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DisplayAllButton.Location = New System.Drawing.Point(399, 75)
        Me.DisplayAllButton.Name = "DisplayAllButton"
        Me.DisplayAllButton.Size = New System.Drawing.Size(101, 30)
        Me.DisplayAllButton.TabIndex = 72
        Me.DisplayAllButton.Text = "部署解除"
        Me.DisplayAllButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(406, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "合計人数"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '合計人数TextBox
        '
        Me.合計人数TextBox.BackColor = System.Drawing.Color.White
        Me.合計人数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.合計人数TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.合計人数TextBox.Location = New System.Drawing.Point(399, 43)
        Me.合計人数TextBox.Name = "合計人数TextBox"
        Me.合計人数TextBox.ReadOnly = True
        Me.合計人数TextBox.Size = New System.Drawing.Size(101, 26)
        Me.合計人数TextBox.TabIndex = 70
        Me.合計人数TextBox.TabStop = False
        Me.合計人数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '部署人数DataGridView
        '
        Me.部署人数DataGridView.AllowUserToAddRows = False
        Me.部署人数DataGridView.AllowUserToDeleteRows = False
        Me.部署人数DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.部署人数DataGridView.Location = New System.Drawing.Point(506, 11)
        Me.部署人数DataGridView.Name = "部署人数DataGridView"
        Me.部署人数DataGridView.ReadOnly = True
        Me.部署人数DataGridView.RowTemplate.Height = 35
        Me.部署人数DataGridView.Size = New System.Drawing.Size(673, 93)
        Me.部署人数DataGridView.TabIndex = 69
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.日報月一覧dtblDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.日報人別月一覧dtblDataGridView)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1254, 548)
        Me.SplitContainer2.SplitterDistance = 659
        Me.SplitContainer2.TabIndex = 0
        '
        '日報月一覧dtblDataGridView
        '
        Me.日報月一覧dtblDataGridView.AllowUserToAddRows = False
        Me.日報月一覧dtblDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.日報月一覧dtblDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.日報月一覧dtblDataGridView.AutoGenerateColumns = False
        Me.日報月一覧dtblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.日報月一覧dtblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.選択, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.日報月一覧dtblDataGridView.DataSource = Me.日報月一覧BindingSource
        Me.日報月一覧dtblDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.日報月一覧dtblDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.日報月一覧dtblDataGridView.Name = "日報月一覧dtblDataGridView"
        Me.日報月一覧dtblDataGridView.ReadOnly = True
        Me.日報月一覧dtblDataGridView.RowTemplate.Height = 35
        Me.日報月一覧dtblDataGridView.Size = New System.Drawing.Size(659, 548)
        Me.日報月一覧dtblDataGridView.TabIndex = 0
        '
        '選択
        '
        Me.選択.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.選択.HeaderText = "選択"
        Me.選択.Name = "選択"
        Me.選択.ReadOnly = True
        Me.選択.Width = 60
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "社員ＩＤ"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "社員ＩＤ"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "社員名"
        Me.DataGridViewTextBoxColumn2.DividerWidth = 2
        Me.DataGridViewTextBoxColumn2.HeaderText = "社員名"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "部署ＩＤ"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "部署ＩＤ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "部署名"
        Me.DataGridViewTextBoxColumn3.DividerWidth = 2
        Me.DataGridViewTextBoxColumn3.HeaderText = "部署名"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "時間計"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "時間計"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "労務費計"
        Me.DataGridViewTextBoxColumn6.HeaderText = "労務費計"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        '日報月一覧BindingSource
        '
        Me.日報月一覧BindingSource.DataMember = "日報月一覧dtbl"
        Me.日報月一覧BindingSource.DataSource = Me.DailyWorksDataSet
        '
        'DailyWorksDataSet
        '
        Me.DailyWorksDataSet.DataSetName = "DailyWorksDataSet"
        Me.DailyWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '日報人別月一覧dtblDataGridView
        '
        Me.日報人別月一覧dtblDataGridView.AllowUserToAddRows = False
        Me.日報人別月一覧dtblDataGridView.AllowUserToDeleteRows = False
        Me.日報人別月一覧dtblDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.日報人別月一覧dtblDataGridView.AutoGenerateColumns = False
        Me.日報人別月一覧dtblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.日報人別月一覧dtblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.日報人別月一覧dtblDataGridView.DataSource = Me.日報人別月一覧BindingSource
        Me.日報人別月一覧dtblDataGridView.Location = New System.Drawing.Point(0, 62)
        Me.日報人別月一覧dtblDataGridView.Name = "日報人別月一覧dtblDataGridView"
        Me.日報人別月一覧dtblDataGridView.ReadOnly = True
        Me.日報人別月一覧dtblDataGridView.RowTemplate.Height = 35
        Me.日報人別月一覧dtblDataGridView.Size = New System.Drawing.Size(590, 486)
        Me.日報人別月一覧dtblDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "作業日"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "MM/dd(ddd)"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn7.HeaderText = "作業日"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "時間計"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn8.HeaderText = "時間計"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "労務費計"
        Me.DataGridViewTextBoxColumn9.HeaderText = "労務費計"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "不時間計"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn10.HeaderText = "不適時間"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "不費計"
        Me.DataGridViewTextBoxColumn11.HeaderText = "不費計"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        '日報人別月一覧BindingSource
        '
        Me.日報人別月一覧BindingSource.DataMember = "日報人別月一覧dtbl"
        Me.日報人別月一覧BindingSource.DataSource = Me.DailyWorksDataSet
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.AveTimesByManTextBox, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TotalTimesByManTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DaysByManTextBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(41, 9)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(365, 49)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'AveTimesByManTextBox
        '
        Me.AveTimesByManTextBox.BackColor = System.Drawing.Color.White
        Me.AveTimesByManTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AveTimesByManTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AveTimesByManTextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AveTimesByManTextBox.Location = New System.Drawing.Point(243, 22)
        Me.AveTimesByManTextBox.Name = "AveTimesByManTextBox"
        Me.AveTimesByManTextBox.ReadOnly = True
        Me.AveTimesByManTextBox.Size = New System.Drawing.Size(119, 26)
        Me.AveTimesByManTextBox.TabIndex = 78
        Me.AveTimesByManTextBox.TabStop = False
        Me.AveTimesByManTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalTimesByManTextBox
        '
        Me.TotalTimesByManTextBox.BackColor = System.Drawing.Color.White
        Me.TotalTimesByManTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalTimesByManTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalTimesByManTextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TotalTimesByManTextBox.Location = New System.Drawing.Point(123, 22)
        Me.TotalTimesByManTextBox.Name = "TotalTimesByManTextBox"
        Me.TotalTimesByManTextBox.ReadOnly = True
        Me.TotalTimesByManTextBox.Size = New System.Drawing.Size(114, 26)
        Me.TotalTimesByManTextBox.TabIndex = 77
        Me.TotalTimesByManTextBox.TabStop = False
        Me.TotalTimesByManTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DaysByManTextBox
        '
        Me.DaysByManTextBox.BackColor = System.Drawing.Color.White
        Me.DaysByManTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DaysByManTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DaysByManTextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DaysByManTextBox.Location = New System.Drawing.Point(3, 22)
        Me.DaysByManTextBox.Name = "DaysByManTextBox"
        Me.DaysByManTextBox.ReadOnly = True
        Me.DaysByManTextBox.Size = New System.Drawing.Size(114, 26)
        Me.DaysByManTextBox.TabIndex = 76
        Me.DaysByManTextBox.TabStop = False
        Me.DaysByManTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(243, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "平均時間"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(123, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 19)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "合計時間"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 19)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "日数"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '日報月一覧dtblTableAdapter1
        '
        Me.日報月一覧dtblTableAdapter1.ClearBeforeFill = True
        '
        '日報人別月一覧dtblTableAdapter1
        '
        Me.日報人別月一覧dtblTableAdapter1.ClearBeforeFill = True
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
        '日報会社休日dtblTableAdapter1
        '
        Me.日報会社休日dtblTableAdapter1.ClearBeforeFill = True
        '
        '日報部署dtblTableAdapter1
        '
        Me.日報部署dtblTableAdapter1.ClearBeforeFill = True
        '
        '日報月一覧Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "日報月一覧Form"
        Me.Text = "日報月一覧"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.部署人数DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.日報月一覧dtblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報月一覧BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報人別月一覧dtblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報人別月一覧BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DisplayAllButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents 合計人数TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 部署人数DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 日報月一覧dtblTableAdapter1 As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報月一覧dtblTableAdapter
    Friend WithEvents 日報人別月一覧dtblTableAdapter1 As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報人別月一覧dtblTableAdapter
    Friend WithEvents TargetMonthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InputMonthButton As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents 日報月一覧BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DailyWorksDataSet As FujiSysForFactory3.DailyWorksDataSet
    Friend WithEvents 日報人別月一覧BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AveTimesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTimesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalNumOfPeoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents 日報月一覧dtblDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableAdapterManager As FujiSysForFactory3.DailyWorksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 選択 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 日報人別月一覧dtblDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AveTimesByManTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTimesByManTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DaysByManTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents 日報会社休日dtblTableAdapter1 As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報会社休日dtblTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 日報部署dtblTableAdapter1 As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報部署dtblTableAdapter
End Class
