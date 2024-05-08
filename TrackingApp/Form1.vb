Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        menu.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim imagePath As String = IO.Path.Combine(Application.StartupPath, "images\BILECO.jpg")
        Dim image As New Bitmap(imagePath)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Image = image

        Dim iconPath As String = IO.Path.Combine(Application.StartupPath, "icons\BILECO.ico")
        Dim icon As New Icon(iconPath)
        Dim formType As Type = Me.GetType()
        formType.GetProperty("Icon").SetValue(Me, icon, Nothing)
    End Sub
End Class
