Public Class SplashScreen
	Private version As Version = My.Application.Info.Version

	Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		SplashClock.Start()
		Label4.Text = "v" + version.Major.ToString + "." +
			version.Minor.ToString + "." + version.Build.ToString
	End Sub

	Private Sub SplashClock_Tick(sender As Object, e As EventArgs) Handles SplashClock.Tick
		sender.Stop()
		Close()
		Main.Show()
	End Sub
End Class