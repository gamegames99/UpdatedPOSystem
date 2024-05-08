Imports System.Collections.Specialized
Imports MySql.Data.MySqlClient

Public Class ReturnsForm
    Private Sub newTable()
        Try
            Ifcon()
            Dim query As String = "SELECT * FROM stock"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            ModifyStocksColumnNames(dataTable)
            DataGridView1.DataSource = dataTable
            DataGridView1.Columns("stock_id").Visible = False
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            labelTitle.Text = "List of all Item Holders"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub ReturnsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newTable()
    End Sub

    Private Sub btnReturns_Click(sender As Object, e As EventArgs) Handles btnReturns.Click
        Try
            Ifcon()
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim idstocks As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("stock_id").Value)
                Dim result As DialogResult = MessageBox.Show("Selected item will be retrieved. Do you wish to continue?", "Confirmation Message : Returns",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    Dim reason As String = InputBox("Please provide a reason for returning item:", "Return reason is required to continue")
                    If Not String.IsNullOrWhiteSpace(reason) Then
                        ' Insert into history table
                        cmd.Connection = conn
                        cmd.CommandText = "INSERT INTO returns (returner_name, returned_item_name,returned_item_serial,returned_reason,returned_date) 
VALUES (@rename, @name, @srl,@reason,@rdate)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.Add("@rdate", MySqlDbType.Date).Value = DateTime.Today
                        cmd.Parameters.Add("@rename", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("name_receiver").Value.ToString()
                        cmd.Parameters.Add("@name", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("stockDescription").Value.ToString()
                        cmd.Parameters.Add("@srl", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("stock_serial").Value.ToString()
                        cmd.Parameters.Add("@reason", MySqlDbType.String).Value = reason
                        cmd.ExecuteNonQuery()

                        cmd.Connection = conn
                        cmd.CommandText = "DELETE FROM stock WHERE stock_id = @id"
                        cmd.Parameters.Clear()
                        cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idstocks
                        cmd.ExecuteNonQuery()
                        MsgBox("Item Returned!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Reason for returns is required.", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                MsgBox("No row selected. Please select a row", MsgBoxStyle.Exclamation)
            End If
            newTable()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            If DataGridView1.SelectedRows.Count > 0 AndAlso Not DataGridView1.SelectedRows(0).IsNewRow Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim idValue As Object = selectedRow.Cells("stock_id").Value
                Dim nameValue As Object = selectedRow.Cells("Name of Receiver").Value
                Dim descValue As Object = selectedRow.Cells("Item Description").Value
                Dim srlValue As Object = selectedRow.Cells("Serial Number").Value
                Dim dateValue As Object = selectedRow.Cells("Date Received").Value
                Dim qtyValue As Object = selectedRow.Cells("Quantity").Value
            End If
        Catch ex As Exception
            MsgBox("You cannot select from this table in View Mode", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnViewItems_Click(sender As Object, e As EventArgs) Handles btnViewItems.Click
        Try
            Ifcon()
            Dim query As String = "SELECT * FROM returns"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            ModifyReturnsColumnNames(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns("id_returns").Visible = False
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            labelTitle.Text = "List of all Retrieved Items"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        newTable()
    End Sub
End Class