Imports System.IO
Imports MySql.Data.MySqlClient
Imports OfficeOpenXml

Public Class ReportsForm
    Private tableMappings As New Dictionary(Of String, String)()

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Open the database connection
        Ifcon()

        tableMappings.Add("Items List", "po_items_container")
        tableMappings.Add("Purchase Orders", "po_listing")
        tableMappings.Add("Disposed Items", "disposal")
        tableMappings.Add("Returned Items", "returns")
        tableMappings.Add("Item Holders", "stock")
        ' Add more mappings as needed

        ' Add the user-friendly texts to the ComboBox
        ComboBox1.Items.AddRange(tableMappings.Keys.ToArray())

        ' Close the database connection
        conn.Close()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ' Open the database connection
        Ifcon()
        If ComboBox1.SelectedItem IsNot Nothing Then
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()

            Dim tableName As String = tableMappings(ComboBox1.SelectedItem.ToString())

            Dim query As String = "SELECT * FROM " & tableName

            Using command As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dataTable As New DataTable()

                    adapter.Fill(dataTable)
                    ModifyDisposalColumnNames(dataTable)
                    ModifyPoItemContainerColumnNames(dataTable)
                    ModifyPoListingColumnNames(dataTable)
                    ModifyReturnsColumnNames(dataTable)
                    ModifyStocksColumnNames(dataTable)
                    Dim primaryKeyColumns As List(Of String) = GetPrimaryKeyColumns(tableName)

                    ' Remove the primary key columns from the DataTable
                    For Each columnName As String In primaryKeyColumns
                        If dataTable.Columns.Contains(columnName) Then
                            dataTable.Columns.Remove(columnName)
                        End If
                    Next

                    DataGridView1.DataSource = dataTable
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                End Using
            End Using

            If tableName = "po_items_container" Then
                Label1.Text = "List of all Items"
            ElseIf tableName = "po_listing" Then
                Label1.Text = "List of all Purchase Orders"
            ElseIf tableName = "disposal" Then
                Label1.Text = "List of all Disposed Items"
            ElseIf tableName = "stock" Then
                Label1.Text = "List of all Item Holders"
            ElseIf tableName = "returns" Then
                Label1.Text = "List of all Returned Items"
            End If
        End If

        conn.Close()
    End Sub

    Private Function GetPrimaryKeyColumns(tableName As String) As List(Of String)
        Dim primaryKeyColumns As New List(Of String)()

        ' Retrieve the primary key information from the database schema
        Dim schemaQuery As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = @TableName AND CONSTRAINT_NAME = 'PRIMARY'"

        Using command As New MySqlCommand(schemaQuery, conn)
            command.Parameters.AddWithValue("@TableName", tableName)
            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim columnName As String = reader("COLUMN_NAME").ToString()
                    primaryKeyColumns.Add(columnName)
                End While
            End Using
        End Using

        Return primaryKeyColumns
    End Function

    Private filePath As String
    Private Sub SaveDataToExcel(dataGridView As DataGridView)
        ExcelPackage.LicenseContext = LicenseContext.Commercial
        Using package As New ExcelPackage()
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Sheet1")

            ' Write column headers
            For columnIndex As Integer = 0 To dataGridView.Columns.Count - 1
                worksheet.Cells(1, columnIndex + 1).Value = dataGridView.Columns(columnIndex).HeaderText
            Next

            ' Write data rows
            For rowIndex As Integer = 0 To dataGridView.Rows.Count - 1
                For columnIndex As Integer = 0 To dataGridView.Columns.Count - 1
                    worksheet.Cells(rowIndex + 2, columnIndex + 1).Value = dataGridView.Rows(rowIndex).Cells(columnIndex).Value
                Next
            Next

            ' Save the Excel file
            Using fileStream As New FileStream(filePath, FileMode.Create)
                package.SaveAs(fileStream)
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            filePath = saveFileDialog.FileName
            SaveDataToExcel(DataGridView1)
            MessageBox.Show($"Data saved to: {filePath}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class