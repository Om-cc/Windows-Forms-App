Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        ' Create an instance of the CreateSubmissionForm
        Dim createForm As New CreateSubmissionForm()
        ' Show the CreateSubmissionForm
        createForm.Show()
    End Sub
    ' This event handler is created when you double-click on the "View Submissions" button
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ' Create an instance of the ViewSubmissionsForm
        Dim viewForm As New ViewSubmissionsForm()
        ' Show the ViewSubmissionsForm
        viewForm.Show()
    End Sub
End Class
