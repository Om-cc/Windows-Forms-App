<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        btnStartPause = New Button()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(233, 100)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(254, 31)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(233, 160)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(254, 31)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(233, 216)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "Phone Number"
        txtPhone.Size = New Size(254, 31)
        txtPhone.TabIndex = 2
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(233, 269)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.PlaceholderText = "GitHub Repo Link"
        txtGitHubLink.Size = New Size(254, 31)
        txtGitHubLink.TabIndex = 3
        ' 
        ' btnStartPause
        ' 
        btnStartPause.BackColor = Color.LightSalmon
        btnStartPause.Location = New Point(208, 339)
        btnStartPause.Name = "btnStartPause"
        btnStartPause.Size = New Size(112, 34)
        btnStartPause.TabIndex = 4
        btnStartPause.Text = "Start/Stop"
        btnStartPause.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(375, 339)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(112, 34)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartPause)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents btnStartPause As Button
    Friend WithEvents btnSubmit As Button
End Class
