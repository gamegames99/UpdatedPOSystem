Imports Microsoft.VisualBasic.Devices
Imports System.ComponentModel
Imports System.Net

Public Class menu
    'Dim loadfrm As New loadscreen
    Private Sub ShowProgressBar()
        If ProgressBar1.InvokeRequired Then
            ProgressBar1.Invoke(Sub() ProgressBar1.Visible = True)
        Else
            ProgressBar1.Visible = True
        End If
        Timer1.Start()
    End Sub

    Private Sub HideProgressBar()
        If ProgressBar1.InvokeRequired Then
            ProgressBar1.Invoke(Sub() ProgressBar1.Visible = False)
        Else
            ProgressBar1.Visible = False
        End If
        Timer1.Stop()
    End Sub

    Private Sub ClearPanel3()
        If Panel3.InvokeRequired Then
            Panel3.Invoke(Sub() Panel3.Controls.Clear())
        Else
            Panel3.Controls.Clear()
        End If
    End Sub
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        ProgressBar1.Visible = False
        Timer1.Interval = 100
        Timer1.Enabled = False
        AddHandler Timer1.Tick, AddressOf Timer1_Tick

        Dim iconPath As String = IO.Path.Combine(Application.StartupPath, "icons\BILECO.ico")
        Dim icon As New Icon(iconPath)
        Dim formType As Type = Me.GetType()
        formType.GetProperty("Icon").SetValue(Me, icon, Nothing)

        Dim imagePath As String = IO.Path.Combine(Application.StartupPath, "images\box.png")
        Dim image As New Bitmap(imagePath)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Image = image
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        ProgressBar1.PerformStep()
    End Sub
    Private Sub menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Async Sub Button_Click(sender As Object, e As EventArgs) Handles btnOrders.Click, btnStock.Click, btnDisposal.Click, btnReport.Click, btnReturn.Click
        Dim clickedButton = DirectCast(sender, Button)
        ClearPanel3()
        ShowProgressBar()

        Dim completedTask1 = Await StartBackgroundWorkAsync(clickedButton)

        HideProgressBar()
        ShowForm(completedTask1)
    End Sub
    Private Async Function StartBackgroundWorkAsync(clickedButton As Button) As Task(Of Button)
        Await Task.Delay(1000) ' Simulate background work
        Return clickedButton
    End Function

    Private Sub ShowForm(clickedButton As Button)
        Dim formToShow As Form = Nothing

        If clickedButton Is btnOrders Then
            formToShow = New Equipments()
        ElseIf clickedButton Is btnStock Then
            formToShow = New Stocks()
        ElseIf clickedButton Is Label1 Then
            formToShow = New menu()
        ElseIf clickedButton Is btnDisposal Then
            formToShow = New Disposal()
        ElseIf clickedButton Is btnReport Then
            formToShow = New ReportsForm()
        ElseIf clickedButton Is btnReturn Then
            formToShow = New ReturnsForm()
        End If

        If formToShow IsNot Nothing Then
            formToShow.TopLevel = False
            formToShow.FormBorderStyle = FormBorderStyle.None
            formToShow.Dock = DockStyle.Fill
            Panel3.Controls.Clear()
            Panel3.Controls.Add(formToShow)
            formToShow.BringToFront()
            formToShow.Show()
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MessageBox.Show("A project for tracking purchase orders", "0000000000x0000000012", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class