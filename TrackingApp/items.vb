Imports MySql.Data.MySqlClient

Public Class items
    Private Sub items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        txtPoNum.Text = poNum.ToString()
        txtQty.Text = "1"
        txtSerial.Focus()
    End Sub
    Private Sub clr()
        txtDesc.Clear()
        txtSerial.Clear()
        txtPrice.Clear()
    End Sub
    Private Sub items_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtPoNum.Text) OrElse
                String.IsNullOrWhiteSpace(txtPrice.Text) OrElse
           String.IsNullOrWhiteSpace(txtDesc.Text) Then
            MessageBox.Show("Required must not be empty. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the event handler
        End If
        Try
            Ifcon()
            cmd.Connection = conn
            ' Check if po_no already exists in po_listing table
            cmd.CommandText = "SELECT COUNT(*) FROM po_listing WHERE po_no = @po"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@po", txtPoNum.Text)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                ' Insert into po_items_container table only
                cmd.CommandText = "INSERT INTO po_items_container (purchase_order_no, item_desc, item_serial, item_quantity, item_price) VALUES (@pon, @desc, @serial, @qty, @price)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@pon", MySqlDbType.VarChar).Value = txtPoNum.Text
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txtDesc.Text
                cmd.Parameters.Add("@serial", MySqlDbType.VarChar).Value = txtSerial.Text
                cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = txtQty.Text
                cmd.Parameters.Add("@price", MySqlDbType.VarChar).Value = txtPrice.Text
                cmd.ExecuteNonQuery()

                MessageBox.Show("Saved to : Purchase Order #" + txtPoNum.Text + "", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Insert into po_listing and po_items_container tables
                cmd.CommandText = "INSERT INTO po_listing (po_no, po_date, prs_date, po_supplier, prs_no) VALUES (@po, @poDate, @prsDate, @supplier, @prsNo)"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@po", txtPoNum.Text)
                cmd.Parameters.AddWithValue("@poDate", PODate)
                cmd.Parameters.AddWithValue("@prsDate", DReceived)
                cmd.Parameters.AddWithValue("@supplier", supplier)
                cmd.Parameters.AddWithValue("@prsNo", prsNum)
                cmd.ExecuteNonQuery()

                cmd.CommandText = "INSERT INTO po_items_container (purchase_order_no, item_desc, item_serial, item_quantity, item_price) VALUES (@pon, @desc, @serial, @qty, @price)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@pon", MySqlDbType.VarChar).Value = txtPoNum.Text
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txtDesc.Text
                cmd.Parameters.Add("@serial", MySqlDbType.VarChar).Value = txtSerial.Text
                cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = txtQty.Text
                cmd.Parameters.Add("@price", MySqlDbType.VarChar).Value = txtPrice.Text
                cmd.ExecuteNonQuery()

                MessageBox.Show("Saved successfully! Serial#" + txtSerial.Text + "", "Purchase Order#" + txtPoNum.Text + "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            clr()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            clr()
        Finally
            conn.Close()
        End Try
    End Sub
End Class