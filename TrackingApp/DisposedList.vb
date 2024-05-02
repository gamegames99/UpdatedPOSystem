Imports MySql.Data.MySqlClient

Public Class DisposedList
    Private Sub tableDisposed()
        Try
            Ifcon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM disposal"

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
            DataGridView1.Columns("disposal_id").Visible = False
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub DisposedList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableDisposed()
    End Sub
End Class