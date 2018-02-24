<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.executeEncoding = New System.Windows.Forms.Button()
        Me.textOriginal = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.copyText = New System.Windows.Forms.Button()
        Me.ResultText = New System.Windows.Forms.RichTextBox()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.initialText = New System.Windows.Forms.TextBox()
        Me.endText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'executeEncoding
        '
        Me.executeEncoding.Location = New System.Drawing.Point(12, 281)
        Me.executeEncoding.Name = "executeEncoding"
        Me.executeEncoding.Size = New System.Drawing.Size(340, 39)
        Me.executeEncoding.TabIndex = 1
        Me.executeEncoding.Text = "実行"
        Me.executeEncoding.UseVisualStyleBackColor = True
        '
        'textOriginal
        '
        Me.textOriginal.Location = New System.Drawing.Point(14, 24)
        Me.textOriginal.Name = "textOriginal"
        Me.textOriginal.Size = New System.Drawing.Size(340, 204)
        Me.textOriginal.TabIndex = 2
        Me.textOriginal.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "文字の先頭"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "文字の後方"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "元データ"
        '
        'copyText
        '
        Me.copyText.Location = New System.Drawing.Point(394, 281)
        Me.copyText.Name = "copyText"
        Me.copyText.Size = New System.Drawing.Size(360, 39)
        Me.copyText.TabIndex = 8
        Me.copyText.Text = "コピー"
        Me.copyText.UseVisualStyleBackColor = True
        '
        'ResultText
        '
        Me.ResultText.Location = New System.Drawing.Point(394, 24)
        Me.ResultText.Name = "ResultText"
        Me.ResultText.Size = New System.Drawing.Size(360, 204)
        Me.ResultText.TabIndex = 9
        Me.ResultText.Text = ""
        '
        'resultLabel
        '
        Me.resultLabel.AutoSize = True
        Me.resultLabel.Location = New System.Drawing.Point(401, 9)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(53, 12)
        Me.resultLabel.TabIndex = 10
        Me.resultLabel.Text = "実行結果"
        '
        'initialText
        '
        Me.initialText.Location = New System.Drawing.Point(14, 246)
        Me.initialText.Name = "initialText"
        Me.initialText.Size = New System.Drawing.Size(338, 19)
        Me.initialText.TabIndex = 11
        '
        'endText
        '
        Me.endText.Location = New System.Drawing.Point(394, 246)
        Me.endText.Name = "endText"
        Me.endText.Size = New System.Drawing.Size(360, 19)
        Me.endText.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 331)
        Me.Controls.Add(Me.endText)
        Me.Controls.Add(Me.initialText)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.ResultText)
        Me.Controls.Add(Me.copyText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textOriginal)
        Me.Controls.Add(Me.executeEncoding)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "一括文字整形アプリケーション"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents executeEncoding As Button
    Friend WithEvents textOriginal As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents copyText As Button
    Friend WithEvents ResultText As RichTextBox
    Friend WithEvents resultLabel As Label
    Friend WithEvents initialText As TextBox
    Friend WithEvents endText As TextBox
End Class
