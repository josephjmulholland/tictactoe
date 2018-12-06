Class MainWindow


    Dim x As Boolean = True


    Private Sub txt1_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles txt1.MouseLeftButtonDown

        If x = True Then
            txt1.Text = "X"
            x = False
        Else
            txt1.Text = "O"
            x = True
        End If

        If txt1.Text = "X" AndAlso txt2.Text = "X" AndAlso txt3.Text = "X" Or txt4.Text = "X" AndAlso txt5.Text = "X" AndAlso txt6.Text = "X" Or txt7.Text = "X" AndAlso txt8.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt4.Text = "X" AndAlso txt7.Text = "X" Or txt2.Text = "X" AndAlso txt5.Text = "X" AndAlso txt8.Text = "X" Or txt3.Text = "X" AndAlso txt6.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt5.Text = "X" AndAlso txt9.Text = "X" Or txt3.Text = "X" AndAlso txt5.Text = "X" AndAlso txt7.Text = "X" Then
            MsgBox("Player 1 Wins!")
        ElseIf txt1.Text = "O" AndAlso txt2.Text = "O" AndAlso txt3.Text = "O" Or txt4.Text = "O" AndAlso txt5.Text = "O" AndAlso txt6.Text = "O" Or txt7.Text = "O" AndAlso txt8.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt4.Text = "O" AndAlso txt7.Text = "O" Or txt2.Text = "O" AndAlso txt5.Text = "O" AndAlso txt8.Text = "O" Or txt3.Text = "O" AndAlso txt6.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt5.Text = "O" AndAlso txt9.Text = "O" Or txt3.Text = "O" AndAlso txt5.Text = "O" AndAlso txt7.Text = "O" Then
            MsgBox("Player 2 Wins!")
        End If

    End Sub

    Private Sub txt2_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles txt2.MouseLeftButtonDown

        If x = True Then
            txt2.Text = "X"
            x = False
        Else
            txt2.Text = "O"
            x = True
        End If

        If txt1.Text = "X" AndAlso txt2.Text = "X" AndAlso txt3.Text = "X" Or txt4.Text = "X" AndAlso txt5.Text = "X" AndAlso txt6.Text = "X" Or txt7.Text = "X" AndAlso txt8.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt4.Text = "X" AndAlso txt7.Text = "X" Or txt2.Text = "X" AndAlso txt5.Text = "X" AndAlso txt8.Text = "X" Or txt3.Text = "X" AndAlso txt6.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt5.Text = "X" AndAlso txt9.Text = "X" Or txt3.Text = "X" AndAlso txt5.Text = "X" AndAlso txt7.Text = "X" Then
            MsgBox("Player 1 Wins!")
        ElseIf txt1.Text = "O" AndAlso txt2.Text = "O" AndAlso txt3.Text = "O" Or txt4.Text = "O" AndAlso txt5.Text = "O" AndAlso txt6.Text = "O" Or txt7.Text = "O" AndAlso txt8.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt4.Text = "O" AndAlso txt7.Text = "O" Or txt2.Text = "O" AndAlso txt5.Text = "O" AndAlso txt8.Text = "O" Or txt3.Text = "O" AndAlso txt6.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt5.Text = "O" AndAlso txt9.Text = "O" Or txt3.Text = "O" AndAlso txt5.Text = "O" AndAlso txt7.Text = "O" Then
            MsgBox("Player 2 Wins!")
        End If

    End Sub

    Private Sub txt3_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles txt3.MouseLeftButtonDown

        If x = True Then
            txt3.Text = "X"
            x = False
        Else
            txt3.Text = "O"
            x = True
        End If

        If txt1.Text = "X" AndAlso txt2.Text = "X" AndAlso txt3.Text = "X" Or txt4.Text = "X" AndAlso txt5.Text = "X" AndAlso txt6.Text = "X" Or txt7.Text = "X" AndAlso txt8.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt4.Text = "X" AndAlso txt7.Text = "X" Or txt2.Text = "X" AndAlso txt5.Text = "X" AndAlso txt8.Text = "X" Or txt3.Text = "X" AndAlso txt6.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt5.Text = "X" AndAlso txt9.Text = "X" Or txt3.Text = "X" AndAlso txt5.Text = "X" AndAlso txt7.Text = "X" Then
            MsgBox("Player 1 Wins!")
        ElseIf txt1.Text = "O" AndAlso txt2.Text = "O" AndAlso txt3.Text = "O" Or txt4.Text = "O" AndAlso txt5.Text = "O" AndAlso txt6.Text = "O" Or txt7.Text = "O" AndAlso txt8.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt4.Text = "O" AndAlso txt7.Text = "O" Or txt2.Text = "O" AndAlso txt5.Text = "O" AndAlso txt8.Text = "O" Or txt3.Text = "O" AndAlso txt6.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt5.Text = "O" AndAlso txt9.Text = "O" Or txt3.Text = "O" AndAlso txt5.Text = "O" AndAlso txt7.Text = "O" Then
            MsgBox("Player 2 Wins!")
        End If

    End Sub

    Private Sub txt4_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles txt4.MouseLeftButtonDown

        If x = True Then
            txt4.Text = "X"
            x = False
        Else
            txt4.Text = "O"
            x = True
        End If

        If txt1.Text = "X" AndAlso txt2.Text = "X" AndAlso txt3.Text = "X" Or txt4.Text = "X" AndAlso txt5.Text = "X" AndAlso txt6.Text = "X" Or txt7.Text = "X" AndAlso txt8.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt4.Text = "X" AndAlso txt7.Text = "X" Or txt2.Text = "X" AndAlso txt5.Text = "X" AndAlso txt8.Text = "X" Or txt3.Text = "X" AndAlso txt6.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt5.Text = "X" AndAlso txt9.Text = "X" Or txt3.Text = "X" AndAlso txt5.Text = "X" AndAlso txt7.Text = "X" Then
            MsgBox("Player 1 Wins!")
        ElseIf txt1.Text = "O" AndAlso txt2.Text = "O" AndAlso txt3.Text = "O" Or txt4.Text = "O" AndAlso txt5.Text = "O" AndAlso txt6.Text = "O" Or txt7.Text = "O" AndAlso txt8.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt4.Text = "O" AndAlso txt7.Text = "O" Or txt2.Text = "O" AndAlso txt5.Text = "O" AndAlso txt8.Text = "O" Or txt3.Text = "O" AndAlso txt6.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt5.Text = "O" AndAlso txt9.Text = "O" Or txt3.Text = "O" AndAlso txt5.Text = "O" AndAlso txt7.Text = "O" Then
            MsgBox("Player 2 Wins!")
        End If

    End Sub

    Private Sub txt5_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles txt5.MouseLeftButtonDown

        If x = True Then
            txt5.Text = "X"
            x = False
        Else
            txt5.Text = "O"
            x = True
        End If

        If txt1.Text = "X" AndAlso txt2.Text = "X" AndAlso txt3.Text = "X" Or txt4.Text = "X" AndAlso txt5.Text = "X" AndAlso txt6.Text = "X" Or txt7.Text = "X" AndAlso txt8.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt4.Text = "X" AndAlso txt7.Text = "X" Or txt2.Text = "X" AndAlso txt5.Text = "X" AndAlso txt8.Text = "X" Or txt3.Text = "X" AndAlso txt6.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt5.Text = "X" AndAlso txt9.Text = "X" Or txt3.Text = "X" AndAlso txt5.Text = "X" AndAlso txt7.Text = "X" Then
            MsgBox("Player 1 Wins!")
        ElseIf txt1.Text = "O" AndAlso txt2.Text = "O" AndAlso txt3.Text = "O" Or txt4.Text = "O" AndAlso txt5.Text = "O" AndAlso txt6.Text = "O" Or txt7.Text = "O" AndAlso txt8.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt4.Text = "O" AndAlso txt7.Text = "O" Or txt2.Text = "O" AndAlso txt5.Text = "O" AndAlso txt8.Text = "O" Or txt3.Text = "O" AndAlso txt6.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt5.Text = "O" AndAlso txt9.Text = "O" Or txt3.Text = "O" AndAlso txt5.Text = "O" AndAlso txt7.Text = "O" Then
            MsgBox("Player 2 Wins!")
        End If

    End Sub

    Private Sub txt6_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles txt6.MouseLeftButtonDown

        If x = True Then
            txt6.Text = "X"
            x = False
        Else
            txt6.Text = "O"
            x = True
        End If

        If txt1.Text = "X" AndAlso txt2.Text = "X" AndAlso txt3.Text = "X" Or txt4.Text = "X" AndAlso txt5.Text = "X" AndAlso txt6.Text = "X" Or txt7.Text = "X" AndAlso txt8.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt4.Text = "X" AndAlso txt7.Text = "X" Or txt2.Text = "X" AndAlso txt5.Text = "X" AndAlso txt8.Text = "X" Or txt3.Text = "X" AndAlso txt6.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt5.Text = "X" AndAlso txt9.Text = "X" Or txt3.Text = "X" AndAlso txt5.Text = "X" AndAlso txt7.Text = "X" Then
            MsgBox("Player 1 Wins!")
        ElseIf txt1.Text = "O" AndAlso txt2.Text = "O" AndAlso txt3.Text = "O" Or txt4.Text = "O" AndAlso txt5.Text = "O" AndAlso txt6.Text = "O" Or txt7.Text = "O" AndAlso txt8.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt4.Text = "O" AndAlso txt7.Text = "O" Or txt2.Text = "O" AndAlso txt5.Text = "O" AndAlso txt8.Text = "O" Or txt3.Text = "O" AndAlso txt6.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt5.Text = "O" AndAlso txt9.Text = "O" Or txt3.Text = "O" AndAlso txt5.Text = "O" AndAlso txt7.Text = "O" Then
            MsgBox("Player 2 Wins!")
        End If

    End Sub

    Private Sub txt7_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles txt7.MouseLeftButtonDown

        If x = True Then
            txt7.Text = "X"
            x = False
        Else
            txt7.Text = "O"
            x = True
        End If

        If txt1.Text = "X" AndAlso txt2.Text = "X" AndAlso txt3.Text = "X" Or txt4.Text = "X" AndAlso txt5.Text = "X" AndAlso txt6.Text = "X" Or txt7.Text = "X" AndAlso txt8.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt4.Text = "X" AndAlso txt7.Text = "X" Or txt2.Text = "X" AndAlso txt5.Text = "X" AndAlso txt8.Text = "X" Or txt3.Text = "X" AndAlso txt6.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt5.Text = "X" AndAlso txt9.Text = "X" Or txt3.Text = "X" AndAlso txt5.Text = "X" AndAlso txt7.Text = "X" Then
            MsgBox("Player 1 Wins!")
        ElseIf txt1.Text = "O" AndAlso txt2.Text = "O" AndAlso txt3.Text = "O" Or txt4.Text = "O" AndAlso txt5.Text = "O" AndAlso txt6.Text = "O" Or txt7.Text = "O" AndAlso txt8.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt4.Text = "O" AndAlso txt7.Text = "O" Or txt2.Text = "O" AndAlso txt5.Text = "O" AndAlso txt8.Text = "O" Or txt3.Text = "O" AndAlso txt6.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt5.Text = "O" AndAlso txt9.Text = "O" Or txt3.Text = "O" AndAlso txt5.Text = "O" AndAlso txt7.Text = "O" Then
            MsgBox("Player 2 Wins!")
        End If

    End Sub

    Private Sub txt8_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles txt8.MouseLeftButtonDown

        If x = True Then
            txt8.Text = "X"
            x = False
        Else
            txt8.Text = "O"
            x = True
        End If

        If txt1.Text = "X" AndAlso txt2.Text = "X" AndAlso txt3.Text = "X" Or txt4.Text = "X" AndAlso txt5.Text = "X" AndAlso txt6.Text = "X" Or txt7.Text = "X" AndAlso txt8.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt4.Text = "X" AndAlso txt7.Text = "X" Or txt2.Text = "X" AndAlso txt5.Text = "X" AndAlso txt8.Text = "X" Or txt3.Text = "X" AndAlso txt6.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt5.Text = "X" AndAlso txt9.Text = "X" Or txt3.Text = "X" AndAlso txt5.Text = "X" AndAlso txt7.Text = "X" Then
            MsgBox("Player 1 Wins!")
        ElseIf txt1.Text = "O" AndAlso txt2.Text = "O" AndAlso txt3.Text = "O" Or txt4.Text = "O" AndAlso txt5.Text = "O" AndAlso txt6.Text = "O" Or txt7.Text = "O" AndAlso txt8.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt4.Text = "O" AndAlso txt7.Text = "O" Or txt2.Text = "O" AndAlso txt5.Text = "O" AndAlso txt8.Text = "O" Or txt3.Text = "O" AndAlso txt6.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt5.Text = "O" AndAlso txt9.Text = "O" Or txt3.Text = "O" AndAlso txt5.Text = "O" AndAlso txt7.Text = "O" Then
            MsgBox("Player 2 Wins!")
        End If

    End Sub

    Private Sub txt9_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles txt9.MouseLeftButtonDown

        If x = True Then
            txt9.Text = "X"
            x = False
        Else
            txt9.Text = "O"
            x = True
        End If

        If txt1.Text = "X" AndAlso txt2.Text = "X" AndAlso txt3.Text = "X" Or txt4.Text = "X" AndAlso txt5.Text = "X" AndAlso txt6.Text = "X" Or txt7.Text = "X" AndAlso txt8.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt4.Text = "X" AndAlso txt7.Text = "X" Or txt2.Text = "X" AndAlso txt5.Text = "X" AndAlso txt8.Text = "X" Or txt3.Text = "X" AndAlso txt6.Text = "X" AndAlso txt9.Text = "X" Or txt1.Text = "X" AndAlso txt5.Text = "X" AndAlso txt9.Text = "X" Or txt3.Text = "X" AndAlso txt5.Text = "X" AndAlso txt7.Text = "X" Then
            MsgBox("Player 1 Wins!")
        ElseIf txt1.Text = "O" AndAlso txt2.Text = "O" AndAlso txt3.Text = "O" Or txt4.Text = "O" AndAlso txt5.Text = "O" AndAlso txt6.Text = "O" Or txt7.Text = "O" AndAlso txt8.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt4.Text = "O" AndAlso txt7.Text = "O" Or txt2.Text = "O" AndAlso txt5.Text = "O" AndAlso txt8.Text = "O" Or txt3.Text = "O" AndAlso txt6.Text = "O" AndAlso txt9.Text = "O" Or txt1.Text = "O" AndAlso txt5.Text = "O" AndAlso txt9.Text = "O" Or txt3.Text = "O" AndAlso txt5.Text = "O" AndAlso txt7.Text = "O" Then
            MsgBox("Player 2 Wins!")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As RoutedEventArgs) Handles btnReset.Click
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt5.Text = ""
        txt6.Text = ""
        txt7.Text = ""
        txt8.Text = ""
        txt9.Text = ""
        x = True
    End Sub
End Class
