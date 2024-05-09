Imports System.IO
Imports System.Xml
Imports MySql.Data.MySqlClient
Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        server = txtServer.Text
        username = txtUsername.Text
        password = txtPassword.Text

        ' Connection string for the MySQL database
        Dim connectionString As String = $"server={server};user={username};password={password};"

        ' Create a new MySqlConnection
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("Connection detected! Click OK to continue.", "PO Management Project 2024", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCreate.Enabled = True
            Catch ex As Exception
                MessageBox.Show("" & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' store the string value into database
        database = "newbileco"
        Dim connectionString As String = $"server={server};user={username};password={password};"

        ' SQL statements to create the schema and tables
        Dim createSchemaQuery As String = $"CREATE SCHEMA IF NOT EXISTS {database};"
        Dim createDisposalTableQuery As String = $"CREATE TABLE IF NOT EXISTS {database}.disposal (disposal_id INT AUTO_INCREMENT PRIMARY KEY, item_desc VARCHAR(245), item_serial VARCHAR(245), po_number VARCHAR(245), reason VARCHAR(245), date_of_disposal DATE);"
        Dim createPoItemsContainerTableQuery As String = $"CREATE TABLE IF NOT EXISTS {database}.po_items_container (id_container INT AUTO_INCREMENT PRIMARY KEY, item_desc VARCHAR(255), item_serial VARCHAR(255) UNIQUE, purchase_order_no VARCHAR(255), item_quantity VARCHAR(255), item_price VARCHAR(255));"
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

                MessageBox.Show("Schema and tables created. Click OK to continue.", "PO Management Project 2024", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Create the XML configuration file path
                Dim configFilePath As String = Path.Combine(Application.StartupPath, "config.xml")
                Dim conString As String = $"server={server};user={username};password={password};database={database}"
                ' Create an XML document
                Dim doc As New XmlDocument()

                ' Create the root element
                Dim rootElement As XmlElement = doc.CreateElement("configuration")
                doc.AppendChild(rootElement)

                ' Create the connection string element and set its value
                Dim connectionStringElement As XmlElement = doc.CreateElement("connectionString")
                connectionStringElement.InnerText = conString
                rootElement.AppendChild(connectionStringElement)

                ' Save the XML document to the configuration file
                doc.Save(configFilePath)

                MessageBox.Show("Configuration file created successfully!", "PO Management Project 2024", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error creating database configuration: " & ex.Message)
            Finally
                connection.Close()
                Me.Hide()
            End Try
        End Using
    End Sub
End Class