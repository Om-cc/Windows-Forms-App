Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStartPause.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGitHubLink.Text,
            .StopwatchTime = stopwatch.Elapsed.ToString()
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission Successful")
            Else
                MessageBox.Show("Submission Failed")
            End If
        End Using
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class
