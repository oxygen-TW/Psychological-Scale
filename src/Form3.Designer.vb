<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.ForeColor = System.Drawing.Color.Blue
        Me.Button7.Location = New System.Drawing.Point(190, 197)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(77, 23)
        Me.Button7.TabIndex = 17
        Me.Button7.Tag = "A"
        Me.Button7.Text = "上一題"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 28)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "說明：請回答是否有下列狀況。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.Color.Red
        Me.Button6.Location = New System.Drawing.Point(190, 222)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(77, 23)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "回主選單"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 48)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "是"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(104, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 48)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "否"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabelA
        '
        Me.LabelA.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelA.ForeColor = System.Drawing.Color.ForestGreen
        Me.LabelA.Location = New System.Drawing.Point(16, 46)
        Me.LabelA.Name = "LabelA"
        Me.LabelA.Size = New System.Drawing.Size(251, 108)
        Me.LabelA.TabIndex = 18
        Me.LabelA.Text = "Label1"
        Me.LabelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.LabelA)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form3"
        Me.Text = "青少年憂鬱量表-氧氣工作室"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LabelA As Label
End Class
