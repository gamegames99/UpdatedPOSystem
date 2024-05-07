Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if the database connection exists
        If IsDatabaseConnectionValid() Then
            Me.Hide()
            menu.Show()
        Else
            MessageBox.Show("No database connection found. Please establish a new connection.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Hide()
            menu.Show()
            OpenSettingsForm()
        End If
    End Sub
    Private Function IsDatabaseConnectionValid() As Boolean
        ' Check if the database connection is valid by attempting to read from it
        Try
            ' Open the connection
            Ifcon()

            ' Perform a simple query to check if the connection is working
            Dim query As String = "SELECT * FROM po_listing"
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteScalar()

            ' Close the connection
            conn.Close()

            Return True
        Catch ex As Exception
            ' An exception occurred, indicating that the connection is invalid
            conn.Close()
            Return False
        End Try
    End Function

    Private Sub OpenSettingsForm()
        ' Open the Settings form to establish a new connection
        Dim settingsForm As New Settings()
        settingsForm.ShowDialog()
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
