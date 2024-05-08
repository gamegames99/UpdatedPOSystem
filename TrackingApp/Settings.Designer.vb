<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Label1 = New Label()
        txtServer = New TextBox()
        Label2 = New Label()
        txtUsername = New TextBox()
        Label3 = New Label()
        txtPassword = New TextBox()
        Label4 = New Label()
        btnApply = New Button()
        btnCreate = New Button()
        btnCheck = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(409, 51)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DeepSkyBlue
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 30)
        Label1.TabIndex = 0
        Label1.Text = "Database Configuration Settings"
        ' 
        ' txtServer
        ' 
        txtServer.Location = New Point(12, 105)
        txtServer.Name = "txtServer"
        txtServer.Size = New Size(383, 23)
        txtServer.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(12, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 17)
        Label2.TabIndex = 2
        Label2.Text = "Server Hostname"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(12, 160)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(383, 23)
        txtUsername.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(12, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 17)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(12, 219)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(383, 23)
        txtPassword.TabIndex = 1
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(12, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 17)
        Label4.TabIndex = 2
        Label4.Text = "Password"
        ' 
        ' btnApply
        ' 
        btnApply.BackColor = Color.DeepSkyBlue
        btnApply.Enabled = False
        btnApply.FlatStyle = FlatStyle.Popup
        btnApply.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnApply.Location = New Point(292, 269)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(93, 32)
        btnApply.TabIndex = 3
        btnApply.Text = "Apply"
        btnApply.UseVisualStyleBackColor = False
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.DeepSkyBlue
        btnCreate.Enabled = False
        btnCreate.FlatStyle = FlatStyle.Popup
        btnCreate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreate.Location = New Point(156, 269)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(93, 32)
        btnCreate.TabIndex = 3
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' btnCheck
        ' 
        btnCheck.BackColor = Color.DeepSkyBlue
        btnCheck.FlatStyle = FlatStyle.Popup
        btnCheck.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheck.Location = New Point(23, 269)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(93, 32)
        btnCheck.TabIndex = 3
        btnCheck.Text = "Check"
        btnCheck.UseVisualStyleBackColor = False
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(409, 363)
        Controls.Add(btnCheck)
        Controls.Add(btnCreate)
        Controls.Add(btnApply)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtServer)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Settings"
        Text = "Settings"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtServer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnApply As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCheck As Button
End Class
