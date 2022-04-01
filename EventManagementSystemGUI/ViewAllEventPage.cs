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
    public partial class ViewAllEventPage : Form
    {

        EventManagerPage eMenu;

        public EventCoordinator eCoord { get; set; }

        private void ViewAllEventPage_Load(object sender, EventArgs e)
        {
            eventListText.Text = eCoord.eventList();
        }

        public ViewAllEventPage()
        {
            InitializeComponent();

        }


        public ViewAllEventPage(EventManagerPage f1)
        {

            eMenu = f1;
            InitializeComponent();


        }

        private void eventListText_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            eMenu.Show();
            this.Hide();
        }

        private void viewEventList_Click(object sender, EventArgs e)
        {
            eventListText.Text = eCoord.eventList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
