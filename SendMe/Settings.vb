Friend Module Settings
	Private status As String

	''' <summary>
	''' Executes the containing code before startup of the application.
	''' </summary>
	Public Sub InitiateServices()
		With Main
			.Refresher.Start()
			.UpdateNetwork.Start()

			.OpenFile.InitialDirectory =
				My.Computer.FileSystem.SpecialDirectories.Desktop
		End With

		VerifyNetwork()
	End Sub
End Module
