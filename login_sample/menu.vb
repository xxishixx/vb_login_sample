Public Class menu

	Private Sub menu_Load(sender As Object, e As EventArgs) Handles Me.Load
		Me.Label1.Text = Login.login_Name
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim result
		result = MessageBox.Show("終了しますか？", "メッセージ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
		If result = vbOK Then
			End
		End If
	End Sub

End Class
