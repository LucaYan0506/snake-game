Imports Microsoft.VisualBasic.PowerPacks

Public Class Form1
    Dim speed As Double = 1
    Dim bHandled As Boolean = False
    Dim direction As String
    Dim sec As Integer = 0
    Dim Snake_size As Integer
    Dim N_ofBody As Integer = 0
    'Change the direction of the snake 
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                direction = "Up"
                bHandled = True
            Case Keys.Down
                direction = "Down"
                bHandled = True
            Case Keys.Right
                direction = "Right"
                bHandled = True
            Case Keys.Left
                direction = "Left"
                bHandled = True
            Case Keys.W
                direction = "Up"
                bHandled = True
            Case Keys.S
                direction = "Down"
                bHandled = True
            Case Keys.D
                direction = "Right"
                bHandled = True
            Case Keys.A
                direction = "Left"
                bHandled = True
        End Select


        Return bHandled
    End Function

    'limit of the snake (for now is useless)
    Private Sub Snake_move(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        MsgBox(e.KeyCode.ToString)
        Snake_head.Enabled = False
        'move the Snake 
        With Snake_head
            'move up
            If e.KeyCode.Equals(Keys.W) Or e.KeyCode.Equals(Keys.Up) Then
                .Location = New Point(Snake_head.Location.X, Snake_head.Location.Y - speed)
                'move down
            ElseIf e.KeyCode.Equals(Keys.S) Or e.KeyCode.Equals(Keys.Down) Then
                .Location = New Point(Snake_head.Location.X, Snake_head.Location.Y + speed)
                'move left
            ElseIf e.KeyCode.Equals(Keys.A) Or e.KeyCode.Equals(Keys.Left) Then
                .Location = New Point(Snake_head.Location.X - speed, Snake_head.Location.Y)
                'move left 
            ElseIf e.KeyCode.Equals(Keys.D) Or e.KeyCode.Equals(Keys.Right) Then
                .Location = New Point(Snake_head.Location.X + speed, Snake_head.Location.Y)
            End If
        End With


        'variable for the limit
        Dim x, y As Integer
        Dim a As Integer = 70
        x = Snake_head.Location.X
        y = Snake_head.Location.Y

        'left limit 
        If Snake_head.Left <= LeftLimit.X1 Then
            x = LeftLimit.X1
        End If

        'Top limit
        If Snake_head.Location.Y <= TopLimit.Y1 Then
            y = TopLimit.Y1
        End If

        'right limit
        If Snake_head.Right >= RightLimit.X1 Then
            x = RightLimit.X1 - Snake_head.Width
        End If

        'down limit
        If Snake_head.Location.Y + Snake_head.Height >= DownLimit.Y1 Then
            y = DownLimit.Y1
        End If
        Snake_head.Location = New Point(x, y)
    End Sub


    Private Sub SnakeMoving_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SnakeMoving.Tick
        'change speed 
        sec += 1
        If sec = 1000 Then
            speed += 0.2
            sec = 0
        End If

        'direction 
        Select Case direction
            Case "Down"
                Snake_head.Location = New Point(Snake_head.Location.X, Snake_head.Location.Y + speed)
            Case "Up"
                Snake_head.Location = New Point(Snake_head.Location.X, Snake_head.Location.Y - speed)
            Case "Right"
                Snake_head.Location = New Point(Snake_head.Location.X + speed, Snake_head.Location.Y)
            Case "Left"
                Snake_head.Location = New Point(Snake_head.Location.X - speed, Snake_head.Location.Y)
        End Select

        'show speed
        Label1.Text = speed + 2

        'variable for the limit
        Dim x, y As Integer
        Dim a As Integer = 70
        x = Snake_head.Location.X
        y = Snake_head.Location.Y

        ' limit 
        If Snake_head.Left <= LeftLimit.X1 Or Snake_head.Location.Y <= TopLimit.Y1 Or Snake_head.Right >= RightLimit.X1 Or Snake_head.Location.Y + Snake_head.Height >= DownLimit.Y1 Then
            sender.stop()
            Snake_head.Location = New Point(146, 116)
            MsgBox("You lost")
        End If
    End Sub

    Private Sub StartCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartCmd.Click
        'init snake size
        Snake_size = Snake_head.Width

        direction = "Down"
        SnakeMoving.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'create new "body" of the snake 
        Dim Container As New ShapeContainer
        Dim Snake_Body As New RectangleShape

        'add new body to the snake
        N_ofBody += 1

        'set the "body" size, location etc.
        Container.Parent = Panel1
        Snake_Body.Parent = Container
        Snake_Body.Name = N_ofBody
        Snake_Body.Width = Snake_head.Width
        Snake_Body.Height = Snake_head.Height
        Snake_size += Snake_Body.Width
        Snake_Body.Top = Snake_head.Top
        Snake_Body.Left = Snake_head.Left - Snake_size
        Snake_Body.FillColor = Color.Green
        Snake_Body.FillStyle = FillStyle.Solid

        'add to the app
        Me.Controls.Add(Container)

        Panel1.SendToBack()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
      


    End Sub
End Class
