Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace T223550.Models
	Public Class DataSourceHelper
		Private Shared _Customers As List(Of Customer)
		Private Shared _Orders As List(Of Order)
		Shared Sub New()
			_Customers = CreateCustomers()
			_Orders = CreateOrders()
		End Sub

		Private Shared Function CreateOrders() As List(Of Order)
			Dim orders As New List(Of Order)()
			Dim order As New Order()
			order.ID = 0
			order.Customer = _Customers(0)
			order.OrderDate = Date.Today
			orders.Add(order)
			order = New Order()
			order.ID = 1
			order.Customer = _Customers(1)
			order.OrderDate = Date.Today.AddDays(1)
			orders.Add(order)
			order = New Order()
			order.ID = 2
			order.Customer = _Customers(1)
			order.OrderDate = Date.Today.AddDays(2)
			orders.Add(order)
			order = New Order()
			order.ID = 3
			order.Customer = _Customers(2)
			order.OrderDate = Date.Today.AddDays(3)
			orders.Add(order)
			order = New Order()
			order.ID = 4
			order.Customer = _Customers(2)
			order.OrderDate = Date.Today.AddDays(4)
			orders.Add(order)
			order = New Order()
			order.ID = 5
			order.Customer = _Customers(2)
			order.OrderDate = Date.Today.AddDays(5)
			orders.Add(order)
			Return orders
		End Function

		Private Shared Function CreateCustomers() As List(Of Customer)
			Dim customers As New List(Of Customer)()
			Dim customer As New Customer()
			customer.ID = 0
			customer.Name = "Tom"
			customers.Add(customer)
			customer = New Customer()
			customer.ID = 1
			customer.Name = "Todd"
			customers.Add(customer)
			customer = New Customer()
			customer.ID = 2
			customer.Name = "John"
			customers.Add(customer)
			Return customers
		End Function

		Public Shared Function GetCustomers() As List(Of Customer)
			Return _Customers
		End Function

		Public Shared Function GetOrders(ByVal customer As Customer) As List(Of Order)
            Dim query = From order In _Orders
                        Where order.Customer Is customer
                        Select order
			Return query.ToList()
		End Function
	End Class
End Namespace
