Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class listing
    Private dataTable As DataTable
    Private identifier As String
    Public Sub New(dataTable As DataTable, poNo As String)
        InitializeComponent()
        Me.dataTable = dataTable
        Label1.Text = "Purchase Order #" & poNo
    End Sub
    Private Sub loadCell()
        DataGridView1.DataSource = dataTable
        DataGridView1.Columns("id_container").Visible = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub Listing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        hideGB()
        loadCell()
    End Sub
    Private Sub hideGB()
        GroupBox1.Visible = False
        DataGridView1.Height += GroupBox1.Height
    End Sub
    Private Sub listing_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub

    Public Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Ifcon()
            cmd.Connection = conn
            ' Update the item_desc and item_price based on the selected serial number
            cmd.CommandText = "UPDATE po_items_container SET item_desc = @desc, item_price = @price, item_quantity =@qty, item_serial=@srl WHERE id_container = @id"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", identifier)
            cmd.Parameters.AddWithValue("@qty", txtQy.Text)
            cmd.Parameters.AddWithValue("@desc", txtDsc.Text)
            cmd.Parameters.AddWithValue("@price", txtPrc.Text)
            cmd.Parameters.AddWithValue("@srl", txtSrn.Text)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Data updated successfully for Serial No#" + txtSrn.Text, "" + Label1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
            Else
                MessageBox.Show("No rows updated for Serial No#" + txtSrn.Text, "" + Label1.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox("Error encountered: " + ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                identifier = If(selectedRow.Cells("id_container").Value IsNot Nothing, selectedRow.Cells("id_container").Value.ToString(), "")
                txtDsc.Text = If(selectedRow.Cells("Item Description").Value IsNot Nothing, selectedRow.Cells("Item Description").Value.ToString(), "")
                txtPrc.Text = If(selectedRow.Cells("Unit Price").Value IsNot Nothing, selectedRow.Cells("Unit Price").Value.ToString(), "")
                txtQy.Text = If(selectedRow.Cells("Quantity").Value IsNot Nothing, selectedRow.Cells("Quantity").Value.ToString(), "")
                txtSrn.Text = If(selectedRow.Cells("Serial Number").Value IsNot Nothing, selectedRow.Cells("Serial Number").Value.ToString(), "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        GroupBox1.Visible = CheckBox1.Checked
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Ifcon()
            cmd.Connection = conn
            ' Check if po_no exists in po_listing table
            cmd.CommandText = "SELECT COUNT(*) FROM po_items_container WHERE item_serial = @srl"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@srl", txtSrn.Text)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                ' Display confirmation dialog before deletion
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the data entry and all associated records?", "Delete Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    ' Delete from po_items_container table
                    cmd.CommandText = "DELETE FROM po_items_container WHERE id_container = @id"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@id", identifier)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data entry and associated records deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Data entry not found!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class