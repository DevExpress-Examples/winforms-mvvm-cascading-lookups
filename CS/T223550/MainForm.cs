using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace T223550 {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
            mvvmContext1.SetBinding(luMaster.Properties, p => p.DataSource, "Customers");
            mvvmContext1.SetBinding(luMaster, p => p.EditValue, "SelectedCustomer");

            mvvmContext1.SetBinding(luChild.Properties, p => p.DataSource, "Orders");
            mvvmContext1.SetBinding(luChild, p => p.EditValue, "SelectedOrder");
        }
    }
}
