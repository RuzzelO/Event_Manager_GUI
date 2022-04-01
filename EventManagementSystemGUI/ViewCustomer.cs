using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystemGUI
{
    
    public partial class ViewCustomer : Form
    {
        CustomerOptions Co;
        public EventCoordinator eCoord { get; set; }
        public ViewCustomer()
        {
            InitializeComponent();
        }
        public ViewCustomer(CustomerOptions CustO)
        {
            Co = CustO;
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            CustomerOutput.Text = eCoord.customerList();
        }



        private void CustomerOutput_Click(object sender, EventArgs e)
        {
            CustomerOutput.Text = eCoord.customerList();
        }

        private void BackToCustomerOptions_Click(object sender, EventArgs e)
        {
            Co.Show();
            this.Hide();
        }
    }
}
