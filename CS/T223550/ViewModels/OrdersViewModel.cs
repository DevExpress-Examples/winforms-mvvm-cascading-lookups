using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T223550.Models;
using DevExpress.Mvvm.POCO;

namespace T223550.ViewModels {
    public class OrdersViewModel {
        public OrdersViewModel() {
            Customers = DataSourceHelper.GetCustomers();
        }

        public virtual Customer SelectedCustomer { get; set; }
        public List<Customer> Customers { get; private set; }
        public virtual Order SelectedOrder { get; set; }
        public List<Order> Orders {
            get { return DataSourceHelper.GetOrders(SelectedCustomer); }
        }

        protected virtual void OnSelectedCustomerChanged() {
            this.RaisePropertyChanged(m => m.Orders);
        }
    }
}
