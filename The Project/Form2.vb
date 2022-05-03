Public Class Form2
    Dim enemy() As PictureBox
    Dim money() As PictureBox
    Dim rope() As PictureBox

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enemy = {enemy0, enemy1, enemy2, enemy3, enemy4, enemy5, enemy6, enemy7, enemy8}
        money = {money0, money1, money2, money3, money4, money5, money6, money7, money8, money9, money10, money11, money12, money13, money14, money15, money16, money17, money18}
        rope = {rope0, rope1, rope2, rope3, rope4, rope5}
        Timer1.Start()
    End Sub

    Public Sub HPlimit()
        If heroHP > 10001 Then
            heroHP = 10000
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If Player.Bounds.IntersectsWith(pctportal.Bounds) Then
            My.Forms.Form2.Hide()
        End If

        For o = 0 To 18
            If Player.Bounds.IntersectsWith(money(o).Bounds) And money(o).Visible Then
                money(o).Hide()
                cash = cash + 100
                lblmoney.Text = cash
            End If
        Next

        For g = 0 To 5

            If e.KeyCode = Keys.W And Player.Bounds.IntersectsWith(rope(g).Bounds) Then
                Player.Top = Player.Top - 5

            End If
            If e.KeyCode = Keys.S And Player.Bounds.IntersectsWith(rope(g).Bounds) Then
                Player.Top = Player.Top + 5

            End If
        Next

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

        For i = 0 To 8
            If Player.Bounds.IntersectsWith(enemy0.Bounds) And enemy(0).Visible And dog1 = 0 Then
                enemy0.Hide()
                chooseenemy = chooseenemy + 7
                dog1 = 1
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy1.Bounds) And enemy(1).Visible And dog2 = 0 Then
                enemy1.Hide()
                chooseenemy = chooseenemy + 8
                dog2 = 1
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy2.Bounds) And enemy(2).Visible And dog3 = 0 Then
                enemy2.Hide()
                chooseenemy = chooseenemy + 9
                dog3 = 1
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy3.Bounds) And enemy(3).Visible And dog4 = 0 Then
                enemy3.Hide()
                chooseenemy = chooseenemy + 10
                dog4 = 1
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy4.Bounds) And enemy(4).Visible And dog5 = 0 Then
                enemy4.Hide()
                chooseenemy = chooseenemy + 11
                dog5 = 1
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy5.Bounds) And enemy(5).Visible And dog6 = 0 Then
                enemy5.Hide()
                chooseenemy = chooseenemy + 12
                dog6 = 1
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy6.Bounds) And enemy(6).Visible And dog7 = 0 Then
                enemy6.Hide()
                chooseenemy = chooseenemy + 15
                dog7 = 1
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy7.Bounds) And enemy(7).Visible And dog8 = 0 Then
                enemy7.Hide()
                chooseenemy = chooseenemy + 13
                dog8 = 1
                My.Forms.Battle_Form.Show()
            ElseIf Player.Bounds.IntersectsWith(enemy8.Bounds) And enemy(8).Visible And dog9 = 0 Then
                enemy8.Hide()
                chooseenemy = chooseenemy + 14
                dog9 = 1
                My.Forms.Battle_Form.Show()
            End If
        Next


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblExp.Text = HeroExp
        lblHP.Text = heroHP
        HPlimit()
        lblmoney.Text = cash
        lbldef.Text = heroDefence
        lbloff.Text = heroOffence
    End Sub
End Class