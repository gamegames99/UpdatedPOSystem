<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Panel2 = New Panel()
        btnSettings = New Button()
        btnReturn = New Button()
        btnReport = New Button()
        btnDisposal = New Button()
        btnStock = New Button()
        btnOrders = New Button()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Timer1 = New Timer(components)
        bw_loadpo = New ComponentModel.BackgroundWorker()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.DeepSkyBlue
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1264, 41)
        Panel1.TabIndex = 0
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ProgressBar1.Location = New Point(896, 9)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(356, 23)
        ProgressBar1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(12, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(306, 37)
        Label1.TabIndex = 0
        Label1.Text = "Inventory Management"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Panel2.Controls.Add(btnSettings)
        Panel2.Controls.Add(btnReturn)
        Panel2.Controls.Add(btnReport)
        Panel2.Controls.Add(btnDisposal)
        Panel2.Controls.Add(btnStock)
        Panel2.Controls.Add(btnOrders)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 41)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 640)
        Panel2.TabIndex = 1
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnSettings.Dock = DockStyle.Top
        btnSettings.FlatAppearance.MouseDownBackColor = Color.White
        btnSettings.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnSettings.FlatStyle = FlatStyle.Popup
        btnSettings.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnSettings.ForeColor = Color.DeepSkyBlue
        btnSettings.Location = New Point(0, 339)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(200, 45)
        btnSettings.TabIndex = 8
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnReturn.Dock = DockStyle.Top
        btnReturn.FlatAppearance.MouseDownBackColor = Color.White
        btnReturn.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnReturn.FlatStyle = FlatStyle.Popup
        btnReturn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnReturn.ForeColor = Color.DeepSkyBlue
        btnReturn.Location = New Point(0, 294)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(200, 45)
        btnReturn.TabIndex = 7
        btnReturn.Text = "Returns"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnReport
        ' 
        btnReport.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnReport.Dock = DockStyle.Top
        btnReport.FlatAppearance.MouseDownBackColor = Color.White
        btnReport.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnReport.FlatStyle = FlatStyle.Popup
        btnReport.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnReport.ForeColor = Color.DeepSkyBlue
        btnReport.Location = New Point(0, 249)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(200, 45)
        btnReport.TabIndex = 6
        btnReport.Text = "Reports"
        btnReport.UseVisualStyleBackColor = False
        ' 
        ' btnDisposal
        ' 
        btnDisposal.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnDisposal.Dock = DockStyle.Top
        btnDisposal.FlatAppearance.MouseDownBackColor = Color.White
        btnDisposal.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnDisposal.FlatStyle = FlatStyle.Popup
        btnDisposal.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnDisposal.ForeColor = Color.DeepSkyBlue
        btnDisposal.Location = New Point(0, 204)
        btnDisposal.Name = "btnDisposal"
        btnDisposal.Size = New Size(200, 45)
        btnDisposal.TabIndex = 5
        btnDisposal.Text = "Disposal"
        btnDisposal.UseVisualStyleBackColor = False
        ' 
        ' btnStock
        ' 
        btnStock.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnStock.Dock = DockStyle.Top
        btnStock.FlatAppearance.MouseDownBackColor = Color.White
        btnStock.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnStock.FlatStyle = FlatStyle.Popup
        btnStock.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnStock.ForeColor = Color.DeepSkyBlue
        btnStock.Location = New Point(0, 159)
        btnStock.Name = "btnStock"
        btnStock.Size = New Size(200, 45)
        btnStock.TabIndex = 2
        btnStock.Text = "Manage Stocks"
        btnStock.UseVisualStyleBackColor = False
        ' 
        ' btnOrders
        ' 
        btnOrders.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnOrders.Dock = DockStyle.Top
        btnOrders.FlatAppearance.MouseDownBackColor = Color.White
        btnOrders.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnOrders.FlatStyle = FlatStyle.Popup
        btnOrders.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnOrders.ForeColor = Color.DeepSkyBlue
        btnOrders.Location = New Point(0, 114)
        btnOrders.Name = "btnOrders"
        btnOrders.Size = New Size(200, 45)
        btnOrders.TabIndex = 1
        btnOrders.Text = "Purchase Orders"
        btnOrders.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 114)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(200, 41)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1064, 640)
        Panel3.TabIndex = 2
        ' 
        ' menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "menu"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnDisposal As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bw_loadpo As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnSettings As Button
End Class
