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
    public partial class RSVPPage : Form
    {
        MenuPage mP;
        public EventCoordinator eCoord { get; set; }

        public RSVPPage()
        {
            InitializeComponent();
        }

        public RSVPPage(MenuPage menuP)
        {
            mP = menuP;
            InitializeComponent();
        }

        private void RSVPPage_Load(object sender, EventArgs e)
        {

        }

        private void EventRSVP_Click(object sender, EventArgs e)
        {
            addRSVPPage aC = new addRSVPPage(this);
            this.Hide();
            aC.eCoord = eCoord;
            aC.Show(this);
        }
        private void viewRSVP_Click(object sender, EventArgs e)
        {
            ViewRSVP aC = new ViewRSVP(this);
            this.Hide();
            aC.eCoord = eCoord;
            aC.Show(this);
        }
        private void BackToMenu_Click(object sender, EventArgs e)
        {
            mP.Show();
            this.Hide();
        }

        
    }
}
