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
        DataTable dtClient = new DataTable();
        int selectedIdClient = -1;
        public clientUserControl()
        {
            InitializeComponent();
            
            dtClient.Columns.Add("ID");
            dtClient.Columns.Add("Full Name");
            dtClient.Columns.Add("Email");
            dtClient.Columns.Add("Phone Number");
            dtClient.Columns.Add("Address");
            dtClient.Columns.Add("City");
            dtClient.Columns.Add("Country");
            dtClient.Columns.Add("Postal Code");
            display();

        }
        public void display()
        {
            
            var clients = db.clients;

            clients.ToList().ForEach(
                c =>


                {

                    DataRow row = dtClient.NewRow();
                    row[0] = c.codeclient;
                    row[1] = c.fullname;
                    row[2] = c.email;
                    row[3] = c.phone;
                    row[4] = c.address;
                    row[5] = c.city;
                    row[6] = c.country;
                    row[7] = c.postalcode;


                    dtClient.Rows.Add(row);

                });



            dataGridView1.DataSource = dtClient;

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
                this.Hide();
                this.Parent.Controls.Add(new clientUserControl());
            }
            catch
            {
                MessageBox.Show("Registration Failed!!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                client cli = db.clients.Find(selectedIdClient);
              
                cli.fullname = txtNom.Text;
                cli.address = txtAdresse.Text;
                cli.city = txtVille.Text;
                cli.postalcode = Int32.Parse(txtCodePostal.Text);
                cli.country = txtPays.Text;
                cli.phone = txtTelephone.Text;
                cli.email = txtEmail.Text;



                db.SaveChanges();
                MessageBox.Show("Update Successful");
                this.Hide();
                this.Parent.Controls.Add(new clientUserControl());
            }
            catch
            {
                MessageBox.Show("Update Failed !!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                client cli = db.clients.Find(selectedIdClient);
                db.clients.Remove(cli);
                db.SaveChanges();
                MessageBox.Show("Delete Successful");
                this.Hide();
                this.Parent.Controls.Add(new clientUserControl());
            }
            catch
            {
                MessageBox.Show("Delete Failed !! ");
               
            }




        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            string selectedFullname = null, selectedEmail = null, selectedPhone = null, selectedAddress=null,selectedCity = null, selectedCountry = null, selectedPostal=null;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectedIdClient= Int32.Parse(row.Cells[0].Value.ToString());
                selectedFullname = row.Cells[1].Value.ToString();
                selectedEmail = row.Cells[2].Value.ToString();
               selectedPhone = row.Cells[3].Value.ToString();
                selectedAddress = row.Cells[4].Value.ToString();
                selectedCity = row.Cells[5].Value.ToString();
                selectedCountry = row.Cells[6].Value.ToString();
                selectedPostal = row.Cells[7].Value.ToString();

               
                
            }

            txtAdresse.Text = selectedAddress;
            txtNom.Text = selectedFullname;
            txtEmail.Text =selectedEmail;
            txtCodePostal.Text = selectedPostal;
            txtPays.Text = selectedCountry;
            txtTelephone.Text=selectedPhone;
            txtVille.Text = selectedCity;
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtPays_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodePostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void pays_Click(object sender, EventArgs e)
        {

        }

        private void codePostal_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void ville_Click(object sender, EventArgs e)
        {

        }

        private void telephone_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
