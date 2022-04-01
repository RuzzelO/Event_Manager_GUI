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
    public partial class MenuPage : Form
    {
        public static EventCoordinator eCoord { get; set; }

        public MenuPage()
        {
            eCoord = new EventCoordinator(200, 1000, 101, 5000, 301, 20);
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The swagpino event managment Software");
        }

        //CustomerOptions
        private void CustomerOptions_Click(object sender, EventArgs e)
        {
            
            CustomerOptions Co = new CustomerOptions(this);
            Co.eCoord = eCoord;
            Co.Show();
            this.Hide();
        }

        //EventOptions
        private void EventOptions_Click(object sender, EventArgs e)
        {
            EventManagerPage Em = new EventManagerPage(this);
            Em.eCoord = eCoord;
            Em.Show(this);
            this.Hide();
        }

        private void RSVPEvent_Click(object sender, EventArgs e)
        {
            RSVPPage Re = new RSVPPage(this);
            Re.eCoord = eCoord;
            Re.Show(this);
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our software");
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
