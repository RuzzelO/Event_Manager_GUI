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
    public partial class ViewCustomerDetails : Form
    {

        public EventCoordinator eCoord { get; set; }

        CustomerOptions Co;
        public ViewCustomerDetails()
        {
            InitializeComponent();
        }
        public ViewCustomerDetails(CustomerOptions CustO)
        {
            Co = CustO;
            InitializeComponent();
        }

        private void ViewCustomerDetails_Load(object sender, EventArgs e)
        {
            CListMenu.Text = eCoord.customerList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SubmitCustomerId_Click(object sender, EventArgs e)
        {
            int value = int.Parse(CId.Text);
            CustomerDetailList.Text = eCoord.getCustomerInfoById(value);
        }

        private void BackToCustomerOptions_Click(object sender, EventArgs e)
        {
            Co.Show();
            this.Hide();
        }
    }
}
