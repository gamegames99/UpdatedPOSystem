<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class items
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtPoNum = New TextBox()
        Label1 = New Label()
        btnSave = New Button()
        txtSerial = New TextBox()
        Label2 = New Label()
        txtDesc = New TextBox()
        Label3 = New Label()
        txtQty = New TextBox()
        lblTitle = New Label()
        txtPrice = New TextBox()
        Label5 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtPoNum
        ' 
        txtPoNum.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtPoNum.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPoNum.ForeColor = Color.DeepSkyBlue
        txtPoNum.Location = New Point(12, 76)
        txtPoNum.Name = "txtPoNum"
        txtPoNum.ReadOnly = True
        txtPoNum.Size = New Size(199, 25)
        txtPoNum.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 1
        Label1.Text = "Purchase Order No."
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.DeepSkyBlue
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(281, 333)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(120, 34)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtSerial
        ' 
        txtSerial.Location = New Point(12, 128)
        txtSerial.Name = "txtSerial"
        txtSerial.Size = New Size(389, 23)
        txtSerial.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Serial No."
        ' 
        ' txtDesc
        ' 
        txtDesc.Location = New Point(12, 183)
        txtDesc.Multiline = True
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(389, 88)
        txtDesc.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 15)
        Label3.TabIndex = 1
        Label3.Text = "Item Description (Name, Brand, etc.)"
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(12, 292)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(120, 23)
        txtQty.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.DeepSkyBlue
        lblTitle.Location = New Point(12, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(213, 30)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Item Container Form"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(201, 292)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(199, 23)
        txtPrice.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(201, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 1
        Label5.Text = "Unit Price"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(442, 42)
        Panel1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 1
        Label4.Text = "Quantity"
        ' 
        ' items
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(442, 396)
        Controls.Add(Panel1)
        Controls.Add(btnSave)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(txtPrice)
        Controls.Add(txtQty)
        Controls.Add(txtDesc)
        Controls.Add(txtSerial)
        Controls.Add(txtPoNum)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "items"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPoNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
End Class
