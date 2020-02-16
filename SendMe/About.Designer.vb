<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.InitialImage = Nothing
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(96, 96)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(170, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(114, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(137, 45)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "SendMe"
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(12, 156)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(410, 75)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "The SendMe software is designed in that way where it installs its own network and" &
	" let everybody connects through it for file sharing without requiring any networ" &
	"k connection."
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(119, 57)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(129, 15)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Let's Start Free Sharing!"
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(170, Byte), Integer))
		Me.LinkLabel1.Location = New System.Drawing.Point(166, 231)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(64, 15)
		Me.LinkLabel1.TabIndex = 10
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "LinuX Man"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 231)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(148, 15)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Saw bugs? Contact author:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(12, 254)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(128, 15)
		Me.Label5.TabIndex = 12
		Me.Label5.Text = "View copyright license:"
		'
		'LinkLabel2
		'
		Me.LinkLabel2.AutoSize = True
		Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(170, Byte), Integer))
		Me.LinkLabel2.Location = New System.Drawing.Point(166, 254)
		Me.LinkLabel2.Name = "LinkLabel2"
		Me.LinkLabel2.Size = New System.Drawing.Size(69, 15)
		Me.LinkLabel2.TabIndex = 13
		Me.LinkLabel2.TabStop = True
		Me.LinkLabel2.Text = "MIT License"
		'
		'About
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(434, 311)
		Me.Controls.Add(Me.LinkLabel2)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.LinkLabel1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.ForeColor = System.Drawing.Color.Silver
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "About"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "About SendMe"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents LinkLabel1 As LinkLabel
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents LinkLabel2 As LinkLabel
End Class
