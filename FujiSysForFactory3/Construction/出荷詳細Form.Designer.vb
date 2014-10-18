<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 出荷詳細Form
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
        Dim 工事番号Label As System.Windows.Forms.Label
        Dim 工程期間始Label As System.Windows.Forms.Label
        Dim 工程期間終Label As System.Windows.Forms.Label
        Dim 部署ＩＤLabel As System.Windows.Forms.Label
        Dim 工程備考１Label As System.Windows.Forms.Label
        Dim 取引先ＩＤLabel As System.Windows.Forms.Label
        Dim 営業社員ＩＤLabel As System.Windows.Forms.Label
        Dim 工事名Label As System.Windows.Forms.Label
        Dim 工事範囲Label As System.Windows.Forms.Label
        Dim 生管社員ＩＤLabel As System.Windows.Forms.Label
        Dim 数量Label As System.Windows.Forms.Label
        Dim 工場出荷分割数Label As System.Windows.Forms.Label
        Dim 工場出荷特記Label As System.Windows.Forms.Label
        Dim 納品備考Label As System.Windows.Forms.Label
        Dim 納品方法Label As System.Windows.Forms.Label
        Dim 自社納品担当Label As System.Windows.Forms.Label
        Dim 運送業者ＩＤLabel As System.Windows.Forms.Label
        Dim 納品先住所Label As System.Windows.Forms.Label
        Dim 納品先名称Label As System.Windows.Forms.Label
        Dim 納品先担当者Label As System.Windows.Forms.Label
        Dim 納品先担当連絡先Label As System.Windows.Forms.Label
        Dim 分納時対象範囲Label As System.Windows.Forms.Label
        Dim 顧客番号等Label As System.Windows.Forms.Label
        Dim 納品数量Label As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim 社内工数Label As System.Windows.Forms.Label
        Me.出荷詳細dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.出荷詳細dtblTableAdapter()
        Me.ConstructionDataSet1 = New FujiSysForFactory3.ConstructionDataSet()
        Me.出荷詳細dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager()
        Me.工事取引先最新dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter()
        Me.工事取引先最新dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事生管担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事生管担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter()
        Me.受注営業担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.受注営業担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter()
        Me.工事部署dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事部署dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事部署dtblTableAdapter()
        Me.工事番号TextBox = New System.Windows.Forms.TextBox()
        Me.工程期間始TextBox = New System.Windows.Forms.TextBox()
        Me.工程期間終TextBox = New System.Windows.Forms.TextBox()
        Me.部署ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.工程備考１TextBox = New System.Windows.Forms.TextBox()
        Me.取引先ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.営業社員ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.工事名TextBox = New System.Windows.Forms.TextBox()
        Me.工事範囲TextBox = New System.Windows.Forms.TextBox()
        Me.生管社員ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.数量TextBox = New System.Windows.Forms.TextBox()
        Me.工場出荷分割数TextBox = New System.Windows.Forms.TextBox()
        Me.工場出荷特記TextBox = New System.Windows.Forms.TextBox()
        Me.納品備考TextBox = New System.Windows.Forms.TextBox()
        Me.納品方法TextBox = New System.Windows.Forms.TextBox()
        Me.自社納品担当ComboBox = New System.Windows.Forms.ComboBox()
        Me.工事歴代社員dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.運送業者ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.納品先住所TextBox = New System.Windows.Forms.TextBox()
        Me.納品先名称TextBox = New System.Windows.Forms.TextBox()
        Me.納品先担当者TextBox = New System.Windows.Forms.TextBox()
        Me.納品先担当連絡先TextBox = New System.Windows.Forms.TextBox()
        Me.分納時対象範囲TextBox = New System.Windows.Forms.TextBox()
        Me.顧客番号等TextBox = New System.Windows.Forms.TextBox()
        Me.納品数量TextBox = New System.Windows.Forms.TextBox()
        Me.工事歴代社員dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事歴代社員dtblTableAdapter()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.社内工数TextBox = New System.Windows.Forms.TextBox()
        工事番号Label = New System.Windows.Forms.Label()
        工程期間始Label = New System.Windows.Forms.Label()
        工程期間終Label = New System.Windows.Forms.Label()
        部署ＩＤLabel = New System.Windows.Forms.Label()
        工程備考１Label = New System.Windows.Forms.Label()
        取引先ＩＤLabel = New System.Windows.Forms.Label()
        営業社員ＩＤLabel = New System.Windows.Forms.Label()
        工事名Label = New System.Windows.Forms.Label()
        工事範囲Label = New System.Windows.Forms.Label()
        生管社員ＩＤLabel = New System.Windows.Forms.Label()
        数量Label = New System.Windows.Forms.Label()
        工場出荷分割数Label = New System.Windows.Forms.Label()
        工場出荷特記Label = New System.Windows.Forms.Label()
        納品備考Label = New System.Windows.Forms.Label()
        納品方法Label = New System.Windows.Forms.Label()
        自社納品担当Label = New System.Windows.Forms.Label()
        運送業者ＩＤLabel = New System.Windows.Forms.Label()
        納品先住所Label = New System.Windows.Forms.Label()
        納品先名称Label = New System.Windows.Forms.Label()
        納品先担当者Label = New System.Windows.Forms.Label()
        納品先担当連絡先Label = New System.Windows.Forms.Label()
        分納時対象範囲Label = New System.Windows.Forms.Label()
        顧客番号等Label = New System.Windows.Forms.Label()
        納品数量Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        社内工数Label = New System.Windows.Forms.Label()
        CType(Me.ConstructionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.出荷詳細dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事取引先最新dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事部署dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事歴代社員dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '工事番号Label
        '
        工事番号Label.AutoSize = True
        工事番号Label.Location = New System.Drawing.Point(36, 28)
        工事番号Label.Name = "工事番号Label"
        工事番号Label.Size = New System.Drawing.Size(89, 19)
        工事番号Label.TabIndex = 0
        工事番号Label.Text = "工事番号:"
        '
        '工程期間始Label
        '
        工程期間始Label.AutoSize = True
        工程期間始Label.Location = New System.Drawing.Point(55, 233)
        工程期間始Label.Name = "工程期間始Label"
        工程期間始Label.Size = New System.Drawing.Size(70, 19)
        工程期間始Label.TabIndex = 2
        工程期間始Label.Text = "期間始:"
        '
        '工程期間終Label
        '
        工程期間終Label.AutoSize = True
        工程期間終Label.Location = New System.Drawing.Point(55, 266)
        工程期間終Label.Name = "工程期間終Label"
        工程期間終Label.Size = New System.Drawing.Size(70, 19)
        工程期間終Label.TabIndex = 4
        工程期間終Label.Text = "期間終:"
        '
        '部署ＩＤLabel
        '
        部署ＩＤLabel.AutoSize = True
        部署ＩＤLabel.Location = New System.Drawing.Point(40, 329)
        部署ＩＤLabel.Name = "部署ＩＤLabel"
        部署ＩＤLabel.Size = New System.Drawing.Size(85, 38)
        部署ＩＤLabel.TabIndex = 6
        部署ＩＤLabel.Text = "実行予定" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "部署:"
        '
        '工程備考１Label
        '
        工程備考１Label.AutoSize = True
        工程備考１Label.Location = New System.Drawing.Point(23, 377)
        工程備考１Label.Name = "工程備考１Label"
        工程備考１Label.Size = New System.Drawing.Size(89, 19)
        工程備考１Label.TabIndex = 8
        工程備考１Label.Text = "工程備考:"
        '
        '取引先ＩＤLabel
        '
        取引先ＩＤLabel.AutoSize = True
        取引先ＩＤLabel.Location = New System.Drawing.Point(55, 103)
        取引先ＩＤLabel.Name = "取引先ＩＤLabel"
        取引先ＩＤLabel.Size = New System.Drawing.Size(70, 19)
        取引先ＩＤLabel.TabIndex = 10
        取引先ＩＤLabel.Text = "取引先:"
        '
        '営業社員ＩＤLabel
        '
        営業社員ＩＤLabel.AutoSize = True
        営業社員ＩＤLabel.Location = New System.Drawing.Point(36, 136)
        営業社員ＩＤLabel.Name = "営業社員ＩＤLabel"
        営業社員ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        営業社員ＩＤLabel.TabIndex = 12
        営業社員ＩＤLabel.Text = "営業担当:"
        '
        '工事名Label
        '
        工事名Label.AutoSize = True
        工事名Label.Location = New System.Drawing.Point(313, 29)
        工事名Label.Name = "工事名Label"
        工事名Label.Size = New System.Drawing.Size(70, 19)
        工事名Label.TabIndex = 14
        工事名Label.Text = "工事名:"
        '
        '工事範囲Label
        '
        工事範囲Label.AutoSize = True
        工事範囲Label.Location = New System.Drawing.Point(294, 63)
        工事範囲Label.Name = "工事範囲Label"
        工事範囲Label.Size = New System.Drawing.Size(89, 19)
        工事範囲Label.TabIndex = 16
        工事範囲Label.Text = "工事範囲:"
        '
        '生管社員ＩＤLabel
        '
        生管社員ＩＤLabel.AutoSize = True
        生管社員ＩＤLabel.Location = New System.Drawing.Point(36, 169)
        生管社員ＩＤLabel.Name = "生管社員ＩＤLabel"
        生管社員ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        生管社員ＩＤLabel.TabIndex = 18
        生管社員ＩＤLabel.Text = "生管担当:"
        '
        '数量Label
        '
        数量Label.AutoSize = True
        数量Label.Location = New System.Drawing.Point(74, 64)
        数量Label.Name = "数量Label"
        数量Label.Size = New System.Drawing.Size(51, 19)
        数量Label.TabIndex = 20
        数量Label.Text = "数量:"
        '
        '工場出荷分割数Label
        '
        工場出荷分割数Label.AutoSize = True
        工場出荷分割数Label.Location = New System.Drawing.Point(298, 136)
        工場出荷分割数Label.Name = "工場出荷分割数Label"
        工場出荷分割数Label.Size = New System.Drawing.Size(85, 38)
        工場出荷分割数Label.TabIndex = 22
        工場出荷分割数Label.Text = "工場出荷" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "分割数:"
        '
        '工場出荷特記Label
        '
        工場出荷特記Label.AutoSize = True
        工場出荷特記Label.Location = New System.Drawing.Point(511, 137)
        工場出荷特記Label.Name = "工場出荷特記Label"
        工場出荷特記Label.Size = New System.Drawing.Size(127, 19)
        工場出荷特記Label.TabIndex = 24
        工場出荷特記Label.Text = "工場出荷特記:"
        '
        '納品備考Label
        '
        納品備考Label.AutoSize = True
        納品備考Label.Location = New System.Drawing.Point(517, 530)
        納品備考Label.Name = "納品備考Label"
        納品備考Label.Size = New System.Drawing.Size(89, 19)
        納品備考Label.TabIndex = 26
        納品備考Label.Text = "納品備考:"
        '
        '納品方法Label
        '
        納品方法Label.AutoSize = True
        納品方法Label.Location = New System.Drawing.Point(36, 432)
        納品方法Label.Name = "納品方法Label"
        納品方法Label.Size = New System.Drawing.Size(89, 19)
        納品方法Label.TabIndex = 28
        納品方法Label.Text = "納品方法:"
        '
        '自社納品担当Label
        '
        自社納品担当Label.AutoSize = True
        自社納品担当Label.Location = New System.Drawing.Point(-2, 464)
        自社納品担当Label.Name = "自社納品担当Label"
        自社納品担当Label.Size = New System.Drawing.Size(127, 19)
        自社納品担当Label.TabIndex = 30
        自社納品担当Label.Text = "自社納品担当:"
        '
        '運送業者ＩＤLabel
        '
        運送業者ＩＤLabel.AutoSize = True
        運送業者ＩＤLabel.Location = New System.Drawing.Point(17, 497)
        運送業者ＩＤLabel.Name = "運送業者ＩＤLabel"
        運送業者ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        運送業者ＩＤLabel.TabIndex = 32
        運送業者ＩＤLabel.Text = "運送業者:"
        '
        '納品先住所Label
        '
        納品先住所Label.AutoSize = True
        納品先住所Label.Location = New System.Drawing.Point(498, 229)
        納品先住所Label.Name = "納品先住所Label"
        納品先住所Label.Size = New System.Drawing.Size(108, 19)
        納品先住所Label.TabIndex = 34
        納品先住所Label.Text = "納品先住所:"
        '
        '納品先名称Label
        '
        納品先名称Label.AutoSize = True
        納品先名称Label.Location = New System.Drawing.Point(498, 295)
        納品先名称Label.Name = "納品先名称Label"
        納品先名称Label.Size = New System.Drawing.Size(108, 19)
        納品先名称Label.TabIndex = 36
        納品先名称Label.Text = "納品先名称:"
        '
        '納品先担当者Label
        '
        納品先担当者Label.AutoSize = True
        納品先担当者Label.Location = New System.Drawing.Point(479, 340)
        納品先担当者Label.Name = "納品先担当者Label"
        納品先担当者Label.Size = New System.Drawing.Size(127, 19)
        納品先担当者Label.TabIndex = 38
        納品先担当者Label.Text = "納品先担当者:"
        '
        '納品先担当連絡先Label
        '
        納品先担当連絡先Label.AutoSize = True
        納品先担当連絡先Label.Location = New System.Drawing.Point(441, 372)
        納品先担当連絡先Label.Name = "納品先担当連絡先Label"
        納品先担当連絡先Label.Size = New System.Drawing.Size(165, 19)
        納品先担当連絡先Label.TabIndex = 40
        納品先担当連絡先Label.Text = "納品先担当連絡先:"
        '
        '分納時対象範囲Label
        '
        分納時対象範囲Label.AutoSize = True
        分納時対象範囲Label.Location = New System.Drawing.Point(460, 445)
        分納時対象範囲Label.Name = "分納時対象範囲Label"
        分納時対象範囲Label.Size = New System.Drawing.Size(146, 19)
        分納時対象範囲Label.TabIndex = 42
        分納時対象範囲Label.Text = "分納時対象範囲:"
        '
        '顧客番号等Label
        '
        顧客番号等Label.AutoSize = True
        顧客番号等Label.Location = New System.Drawing.Point(498, 404)
        顧客番号等Label.Name = "顧客番号等Label"
        顧客番号等Label.Size = New System.Drawing.Size(108, 19)
        顧客番号等Label.TabIndex = 44
        顧客番号等Label.Text = "顧客番号等:"
        '
        '納品数量Label
        '
        納品数量Label.AutoSize = True
        納品数量Label.Location = New System.Drawing.Point(36, 530)
        納品数量Label.Name = "納品数量Label"
        納品数量Label.Size = New System.Drawing.Size(89, 19)
        納品数量Label.TabIndex = 46
        納品数量Label.Text = "納品数量:"
        '
        'Label1
        '
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label1.Location = New System.Drawing.Point(17, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(1099, 186)
        Label1.TabIndex = 48
        '
        'Label2
        '
        Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label2.Location = New System.Drawing.Point(17, 210)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(391, 197)
        Label2.TabIndex = 49
        '
        '社内工数Label
        '
        社内工数Label.AutoSize = True
        社内工数Label.Location = New System.Drawing.Point(36, 299)
        社内工数Label.Name = "社内工数Label"
        社内工数Label.Size = New System.Drawing.Size(89, 19)
        社内工数Label.TabIndex = 66
        社内工数Label.Text = "予定工数:"
        '
        '出荷詳細dtblTableAdapter1
        '
        Me.出荷詳細dtblTableAdapter1.ClearBeforeFill = True
        '
        'ConstructionDataSet1
        '
        Me.ConstructionDataSet1.DataSetName = "ConstructionDataSet"
        Me.ConstructionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '出荷詳細dtblBindingSource
        '
        Me.出荷詳細dtblBindingSource.DataMember = "出荷詳細dtbl"
        Me.出荷詳細dtblBindingSource.DataSource = Me.ConstructionDataSet1
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
        '工事取引先最新dtblTableAdapter1
        '
        Me.工事取引先最新dtblTableAdapter1.ClearBeforeFill = True
        '
        '工事取引先最新dtblBindingSource
        '
        Me.工事取引先最新dtblBindingSource.DataMember = "工事取引先最新dtbl"
        Me.工事取引先最新dtblBindingSource.DataSource = Me.ConstructionDataSet1
        '
        '工事生管担当dtblBindingSource
        '
        Me.工事生管担当dtblBindingSource.DataMember = "工事生管担当dtbl"
        Me.工事生管担当dtblBindingSource.DataSource = Me.ConstructionDataSet1
        '
        '工事生管担当dtblTableAdapter
        '
        Me.工事生管担当dtblTableAdapter.ClearBeforeFill = True
        '
        '受注営業担当dtblBindingSource
        '
        Me.受注営業担当dtblBindingSource.DataMember = "受注営業担当dtbl"
        Me.受注営業担当dtblBindingSource.DataSource = Me.ConstructionDataSet1
        '
        '受注営業担当dtblTableAdapter
        '
        Me.受注営業担当dtblTableAdapter.ClearBeforeFill = True
        '
        '工事部署dtblBindingSource
        '
        Me.工事部署dtblBindingSource.DataMember = "工事部署dtbl"
        Me.工事部署dtblBindingSource.DataSource = Me.ConstructionDataSet1
        '
        '工事部署dtblTableAdapter
        '
        Me.工事部署dtblTableAdapter.ClearBeforeFill = True
        '
        '工事番号TextBox
        '
        Me.工事番号TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事番号TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事番号TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "工事番号", True))
        Me.工事番号TextBox.Location = New System.Drawing.Point(131, 25)
        Me.工事番号TextBox.Name = "工事番号TextBox"
        Me.工事番号TextBox.ReadOnly = True
        Me.工事番号TextBox.Size = New System.Drawing.Size(160, 26)
        Me.工事番号TextBox.TabIndex = 1
        '
        '工程期間始TextBox
        '
        Me.工程期間始TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工程期間始TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工程期間始TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "工程期間始", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.工程期間始TextBox.Location = New System.Drawing.Point(131, 231)
        Me.工程期間始TextBox.Name = "工程期間始TextBox"
        Me.工程期間始TextBox.ReadOnly = True
        Me.工程期間始TextBox.Size = New System.Drawing.Size(160, 26)
        Me.工程期間始TextBox.TabIndex = 3
        Me.工程期間始TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '工程期間終TextBox
        '
        Me.工程期間終TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工程期間終TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工程期間終TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "工程期間終", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.工程期間終TextBox.Location = New System.Drawing.Point(131, 264)
        Me.工程期間終TextBox.Name = "工程期間終TextBox"
        Me.工程期間終TextBox.ReadOnly = True
        Me.工程期間終TextBox.Size = New System.Drawing.Size(160, 26)
        Me.工程期間終TextBox.TabIndex = 5
        Me.工程期間終TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '部署ＩＤComboBox
        '
        Me.部署ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.部署ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.出荷詳細dtblBindingSource, "部署ＩＤ", True))
        Me.部署ＩＤComboBox.DataSource = Me.工事部署dtblBindingSource
        Me.部署ＩＤComboBox.DisplayMember = "部署名"
        Me.部署ＩＤComboBox.Enabled = False
        Me.部署ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.部署ＩＤComboBox.FormattingEnabled = True
        Me.部署ＩＤComboBox.Location = New System.Drawing.Point(131, 329)
        Me.部署ＩＤComboBox.Name = "部署ＩＤComboBox"
        Me.部署ＩＤComboBox.Size = New System.Drawing.Size(160, 27)
        Me.部署ＩＤComboBox.TabIndex = 7
        Me.部署ＩＤComboBox.ValueMember = "部署ＩＤ"
        '
        '工程備考１TextBox
        '
        Me.工程備考１TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工程備考１TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工程備考１TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "工程備考１", True))
        Me.工程備考１TextBox.Location = New System.Drawing.Point(131, 375)
        Me.工程備考１TextBox.Name = "工程備考１TextBox"
        Me.工程備考１TextBox.ReadOnly = True
        Me.工程備考１TextBox.Size = New System.Drawing.Size(265, 26)
        Me.工程備考１TextBox.TabIndex = 9
        '
        '取引先ＩＤComboBox
        '
        Me.取引先ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.取引先ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.出荷詳細dtblBindingSource, "取引先ＩＤ", True))
        Me.取引先ＩＤComboBox.DataSource = Me.工事取引先最新dtblBindingSource
        Me.取引先ＩＤComboBox.DisplayMember = "取引先略称"
        Me.取引先ＩＤComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.取引先ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.取引先ＩＤComboBox.FormattingEnabled = True
        Me.取引先ＩＤComboBox.Location = New System.Drawing.Point(131, 100)
        Me.取引先ＩＤComboBox.Name = "取引先ＩＤComboBox"
        Me.取引先ＩＤComboBox.Size = New System.Drawing.Size(160, 27)
        Me.取引先ＩＤComboBox.TabIndex = 11
        Me.取引先ＩＤComboBox.ValueMember = "取引先ＩＤ"
        '
        '営業社員ＩＤComboBox
        '
        Me.営業社員ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.営業社員ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.出荷詳細dtblBindingSource, "営業社員ＩＤ", True))
        Me.営業社員ＩＤComboBox.DataSource = Me.受注営業担当dtblBindingSource
        Me.営業社員ＩＤComboBox.DisplayMember = "社員名"
        Me.営業社員ＩＤComboBox.Enabled = False
        Me.営業社員ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.営業社員ＩＤComboBox.FormattingEnabled = True
        Me.営業社員ＩＤComboBox.Location = New System.Drawing.Point(131, 133)
        Me.営業社員ＩＤComboBox.Name = "営業社員ＩＤComboBox"
        Me.営業社員ＩＤComboBox.Size = New System.Drawing.Size(160, 27)
        Me.営業社員ＩＤComboBox.TabIndex = 13
        Me.営業社員ＩＤComboBox.ValueMember = "社員ＩＤ"
        '
        '工事名TextBox
        '
        Me.工事名TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事名TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "工事名", True))
        Me.工事名TextBox.Location = New System.Drawing.Point(389, 26)
        Me.工事名TextBox.Name = "工事名TextBox"
        Me.工事名TextBox.ReadOnly = True
        Me.工事名TextBox.Size = New System.Drawing.Size(649, 26)
        Me.工事名TextBox.TabIndex = 15
        '
        '工事範囲TextBox
        '
        Me.工事範囲TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事範囲TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事範囲TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "工事範囲", True))
        Me.工事範囲TextBox.Location = New System.Drawing.Point(389, 60)
        Me.工事範囲TextBox.Multiline = True
        Me.工事範囲TextBox.Name = "工事範囲TextBox"
        Me.工事範囲TextBox.ReadOnly = True
        Me.工事範囲TextBox.Size = New System.Drawing.Size(710, 67)
        Me.工事範囲TextBox.TabIndex = 17
        '
        '生管社員ＩＤComboBox
        '
        Me.生管社員ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.生管社員ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.出荷詳細dtblBindingSource, "生管社員ＩＤ", True))
        Me.生管社員ＩＤComboBox.DataSource = Me.工事生管担当dtblBindingSource
        Me.生管社員ＩＤComboBox.DisplayMember = "社員名"
        Me.生管社員ＩＤComboBox.Enabled = False
        Me.生管社員ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.生管社員ＩＤComboBox.FormattingEnabled = True
        Me.生管社員ＩＤComboBox.Location = New System.Drawing.Point(131, 166)
        Me.生管社員ＩＤComboBox.Name = "生管社員ＩＤComboBox"
        Me.生管社員ＩＤComboBox.Size = New System.Drawing.Size(160, 27)
        Me.生管社員ＩＤComboBox.TabIndex = 19
        Me.生管社員ＩＤComboBox.ValueMember = "社員ＩＤ"
        '
        '数量TextBox
        '
        Me.数量TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.数量TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.数量TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "数量", True))
        Me.数量TextBox.Location = New System.Drawing.Point(131, 61)
        Me.数量TextBox.Name = "数量TextBox"
        Me.数量TextBox.ReadOnly = True
        Me.数量TextBox.Size = New System.Drawing.Size(160, 26)
        Me.数量TextBox.TabIndex = 21
        '
        '工場出荷分割数TextBox
        '
        Me.工場出荷分割数TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工場出荷分割数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工場出荷分割数TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "工場出荷分割数", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.工場出荷分割数TextBox.Location = New System.Drawing.Point(389, 134)
        Me.工場出荷分割数TextBox.Name = "工場出荷分割数TextBox"
        Me.工場出荷分割数TextBox.ReadOnly = True
        Me.工場出荷分割数TextBox.Size = New System.Drawing.Size(100, 26)
        Me.工場出荷分割数TextBox.TabIndex = 23
        Me.工場出荷分割数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '工場出荷特記TextBox
        '
        Me.工場出荷特記TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工場出荷特記TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工場出荷特記TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "工場出荷特記", True))
        Me.工場出荷特記TextBox.Location = New System.Drawing.Point(644, 134)
        Me.工場出荷特記TextBox.Multiline = True
        Me.工場出荷特記TextBox.Name = "工場出荷特記TextBox"
        Me.工場出荷特記TextBox.ReadOnly = True
        Me.工場出荷特記TextBox.Size = New System.Drawing.Size(394, 59)
        Me.工場出荷特記TextBox.TabIndex = 25
        '
        '納品備考TextBox
        '
        Me.納品備考TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.納品備考TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.納品備考TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "納品備考", True))
        Me.納品備考TextBox.Location = New System.Drawing.Point(612, 527)
        Me.納品備考TextBox.Multiline = True
        Me.納品備考TextBox.Name = "納品備考TextBox"
        Me.納品備考TextBox.ReadOnly = True
        Me.納品備考TextBox.Size = New System.Drawing.Size(588, 117)
        Me.納品備考TextBox.TabIndex = 27
        '
        '納品方法TextBox
        '
        Me.納品方法TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.納品方法TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.納品方法TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "納品方法", True))
        Me.納品方法TextBox.Location = New System.Drawing.Point(131, 429)
        Me.納品方法TextBox.Name = "納品方法TextBox"
        Me.納品方法TextBox.ReadOnly = True
        Me.納品方法TextBox.Size = New System.Drawing.Size(265, 26)
        Me.納品方法TextBox.TabIndex = 29
        '
        '自社納品担当ComboBox
        '
        Me.自社納品担当ComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.自社納品担当ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.出荷詳細dtblBindingSource, "自社納品担当", True))
        Me.自社納品担当ComboBox.DataSource = Me.工事歴代社員dtblBindingSource
        Me.自社納品担当ComboBox.DisplayMember = "社員名"
        Me.自社納品担当ComboBox.Enabled = False
        Me.自社納品担当ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.自社納品担当ComboBox.FormattingEnabled = True
        Me.自社納品担当ComboBox.Location = New System.Drawing.Point(131, 461)
        Me.自社納品担当ComboBox.Name = "自社納品担当ComboBox"
        Me.自社納品担当ComboBox.Size = New System.Drawing.Size(265, 27)
        Me.自社納品担当ComboBox.TabIndex = 31
        Me.自社納品担当ComboBox.ValueMember = "社員ＩＤ"
        '
        '工事歴代社員dtblBindingSource
        '
        Me.工事歴代社員dtblBindingSource.DataMember = "工事歴代社員dtbl"
        Me.工事歴代社員dtblBindingSource.DataSource = Me.ConstructionDataSet1
        '
        '運送業者ＩＤComboBox
        '
        Me.運送業者ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.運送業者ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.出荷詳細dtblBindingSource, "運送業者ＩＤ", True))
        Me.運送業者ＩＤComboBox.DataSource = Me.工事取引先最新dtblBindingSource
        Me.運送業者ＩＤComboBox.DisplayMember = "取引先略称"
        Me.運送業者ＩＤComboBox.Enabled = False
        Me.運送業者ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.運送業者ＩＤComboBox.FormattingEnabled = True
        Me.運送業者ＩＤComboBox.Location = New System.Drawing.Point(131, 494)
        Me.運送業者ＩＤComboBox.Name = "運送業者ＩＤComboBox"
        Me.運送業者ＩＤComboBox.Size = New System.Drawing.Size(265, 27)
        Me.運送業者ＩＤComboBox.TabIndex = 33
        Me.運送業者ＩＤComboBox.ValueMember = "取引先ＩＤ"
        '
        '納品先住所TextBox
        '
        Me.納品先住所TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.納品先住所TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.納品先住所TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "納品先住所", True))
        Me.納品先住所TextBox.Location = New System.Drawing.Point(612, 226)
        Me.納品先住所TextBox.Multiline = True
        Me.納品先住所TextBox.Name = "納品先住所TextBox"
        Me.納品先住所TextBox.ReadOnly = True
        Me.納品先住所TextBox.Size = New System.Drawing.Size(588, 59)
        Me.納品先住所TextBox.TabIndex = 35
        '
        '納品先名称TextBox
        '
        Me.納品先名称TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.納品先名称TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.納品先名称TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "納品先名称", True))
        Me.納品先名称TextBox.Location = New System.Drawing.Point(612, 292)
        Me.納品先名称TextBox.Name = "納品先名称TextBox"
        Me.納品先名称TextBox.ReadOnly = True
        Me.納品先名称TextBox.Size = New System.Drawing.Size(588, 26)
        Me.納品先名称TextBox.TabIndex = 37
        '
        '納品先担当者TextBox
        '
        Me.納品先担当者TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.納品先担当者TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.納品先担当者TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "納品先担当者", True))
        Me.納品先担当者TextBox.Location = New System.Drawing.Point(612, 337)
        Me.納品先担当者TextBox.Name = "納品先担当者TextBox"
        Me.納品先担当者TextBox.ReadOnly = True
        Me.納品先担当者TextBox.Size = New System.Drawing.Size(588, 26)
        Me.納品先担当者TextBox.TabIndex = 39
        '
        '納品先担当連絡先TextBox
        '
        Me.納品先担当連絡先TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.納品先担当連絡先TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.納品先担当連絡先TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "納品先担当連絡先", True))
        Me.納品先担当連絡先TextBox.Location = New System.Drawing.Point(612, 369)
        Me.納品先担当連絡先TextBox.Name = "納品先担当連絡先TextBox"
        Me.納品先担当連絡先TextBox.ReadOnly = True
        Me.納品先担当連絡先TextBox.Size = New System.Drawing.Size(588, 26)
        Me.納品先担当連絡先TextBox.TabIndex = 41
        '
        '分納時対象範囲TextBox
        '
        Me.分納時対象範囲TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.分納時対象範囲TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.分納時対象範囲TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "分納時対象範囲", True))
        Me.分納時対象範囲TextBox.Location = New System.Drawing.Point(612, 442)
        Me.分納時対象範囲TextBox.Multiline = True
        Me.分納時対象範囲TextBox.Name = "分納時対象範囲TextBox"
        Me.分納時対象範囲TextBox.ReadOnly = True
        Me.分納時対象範囲TextBox.Size = New System.Drawing.Size(588, 64)
        Me.分納時対象範囲TextBox.TabIndex = 43
        '
        '顧客番号等TextBox
        '
        Me.顧客番号等TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.顧客番号等TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.顧客番号等TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "顧客番号等", True))
        Me.顧客番号等TextBox.Location = New System.Drawing.Point(612, 401)
        Me.顧客番号等TextBox.Name = "顧客番号等TextBox"
        Me.顧客番号等TextBox.ReadOnly = True
        Me.顧客番号等TextBox.Size = New System.Drawing.Size(588, 26)
        Me.顧客番号等TextBox.TabIndex = 45
        '
        '納品数量TextBox
        '
        Me.納品数量TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.納品数量TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.納品数量TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "納品数量", True))
        Me.納品数量TextBox.Location = New System.Drawing.Point(131, 527)
        Me.納品数量TextBox.Name = "納品数量TextBox"
        Me.納品数量TextBox.ReadOnly = True
        Me.納品数量TextBox.Size = New System.Drawing.Size(265, 26)
        Me.納品数量TextBox.TabIndex = 47
        '
        '工事歴代社員dtblTableAdapter
        '
        Me.工事歴代社員dtblTableAdapter.ClearBeforeFill = True
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(1122, 13)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(120, 74)
        Me.ButtonClose.TabIndex = 66
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        '社内工数TextBox
        '
        Me.社内工数TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.社内工数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.社内工数TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出荷詳細dtblBindingSource, "社内工数", True))
        Me.社内工数TextBox.Location = New System.Drawing.Point(131, 296)
        Me.社内工数TextBox.Name = "社内工数TextBox"
        Me.社内工数TextBox.ReadOnly = True
        Me.社内工数TextBox.Size = New System.Drawing.Size(160, 26)
        Me.社内工数TextBox.TabIndex = 67
        Me.社内工数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '出荷詳細Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 664)
        Me.Controls.Add(社内工数Label)
        Me.Controls.Add(Me.社内工数TextBox)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(納品数量Label)
        Me.Controls.Add(Me.納品数量TextBox)
        Me.Controls.Add(顧客番号等Label)
        Me.Controls.Add(Me.顧客番号等TextBox)
        Me.Controls.Add(分納時対象範囲Label)
        Me.Controls.Add(Me.分納時対象範囲TextBox)
        Me.Controls.Add(納品先担当連絡先Label)
        Me.Controls.Add(Me.納品先担当連絡先TextBox)
        Me.Controls.Add(納品先担当者Label)
        Me.Controls.Add(Me.納品先担当者TextBox)
        Me.Controls.Add(納品先名称Label)
        Me.Controls.Add(Me.納品先名称TextBox)
        Me.Controls.Add(納品先住所Label)
        Me.Controls.Add(Me.納品先住所TextBox)
        Me.Controls.Add(運送業者ＩＤLabel)
        Me.Controls.Add(Me.運送業者ＩＤComboBox)
        Me.Controls.Add(自社納品担当Label)
        Me.Controls.Add(Me.自社納品担当ComboBox)
        Me.Controls.Add(納品方法Label)
        Me.Controls.Add(Me.納品方法TextBox)
        Me.Controls.Add(納品備考Label)
        Me.Controls.Add(Me.納品備考TextBox)
        Me.Controls.Add(工場出荷特記Label)
        Me.Controls.Add(Me.工場出荷特記TextBox)
        Me.Controls.Add(工場出荷分割数Label)
        Me.Controls.Add(Me.工場出荷分割数TextBox)
        Me.Controls.Add(数量Label)
        Me.Controls.Add(Me.数量TextBox)
        Me.Controls.Add(生管社員ＩＤLabel)
        Me.Controls.Add(Me.生管社員ＩＤComboBox)
        Me.Controls.Add(工事範囲Label)
        Me.Controls.Add(Me.工事範囲TextBox)
        Me.Controls.Add(工事名Label)
        Me.Controls.Add(Me.工事名TextBox)
        Me.Controls.Add(営業社員ＩＤLabel)
        Me.Controls.Add(Me.営業社員ＩＤComboBox)
        Me.Controls.Add(取引先ＩＤLabel)
        Me.Controls.Add(Me.取引先ＩＤComboBox)
        Me.Controls.Add(工程備考１Label)
        Me.Controls.Add(Me.工程備考１TextBox)
        Me.Controls.Add(部署ＩＤLabel)
        Me.Controls.Add(Me.部署ＩＤComboBox)
        Me.Controls.Add(工程期間終Label)
        Me.Controls.Add(Me.工程期間終TextBox)
        Me.Controls.Add(工程期間始Label)
        Me.Controls.Add(Me.工程期間始TextBox)
        Me.Controls.Add(工事番号Label)
        Me.Controls.Add(Me.工事番号TextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "出荷詳細Form"
        Me.Text = "出荷詳細"
        CType(Me.ConstructionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.出荷詳細dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事取引先最新dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事部署dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事歴代社員dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 出荷詳細dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.出荷詳細dtblTableAdapter
    Friend WithEvents ConstructionDataSet1 As FujiSysForFactory3.ConstructionDataSet
    Friend WithEvents 出荷詳細dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工事取引先最新dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter
    Friend WithEvents 工事取引先最新dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事生管担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事生管担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter
    Friend WithEvents 受注営業担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 受注営業担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter
    Friend WithEvents 工事部署dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事部署dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事部署dtblTableAdapter
    Friend WithEvents 工事番号TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工程期間始TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工程期間終TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 部署ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 工程備考１TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 取引先ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 営業社員ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 工事名TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事範囲TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 生管社員ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 数量TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工場出荷分割数TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工場出荷特記TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 納品備考TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 納品方法TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 自社納品担当ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 運送業者ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 納品先住所TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 納品先名称TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 納品先担当者TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 納品先担当連絡先TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 分納時対象範囲TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 顧客番号等TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 納品数量TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事歴代社員dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事歴代社員dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事歴代社員dtblTableAdapter
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents 社内工数TextBox As System.Windows.Forms.TextBox
End Class
