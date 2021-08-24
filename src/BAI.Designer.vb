<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BAI
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
        Me.Btn2p = New System.Windows.Forms.Button()
        Me.Btn3p = New System.Windows.Forms.Button()
        Me.LabelA = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.Btn0p = New System.Windows.Forms.Button()
        Me.Btn1p = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Btn2p
        '
        Me.Btn2p.Location = New System.Drawing.Point(31, 274)
        Me.Btn2p.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn2p.Name = "Btn2p"
        Me.Btn2p.Size = New System.Drawing.Size(103, 40)
        Me.Btn2p.TabIndex = 34
        Me.Btn2p.Text = "中等" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "無令我不悅"
        Me.Btn2p.UseVisualStyleBackColor = True
        '
        'Btn3p
        '
        Me.Btn3p.Location = New System.Drawing.Point(142, 274)
        Me.Btn3p.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn3p.Name = "Btn3p"
        Me.Btn3p.Size = New System.Drawing.Size(103, 40)
        Me.Btn3p.TabIndex = 33
        Me.Btn3p.Text = "嚴重" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "影響生活"
        Me.Btn3p.UseVisualStyleBackColor = True
        '
        'LabelA
        '
        Me.LabelA.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelA.ForeColor = System.Drawing.Color.ForestGreen
        Me.LabelA.Location = New System.Drawing.Point(26, 72)
        Me.LabelA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelA.Name = "LabelA"
        Me.LabelA.Size = New System.Drawing.Size(335, 135)
        Me.LabelA.TabIndex = 32
        Me.LabelA.Text = "Label1"
        Me.LabelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBack
        '
        Me.BtnBack.ForeColor = System.Drawing.Color.Blue
        Me.BtnBack.Location = New System.Drawing.Point(253, 226)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(103, 40)
        Me.BtnBack.TabIndex = 31
        Me.BtnBack.Tag = "A"
        Me.BtnBack.Text = "上一題"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 46)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "在過去一個月內(包含今天)，你有多經常受以下問題困擾？" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnReturn
        '
        Me.BtnReturn.ForeColor = System.Drawing.Color.Red
        Me.BtnReturn.Location = New System.Drawing.Point(253, 274)
        Me.BtnReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(103, 40)
        Me.BtnReturn.TabIndex = 29
        Me.BtnReturn.Text = "回主選單"
        Me.BtnReturn.UseVisualStyleBackColor = True
        '
        'Btn0p
        '
        Me.Btn0p.Location = New System.Drawing.Point(31, 226)
        Me.Btn0p.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn0p.Name = "Btn0p"
        Me.Btn0p.Size = New System.Drawing.Size(103, 40)
        Me.Btn0p.TabIndex = 28
        Me.Btn0p.Text = "完全沒有"
        Me.Btn0p.UseVisualStyleBackColor = True
        '
        'Btn1p
        '
        Me.Btn1p.Location = New System.Drawing.Point(142, 226)
        Me.Btn1p.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn1p.Name = "Btn1p"
        Me.Btn1p.Size = New System.Drawing.Size(103, 40)
        Me.Btn1p.TabIndex = 27
        Me.Btn1p.Text = "輕微" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "無影響生活"
        Me.Btn1p.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(101, 32)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(57, 19)
        Me.LinkLabel1.TabIndex = 36
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Source"
        '
        'BAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 328)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Btn2p)
        Me.Controls.Add(Me.Btn3p)
        Me.Controls.Add(Me.LabelA)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.Btn0p)
        Me.Controls.Add(Me.Btn1p)
        Me.Name = "BAI"
        Me.Text = "貝克焦慮量表 | Beck Anxiety Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn2p As Button
    Friend WithEvents Btn3p As Button
    Friend WithEvents LabelA As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnReturn As Button
    Friend WithEvents Btn0p As Button
    Friend WithEvents Btn1p As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
