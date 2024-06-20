Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        currentIndex -= 1
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(json)
                DisplaySubmission(submission)
            Else
                MessageBox.Show("Failed to load submission")
            End If
        End Using
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        lblName.Text = submission.Name
        lblEmail.Text = submission.Email
        lblPhone.Text = submission.Phone
        lblGitHubLink.Text = submission.GitHubLink
        lblStopwatchTime.Text = submission.StopwatchTime
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnPrevious.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
