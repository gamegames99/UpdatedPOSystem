Imports Org.BouncyCastle.Tls
Imports System.Reflection

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
    Public Shared Sub NotifyEstablishNewConnection()
        MsgBox("Connection needs to be re-established. Please provide a new connection")
    End Sub
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim server As String = txtServer.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Pass the connection details to Module.vb
        EstablishNewConnection(server, username, password)
    End Sub
End Class