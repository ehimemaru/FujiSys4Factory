<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutworExistenceDialog
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
        Me.OutWorkExistenceGroupBox = New System.Windows.Forms.GroupBox()
        Me.RadioButtonAll = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNotExist = New System.Windows.Forms.RadioButton()
        Me.RadioButtonExist = New System.Windows.Forms.RadioButton()
        Me.OutWorkExistenceGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OutWorkExistenceGroupBox
        '
        Me.OutWorkExistenceGroupBox.Controls.Add(Me.RadioButtonAll)
        Me.OutWorkExistenceGroupBox.Controls.Add(Me.RadioButtonNotExist)
        Me.OutWorkExistenceGroupBox.Controls.Add(Me.RadioButtonExist)
        Me.OutWorkExistenceGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OutWorkExistenceGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.OutWorkExistenceGroupBox.Name = "OutWorkExistenceGroupBox"
        Me.OutWorkExistenceGroupBox.Size = New System.Drawing.Size(243, 213)
        Me.OutWorkExistenceGroupBox.TabIndex = 1
        Me.OutWorkExistenceGroupBox.TabStop = False
        Me.OutWorkExistenceGroupBox.Text = "外業有無"
        '
        'RadioButtonAll
        '
        Me.RadioButtonAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonAll.Checked = True
        Me.RadioButtonAll.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.RadioButtonAll.FlatAppearance.BorderSize = 2
        Me.RadioButtonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonAll.Location = New System.Drawing.Point(44, 155)
        Me.RadioButtonAll.Name = "RadioButtonAll"
        Me.RadioButtonAll.Size = New System.Drawing.Size(162, 40)
        Me.RadioButtonAll.TabIndex = 2
        Me.RadioButtonAll.TabStop = True
        Me.RadioButtonAll.Text = "全て"
        Me.RadioButtonAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButtonAll.UseVisualStyleBackColor = True
        '
        'RadioButtonNotExist
        '
        Me.RadioButtonNotExist.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonNotExist.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.RadioButtonNotExist.FlatAppearance.BorderSize = 2
        Me.RadioButtonNotExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonNotExist.Location = New System.Drawing.Point(44, 103)
        Me.RadioButtonNotExist.Name = "RadioButtonNotExist"
        Me.RadioButtonNotExist.Size = New System.Drawing.Size(162, 40)
        Me.RadioButtonNotExist.TabIndex = 1
        Me.RadioButtonNotExist.Text = "無し"
        Me.RadioButtonNotExist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButtonNotExist.UseVisualStyleBackColor = True
        '
        'RadioButtonExist
        '
        Me.RadioButtonExist.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonExist.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.RadioButtonExist.FlatAppearance.BorderSize = 2
        Me.RadioButtonExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonExist.Location = New System.Drawing.Point(44, 52)
        Me.RadioButtonExist.Name = "RadioButtonExist"
        Me.RadioButtonExist.Size = New System.Drawing.Size(162, 40)
        Me.RadioButtonExist.TabIndex = 0
        Me.RadioButtonExist.Text = "有り"
        Me.RadioButtonExist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButtonExist.UseVisualStyleBackColor = True
        '
        'OutworExistenceDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 237)
        Me.Controls.Add(Me.OutWorkExistenceGroupBox)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "OutworExistenceDialog"
        Me.Text = "外業有無"
        Me.OutWorkExistenceGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OutWorkExistenceGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonAll As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNotExist As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonExist As System.Windows.Forms.RadioButton
End Class
