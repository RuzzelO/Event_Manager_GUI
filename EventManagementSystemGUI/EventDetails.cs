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
    public partial class EventDetails : Form
    {
        EventManagerPage eMenu;
        public EventCoordinator eCoord { get; set; }
        public EventDetails()
        {
            InitializeComponent();
        }

        public EventDetails(EventManagerPage f1)
        {
            eMenu = f1;
            InitializeComponent();
        }

        private void EventDetails_Load(object sender, EventArgs e)
        {
                eListMenu.Text = eCoord.eventList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_to_Click(object sender, EventArgs e)
        {
            eMenu.Show();
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int value = int.Parse(eID.Text);
            int inID = Convert.ToInt32(value);
            eventDetailList.Text = eCoord.getEventInfoById(value);
        }


    }
}
