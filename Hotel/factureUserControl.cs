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
    public partial class factureUserControl : UserControl
    {
        private chaineHoteliereContext db=new chaineHoteliereContext();
        int clientID;
        double priceRes=0, priceSer=0,depositP=0, priceTotal = 0;
        
        public factureUserControl()
        {
            InitializeComponent();
            var client = db.clients; 
            this.clientComboBox.DataSource = client.ToList();
            this.clientComboBox.DisplayMember = "fullname";
            this.clientComboBox.ValueMember = "codeclient";
            this.clientComboBox.SelectedItem = null;
            this.clientComboBox.SelectedText = "select a Client";

            DataTable dtService = new DataTable();
            dtService.Columns.Add("Client ID");
            dtService.Columns.Add("Client Name");
            dtService.Columns.Add("Service Name");
            dtService.Columns.Add("Price");
            dtService.Columns.Add("Date Consumtion");


        }
       
        public void display()
        {
            DataTable dtReservation = new DataTable();
            dtReservation.Columns.Add("Client ID");
            dtReservation.Columns.Add("Client Name");
            dtReservation.Columns.Add("Hotel ID");
            dtReservation.Columns.Add("Hotel Name");
            dtReservation.Columns.Add("Room ID");
            dtReservation.Columns.Add("Room Num");
            dtReservation.Columns.Add("Reservation Price");
            dtReservation.Columns.Add("Arrival date");
            dtReservation.Columns.Add("departure date");
            dtReservation.Columns.Add("deposit");
            client c = db.clients.Where(cl => cl.fullname == clientComboBox.Text).SingleOrDefault();
            var reservation = db.reservations;
            if (c != null)
            {
                clientID = c.codeclient;
                String clientName = c.fullname;
                reservation.ToList().ForEach(
                    r =>


                    {
                        if (r.clientid == clientID)
                        {
                            room rr = db.rooms.Find(r.roomid);
                            int hotelID = rr.hotelid;
                            TimeSpan days = r.departure.Date - r.arrival.Date;

                            DataRow row = dtReservation.NewRow();
                            row[0] = clientID;
                            row[1] = clientName;
                            row[2] = hotelID;
                            row[3] = db.hotels.Find(hotelID).Name;
                            row[4] = rr.coderoom;
                            row[5] = rr.numroom;
                            row[6] = rr.priceroom * days.Days;
                            row[7] = r.arrival;
                            row[8] = r.departure;
                            row[9] = r.deposit;

                            dtReservation.Rows.Add(row);
                            priceRes=rr.priceroom*days.Days;
                        }
                    }
                    );




            }

            dataGridView1.DataSource = dtReservation;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new dashboardUserControl());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            display();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            priceSer = 0; 
            DataTable dtService = new DataTable();
            dtService.Columns.Add("Client ID");
            dtService.Columns.Add("Client Name");
            dtService.Columns.Add("Service Name");
            dtService.Columns.Add("Price");
            dtService.Columns.Add("Date Consumtion");

            DateTime dateConsumption=DateTime.Now;
            client cl;
            service ser;
            DateTime selectedArrival=DateTime.Now , selectedDeparture=DateTime.Now;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int selectedIdClient =int.Parse(row.Cells[0].Value.ToString());
                 selectedArrival =Convert.ToDateTime( row.Cells[7].Value.ToString());
                selectedDeparture = Convert.ToDateTime(row.Cells[8].Value.ToString());
                txtdeposit.Text = row.Cells[9].Value.ToString();
                depositP = double.Parse(row.Cells[9].Value.ToString());
                


            }
            db.consumptions.ToList().ForEach(cs => {

                if (cs.clientid == clientID && cs.dateconsumption > selectedArrival && cs.dateconsumption < selectedDeparture)
                {
                   dateConsumption= cs.dateconsumption ;
                    cl = db.clients.Find(cs.clientid);
                    ser = db.services.Find(cs.serviceid);
                
                    DisplayService(dtService,cl.codeclient, cl.fullname, ser.servicename,ser.serviceprice, dateConsumption);
                    priceSer =priceSer + ser.serviceprice;
                
                } ;
            });
                    textPrice.Text=(priceRes+priceSer).ToString();
            priceTotal = priceRes+priceSer - depositP;
            textTotal.Text=priceTotal.ToString();

            dataGridView2.DataSource = dtService;
           
          //  textPrice.Text = price.ToString();
            


        }


        public void DisplayService(DataTable dtService,int codeclient, string fullname,string servicename,double serviceprice, DateTime date)
        {
            DataRow row = dtService.NewRow();
            row[0] = codeclient;
            row[1] = fullname;
            row[2] = servicename;
            row[3] = serviceprice;
            row[4] = date;
          

            dtService.Rows.Add(row);

            
            
        }
        

    }
}
