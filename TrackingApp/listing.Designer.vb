<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listing
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
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        btnUpdate = New Button()
        GroupBox1 = New GroupBox()
        txtQy = New TextBox()
        Label5 = New Label()
        txtPrc = New TextBox()
        Label4 = New Label()
        txtSrn = New TextBox()
        Label3 = New Label()
        txtDsc = New TextBox()
        Label2 = New Label()
        btnDelete = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(883, 53)
        Panel1.TabIndex = 2
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.DeepSkyBlue
        CheckBox1.Location = New Point(738, 20)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(133, 21)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Show/Hide Editor"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DeepSkyBlue
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 32)
        Label1.TabIndex = 0
        Label1.Text = "1234567890"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 68)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(859, 307)
        DataGridView1.TabIndex = 0
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnUpdate.BackColor = Color.DeepSkyBlue
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(716, 49)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(137, 30)
        btnUpdate.TabIndex = 8
        btnUpdate.Text = "Update Selected"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnDelete)
        GroupBox1.Controls.Add(txtQy)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtPrc)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtSrn)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtDsc)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnUpdate)
        GroupBox1.Location = New Point(12, 381)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(859, 164)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Manage Items"
        ' 
        ' txtQy
        ' 
        txtQy.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtQy.Location = New Point(314, 115)
        txtQy.Name = "txtQy"
        txtQy.Size = New Size(158, 23)
        txtQy.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(314, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 9
        Label5.Text = "Quantity"
        ' 
        ' txtPrc
        ' 
        txtPrc.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtPrc.Location = New Point(314, 55)
        txtPrc.Name = "txtPrc"
        txtPrc.Size = New Size(158, 23)
        txtPrc.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(314, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 9
        Label4.Text = "Unit Price"
        ' 
        ' txtSrn
        ' 
        txtSrn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtSrn.Location = New Point(478, 55)
        txtSrn.Name = "txtSrn"
        txtSrn.Size = New Size(180, 23)
        txtSrn.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(478, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 9
        Label3.Text = "Serial No."
        ' 
        ' txtDsc
        ' 
        txtDsc.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtDsc.Location = New Point(6, 55)
        txtDsc.Multiline = True
        txtDsc.Name = "txtDsc"
        txtDsc.Size = New Size(296, 84)
        txtDsc.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(6, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 15)
        Label2.TabIndex = 9
        Label2.Text = "Item Description"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.DeepSkyBlue
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(716, 108)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(137, 30)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete Selected"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' listing
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(883, 557)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "listing"
        Text = "Contents List"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtQy As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSrn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDsc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnDelete As Button
End Class
