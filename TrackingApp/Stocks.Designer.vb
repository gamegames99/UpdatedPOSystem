<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stocks
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
        GroupBox1 = New GroupBox()
        txtboxDescription = New TextBox()
        btnView = New Button()
        btnRefresh = New Button()
        btnSearch = New Button()
        txtboxSearch = New TextBox()
        btnSave = New Button()
        txtboxQuantity = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtboxPersonnel = New TextBox()
        DataGridView1 = New DataGridView()
        GroupBox2 = New GroupBox()
        DataGridView2 = New DataGridView()
        btnSearch2 = New Button()
        txtboxSearch2 = New TextBox()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(txtboxDescription)
        GroupBox1.Controls.Add(btnView)
        GroupBox1.Controls.Add(btnRefresh)
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(txtboxSearch)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(txtboxQuantity)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtboxPersonnel)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(611, 497)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Inbound Stocks"
        ' 
        ' txtboxDescription
        ' 
        txtboxDescription.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtboxDescription.Location = New Point(16, 408)
        txtboxDescription.Name = "txtboxDescription"
        txtboxDescription.Size = New Size(209, 23)
        txtboxDescription.TabIndex = 8
        ' 
        ' btnView
        ' 
        btnView.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnView.BackColor = Color.DeepSkyBlue
        btnView.FlatStyle = FlatStyle.Popup
        btnView.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnView.Location = New Point(241, 403)
        btnView.Name = "btnView"
        btnView.Size = New Size(77, 28)
        btnView.TabIndex = 7
        btnView.Text = "View Info"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.DeepSkyBlue
        btnRefresh.FlatStyle = FlatStyle.Popup
        btnRefresh.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(6, 22)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(99, 28)
        btnRefresh.TabIndex = 7
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSearch.BackColor = Color.DeepSkyBlue
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(241, 453)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(77, 28)
        btnSearch.TabIndex = 7
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtboxSearch
        ' 
        txtboxSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtboxSearch.Location = New Point(16, 458)
        txtboxSearch.Name = "txtboxSearch"
        txtboxSearch.Size = New Size(209, 23)
        txtboxSearch.TabIndex = 6
        txtboxSearch.Text = "enter keywords..."
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSave.BackColor = Color.DeepSkyBlue
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(511, 453)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(84, 28)
        btnSave.TabIndex = 5
        btnSave.Text = "Save Entry"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtboxQuantity
        ' 
        txtboxQuantity.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtboxQuantity.Location = New Point(357, 458)
        txtboxQuantity.Name = "txtboxQuantity"
        txtboxQuantity.Size = New Size(138, 23)
        txtboxQuantity.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(357, 440)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 3
        Label2.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(16, 440)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 15)
        Label4.TabIndex = 2
        Label4.Text = "General Search Bar"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(16, 390)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 15)
        Label3.TabIndex = 2
        Label3.Text = "Item Description"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(357, 390)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 2
        Label1.Text = "Receiver Name"
        ' 
        ' txtboxPersonnel
        ' 
        txtboxPersonnel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtboxPersonnel.Location = New Point(357, 408)
        txtboxPersonnel.Name = "txtboxPersonnel"
        txtboxPersonnel.Size = New Size(248, 23)
        txtboxPersonnel.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 61)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(599, 326)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(DataGridView2)
        GroupBox2.Controls.Add(btnSearch2)
        GroupBox2.Controls.Add(txtboxSearch2)
        GroupBox2.Location = New Point(629, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(433, 497)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Outbound Stocks"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(6, 61)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(421, 420)
        DataGridView2.TabIndex = 0
        ' 
        ' btnSearch2
        ' 
        btnSearch2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch2.BackColor = Color.DeepSkyBlue
        btnSearch2.FlatStyle = FlatStyle.Popup
        btnSearch2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch2.Location = New Point(315, 22)
        btnSearch2.Name = "btnSearch2"
        btnSearch2.Size = New Size(99, 28)
        btnSearch2.TabIndex = 7
        btnSearch2.Text = "Search"
        btnSearch2.UseVisualStyleBackColor = False
        ' 
        ' txtboxSearch2
        ' 
        txtboxSearch2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtboxSearch2.Location = New Point(108, 27)
        txtboxSearch2.Name = "txtboxSearch2"
        txtboxSearch2.Size = New Size(201, 23)
        txtboxSearch2.TabIndex = 6
        ' 
        ' Stocks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1074, 521)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Stocks"
        Text = "Stocks"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxPersonnel As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtboxQuantity As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents btnSearch2 As Button
    Friend WithEvents txtboxSearch2 As TextBox
    Friend WithEvents txtboxDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnView As Button
End Class
