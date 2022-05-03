Public Class boss

    Private Sub boss_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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

        If Player.Bounds.IntersectsWith(pctboss.Bounds) Then
            chooseenemy = 16
            My.Forms.Battle_Form.Show()
        End If
        If Player.Bounds.IntersectsWith(pctgate.Bounds) Then
            My.Forms.boss.Hide()
        End If

    End Sub


End Class