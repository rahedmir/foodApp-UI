
Public Class frmMain
    Dim drag As Boolean

    Dim mousex As Integer

    Dim mousey As Integer
    Public Sub mousedown_x()
        drag = True 'Sets the variable drag to true.

        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex

        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub
    Public Sub mouseup_x()
        drag = False
    End Sub

    Public Sub mousemove_x()
        If drag Then

            Me.Top = Windows.Forms.Cursor.Position.Y - mousey

            Me.Left = Windows.Forms.Cursor.Position.X - mousex

        End If
    End Sub


    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        pnlForFoods.Visible = True
        pnlForDrinks.Visible = False
        pnlForIcecream.Visible = False
        pnlForCake.Visible = False
        pnlForOrder.Visible = False

        panelDrinks.Visible = False
        panelIceCream.Visible = False
        panelCake.Visible = False
        panelOrder.Visible = False
        panelFood.Visible = True
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click

        Me.pnlForDrinks.Visible = True
        pnlForFoods.Visible = False
        pnlForIcecream.Visible = False
        pnlForCake.Visible = False
        pnlForOrder.Visible = False

        panelDrinks.Visible = True
        panelIceCream.Visible = False
        panelCake.Visible = False
        panelOrder.Visible = False
        panelFood.Visible = False
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlForFoods.Visible = True
        pnlForDrinks.Visible = False
        pnlForIcecream.Visible = False
        pnlForCake.Visible = False
        pnlForOrder.Visible = False

        panelDrinks.Visible = False
        panelIceCream.Visible = False
        panelCake.Visible = False
        panelOrder.Visible = False
        panelFood.Visible = True
    End Sub

    Private Sub btnIceCream_Click(sender As Object, e As EventArgs) Handles btnIceCream.Click
        pnlForFoods.Visible = False
        pnlForDrinks.Visible = False
        pnlForIcecream.Visible = True
        pnlForCake.Visible = False
        pnlForOrder.Visible = False

        panelDrinks.Visible = False
        panelIceCream.Visible = True
        panelCake.Visible = False
        panelOrder.Visible = False
        panelFood.Visible = False
    End Sub

    Private Sub btnCake_Click(sender As Object, e As EventArgs) Handles btnCake.Click
        pnlForFoods.Visible = False
        pnlForDrinks.Visible = False
        pnlForIcecream.Visible = False
        pnlForCake.Visible = True
        pnlForOrder.Visible = False

        panelDrinks.Visible = False
        panelIceCream.Visible = False
        panelCake.Visible = True
        panelOrder.Visible = False
        panelFood.Visible = False
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        pnlForFoods.Visible = False
        pnlForDrinks.Visible = False
        pnlForIcecream.Visible = False
        pnlForCake.Visible = False
        pnlForOrder.Visible = True

        panelDrinks.Visible = False
        panelIceCream.Visible = False
        panelCake.Visible = False
        panelOrder.Visible = True
        panelFood.Visible = False

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub panelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTop.MouseDown
        mousedown_x()
    End Sub

    Private Sub panelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTop.MouseMove
        mousemove_x()
    End Sub

    Private Sub panelTop_MouseUp(sender As Object, e As MouseEventArgs) Handles panelTop.MouseUp
        mouseup_x()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Process.Start("https://www.facebook.com/mir.rahed.uddin.io")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Process.Start("https://rahedmir.github.io")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub panelLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles panelLeft.MouseDown
        mousedown_x()
    End Sub

    Private Sub panelLeft_MouseMove(sender As Object, e As MouseEventArgs) Handles panelLeft.MouseMove
        mousemove_x()
    End Sub

    Private Sub panelLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles panelLeft.MouseUp
        mouseup_x()
    End Sub

   
    
End Class
