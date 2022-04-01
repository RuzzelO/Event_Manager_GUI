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
    public partial class DeleteEvent : Form
    {


        public EventCoordinator eCoord { get; set; }
        public EventManager eventMan { get; set; }


        EventManagerPage Emp;

        
        public DeleteEvent()
        {
            InitializeComponent();
        }
        public DeleteEvent(EventManagerPage EventMP)
        {
            Emp = EventMP;
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteEvent_Load(object sender, EventArgs e)
        {
            eventListText.Text = eCoord.eventList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int value = int.Parse(eID.Text);
            if (eCoord.deleteEvent(value) == true)
            {
                deletedEventList.Text = eCoord.eventList();
                eventListText.Text = eCoord.eventList();
                eCoord.deleteEvent(value);
                                
            }
            else
            {
                MessageBox.Show("This Id does not exist or is incorrect. Please Try again");
            }
            //if(eCoord)
        }

        private void ReturnToEventManagerPage_Click(object sender, EventArgs e)
        {
            Emp.Show();
            this.Hide();
        }
    }
}
