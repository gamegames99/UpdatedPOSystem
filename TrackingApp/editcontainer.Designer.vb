<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editcontainer
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
        btnSave = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtPrice = New TextBox()
        txtDesc = New TextBox()
        cbxSerial = New ComboBox()
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
        Panel1.Size = New Size(442, 52)
        Panel1.TabIndex = 0
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
        ' btnSave
        ' 
        btnSave.BackColor = Color.DeepSkyBlue
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(255, 297)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(146, 34)
        btnSave.TabIndex = 9
        btnSave.Text = "Save Changes"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 6
        Label5.Text = "Unit Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 15)
        Label3.TabIndex = 7
        Label3.Text = "Item Description (Name, Brand, etc.)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 8
        Label2.Text = "Serial No."
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(12, 256)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(199, 23)
        txtPrice.TabIndex = 3
        ' 
        ' txtDesc
        ' 
        txtDesc.Location = New Point(12, 147)
        txtDesc.Multiline = True
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(389, 88)
        txtDesc.TabIndex = 4
        ' 
        ' cbxSerial
        ' 
        cbxSerial.FormattingEnabled = True
        cbxSerial.Location = New Point(12, 92)
        cbxSerial.Name = "cbxSerial"
        cbxSerial.Size = New Size(389, 23)
        cbxSerial.TabIndex = 10
        ' 
        ' editcontainer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(442, 354)
        Controls.Add(cbxSerial)
        Controls.Add(btnSave)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtPrice)
        Controls.Add(txtDesc)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "editcontainer"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents cbxSerial As ComboBox
End Class
