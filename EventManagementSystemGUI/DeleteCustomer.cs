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
    public partial class DeleteCustomer : Form
    {

        public EventCoordinator eCoord { get; set; }

        CustomerOptions Co;
        public DeleteCustomer()
        {
            InitializeComponent();
        }
        public DeleteCustomer(CustomerOptions CustO)
        {
            Co = CustO;
            InitializeComponent();
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            CListMenu.Text = eCoord.customerList();
        }

        private void CListMenu_Click(object sender, EventArgs e)
        {
            CListMenu.Text = eCoord.customerList();
        }

        private void SubmitCustomerId_Click(object sender, EventArgs e)
        {

            int value = int.Parse(CId.Text);

            if (eCoord.deleteCustomer(value) == true)
            {
                DeletedCustomerList.Text = eCoord.customerList();
                CListMenu.Text = eCoord.customerList();
                eCoord.deleteCheckCust(value);
            }
            else
            {
                MessageBox.Show("This Id does not exist or is incorrect. Please Try again");
            }

        }


        private void CId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackToCustomerOptions_Click(object sender, EventArgs e)
        {
            Co.Show();
            this.Hide();
        }
    }
}
