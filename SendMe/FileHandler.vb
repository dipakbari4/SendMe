Imports System.IO.File

Friend Module FileHandler
	Public Sub Write(location As String, content As String)
		If Exists(location) Then
			asker =
				MsgBox("The file seems already existing there, it can be overwritten.",
					   MsgBoxStyle.YesNo, "Overwite?")

			Select Case asker
				Case MsgBoxResult.Yes
					Try
						WriteAllText(location, content)
					Catch ex As Exception
						Message("Unable to process the file.", "File Error")
					End Try
				Case Else
			End Select
		Else
			WriteAllText(location, content)
		End If
	End Sub
End Module
