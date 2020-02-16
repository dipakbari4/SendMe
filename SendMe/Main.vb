Imports System.IO

Public Class Main
	Private selected As Short
	Private file As FileStream
	Private fileSize As Double
	Private ReadOnly tScript As New TransferScript

	' ----- Startup & Main activities --------------------
	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		InitiateServices()
	End Sub

	Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
		If WindowState = FormWindowState.Minimized Then
			trigger = True
			ShowNotify("The application is still running in the background.",
					   "SendMe is still running")
			ShowInTaskbar = False
		End If
	End Sub

	' ----- Optional code starts from here --------------------
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If Not DoPing Then
			Message("The network connection is having some troubles." +
					" Please try again shortly.", "Network Error", 3)
			Return
		End If

		If IO.File.Exists(filePath) Then
		Else
			Message("The file path: " + vbCrLf + filePath +
					" was moved from the its place. Please select again.",
					"File Not Found", 3)
			OpenFile.ShowDialog()
		End If

		tScript.Sender(filePath)
	End Sub

	Private Sub Refresher_Tick(sender As Object, e As EventArgs) Handles Refresher.Tick
		Notifier.Visible = trigger

		Try
			If Not IO.File.Exists(Application.ExecutablePath) Then
				Refresher.Stop()

				Message("The SendMe was removed from the executive place.",
						"External Activity Detected")
			End If
		Catch ex As Exception
			' Silence
		End Try
	End Sub

	Private Sub UpdateNetwork_Tick(sender As Object, e As EventArgs) Handles UpdateNetwork.Tick
		VerifyNetwork()
	End Sub

	Private Sub Notifier_DoubleClick(sender As Object, e As EventArgs) Handles Notifier.DoubleClick, Notifier.BalloonTipClicked
		trigger = False
		ShowInTaskbar = True
		WindowState = FormWindowState.Normal
	End Sub

	Private Sub OpenFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFile.FileOk
		TextBox1.Text = OpenFile.FileName.ToString
	End Sub

	Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
		OpenFile.ShowDialog()
	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		Button1.Enabled = sender.ToString.Length > 0
		filePath = sender.Text.ToString
		Label3.Visible = True
		file = IO.File.Open(filePath, FileMode.Open)
		fileSize = file.Length()

		If fileSize > 1024 ^ 3 Then
			Label3.Text = "File Size: " + Format(fileSize / 1024 ^ 3, "0.00").ToString + " GB"
		ElseIf fileSize > 1024 ^ 2 Then
			Label3.Text = "File Size: " + Format(fileSize / 1024 ^ 2, "0.00").ToString + " MB"
		ElseIf fileSize > 1024 Then
			Label3.Text = "File Size: " + Format(fileSize / 1024, "0.00").ToString + " KB"
		Else
			Label3.Text = "File Size: " + Format(file, "0").ToString + " Byte"

			If fileSize > 1 Then
				Label3.Text += "s"
			End If
		End If

		HelpText.SetToolTip(TextBox1, "The file will be uploaded: """ +
			Path.GetFileName(filePath) + """ from " + vbCrLf +
			  Path.GetDirectoryName(filePath))
		file.Close()
	End Sub

	Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
		HelpText.SetToolTip(TrackBar1, "Value: " + sender.Value.ToString)

		If sender.Value = UpdateNetwork.Interval Then
			HelpText.SetToolTip(TrackBar1, "Current Value: " + sender.Value.ToString)
		End If
	End Sub

	Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp
		UpdateInterval()
	End Sub

	Private Sub TrackBar1_KeyDown(sender As Object, e As KeyEventArgs) Handles TrackBar1.KeyDown
		If e.KeyCode = Keys.Enter Then
			UpdateInterval()
		End If
	End Sub

	Private Sub UpdateInterval()
		selected = TrackBar1.Value

		If selected * 1000 = UpdateNetwork.Interval Then
			Return
		Else
			UpdateNetwork.Interval = selected * 1000
		End If

		Message("The for network update interval is set to: " +
				selected.ToString + " seconds.", "Interval Updated", 1)
	End Sub

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

	End Sub

	Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
		Message("You should get notified as soon as network will start responding.",
				"Network Waiter")

		WindowState = FormWindowState.Minimized
		NetworkWaiter.Start()
		Status("Network Waiter has been started!")
	End Sub

	Private Sub NetworkWaiter_Tick(sender As Object, e As EventArgs) Handles NetworkWaiter.Tick
		If DoPing = True Then
			ShowNotify("Network is back! Let us have some party.", "Internet is Back")
			WindowState = FormWindowState.Normal
			NetworkWaiter.Stop()
		End If
	End Sub

	Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
		About.ShowDialog()
	End Sub
End Class
