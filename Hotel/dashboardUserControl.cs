using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class dashboardUserControl : UserControl
    {
        public dashboardUserControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new clientUserControl());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new factureUserControl());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new hotelsUserControl());

        }
    }
}
