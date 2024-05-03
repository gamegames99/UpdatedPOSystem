<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disposal
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
        btnDispose = New Button()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnDone = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 305)
        DataGridView1.TabIndex = 0
        ' 
        ' btnDispose
        ' 
        btnDispose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnDispose.BackColor = Color.DeepSkyBlue
        btnDispose.FlatStyle = FlatStyle.Popup
        btnDispose.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDispose.Location = New Point(598, 331)
        btnDispose.Name = "btnDispose"
        btnDispose.Size = New Size(181, 34)
        btnDispose.TabIndex = 1
        btnDispose.Text = "Dispose Selected Item"
        btnDispose.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtSearch.Location = New Point(21, 339)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(222, 23)
        txtSearch.TabIndex = 2
        txtSearch.Text = "search here..."
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSearch.BackColor = Color.DeepSkyBlue
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(249, 331)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(124, 34)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search Item"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnDone
        ' 
        btnDone.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnDone.BackColor = Color.DeepSkyBlue
        btnDone.FlatStyle = FlatStyle.Popup
        btnDone.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDone.Location = New Point(379, 331)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(181, 34)
        btnDone.TabIndex = 1
        btnDone.Text = "View Disposed Items"
        btnDone.UseVisualStyleBackColor = False
        ' 
        ' Disposal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 425)
        Controls.Add(txtSearch)
        Controls.Add(btnDone)
        Controls.Add(btnSearch)
        Controls.Add(btnDispose)
        Controls.Add(DataGridView1)
        Name = "Disposal"
        Text = "Disposal"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDispose As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDone As Button
End Class
