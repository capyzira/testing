Public Class Form1
    Private Sub btnCALC_Click(sender As Object, e As EventArgs) Handles btnCALC.Click
        'Declare variable and store value
        Dim users As Double
        'sydney = 1499
        'london = 1899
        'penang = 199
        ' dubai = 1299
        'seoul = 1499
        'kuching = 399


        If rdbDubai.Checked Then
            users = 1299
        ElseIf rdbKuching.Checked Then
            users = 399
        ElseIf rdbLondon.Checked Then
            users = 1899
        ElseIf rdbPenang.Checked Then
            users = 199
        ElseIf rdbSeoul.Checked Then
            users = 1499
        ElseIf rdbSydney.Checked Then
            users = 1499
        Else
            MessageBox.Show("Please select destination provided", "Select destination", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If chkReturn.Checked Then
            users = users * 2
        End If

        If chkHoneymoon.Checked Then
            users = users * 2 - (0.3 * users * 2)
        End If

        If chkTourist.Checked Then
            users = users + 500
        End If

        users = Format(users, "currency")
        MessageBox.Show("Your travelling cost is " & users, "Thank you for choosing our services", MessageBoxButtons.OK)
        lblTotal.Text = Format(users, "currency")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rdbDubai.Checked = False
        rdbKuching.Checked = False
        rdbLondon.Checked = False
        rdbPenang.Checked = False
        rdbSeoul.Checked = False
        rdbSydney.Checked = False

        chkHoneymoon.Checked = False
        chkReturn.Checked = False
        chkTourist.Checked = False

        txtName.Clear()
        txtPhoneNumber.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub



End Class
