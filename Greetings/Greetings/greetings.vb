Public Class Greetings
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        MessageBox.Show("Thank You")
        'Print greetings to listbox
        lstOut.Items.Add("Happy Birthday to You, Happy Birthday to You")
        lstOut.Items.Add("Happy Birthday to You " & txtName.Text)


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear txtName value
        txtName.Clear()
        lstOut.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'when user exits the program
        'Beep()
        Application.Exit()
    End Sub

    Private Sub picGreeting_Click(sender As Object, e As EventArgs) Handles picGreeting.Click

    End Sub

    Private Sub lstOut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOut.SelectedIndexChanged

    End Sub

    Private Sub lblHeading_Click(sender As Object, e As EventArgs) Handles lblHeading.Click


    End Sub
End Class
