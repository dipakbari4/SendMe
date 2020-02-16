<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
		Me.Refresher = New System.Windows.Forms.Timer(Me.components)
		Me.Notifier = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.StatusBar = New System.Windows.Forms.StatusStrip()
		Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.HelpText = New System.Windows.Forms.ToolTip(Me.components)
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
		Me.UpdateNetwork = New System.Windows.Forms.Timer(Me.components)
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TrackBar1 = New System.Windows.Forms.TrackBar()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
		Me.NetworkWaiter = New System.Windows.Forms.Timer(Me.components)
		Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
		Me.StatusBar.SuspendLayout()
		CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Refresher
		'
		Me.Refresher.Interval = 1000
		'
		'Notifier
		'
		Me.Notifier.Text = "SendMe"
		Me.Notifier.Visible = True
		'
		'StatusBar
		'
		Me.StatusBar.BackColor = System.Drawing.Color.DimGray
		Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
		Me.StatusBar.Location = New System.Drawing.Point(0, 239)
		Me.StatusBar.Name = "StatusBar"
		Me.StatusBar.Size = New System.Drawing.Size(384, 22)
		Me.StatusBar.SizingGrip = False
		Me.StatusBar.TabIndex = 0
		Me.StatusBar.Text = "Status"
		'
		'StatusLabel
		'
		Me.StatusLabel.ForeColor = System.Drawing.Color.Silver
		Me.StatusLabel.Name = "StatusLabel"
		Me.StatusLabel.Size = New System.Drawing.Size(109, 17)
		Me.StatusLabel.Text = "Status appears here"
		'
		'HelpText
		'
		Me.HelpText.BackColor = System.Drawing.Color.DimGray
		Me.HelpText.ForeColor = System.Drawing.Color.Silver
		Me.HelpText.StripAmpersands = True
		Me.HelpText.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.HelpText.ToolTipTitle = "Info"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(170, Byte), Integer))
		Me.Button1.Enabled = False
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(272, 43)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(100, 25)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Upload File"
		Me.HelpText.SetToolTip(Me.Button1, "Upload the specified file to share.")
		Me.Button1.UseVisualStyleBackColor = False
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.DimGray
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.TextBox1.ForeColor = System.Drawing.Color.Silver
		Me.TextBox1.Location = New System.Drawing.Point(12, 43)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.Size = New System.Drawing.Size(254, 25)
		Me.TextBox1.TabIndex = 1
		Me.HelpText.SetToolTip(Me.TextBox1, "The file to be shared.")
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.ForeColor = System.Drawing.Color.Silver
		Me.Label1.Location = New System.Drawing.Point(9, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(176, 15)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Please specify the file to upload:"
		'
		'OpenFile
		'
		Me.OpenFile.Title = "Choose a file to upload..."
		'
		'UpdateNetwork
		'
		Me.UpdateNetwork.Interval = 15000
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.Silver
		Me.Label2.Location = New System.Drawing.Point(12, 193)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 15)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Refresh per:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.Silver
		Me.Label3.Location = New System.Drawing.Point(9, 79)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(86, 15)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "File Size Details"
		Me.Label3.Visible = False
		'
		'TrackBar1
		'
		Me.TrackBar1.LargeChange = 10
		Me.TrackBar1.Location = New System.Drawing.Point(87, 191)
		Me.TrackBar1.Maximum = 60
		Me.TrackBar1.Minimum = 10
		Me.TrackBar1.Name = "TrackBar1"
		Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
		Me.TrackBar1.SmallChange = 10
		Me.TrackBar1.TabIndex = 5
		Me.TrackBar1.TickFrequency = 10
		Me.TrackBar1.Value = 30
		'
		'Label4
		'
		Me.Label4.ForeColor = System.Drawing.Color.Silver
		Me.Label4.Location = New System.Drawing.Point(197, 193)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(175, 43)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "seconds. Press Enter or drag the cursor to update."
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(170, Byte), Integer))
		Me.LinkLabel1.Location = New System.Drawing.Point(287, 79)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(85, 15)
		Me.LinkLabel1.TabIndex = 4
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "Setup Network"
		Me.LinkLabel1.Visible = False
		'
		'LinkLabel2
		'
		Me.LinkLabel2.AutoSize = True
		Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(170, Byte), Integer))
		Me.LinkLabel2.Location = New System.Drawing.Point(266, 79)
		Me.LinkLabel2.Name = "LinkLabel2"
		Me.LinkLabel2.Size = New System.Drawing.Size(106, 15)
		Me.LinkLabel2.TabIndex = 3
		Me.LinkLabel2.TabStop = True
		Me.LinkLabel2.Text = "Wait for a Network"
		Me.LinkLabel2.Visible = False
		'
		'NetworkWaiter
		'
		Me.NetworkWaiter.Interval = 5000
		'
		'LinkLabel3
		'
		Me.LinkLabel3.AutoSize = True
		Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(170, Byte), Integer))
		Me.LinkLabel3.Location = New System.Drawing.Point(191, 17)
		Me.LinkLabel3.Name = "LinkLabel3"
		Me.LinkLabel3.Size = New System.Drawing.Size(86, 15)
		Me.LinkLabel3.TabIndex = 9
		Me.LinkLabel3.TabStop = True
		Me.LinkLabel3.Text = "About SendMe"
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(384, 261)
		Me.Controls.Add(Me.LinkLabel3)
		Me.Controls.Add(Me.LinkLabel2)
		Me.Controls.Add(Me.LinkLabel1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.TrackBar1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.StatusBar)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Main"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SendMe"
		Me.StatusBar.ResumeLayout(False)
		Me.StatusBar.PerformLayout()
		CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Refresher As Timer
	Friend WithEvents Notifier As NotifyIcon
	Friend WithEvents StatusBar As StatusStrip
	Friend WithEvents StatusLabel As ToolStripStatusLabel
	Friend WithEvents HelpText As ToolTip
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents OpenFile As OpenFileDialog
	Friend WithEvents UpdateNetwork As Timer
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents TrackBar1 As TrackBar
	Friend WithEvents Label4 As Label
	Friend WithEvents LinkLabel1 As LinkLabel
	Friend WithEvents LinkLabel2 As LinkLabel
	Friend WithEvents NetworkWaiter As Timer
	Friend WithEvents LinkLabel3 As LinkLabel
End Class
