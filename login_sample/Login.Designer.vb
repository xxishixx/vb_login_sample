﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
	Friend WithEvents User1 As System.Windows.Forms.TextBox
	Friend WithEvents Password1 As System.Windows.Forms.TextBox
	Friend WithEvents OK As System.Windows.Forms.Button
	Friend WithEvents Cancel As System.Windows.Forms.Button

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
		Me.UsernameLabel = New System.Windows.Forms.Label()
		Me.PasswordLabel = New System.Windows.Forms.Label()
		Me.User1 = New System.Windows.Forms.TextBox()
		Me.Password1 = New System.Windows.Forms.TextBox()
		Me.OK = New System.Windows.Forms.Button()
		Me.Cancel = New System.Windows.Forms.Button()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
		Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
		Me.LogoPictureBox.TabIndex = 0
		Me.LogoPictureBox.TabStop = False
		'
		'UsernameLabel
		'
		Me.UsernameLabel.Location = New System.Drawing.Point(172, 24)
		Me.UsernameLabel.Name = "UsernameLabel"
		Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
		Me.UsernameLabel.TabIndex = 0
		Me.UsernameLabel.Text = "ユーザー名(&U)"
		Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PasswordLabel
		'
		Me.PasswordLabel.Location = New System.Drawing.Point(172, 81)
		Me.PasswordLabel.Name = "PasswordLabel"
		Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
		Me.PasswordLabel.TabIndex = 2
		Me.PasswordLabel.Text = "パスワード(&P)"
		Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'User1
		'
		Me.User1.Location = New System.Drawing.Point(174, 44)
		Me.User1.Name = "User1"
		Me.User1.Size = New System.Drawing.Size(220, 22)
		Me.User1.TabIndex = 1
		'
		'Password1
		'
		Me.Password1.Location = New System.Drawing.Point(174, 101)
		Me.Password1.Name = "Password1"
		Me.Password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.Password1.Size = New System.Drawing.Size(220, 22)
		Me.Password1.TabIndex = 3
		'
		'OK
		'
		Me.OK.Location = New System.Drawing.Point(197, 161)
		Me.OK.Name = "OK"
		Me.OK.Size = New System.Drawing.Size(94, 23)
		Me.OK.TabIndex = 4
		Me.OK.Text = "OK(&O)"
		'
		'Cancel
		'
		Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel.Location = New System.Drawing.Point(300, 161)
		Me.Cancel.Name = "Cancel"
		Me.Cancel.Size = New System.Drawing.Size(94, 23)
		Me.Cancel.TabIndex = 5
		Me.Cancel.Text = "キャンセル(&C)"
		'
		'Login
		'
		Me.AcceptButton = Me.OK
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.Cancel
		Me.ClientSize = New System.Drawing.Size(401, 192)
		Me.Controls.Add(Me.Cancel)
		Me.Controls.Add(Me.OK)
		Me.Controls.Add(Me.Password1)
		Me.Controls.Add(Me.User1)
		Me.Controls.Add(Me.PasswordLabel)
		Me.Controls.Add(Me.UsernameLabel)
		Me.Controls.Add(Me.LogoPictureBox)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Login"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

End Sub

End Class