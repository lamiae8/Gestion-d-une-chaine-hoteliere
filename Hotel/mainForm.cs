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
    public partial class mainForm : Form
    {
        private chaineHoteliereContext db = new chaineHoteliereContext();
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
            dashboardUserControl1.Hide();
         //   hotelsUserControl1.Hide();
            factureUserControl1.Hide();
          //  clientUserControl1.Hide();
            //roomUserControl1.Hide();
            //categoryUserControl1.Hide();
            welcomeUserControl1.Show();
            var Hotel = db.hotels;
            Hotel.ToList().ForEach(h =>Console.WriteLine(h.Name));


        }
    }
}
