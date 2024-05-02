Imports MySql.Data.MySqlClient
Module Everything
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public poNum As String
    Public PODate As DateTime
    Public DReceived As DateTime
    Public supplier As String
    Public prsNum As String

    Sub connOpen()
        conn.ConnectionString = "server=127.0.0.1;user=root;password=user;database=project"
        conn.Open()
    End Sub

    Sub Ifcon()
        If conn.State = ConnectionState.Closed Then
            connOpen()
        End If
    End Sub
End Module
