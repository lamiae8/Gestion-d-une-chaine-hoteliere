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
    public partial class reservationUserControl : UserControl
    {
        private chaineHoteliereContext db = new chaineHoteliereContext();
        double price;
        string nameHotel, nameCat,numroom;
        int idhotel, idcat;
        
        public reservationUserControl()
        {
            InitializeComponent();
        }
        public reservationUserControl(int idHotel, int idCat, string numRoom)
        {
            InitializeComponent();
            idhotel = idHotel;
            idcat =idCat;
            numroom =numRoom;
            var hotelcat = db.hotelcats;
            var hotel = db.hotels;
            var cat = db.categories;
            var client = db.clients;

            hotelcat.ToList().ForEach(hc => { if (hc.codeHotel == idHotel && hc.codeCat==idCat) { price = hc.prixStarCat; } });
            hotel.ToList().ForEach(h => nameHotel=hotel.Find(idHotel).Name );
            cat.ToList().ForEach(c => nameCat = cat.Find(idCat).nom_category);
            priceBox.Text = price.ToString();
            hotelBox.Text = nameHotel;
            roomBox.Text = nameCat;

            this.clientCombo.DataSource = client.ToList() ;
            this.clientCombo.DisplayMember ="fullname" ;
            this.clientCombo.ValueMember = "codeclient";

            
        }


        private void name_Click(object sender, EventArgs e)
        {

        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
           
            room Room = db.rooms.Where(r=> r.hotelid==idhotel && r.numroom == numroom).Single();
           // var res = db.reservations;
            

            try {
                reservation reservation = new reservation()
                {
                    arrival = arrivalDate.Value,
                    departure = departureDate.Value,
                    deposit = double.Parse(depositBox.Text),
                    datedeposit = depositDate.Value,
                  roomid =  Room.coderoom,
                    clientid = clientCombo.SelectedIndex + 1
                    

                };
                Console.WriteLine(departureDate.Value);
                Console.WriteLine(depositBox.Text);
                Console.WriteLine(depositDate.Value);
                Console.WriteLine(Room.coderoom);
                Console.WriteLine(clientCombo.SelectedIndex + 1);
                Console.WriteLine(arrivalDate.Value);
              //  res.ToList().ForEach(re => { if (re.roomid == Room.coderoom && re.arrival <= arrivalDate.Value && re.departure <= departureDate.Value)  ; });
              //  if (Room.booked == false && res.Find()) ;
                db.reservations.Add(reservation);
                Room.booked = true ;
                db.SaveChanges();
                
            MessageBox.Show("Registration Successful");
                

            }
            catch
            {
                MessageBox.Show("Registration Failed!!");
            }


}

        private void txtPrenom_TextChanged(object sender, EventArgs e)
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

        private void prenom_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new categoryUserControl());
        }
    }
}
