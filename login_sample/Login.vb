Option Explicit On

Public Class Login

	Public Shared login_Name As String = ""

	Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

		Dim con1 As New OleDb.OleDbConnection
		Dim cmd1 As New OleDb.OleDbCommand

		' DB接続文字列の設定
		'con1.ConnectionString = _
		'	"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & "C:\VB\main\main1\bin\Debug\db1.mdb"
		con1.ConnectionString = _
			"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & "C:\VB\login_sample\login_sample\db1.mdb"
		' コネクションの設定
		cmd1.Connection = con1

		' DB接続を開く
		con1.Open()

		' SQL文の設定
		Dim SQL As String
		SQL = "SELECT * FROM [user] WHERE user = :p1 and password = :p2"
		cmd1.CommandText = SQL

		' SQL文パラメータの設定
		cmd1.Parameters.Clear()
		cmd1.Parameters.Add(":1", OleDb.OleDbType.Char, 10)
		cmd1.Parameters(":1").Value = Me.User1.Text
		cmd1.Parameters.Add(":2", OleDb.OleDbType.Char, 10)
		cmd1.Parameters(":2").Value = Me.Password1.Text

		' データを取得する 
		Dim dt As New DataTable
		Dim adapter As New OleDb.OleDbDataAdapter(cmd1)
		adapter.Fill(dt)
		adapter.Dispose()
		If dt.Rows.Count > 0 Then
			login_Name = dt.Rows(0).Item("name")
			MsgBox(login_Name & "さんですね")
		Else
			login_Name = ""
			MsgBox("データなし")
		End If
		' DB接続を閉じる
		If Not con1 Is Nothing Then
			con1.Close()
			con1.Dispose()
		End If

		If login_Name = "" Then
			Exit Sub
		End If

		Dim f As New menu
		f.Show()
		My.Application.ApplicationContext.MainForm = f
		Me.Close()

	End Sub

	Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
		Me.Close()
	End Sub

End Class
