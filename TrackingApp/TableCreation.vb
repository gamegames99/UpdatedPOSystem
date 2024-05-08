Imports System.Data
Imports MySql.Data.MySqlClient

Module TableCreation
    Public Sub ModifyPoListingColumnNames(dataTable As DataTable)
        Dim columnMappings As New Dictionary(Of String, String)()
        columnMappings.Add("po_no", "Purchase Order #")
        columnMappings.Add("po_date", "Purchase Order Date")
        columnMappings.Add("po_supplier", "Supplier")
        columnMappings.Add("prs_no", "PRS #")
        columnMappings.Add("prs_date", "PRS Date")

        For Each column As DataColumn In dataTable.Columns
            If columnMappings.ContainsKey(column.ColumnName) Then
                ' Modify the column name as needed
                column.ColumnName = columnMappings(column.ColumnName)
            End If
        Next
    End Sub
    Public Sub ModifyPoItemContainerColumnNames(dataTable As DataTable)
        Dim columnMappings As New Dictionary(Of String, String)()
        columnMappings.Add("item_desc", "Item Description")
        columnMappings.Add("item_serial", "Serial Number")
        columnMappings.Add("purchase_order_no", "Purchase Order #")
        columnMappings.Add("item_quantity", "Quantity")
        columnMappings.Add("item_price", "Unit Price")

        For Each column As DataColumn In dataTable.Columns
            If columnMappings.ContainsKey(column.ColumnName) Then
                ' Modify the column name as needed
                column.ColumnName = columnMappings(column.ColumnName)
            End If
        Next
    End Sub
    Public Sub ModifyStocksColumnNames(dataTable As DataTable)
        Dim columnMappings As New Dictionary(Of String, String)()
        columnMappings.Add("name_receiver", "Name of Receiver")
        columnMappings.Add("stockDescription", "Item Description")
        columnMappings.Add("stock_serial", "Serial Number")
        columnMappings.Add("date_received", "Date Received")
        columnMappings.Add("stockQuantity", "Quantity")

        For Each column As DataColumn In dataTable.Columns
            If columnMappings.ContainsKey(column.ColumnName) Then
                ' Modify the column name as needed
                column.ColumnName = columnMappings(column.ColumnName)
            End If
        Next
    End Sub
    Public Sub ModifyReturnsColumnNames(dataTable As DataTable)
        Dim columnMappings As New Dictionary(Of String, String)()
        columnMappings.Add("returner_name", "Reciprocator")
        columnMappings.Add("returned_item_name", "Item Returned")
        columnMappings.Add("returned_item_serial", "Serial Number")
        columnMappings.Add("returned_reason", "Reasons of Return")
        columnMappings.Add("returned_date", "Date Returned")

        For Each column As DataColumn In dataTable.Columns
            If columnMappings.ContainsKey(column.ColumnName) Then
                ' Modify the column name as needed
                column.ColumnName = columnMappings(column.ColumnName)
            End If
        Next
    End Sub
    Public Sub ModifyDisposalColumnNames(dataTable As DataTable)
        Dim columnMappings As New Dictionary(Of String, String)()
        columnMappings.Add("item_desc", "Item Description")
        columnMappings.Add("item_serial", "Serial Number")
        columnMappings.Add("po_number", "Purchase Order #")
        columnMappings.Add("reason", "Reasons of Disposal")
        columnMappings.Add("date_of_disposal", "Date of Disposal")

        For Each column As DataColumn In dataTable.Columns
            If columnMappings.ContainsKey(column.ColumnName) Then
                ' Modify the column name as needed
                column.ColumnName = columnMappings(column.ColumnName)
            End If
        Next
    End Sub
End Module