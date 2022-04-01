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
    public partial class EventManagerPage : Form
    {

        MenuPage mP;
        public EventCoordinator eCoord { get; set; }
        
        public EventManagerPage(MenuPage menuP)
        {

            mP = menuP;
            InitializeComponent();
        }

        public void EventManagerPage_Load(object sender, EventArgs e)
        {
        }

        public string getECoordList()
        {

            return eCoord.eventList();
        }


        private void addEvent_Click(object sender, EventArgs e)
        {
            AddEventForm nForm = new AddEventForm(this);
            this.Hide();
            nForm.eCoord = eCoord;
            nForm.Show(this);

        }

        private void viewAllEvent_Click(object sender, EventArgs e)
        {
            ViewAllEventPage nForm = new ViewAllEventPage(this);
            this.Hide();
            nForm.eCoord = eCoord;
            nForm.Show(this);

        }

        private void viewEventDetails_Click(object sender, EventArgs e)
        {
            EventDetails nForm = new EventDetails(this);
            this.Hide();
            nForm.eCoord = eCoord;
            nForm.Show(this);
        }

        private void ExitToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mP.Show();
        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            DeleteEvent nForm = new DeleteEvent(this);
            this.Hide();
            nForm.eCoord = eCoord;
            nForm.Show(this);

        }
    }
}
