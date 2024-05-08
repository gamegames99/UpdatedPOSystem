Imports System.Reflection
Imports MySql.Data.MySqlClient
Public Class Settings
    Private server As String
    Private username As String
    Private password As String
    Private database As String
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        server = txtServer.Text
        username = txtUsername.Text
        password = txtPassword.Text
        database = "project"

        ' Connection string for the MySQL database
        Dim connectionString As String = $"server={server};user={username};password={password};"

        ' Create a new MySqlConnection
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("Database connection detected!")
                btnCreate.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Error connecting to database: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Connection string for the MySQL database
        Dim connectionString As String = $"server={server};user={username};password={password};"

        ' SQL statements to create the schema and tables
        Dim createSchemaQuery As String = $"CREATE SCHEMA IF NOT EXISTS {database};"
        Dim createDisposalTableQuery As String = $"CREATE TABLE IF NOT EXISTS {database}.disposal (disposal_id INT AUTO_INCREMENT PRIMARY KEY, item_desc VARCHAR(245), item_serial VARCHAR(245), po_number VARCHAR(245), reason VARCHAR(245), date_of_disposal DATE);"
        Dim createPoItemsContainerTableQuery As String = $"CREATE TABLE IF NOT EXISTS {database}.po_items_container (id_container VARCHAR(255) PRIMARY KEY, item_desc VARCHAR(255), item_serial VARCHAR(255) UNIQUE, purchase_order_no VARCHAR(255), item_quantity VARCHAR(255), item_price VARCHAR(255));"
        Dim createPoListingTableQuery As String = $"CREATE TABLE IF NOT EXISTS {database}.po_listing (id_po INT AUTO_INCREMENT PRIMARY KEY, po_no VARCHAR(255) UNIQUE, po_date DATE, po_supplier VARCHAR(255), prs_no VARCHAR(255), prs_date DATE);"
        Dim createReturnsTableQuery As String = $"CREATE TABLE IF NOT EXISTS {database}.returns (id_returns INT AUTO_INCREMENT PRIMARY KEY, returner_name VARCHAR(245), returned_item_name VARCHAR(245), returned_item_serial VARCHAR(245), returned_reason VARCHAR(245), returned_date DATE);"
        Dim createStockTableQuery As String = $"CREATE TABLE IF NOT EXISTS {database}.stock (stock_id INT AUTO_INCREMENT PRIMARY KEY, name_receiver VARCHAR(245), stockDescription VARCHAR(245), stock_serial VARCHAR(245), date_received DATE, stockQuantity VARCHAR(245));"

        ' Create a new MySqlConnection
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Create the schema
                Using createSchemaCommand As New MySqlCommand(createSchemaQuery, connection)
                    createSchemaCommand.ExecuteNonQuery()
                End Using

                ' Create the disposal table
                Using createDisposalTableCommand As New MySqlCommand(createDisposalTableQuery, connection)
                    createDisposalTableCommand.ExecuteNonQuery()
                End Using

                ' Create the po_items_container table
                Using createPoItemsContainerTableCommand As New MySqlCommand(createPoItemsContainerTableQuery, connection)
                    createPoItemsContainerTableCommand.ExecuteNonQuery()
                End Using

                ' Create the po_listing table
                Using createPoListingTableCommand As New MySqlCommand(createPoListingTableQuery, connection)
                    createPoListingTableCommand.ExecuteNonQuery()
                End Using

                ' Create the returns table
                Using createReturnsTableCommand As New MySqlCommand(createReturnsTableQuery, connection)
                    createReturnsTableCommand.ExecuteNonQuery()
                End Using

                ' Create the stock table
                Using createStockTableCommand As New MySqlCommand(createStockTableQuery, connection)
                    createStockTableCommand.ExecuteNonQuery()
                End Using

                MessageBox.Show("Schema and tables created successfully!")
                btnApply.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Error creating database and tables: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Everything.conn.ConnectionString = $"server={server};user={username};password={password};database={database};"
        MessageBox.Show("Database Connection applied!", "Inventory Management prompts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
    End Sub
End Class