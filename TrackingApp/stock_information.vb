Public Class stock_information
    Private Sub stock_information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
    Public Sub New(selectDesc As String, itemSerial As String, supplier As String, poNumber As String, prs As String, pDate As Date, prDate As Date)
        InitializeComponent()
        txtDesc.Text = selectDesc
        labelSerial.Text = "Serial Number :" & itemSerial
        txtSupplier.Text = supplier
        txtponumber.Text = poNumber
        txtprs.Text = prs
        txtpodate.Text = pDate
        txtprsdate.Text = prDate
    End Sub
End Class