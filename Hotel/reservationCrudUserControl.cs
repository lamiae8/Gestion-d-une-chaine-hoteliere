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
    public partial class reservationCrudUserControl : UserControl
    {
        private chaineHoteliereContext db= new chaineHoteliereContext();
        int roomID=-1;
        DateTime arrivalChoosed=DateTime.Now, departureChoosed=DateTime.Now, selectedDepositDate=DateTime.Now, selectedDeparture=DateTime.Now, selectedArrival=DateTime.Now;
        int selectedId=-1, selectedIdClient=-1;
        double selectedDeposit = 0, selectedPrice = 0;
        string selectedHotel, selectedCategory, selectedRoomNum, selectedNameClient;


        public reservationCrudUserControl()
        {
            InitializeComponent();
           

            display();
            //load data to clientCmboBox
            var client = db.clients;
            this.clientCombo.DataSource = client.ToList();
            this.clientCombo.DisplayMember = "fullname";
            this.clientCombo.ValueMember = "codeclient";
            this.clientCombo.SelectedItem = null;
            this.clientCombo.SelectedText = "select a Client";

            //load data to HotelCmboBox
            var hotel = db.hotels;
            this.hotelComboBox.DataSource = hotel.ToList();
            this.hotelComboBox.DisplayMember = "Name";
            this.hotelComboBox.ValueMember = "codehotel";
            this.hotelComboBox.SelectedItem = null;
            this.hotelComboBox.SelectedText = "select an Hotel";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new dashboardUserControl());
        }

        public void display()
        {
            DataTable dtReservation = new DataTable();
            dtReservation.Columns.Add("Reservation ID");
            dtReservation.Columns.Add("Client ID");
            dtReservation.Columns.Add("Client Name");
            dtReservation.Columns.Add("Hotel Name");
            dtReservation.Columns.Add("Room Category");
            dtReservation.Columns.Add("Room Num");
            dtReservation.Columns.Add("Reservation Price");
            dtReservation.Columns.Add("Arrival date");
            dtReservation.Columns.Add("departure date");
            dtReservation.Columns.Add("deposit");
            dtReservation.Columns.Add("deposit date");

            var reservation = db.reservations;
           
                
                reservation.ToList().ForEach(
                    r =>


                    {
                        room rr = db.rooms.Find(r.roomid);
                        roomID = rr.coderoom;
                        client c = db.clients.Where(cl => cl.codeclient == r.clientid).SingleOrDefault();
                        hotel H = db.hotels.Where(h => h.codeHotel == rr.hotelid).SingleOrDefault();
                        category C = db.categories.Where(cat => cat.codeCat == rr.Categoryid).SingleOrDefault();
                        int hotelID = rr.hotelid;

                        TimeSpan days = r.departure.Date - r.arrival.Date;
                      //  Console.WriteLine(r.arrival.ToShortDateString());
                        Console.WriteLine(days + " " + r.arrival.ToShortDateString() + " "+r.departure.ToShortDateString());
                        DataRow row = dtReservation.NewRow();
                            row[0] = r.codereservation;
                            row[1] = c.codeclient;
                            row[2] = c.fullname;
                            row[3] = H.Name;
                            row[4] = C.nom_category;
                            row[5] = rr.numroom;
                            row[6] = rr.priceroom * days.Days;
                            row[7] = r.arrival;
                            row[8] = r.departure;
                            row[9] = r.deposit;
                            row[10] =r.datedeposit;

                            dtReservation.Rows.Add(row);
                      
                    }
                    );




            

           dataGridView1.DataSource = dtReservation;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectedId = Int32.Parse( row.Cells[0].Value.ToString());
                selectedIdClient = Int32.Parse(row.Cells[1].Value.ToString());
                selectedNameClient =row.Cells[2].Value.ToString();
                selectedHotel = row.Cells[3].Value.ToString();
               selectedCategory = row.Cells[4].Value.ToString();
                selectedRoomNum = row.Cells[5].Value.ToString();
                selectedPrice= double.Parse(row.Cells[6].Value.ToString());             
                selectedArrival = Convert.ToDateTime(row.Cells[7].Value.ToString());
                selectedDeparture = Convert.ToDateTime(row.Cells[8].Value.ToString());
                selectedDeposit= double.Parse(row.Cells[9].Value.ToString());
                selectedDepositDate= Convert.ToDateTime(row.Cells[10].Value.ToString());
         

             }

            //remplicage des champs


            clientCombo.Text = selectedNameClient;
            hotelComboBox.Text = selectedHotel;
            categoryComboBox.Text = selectedCategory;
            roomNumComboBox.Text = selectedRoomNum;
            priceBox.Text = selectedPrice.ToString();
            arrivalDate.Text = selectedArrival.ToString();
            departureDate.Text = selectedDeparture.ToString();
            depositBox.Text = selectedDeposit.ToString();
            depositDate.Text = selectedDepositDate.ToString();
            //load data to clientCmboBox
            hotel hotel = db.hotels.Where(h => h.Name == hotelComboBox.Text).SingleOrDefault() ;
            var hotelcat = db.hotelcats;
            var cat = db.categories;
            List<int> catID = new List<int>();
            List<category> catName = new List<category>();
            if (hotel != null)
            {
                hotelcat.ToList().ForEach(hc => { if (hc.codeHotel == hotel.codeHotel) { catID.Add(hc.codeCat); } });
                catID.ForEach(c => { Console.WriteLine(c); catName.Add(cat.Find(c)); });


                this.categoryComboBox.DataSource = catName.ToList();
                this.categoryComboBox.DisplayMember = "nom_category";
                this.categoryComboBox.ValueMember = "codeCat";
                
            }
           


        }
            

        private void departureDate_ValueChanged(object sender, EventArgs e)
        {
            departureChoosed = departureDate.Value;
            room rr = db.rooms.Find(roomID);
            var days = departureChoosed.Date - arrivalChoosed.Date;
           
            priceBox.Text = (rr.priceroom * days.Days).ToString();
        }

        private void hotelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.categoryComboBox.SelectedItem = null;
            this.roomNumComboBox.SelectedItem = null;
           
            //load data to categoryCmboBox
            hotel hotel = db.hotels.Where(h => h.Name == hotelComboBox.Text).SingleOrDefault();
            var hotelcat = db.hotelcats;
            var cat = db.categories;
            List<int> catID = new List<int>();
            List<category> catName = new List<category>();
            if (hotel != null)
            {
               
                hotelcat.ToList().ForEach(hc => { if (hc.codeHotel == hotel.codeHotel) { catID.Add(hc.codeCat); } });
                catID.ForEach(c => { Console.WriteLine(c); catName.Add(cat.Find(c)); });


                this.categoryComboBox.DataSource = catName.ToList();
                this.categoryComboBox.DisplayMember = "nom_category";
                this.categoryComboBox.ValueMember = "codeCat";
               
                
                
            }
        }

       

        private void categoryComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            this.roomNumComboBox.DataSource = null;

            //load data to ROOMCmboBox
            category caty = db.categories.Where(c => c.nom_category == categoryComboBox.Text).SingleOrDefault();
            Console.WriteLine(categoryComboBox.Text);

            hotel hot = db.hotels.Where(h => h.Name == hotelComboBox.Text).SingleOrDefault();
            Console.WriteLine(hot.Name);


            if (caty != null)
            {
            List<room> listRoom = new List<room>();
             List<room> listFreeRoom = new List<room>();
             List<reservation> listRes = new List<reservation>();
                var Room = db.rooms;
            Room.ToList().ForEach(r => { if (r.Categoryid == caty.codeCat && r.hotelid == hot.codeHotel) { listRoom.Add(r); Console.WriteLine(r.numroom); } });
               //************************************************
                var res = db.reservations;
               
               int ii; 
                for(ii=0; ii<listRoom.Count(); ii++) 
                {
                     
                    res.ToList().ForEach(r =>
                    {
                        if (r.roomid == listRoom[ii].coderoom)
                        {
                            listRes.Add(r);
                        }
                    });

                    for (int i = 0; i < listRes.Count(); i++)
                    {
                        if (departureDate.Value < listRes[i].arrival || arrivalDate.Value > listRes[i].departure)
                        { listFreeRoom.Add(listRoom[ii]); };

                      //  Console.WriteLine(listFreeRoom[i].numroom);
                    }
                }

                
                this.roomNumComboBox.DataSource = listFreeRoom.ToList();
                this.roomNumComboBox.DisplayMember = "numroom";
                this.roomNumComboBox.ValueMember = "coderoom";
              




            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                reservation res = db.reservations.Find(selectedId);
                client c = db.clients.Where(cc => cc.fullname == clientCombo.Text).SingleOrDefault();
                room r = db.rooms.Where(rr => rr.numroom == roomNumComboBox.Text).SingleOrDefault();

                res.clientid = c.codeclient;
                res.roomid = r.coderoom;
                res.arrival = arrivalDate.Value;
                res.departure = departureDate.Value;
                res.deposit = double.Parse(depositBox.Text);
                res.datedeposit=depositDate.Value;
                


                db.SaveChanges();
                MessageBox.Show("Update Successful");
                this.Hide();
                this.Parent.Controls.Add(new reservationCrudUserControl());
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
                reservation res = db.reservations.Find(selectedId);
                db.reservations.Remove(res);
                db.SaveChanges();
                MessageBox.Show("Delete Successful");
                this.Hide();
                this.Parent.Controls.Add(new reservationCrudUserControl());
            }
            catch
            {
                MessageBox.Show("Delete Failed !! ");

            }
        }
        //reserver une chambre
        private void button3_Click(object sender, EventArgs e)
        {
            client c = db.clients.Where(cc => cc.fullname == clientCombo.Text).SingleOrDefault();
            room r = db.rooms.Where(rr => rr.numroom == roomNumComboBox.Text).SingleOrDefault();



            try
            {
                var res = new reservation()
                {

                    clientid = c.codeclient,
                    roomid = r.coderoom,
                    arrival = arrivalDate.Value,
                    departure = departureDate.Value,
                    deposit = double.Parse(depositBox.Text),
                    datedeposit=depositDate.Value
                };
                db.reservations.Add(res);
                db.SaveChanges();

                MessageBox.Show("Registration Successful");
                this.Hide();
                this.Parent.Controls.Add(new reservationCrudUserControl());

            }
            catch
            {
                MessageBox.Show("Registration Failed!!");

            }
        }

        private void arrivalDate_ValueChanged(object sender, EventArgs e)
        {

            arrivalChoosed=arrivalDate.Value;
            room rr = db.rooms.Find(roomID);
            var days = departureChoosed.Date - arrivalChoosed.Date;
          
            priceBox.Text = (rr.priceroom * days.Days).ToString();
        }
    }
}
