<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipments
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
        CheckBox1 = New CheckBox()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnDelete = New Button()
        btnView = New Button()
        DataGridView1 = New DataGridView()
        btnEdit = New Button()
        GroupBox2 = New GroupBox()
        cbxPONum = New ComboBox()
        Label8 = New Label()
        txtboxprs = New TextBox()
        Label6 = New Label()
        btnRefresh = New Button()
        txtboxSupplier = New TextBox()
        Label5 = New Label()
        dateReceived = New DateTimePicker()
        purchaseDate = New DateTimePicker()
        lbDR = New Label()
        Label1 = New Label()
        btnClear = New Button()
        btnAdd = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(txtSearch)
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(btnDelete)
        GroupBox1.Controls.Add(btnView)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(btnEdit)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1050, 345)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Information Tab"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(6, 309)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(133, 21)
        CheckBox1.TabIndex = 11
        CheckBox1.Text = "Show/Hide Editor"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtSearch.Location = New Point(715, 306)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(234, 23)
        txtSearch.TabIndex = 10
        txtSearch.Text = "Search here...."
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSearch.BackColor = Color.DeepSkyBlue
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(955, 300)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(87, 30)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnDelete.BackColor = Color.DeepSkyBlue
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(467, 303)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(138, 30)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete Selected"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnView
        ' 
        btnView.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnView.BackColor = Color.DeepSkyBlue
        btnView.FlatStyle = FlatStyle.Popup
        btnView.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnView.Location = New Point(156, 303)
        btnView.Name = "btnView"
        btnView.Size = New Size(123, 30)
        btnView.TabIndex = 3
        btnView.Text = "Contents List"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(1038, 272)
        DataGridView1.TabIndex = 2
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnEdit.BackColor = Color.DeepSkyBlue
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(306, 303)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(137, 30)
        btnEdit.TabIndex = 7
        btnEdit.Text = "Update Contents"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(cbxPONum)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtboxprs)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(btnRefresh)
        GroupBox2.Controls.Add(txtboxSupplier)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(dateReceived)
        GroupBox2.Controls.Add(purchaseDate)
        GroupBox2.Controls.Add(lbDR)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(btnClear)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Location = New Point(12, 363)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1050, 146)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Manage Item"
        ' 
        ' cbxPONum
        ' 
        cbxPONum.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        cbxPONum.FormattingEnabled = True
        cbxPONum.Location = New Point(6, 54)
        cbxPONum.Name = "cbxPONum"
        cbxPONum.Size = New Size(246, 23)
        cbxPONum.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Location = New Point(271, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 15)
        Label8.TabIndex = 26
        Label8.Text = "Purchase Order Date"
        ' 
        ' txtboxprs
        ' 
        txtboxprs.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtboxprs.Location = New Point(542, 54)
        txtboxprs.Name = "txtboxprs"
        txtboxprs.Size = New Size(230, 23)
        txtboxprs.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Location = New Point(542, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 22
        Label6.Text = "PRS No."
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRefresh.BackColor = Color.DeepSkyBlue
        btnRefresh.FlatStyle = FlatStyle.Popup
        btnRefresh.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(931, 48)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(102, 30)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh Cell"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtboxSupplier
        ' 
        txtboxSupplier.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtboxSupplier.Location = New Point(6, 98)
        txtboxSupplier.Name = "txtboxSupplier"
        txtboxSupplier.Size = New Size(246, 23)
        txtboxSupplier.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(6, 80)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 15)
        Label5.TabIndex = 20
        Label5.Text = "Name of Supplier"
        ' 
        ' dateReceived
        ' 
        dateReceived.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        dateReceived.Location = New Point(271, 98)
        dateReceived.Name = "dateReceived"
        dateReceived.Size = New Size(246, 23)
        dateReceived.TabIndex = 13
        ' 
        ' purchaseDate
        ' 
        purchaseDate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        purchaseDate.Location = New Point(271, 54)
        purchaseDate.Name = "purchaseDate"
        purchaseDate.Size = New Size(246, 23)
        purchaseDate.TabIndex = 12
        ' 
        ' lbDR
        ' 
        lbDR.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lbDR.AutoSize = True
        lbDR.Location = New Point(271, 80)
        lbDR.Name = "lbDR"
        lbDR.Size = New Size(54, 15)
        lbDR.TabIndex = 11
        lbDR.Text = "PRS Date"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(6, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 9
        Label1.Text = "Purchase Order No."
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClear.BackColor = Color.DeepSkyBlue
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(808, 48)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(102, 30)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear Fields"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAdd.BackColor = Color.DeepSkyBlue
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(542, 92)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(230, 30)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Save Entry / Add Entry"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Equipments
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1074, 521)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Equipments"
        Text = "Equipments"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnView As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dateReceived As DateTimePicker
    Friend WithEvents purchaseDate As DateTimePicker
    Friend WithEvents lbDR As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxprs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtboxSupplier As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents cbxPONum As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
