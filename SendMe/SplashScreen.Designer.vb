﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.SplashClock = New System.Windows.Forms.Timer(Me.components)
		Me.Label5 = New System.Windows.Forms.Label()
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
		Me.PictureBox1.TabIndex = 0
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
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "SendMe"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(119, 57)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(190, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "POWERED BY LXM COMPANY, INC."
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.Label3.Location = New System.Drawing.Point(12, 162)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(424, 25)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "LET'S START FREE SHARING!"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.Label4.Location = New System.Drawing.Point(394, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(54, 19)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "Version"
		'
		'SplashClock
		'
		Me.SplashClock.Interval = 3000
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(92, 324)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(264, 15)
		Me.Label5.TabIndex = 5
		Me.Label5.Text = "Copyright © LinuX Man 2020. All rights reserved."
		'
		'SplashScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(448, 348)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.ForeColor = System.Drawing.Color.Silver
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "SplashScreen"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.TopMost = True
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents SplashClock As Timer
	Friend WithEvents Label5 As Label
End Class
