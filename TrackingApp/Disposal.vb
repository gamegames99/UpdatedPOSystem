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
            ModifyPoItemContainerColumnNames(dataTable)
            DataGridView1.DataSource = dataTable
            DataGridView1.Columns("id_container").Visible = False
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
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
                Dim srlNumber As String = DataGridView1.SelectedRows(0).Cells("Serial Number").Value.ToString()
                ' Check if the item exists in the stock table
                cmd.Connection = conn
                cmd.CommandText = "SELECT COUNT(*) FROM stock WHERE stock_serial = @serial"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@serial", srlNumber)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MsgBox("Selected item is currently in-use, you cannot dispose in-use items", MsgBoxStyle.Exclamation)
                    Return ' Exit the event handler
                End If
                cmd.Connection = conn
                cmd.CommandText = "SELECT COUNT(*) FROM disposal WHERE item_serial = @serial"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@serial", srlNumber)
                Dim ct As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If ct > 0 Then
                    MsgBox("Selected item has already been disposed.", MsgBoxStyle.Exclamation)
                    Return ' Exit the event handler
                End If
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to dispose this item?", "Confirmation",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    ' Create custom input dialog with ComboBox for reasons
                    Dim inputForm As New Form()
                    inputForm.Text = "Reasons for Disposal"
                    inputForm.Width = 350
                    inputForm.Height = 150
                    inputForm.FormBorderStyle = FormBorderStyle.FixedDialog
                    inputForm.StartPosition = FormStartPosition.CenterScreen
                    inputForm.MinimizeBox = False
                    inputForm.MaximizeBox = False

                    Dim promptLabel As New Label()
                    promptLabel.Text = "Please select a reason for disposal:"
                    promptLabel.SetBounds(10, 10, 300, 20)
                    inputForm.Controls.Add(promptLabel)

                    Dim comboBox As New ComboBox()
                    comboBox.SetBounds(10, 40, 300, 21)
                    comboBox.DropDownStyle = ComboBoxStyle.DropDown
                    comboBox.Items.AddRange(New String() {"Damaged Unit", "Obsolete Unit", "Lost Unit", "Others"})
                    inputForm.Controls.Add(comboBox)

                    Dim okButton As New Button()
                    okButton.Text = "OK"
                    okButton.SetBounds(235, 70, 75, 23)
                    okButton.DialogResult = DialogResult.OK
                    inputForm.Controls.Add(okButton)

                    inputForm.AcceptButton = okButton

                    If inputForm.ShowDialog() = DialogResult.OK Then
                        Dim reason As String = comboBox.SelectedItem?.ToString()
                        If String.IsNullOrWhiteSpace(reason) Then
                            MessageBox.Show("Reason for disposal is required. Item has not been disposed.", "Disposal Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            ' Insert into history table
                            cmd.Connection = conn
                            cmd.CommandText = "INSERT INTO disposal (item_desc, item_serial,po_number,reason,date_of_disposal) VALUES (@dsc, @srl, @poNo,@reason,@dod)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@dod", MySqlDbType.Date).Value = DateTime.Today
                            cmd.Parameters.Add("@poNo", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("Purchase Order #").Value.ToString()
                            cmd.Parameters.Add("@srl", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("Serial Number").Value.ToString()
                            cmd.Parameters.Add("@dsc", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("Item Description").Value.ToString()
                            cmd.Parameters.Add("@reason", MySqlDbType.String).Value = reason
                            cmd.ExecuteNonQuery()

                            'cmd.Connection = conn
                            'cmd.CommandText = "DELETE FROM po_items_container WHERE id_container = @id"
                            'cmd.Parameters.Clear()
                            'cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idContain
                            'cmd.ExecuteNonQuery()
                            MsgBox("Item Disposed!", MsgBoxStyle.Information)
                        End If
                    End If
                End If
            Else
                MsgBox("No row selected.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
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