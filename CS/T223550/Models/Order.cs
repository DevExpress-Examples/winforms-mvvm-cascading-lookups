using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T223550.Models {
    public class Order {
        public int ID { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public override string ToString() {
            return string.Format("{0} - {1:d}", ID, OrderDate);
        }
    }
}
