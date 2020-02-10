Friend Module NetworkConnectivity
	Private Const IP As String = "172.217.26.196" ' Google's IP

	''' <summary>
	''' Checks and returns the network connectivity as Boolean.
	''' </summary>
	Public ReadOnly Property DoPing As Boolean
		Get
			Try
				If My.Computer.Network.Ping(IP, 1000) Then
					' Ping OK
					Return True
				Else
					' Internet unreachable
					Return False
				End If

			Catch ex As Exception
				' Ping failed before attempting
				Return False
			End Try
		End Get
	End Property

	''' <summary>
	''' Custom activity script to check the internet connection.
	''' </summary>
	Public Sub VerifyNetwork()
		If My.Computer.Network.IsAvailable Then
			If DoPing Then
				Status("Connection successful")
			Else
				Status("Network is unreachable", 2)
			End If
		Else
			Status("Network is disconnected", 3)
		End If
	End Sub
End Module
