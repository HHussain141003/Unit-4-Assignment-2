Public Class Form1
    Dim blnChecker As Boolean
    Dim plus1 As Integer
    Dim intPlayer1 As Integer
    Dim intPlayer2 As Integer

    'Player 1 = X
    'Player 2 = O

    Private Sub Enable_False()
        btnGrid1.Enabled = False
        btnGrid2.Enabled = False
        btnGrid3.Enabled = True
        btnGrid4.Enabled = False
        btnGrid5.Enabled = False
        btnGrid6.Enabled = False
        btnGrid7.Enabled = False
        btnGrid8.Enabled = False
        btnGrid9.Enabled = False
    End Sub

    Private Sub Score()
        'All win conditions for both players
        'Player 1 (X)
        If btnGrid1.Text = "X" And btnGrid2.Text = "X" And btnGrid3.Text = "X" Then
            btnGrid1.BackColor = Color.PowderBlue
            btnGrid2.BackColor = Color.PowderBlue
            btnGrid3.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 1!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer1 += 1
            LblPlayer1Score.Text = intPlayer1
        End If

        If btnGrid4.Text = "X" And btnGrid5.Text = "X" And btnGrid6.Text = "X" Then
            btnGrid4.BackColor = Color.PowderBlue
            btnGrid5.BackColor = Color.PowderBlue
            btnGrid6.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 1!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer1 += 1
            LblPlayer1Score.Text = intPlayer1
        End If

        If btnGrid7.Text = "X" And btnGrid8.Text = "X" And btnGrid9.Text = "X" Then
            btnGrid7.BackColor = Color.PowderBlue
            btnGrid8.BackColor = Color.PowderBlue
            btnGrid9.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 1!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer1 += 1
            LblPlayer1Score.Text = intPlayer1
        End If

        If btnGrid1.Text = "X" And btnGrid4.Text = "X" And btnGrid7.Text = "X" Then
            btnGrid1.BackColor = Color.PowderBlue
            btnGrid4.BackColor = Color.PowderBlue
            btnGrid7.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 1!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer1 += 1
            LblPlayer1Score.Text = intPlayer1
        End If

        If btnGrid2.Text = "X" And btnGrid5.Text = "X" And btnGrid8.Text = "X" Then
            btnGrid2.BackColor = Color.PowderBlue
            btnGrid5.BackColor = Color.PowderBlue
            btnGrid8.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 1!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer1 += 1
            LblPlayer1Score.Text = intPlayer1
        End If

        If btnGrid3.Text = "X" And btnGrid6.Text = "X" And btnGrid9.Text = "X" Then
            btnGrid3.BackColor = Color.PowderBlue
            btnGrid6.BackColor = Color.PowderBlue
            btnGrid9.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 1!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer1 += 1
            LblPlayer1Score.Text = intPlayer1
        End If

        If btnGrid1.Text = "X" And btnGrid5.Text = "X" And btnGrid9.Text = "X" Then
            btnGrid1.BackColor = Color.PowderBlue
            btnGrid5.BackColor = Color.PowderBlue
            btnGrid9.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 1!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer1 += 1
            LblPlayer1Score.Text = intPlayer1
        End If

        If btnGrid3.Text = "X" And btnGrid5.Text = "X" And btnGrid7.Text = "X" Then
            btnGrid3.BackColor = Color.PowderBlue
            btnGrid5.BackColor = Color.PowderBlue
            btnGrid7.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 1!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer1 += 1
            LblPlayer1Score.Text = intPlayer1
        End If

        'Player 2(O)
        If btnGrid1.Text = "O" And btnGrid2.Text = "O" And btnGrid3.Text = "O" Then
            btnGrid1.BackColor = Color.PowderBlue
            btnGrid2.BackColor = Color.PowderBlue
            btnGrid3.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 2!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer2 += 1
            LblPlayer2Score.Text = intPlayer2
        End If

        If btnGrid4.Text = "O" And btnGrid5.Text = "O" And btnGrid6.Text = "O" Then
            btnGrid4.BackColor = Color.PowderBlue
            btnGrid5.BackColor = Color.PowderBlue
            btnGrid6.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 2!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer2 += 1
            LblPlayer2Score.Text = intPlayer2
        End If

        If btnGrid7.Text = "O" And btnGrid8.Text = "O" And btnGrid9.Text = "O" Then
            btnGrid7.BackColor = Color.PowderBlue
            btnGrid8.BackColor = Color.PowderBlue
            btnGrid9.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 2!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer2 += 1
            LblPlayer2Score.Text = intPlayer2
        End If

        If btnGrid1.Text = "O" And btnGrid4.Text = "O" And btnGrid7.Text = "O" Then
            btnGrid1.BackColor = Color.PowderBlue
            btnGrid4.BackColor = Color.PowderBlue
            btnGrid7.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 2!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer2 += 1
            LblPlayer2Score.Text = intPlayer2
        End If

        If btnGrid2.Text = "O" And btnGrid5.Text = "O" And btnGrid8.Text = "O" Then
            btnGrid2.BackColor = Color.PowderBlue
            btnGrid5.BackColor = Color.PowderBlue
            btnGrid8.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 2!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer2 += 1
            LblPlayer2Score.Text = intPlayer2
        End If

        If btnGrid3.Text = "O" And btnGrid6.Text = "O" And btnGrid9.Text = "O" Then
            btnGrid3.BackColor = Color.PowderBlue
            btnGrid6.BackColor = Color.PowderBlue
            btnGrid9.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 2!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer2 += 1
            LblPlayer2Score.Text = intPlayer2
        End If

        If btnGrid1.Text = "O" And btnGrid5.Text = "O" And btnGrid9.Text = "O" Then
            btnGrid1.BackColor = Color.PowderBlue
            btnGrid5.BackColor = Color.PowderBlue
            btnGrid9.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 2!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer2 += 1
            LblPlayer2Score.Text = intPlayer2
        End If

        If btnGrid3.Text = "O" And btnGrid5.Text = "O" And btnGrid7.Text = "O" Then
            btnGrid3.BackColor = Color.PowderBlue
            btnGrid5.BackColor = Color.PowderBlue
            btnGrid7.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is Player 2!", "Noughts and Crosses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus1 = Convert.ToInt64(LblPlayer1Score.Text)
            LblPlayer1Score.Text = Convert.ToString(plus1)
            Enable_False()
            intPlayer2 += 1
            LblPlayer2Score.Text = intPlayer2
        End If
    End Sub

    Private Sub BtnGrid1_Click(sender As Object, e As EventArgs) Handles btnGrid1.Click
        If blnChecker = False Then

            btnGrid1.Text = "X"
            blnChecker = True

        Else

            btnGrid1.Text = "O"
            blnChecker = False
        End If
        Score()
        btnGrid1.Enabled = False
    End Sub

    Private Sub BtnGrid2_Click(sender As Object, e As EventArgs) Handles btnGrid2.Click
        If blnChecker = False Then

            btnGrid2.Text = "X"
            blnChecker = True

        Else

            btnGrid2.Text = "O"
            blnChecker = False
        End If
        Score()
        btnGrid2.Enabled = False
    End Sub

    Private Sub BtnGrid3_Click(sender As Object, e As EventArgs) Handles btnGrid3.Click
        If blnChecker = False Then

            btnGrid3.Text = "X"
            blnChecker = True

        Else

            btnGrid3.Text = "O"
            blnChecker = False
        End If
        Score()
        btnGrid3.Enabled = False
    End Sub

    Private Sub BtnGrid4_Click(sender As Object, e As EventArgs) Handles btnGrid4.Click
        If blnChecker = False Then

            btnGrid4.Text = "X"
            blnChecker = True

        Else

            btnGrid4.Text = "O"
            blnChecker = False
        End If
        Score()
        btnGrid4.Enabled = False
    End Sub

    Private Sub BtnGrid5_Click(sender As Object, e As EventArgs) Handles btnGrid5.Click
        If blnChecker = False Then

            btnGrid5.Text = "X"
            blnChecker = True

        Else

            btnGrid5.Text = "O"
            blnChecker = False
        End If
        Score()
        btnGrid5.Enabled = False
    End Sub

    Private Sub BtnGrid6_Click(sender As Object, e As EventArgs) Handles btnGrid6.Click
        If blnChecker = False Then

            btnGrid6.Text = "X"
            blnChecker = True

        Else

            btnGrid6.Text = "O"
            blnChecker = False
        End If
        Score()
        btnGrid6.Enabled = False
    End Sub

    Private Sub BtnGrid7_Click(sender As Object, e As EventArgs) Handles btnGrid7.Click
        If blnChecker = False Then

            btnGrid7.Text = "X"
            blnChecker = True

        Else

            btnGrid7.Text = "O"
            blnChecker = False
        End If
        Score()
        btnGrid7.Enabled = False
    End Sub

    Private Sub BtnGrid8_Click(sender As Object, e As EventArgs) Handles btnGrid8.Click
        If blnChecker = False Then

            btnGrid8.Text = "X"
            blnChecker = True

        Else

            btnGrid8.Text = "O"
            blnChecker = False
        End If
        Score()
        btnGrid8.Enabled = False
    End Sub

    Private Sub BtnGrid9_Click(sender As Object, e As EventArgs) Handles btnGrid9.Click
        If blnChecker = False Then

            btnGrid9.Text = "X"
            blnChecker = True

        Else

            btnGrid9.Text = "O"
            blnChecker = False
        End If
        Score()
        btnGrid9.Enabled = False
    End Sub

    Private Sub BtnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        btnGrid1.Enabled = True
        btnGrid2.Enabled = True
        btnGrid3.Enabled = True
        btnGrid4.Enabled = True
        btnGrid5.Enabled = True
        btnGrid6.Enabled = True
        btnGrid7.Enabled = True
        btnGrid8.Enabled = True
        btnGrid9.Enabled = True

        btnGrid1.Text = ""
        btnGrid2.Text = ""
        btnGrid3.Text = ""
        btnGrid4.Text = ""
        btnGrid5.Text = ""
        btnGrid6.Text = ""
        btnGrid7.Text = ""
        btnGrid8.Text = ""
        btnGrid9.Text = ""

        intPlayer1 = 0
        intPlayer2 = 0
        LblPlayer1Score.Text = "0"
        LblPlayer2Score.Text = "0"

        btnGrid1.BackColor = Color.White
        btnGrid2.BackColor = Color.White
        btnGrid3.BackColor = Color.White
        btnGrid4.BackColor = Color.White
        btnGrid5.BackColor = Color.White
        btnGrid6.BackColor = Color.White
        btnGrid7.BackColor = Color.White
        btnGrid8.BackColor = Color.White
        btnGrid9.BackColor = Color.White
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnGrid1.Enabled = True
        btnGrid2.Enabled = True
        btnGrid3.Enabled = True
        btnGrid4.Enabled = True
        btnGrid5.Enabled = True
        btnGrid6.Enabled = True
        btnGrid7.Enabled = True
        btnGrid8.Enabled = True
        btnGrid9.Enabled = True

        btnGrid1.Text = ""
        btnGrid2.Text = ""
        btnGrid3.Text = ""
        btnGrid4.Text = ""
        btnGrid5.Text = ""
        btnGrid6.Text = ""
        btnGrid7.Text = ""
        btnGrid8.Text = ""
        btnGrid9.Text = ""

        btnGrid1.BackColor = Color.White
        btnGrid2.BackColor = Color.White
        btnGrid3.BackColor = Color.White
        btnGrid4.BackColor = Color.White
        btnGrid5.BackColor = Color.White
        btnGrid6.BackColor = Color.White
        btnGrid7.BackColor = Color.White
        btnGrid8.BackColor = Color.White
        btnGrid9.BackColor = Color.White

        btnNewGame.Enabled = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
