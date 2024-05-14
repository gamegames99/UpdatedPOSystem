Imports System.Collections.Specialized
Imports MySql.Data.MySqlClient

Public Class ReturnsForm
    Private Sub newTable()
        Try
            Ifcon()
            Dim query As String = "SELECT * FROM stock ORDER by stock_id DESC"
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
                Dim inputForm As New Form()
                inputForm.Text = "Reasons for Return"
                inputForm.Width = 350
                inputForm.Height = 150
                inputForm.FormBorderStyle = FormBorderStyle.FixedDialog
                inputForm.StartPosition = FormStartPosition.CenterScreen
                inputForm.MinimizeBox = False
                inputForm.MaximizeBox = False

                Dim promptLabel As New Label()
                promptLabel.Text = "Please select a reason for returns:"
                promptLabel.SetBounds(10, 10, 300, 20)
                inputForm.Controls.Add(promptLabel)

                Dim comboBox As New ComboBox()
                comboBox.SetBounds(10, 40, 300, 21)
                comboBox.DropDownStyle = ComboBoxStyle.DropDown
                comboBox.Items.AddRange(New String() {"Broken Unit", "For replacement", "For repair", "Lost Unit", "Others"})
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
                        MessageBox.Show("Reason for returns is required. No returns were made.", "Retrieval Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        ' Insert into history table
                        cmd.Connection = conn
                        cmd.CommandText = "INSERT INTO returns (returner_name, returned_item_name,returned_item_serial,returned_reason,returned_date) 
VALUES (@rename, @name, @srl,@reason,@rdate)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.Add("@rdate", MySqlDbType.Date).Value = DateTime.Today
                        cmd.Parameters.Add("@rename", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("Name of Receiver").Value.ToString()
                        cmd.Parameters.Add("@name", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("Item Description").Value.ToString()
                        cmd.Parameters.Add("@srl", MySqlDbType.String).Value = DataGridView1.SelectedRows(0).Cells("Serial Number").Value.ToString()
                        cmd.Parameters.Add("@reason", MySqlDbType.String).Value = reason
                        cmd.ExecuteNonQuery()

                        cmd.Connection = conn
                        cmd.CommandText = "DELETE FROM stock WHERE stock_id = @id"
                        cmd.Parameters.Clear()
                        cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idstocks
                        cmd.ExecuteNonQuery()
                        MsgBox("Item Returned!", MsgBoxStyle.Information)
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
            MsgBox("Selection is DISABLED in View Mode", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnViewItems_Click(sender As Object, e As EventArgs) Handles btnViewItems.Click
        Try
            Ifcon()
            Dim query As String = "SELECT * FROM returns ORDER by id_returns DESC"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            ModifyReturnsColumnNames(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns("id_returns").Visible = False
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            labelTitle.Text = "List of all Returned Items"
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