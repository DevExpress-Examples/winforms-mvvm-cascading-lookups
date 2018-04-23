using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T223550.Models {
    public class DataSourceHelper {
        private static List<Customer> _Customers;
        private static List<Order> _Orders;
        static DataSourceHelper() {
            _Customers = CreateCustomers();
            _Orders = CreateOrders();
        }

        private static List<Order> CreateOrders() {
            List<Order> orders = new List<Order>();
            Order order = new Order();
            order.ID = 0;
            order.Customer = _Customers[0];
            order.OrderDate = DateTime.Today;
            orders.Add(order);
            order = new Order();
            order.ID = 1;
            order.Customer = _Customers[1];
            order.OrderDate = DateTime.Today.AddDays(1);
            orders.Add(order);
            order = new Order();
            order.ID = 2;
            order.Customer = _Customers[1];
            order.OrderDate = DateTime.Today.AddDays(2);
            orders.Add(order);
            order = new Order();
            order.ID = 3;
            order.Customer = _Customers[2];
            order.OrderDate = DateTime.Today.AddDays(3);
            orders.Add(order);
            order = new Order();
            order.ID = 4;
            order.Customer = _Customers[2];
            order.OrderDate = DateTime.Today.AddDays(4);
            orders.Add(order);
            order = new Order();
            order.ID = 5;
            order.Customer = _Customers[2];
            order.OrderDate = DateTime.Today.AddDays(5);
            orders.Add(order);
            return orders;
        }

        private static List<Customer> CreateCustomers() {
            List<Customer> customers = new List<Customer>();
            Customer customer = new Customer();
            customer.ID = 0;
            customer.Name = "Tom";
            customers.Add(customer);
            customer = new Customer();
            customer.ID = 1;
            customer.Name = "Todd";
            customers.Add(customer);
            customer = new Customer();
            customer.ID = 2;
            customer.Name = "John";
            customers.Add(customer);
            return customers;
        }

        public static List<Customer> GetCustomers() {
            return _Customers;
        }

        public static List<Order> GetOrders(Customer customer) {
            var query = from order in _Orders
                        where order.Customer == customer
                        select order;
            return query.ToList();
        }
    }
}
