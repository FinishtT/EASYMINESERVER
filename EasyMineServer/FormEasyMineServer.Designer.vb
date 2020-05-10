<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEasyMineServer
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEasyMineServer))
		Me.Button1 = New System.Windows.Forms.Button()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.BWSTARTSERVER = New System.ComponentModel.BackgroundWorker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.TimerCPU = New System.Windows.Forms.Timer(Me.components)
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TimerMEM = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Transparent
		Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(76, 39)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(535, 32)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Launch the server"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'RichTextBox1
		'
		Me.RichTextBox1.BackColor = System.Drawing.Color.Black
		Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.RichTextBox1.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RichTextBox1.ForeColor = System.Drawing.Color.White
		Me.RichTextBox1.Location = New System.Drawing.Point(12, 191)
		Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.ReadOnly = True
		Me.RichTextBox1.Size = New System.Drawing.Size(671, 171)
		Me.RichTextBox1.TabIndex = 3
		Me.RichTextBox1.Text = ""
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(9, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(133, 16)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Processor: 0%"
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.Black
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox1.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.ForeColor = System.Drawing.Color.White
		Me.TextBox1.Location = New System.Drawing.Point(12, 368)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.Size = New System.Drawing.Size(674, 25)
		Me.TextBox1.TabIndex = 7
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.Transparent
		Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.White
		Me.Button2.Location = New System.Drawing.Point(570, 403)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(116, 36)
		Me.Button2.TabIndex = 8
		Me.Button2.Text = "Send"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Timer2
		'
		'
		'BWSTARTSERVER
		'
		Me.BWSTARTSERVER.WorkerReportsProgress = True
		Me.BWSTARTSERVER.WorkerSupportsCancellation = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(12, 403)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(81, 16)
		Me.Label2.TabIndex = 10
		Me.Label2.Text = "Local ip:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(12, 428)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(87, 16)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "Public ip:"
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Transparent
		Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
		Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
		Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.ForeColor = System.Drawing.Color.White
		Me.Button4.Location = New System.Drawing.Point(76, 115)
		Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(535, 32)
		Me.Button4.TabIndex = 13
		Me.Button4.Text = "Options"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'TimerCPU
		'
		Me.TimerCPU.Interval = 1000
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(100, 428)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(48, 16)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "????"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(100, 403)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(48, 16)
		Me.Label5.TabIndex = 15
		Me.Label5.Text = "????"
		'
		'Button5
		'
		Me.Button5.BackColor = System.Drawing.Color.Transparent
		Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
		Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
		Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button5.ForeColor = System.Drawing.Color.White
		Me.Button5.Location = New System.Drawing.Point(76, 77)
		Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(535, 32)
		Me.Button5.TabIndex = 17
		Me.Button5.Text = "Server.Properties"
		Me.Button5.UseVisualStyleBackColor = False
		'
		'Button6
		'
		Me.Button6.BackColor = System.Drawing.Color.Transparent
		Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
		Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
		Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
		Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button6.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button6.ForeColor = System.Drawing.Color.White
		Me.Button6.Location = New System.Drawing.Point(76, 153)
		Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(535, 32)
		Me.Button6.TabIndex = 18
		Me.Button6.Text = "About"
		Me.Button6.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(599, 9)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(86, 16)
		Me.Label6.TabIndex = 19
		Me.Label6.Text = "MEM : 0%"
		Me.Label6.Visible = False
		'
		'TimerMEM
		'
		Me.TimerMEM.Interval = 1000
		'
		'FormEasyMineServer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(700, 451)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.RichTextBox1)
		Me.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ForeColor = System.Drawing.Color.White
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.MaximizeBox = False
		Me.Name = "FormEasyMineServer"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "EasyMineServer"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents Timer2 As System.Windows.Forms.Timer
	Friend WithEvents BWSTARTSERVER As System.ComponentModel.BackgroundWorker
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Button4 As System.Windows.Forms.Button
	Friend WithEvents TimerCPU As System.Windows.Forms.Timer
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Button5 As System.Windows.Forms.Button
	Friend WithEvents Button6 As System.Windows.Forms.Button
	Friend WithEvents Label6 As Label
	Friend WithEvents TimerMEM As Timer
End Class
