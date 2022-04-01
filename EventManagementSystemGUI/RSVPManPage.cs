using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RSVPManPage : Form
    {
        public static EventCoordinator eCoord { get; set; }
        public RSVPManPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRSVPPage nForm = new AddRSVPPage();
            this.Hide();

        }
    }
}
