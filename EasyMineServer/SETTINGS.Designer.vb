<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SETTINGS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SETTINGS))
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.CheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.CheckBox1.Location = New System.Drawing.Point(90, 114)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(182, 20)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Active sound alert"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheckBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.CheckBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CheckBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.DarkGray
        Me.CheckBox3.Location = New System.Drawing.Point(90, 63)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(163, 20)
        Me.CheckBox3.TabIndex = 15
        Me.CheckBox3.TabStop = False
        Me.CheckBox3.Text = "Show Processor"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Minecraft", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkGray
        Me.Button1.Location = New System.Drawing.Point(157, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 26)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Language: English"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheckBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.CheckBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CheckBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.CheckBox2.Location = New System.Drawing.Point(90, 88)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(111, 20)
        Me.CheckBox2.TabIndex = 18
        Me.CheckBox2.TabStop = False
        Me.CheckBox2.Text = "Show RAM"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'SETTINGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(351, 218)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "SETTINGS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyMineServer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox

End Class
