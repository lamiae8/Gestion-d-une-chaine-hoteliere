using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel
{
    [Table("hotel")]
    class hotel
    {
        [Key]
        [Column("code")]
        public int codeHotel { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("address")]
        public string address { get; set; }

        [Column("phone")]
        public string phone { get; set; }

       /* [Column("nbr_chamber")]
        public int nbrChamber { get; set; }*/

        [Column("star")]
        public int star { get; set; }


        
        public virtual ICollection<hotelCat> hotelCat { get; set; }
        public virtual ICollection<room> room { get; set; }

    }
}
