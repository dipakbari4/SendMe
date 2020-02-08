Friend Module Modules
	Private messageType As MsgBoxStyle

	''' <summary>
	''' Custom parametric message box.
	''' <list type="bullet">Option 1: Information</list>
	''' <list type="bullet">Option 2: Exclamation</list>
	''' <list type="bullet">Option 3: Critical</list>
	''' </summary>
	''' 
	''' <param name="message">Gets the message string.</param>
	''' <param name="type">Gets the type of message.</param>
	Public Sub Message(message As String, header As String, type As Short)
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
End Module
