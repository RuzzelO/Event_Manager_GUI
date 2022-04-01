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
    public partial class RSVPEvent : Form
    {
        MenuPage mP;
        public RSVPEvent()
        {
            InitializeComponent();
        }

        public RSVPEvent(MenuPage menuP)
        {
            mP = menuP;
            InitializeComponent();
        }

        private void RSVPEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
