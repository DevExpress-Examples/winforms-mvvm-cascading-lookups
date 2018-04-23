Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace T223550.Models
	Public Class Order
		Public Property ID() As Integer
		Public Property Customer() As Customer
		Public Property OrderDate() As Date
		Public Overrides Function ToString() As String
			Return String.Format("{0} - {1:d}", ID, OrderDate)
		End Function
	End Class
End Namespace
