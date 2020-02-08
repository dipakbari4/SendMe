Public Class TransferScript
	''' <summary>
	''' Sender class for a binary file to another host.
	''' </summary>
	Public Sub Sender()

	End Sub

	''' <summary>
	''' Receiver class to receive the binary data from Sender.
	''' </summary>
	Public Sub Receive()

	End Sub

	' ----- Override statements --------------------
	Protected Overrides Sub Finalize()
		MyBase.Finalize()
	End Sub

	Public Overrides Function ToString() As String
		Return MyBase.ToString()
	End Function

	Public Overrides Function Equals(obj As Object) As Boolean
		Return MyBase.Equals(obj)
	End Function

	Public Overrides Function GetHashCode() As Integer
		Return MyBase.GetHashCode()
	End Function
End Class
