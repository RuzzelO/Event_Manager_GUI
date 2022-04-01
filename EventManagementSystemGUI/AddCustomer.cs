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
    public partial class AddCustomer : Form
    {
        CustomerOptions Co;
        public EventCoordinator eCoord { get; set; }

        public AddCustomer()
        {
            InitializeComponent();
        }
        public AddCustomer(CustomerOptions CustO)
        {
            Co = CustO;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            
        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Submit_Click(object sender, EventArgs e)
        {
            
        }

        private void SubmitCustomer_Click(object sender, EventArgs e)
        {
            int blankChecker = 0;
            string fName = CustomerFirstName.Text;
            string lName = CustomerLastName.Text;
            string phoneNum = CustomerPhoneNumber.Text;

            if (fName == "" || lName == "" || phoneNum == "")
            {
                MessageBox.Show("Please fill in blank boxes");
                blankChecker++;
            }
            if(phoneNum.Length != 10)
            {
                MessageBox.Show("Please enter a Valid Phone Number.");
                blankChecker++;
            }
            if (blankChecker == 0)
            {
                eCoord.addCustomer(fName, lName, phoneNum);
                CustomerStatus.Text = "Successful";
            }
            else
            {
                CustomerStatus.Text = "Unsuccessful";
            }

        }

        private void ExitToCustomerOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Co.Show();
        }

        

        /*public Submit_Click(object sender, EventArgs e)
        {
            string Custfirst = CustomerFirstName.Text;
            string CustLast = CustomerFirstName.Text;

            return CustomerFirstName;
        }*/
    }
}
