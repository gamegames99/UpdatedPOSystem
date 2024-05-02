Imports MySql.Data.MySqlClient

Public Class editcontainer
    Private ReadOnly selectedPoNo As String
    Private ReadOnly serialNumbers As List(Of String)
    Private ReadOnly idf As List(Of String)
    Private itr As String
    Public Sub New(poNo As String, serials As List(Of String), identifiers As List(Of String))
        InitializeComponent()
        selectedPoNo = poNo
        serialNumbers = serials
        idf = identifiers
    End Sub
    Private Sub editcontainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Label1.Text = "Purchase Order #" & selectedPoNo
        cbxSerial.DataSource = serialNumbers
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Ifcon()
            cmd.Connection = conn
            ' Update the item_desc and item_price based on the selected serial number
            cmd.CommandText = "UPDATE po_items_container SET item_serial=@serial, item_desc = @desc, item_price = @price WHERE id_container = @id"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", itr)
            cmd.Parameters.AddWithValue("@desc", txtDesc.Text)
            cmd.Parameters.AddWithValue("@price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@serial", cbxSerial.Text)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Data updated successfully for Serial No#" + cbxSerial.Text, "" + Label1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No rows updated for Serial No#" + cbxSerial.Text, "" + Label1.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As MySqlException
            MsgBox("Error encountered: " + ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cbxSerial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSerial.SelectedIndexChanged
        Try
            Ifcon()
            cmd.Connection = conn
            ' Retrieve the item_desc and item_price based on the selected item_serial
            cmd.CommandText = "SELECT id_container, item_desc, item_price FROM po_items_container WHERE item_serial= @serial"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@serial", cbxSerial.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                itr = reader("id_container").ToString()
                txtDesc.Text = reader("item_desc").ToString()
                txtPrice.Text = reader("item_price").ToString()
            Else
                itr = String.Empty
                txtDesc.Text = String.Empty
                txtPrice.Text = String.Empty
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error encountered: " + ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub editcontainer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub
End Class