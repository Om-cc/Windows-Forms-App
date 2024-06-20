<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCreateNewSubmission = New Button()
        btnViewSubmissions = New Button()
        SuspendLayout()
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.Location = New Point(142, 59)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(243, 34)
        btnCreateNewSubmission.TabIndex = 0
        btnCreateNewSubmission.Text = "Create New Submission"
        btnCreateNewSubmission.UseVisualStyleBackColor = True
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.Location = New Point(457, 59)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(272, 34)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "View Submissions"
        btnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnCreateNewSubmission)
        Name = "Form1"
        Text = "Form Submission App"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents btnViewSubmissions As Button

End Class
