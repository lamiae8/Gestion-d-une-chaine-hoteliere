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
    public partial class consumptionUserControl : UserControl
    {
        private chaineHoteliereContext db = new chaineHoteliereContext();
        DataTable dtConsumption = new DataTable();
        int selectedIdConsumption = -1;
        public consumptionUserControl()
        {
            InitializeComponent();
            var client = db.clients;
            

            this.clientComboBox.DataSource = client.ToList();
            this.clientComboBox.DisplayMember = "fullname";
            this.clientComboBox.ValueMember = "codeclient";
            this.clientComboBox.SelectedItem = null;
            this.clientComboBox.SelectedText = "select a Client";
            var service = db.services;
            
            this.serviceComboBox.DataSource = service.ToList();
            this.serviceComboBox.DisplayMember = "servicename";
            this.serviceComboBox.ValueMember = "serviceprice";
           this.serviceComboBox.SelectedItem = null;
          this.serviceComboBox.SelectedText = "select a Service";

            dtConsumption.Columns.Add("ID");
            dtConsumption.Columns.Add("Service");
            dtConsumption.Columns.Add("Client");
            dtConsumption.Columns.Add("Consumption Date");
            dtConsumption.Columns.Add("Price");
            display();
        }

        public void display()
        {

            var consumption = db.consumptions;

            consumption.ToList().ForEach(
                c =>


                {

                    DataRow row = dtConsumption.NewRow();
                    row[0] = c.codeconsumption;
                    row[1] = c.service.servicename;
                    row[2] = c.client.fullname;
                    row[3] = c.dateconsumption;
                    row[4] = c.service.serviceprice;
                    


                    dtConsumption.Rows.Add(row);

                });



            dataGridView1.DataSource = dtConsumption;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            DateTime selectedDate = DateTime.Now;
            string selectedService = null, selectedClient = null;
            string selectedPrice = null;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectedIdConsumption = Int32.Parse(row.Cells[0].Value.ToString());
                selectedService = row.Cells[1].Value.ToString();
                selectedClient = row.Cells[2].Value.ToString();
                selectedDate = Convert.ToDateTime( row.Cells[3].Value.ToString());
                selectedPrice = row.Cells[4].Value.ToString();

                clientComboBox.Text = null;
                serviceComboBox.Text = null;
            }

            serviceComboBox.SelectedText = selectedService;
            clientComboBox.SelectedText = selectedClient;
            consumptionPrice.Text = selectedPrice;
            ConsumptionDate.Value=selectedDate;
           
           



        }


        private void addConsumption_Click(object sender, EventArgs e)
        {  
            service sr = db.services.Where(s => s.servicename == serviceComboBox.Text).SingleOrDefault();

            client cl = db.clients.Where(c => c.fullname == clientComboBox.Text).SingleOrDefault();

            

            try
            {
                var consumption = new consumption()
                {
            
                    serviceid = sr.codeservice,
                    clientid = cl.codeclient,
                    dateconsumption = ConsumptionDate.Value

                };
                db.consumptions.Add(consumption);
                db.SaveChanges();

                MessageBox.Show("Registration Successful");
                this.Hide();
                this.Parent.Controls.Add(new consumptionUserControl());

            }
            catch
            {
                MessageBox.Show("Registration Failed!!");

            }
        }


        private void serviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            service sr = db.services.Where(s => s.servicename == serviceComboBox.Text).SingleOrDefault();

            if (sr != null) this.consumptionPrice.Text = sr.serviceprice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client c = db.clients.Where(cl => cl.fullname == clientComboBox.Text).SingleOrDefault();
            service s = db.services.Where(sr => sr.servicename == serviceComboBox.Text).SingleOrDefault();
            try
            {
                consumption cons = db.consumptions.Find(selectedIdConsumption);
               
                cons.serviceid = s.codeservice;
                cons.clientid = c.codeclient;
                cons.dateconsumption = ConsumptionDate.Value;


                Console.WriteLine(cons.serviceid + "" + cons.clientid + "" + cons.dateconsumption);

                  db.SaveChanges();
                MessageBox.Show("Update Successful");
                this.Hide();
                this.Parent.Controls.Add(new consumptionUserControl());
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
                consumption c = db.consumptions.Find(selectedIdConsumption);
                db.consumptions.Remove(c);
                db.SaveChanges();
                MessageBox.Show("Delete Successful");
                this.Hide();
                this.Parent.Controls.Add(new consumptionUserControl());
            }
            catch
            {
                MessageBox.Show("Delete Failed !! ");

            }
        }
        private void serviceComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new dashboardUserControl());
        }
    }
}
