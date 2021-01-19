Public Class Form1

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim intTraining As Integer

        If (radAssembly.Checked = True) Then
            intTraining = 1
        ElseIf (radCashier.Checked = True) Then
            intTraining = 2
        ElseIf (radTraining.Checked = True) Then
            intTraining = 3
        ElseIf (radManagement.Checked = True) Then
            intTraining = 4
        End If

        Select Case intTraining
            Case 1
                lblTraining.Text = "You have completed the Introductory Burger Assembly training"

            Case 2
                lblTraining.Text = "You have completed the Introductory Cashier Skills training"

            Case 3
                lblTraining.Text = "You have completed the Introductory Training Employees training"

            Case 4
                lblTraining.Text = "You have completed the Introductory Restaurant Managment"

        End Select

    End Sub

    Private Sub btnRequst_Click(sender As Object, e As EventArgs) Handles btnRequst.Click
        Dim intPromotion As Integer

        Randomize()
        intPromotion = Int(Rnd() * 10) + 1

        If (radAssembly.Checked = True) Or (radCashier.Checked = True) Then
            MessageBox.Show("You are promoted!")

        ElseIf (radTraining.Checked = True) And (intPromotion > 7) Then
            MessageBox.Show("Promoted to Crew Trainer")

        ElseIf (radManagement.Checked = True) And (intPromotion >= 8) Then
            MessageBox.Show("Promoted to Restaurant Manager!")
        End If

    End Sub
End Class
