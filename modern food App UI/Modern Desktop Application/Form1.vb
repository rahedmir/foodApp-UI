
Public Class frmMain

    Dim drag As Boolean

    Dim mouse_x As Integer

    Dim mouse_y As Integer
    Public Sub mouse_down()
        drag = True 'Sets the variable drag to true.

        mouse_x = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mouse_x

        mouse_y = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mouse_y
    End Sub
    Public Sub mouse_up()
        drag = False
    End Sub

    Public Sub mouse_move()
        If drag Then

            Me.Top = Windows.Forms.Cursor.Position.Y - mouse_y

            Me.Left = Windows.Forms.Cursor.Position.X - mouse_x

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
        mouse_down()
    End Sub

    Private Sub panelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTop.MouseMove
        mouse_move()
    End Sub

    Private Sub panelTop_MouseUp(sender As Object, e As MouseEventArgs) Handles panelTop.MouseUp
        mouse_up()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Process.Start("https://www.facebook.com/rahedmir.io")
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
        mouse_down()
    End Sub

    Private Sub panelLeft_MouseMove(sender As Object, e As MouseEventArgs) Handles panelLeft.MouseMove
        mouse_move()
    End Sub

    Private Sub panelLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles panelLeft.MouseUp
        mouse_up()
    End Sub



End Class
