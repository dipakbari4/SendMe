Friend Module Settings
	''' <summary>
	''' Executes the containing code in startup of the application.
	''' </summary>
	Public Sub InitiateServices()
		Message("This application has successfully started.", "Application", 1)

		Main.Refresher.Start()
	End Sub
End Module
