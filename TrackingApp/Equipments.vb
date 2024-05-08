Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class Equipments
    Private Sub cbox()
        Try
            Ifcon()
            cmd.Connection = conn
            cmd.CommandText = "SELECT po_no FROM po_listing"
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            cbxPONum.Items.Clear()
            While reader.Read()
                cbxPONum.Items.Add(reader("po_no").ToString())
            End While
            reader.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub AssignValuesToFields(selectedPoNo As String)
        Try
            Ifcon()
            cmd.Connection = conn

            ' Retrieve the corresponding values from po_listing table
            cmd.CommandText = "SELECT po_date, prs_date, po_supplier, prs_no FROM po_listing WHERE po_no = @po"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@po", selectedPoNo)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Assign the retrieved values to the fields
            While reader.Read()
                purchaseDate.Value = reader.GetDateTime("po_date").Date
                dateReceived.Value = reader.GetDateTime("prs_date").Date
                txtboxSupplier.Text = reader.GetString("po_supplier")
                txtboxprs.Text = reader.GetString("prs_no")
            End While

            ' Close the data reader
            reader.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub clearAll()
        NewTable()
        ResizeColumns()
        cbox()
    End Sub
    Private Sub hideGB()
        CheckBox1.CheckState = CheckState.Unchecked
        GroupBox2.Visible = False
        GroupBox1.Height = Me.ClientSize.Height - GroupBox1.Top - CheckBox1.Height ' Adjust the height of GroupBox1 dynamically
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            GroupBox2.Visible = True
            GroupBox1.Height = Me.ClientSize.Height - GroupBox1.Top - GroupBox2.Height ' Adjust the height of GroupBox1 dynamically
        Else
            GroupBox2.Visible = False
            GroupBox1.Height = Me.ClientSize.Height - GroupBox1.Top - CheckBox1.Height ' Adjust the height of GroupBox1 dynamically
        End If
    End Sub
    Private Sub Equipments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearAll()
        hideGB()
    End Sub
    Private Sub ResizeColumns()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
    Private Sub NewTable()
        Try
            Ifcon()
            Dim sql As String = "SELECT * FROM po_listing ORDER by po_no DESC"
            Dim command As New MySqlCommand(sql, conn)
            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            ModifyPoListingColumnNames(dataTable)
            DataGridView1.DataSource = dataTable
            DataGridView1.Columns("id_po").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(cbxPONum.Text) OrElse
           String.IsNullOrWhiteSpace(purchaseDate.Value) OrElse
           String.IsNullOrWhiteSpace(dateReceived.Value) OrElse
           String.IsNullOrWhiteSpace(txtboxprs.Text) OrElse
           String.IsNullOrWhiteSpace(txtboxSupplier.Text) Then
            MessageBox.Show("Required fields must not be empty. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            poNum = cbxPONum.Text
            PODate = purchaseDate.Value.Date
            DReceived = dateReceived.Value.Date
            supplier = txtboxSupplier.Text
            prsNum = txtboxprs.Text
            items.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm = txtSearch.Text.Trim.ToLower
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

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxSupplier.Clear()
        txtboxprs.Clear()
        cbxPONum.Text = ""
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        clearAll()
    End Sub

    Private Sub cbxPONum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPONum.SelectedIndexChanged
        Dim selectedPoNo As String = cbxPONum.SelectedItem.ToString()
        AssignValuesToFields(selectedPoNo)
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 AndAlso Not DataGridView1.SelectedRows(0).IsNewRow Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim cellValue As Object = selectedRow.Cells("Purchase Order #").Value
            If cellValue IsNot Nothing Then
                Dim selectedPoNo As String = cellValue.ToString()
                cbxPONum.Text = selectedPoNo
                AssignValuesToFields(selectedPoNo)
                poNum = cbxPONum.Text
            End If
        End If
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If cbxPONum.SelectedIndex <> -1 Then
            Dim selectedPoNo As String = cbxPONum.SelectedItem.ToString()
            Try
                Ifcon()
                cmd.Connection = conn
                cmd.CommandText = "SELECT id_container, item_desc, item_serial, item_quantity, item_price FROM po_items_container WHERE purchase_order_no = @po"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@po", selectedPoNo)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                Dim dTable As New DataTable()
                dTable.Load(reader)
                ModifyPoItemContainerColumnNames(dTable)
                ' Open the listing form and pass the DataTable as a parameter
                Dim listingForm As New listing(dTable, selectedPoNo)
                listingForm.ShowDialog()

                reader.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                conn.Close()
            End Try
        Else
            MsgBox("No purchase order number selected. Please select a row")
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If cbxPONum.SelectedIndex <> -1 Then
            Dim selectedPoNo As String = cbxPONum.SelectedItem.ToString()
            Try
                Ifcon()
                cmd.Connection = conn
                cmd.CommandText = "SELECT id_container, item_serial FROM po_items_container WHERE purchase_order_no = @po"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@po", selectedPoNo)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ' Create a list to store the item serial numbers
                Dim serialNumbers As New List(Of String)()
                Dim identifiers As New List(Of String)()
                While reader.Read()
                    ' Add each item serial number to the list
                    serialNumbers.Add(reader("item_serial").ToString())
                    identifiers.Add(reader("id_container").ToString)
                End While
                reader.Close()
                ' Open the editcontainer form and pass the selected purchase order number and item serial numbers
                Dim editContainerForm As New editcontainer(selectedPoNo, serialNumbers, identifiers)
                editContainerForm.ShowDialog()
            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                conn.Close()
            End Try
        Else
            MsgBox("No item selected. Please select a row.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Ifcon()
            cmd.Connection = conn
            ' Check if po_no exists in po_listing table
            cmd.CommandText = "SELECT COUNT(*) FROM po_listing WHERE po_no = @po"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@po", poNum)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                ' Display confirmation dialog before deletion
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the data entry and all associated records?", "Delete Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    ' Delete from po_items_container table
                    cmd.CommandText = "DELETE FROM po_items_container WHERE purchase_order_no = @pon"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@pon", poNum)
                    cmd.ExecuteNonQuery()

                    ' Delete from po_listing table
                    cmd.CommandText = "DELETE FROM po_listing WHERE po_no = @po"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@po", poNum)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data entry and associated records deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Data entry not found!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            clearAll()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class