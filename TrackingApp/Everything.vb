Imports System.IO
Imports System.Xml
Imports MySql.Data.MySqlClient
Module Everything
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public poNum As String
    Public PODate As Date
    Public DReceived As Date
    Public supplier As String
    Public prsNum As String
    Public server As String
    Public username As String
    Public password As String
    Public database As String

    Sub IconLoad(form As Form, iconFilePath As String)
        Dim iconPath As String = Path.Combine(Application.StartupPath, iconFilePath)
        Dim icon As New Icon(iconPath)
        Dim formType As Type = form.GetType()
        formType.GetProperty("Icon").SetValue(form, icon, Nothing)
    End Sub

    Sub connectionOpen()
        connectionOpen(GetConnectionString)
    End Sub

    Sub connectionOpen(connectionString As String)
        conn.ConnectionString = connectionString
        conn.Open()
    End Sub

    Sub Ifcon()
        If conn.State = ConnectionState.Closed Then
            connectionOpen(GetConnectionString)
        End If
    End Sub
    Function GetConnectionString() As String
        If String.IsNullOrEmpty(server) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(database) Then
            Return ReadConnectionStringFromConfig()
        Else
            Return $"server={server};user={username};password={password};database={database};"
        End If
    End Function
    Function ReadConnectionStringFromConfig() As String
        Dim configFilePath As String = Path.Combine(Application.StartupPath, "config.xml")

        If File.Exists(configFilePath) Then
            Try
                Dim doc As New XmlDocument()
                doc.Load(configFilePath)

                Dim connectionStringElement As XmlElement = doc.SelectSingleNode("/configuration/connectionString")

                If connectionStringElement IsNot Nothing Then
                    Return connectionStringElement.InnerText
                End If
            Catch ex As Exception
                MessageBox.Show("Error reading configuration file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        Return "server=127.0.0.1;user=root;password=user;database=project"
    End Function
End Module
