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
    public partial class CustomerOptions : Form
    {
        public EventCoordinator eCoord { get; set; }
        MenuPage mP;
        public CustomerOptions()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public CustomerOptions(MenuPage menuP)
        {
            mP = menuP;
            InitializeComponent();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer aC = new AddCustomer(this);
            this.Hide();
            aC.eCoord = eCoord;
            aC.Show(this);
        }

        private void ViewCustomer_Click(object sender, EventArgs e)
        {
            ViewCustomer vC = new ViewCustomer(this);
            this.Hide();
            vC.eCoord = eCoord;
            vC.Show(this);

        }

        private void ViewCustomerDetails_Click(object sender, EventArgs e)
        {
            ViewCustomerDetails vCD = new ViewCustomerDetails(this);
            this.Hide();
            vCD.eCoord = eCoord;
            vCD.Show(this);
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomer dC = new DeleteCustomer(this);
            this.Hide();
            dC.eCoord = eCoord;
            dC.Show(this);
        }

        private void MenuPage_Click(object sender, EventArgs e)
        {
            mP.Show();
            this.Hide();
        }
    }
}
