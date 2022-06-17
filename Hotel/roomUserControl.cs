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
    public partial class roomUserControl : UserControl
    {
        private chaineHoteliereContext db = new chaineHoteliereContext();
        int idhotel, idcat;
        public roomUserControl()
        {
            InitializeComponent();
        }

        public roomUserControl(int idHotel, int idCat)

        {

            InitializeComponent();
            idcat = idCat;

            idhotel = idHotel;
            var rooms = db.rooms; //la table de toutes les chambres  
            List<room> listRoom = new List<room>(); //list des chambres qui apartient à l'hotel et la categorie en question
            Label[] listLabels = { room1, room2, room3, room4, room5 };
            int i = 0;
            rooms.ToList().ForEach(r => { if (idHotel == r.hotelid && idCat == r.Categoryid) { listRoom.Add(r); Console.WriteLine(r.numroom); } });
            listRoom.ForEach(n => { listLabels[i].Text = n.numroom.ToString();i++; }); //afficher les numeros des chambres 
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new categoryUserControl());
        }

        private void roomUserControl_Click(object sender, EventArgs e)
        {

        }

        private void room1_Click(object sender, EventArgs e)
        {
            string idRoom = room1.Text;
            this.Hide();
            this.Parent.Controls.Add(new reservationUserControl(idhotel,idcat,idRoom));

        }
    }
}
