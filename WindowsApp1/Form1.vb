Public Class Form1
    Dim Alpha As Decimal
    Dim Beta As Decimal
    Dim result As Decimal
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsNumeric(numBeta.Text) = True And IsNumeric(numAlpha.Text) = True Then
            Alpha = numAlpha.Text
            Beta = numBeta.Text
            result = Alpha + Beta
            txtResult.Text = result
        Else MsgBox("imput a decimal number")

        End If
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If IsNumeric(numBeta.Text) = True And IsNumeric(numAlpha.Text) = True Then
            Alpha = numAlpha.Text
            Beta = numBeta.Text
            result = Alpha - Beta
            txtResult.Text = result
        Else MsgBox("imput a decimal number")

        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If IsNumeric(numBeta.Text) = True And IsNumeric(numAlpha.Text) = True Then
            Alpha = numAlpha.Text
            Beta = numBeta.Text
            result = Alpha * Beta
            txtResult.Text = result
        Else MsgBox("imput a decimal number")

        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If IsNumeric(numBeta.Text) = True And IsNumeric(numAlpha.Text) = True Then
            Alpha = numAlpha.Text
            Beta = numBeta.Text
            result = Alpha / Beta
            txtResult.Text = result
        Else MsgBox("imput a decimal number")

        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnInt_Click(sender As Object, e As EventArgs) Handles btnInt.Click
        If IsNumeric(numBeta.Text) = True And IsNumeric(numAlpha.Text) = True Then
            Alpha = numAlpha.Text
            Beta = numBeta.Text
            result = Alpha \ Beta
            txtResult.Text = result
        Else MsgBox("imput a decimal number")

        End If
    End Sub

    Private Sub btnRemainer_Click(sender As Object, e As EventArgs) Handles btnRemainer.Click
        If IsNumeric(numBeta.Text) = True And IsNumeric(numAlpha.Text) = True Then
            Alpha = numAlpha.Text
            Beta = numBeta.Text
            result = Alpha Mod Beta
            txtResult.Text = result
        Else MsgBox("imput a decimal number")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExponentiation.Click
        If IsNumeric(numBeta.Text) = True And IsNumeric(numAlpha.Text) = True Then
            Alpha = numAlpha.Text
            Beta = numBeta.Text
            result = Alpha ^ Beta
            txtResult.Text = result
        Else MsgBox("imput a decimal number")

        End If
    End Sub

    Private Sub btnConcatenation_Click(sender As Object, e As EventArgs) Handles btnConcatenation.Click
        If IsNumeric(numBeta.Text) = True And IsNumeric(numAlpha.Text) = True Then
            Alpha = numAlpha.Text
            Beta = numBeta.Text
            result = Alpha & Beta
            txtResult.Text = result
        Else MsgBox("imput a decimal number")

        End If
    End Sub
End Class
