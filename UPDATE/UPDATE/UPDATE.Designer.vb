<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UPDATE
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UPDATE))
		Me.ProgressBar = New System.Windows.Forms.ProgressBar()
		Me.NotesLabel = New System.Windows.Forms.Label()
		Me.ProgressBarPanel = New System.Windows.Forms.Panel()
		Me.BackgroundProgressBarPanel = New System.Windows.Forms.Panel()
		Me.RéduireButton = New System.Windows.Forms.Button()
		Me.ProgressBarPanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'ProgressBar
		'
		Me.ProgressBar.BackColor = System.Drawing.Color.Green
		Me.ProgressBar.ForeColor = System.Drawing.Color.Black
		Me.ProgressBar.Location = New System.Drawing.Point(-6, -2)
		Me.ProgressBar.Name = "ProgressBar"
		Me.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ProgressBar.Size = New System.Drawing.Size(682, 24)
		Me.ProgressBar.Step = 1
		Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
		Me.ProgressBar.TabIndex = 0
		'
		'NotesLabel
		'
		Me.NotesLabel.AutoSize = True
		Me.NotesLabel.BackColor = System.Drawing.Color.Transparent
		Me.NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NotesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.NotesLabel.Location = New System.Drawing.Point(4, 2)
		Me.NotesLabel.Name = "NotesLabel"
		Me.NotesLabel.Size = New System.Drawing.Size(222, 16)
		Me.NotesLabel.TabIndex = 1
		Me.NotesLabel.Text = "UPDATE - EASYMINESERVER"
		'
		'ProgressBarPanel
		'
		Me.ProgressBarPanel.BackColor = System.Drawing.Color.Black
		Me.ProgressBarPanel.Controls.Add(Me.ProgressBar)
		Me.ProgressBarPanel.ForeColor = System.Drawing.Color.Black
		Me.ProgressBarPanel.Location = New System.Drawing.Point(8, 28)
		Me.ProgressBarPanel.Name = "ProgressBarPanel"
		Me.ProgressBarPanel.Size = New System.Drawing.Size(670, 20)
		Me.ProgressBarPanel.TabIndex = 2
		'
		'BackgroundProgressBarPanel
		'
		Me.BackgroundProgressBarPanel.BackColor = System.Drawing.Color.Black
		Me.BackgroundProgressBarPanel.ForeColor = System.Drawing.Color.DarkRed
		Me.BackgroundProgressBarPanel.Location = New System.Drawing.Point(4, 25)
		Me.BackgroundProgressBarPanel.Name = "BackgroundProgressBarPanel"
		Me.BackgroundProgressBarPanel.Size = New System.Drawing.Size(674, 27)
		Me.BackgroundProgressBarPanel.TabIndex = 3
		'
		'RéduireButton
		'
		Me.RéduireButton.BackColor = System.Drawing.Color.Transparent
		Me.RéduireButton.BackgroundImage = Global.UPDATE.My.Resources.Resources.Hide_default
		Me.RéduireButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.RéduireButton.Cursor = System.Windows.Forms.Cursors.Default
		Me.RéduireButton.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.RéduireButton.FlatAppearance.BorderSize = 0
		Me.RéduireButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.RéduireButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.RéduireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.RéduireButton.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RéduireButton.ForeColor = System.Drawing.Color.Black
		Me.RéduireButton.Location = New System.Drawing.Point(503, -2)
		Me.RéduireButton.Name = "RéduireButton"
		Me.RéduireButton.Size = New System.Drawing.Size(29, 23)
		Me.RéduireButton.TabIndex = 4
		Me.RéduireButton.TabStop = False
		Me.RéduireButton.UseVisualStyleBackColor = False
		'
		'UPDATE
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(690, 63)
		Me.Controls.Add(Me.RéduireButton)
		Me.Controls.Add(Me.ProgressBarPanel)
		Me.Controls.Add(Me.NotesLabel)
		Me.Controls.Add(Me.BackgroundProgressBarPanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "UPDATE"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "UPDATE"
		Me.ProgressBarPanel.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents NotesLabel As System.Windows.Forms.Label
    Friend WithEvents ProgressBarPanel As System.Windows.Forms.Panel
    Friend WithEvents BackgroundProgressBarPanel As System.Windows.Forms.Panel
    Friend WithEvents RéduireButton As System.Windows.Forms.Button

End Class
