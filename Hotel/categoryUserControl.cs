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
    public partial class categoryUserControl : UserControl
    {
        private chaineHoteliereContext db = new chaineHoteliereContext();
        List<category> listName = new List<category>();
        int ID;
        int idCat;
        public categoryUserControl()
        {
            InitializeComponent();
            
        }
        public categoryUserControl(int id)
        {
            ID = id;
            

            InitializeComponent();
            Console.WriteLine("from category" + id);
            var hotelcat = db.hotelcats;
            var catName = db.categories;
             List<int> listcat = new List<int>();
           
            int i = 0;
            hotelcat.ToList().ForEach(h => { if (h.codeHotel == id) { listcat.Add(h.codeCat);  } });
            listcat.ForEach(c => { Console.WriteLine(c); listName.Add(catName.Find(c)); }) ;
            listName.ForEach(t => Console.WriteLine(t.nom_category)) ;
            Label[] listLabels = { cat1, cat2, cat3, cat4, cat5, cat6, cat7, cat8 , cat9};
            
            listName.ToList().ForEach(h => { listLabels[i].Text = h.nom_category; i++; });



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           // this.Hide();
          //  this.Parent.Controls.Add(new roomUserControl(ID));
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new hotelsUserControl());
        }

        private void categoryUserControl_Click(object sender, EventArgs e)
        {
            
        }

        private void cat1_Click(object sender, EventArgs e)
        { 
            string name = cat1.Text;
            listName.ToList().ForEach(h => { if (name == h.nom_category) { idCat = h.codeCat; Console.WriteLine(idCat); }  });

            this.Hide();
            this.Parent.Controls.Add(new roomUserControl(ID,idCat));
        }
    }
}
