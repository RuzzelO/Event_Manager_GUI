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
    public partial class addRSVPPage : Form
    {
        public EventCoordinator eCoord { get; set; }
        RSVPPage rp;
        public addRSVPPage()
        {
            InitializeComponent();
        }

        public addRSVPPage(RSVPPage rp1)
        {
            rp = rp1;
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int blankChecker = 0;
            decimal evID = eID.Value;
            decimal custID = cID.Value;
            int eVal = Convert.ToInt32(evID);
            int cVal = Convert.ToInt32(custID);
            if (eVal == 0 || cVal == 0)
            {
                MessageBox.Show("enter values for the blanks");
                blankChecker++;
            }
            int day = datePicker.Value.Day;
            int month = datePicker.Value.Month;
            int year = datePicker.Value.Year;
            int hour = timePicker.Value.Hour;
            int minute = timePicker.Value.Minute;
            Date date = new Date(day, month, year, hour, minute);

            if (eCoord.addRSVP(cVal, eVal,date) && blankChecker == 0)
            {
                addRSVP.Text = "Successful";
            }
            else
            {
                addRSVP.Text = "Not Successful";
            }
            eventListText.Text = eCoord.eventList();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            rp.Show();
            this.Hide();
        }

        private void addRSVPPage_Load(object sender, EventArgs e)
        {
            eventListText.Text = eCoord.eventList();
            customerListText.Text = eCoord.customerList();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
