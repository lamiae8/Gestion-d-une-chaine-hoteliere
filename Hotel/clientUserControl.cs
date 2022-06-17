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
    public partial class clientUserControl : UserControl
    {
        private chaineHoteliereContext db = new chaineHoteliereContext();
        public clientUserControl()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new dashboardUserControl());
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new client
                {
                    fullname = txtNom.Text,            
                    address = txtAdresse.Text,
                    city = txtVille.Text,
                    postalcode = Int32.Parse(txtCodePostal.Text),
                    country = txtPays.Text,
                    phone = txtTelephone.Text,
                    email = txtEmail.Text

                };
                db.clients.Add(client);
                db.SaveChanges();
                MessageBox.Show("Registration Successful");
            }
            catch
            {
                MessageBox.Show("Registration Failed!!");
            }
        }


    }
}
