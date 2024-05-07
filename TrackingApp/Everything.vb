Imports MySql.Data.MySqlClient
Module Everything
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public poNum As String
    Public PODate As DateTime
    Public DReceived As DateTime
    Public supplier As String
    Public prsNum As String

    Sub connectionOpen()
        conn.ConnectionString = "server=127.0.0.1;user=root;password=user;database=project"
        conn.Open()
    End Sub

    Sub Ifcon()
        If conn.State = ConnectionState.Closed Then
            connectionOpen()
        End If
    End Sub
    Function IsDatabaseExist(database As String) As Boolean
        Dim query As String = $"SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '{database}'"
        cmd = New MySqlCommand(query, conn)
        Dim result As Object = cmd.ExecuteScalar()
        Return result IsNot Nothing AndAlso Not String.IsNullOrEmpty(result.ToString())
    End Function

    Sub EstablishNewConnection(server As String, username As String, password As String)
        conn.Close()
        connectionOpen()

        Dim database As String = New MySqlConnectionStringBuilder(conn.ConnectionString).Database
        If Not IsDatabaseExist(database) Then
            conn.Close()
            ' Notify Settings.vb form to establish a new connection
            Settings.NotifyEstablishNewConnection()
        End If
    End Sub
End Module
