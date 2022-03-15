Public Class Form1
    Dim Snake(2500) As PictureBox
    Dim Snake_length As Integer = -1
    Dim Food_number As Integer = 0
    Dim speed As Integer = 10
    Dim UpDown, LeftRight As Double
    Dim score As Integer
    Dim lastKeyDown As Keys
    Dim Bonus_food(100) As PictureBox
    Dim first As Boolean = True
    Dim level As Integer = 0
    'Restart the game
    Private Sub StartCmd_Click(sender As Object, e As EventArgs) Handles StartCmd.Click
        'make sure that we can use keys.space 
        NumericUpDown1.Enabled = False


        Snake_move.Stop()
        'init the score and level
        score = 0
        level = 1
        ScoreLbl.Text = score
        LevelLbl.Text = level

        'delete the snake (if exists)
        For i = 0 To Snake_length
            Me.Controls.Add(Snake(i))
        Next

        'create a new one with new location
        Snake_length = -1
        Head()
        Start_length_of_snake(1)
        sender.enabled = False

        'delete are food
        For i = 0 To Food_number
            Me.Controls.Remove(Bonus_food(i))
        Next

        'add 1 food 
        Food_number = 0
        food(0, Food_number)


    End Sub

    'generate snake_head
    Private Sub Head()
        Snake_length += 1
        'set it as new picture box
        Snake(0) = New PictureBox

        'set all value sush as name, location,size
        With Snake(0)
            .Name = "Head"
            .Width = 25
            .Height = 25
            .Top = 100
            .Left = 100
            .BackColor = Color.FromArgb(192, 192, 0)
            Dim snake_head As Image = Image.FromFile("D:\School\IT\Visual Basic\Snake Game\Snake Game (1.1)\Snake Game (1.1)\snake_head.jpg")
            .Image = snake_head
            .SizeMode = PictureBoxSizeMode.Zoom
        End With
        Me.Controls.Add(Snake(0))

        Snake(0).BringToFront()
    End Sub

    'generate snake_body
    Private Sub Body()
        Snake_length += 1

        'create the "body"
        Snake(Snake_length) = New PictureBox

        'set all value such as location size name
        With Snake(Snake_length)
            .Name = Snake_length
            .Width = Snake(0).Width
            .Height = Snake(0).Height
            .Top = Snake(Snake_length - 1).Top
            .Left = Snake(Snake_length - 1).Left - Snake(Snake_length).Width
            .BackColor = Color.Green
        End With

        Me.Controls.Add(Snake(Snake_length))

        Snake(Snake_length).BringToFront()
    End Sub


    'init the length of snake
    Private Sub Start_length_of_snake(ByVal l As Integer)
        For i = 1 To l
            Body()
        Next
    End Sub

    'food and snake move
    Private Sub Snake_move_Tick(sender As Object, e As EventArgs) Handles Snake_move.Tick
        'snake_body location
        For i = Snake_length To 1 Step -1
            Snake(i).Location = Snake(i - 1).Location
        Next

        'snake_head location
        Snake(0).Top += UpDown
        Snake(0).Left += LeftRight

        'what happend when eat food
        For i = 0 To Food_number
            If Snake(0).Location.X > Bonus_food(i).Location.X - 25 And Snake(0).Location.X < Bonus_food(i).Location.X + 25 Then
                If Snake(0).Location.Y > Bonus_food(i).Location.Y - 25 And Snake(0).Location.Y < Bonus_food(i).Location.Y + 25 Then
                    Bonus_food(i).Location = New Point(5000, 5000)
                    If i = 0 Then
                        Bonus_food(i).Location = New Point((33 * Rnd()) * 25, (18 * Rnd()) * 25)
                        food_Type(Bonus_food(i))
                    End If
                    Body()
                    first = True
                    score += 1
                    ScoreLbl.Text = score
                End If
            End If
        Next


        'bonus
        Dim Level_n_of_score As Integer
        Level_set(level, Level_n_of_score)
        If score Mod Level_n_of_score = 0 And score <> 0 And first = True Then
            bonus()
            first = False
            level += 1
            LevelLbl.Text = level
            Dim nextLevel As Integer
            Level_set(level, nextLevel)
            NextLevel_scoreLbl.Text = nextLevel
        End If

        'check if lose 
        Dim lose As Boolean
        Check_lose(lose)
        If lose = True Then
            Snake_move.Stop()
            MsgBox("You lost")
            StartCmd.Enabled = True
            NumericUpDown1.Enabled = True
        End If
    End Sub

    'Change the direction of the snake 
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If Snake_length > -1 Then
            'move the snake
            Select Case keyData
                Case Keys.Up, Keys.Down, Keys.Left, Keys.Right, Keys.S, Keys.A, Keys.D, Keys.W
                    Snake_move.Start()


                    'check if the user want to go to the opposite dirrection 
                    Select Case keyData
                        Case Keys.Up, Keys.W
                            If lastKeyDown = Keys.Down Or lastKeyDown = Keys.S Then
                                keyData = Keys.Down
                            End If
                        Case Keys.Down, Keys.S
                            If lastKeyDown = Keys.Up Or lastKeyDown = Keys.W Then
                                keyData = Keys.Up
                            End If
                        Case Keys.Right, Keys.D
                            If lastKeyDown = Keys.Left Or lastKeyDown = Keys.A Then
                                keyData = Keys.Left
                            End If
                        Case Keys.Left, Keys.A
                            If lastKeyDown = Keys.Right Or lastKeyDown = Keys.D Then
                                keyData = Keys.Right
                            End If
                    End Select

                    'check direction
                    Dim bHandled As Boolean
                    UpDown = 0
                    LeftRight = 0
                    Select Case keyData
                        Case Keys.Up, Keys.W
                            UpDown = -speed
                            bHandled = True
                        Case Keys.Down, Keys.S
                            UpDown = +speed
                            bHandled = True
                        Case Keys.Right, Keys.D
                            LeftRight = +speed
                            bHandled = True
                        Case Keys.Left, Keys.A
                            LeftRight = -speed
                            bHandled = True
                    End Select
                    lastKeyDown = keyData
                    Return bHandled
            End Select
        End If
    End Function

    'lose condition 
    Private Sub Check_lose(ByRef lose As Boolean)
        If Snake(0).Location.X < 0 Then
            Snake(0).Location = New Point(0, Snake(0).Location.Y)
            lose = True
        ElseIf Snake(0).Location.Y < 0 Then
            Snake(0).Location = New Point(Snake(0).Location.X, 0)
            lose = True
        ElseIf Snake(0).Location.X > 851 Then
            Snake(0).Location = New Point(851, Snake(0).Location.Y)
            lose = True
        ElseIf Snake(0).Location.Y > 476 Then
            Snake(0).Location = New Point(Snake(0).Location.X, 476)
            lose = True
        Else
            For i = 1 To Snake_length
                If Snake(0).Location = Snake(i).Location Then
                    Snake_move.Stop()
                    lose = True
                    Exit For
                End If
            Next
        End If

        Snake(0).BringToFront()
    End Sub

    'bonus 
    Private Sub bonus()
        For i = 1 To Food_number
            Me.Controls.Remove(Bonus_food(i))
        Next
        Food_number = NumericUpDown1.Value
        food(1, Food_number)
    End Sub

    'generate food
    Private Sub food(ByVal First As Integer, ByVal LastOne As Integer)
        For i = First To LastOne
            'create new food 
            Bonus_food(i) = New PictureBox
            With Bonus_food(i)
                Name = "Food" & i
                .Anchor = System.Windows.Forms.AnchorStyles.None
                .BackColor = System.Drawing.Color.Transparent
                .BackgroundImage = Global.Snake_Game__1._1_.My.Resources.Resources.Background
                .BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
                food_Type(Bonus_food(i))
                .Location = New System.Drawing.Point(New Point((33 * Rnd()) * 25, (18 * Rnd()) * 25))
                For x = 0 To i
                    check(Bonus_food(i), Bonus_food(x))
                Next
                .Size = New System.Drawing.Size(25, 25)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            End With
            Me.Controls.Add(Bonus_food(i))
            Bonus_food(i).BringToFront()
        Next
    End Sub

    'check if there are food in the same location
    Private Sub check(ByVal a As PictureBox, ByVal b As PictureBox)
        If a.Location.X > b.Location.X - 25 And a.Location.X < b.Location.X + 25 Then
            If a.Location.Y > b.Location.Y - 25 And a.Location.Y < b.Location.Y Then
                a.Location = New Point((33 * Rnd()) * 25, (18 * Rnd()) * 25)
            End If
        End If
    End Sub

    'accelaration
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode.Equals(Keys.Space) Then
            speed = 25
            Select Case lastKeyDown
                Case Keys.Up, Keys.W
                    UpDown = -speed
                Case Keys.Down, Keys.S
                    UpDown = +speed
                Case Keys.Right, Keys.D
                    LeftRight = +speed
                Case Keys.Left, Keys.A
                    LeftRight = -speed
            End Select
        End If
    End Sub

    'deaccelaration
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode.Equals(Keys.Space) Then
            speed = 10
            Select Case lastKeyDown
                Case Keys.Up, Keys.W
                    UpDown = -speed
                Case Keys.Down, Keys.S
                    UpDown = +speed
                Case Keys.Right, Keys.D
                    LeftRight = +speed
                Case Keys.Left, Keys.A
                    LeftRight = -speed
            End Select
        End If
    End Sub

    'choose level
    Private Sub Level_set(ByVal l As Integer, ByRef result As Integer)
        For i = 1 To l
            result += 10 + result
        Next
    End Sub


    'choose randow food
    Private Sub food_Type(ByVal foodd As PictureBox)
        Dim f As Integer = 4 * Rnd() + 1
        Select Case f
            Case 1
                foodd.Image = Global.Snake_Game__1._1_.My.Resources.Strawberry_removebg_preview
            Case 2
                foodd.Image = Global.Snake_Game__1._1_.My.Resources.apple_removebg_preview
            Case 3
                foodd.Image = Global.Snake_Game__1._1_.My.Resources.Cherry_removebg_preview
            Case 4
                foodd.Image = Global.Snake_Game__1._1_.My.Resources.orange_removebg_preview
        End Select
    End Sub
End Class
