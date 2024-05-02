Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Stocks
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Ifcon()
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO stock(stockDescription, name_receiver, date_received, stockQuantity) 
VALUES (@desc, @nrec, @drec, @qty)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@drec", MySqlDbType.Date).Value = DateTime.Today
            cmd.Parameters.Add("@nrec", MySqlDbType.String).Value = txtboxPersonnel.Text
            cmd.Parameters.Add("@qty", MySqlDbType.Int32).Value = txtboxQuantity.Text
            cmd.Parameters.Add("@desc", MySqlDbType.String).Value = txtboxDescription.Text
            cmd.ExecuteNonQuery()
            MsgBox("Saved")
            clearAll()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub stockTable()
        Try
            Ifcon()
            Dim sql As String = "SELECT item_serial, item_desc, item_quantity FROM po_items_container"
            Dim command As New MySqlCommand(sql, conn)
            Dim adapter As New MySqlDataAdapter(command)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub newTable()
        Try
            Ifcon()
            Dim query As String = "SELECT * FROM stock"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            DataGridView2.DataSource = dataTable
            DataGridView2.Columns("stock_id").Visible = False
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub clearAll()
        newTable()
        stockTable()
        ResizeColumns()
    End Sub
    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearAll()
    End Sub
    Private Sub ResizeColumns()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 AndAlso Not DataGridView1.SelectedRows(0).IsNewRow Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim cellValue As Object = selectedRow.Cells("item_desc").Value
            Dim qtyValue As Object = selectedRow.Cells("item_quantity").Value
            If cellValue IsNot Nothing Then
                txtboxDescription.Text = cellValue.ToString()
                txtboxQuantity.Text = qtyValue.ToString()
            End If
        End If
    End Sub
    Private Sub txtboxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm = txtboxSearch.Text.Trim.ToLower
        If String.IsNullOrWhiteSpace(searchTerm) Then
            MessageBox.Show("Field is empty. Type at least one character", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        DataGridView1.ClearSelection()
        Dim matchFound = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim rowContainsTerm = False
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString.ToLower.Contains(searchTerm) Then
                    rowContainsTerm = True
                    cell.Selected = True
                    Exit For
                End If
            Next
            If rowContainsTerm Then
                row.Selected = True
                DataGridView1.FirstDisplayedScrollingRowIndex = row.Index
                matchFound = True
            End If
        Next
        If Not matchFound Then
            MessageBox.Show("No matches found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtboxSearch_Click(sender As Object, e As EventArgs) Handles txtboxSearch.Click
        txtboxSearch.Text = ""
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        clearAll()
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            If Not String.IsNullOrEmpty(txtboxDescription.Text) Then
                Dim selectDesc As String = txtboxDescription.Text.Trim()

                Ifcon()
                cmd.Connection = conn
                cmd.CommandText = "SELECT item_serial, purchase_order_no FROM po_items_container WHERE item_desc = @desc"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@desc", selectDesc)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim itemSerial As String = reader.GetString("item_serial")
                    Dim purchaseOrderNo As String = reader.GetString("purchase_order_no")

                    reader.Close()

                    ' Retrieve prs_no and po_supplier based on po_no from po_listing table
                    cmd.CommandText = "SELECT po_date, prs_date, prs_no, po_supplier FROM po_listing WHERE po_no = @poNo"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@poNo", purchaseOrderNo)

                    Dim reader2 As MySqlDataReader = cmd.ExecuteReader()

                    If reader2.Read() Then
                        Dim prsNo As String = reader2.GetString("prs_no")
                        Dim poSupplier As String = reader2.GetString("po_supplier")
                        Dim poDate As DateTime = reader2.GetDateTime("po_date")
                        Dim prsDate As DateTime = reader2.GetDateTime("prs_date")

                        reader2.Close()

                        ' Create and display the stock_information form
                        Dim stockInfoForm As New stock_information(selectDesc, itemSerial, poSupplier, purchaseOrderNo, prsNo, poDate, prsDate)
                        stockInfoForm.ShowDialog()

                    Else
                        reader2.Close()
                        MessageBox.Show("No matching record found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    reader.Close()
                    MessageBox.Show("No matching record found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please select a row.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
End Class