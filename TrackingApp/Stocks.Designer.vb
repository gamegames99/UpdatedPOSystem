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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        CheckBox1 = New CheckBox()
        txtIdContainer = New TextBox()
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
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(txtIdContainer)
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
        GroupBox1.Size = New Size(636, 497)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Inbound Stocks"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(444, 34)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(176, 21)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Show/Hide Item Holders"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' txtIdContainer
        ' 
        txtIdContainer.Location = New Point(125, 27)
        txtIdContainer.Name = "txtIdContainer"
        txtIdContainer.ReadOnly = True
        txtIdContainer.Size = New Size(55, 23)
        txtIdContainer.TabIndex = 9
        txtIdContainer.Visible = False
        ' 
        ' txtboxDescription
        ' 
        txtboxDescription.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtboxDescription.Location = New Point(16, 408)
        txtboxDescription.Name = "txtboxDescription"
        txtboxDescription.Size = New Size(268, 23)
        txtboxDescription.TabIndex = 8
        ' 
        ' btnView
        ' 
        btnView.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnView.BackColor = Color.DeepSkyBlue
        btnView.FlatStyle = FlatStyle.Popup
        btnView.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnView.Location = New Point(290, 403)
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
        btnSearch.Location = New Point(290, 453)
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
        txtboxSearch.Size = New Size(268, 23)
        txtboxSearch.TabIndex = 6
        txtboxSearch.Text = "search here..."
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom
        btnSave.BackColor = Color.DeepSkyBlue
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(536, 453)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(84, 28)
        btnSave.TabIndex = 5
        btnSave.Text = "Save Entry"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtboxQuantity
        ' 
        txtboxQuantity.Anchor = AnchorStyles.Bottom
        txtboxQuantity.Location = New Point(392, 458)
        txtboxQuantity.Name = "txtboxQuantity"
        txtboxQuantity.Size = New Size(138, 23)
        txtboxQuantity.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Location = New Point(392, 440)
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
        Label4.Size = New Size(65, 15)
        Label4.TabIndex = 2
        Label4.Text = "Search Box"
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
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Location = New Point(392, 390)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 15)
        Label1.TabIndex = 2
        Label1.Text = "Item Receiver Name"
        ' 
        ' txtboxPersonnel
        ' 
        txtboxPersonnel.Anchor = AnchorStyles.Bottom
        txtboxPersonnel.Location = New Point(392, 408)
        txtboxPersonnel.Name = "txtboxPersonnel"
        txtboxPersonnel.Size = New Size(228, 23)
        txtboxPersonnel.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 61)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(624, 326)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(DataGridView2)
        GroupBox2.Controls.Add(btnSearch2)
        GroupBox2.Controls.Add(txtboxSearch2)
        GroupBox2.Location = New Point(654, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(575, 497)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Item Holders"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(6, 61)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.Size = New Size(563, 420)
        DataGridView2.TabIndex = 0
        ' 
        ' btnSearch2
        ' 
        btnSearch2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch2.BackColor = Color.DeepSkyBlue
        btnSearch2.FlatStyle = FlatStyle.Popup
        btnSearch2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch2.Location = New Point(457, 22)
        btnSearch2.Name = "btnSearch2"
        btnSearch2.Size = New Size(99, 28)
        btnSearch2.TabIndex = 7
        btnSearch2.Text = "Search"
        btnSearch2.UseVisualStyleBackColor = False
        ' 
        ' txtboxSearch2
        ' 
        txtboxSearch2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtboxSearch2.Location = New Point(250, 27)
        txtboxSearch2.Name = "txtboxSearch2"
        txtboxSearch2.Size = New Size(201, 23)
        txtboxSearch2.TabIndex = 6
        ' 
        ' Stocks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1241, 521)
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
    Friend WithEvents txtIdContainer As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
