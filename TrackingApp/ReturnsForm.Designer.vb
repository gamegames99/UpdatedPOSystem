<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnsForm
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
        DataGridView1 = New DataGridView()
        btnReturns = New Button()
        btnViewItems = New Button()
        btnStock = New Button()
        Panel1 = New Panel()
        labelTitle = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 78)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(776, 275)
        DataGridView1.TabIndex = 0
        ' 
        ' btnReturns
        ' 
        btnReturns.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnReturns.BackColor = Color.DeepSkyBlue
        btnReturns.FlatStyle = FlatStyle.Popup
        btnReturns.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturns.Location = New Point(562, 378)
        btnReturns.Name = "btnReturns"
        btnReturns.Size = New Size(190, 39)
        btnReturns.TabIndex = 1
        btnReturns.Text = "Return Selected Item"
        btnReturns.UseVisualStyleBackColor = False
        ' 
        ' btnViewItems
        ' 
        btnViewItems.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnViewItems.BackColor = Color.DeepSkyBlue
        btnViewItems.FlatStyle = FlatStyle.Popup
        btnViewItems.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewItems.Location = New Point(47, 378)
        btnViewItems.Name = "btnViewItems"
        btnViewItems.Size = New Size(184, 39)
        btnViewItems.TabIndex = 1
        btnViewItems.Text = "View Returned Items"
        btnViewItems.UseVisualStyleBackColor = False
        ' 
        ' btnStock
        ' 
        btnStock.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnStock.BackColor = Color.DeepSkyBlue
        btnStock.FlatStyle = FlatStyle.Popup
        btnStock.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStock.Location = New Point(237, 378)
        btnStock.Name = "btnStock"
        btnStock.Size = New Size(184, 39)
        btnStock.TabIndex = 1
        btnStock.Text = "Return An Item"
        btnStock.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Controls.Add(labelTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 51)
        Panel1.TabIndex = 2
        ' 
        ' labelTitle
        ' 
        labelTitle.AutoSize = True
        labelTitle.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTitle.ForeColor = Color.White
        labelTitle.Location = New Point(12, 9)
        labelTitle.Name = "labelTitle"
        labelTitle.Size = New Size(71, 30)
        labelTitle.TabIndex = 0
        labelTitle.Text = "Label1"
        ' 
        ' ReturnsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(btnStock)
        Controls.Add(btnViewItems)
        Controls.Add(btnReturns)
        Controls.Add(DataGridView1)
        Name = "ReturnsForm"
        Text = "ReturnsForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReturns As Button
    Friend WithEvents btnViewItems As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelTitle As Label
End Class
