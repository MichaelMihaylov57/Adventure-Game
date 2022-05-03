Public Class Shop
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If shopOnest = 1 Then
            MsgBox("This is my shop! You can pick out anything and buy it, as long as you have the money to!")
            lblshowmoney.Text = cash
            Timer1.Start()
        End If
    End Sub

    Private Sub btnhealth1_Click(sender As Object, e As EventArgs) Handles btnhealth1.Click
        If cash > 99 And heroHP < 10000 Then
            cash = cash - 100
            heroHP = heroHP + 500
        End If
    End Sub
    Private Sub btnhealth2_Click(sender As Object, e As EventArgs) Handles btnhealth2.Click
        If cash > 199 And heroHP < 10000 Then
            cash = cash - 200
            heroHP = heroHP + 1500
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblshowmoney.Text = cash
    End Sub

    Private Sub btnblue_Click(sender As Object, e As EventArgs) Handles btnblue.Click
        If cash > 149 And SpeedBuy = 0 Then
            cash = cash - 150
            speed = 1
            SpeedBuy = 1
        ElseIf cash > 149 And SpeedBuy = 1 Then
            cash = cash - 150
            speed = 2
            SpeedBuy = 2
        ElseIf cash > 149 And SpeedBuy = 2 Then
            cash = cash
        End If
    End Sub

    Private Sub btnsword_Click(sender As Object, e As EventArgs) Handles btnsword.Click
        If cash > 149 And maxSword = 0 Then
            cash = cash - 150
            heroOffence = heroOffence + 100
            maxSword = 1
        ElseIf cash > 149 And maxSword = 1 Then
            cash = cash - 150
            heroOffence = heroOffence + 100
            maxSword = 2
        ElseIf cash > 149 And maxSword = 2 Then
            cash = cash - 150
            heroOffence = heroOffence + 100
            maxSword = 3
        ElseIf cash > 149 And maxSword = 3 Then
            cash = cash - 150
            heroOffence = heroOffence + 100
            maxSword = 4
        ElseIf cash > 149 And maxSword = 4 Then
            cash = cash
        End If
    End Sub

    Private Sub btnshield_Click(sender As Object, e As EventArgs) Handles btnshield.Click
        If cash > 149 And maxShield = 0 Then
            cash = cash - 150
            heroDefence = heroDefence + 100
            maxShield = 1
        ElseIf cash > 149 And maxShield = 1 Then
            cash = cash - 150
            heroDefence = heroDefence + 100
            maxShield = 2
        ElseIf cash > 149 And maxShield = 2 Then
            cash = cash - 150
            heroDefence = heroDefence + 100
            maxShield = 3
        ElseIf cash > 149 And maxShield = 3 Then
            cash = cash - 150
            heroDefence = heroDefence + 100
            maxShield = 4
        ElseIf cash > 149 And maxShield = 4 Then
            cash = cash
        End If
    End Sub

    Private Sub btnkey_Click(sender As Object, e As EventArgs) Handles btnkey.Click
        If cash > 599 Then
            keyOwn = 1
            cash = cash - 600
            Secretropes = Secretropes + 1

        End If
    End Sub

    Private Sub btngoggles_Click(sender As Object, e As EventArgs) Handles btngoggles.Click
        If cash > 299 Then
            goggles = 1
            cash = cash - 300
            MsgBox("With these goggles you are able to see previously unseen treasures! I advise you to check out the portal!")

        End If
    End Sub
End Class