<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock_information
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
        Panel1 = New Panel()
        labelSerial = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtDesc = New Label()
        txtSupplier = New Label()
        txtponumber = New Label()
        txtprs = New Label()
        Label5 = New Label()
        txtpodate = New Label()
        Label6 = New Label()
        txtprsdate = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Controls.Add(labelSerial)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(880, 54)
        Panel1.TabIndex = 0
        ' 
        ' labelSerial
        ' 
        labelSerial.AutoSize = True
        labelSerial.BackColor = Color.DeepSkyBlue
        labelSerial.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelSerial.Location = New Point(12, 9)
        labelSerial.Name = "labelSerial"
        labelSerial.Size = New Size(128, 30)
        labelSerial.TabIndex = 0
        labelSerial.Text = "1234567890"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(12, 285)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 25)
        Label1.TabIndex = 1
        Label1.Text = "Item Description :"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(12, 384)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 1
        Label2.Text = "Supplier :"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(12, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(169, 25)
        Label3.TabIndex = 1
        Label3.Text = "Purchase Order # :"
        Label3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' txtDesc
        ' 
        txtDesc.AutoSize = True
        txtDesc.BackColor = Color.IndianRed
        txtDesc.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        txtDesc.Location = New Point(12, 322)
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(102, 25)
        txtDesc.TabIndex = 1
        txtDesc.Text = "blank data"
        ' 
        ' txtSupplier
        ' 
        txtSupplier.AutoSize = True
        txtSupplier.BackColor = Color.IndianRed
        txtSupplier.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        txtSupplier.Location = New Point(12, 423)
        txtSupplier.Name = "txtSupplier"
        txtSupplier.Size = New Size(102, 25)
        txtSupplier.TabIndex = 1
        txtSupplier.Text = "blank data"
        txtSupplier.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtponumber
        ' 
        txtponumber.AutoSize = True
        txtponumber.BackColor = Color.DeepSkyBlue
        txtponumber.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        txtponumber.Location = New Point(12, 111)
        txtponumber.Name = "txtponumber"
        txtponumber.Size = New Size(102, 25)
        txtponumber.TabIndex = 1
        txtponumber.Text = "blank data"
        txtponumber.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' txtprs
        ' 
        txtprs.AutoSize = True
        txtprs.BackColor = Color.DeepSkyBlue
        txtprs.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        txtprs.Location = New Point(12, 221)
        txtprs.Name = "txtprs"
        txtprs.Size = New Size(102, 25)
        txtprs.TabIndex = 1
        txtprs.Text = "blank data"
        txtprs.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(12, 179)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 25)
        Label5.TabIndex = 1
        Label5.Text = "PRS # :"
        Label5.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' txtpodate
        ' 
        txtpodate.AutoSize = True
        txtpodate.BackColor = Color.DeepSkyBlue
        txtpodate.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        txtpodate.Location = New Point(270, 111)
        txtpodate.Name = "txtpodate"
        txtpodate.Size = New Size(102, 25)
        txtpodate.TabIndex = 1
        txtpodate.Text = "blank data"
        txtpodate.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label6.Location = New Point(270, 69)
        Label6.Name = "Label6"
        Label6.Size = New Size(204, 25)
        Label6.TabIndex = 1
        Label6.Text = "Purchase Order Date  :"
        Label6.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' txtprsdate
        ' 
        txtprsdate.AutoSize = True
        txtprsdate.BackColor = Color.DeepSkyBlue
        txtprsdate.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        txtprsdate.Location = New Point(270, 221)
        txtprsdate.Name = "txtprsdate"
        txtprsdate.Size = New Size(102, 25)
        txtprsdate.TabIndex = 1
        txtprsdate.Text = "blank data"
        txtprsdate.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label8.Location = New Point(270, 179)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 25)
        Label8.TabIndex = 1
        Label8.Text = "PRS Date :"
        Label8.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' stock_information
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 485)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(txtprsdate)
        Controls.Add(Label3)
        Controls.Add(txtprs)
        Controls.Add(txtpodate)
        Controls.Add(Label2)
        Controls.Add(txtponumber)
        Controls.Add(txtSupplier)
        Controls.Add(txtDesc)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "stock_information"
        Text = "Item Information"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelSerial As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDesc As Label
    Friend WithEvents txtSupplier As Label
    Friend WithEvents txtponumber As Label
    Friend WithEvents txtprs As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpodate As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprsdate As Label
    Friend WithEvents Label8 As Label
End Class
