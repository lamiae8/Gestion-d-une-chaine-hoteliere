                                                                                                      using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    [Table("room")]
    
       
        class room
    {
        [Key]
        [Column("coderoom")]
        public int coderoom { get; set; }


        [Column("numroom")]
        public string numroom { get; set; }


        [Column("phoneroom")]
        public string phoneroom { get; set; }


        [Column("priceroom")]
        public double priceroom { get; set; }


        [Column("booked")]
        public Boolean booked  { get; set; }


        [ForeignKey("hotel")]
        public int hotelid { get; set; }

        public virtual hotel hotel { get; set; }

        [ForeignKey("category")]
        public int Categoryid { get; set; }

        public virtual category category { get; set; }
    }
}
