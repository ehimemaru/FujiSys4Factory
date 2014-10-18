<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConstructionCompleteDialog
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
        Me.ConstructionCompleteGroupBox = New System.Windows.Forms.GroupBox()
        Me.RadioButtonAll = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNotComplete = New System.Windows.Forms.RadioButton()
        Me.RadioButtonComplete = New System.Windows.Forms.RadioButton()
        Me.ConstructionCompleteGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConstructionCompleteGroupBox
        '
        Me.ConstructionCompleteGroupBox.Controls.Add(Me.RadioButtonAll)
        Me.ConstructionCompleteGroupBox.Controls.Add(Me.RadioButtonNotComplete)
        Me.ConstructionCompleteGroupBox.Controls.Add(Me.RadioButtonComplete)
        Me.ConstructionCompleteGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ConstructionCompleteGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.ConstructionCompleteGroupBox.Name = "ConstructionCompleteGroupBox"
        Me.ConstructionCompleteGroupBox.Size = New System.Drawing.Size(243, 213)
        Me.ConstructionCompleteGroupBox.TabIndex = 0
        Me.ConstructionCompleteGroupBox.TabStop = False
        Me.ConstructionCompleteGroupBox.Text = "工事完了"
        '
        'RadioButtonAll
        '
        Me.RadioButtonAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonAll.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.RadioButtonAll.FlatAppearance.BorderSize = 2
        Me.RadioButtonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonAll.Location = New System.Drawing.Point(44, 155)
        Me.RadioButtonAll.Name = "RadioButtonAll"
        Me.RadioButtonAll.Size = New System.Drawing.Size(162, 40)
        Me.RadioButtonAll.TabIndex = 2
        Me.RadioButtonAll.Text = "全て"
        Me.RadioButtonAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButtonAll.UseVisualStyleBackColor = True
        '
        'RadioButtonNotComplete
        '
        Me.RadioButtonNotComplete.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonNotComplete.Checked = True
        Me.RadioButtonNotComplete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.RadioButtonNotComplete.FlatAppearance.BorderSize = 2
        Me.RadioButtonNotComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonNotComplete.Location = New System.Drawing.Point(44, 103)
        Me.RadioButtonNotComplete.Name = "RadioButtonNotComplete"
        Me.RadioButtonNotComplete.Size = New System.Drawing.Size(162, 40)
        Me.RadioButtonNotComplete.TabIndex = 1
        Me.RadioButtonNotComplete.TabStop = True
        Me.RadioButtonNotComplete.Text = "未完"
        Me.RadioButtonNotComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButtonNotComplete.UseVisualStyleBackColor = True
        '
        'RadioButtonComplete
        '
        Me.RadioButtonComplete.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonComplete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.RadioButtonComplete.FlatAppearance.BorderSize = 2
        Me.RadioButtonComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonComplete.Location = New System.Drawing.Point(44, 52)
        Me.RadioButtonComplete.Name = "RadioButtonComplete"
        Me.RadioButtonComplete.Size = New System.Drawing.Size(162, 40)
        Me.RadioButtonComplete.TabIndex = 0
        Me.RadioButtonComplete.Text = "完了"
        Me.RadioButtonComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButtonComplete.UseVisualStyleBackColor = True
        '
        'ConstructionCompleteDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 237)
        Me.Controls.Add(Me.ConstructionCompleteGroupBox)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "ConstructionCompleteDialog"
        Me.Text = "工事完了"
        Me.ConstructionCompleteGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConstructionCompleteGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonAll As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNotComplete As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonComplete As System.Windows.Forms.RadioButton
End Class
