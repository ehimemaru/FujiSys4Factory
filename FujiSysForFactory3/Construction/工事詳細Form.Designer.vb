<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 工事詳細Form
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
        Dim 取引先ＩＤLabel2 As System.Windows.Forms.Label
        Dim 営業社員ＩＤLabel As System.Windows.Forms.Label
        Dim 工事名Label As System.Windows.Forms.Label
        Dim 数量Label As System.Windows.Forms.Label
        Dim 生管社員ＩＤLabel As System.Windows.Forms.Label
        Dim 工事概要Label As System.Windows.Forms.Label
        Dim 工事範囲Label As System.Windows.Forms.Label
        Dim 製造範囲ＩＤLabel As System.Windows.Forms.Label
        Dim 材料支給有無Label As System.Windows.Forms.Label
        Dim ミルシート有無Label As System.Windows.Forms.Label
        Dim 材料特記Label As System.Windows.Forms.Label
        Dim 購入品支給有無Label As System.Windows.Forms.Label
        Dim 購入品特記Label As System.Windows.Forms.Label
        Dim その他支給特記Label As System.Windows.Forms.Label
        Dim 工事追記Label As System.Windows.Forms.Label
        Dim 工場出荷分割数Label As System.Windows.Forms.Label
        Dim 工場出荷特記Label As System.Windows.Forms.Label
        Dim 工事完了日Label As System.Windows.Forms.Label
        Dim 検査特記Label As System.Windows.Forms.Label
        Dim 検査仕様書有無Label As System.Windows.Forms.Label
        Dim 製作仕様書有無Label As System.Windows.Forms.Label
        Dim 立会検査有無Label As System.Windows.Forms.Label
        Dim 塗装仕様書有無Label As System.Windows.Forms.Label
        Dim 工程写真有無Label As System.Windows.Forms.Label
        Dim 工程写真特記Label As System.Windows.Forms.Label
        Dim 期間始Label As System.Windows.Forms.Label
        Dim 外注予算Label As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.工事詳細dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事詳細dtblTableAdapter()
        Me.ConstructionDataSet1 = New FujiSysForFactory3.ConstructionDataSet()
        Me.工事詳細BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事取引先最新dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter()
        Me.工事生管担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事生管担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter()
        Me.TableAdapterManager = New FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager()
        Me.受注営業担当dtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.受注営業担当dtblTableAdapter = New FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter()
        Me.工事取引先最新BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.工事番号TextBox = New System.Windows.Forms.TextBox()
        Me.取引先ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.営業社員ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.工事名TextBox = New System.Windows.Forms.TextBox()
        Me.数量TextBox = New System.Windows.Forms.TextBox()
        Me.工事製造範囲dtblTableAdapter1 = New FujiSysForFactory3.ConstructionDataSetTableAdapters.工事製造範囲dtblTableAdapter()
        Me.工事製造範囲BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.生管社員ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.工事概要TextBox = New System.Windows.Forms.TextBox()
        Me.工事範囲TextBox = New System.Windows.Forms.TextBox()
        Me.製造範囲ＩＤComboBox = New System.Windows.Forms.ComboBox()
        Me.材料支給有無CheckBox = New System.Windows.Forms.CheckBox()
        Me.ミルシート有無CheckBox = New System.Windows.Forms.CheckBox()
        Me.材料特記TextBox = New System.Windows.Forms.TextBox()
        Me.購入品支給有無CheckBox = New System.Windows.Forms.CheckBox()
        Me.購入品特記TextBox = New System.Windows.Forms.TextBox()
        Me.その他支給特記TextBox = New System.Windows.Forms.TextBox()
        Me.工事追記TextBox = New System.Windows.Forms.TextBox()
        Me.工場出荷分割数TextBox = New System.Windows.Forms.TextBox()
        Me.工場出荷特記TextBox = New System.Windows.Forms.TextBox()
        Me.工事完了日TextBox = New System.Windows.Forms.TextBox()
        Me.検査特記TextBox = New System.Windows.Forms.TextBox()
        Me.検査仕様書有無CheckBox = New System.Windows.Forms.CheckBox()
        Me.製作仕様書有無CheckBox = New System.Windows.Forms.CheckBox()
        Me.立会検査有無CheckBox = New System.Windows.Forms.CheckBox()
        Me.塗装仕様書有無CheckBox = New System.Windows.Forms.CheckBox()
        Me.工程写真有無CheckBox = New System.Windows.Forms.CheckBox()
        Me.工程写真特記TextBox = New System.Windows.Forms.TextBox()
        Me.期間始TextBox = New System.Windows.Forms.TextBox()
        Me.期間終TextBox = New System.Windows.Forms.TextBox()
        Me.予算工数TextBox = New System.Windows.Forms.TextBox()
        Me.外注予算TextBox = New System.Windows.Forms.TextBox()
        Me.実績工数TextBox = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonBudgetOpen = New System.Windows.Forms.Button()
        Me.ButtonDayWorksOpen = New System.Windows.Forms.Button()
        Me.ButtonBudgetDetailOpen = New System.Windows.Forms.Button()
        Me.ButtonOutWorkOpen = New System.Windows.Forms.Button()
        Me.ButtonShipmentOpen = New System.Windows.Forms.Button()
        Me.ButtonMyOrderOpen = New System.Windows.Forms.Button()
        工事番号Label = New System.Windows.Forms.Label()
        取引先ＩＤLabel2 = New System.Windows.Forms.Label()
        営業社員ＩＤLabel = New System.Windows.Forms.Label()
        工事名Label = New System.Windows.Forms.Label()
        数量Label = New System.Windows.Forms.Label()
        生管社員ＩＤLabel = New System.Windows.Forms.Label()
        工事概要Label = New System.Windows.Forms.Label()
        工事範囲Label = New System.Windows.Forms.Label()
        製造範囲ＩＤLabel = New System.Windows.Forms.Label()
        材料支給有無Label = New System.Windows.Forms.Label()
        ミルシート有無Label = New System.Windows.Forms.Label()
        材料特記Label = New System.Windows.Forms.Label()
        購入品支給有無Label = New System.Windows.Forms.Label()
        購入品特記Label = New System.Windows.Forms.Label()
        その他支給特記Label = New System.Windows.Forms.Label()
        工事追記Label = New System.Windows.Forms.Label()
        工場出荷分割数Label = New System.Windows.Forms.Label()
        工場出荷特記Label = New System.Windows.Forms.Label()
        工事完了日Label = New System.Windows.Forms.Label()
        検査特記Label = New System.Windows.Forms.Label()
        検査仕様書有無Label = New System.Windows.Forms.Label()
        製作仕様書有無Label = New System.Windows.Forms.Label()
        立会検査有無Label = New System.Windows.Forms.Label()
        塗装仕様書有無Label = New System.Windows.Forms.Label()
        工程写真有無Label = New System.Windows.Forms.Label()
        工程写真特記Label = New System.Windows.Forms.Label()
        期間始Label = New System.Windows.Forms.Label()
        外注予算Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.ConstructionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事詳細BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事取引先最新BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.工事製造範囲BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '工事番号Label
        '
        工事番号Label.AutoSize = True
        工事番号Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事番号Label.Location = New System.Drawing.Point(10, 32)
        工事番号Label.Name = "工事番号Label"
        工事番号Label.Size = New System.Drawing.Size(89, 19)
        工事番号Label.TabIndex = 0
        工事番号Label.Text = "工事番号:"
        '
        '取引先ＩＤLabel2
        '
        取引先ＩＤLabel2.AutoSize = True
        取引先ＩＤLabel2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        取引先ＩＤLabel2.Location = New System.Drawing.Point(29, 97)
        取引先ＩＤLabel2.Name = "取引先ＩＤLabel2"
        取引先ＩＤLabel2.Size = New System.Drawing.Size(70, 19)
        取引先ＩＤLabel2.TabIndex = 4
        取引先ＩＤLabel2.Text = "取引先:"
        '
        '営業社員ＩＤLabel
        '
        営業社員ＩＤLabel.AutoSize = True
        営業社員ＩＤLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        営業社員ＩＤLabel.Location = New System.Drawing.Point(11, 162)
        営業社員ＩＤLabel.Name = "営業社員ＩＤLabel"
        営業社員ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        営業社員ＩＤLabel.TabIndex = 5
        営業社員ＩＤLabel.Text = "営業担当:"
        '
        '工事名Label
        '
        工事名Label.AutoSize = True
        工事名Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事名Label.Location = New System.Drawing.Point(30, 65)
        工事名Label.Name = "工事名Label"
        工事名Label.Size = New System.Drawing.Size(70, 19)
        工事名Label.TabIndex = 6
        工事名Label.Text = "工事名:"
        '
        '数量Label
        '
        数量Label.AutoSize = True
        数量Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        数量Label.Location = New System.Drawing.Point(44, 130)
        数量Label.Name = "数量Label"
        数量Label.Size = New System.Drawing.Size(51, 19)
        数量Label.TabIndex = 8
        数量Label.Text = "数量:"
        '
        '生管社員ＩＤLabel
        '
        生管社員ＩＤLabel.AutoSize = True
        生管社員ＩＤLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        生管社員ＩＤLabel.Location = New System.Drawing.Point(11, 195)
        生管社員ＩＤLabel.Name = "生管社員ＩＤLabel"
        生管社員ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        生管社員ＩＤLabel.TabIndex = 12
        生管社員ＩＤLabel.Text = "生管担当:"
        '
        '工事概要Label
        '
        工事概要Label.AutoSize = True
        工事概要Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事概要Label.Location = New System.Drawing.Point(10, 304)
        工事概要Label.Name = "工事概要Label"
        工事概要Label.Size = New System.Drawing.Size(32, 76)
        工事概要Label.TabIndex = 14
        工事概要Label.Text = "工" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "事" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "概" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "要:"
        '
        '工事範囲Label
        '
        工事範囲Label.AutoSize = True
        工事範囲Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事範囲Label.Location = New System.Drawing.Point(10, 230)
        工事範囲Label.Name = "工事範囲Label"
        工事範囲Label.Size = New System.Drawing.Size(89, 19)
        工事範囲Label.TabIndex = 15
        工事範囲Label.Text = "工事範囲:"
        '
        '製造範囲ＩＤLabel
        '
        製造範囲ＩＤLabel.AutoSize = True
        製造範囲ＩＤLabel.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        製造範囲ＩＤLabel.Location = New System.Drawing.Point(336, 134)
        製造範囲ＩＤLabel.Name = "製造範囲ＩＤLabel"
        製造範囲ＩＤLabel.Size = New System.Drawing.Size(89, 19)
        製造範囲ＩＤLabel.TabIndex = 16
        製造範囲ＩＤLabel.Text = "製造範囲:"
        '
        '材料支給有無Label
        '
        材料支給有無Label.AutoSize = True
        材料支給有無Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        材料支給有無Label.Location = New System.Drawing.Point(276, 462)
        材料支給有無Label.Name = "材料支給有無Label"
        材料支給有無Label.Size = New System.Drawing.Size(89, 19)
        材料支給有無Label.TabIndex = 18
        材料支給有無Label.Text = "材料支給:"
        '
        'ミルシート有無Label
        '
        ミルシート有無Label.AutoSize = True
        ミルシート有無Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ミルシート有無Label.Location = New System.Drawing.Point(155, 462)
        ミルシート有無Label.Name = "ミルシート有無Label"
        ミルシート有無Label.Size = New System.Drawing.Size(85, 19)
        ミルシート有無Label.TabIndex = 20
        ミルシート有無Label.Text = "ミルシート:"
        '
        '材料特記Label
        '
        材料特記Label.AutoSize = True
        材料特記Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        材料特記Label.Location = New System.Drawing.Point(2, 462)
        材料特記Label.Name = "材料特記Label"
        材料特記Label.Size = New System.Drawing.Size(89, 19)
        材料特記Label.TabIndex = 22
        材料特記Label.Text = "材料特記:"
        '
        '購入品支給有無Label
        '
        購入品支給有無Label.AutoSize = True
        購入品支給有無Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        購入品支給有無Label.Location = New System.Drawing.Point(261, 554)
        購入品支給有無Label.Name = "購入品支給有無Label"
        購入品支給有無Label.Size = New System.Drawing.Size(108, 19)
        購入品支給有無Label.TabIndex = 24
        購入品支給有無Label.Text = "購入品支給:"
        '
        '購入品特記Label
        '
        購入品特記Label.AutoSize = True
        購入品特記Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        購入品特記Label.Location = New System.Drawing.Point(2, 554)
        購入品特記Label.Name = "購入品特記Label"
        購入品特記Label.Size = New System.Drawing.Size(108, 19)
        購入品特記Label.TabIndex = 26
        購入品特記Label.Text = "購入品特記:"
        '
        'その他支給特記Label
        '
        その他支給特記Label.AutoSize = True
        その他支給特記Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        その他支給特記Label.Location = New System.Drawing.Point(835, 464)
        その他支給特記Label.Name = "その他支給特記Label"
        その他支給特記Label.Size = New System.Drawing.Size(138, 19)
        その他支給特記Label.TabIndex = 28
        その他支給特記Label.Text = "その他支給特記:"
        '
        '工事追記Label
        '
        工事追記Label.AutoSize = True
        工事追記Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事追記Label.Location = New System.Drawing.Point(477, 94)
        工事追記Label.Name = "工事追記Label"
        工事追記Label.Size = New System.Drawing.Size(89, 19)
        工事追記Label.TabIndex = 30
        工事追記Label.Text = "工事追記:"
        '
        '工場出荷分割数Label
        '
        工場出荷分割数Label.AutoSize = True
        工場出荷分割数Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工場出荷分割数Label.Location = New System.Drawing.Point(313, 200)
        工場出荷分割数Label.Name = "工場出荷分割数Label"
        工場出荷分割数Label.Size = New System.Drawing.Size(108, 19)
        工場出荷分割数Label.TabIndex = 32
        工場出荷分割数Label.Text = "出荷分割数:"
        '
        '工場出荷特記Label
        '
        工場出荷特記Label.AutoSize = True
        工場出荷特記Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工場出荷特記Label.Location = New System.Drawing.Point(835, 554)
        工場出荷特記Label.Name = "工場出荷特記Label"
        工場出荷特記Label.Size = New System.Drawing.Size(127, 19)
        工場出荷特記Label.TabIndex = 34
        工場出荷特記Label.Text = "工場出荷特記:"
        '
        '工事完了日Label
        '
        工事完了日Label.AutoSize = True
        工事完了日Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工事完了日Label.Location = New System.Drawing.Point(316, 167)
        工事完了日Label.Name = "工事完了日Label"
        工事完了日Label.Size = New System.Drawing.Size(108, 19)
        工事完了日Label.TabIndex = 36
        工事完了日Label.Text = "工事完了日:"
        '
        '検査特記Label
        '
        検査特記Label.AutoSize = True
        検査特記Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        検査特記Label.Location = New System.Drawing.Point(418, 463)
        検査特記Label.Name = "検査特記Label"
        検査特記Label.Size = New System.Drawing.Size(89, 19)
        検査特記Label.TabIndex = 38
        検査特記Label.Text = "検査特記:"
        '
        '検査仕様書有無Label
        '
        検査仕様書有無Label.AutoSize = True
        検査仕様書有無Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        検査仕様書有無Label.Location = New System.Drawing.Point(563, 463)
        検査仕様書有無Label.Name = "検査仕様書有無Label"
        検査仕様書有無Label.Size = New System.Drawing.Size(108, 19)
        検査仕様書有無Label.TabIndex = 40
        検査仕様書有無Label.Text = "検査仕様書:"
        '
        '製作仕様書有無Label
        '
        製作仕様書有無Label.AutoSize = True
        製作仕様書有無Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        製作仕様書有無Label.Location = New System.Drawing.Point(998, 435)
        製作仕様書有無Label.Name = "製作仕様書有無Label"
        製作仕様書有無Label.Size = New System.Drawing.Size(108, 19)
        製作仕様書有無Label.TabIndex = 42
        製作仕様書有無Label.Text = "製作仕様書:"
        '
        '立会検査有無Label
        '
        立会検査有無Label.AutoSize = True
        立会検査有無Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        立会検査有無Label.Location = New System.Drawing.Point(717, 462)
        立会検査有無Label.Name = "立会検査有無Label"
        立会検査有無Label.Size = New System.Drawing.Size(89, 19)
        立会検査有無Label.TabIndex = 44
        立会検査有無Label.Text = "立会検査:"
        '
        '塗装仕様書有無Label
        '
        塗装仕様書有無Label.AutoSize = True
        塗装仕様書有無Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        塗装仕様書有無Label.Location = New System.Drawing.Point(998, 406)
        塗装仕様書有無Label.Name = "塗装仕様書有無Label"
        塗装仕様書有無Label.Size = New System.Drawing.Size(108, 19)
        塗装仕様書有無Label.TabIndex = 46
        塗装仕様書有無Label.Text = "塗装仕様書:"
        '
        '工程写真有無Label
        '
        工程写真有無Label.AutoSize = True
        工程写真有無Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工程写真有無Label.Location = New System.Drawing.Point(717, 556)
        工程写真有無Label.Name = "工程写真有無Label"
        工程写真有無Label.Size = New System.Drawing.Size(89, 19)
        工程写真有無Label.TabIndex = 48
        工程写真有無Label.Text = "工程写真:"
        '
        '工程写真特記Label
        '
        工程写真特記Label.AutoSize = True
        工程写真特記Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        工程写真特記Label.Location = New System.Drawing.Point(418, 554)
        工程写真特記Label.Name = "工程写真特記Label"
        工程写真特記Label.Size = New System.Drawing.Size(127, 19)
        工程写真特記Label.TabIndex = 50
        工程写真特記Label.Text = "工程写真特記:"
        '
        '期間始Label
        '
        期間始Label.AutoSize = True
        期間始Label.BackColor = System.Drawing.Color.Gray
        期間始Label.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        期間始Label.ForeColor = System.Drawing.Color.White
        期間始Label.Location = New System.Drawing.Point(1011, 129)
        期間始Label.Name = "期間始Label"
        期間始Label.Size = New System.Drawing.Size(89, 38)
        期間始Label.TabIndex = 52
        期間始Label.Text = "製造" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "予定期間:"
        '
        '外注予算Label
        '
        外注予算Label.AutoSize = True
        外注予算Label.BackColor = System.Drawing.Color.Gray
        外注予算Label.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        外注予算Label.ForeColor = System.Drawing.Color.White
        外注予算Label.Location = New System.Drawing.Point(1002, 269)
        外注予算Label.Name = "外注予算Label"
        外注予算Label.Size = New System.Drawing.Size(98, 21)
        外注予算Label.TabIndex = 58
        外注予算Label.Text = "外注予算:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Gray
        Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(1165, 137)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(13, 19)
        Label1.TabIndex = 62
        Label1.Text = "|"
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Gray
        Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Label2.Location = New System.Drawing.Point(993, 88)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(256, 269)
        Label2.TabIndex = 63
        '
        '工事詳細dtblTableAdapter1
        '
        Me.工事詳細dtblTableAdapter1.ClearBeforeFill = True
        '
        'ConstructionDataSet1
        '
        Me.ConstructionDataSet1.DataSetName = "ConstructionDataSet"
        Me.ConstructionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '工事詳細BindingSource
        '
        Me.工事詳細BindingSource.DataMember = "工事詳細dtbl"
        Me.工事詳細BindingSource.DataSource = Me.ConstructionDataSet1
        '
        '工事取引先最新dtblTableAdapter1
        '
        Me.工事取引先最新dtblTableAdapter1.ClearBeforeFill = True
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
        '受注営業担当dtblBindingSource
        '
        Me.受注営業担当dtblBindingSource.DataMember = "受注営業担当dtbl"
        Me.受注営業担当dtblBindingSource.DataSource = Me.ConstructionDataSet1
        '
        '受注営業担当dtblTableAdapter
        '
        Me.受注営業担当dtblTableAdapter.ClearBeforeFill = True
        '
        '工事取引先最新BindingSource
        '
        Me.工事取引先最新BindingSource.DataMember = "工事取引先最新dtbl"
        Me.工事取引先最新BindingSource.DataSource = Me.ConstructionDataSet1
        '
        '工事番号TextBox
        '
        Me.工事番号TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事番号TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事番号TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "工事番号", True))
        Me.工事番号TextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事番号TextBox.Location = New System.Drawing.Point(101, 26)
        Me.工事番号TextBox.Name = "工事番号TextBox"
        Me.工事番号TextBox.ReadOnly = True
        Me.工事番号TextBox.Size = New System.Drawing.Size(218, 31)
        Me.工事番号TextBox.TabIndex = 1
        '
        '取引先ＩＤComboBox
        '
        Me.取引先ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.取引先ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.工事詳細BindingSource, "取引先ＩＤ", True))
        Me.取引先ＩＤComboBox.DataSource = Me.工事取引先最新BindingSource
        Me.取引先ＩＤComboBox.DisplayMember = "取引先略称"
        Me.取引先ＩＤComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.取引先ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.取引先ＩＤComboBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.取引先ＩＤComboBox.FormattingEnabled = True
        Me.取引先ＩＤComboBox.Location = New System.Drawing.Point(101, 94)
        Me.取引先ＩＤComboBox.Name = "取引先ＩＤComboBox"
        Me.取引先ＩＤComboBox.Size = New System.Drawing.Size(305, 27)
        Me.取引先ＩＤComboBox.TabIndex = 5
        Me.取引先ＩＤComboBox.ValueMember = "取引先ＩＤ"
        '
        '営業社員ＩＤComboBox
        '
        Me.営業社員ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.営業社員ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.工事詳細BindingSource, "営業社員ＩＤ", True))
        Me.営業社員ＩＤComboBox.DataSource = Me.受注営業担当dtblBindingSource
        Me.営業社員ＩＤComboBox.DisplayMember = "社員名"
        Me.営業社員ＩＤComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.営業社員ＩＤComboBox.Enabled = False
        Me.営業社員ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.営業社員ＩＤComboBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.営業社員ＩＤComboBox.FormattingEnabled = True
        Me.営業社員ＩＤComboBox.Location = New System.Drawing.Point(101, 159)
        Me.営業社員ＩＤComboBox.Name = "営業社員ＩＤComboBox"
        Me.営業社員ＩＤComboBox.Size = New System.Drawing.Size(139, 27)
        Me.営業社員ＩＤComboBox.TabIndex = 6
        Me.営業社員ＩＤComboBox.ValueMember = "社員ＩＤ"
        '
        '工事名TextBox
        '
        Me.工事名TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事名TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "工事名", True))
        Me.工事名TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事名TextBox.Location = New System.Drawing.Point(101, 63)
        Me.工事名TextBox.Name = "工事名TextBox"
        Me.工事名TextBox.ReadOnly = True
        Me.工事名TextBox.Size = New System.Drawing.Size(884, 26)
        Me.工事名TextBox.TabIndex = 7
        '
        '数量TextBox
        '
        Me.数量TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.数量TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.数量TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "数量", True))
        Me.数量TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.数量TextBox.Location = New System.Drawing.Point(101, 127)
        Me.数量TextBox.Name = "数量TextBox"
        Me.数量TextBox.ReadOnly = True
        Me.数量TextBox.Size = New System.Drawing.Size(218, 26)
        Me.数量TextBox.TabIndex = 9
        '
        '工事製造範囲dtblTableAdapter1
        '
        Me.工事製造範囲dtblTableAdapter1.ClearBeforeFill = True
        '
        '工事製造範囲BindingSource
        '
        Me.工事製造範囲BindingSource.DataMember = "工事製造範囲dtbl"
        Me.工事製造範囲BindingSource.DataSource = Me.ConstructionDataSet1
        '
        '生管社員ＩＤComboBox
        '
        Me.生管社員ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.生管社員ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.工事詳細BindingSource, "生管社員ＩＤ", True))
        Me.生管社員ＩＤComboBox.DataSource = Me.工事生管担当dtblBindingSource
        Me.生管社員ＩＤComboBox.DisplayMember = "社員名"
        Me.生管社員ＩＤComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.生管社員ＩＤComboBox.Enabled = False
        Me.生管社員ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.生管社員ＩＤComboBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.生管社員ＩＤComboBox.FormattingEnabled = True
        Me.生管社員ＩＤComboBox.Location = New System.Drawing.Point(101, 192)
        Me.生管社員ＩＤComboBox.Name = "生管社員ＩＤComboBox"
        Me.生管社員ＩＤComboBox.Size = New System.Drawing.Size(139, 27)
        Me.生管社員ＩＤComboBox.TabIndex = 13
        Me.生管社員ＩＤComboBox.ValueMember = "社員ＩＤ"
        '
        '工事概要TextBox
        '
        Me.工事概要TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事概要TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事概要TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "工事概要", True))
        Me.工事概要TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事概要TextBox.Location = New System.Drawing.Point(48, 301)
        Me.工事概要TextBox.Multiline = True
        Me.工事概要TextBox.Name = "工事概要TextBox"
        Me.工事概要TextBox.ReadOnly = True
        Me.工事概要TextBox.Size = New System.Drawing.Size(937, 153)
        Me.工事概要TextBox.TabIndex = 15
        '
        '工事範囲TextBox
        '
        Me.工事範囲TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事範囲TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事範囲TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "工事範囲", True))
        Me.工事範囲TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事範囲TextBox.Location = New System.Drawing.Point(101, 227)
        Me.工事範囲TextBox.Multiline = True
        Me.工事範囲TextBox.Name = "工事範囲TextBox"
        Me.工事範囲TextBox.ReadOnly = True
        Me.工事範囲TextBox.Size = New System.Drawing.Size(884, 64)
        Me.工事範囲TextBox.TabIndex = 16
        '
        '製造範囲ＩＤComboBox
        '
        Me.製造範囲ＩＤComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.製造範囲ＩＤComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.工事詳細BindingSource, "製造範囲ＩＤ", True))
        Me.製造範囲ＩＤComboBox.DataSource = Me.工事製造範囲BindingSource
        Me.製造範囲ＩＤComboBox.DisplayMember = "製造範囲名"
        Me.製造範囲ＩＤComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.製造範囲ＩＤComboBox.Enabled = False
        Me.製造範囲ＩＤComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.製造範囲ＩＤComboBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.製造範囲ＩＤComboBox.FormattingEnabled = True
        Me.製造範囲ＩＤComboBox.Location = New System.Drawing.Point(427, 131)
        Me.製造範囲ＩＤComboBox.Name = "製造範囲ＩＤComboBox"
        Me.製造範囲ＩＤComboBox.Size = New System.Drawing.Size(139, 27)
        Me.製造範囲ＩＤComboBox.TabIndex = 17
        Me.製造範囲ＩＤComboBox.ValueMember = "製造範囲ＩＤ"
        '
        '材料支給有無CheckBox
        '
        Me.材料支給有無CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.工事詳細BindingSource, "材料支給有無", True))
        Me.材料支給有無CheckBox.Enabled = False
        Me.材料支給有無CheckBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.材料支給有無CheckBox.Location = New System.Drawing.Point(370, 460)
        Me.材料支給有無CheckBox.Name = "材料支給有無CheckBox"
        Me.材料支給有無CheckBox.Size = New System.Drawing.Size(17, 27)
        Me.材料支給有無CheckBox.TabIndex = 19
        Me.材料支給有無CheckBox.ThreeState = True
        Me.材料支給有無CheckBox.UseVisualStyleBackColor = True
        '
        'ミルシート有無CheckBox
        '
        Me.ミルシート有無CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.工事詳細BindingSource, "ミルシート有無", True))
        Me.ミルシート有無CheckBox.Enabled = False
        Me.ミルシート有無CheckBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ミルシート有無CheckBox.Location = New System.Drawing.Point(245, 465)
        Me.ミルシート有無CheckBox.Name = "ミルシート有無CheckBox"
        Me.ミルシート有無CheckBox.Size = New System.Drawing.Size(17, 17)
        Me.ミルシート有無CheckBox.TabIndex = 21
        Me.ミルシート有無CheckBox.ThreeState = True
        Me.ミルシート有無CheckBox.UseVisualStyleBackColor = True
        '
        '材料特記TextBox
        '
        Me.材料特記TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.材料特記TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.材料特記TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "材料特記", True))
        Me.材料特記TextBox.Font = New System.Drawing.Font("MS UI Gothic", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.材料特記TextBox.Location = New System.Drawing.Point(6, 486)
        Me.材料特記TextBox.Multiline = True
        Me.材料特記TextBox.Name = "材料特記TextBox"
        Me.材料特記TextBox.ReadOnly = True
        Me.材料特記TextBox.Size = New System.Drawing.Size(413, 62)
        Me.材料特記TextBox.TabIndex = 23
        '
        '購入品支給有無CheckBox
        '
        Me.購入品支給有無CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.工事詳細BindingSource, "購入品支給有無", True))
        Me.購入品支給有無CheckBox.Enabled = False
        Me.購入品支給有無CheckBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.購入品支給有無CheckBox.Location = New System.Drawing.Point(370, 558)
        Me.購入品支給有無CheckBox.Name = "購入品支給有無CheckBox"
        Me.購入品支給有無CheckBox.Size = New System.Drawing.Size(17, 17)
        Me.購入品支給有無CheckBox.TabIndex = 25
        Me.購入品支給有無CheckBox.ThreeState = True
        Me.購入品支給有無CheckBox.UseVisualStyleBackColor = True
        '
        '購入品特記TextBox
        '
        Me.購入品特記TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.購入品特記TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.購入品特記TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "購入品特記", True))
        Me.購入品特記TextBox.Font = New System.Drawing.Font("MS UI Gothic", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.購入品特記TextBox.Location = New System.Drawing.Point(6, 576)
        Me.購入品特記TextBox.Multiline = True
        Me.購入品特記TextBox.Name = "購入品特記TextBox"
        Me.購入品特記TextBox.ReadOnly = True
        Me.購入品特記TextBox.Size = New System.Drawing.Size(412, 62)
        Me.購入品特記TextBox.TabIndex = 27
        '
        'その他支給特記TextBox
        '
        Me.その他支給特記TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.その他支給特記TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.その他支給特記TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "その他支給特記", True))
        Me.その他支給特記TextBox.Font = New System.Drawing.Font("MS UI Gothic", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.その他支給特記TextBox.Location = New System.Drawing.Point(839, 486)
        Me.その他支給特記TextBox.Multiline = True
        Me.その他支給特記TextBox.Name = "その他支給特記TextBox"
        Me.その他支給特記TextBox.ReadOnly = True
        Me.その他支給特記TextBox.Size = New System.Drawing.Size(413, 62)
        Me.その他支給特記TextBox.TabIndex = 29
        '
        '工事追記TextBox
        '
        Me.工事追記TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事追記TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事追記TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "工事追記", True))
        Me.工事追記TextBox.Font = New System.Drawing.Font("MS UI Gothic", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事追記TextBox.Location = New System.Drawing.Point(572, 94)
        Me.工事追記TextBox.Multiline = True
        Me.工事追記TextBox.Name = "工事追記TextBox"
        Me.工事追記TextBox.ReadOnly = True
        Me.工事追記TextBox.Size = New System.Drawing.Size(413, 128)
        Me.工事追記TextBox.TabIndex = 31
        '
        '工場出荷分割数TextBox
        '
        Me.工場出荷分割数TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工場出荷分割数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工場出荷分割数TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "工場出荷分割数", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.工場出荷分割数TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工場出荷分割数TextBox.Location = New System.Drawing.Point(427, 197)
        Me.工場出荷分割数TextBox.Name = "工場出荷分割数TextBox"
        Me.工場出荷分割数TextBox.ReadOnly = True
        Me.工場出荷分割数TextBox.Size = New System.Drawing.Size(139, 26)
        Me.工場出荷分割数TextBox.TabIndex = 33
        Me.工場出荷分割数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '工場出荷特記TextBox
        '
        Me.工場出荷特記TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工場出荷特記TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工場出荷特記TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "工場出荷特記", True))
        Me.工場出荷特記TextBox.Font = New System.Drawing.Font("MS UI Gothic", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工場出荷特記TextBox.Location = New System.Drawing.Point(839, 576)
        Me.工場出荷特記TextBox.Multiline = True
        Me.工場出荷特記TextBox.Name = "工場出荷特記TextBox"
        Me.工場出荷特記TextBox.ReadOnly = True
        Me.工場出荷特記TextBox.Size = New System.Drawing.Size(413, 62)
        Me.工場出荷特記TextBox.TabIndex = 35
        '
        '工事完了日TextBox
        '
        Me.工事完了日TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工事完了日TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工事完了日TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "工事完了日", True))
        Me.工事完了日TextBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工事完了日TextBox.Location = New System.Drawing.Point(427, 164)
        Me.工事完了日TextBox.Name = "工事完了日TextBox"
        Me.工事完了日TextBox.ReadOnly = True
        Me.工事完了日TextBox.Size = New System.Drawing.Size(139, 26)
        Me.工事完了日TextBox.TabIndex = 37
        Me.工事完了日TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '検査特記TextBox
        '
        Me.検査特記TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.検査特記TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.検査特記TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "検査特記", True))
        Me.検査特記TextBox.Font = New System.Drawing.Font("MS UI Gothic", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.検査特記TextBox.Location = New System.Drawing.Point(422, 486)
        Me.検査特記TextBox.Multiline = True
        Me.検査特記TextBox.Name = "検査特記TextBox"
        Me.検査特記TextBox.ReadOnly = True
        Me.検査特記TextBox.Size = New System.Drawing.Size(413, 62)
        Me.検査特記TextBox.TabIndex = 39
        '
        '検査仕様書有無CheckBox
        '
        Me.検査仕様書有無CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.工事詳細BindingSource, "検査仕様書有無", True))
        Me.検査仕様書有無CheckBox.Enabled = False
        Me.検査仕様書有無CheckBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.検査仕様書有無CheckBox.Location = New System.Drawing.Point(671, 466)
        Me.検査仕様書有無CheckBox.Name = "検査仕様書有無CheckBox"
        Me.検査仕様書有無CheckBox.Size = New System.Drawing.Size(17, 17)
        Me.検査仕様書有無CheckBox.TabIndex = 41
        Me.検査仕様書有無CheckBox.ThreeState = True
        Me.検査仕様書有無CheckBox.UseVisualStyleBackColor = True
        '
        '製作仕様書有無CheckBox
        '
        Me.製作仕様書有無CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.工事詳細BindingSource, "製作仕様書有無", True))
        Me.製作仕様書有無CheckBox.Enabled = False
        Me.製作仕様書有無CheckBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.製作仕様書有無CheckBox.Location = New System.Drawing.Point(1112, 437)
        Me.製作仕様書有無CheckBox.Name = "製作仕様書有無CheckBox"
        Me.製作仕様書有無CheckBox.Size = New System.Drawing.Size(17, 17)
        Me.製作仕様書有無CheckBox.TabIndex = 43
        Me.製作仕様書有無CheckBox.ThreeState = True
        Me.製作仕様書有無CheckBox.UseVisualStyleBackColor = True
        '
        '立会検査有無CheckBox
        '
        Me.立会検査有無CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.工事詳細BindingSource, "立会検査有無", True))
        Me.立会検査有無CheckBox.Enabled = False
        Me.立会検査有無CheckBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.立会検査有無CheckBox.Location = New System.Drawing.Point(810, 465)
        Me.立会検査有無CheckBox.Name = "立会検査有無CheckBox"
        Me.立会検査有無CheckBox.Size = New System.Drawing.Size(17, 17)
        Me.立会検査有無CheckBox.TabIndex = 45
        Me.立会検査有無CheckBox.ThreeState = True
        Me.立会検査有無CheckBox.UseVisualStyleBackColor = True
        '
        '塗装仕様書有無CheckBox
        '
        Me.塗装仕様書有無CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.工事詳細BindingSource, "塗装仕様書有無", True))
        Me.塗装仕様書有無CheckBox.Enabled = False
        Me.塗装仕様書有無CheckBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.塗装仕様書有無CheckBox.Location = New System.Drawing.Point(1112, 408)
        Me.塗装仕様書有無CheckBox.Name = "塗装仕様書有無CheckBox"
        Me.塗装仕様書有無CheckBox.Size = New System.Drawing.Size(17, 17)
        Me.塗装仕様書有無CheckBox.TabIndex = 47
        Me.塗装仕様書有無CheckBox.ThreeState = True
        Me.塗装仕様書有無CheckBox.UseVisualStyleBackColor = True
        '
        '工程写真有無CheckBox
        '
        Me.工程写真有無CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.工事詳細BindingSource, "工程写真有無", True))
        Me.工程写真有無CheckBox.Enabled = False
        Me.工程写真有無CheckBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工程写真有無CheckBox.Location = New System.Drawing.Point(810, 558)
        Me.工程写真有無CheckBox.Name = "工程写真有無CheckBox"
        Me.工程写真有無CheckBox.Size = New System.Drawing.Size(17, 17)
        Me.工程写真有無CheckBox.TabIndex = 49
        Me.工程写真有無CheckBox.ThreeState = True
        Me.工程写真有無CheckBox.UseVisualStyleBackColor = True
        '
        '工程写真特記TextBox
        '
        Me.工程写真特記TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.工程写真特記TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.工程写真特記TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "工程写真特記", True))
        Me.工程写真特記TextBox.Font = New System.Drawing.Font("MS UI Gothic", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.工程写真特記TextBox.Location = New System.Drawing.Point(422, 576)
        Me.工程写真特記TextBox.Multiline = True
        Me.工程写真特記TextBox.Name = "工程写真特記TextBox"
        Me.工程写真特記TextBox.ReadOnly = True
        Me.工程写真特記TextBox.Size = New System.Drawing.Size(413, 62)
        Me.工程写真特記TextBox.TabIndex = 51
        '
        '期間始TextBox
        '
        Me.期間始TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.期間始TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.期間始TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "期間始", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "M"))
        Me.期間始TextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.期間始TextBox.Location = New System.Drawing.Point(1108, 103)
        Me.期間始TextBox.Name = "期間始TextBox"
        Me.期間始TextBox.ReadOnly = True
        Me.期間始TextBox.Size = New System.Drawing.Size(132, 31)
        Me.期間始TextBox.TabIndex = 53
        Me.期間始TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '期間終TextBox
        '
        Me.期間終TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.期間終TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.期間終TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "期間終", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "M"))
        Me.期間終TextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.期間終TextBox.Location = New System.Drawing.Point(1108, 162)
        Me.期間終TextBox.Name = "期間終TextBox"
        Me.期間終TextBox.ReadOnly = True
        Me.期間終TextBox.Size = New System.Drawing.Size(132, 31)
        Me.期間終TextBox.TabIndex = 55
        Me.期間終TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '予算工数TextBox
        '
        Me.予算工数TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.予算工数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.予算工数TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "予算工数", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N1"))
        Me.予算工数TextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.予算工数TextBox.Location = New System.Drawing.Point(1108, 227)
        Me.予算工数TextBox.Name = "予算工数TextBox"
        Me.予算工数TextBox.ReadOnly = True
        Me.予算工数TextBox.Size = New System.Drawing.Size(132, 31)
        Me.予算工数TextBox.TabIndex = 57
        Me.予算工数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '外注予算TextBox
        '
        Me.外注予算TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.外注予算TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.外注予算TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "外注予算", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "0"))
        Me.外注予算TextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.外注予算TextBox.Location = New System.Drawing.Point(1108, 264)
        Me.外注予算TextBox.Name = "外注予算TextBox"
        Me.外注予算TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.外注予算TextBox.ReadOnly = True
        Me.外注予算TextBox.Size = New System.Drawing.Size(132, 31)
        Me.外注予算TextBox.TabIndex = 59
        Me.外注予算TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '実績工数TextBox
        '
        Me.実績工数TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.実績工数TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.実績工数TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.工事詳細BindingSource, "実績工数", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N1"))
        Me.実績工数TextBox.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.実績工数TextBox.Location = New System.Drawing.Point(1108, 311)
        Me.実績工数TextBox.Name = "実績工数TextBox"
        Me.実績工数TextBox.ReadOnly = True
        Me.実績工数TextBox.Size = New System.Drawing.Size(132, 31)
        Me.実績工数TextBox.TabIndex = 61
        Me.実績工数TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonClose.FlatAppearance.BorderSize = 2
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(993, 9)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(256, 46)
        Me.ButtonClose.TabIndex = 65
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonBudgetOpen
        '
        Me.ButtonBudgetOpen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonBudgetOpen.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonBudgetOpen.FlatAppearance.BorderSize = 2
        Me.ButtonBudgetOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBudgetOpen.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonBudgetOpen.ForeColor = System.Drawing.Color.Black
        Me.ButtonBudgetOpen.Location = New System.Drawing.Point(998, 228)
        Me.ButtonBudgetOpen.Name = "ButtonBudgetOpen"
        Me.ButtonBudgetOpen.Size = New System.Drawing.Size(108, 31)
        Me.ButtonBudgetOpen.TabIndex = 66
        Me.ButtonBudgetOpen.Text = "予算工数："
        Me.ButtonBudgetOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBudgetOpen.UseVisualStyleBackColor = False
        '
        'ButtonDayWorksOpen
        '
        Me.ButtonDayWorksOpen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonDayWorksOpen.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonDayWorksOpen.FlatAppearance.BorderSize = 2
        Me.ButtonDayWorksOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDayWorksOpen.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonDayWorksOpen.ForeColor = System.Drawing.Color.Black
        Me.ButtonDayWorksOpen.Location = New System.Drawing.Point(998, 311)
        Me.ButtonDayWorksOpen.Name = "ButtonDayWorksOpen"
        Me.ButtonDayWorksOpen.Size = New System.Drawing.Size(108, 31)
        Me.ButtonDayWorksOpen.TabIndex = 67
        Me.ButtonDayWorksOpen.Text = "実績工数："
        Me.ButtonDayWorksOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDayWorksOpen.UseVisualStyleBackColor = False
        '
        'ButtonBudgetDetailOpen
        '
        Me.ButtonBudgetDetailOpen.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonBudgetDetailOpen.FlatAppearance.BorderSize = 2
        Me.ButtonBudgetDetailOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBudgetDetailOpen.Location = New System.Drawing.Point(852, 9)
        Me.ButtonBudgetDetailOpen.Name = "ButtonBudgetDetailOpen"
        Me.ButtonBudgetDetailOpen.Size = New System.Drawing.Size(135, 46)
        Me.ButtonBudgetDetailOpen.TabIndex = 68
        Me.ButtonBudgetDetailOpen.Text = "予算詳細"
        Me.ButtonBudgetDetailOpen.UseVisualStyleBackColor = True
        '
        'ButtonOutWorkOpen
        '
        Me.ButtonOutWorkOpen.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonOutWorkOpen.FlatAppearance.BorderSize = 2
        Me.ButtonOutWorkOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOutWorkOpen.Location = New System.Drawing.Point(711, 9)
        Me.ButtonOutWorkOpen.Name = "ButtonOutWorkOpen"
        Me.ButtonOutWorkOpen.Size = New System.Drawing.Size(135, 46)
        Me.ButtonOutWorkOpen.TabIndex = 69
        Me.ButtonOutWorkOpen.Text = "外業予定"
        Me.ButtonOutWorkOpen.UseVisualStyleBackColor = True
        '
        'ButtonShipmentOpen
        '
        Me.ButtonShipmentOpen.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonShipmentOpen.FlatAppearance.BorderSize = 2
        Me.ButtonShipmentOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShipmentOpen.Location = New System.Drawing.Point(570, 9)
        Me.ButtonShipmentOpen.Name = "ButtonShipmentOpen"
        Me.ButtonShipmentOpen.Size = New System.Drawing.Size(135, 46)
        Me.ButtonShipmentOpen.TabIndex = 70
        Me.ButtonShipmentOpen.Text = "出荷予定"
        Me.ButtonShipmentOpen.UseVisualStyleBackColor = True
        '
        'ButtonMyOrderOpen
        '
        Me.ButtonMyOrderOpen.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ButtonMyOrderOpen.FlatAppearance.BorderSize = 2
        Me.ButtonMyOrderOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMyOrderOpen.Location = New System.Drawing.Point(429, 9)
        Me.ButtonMyOrderOpen.Name = "ButtonMyOrderOpen"
        Me.ButtonMyOrderOpen.Size = New System.Drawing.Size(135, 46)
        Me.ButtonMyOrderOpen.TabIndex = 71
        Me.ButtonMyOrderOpen.Text = "注文状況"
        Me.ButtonMyOrderOpen.UseVisualStyleBackColor = True
        '
        '工事詳細Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 641)
        Me.Controls.Add(Me.ButtonMyOrderOpen)
        Me.Controls.Add(Me.ButtonShipmentOpen)
        Me.Controls.Add(Me.ButtonOutWorkOpen)
        Me.Controls.Add(Me.ButtonBudgetDetailOpen)
        Me.Controls.Add(Me.ButtonDayWorksOpen)
        Me.Controls.Add(Me.ButtonBudgetOpen)
        Me.Controls.Add(Me.実績工数TextBox)
        Me.Controls.Add(Me.外注予算TextBox)
        Me.Controls.Add(Me.予算工数TextBox)
        Me.Controls.Add(Me.期間終TextBox)
        Me.Controls.Add(Me.期間始TextBox)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Label1)
        Me.Controls.Add(外注予算Label)
        Me.Controls.Add(期間始Label)
        Me.Controls.Add(工程写真特記Label)
        Me.Controls.Add(Me.工程写真特記TextBox)
        Me.Controls.Add(工程写真有無Label)
        Me.Controls.Add(Me.工程写真有無CheckBox)
        Me.Controls.Add(塗装仕様書有無Label)
        Me.Controls.Add(Me.塗装仕様書有無CheckBox)
        Me.Controls.Add(立会検査有無Label)
        Me.Controls.Add(Me.立会検査有無CheckBox)
        Me.Controls.Add(製作仕様書有無Label)
        Me.Controls.Add(Me.製作仕様書有無CheckBox)
        Me.Controls.Add(検査仕様書有無Label)
        Me.Controls.Add(Me.検査仕様書有無CheckBox)
        Me.Controls.Add(検査特記Label)
        Me.Controls.Add(Me.検査特記TextBox)
        Me.Controls.Add(工事完了日Label)
        Me.Controls.Add(Me.工事完了日TextBox)
        Me.Controls.Add(工場出荷特記Label)
        Me.Controls.Add(Me.工場出荷特記TextBox)
        Me.Controls.Add(工場出荷分割数Label)
        Me.Controls.Add(Me.工場出荷分割数TextBox)
        Me.Controls.Add(工事追記Label)
        Me.Controls.Add(Me.工事追記TextBox)
        Me.Controls.Add(その他支給特記Label)
        Me.Controls.Add(Me.その他支給特記TextBox)
        Me.Controls.Add(購入品特記Label)
        Me.Controls.Add(Me.購入品特記TextBox)
        Me.Controls.Add(購入品支給有無Label)
        Me.Controls.Add(Me.購入品支給有無CheckBox)
        Me.Controls.Add(材料特記Label)
        Me.Controls.Add(Me.材料特記TextBox)
        Me.Controls.Add(ミルシート有無Label)
        Me.Controls.Add(Me.ミルシート有無CheckBox)
        Me.Controls.Add(材料支給有無Label)
        Me.Controls.Add(Me.材料支給有無CheckBox)
        Me.Controls.Add(製造範囲ＩＤLabel)
        Me.Controls.Add(Me.製造範囲ＩＤComboBox)
        Me.Controls.Add(工事範囲Label)
        Me.Controls.Add(Me.工事範囲TextBox)
        Me.Controls.Add(工事概要Label)
        Me.Controls.Add(Me.工事概要TextBox)
        Me.Controls.Add(生管社員ＩＤLabel)
        Me.Controls.Add(Me.生管社員ＩＤComboBox)
        Me.Controls.Add(数量Label)
        Me.Controls.Add(Me.数量TextBox)
        Me.Controls.Add(工事名Label)
        Me.Controls.Add(Me.工事名TextBox)
        Me.Controls.Add(営業社員ＩＤLabel)
        Me.Controls.Add(Me.営業社員ＩＤComboBox)
        Me.Controls.Add(取引先ＩＤLabel2)
        Me.Controls.Add(Me.取引先ＩＤComboBox)
        Me.Controls.Add(工事番号Label)
        Me.Controls.Add(Me.工事番号TextBox)
        Me.Controls.Add(Label2)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "工事詳細Form"
        Me.Text = "工事詳細(製造のみ)"
        CType(Me.ConstructionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事詳細BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事生管担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.受注営業担当dtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事取引先最新BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.工事製造範囲BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 工事詳細dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事詳細dtblTableAdapter
    Friend WithEvents ConstructionDataSet1 As FujiSysForFactory3.ConstructionDataSet
    Friend WithEvents 工事詳細BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事取引先最新dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事取引先最新dtblTableAdapter
    Friend WithEvents 工事生管担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事生管担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事生管担当dtblTableAdapter
    Friend WithEvents TableAdapterManager As FujiSysForFactory3.ConstructionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 受注営業担当dtblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 受注営業担当dtblTableAdapter As FujiSysForFactory3.ConstructionDataSetTableAdapters.受注営業担当dtblTableAdapter
    Friend WithEvents 工事取引先最新BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 工事番号TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 取引先ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 営業社員ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 工事名TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 数量TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事製造範囲dtblTableAdapter1 As FujiSysForFactory3.ConstructionDataSetTableAdapters.工事製造範囲dtblTableAdapter
    Friend WithEvents 工事製造範囲BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 生管社員ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 工事概要TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事範囲TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 製造範囲ＩＤComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 材料支給有無CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ミルシート有無CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 材料特記TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 購入品支給有無CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 購入品特記TextBox As System.Windows.Forms.TextBox
    Friend WithEvents その他支給特記TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事追記TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工場出荷分割数TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工場出荷特記TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 工事完了日TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 検査特記TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 検査仕様書有無CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 製作仕様書有無CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 立会検査有無CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 塗装仕様書有無CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 工程写真有無CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 工程写真特記TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 期間始TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 期間終TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 予算工数TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 外注予算TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 実績工数TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonBudgetOpen As System.Windows.Forms.Button
    Friend WithEvents ButtonDayWorksOpen As System.Windows.Forms.Button
    Friend WithEvents ButtonBudgetDetailOpen As System.Windows.Forms.Button
    Friend WithEvents ButtonOutWorkOpen As System.Windows.Forms.Button
    Friend WithEvents ButtonShipmentOpen As System.Windows.Forms.Button
    Friend WithEvents ButtonMyOrderOpen As System.Windows.Forms.Button
End Class
