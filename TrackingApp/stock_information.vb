Public Class stock_information
    Private _itemStatus As String

    Public Property ItemStatus As String
        Get
            Return _itemStatus
        End Get
        Set(value As String)
            _itemStatus = value
        End Set
    End Property

    Private Sub stock_information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        txtStatus.Text = "Status: " & _itemStatus ' Set the itemStatus value to txtStatus
        ' Set the color of txtStatus based on the itemStatus value
        If _itemStatus = "Available" Then
            txtStatus.BackColor = Color.LightGreen
        ElseIf _itemStatus = "Unavailable" Then
            txtStatus.BackColor = Color.Magenta
        ElseIf _itemStatus = "Disposed" Then
            txtStatus.BackColor = Color.Red
        End If
    End Sub

    Public Sub New(selectDesc As String, serialStorage As String, supplier As String, poNumber As String, prs As String, pDate As Date, prDate As Date)
        InitializeComponent()
        txtDesc.Text = selectDesc
        labelSerial.Text = "Serial Number: " & serialStorage
        txtSupplier.Text = supplier
        txtponumber.Text = poNumber
        txtprs.Text = prs
        txtpodate.Text = pDate.Date
        txtprsdate.Text = prDate.Date
    End Sub

    Private Sub stock_information_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        txtDesc.MaximumSize = New Size(Me.ClientSize.Width - Label1.Left - 10, 0)
    End Sub
End Class