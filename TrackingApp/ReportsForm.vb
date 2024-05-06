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

        ' Check if a table is selected in the ComboBox
        If ComboBox1.SelectedItem IsNot Nothing Then
            ' Clear the existing data in the DataGridView
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()

            ' Get the selected table name
            Dim tableName As String = tableMappings(ComboBox1.SelectedItem.ToString())

            ' Retrieve the data from the selected table
            Dim query As String = "SELECT * FROM " & tableName

            ' Create a command to execute the query
            Using command As New MySqlCommand(query, conn)
                ' Create a data adapter to retrieve the data
                Using adapter As New MySqlDataAdapter(command)
                    ' Create a DataTable to hold the data
                    Dim dataTable As New DataTable()

                    ' Fill the DataTable with the data from the database
                    adapter.Fill(dataTable)

                    ' Remove primary key columns
                    Dim primaryKeyColumns As List(Of String) = GetPrimaryKeyColumns(tableName)
                    For Each primaryKeyColumn As String In primaryKeyColumns
                        dataTable.Columns.Remove(primaryKeyColumn)
                    Next

                    ' Bind the DataTable to the DataGridView to display the data
                    DataGridView1.DataSource = dataTable
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                End Using
            End Using
            ' Update Label1.Text based on the selected item
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
        ' Close the database connection
        conn.Close()
    End Sub

    Private Function GetPrimaryKeyColumns(tableName As String) As List(Of String)
        ' Open the database connection
        Ifcon()

        Dim primaryKeyColumns As New List(Of String)()

        ' Retrieve the primary key column names for the specified table
        Dim query As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = @TableName AND CONSTRAINT_NAME = 'PRIMARY'"

        ' Create a command to execute the query
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@TableName", tableName)

            ' Execute the query and read the primary key column names
            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    ' Add the primary key column name to the list
                    primaryKeyColumns.Add(reader.GetString(0))
                End While
            End Using
        End Using

        ' Close the database connection
        conn.Close()

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