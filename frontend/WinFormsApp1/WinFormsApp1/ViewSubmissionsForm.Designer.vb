<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnNext = New Button()
        btnPrevious = New Button()
        lblName = New TextBox()
        lblEmail = New TextBox()
        lblGitHubLink = New TextBox()
        lblStopwatchTime = New TextBox()
        lblPhone = New TextBox()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(509, 336)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(112, 34)
        btnNext.TabIndex = 0
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(98, 336)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(112, 34)
        btnPrevious.TabIndex = 1
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' lblName
        ' 
        lblName.Location = New Point(236, 32)
        lblName.Name = "lblName"
        lblName.PlaceholderText = "Name"
        lblName.Size = New Size(280, 31)
        lblName.TabIndex = 2
        ' 
        ' lblEmail
        ' 
        lblEmail.Location = New Point(236, 89)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(280, 31)
        lblEmail.TabIndex = 3
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.Location = New Point(236, 194)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(280, 31)
        lblGitHubLink.TabIndex = 4
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.Location = New Point(236, 249)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(280, 31)
        lblStopwatchTime.TabIndex = 5
        ' 
        ' lblPhone
        ' 
        lblPhone.Location = New Point(236, 143)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(280, 31)
        lblPhone.TabIndex = 6
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblPhone)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(btnPrevious)
        Controls.Add(btnNext)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblName As TextBox
    Friend WithEvents lblEmail As TextBox
    Friend WithEvents lblGitHubLink As TextBox
    Friend WithEvents lblStopwatchTime As TextBox
    Friend WithEvents lblPhone As TextBox
End Class
