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
    public partial class hotelsUserControl : UserControl
    {
       private chaineHoteliereContext db = new chaineHoteliereContext();
        public hotelsUserControl()
        {
            InitializeComponent();
            
            var Hotel = db.hotels;
            Label[] listHotel = { label8, label10, label11, label12, label13, label14, label15, label16 };
            int i = 0;
            Hotel.ToList().ForEach(h => { listHotel[i].Text = h.Name; i++; }) ;
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new dashboardUserControl());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            int id;
                if (sender is PictureBox)
            {
                id= Int32.Parse(((PictureBox)sender).Name.Substring(5));
                Console.WriteLine("clicked on: " +id);
                this.Hide();
           this.Parent.Controls.Add(new categoryUserControl(id));
            }
            
        } 

        private void Hotels_load(object sender, EventArgs e)
        {
          // dataGridView1.DataSource = db.hotelcats.ToList();
          
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
