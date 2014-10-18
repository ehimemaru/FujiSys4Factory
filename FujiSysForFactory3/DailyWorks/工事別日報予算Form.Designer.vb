<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 工事別日報予算Form
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.予算工数計TextBox = New System.Windows.Forms.TextBox()
        Me.実績工数計TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DisplayAllButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.合計人数TextBox = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.部署人数DataGridView = New System.Windows.Forms.DataGridView()
        Me.ConstructionNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonOpenConstDialog = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.日報実績DataGridView = New System.Windows.Forms.DataGridView()
        Me.社員ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.社員ＩＤ名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.最小人別DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.最大人別DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工数計DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.部署ＩＤDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日報人実績一覧BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DailyWorksDataSet = New FujiSysForFactory3.DailyWorksDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.予算工数DataGridView = New System.Windows.Forms.DataGridView()
        Me.工程ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.日報工程BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工程予算ＮＯDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工事番号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程パスDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.表示順DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.期間対象DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.予算対象DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.単価対象DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程期間始DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程期間終DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.部署ＩＤDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.日報部署BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.部署名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.単価金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.社内工数DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.社内金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.社外金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.更新日時DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程完了日DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程備考１DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程備考２DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工程備考３DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.土曜含DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.日曜含DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.製作品詳細対象DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.設備コードDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.職種コードDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日毎社工DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日報工程予算BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.日報会社休日dtblTableAdapter1 = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報会社休日dtblTableAdapter()
        Me.日報部署dtblTableAdapter1 = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報部署dtblTableAdapter()
        Me.日報工程予算dtblTableAdapter1 = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報工程予算dtblTableAdapter()
        Me.日報工程dtblTableAdapter1 = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報工程dtblTableAdapter()
        Me.日報人実績一覧dtblTableAdapter1 = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報人実績一覧dtblTableAdapter()
        Me.日報人実績一覧サブdtblTableAdapter1 = New FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報人実績一覧サブdtblTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.部署人数DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.日報実績DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報人実績一覧BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.予算工数DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報工程BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報部署BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.日報工程予算BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 662)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DisplayAllButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.合計人数TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.部署人数DataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConstructionNoMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOpenConstDialog)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1251, 662)
        Me.SplitContainer1.SplitterDistance = 111
        Me.SplitContainer1.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.12292!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.87708!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.予算工数計TextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.実績工数計TextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 47)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(370, 59)
        Me.TableLayoutPanel1.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 30)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "実績工数計"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '予算工数計TextBox
        '
        Me.予算工数計TextBox.BackColor = System.Drawing.Color.White
        Me.予算工数計TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.予算工数計TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.予算工数計TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.予算工数計TextBox.Location = New System.Drawing.Point(236, 3)
        Me.予算工数計TextBox.Name = "予算工数計TextBox"
        Me.予算工数計TextBox.ReadOnly = True
        Me.予算工数計TextBox.Size = New System.Drawing.Size(131, 26)
        Me.予算工数計TextBox.TabIndex = 74
        Me.予算工数計TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '実績工数計TextBox
        '
        Me.実績工数計TextBox.BackColor = System.Drawing.Color.White
        Me.実績工数計TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.実績工数計TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.実績工数計TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.実績工数計TextBox.Location = New System.Drawing.Point(236, 32)
        Me.実績工数計TextBox.Name = "実績工数計TextBox"
        Me.実績工数計TextBox.ReadOnly = True
        Me.実績工数計TextBox.Size = New System.Drawing.Size(131, 26)
        Me.実績工数計TextBox.TabIndex = 75
        Me.実績工数計TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 29)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "予算工数計(設計除く)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DisplayAllButton
        '
        Me.DisplayAllButton.BackColor = System.Drawing.Color.Gainsboro
        Me.DisplayAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.DisplayAllButton.FlatAppearance.BorderSize = 2
        Me.DisplayAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayAllButton.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DisplayAllButton.Location = New System.Drawing.Point(394, 67)
        Me.DisplayAllButton.Name = "DisplayAllButton"
        Me.DisplayAllButton.Size = New System.Drawing.Size(101, 30)
        Me.DisplayAllButton.TabIndex = 75
        Me.DisplayAllButton.Text = "部署解除"
        Me.DisplayAllButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "合計人数"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '合計人数TextBox
        '
        Me.合計人数TextBox.BackColor = System.Drawing.Color.White
        Me.合計人数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.合計人数TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.合計人数TextBox.Location = New System.Drawing.Point(394, 35)
        Me.合計人数TextBox.Name = "合計人数TextBox"
        Me.合計人数TextBox.ReadOnly = True
        Me.合計人数TextBox.Size = New System.Drawing.Size(101, 26)
        Me.合計人数TextBox.TabIndex = 73
        Me.合計人数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(1180, 13)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(69, 88)
        Me.ButtonClose.TabIndex = 72
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        '部署人数DataGridView
        '
        Me.部署人数DataGridView.AllowUserToAddRows = False
        Me.部署人数DataGridView.AllowUserToDeleteRows = False
        Me.部署人数DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.部署人数DataGridView.Location = New System.Drawing.Point(501, 12)
        Me.部署人数DataGridView.Name = "部署人数DataGridView"
        Me.部署人数DataGridView.ReadOnly = True
        Me.部署人数DataGridView.RowTemplate.Height = 35
        Me.部署人数DataGridView.Size = New System.Drawing.Size(673, 93)
        Me.部署人数DataGridView.TabIndex = 69
        '
        'ConstructionNoMaskedTextBox
        '
        Me.ConstructionNoMaskedTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ConstructionNoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConstructionNoMaskedTextBox.Enabled = False
        Me.ConstructionNoMaskedTextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ConstructionNoMaskedTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ConstructionNoMaskedTextBox.Location = New System.Drawing.Point(146, 12)
        Me.ConstructionNoMaskedTextBox.Mask = ">00A-&000-00"
        Me.ConstructionNoMaskedTextBox.Name = "ConstructionNoMaskedTextBox"
        Me.ConstructionNoMaskedTextBox.Size = New System.Drawing.Size(164, 31)
        Me.ConstructionNoMaskedTextBox.TabIndex = 70
        Me.ConstructionNoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonOpenConstDialog
        '
        Me.ButtonOpenConstDialog.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOpenConstDialog.FlatAppearance.BorderSize = 2
        Me.ButtonOpenConstDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenConstDialog.Location = New System.Drawing.Point(9, 12)
        Me.ButtonOpenConstDialog.Name = "ButtonOpenConstDialog"
        Me.ButtonOpenConstDialog.Size = New System.Drawing.Size(131, 31)
        Me.ButtonOpenConstDialog.TabIndex = 71
        Me.ButtonOpenConstDialog.Text = "工事番号："
        Me.ButtonOpenConstDialog.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1251, 547)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.日報実績DataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1243, 514)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "日報実績"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        '日報実績DataGridView
        '
        Me.日報実績DataGridView.AllowUserToAddRows = False
        Me.日報実績DataGridView.AllowUserToDeleteRows = False
        Me.日報実績DataGridView.AutoGenerateColumns = False
        Me.日報実績DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.日報実績DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.社員ＩＤDataGridViewTextBoxColumn, Me.社員ＩＤ名DataGridViewTextBoxColumn, Me.最小人別DataGridViewTextBoxColumn, Me.最大人別DataGridViewTextBoxColumn, Me.工数計DataGridViewTextBoxColumn, Me.部署ＩＤDataGridViewTextBoxColumn1})
        Me.日報実績DataGridView.DataSource = Me.日報人実績一覧BindingSource
        Me.日報実績DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.日報実績DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.日報実績DataGridView.Name = "日報実績DataGridView"
        Me.日報実績DataGridView.ReadOnly = True
        Me.日報実績DataGridView.RowTemplate.Height = 35
        Me.日報実績DataGridView.Size = New System.Drawing.Size(1237, 508)
        Me.日報実績DataGridView.TabIndex = 0
        '
        '社員ＩＤDataGridViewTextBoxColumn
        '
        Me.社員ＩＤDataGridViewTextBoxColumn.DataPropertyName = "社員ＩＤ"
        Me.社員ＩＤDataGridViewTextBoxColumn.Frozen = True
        Me.社員ＩＤDataGridViewTextBoxColumn.HeaderText = "社員ＩＤ"
        Me.社員ＩＤDataGridViewTextBoxColumn.Name = "社員ＩＤDataGridViewTextBoxColumn"
        Me.社員ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.社員ＩＤDataGridViewTextBoxColumn.Visible = False
        '
        '社員ＩＤ名DataGridViewTextBoxColumn
        '
        Me.社員ＩＤ名DataGridViewTextBoxColumn.DataPropertyName = "社員ＩＤ名"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.社員ＩＤ名DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.社員ＩＤ名DataGridViewTextBoxColumn.Frozen = True
        Me.社員ＩＤ名DataGridViewTextBoxColumn.HeaderText = "社員名"
        Me.社員ＩＤ名DataGridViewTextBoxColumn.Name = "社員ＩＤ名DataGridViewTextBoxColumn"
        Me.社員ＩＤ名DataGridViewTextBoxColumn.ReadOnly = True
        Me.社員ＩＤ名DataGridViewTextBoxColumn.Width = 180
        '
        '最小人別DataGridViewTextBoxColumn
        '
        Me.最小人別DataGridViewTextBoxColumn.DataPropertyName = "最小人別"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Format = "MM/dd"
        Me.最小人別DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.最小人別DataGridViewTextBoxColumn.Frozen = True
        Me.最小人別DataGridViewTextBoxColumn.HeaderText = "最小"
        Me.最小人別DataGridViewTextBoxColumn.Name = "最小人別DataGridViewTextBoxColumn"
        Me.最小人別DataGridViewTextBoxColumn.ReadOnly = True
        Me.最小人別DataGridViewTextBoxColumn.Width = 60
        '
        '最大人別DataGridViewTextBoxColumn
        '
        Me.最大人別DataGridViewTextBoxColumn.DataPropertyName = "最大人別"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Format = "MM/dd"
        Me.最大人別DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.最大人別DataGridViewTextBoxColumn.Frozen = True
        Me.最大人別DataGridViewTextBoxColumn.HeaderText = "最大"
        Me.最大人別DataGridViewTextBoxColumn.Name = "最大人別DataGridViewTextBoxColumn"
        Me.最大人別DataGridViewTextBoxColumn.ReadOnly = True
        Me.最大人別DataGridViewTextBoxColumn.Width = 60
        '
        '工数計DataGridViewTextBoxColumn
        '
        Me.工数計DataGridViewTextBoxColumn.DataPropertyName = "工数計"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Format = "N2"
        Me.工数計DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.工数計DataGridViewTextBoxColumn.DividerWidth = 2
        Me.工数計DataGridViewTextBoxColumn.Frozen = True
        Me.工数計DataGridViewTextBoxColumn.HeaderText = "工数計"
        Me.工数計DataGridViewTextBoxColumn.Name = "工数計DataGridViewTextBoxColumn"
        Me.工数計DataGridViewTextBoxColumn.ReadOnly = True
        '
        '部署ＩＤDataGridViewTextBoxColumn1
        '
        Me.部署ＩＤDataGridViewTextBoxColumn1.DataPropertyName = "部署ＩＤ"
        Me.部署ＩＤDataGridViewTextBoxColumn1.HeaderText = "部署ＩＤ"
        Me.部署ＩＤDataGridViewTextBoxColumn1.Name = "部署ＩＤDataGridViewTextBoxColumn1"
        Me.部署ＩＤDataGridViewTextBoxColumn1.ReadOnly = True
        Me.部署ＩＤDataGridViewTextBoxColumn1.Visible = False
        '
        '日報人実績一覧BindingSource
        '
        Me.日報人実績一覧BindingSource.DataMember = "日報人実績一覧dtbl"
        Me.日報人実績一覧BindingSource.DataSource = Me.DailyWorksDataSet
        '
        'DailyWorksDataSet
        '
        Me.DailyWorksDataSet.DataSetName = "DailyWorksDataSet"
        Me.DailyWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.予算工数DataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1243, 521)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "予算工数"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        '予算工数DataGridView
        '
        Me.予算工数DataGridView.AllowUserToAddRows = False
        Me.予算工数DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        Me.予算工数DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.予算工数DataGridView.AutoGenerateColumns = False
        Me.予算工数DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.予算工数DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.工程ＩＤDataGridViewTextBoxColumn, Me.工程予算ＮＯDataGridViewTextBoxColumn, Me.工事番号DataGridViewTextBoxColumn, Me.工程パスDataGridViewTextBoxColumn, Me.表示順DataGridViewTextBoxColumn, Me.期間対象DataGridViewTextBoxColumn, Me.予算対象DataGridViewTextBoxColumn, Me.単価対象DataGridViewTextBoxColumn, Me.工程期間始DataGridViewTextBoxColumn, Me.工程期間終DataGridViewTextBoxColumn, Me.部署ＩＤDataGridViewTextBoxColumn, Me.部署名DataGridViewTextBoxColumn, Me.単価金額DataGridViewTextBoxColumn, Me.社内工数DataGridViewTextBoxColumn, Me.社内金額DataGridViewTextBoxColumn, Me.社外金額DataGridViewTextBoxColumn, Me.更新日時DataGridViewTextBoxColumn, Me.工程完了日DataGridViewTextBoxColumn, Me.工程備考１DataGridViewTextBoxColumn, Me.工程備考２DataGridViewTextBoxColumn, Me.工程備考３DataGridViewTextBoxColumn, Me.土曜含DataGridViewTextBoxColumn, Me.日曜含DataGridViewTextBoxColumn, Me.製作品詳細対象DataGridViewTextBoxColumn, Me.設備コードDataGridViewTextBoxColumn, Me.職種コードDataGridViewTextBoxColumn, Me.日毎社工DataGridViewTextBoxColumn})
        Me.予算工数DataGridView.DataSource = Me.日報工程予算BindingSource
        Me.予算工数DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.予算工数DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.予算工数DataGridView.Name = "予算工数DataGridView"
        Me.予算工数DataGridView.ReadOnly = True
        Me.予算工数DataGridView.RowTemplate.Height = 35
        Me.予算工数DataGridView.Size = New System.Drawing.Size(1237, 515)
        Me.予算工数DataGridView.TabIndex = 0
        '
        '工程ＩＤDataGridViewTextBoxColumn
        '
        Me.工程ＩＤDataGridViewTextBoxColumn.DataPropertyName = "工程ＩＤ"
        Me.工程ＩＤDataGridViewTextBoxColumn.DataSource = Me.日報工程BindingSource
        Me.工程ＩＤDataGridViewTextBoxColumn.DisplayMember = "工程名"
        Me.工程ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.工程ＩＤDataGridViewTextBoxColumn.HeaderText = "工程"
        Me.工程ＩＤDataGridViewTextBoxColumn.Name = "工程ＩＤDataGridViewTextBoxColumn"
        Me.工程ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.工程ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.工程ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.工程ＩＤDataGridViewTextBoxColumn.ValueMember = "工程ＩＤ"
        '
        '日報工程BindingSource
        '
        Me.日報工程BindingSource.DataMember = "日報工程dtbl"
        Me.日報工程BindingSource.DataSource = Me.DailyWorksDataSet
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
        Me.工事番号DataGridViewTextBoxColumn.ReadOnly = True
        Me.工事番号DataGridViewTextBoxColumn.Visible = False
        '
        '工程パスDataGridViewTextBoxColumn
        '
        Me.工程パスDataGridViewTextBoxColumn.DataPropertyName = "工程パス"
        Me.工程パスDataGridViewTextBoxColumn.HeaderText = "工程パス"
        Me.工程パスDataGridViewTextBoxColumn.Name = "工程パスDataGridViewTextBoxColumn"
        Me.工程パスDataGridViewTextBoxColumn.ReadOnly = True
        Me.工程パスDataGridViewTextBoxColumn.Visible = False
        '
        '表示順DataGridViewTextBoxColumn
        '
        Me.表示順DataGridViewTextBoxColumn.DataPropertyName = "表示順"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        Me.表示順DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.表示順DataGridViewTextBoxColumn.DividerWidth = 2
        Me.表示順DataGridViewTextBoxColumn.HeaderText = "順"
        Me.表示順DataGridViewTextBoxColumn.Name = "表示順DataGridViewTextBoxColumn"
        Me.表示順DataGridViewTextBoxColumn.ReadOnly = True
        Me.表示順DataGridViewTextBoxColumn.Width = 60
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "MM/dd"
        Me.工程期間始DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.工程期間始DataGridViewTextBoxColumn.HeaderText = "工程始"
        Me.工程期間始DataGridViewTextBoxColumn.Name = "工程期間始DataGridViewTextBoxColumn"
        Me.工程期間始DataGridViewTextBoxColumn.ReadOnly = True
        '
        '工程期間終DataGridViewTextBoxColumn
        '
        Me.工程期間終DataGridViewTextBoxColumn.DataPropertyName = "工程期間終"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "MM/dd"
        Me.工程期間終DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.工程期間終DataGridViewTextBoxColumn.DividerWidth = 2
        Me.工程期間終DataGridViewTextBoxColumn.HeaderText = "工程終"
        Me.工程期間終DataGridViewTextBoxColumn.Name = "工程期間終DataGridViewTextBoxColumn"
        Me.工程期間終DataGridViewTextBoxColumn.ReadOnly = True
        '
        '部署ＩＤDataGridViewTextBoxColumn
        '
        Me.部署ＩＤDataGridViewTextBoxColumn.DataPropertyName = "部署ＩＤ"
        Me.部署ＩＤDataGridViewTextBoxColumn.DataSource = Me.日報部署BindingSource
        Me.部署ＩＤDataGridViewTextBoxColumn.DisplayMember = "部署名"
        Me.部署ＩＤDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.部署ＩＤDataGridViewTextBoxColumn.HeaderText = "部署ＩＤ"
        Me.部署ＩＤDataGridViewTextBoxColumn.Name = "部署ＩＤDataGridViewTextBoxColumn"
        Me.部署ＩＤDataGridViewTextBoxColumn.ReadOnly = True
        Me.部署ＩＤDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.部署ＩＤDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.部署ＩＤDataGridViewTextBoxColumn.ValueMember = "部署ＩＤ"
        '
        '日報部署BindingSource
        '
        Me.日報部署BindingSource.DataMember = "日報部署dtbl"
        Me.日報部署BindingSource.DataSource = Me.DailyWorksDataSet
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.社内工数DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.社内工数DataGridViewTextBoxColumn.DividerWidth = 2
        Me.社内工数DataGridViewTextBoxColumn.HeaderText = "社内工数"
        Me.社内工数DataGridViewTextBoxColumn.Name = "社内工数DataGridViewTextBoxColumn"
        Me.社内工数DataGridViewTextBoxColumn.ReadOnly = True
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
        '工程備考１DataGridViewTextBoxColumn
        '
        Me.工程備考１DataGridViewTextBoxColumn.DataPropertyName = "工程備考１"
        Me.工程備考１DataGridViewTextBoxColumn.HeaderText = "工程備考１"
        Me.工程備考１DataGridViewTextBoxColumn.Name = "工程備考１DataGridViewTextBoxColumn"
        Me.工程備考１DataGridViewTextBoxColumn.ReadOnly = True
        Me.工程備考１DataGridViewTextBoxColumn.Width = 180
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
        Me.土曜含DataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.土曜含DataGridViewTextBoxColumn.HeaderText = "土曜含"
        Me.土曜含DataGridViewTextBoxColumn.Name = "土曜含DataGridViewTextBoxColumn"
        Me.土曜含DataGridViewTextBoxColumn.ReadOnly = True
        Me.土曜含DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.土曜含DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.土曜含DataGridViewTextBoxColumn.TrueValue = "1"
        Me.土曜含DataGridViewTextBoxColumn.Width = 60
        '
        '日曜含DataGridViewTextBoxColumn
        '
        Me.日曜含DataGridViewTextBoxColumn.DataPropertyName = "日曜含"
        Me.日曜含DataGridViewTextBoxColumn.DividerWidth = 2
        Me.日曜含DataGridViewTextBoxColumn.FalseValue = "0"
        Me.日曜含DataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.日曜含DataGridViewTextBoxColumn.HeaderText = "日曜含"
        Me.日曜含DataGridViewTextBoxColumn.Name = "日曜含DataGridViewTextBoxColumn"
        Me.日曜含DataGridViewTextBoxColumn.ReadOnly = True
        Me.日曜含DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.日曜含DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.日曜含DataGridViewTextBoxColumn.TrueValue = "1"
        Me.日曜含DataGridViewTextBoxColumn.Width = 60
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.職種コードDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.職種コードDataGridViewTextBoxColumn.HeaderText = "職種コード"
        Me.職種コードDataGridViewTextBoxColumn.Name = "職種コードDataGridViewTextBoxColumn"
        Me.職種コードDataGridViewTextBoxColumn.ReadOnly = True
        Me.職種コードDataGridViewTextBoxColumn.Visible = False
        '
        '日毎社工DataGridViewTextBoxColumn
        '
        Me.日毎社工DataGridViewTextBoxColumn.DataPropertyName = "日毎社工"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.日毎社工DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.日毎社工DataGridViewTextBoxColumn.HeaderText = "時/日"
        Me.日毎社工DataGridViewTextBoxColumn.Name = "日毎社工DataGridViewTextBoxColumn"
        Me.日毎社工DataGridViewTextBoxColumn.ReadOnly = True
        '
        '日報工程予算BindingSource
        '
        Me.日報工程予算BindingSource.DataMember = "日報工程予算dtbl"
        Me.日報工程予算BindingSource.DataSource = Me.DailyWorksDataSet
        '
        '日報会社休日dtblTableAdapter1
        '
        Me.日報会社休日dtblTableAdapter1.ClearBeforeFill = True
        '
        '日報部署dtblTableAdapter1
        '
        Me.日報部署dtblTableAdapter1.ClearBeforeFill = True
        '
        '日報工程予算dtblTableAdapter1
        '
        Me.日報工程予算dtblTableAdapter1.ClearBeforeFill = True
        '
        '日報工程dtblTableAdapter1
        '
        Me.日報工程dtblTableAdapter1.ClearBeforeFill = True
        '
        '日報人実績一覧dtblTableAdapter1
        '
        Me.日報人実績一覧dtblTableAdapter1.ClearBeforeFill = True
        '
        '日報人実績一覧サブdtblTableAdapter1
        '
        Me.日報人実績一覧サブdtblTableAdapter1.ClearBeforeFill = True
        '
        '工事別日報予算Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Splitter1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "工事別日報予算Form"
        Me.Text = "工事別日報予算"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.部署人数DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.日報実績DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報人実績一覧BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.予算工数DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報工程BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報部署BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.日報工程予算BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DisplayAllButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents 合計人数TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents 部署人数DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ConstructionNoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonOpenConstDialog As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents 日報実績DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 予算工数DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 日報会社休日dtblTableAdapter1 As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報会社休日dtblTableAdapter
    Friend WithEvents 日報部署dtblTableAdapter1 As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報部署dtblTableAdapter
    Friend WithEvents DailyWorksDataSet As FujiSysForFactory3.DailyWorksDataSet
    Friend WithEvents 日報工程予算BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 日報工程予算dtblTableAdapter1 As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報工程予算dtblTableAdapter
    Friend WithEvents 日報工程dtblTableAdapter1 As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報工程dtblTableAdapter
    Friend WithEvents 日報人実績一覧BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 日報人実績一覧dtblTableAdapter1 As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報人実績一覧dtblTableAdapter
    Friend WithEvents 日報人実績一覧サブdtblTableAdapter1 As FujiSysForFactory3.DailyWorksDataSetTableAdapters.日報人実績一覧サブdtblTableAdapter
    Friend WithEvents 日報部署BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 日報工程BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 社員ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 社員ＩＤ名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 最小人別DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 最大人別DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工数計DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 部署ＩＤDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents 予算工数計TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 実績工数計TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents 工程ＩＤDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents 工程予算ＮＯDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事番号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程パスDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 表示順DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents 工程備考１DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程備考２DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工程備考３DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 土曜含DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents 日曜含DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents 製作品詳細対象DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 設備コードDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 職種コードDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 日毎社工DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
