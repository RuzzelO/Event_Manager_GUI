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
    public partial class ViewRSVP : Form
    {
        RSVPPage rp;
        public EventCoordinator eCoord { get; set; }
        public ViewRSVP()
        {
            InitializeComponent();
        }
        public ViewRSVP(RSVPPage rp1)
        {
            rp = rp1;
            InitializeComponent();
        }

        private void ViewRSVP_Load(object sender, EventArgs e)
        {
            rsvpListText.Text = eCoord.rsvpList(); 
        }

        private void back_To_Click(object sender, EventArgs e)
        {
            rp.Show();
            this.Hide();
        }
    }
}
