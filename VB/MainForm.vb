Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace T223550
	Partial Public Class MainForm
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			mvvmContext1.SetBinding(luMaster.Properties, Function(p) p.DataSource, "Customers")
			mvvmContext1.SetBinding(luMaster, Function(p) p.EditValue, "SelectedCustomer")

			mvvmContext1.SetBinding(luChild.Properties, Function(p) p.DataSource, "Orders")
			mvvmContext1.SetBinding(luChild, Function(p) p.EditValue, "SelectedOrder")
		End Sub
	End Class
End Namespace
