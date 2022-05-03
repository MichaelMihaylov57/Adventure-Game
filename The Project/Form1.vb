Public Class Form1
    Dim rope() As PictureBox
    Dim wall() As PictureBox
    Dim money() As PictureBox
    Dim enemy() As PictureBox
    Dim unknown As Integer
    Dim shop As Integer
    Dim rnum As Random

    Public Sub HPlimit()
        If heroHP > 10001 Then
            heroHP = 10000
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wall = {wall0, wall1, wall2, wall3, wall4, wall5, wall6, wall7, wall8, wall9, wall10, wall11, wall12, wall13, wall14, wall15, wall16, wall17, wall18, wall19, wall20, wall21}
        rope = {rope0, rope1, rope2, rope3, rope4, rope5, rope6, rope7, rope8, rope9, pctsecretrope}
        money = {money0, money1, money2, money3, money4, money5, money6, money7, money8, money9, money10}
        enemy = {enemy0, enemy1, enemy2, enemy3, enemy4, enemy5}
        heroHP = 1000
        shopOnest = 1
        Timer1.Start()
        pctsecretrope.Hide()
        Timer2.Start()

    End Sub

    Public Sub secretRope()
        If Secretropes = 1 Then
            pctsecretrope.Show()
            pctchain.Hide()
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        For i = 0 To 10

            If e.KeyCode = Keys.U And heroDefence = 0 Then
                heroHP = 10000
                heroDefence = 500
                heroOffence = 1000
                MsgBox("You have started the game! Dont press U again and continue with your adventure!")
            End If



            If e.KeyCode = Keys.W And Player.Bounds.IntersectsWith(rope(i).Bounds) Then
                Player.Top = Player.Top - 5

            End If
            If e.KeyCode = Keys.S And Player.Bounds.IntersectsWith(rope(i).Bounds) Then
                Player.Top = Player.Top + 5

            End If
        Next

        If e.KeyCode = Keys.K Then
            cash = 100000
            heroHP = 100000
            heroOffence = 100000
            heroDefence = 100000
            speed = 2
        End If

        If e.KeyCode = Keys.A And speed = 0 Then
            Player.Left = Player.Left - 5

        ElseIf e.KeyCode = Keys.A And speed = 1 Then
            Player.Left = Player.Left - 10

        ElseIf e.KeyCode = Keys.A And speed = 2 Then
            Player.Left = Player.Left - 15

        End If
        If e.KeyCode = Keys.D And speed = 0 Then
            Player.Left = Player.Left + 5

        ElseIf e.KeyCode = Keys.D And speed = 1 Then
            Player.Left = Player.Left + 10

        ElseIf e.KeyCode = Keys.D And speed = 2 Then
            Player.Left = Player.Left + 15

        End If
        For o = 0 To 10
            If Player.Bounds.IntersectsWith(money(o).Bounds) And money(o).Visible Then
                money(o).Hide()
                cash = cash + 100
                lblmoney.Text = cash

            End If
        Next

        If Player.Bounds.IntersectsWith(pctgate.Bounds) Then
            My.Forms.boss.Show()

        End If

        For i = 0 To 5

            If Player.Bounds.IntersectsWith(enemy0.Bounds) And enemy(0).Visible Then
                enemy0.Hide()
                chooseenemy = chooseenemy + 1
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy1.Bounds) And enemy(1).Visible Then
                enemy1.Hide()
                chooseenemy = chooseenemy + 2
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy2.Bounds) And enemy(2).Visible Then
                enemy2.Hide()
                chooseenemy = chooseenemy + 3
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy3.Bounds) And enemy(3).Visible Then
                enemy3.Hide()
                chooseenemy = chooseenemy + 4
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy4.Bounds) And enemy(4).Visible Then
                enemy4.Hide()
                chooseenemy = chooseenemy + 5
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy5.Bounds) And enemy(5).Visible Then
                enemy5.Hide()
                chooseenemy = chooseenemy + 6
                My.Forms.Battle_Form.Show()

            End If
            If Player.Bounds.IntersectsWith(pctportal.Bounds) Then
                My.Forms.Form2.Show()
            End If

            If Player.Bounds.IntersectsWith(PicIntersect.Bounds) And PicIntersect.Visible Then
                PicIntersect.Hide()
                MsgBox("Jake the Merchant: Help me! You have to kill this mad doge! If you do I will reward you and let you trade with me!")
            End If
            If Player.Bounds.IntersectsWith(PicWin.Bounds) And PicWin.Visible Then
                PicWin.Hide()
                MsgBox("You have saved me! Heres $1000 as a reward! If you ever wanna trade, then just come and INTERSECT BOUNDS with me! ;)")
                cash = cash + 1000
            End If
            If Player.Bounds.IntersectsWith(PicJaker.Bounds) And shop = 1 Then
                shop = 0
                My.Forms.Shop.Show()
            End If
            If Player.Bounds.IntersectsWith(PicShop.Bounds) Then
                shop = 1
            End If
        Next
        If Player.Bounds.IntersectsWith(pctchain.Bounds) And keyOwn = 1 Then
            keyOwn = 2
            pctchain.Hide()
            MsgBox("You have unlocked the path to the boss! But beware, he is the most powerful creature you will have to face!")
        ElseIf Player.Bounds.IntersectsWith(pctchain.Bounds) And keyOwn = 0 And keyTime = 0 Then
            MsgBox("You have to go buy the key from the Merchant to proceed!")
            Player.Top = Player.Top + 10
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblExp.Text = HeroExp
        lblHP.Text = heroHP
        HPlimit()
        lblmoney.Text = cash
        lbldef.Text = heroDefence
        lbloff.Text = heroOffence
        secretRope()


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub
End Class
