using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T223550.Models {
    public class Customer {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            return Name;
        }
    }
}
