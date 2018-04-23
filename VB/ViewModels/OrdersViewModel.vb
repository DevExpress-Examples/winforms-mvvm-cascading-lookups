Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports T223550.Models
Imports DevExpress.Mvvm.POCO

Namespace T223550.ViewModels
	Public Class OrdersViewModel
		Public Sub New()
			Customers = DataSourceHelper.GetCustomers()
		End Sub

		Public Overridable Property SelectedCustomer() As Customer
		Private privateCustomers As List(Of Customer)
		Public Property Customers() As List(Of Customer)
			Get
				Return privateCustomers
			End Get
			Private Set(ByVal value As List(Of Customer))
				privateCustomers = value
			End Set
		End Property
		Public Overridable Property SelectedOrder() As Order
		Public ReadOnly Property Orders() As List(Of Order)
			Get
				Return DataSourceHelper.GetOrders(SelectedCustomer)
			End Get
		End Property

		Protected Overridable Sub OnSelectedCustomerChanged()
			Me.RaisePropertyChanged(Function(m) m.Orders)
		End Sub
	End Class
End Namespace
