Imports MySql.Data.MySqlClient

Public Class Disposal

    Private Sub FirstTable()
        Try
            Ifcon()
            Dim sql As String = "SELECT * FROM po_items_container ORDER by id_container DESC"
            Dim command As New MySqlCommand(sql, conn)
            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable
            DataGridView1.Columns("id_container").Visible = False
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Disposal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstTable()
    End Sub
    Private Sub btnDispose_Click(sender As Object, e As EventArgs) Handles btnDispose.Click
        Try
            Ifcon()
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim idContain As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id_container").Value)
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to dispose this item?", "Confirmation",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim reason As String = InputBox("Please provide a reason for disposal:", "Reason")
                    If Not String.IsNullOrWhiteSpace(reason) Then
                        ' Insert into history table
                        cmd.Connection = conn
                        cmd.CommandText = "INSERT INTO disposal (item_desc, item_serial,po_number,reason,date_of_disposal) VALUES (@dsc, @srl, @poNo,@reason,@dod)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.Add("@dod", MySqlDbType.Date).Value = DateTime.Today
                        cmd.Parameters.Add("@poNo", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("purchase_order_no").Value.ToString()
                        cmd.Parameters.Add("@srl", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("item_serial").Value.ToString()
                        cmd.Parameters.Add("@dsc", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("item_desc").Value.ToString()
                        cmd.Parameters.Add("@reason", MySqlDbType.String).Value = reason
                        cmd.ExecuteNonQuery()

                        cmd.Connection = conn
                        cmd.CommandText = "DELETE FROM po_items_container WHERE id_container = @id"
                        cmd.Parameters.Clear()
                        cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idContain
                        cmd.ExecuteNonQuery()
                        MsgBox("Item Disposed!")
                    Else
                        MsgBox("Reason for disposal is required.")
                    End If
                End If
            Else
                MsgBox("No row selected.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
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

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        DisposedList.ShowDialog()
    End Sub
End Class