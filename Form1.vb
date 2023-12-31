Public Class Form1
    Dim Num1 As Decimal
    Dim Num2 As Decimal
    Dim Operate As Integer

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click

        Num2 = Num.Text

        Select Case Operate
            Case 1
                Num.Text = Num1 + Num2
            Case 2
                Num.Text = Num1 - Num2
            Case 3
                Num.Text = Num1 * Num2
            Case 4
                Num.Text = Num2
                If Num2 = 0 Then
                    Num.Text = "Error"
                Else
                    Num.Text = Num1 / Num2
                End If
            Case Else
                Num.Text = "0"
        End Select


    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        If Num.Text <> "0" Then
            Num.Text += "1"
        Else
            Num.Text = "1"
        End If

    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        If Num.Text <> "0" Then
            Num.Text += "2"
        Else
            Num.Text = "2"
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Try
            Num1 = Num.Text
            Num.Text = "0"
            Operate = 1
        Catch ex As Exception
            Num.Text = "Error"
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        If Num.Text <> "0" Then
            Num.Text += "3"
        Else
            Num.Text = "3"
        End If
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        If Num.Text <> "0" Then
            Num.Text += "4"
        Else
            Num.Text = "4"
        End If
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        If Num.Text <> "0" Then
            Num.Text += "5"
        Else
            Num.Text = "5"
        End If
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        If Num.Text <> "0" Then
            Num.Text += "6"
        Else
            Num.Text = "6"
        End If
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        If Num.Text <> "0" Then
            Num.Text += "7"
        Else
            Num.Text = "7"
        End If
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        If Num.Text <> "0" Then
            Num.Text += "8"
        Else
            Num.Text = "8"
        End If
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        If Num.Text <> "0" Then
            Num.Text += "9"
        Else
            Num.Text = "9"
        End If
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If Num.Text <> "0" Then
            Num.Text += "0"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Num.Clear()
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If Num.Text <> "0" Or Not (Num.Text.Contains(".")) Then
            Num.Text += "."
        Else
            Num.Text = "0"
        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Try
            Num1 = Num.Text
            Num.Text = "0"
            Operate = 2
        Catch ex As Exception
            Num.Text = "Error"
        End Try

    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Try
            Num1 = Num.Text
            Num.Text = "0"
            Operate = 3
        Catch ex As Exception
            Num.Text = "Error"
        End Try

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Try
            Num1 = Num.Text
            Num.Text = "0"
            Operate = 4
        Catch ex As Exception
            Num.Text = "Error"
        End Try

    End Sub
End Class
