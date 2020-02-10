Friend Module LifetimeModules
	Private messageType As MsgBoxStyle
	Private tIcon As ToolTipIcon
	Private color As Color

	''' <summary>
	''' Custom parametric message box.
	''' <list type="bullet">Option 1: Information</list>
	''' <list type="bullet">Option 2: Exclamation</list>
	''' <list type="bullet">Option 3: Critical</list>
	''' </summary>
	''' 
	''' <param name="message">Gets the message string.</param>
	''' <param name="type">Gets the type of message.</param>
	Public Sub Message(message As String, header As String, Optional type As Short = 1)
		Select Case type
			Case 1
				messageType = MsgBoxStyle.Information
			Case 2
				messageType = MsgBoxStyle.Exclamation
			Case 3
				messageType = MsgBoxStyle.Critical
			Case Else
				Exit Select
		End Select

		MsgBox(message, messageType, header)
	End Sub

	''' <summary>
	''' Sets the Status Text message located at bottom of the app.
	''' <list type="bullet">1: Default</list>
	''' <list type="bullet">2: Orange</list>
	''' <list type="bullet">3: Red</list>
	''' </summary>
	''' 
	''' <param name="statusMessage">Sets the Status Message for StatusLabel.</param>
	''' <param name="statusType">Sets some specific colors for StatusLabel.</param>
	Public Sub Status(statusMessage As String, Optional statusType As Short = 1)
		Select Case statusType
			Case 1
				' Normal - Default
				color = Color.Silver
			Case 2
				' Warning - Orange
				color = Color.Orange
			Case 3
				' Error - Red (Tomato)
				color = Color.Tomato
		End Select

		Main.StatusLabel.Text = statusMessage
		Main.StatusLabel.ForeColor = color
	End Sub

	''' <summary>
	''' Windows notifier of Notification Bar.
	''' </summary>
	''' <param name="body">The body string for the notification</param>
	''' <param name="header">The header of the notification</param>
	''' <param name="icon">Type of notification</param>
	Public Sub ShowNotify(body As String, header As String, Optional icon As Short = 1)
		Select Case icon
			Case 1
				' Info
				tIcon = ToolTipIcon.Info
			Case 2
				' Warning
				tIcon = ToolTipIcon.Warning
			Case 3
				' Error
				tIcon = ToolTipIcon.Error
			Case Else
				Exit Select
		End Select

		With Main.Notifier
			.Visible = True
			.Icon = Main.Icon
			.ShowBalloonTip(3000, header, body, tIcon)
		End With
	End Sub
End Module
