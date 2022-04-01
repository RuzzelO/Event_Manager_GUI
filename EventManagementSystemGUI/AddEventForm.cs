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
    public partial class AddEventForm : Form
    {

        EventManagerPage eMenu;
        public static EventManager eventMan { get; set; }
        public EventCoordinator eCoord { get; set; }

        public static string eventText;


        public AddEventForm()
        {

            InitializeComponent();
        }
        public AddEventForm(EventManagerPage f1)
        {
            eMenu = f1;
            InitializeComponent();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
                
        }

        public void submit_Click(object sender, EventArgs e)
        {
            int blankChecker = 0;
            string eName = eventName.Text;
            string eVenue = venue.Text;
            decimal value = maxAtt.Value;
            int maxAttendees = Convert.ToInt32(value);

            if (value == 0 || eName == "" || eVenue == "")
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

            if (eCoord.checkVenue(eVenue, day) == true && blankChecker == 0 && maxAttendees != 0)
            {
                eCoord.addEvent(eName, eVenue, date, maxAttendees);
                customer.Text = "Successful";
            }
            else 
            {
                customer.Text = "Not Successful";
            }

        }

        public string SomeData { get; set; }
        public bool NewData { get; private set; }

        public string getEvent() { return eventText; }


        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            eMenu.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
       
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxAtt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
