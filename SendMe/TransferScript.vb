Public Class TransferScript
	''' <summary>
	''' Sender class for a binary file to another host.
	''' </summary>
	Public Sub Sender(path As String)
		asker = MsgBox("The file will be uploaded: """ + IO.Path.GetFileName(path) + " from """ +
					   vbCrLf + IO.Path.GetDirectoryName(path) + ", are you sure?",
					   MsgBoxStyle.YesNo, "Confirm Upload")

		Select Case asker
			Case MsgBoxResult.Yes
				Message("The file will be uploaded.", "Upload Started")
			Case Else
				Exit Select
		End Select
	End Sub

	''' <summary>
	''' Receiver class to receive the binary data from Sender.
	''' </summary>
	Public Sub Receiver()

	End Sub
End Class
