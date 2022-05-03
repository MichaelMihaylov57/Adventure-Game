Public Class Battle_Form
    Dim enemyOffence As Integer
    Dim enemyDefence As Integer
    Dim enemyHP As Integer
    Dim rnum1 As New Random
    Dim rnum As New Random
    Dim hOMP As Double 'hero offence multiplier
    Dim eOMP As Double 'enemy offence multiplier
    Dim loseHeroHp As Integer
    Dim loseEnemyHP As Integer
    Dim Mult As Decimal
    Dim Mult1 As Decimal
    Dim Mult5 As Integer
    Dim rnum3 As New Random

    Private Sub Battle_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If chooseenemy = 1 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\sqrl.png”)
            chooseenemy = 0
            enemyHP = 2000
            enemyDefence = rnum.Next(200, 350)
            enemyOffence = rnum.Next(600, 750)
            setLabels()


        ElseIf chooseenemy = 2 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\doge.png”)
            chooseenemy = 0
            enemyHP = 2500
            enemyDefence = rnum.Next(300, 400)
            enemyOffence = rnum.Next(650, 750)
            setLabels()


        ElseIf chooseenemy = 3 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\mad doge.png”)
            chooseenemy = 0
            enemyHP = 3500
            enemyDefence = rnum.Next(500, 600)
            enemyOffence = rnum.Next(800, 900)
            setLabels()


        ElseIf chooseenemy = 4 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\doggggg.png”)
            chooseenemy = 0
            enemyHP = 2500
            enemyDefence = rnum.Next(200, 250)
            enemyOffence = rnum.Next(650, 700)
            setLabels()


        ElseIf chooseenemy = 5 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\doggg.png”)
            chooseenemy = 0
            enemyHP = 2000
            enemyDefence = rnum.Next(300, 450)
            enemyOffence = rnum.Next(800, 900)
            setLabels()


        ElseIf chooseenemy = 6 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\browndog.png”)
            chooseenemy = 0
            enemyHP = 1500
            enemyDefence = rnum.Next(400, 450)
            enemyOffence = rnum.Next(700, 800)
            setLabels()


        ElseIf chooseenemy = 7 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\maddog1.png”)
            chooseenemy = 0
            enemyHP = 3000
            enemyDefence = rnum.Next(400, 450)
            enemyOffence = rnum.Next(700, 800)
            setLabels()


        ElseIf chooseenemy = 8 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\maddog8.png”)
            chooseenemy = 0
            enemyHP = 3000
            enemyDefence = rnum.Next(400, 450)
            enemyOffence = rnum.Next(700, 800)
            setLabels()

        ElseIf chooseenemy = 9 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\maddog7.png”)
            chooseenemy = 0
            enemyHP = 3000
            enemyDefence = rnum.Next(400, 450)
            enemyOffence = rnum.Next(700, 800)
            setLabels()


        ElseIf chooseenemy = 10 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\maddog5.png”)
            chooseenemy = 0
            enemyHP = 3000
            enemyDefence = rnum.Next(400, 450)
            enemyOffence = rnum.Next(700, 800)
            setLabels()


        ElseIf chooseenemy = 11 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\maddog9.png”)
            chooseenemy = 0
            enemyHP = 3000
            enemyDefence = rnum.Next(400, 450)
            enemyOffence = rnum.Next(700, 800)
            setLabels()


        ElseIf chooseenemy = 12 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\maddog6.png”)
            chooseenemy = 0
            enemyHP = 3000
            enemyDefence = rnum.Next(400, 450)
            enemyOffence = rnum.Next(700, 800)
            setLabels()

        ElseIf chooseenemy = 13 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\maddog4.png”)
            chooseenemy = 0
            enemyHP = 3000
            enemyDefence = rnum.Next(400, 450)
            enemyOffence = rnum.Next(700, 800)
            setLabels()


        ElseIf chooseenemy = 14 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\maddog3.png”)
            chooseenemy = 0
            enemyHP = 3000
            enemyDefence = rnum.Next(400, 450)
            enemyOffence = rnum.Next(700, 800)
            setLabels()


        ElseIf chooseenemy = 15 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\maddog8.png”)
            chooseenemy = 0
            enemyHP = 3000
            enemyDefence = rnum.Next(400, 450)
            enemyOffence = rnum.Next(700, 800)
            setLabels()


        ElseIf chooseenemy = 16 Then
            pctEnemy.Image = Image.FromFile(“H:\0.m256\0.Visual Basi.c\Projects in Progress\Backgrounds\boss.png”)
            chooseenemy = 0
            enemyHP = 15000
            enemyDefence = 1000
            enemyOffence = 1000
            setLabels()


        End If
    End Sub

    'Public Sub backgrounds()
    '    If x = 0 Then
    '        Me.BackgroundImage = Image.FromFile("H:\0.m256\0.Visual Basi.c\Projects in Progress\backergrounds\background.png")
    '    ElseIf x = 1 Then
    '        Me.BackgroundImage = Image.FromFile("H:\0.m256\0.Visual Basi.c\Projects in Progress\backergrounds\background2.png")
    '    ElseIf x = 2 Then
    '        Me.BackgroundImage = Image.FromFile("H:\0.m256\0.Visual Basi.c\Projects in Progress\backergrounds\background3.png")
    '    ElseIf x = 3 Then
    '        Me.BackgroundImage = Image.FromFile("H:\0.m256\0.Visual Basi.c\Projects in Progress\backergrounds\background4.png")
    '    ElseIf x = 4 Then
    '        Me.BackgroundImage = Image.FromFile("H:\0.m256\0.Visual Basi.c\Projects in Progress\backergrounds\background5.png")
    '    End If

    'End Sub


    Public Sub setLabels()
        lblHeroHp.Text = heroHP
        lblHeroOffence.Text = heroOffence
        lblHeroDefence.Text = heroDefence
        lblEnemyHp.Text = enemyHP
        lblEnemyOffence.Text = enemyOffence
        lblEnemyDefence.Text = enemyDefence
    End Sub

    Public Sub Multiplier()
        hOMP = rnum.NextDouble ' rnum between 0 and 1
        If hOMP > 0 And hOMP < 0.1 Then
            Mult = 1.05
        ElseIf hOMP > 0.11 And hOMP < 0.2 Then
            Mult = 1.1
        ElseIf hOMP > 0.21 And hOMP < 0.3 Then
            Mult = 1.15
        ElseIf hOMP > 0.31 And hOMP < 0.4 Then
            Mult = 1.2
        ElseIf hOMP > 0.41 And hOMP < 0.5 Then
            Mult = 1.25
        ElseIf hOMP > 0.51 And hOMP < 0.6 Then
            Mult = 1.3
        ElseIf hOMP > 0.61 And hOMP < 0.7 Then
            Mult = 1.35
        ElseIf hOMP > 0.71 And hOMP < 0.8 Then
            Mult = 1.4
        ElseIf hOMP > 0.81 And hOMP < 0.9 Then
            Mult = 1.45
        Else Mult = 1.5

        End If

        eOMP = rnum.NextDouble ' rnum between 0 and 1
        If eOMP > 0 And eOMP < 0.1 Then
            Mult1 = 1.05
        ElseIf eOMP > 0.11 And eOMP < 0.2 Then
            Mult1 = 1.1
        ElseIf eOMP > 0.21 And eOMP < 0.3 Then
            Mult1 = 1.15
        ElseIf eOMP > 0.31 And eOMP < 0.4 Then
            Mult1 = 1.2
        ElseIf eOMP > 0.41 And eOMP < 0.5 Then
            Mult1 = 1.25
        ElseIf eOMP > 0.51 And eOMP < 0.6 Then
            Mult1 = 1.3
        ElseIf eOMP > 0.61 And eOMP < 0.7 Then
            Mult1 = 1.35
        ElseIf eOMP > 0.71 And eOMP < 0.8 Then
            Mult1 = 1.4
        ElseIf eOMP > 0.81 And eOMP < 0.9 Then
            Mult1 = 1.45
        Else Mult1 = 1.5

        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbattle.Click
        'figuring out the loseHeroHP and loseEnemyHp will be a BIG part of MY project :D
        Multiplier()
        loseHeroHp = enemyOffence * Mult1 - heroDefence
        MsgBox(loseHeroHp)

        loseEnemyHP = heroOffence * Mult - enemyDefence
        MsgBox(loseEnemyHP)

        heroHP = heroHP - loseHeroHp
        enemyHP = enemyHP - loseEnemyHP

        setLabels()

        If enemyHP <= 0 Then
            MsgBox("Enemy has deaded. You won!")
            'heroHP = heroHP + 500
            HeroExp = HeroExp + 10
            cash = cash + 100
            Close()
        ElseIf heroHP <= 0 Then
            MsgBox("Hero has deaded")
            Close()
            MsgBox("You have LOST! Better luck next time, kiddo!")
        End If
    End Sub

    'Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
    '    hOMP = rnum1.NextDouble

    '    If hOMP > 0 And hOMP < 0.25 Then
    '        hOMP = 0.25
    '    ElseIf hOMP >= 0.25 And hOMP < 0.6 Then
    '        hOMP = 2.2
    '    ElseIf hOMP >= 0.6 And hOMP < 1 Then
    '        hOMP = 4.5
    '        MsgBox(hOMP)


    '    End If
    'End Sub

    'Private Sub btn125_Click(sender As Object, e As EventArgs) Handles btn125.Click
    '    If Exp >= 3 Then

    '        Mult5 = Mult5 + 0.25
    '        Exp = Exp - 3
    '    Else
    '    End If
    'End Sub

    'Private Sub btn150_Click(sender As Object, e As EventArgs) Handles btn150.Click
    '    If Exp >= 5 Then
    '        Multiplier()
    '        Mult5 = Mult5 + 0.5
    '        Exp = Exp - 5
    '    Else
    '    End If
    'End Sub

    'Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click
    '    If Exp >= 10 Then
    '        Multiplier()
    '        Mult5 = Mult5 + 1.0
    '        Exp = Exp - 10
    '    Else
    '    End If
    'End Sub

End Class

