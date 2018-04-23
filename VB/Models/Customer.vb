Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace T223550.Models
	Public Class Customer
		Public Property ID() As Integer
		Public Property Name() As String
		Public Overrides Function ToString() As String
			Return Name
		End Function
	End Class
End Namespace
