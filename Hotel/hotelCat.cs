using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    [Table("hotelCat")]
    class hotelCat
    {

        [Key]
        [Column(Order = 1)]
        public int codeHotel { get; set; }
        [Key]
        [Column(Order = 2)]
        public int codeCat { get; set; }
       
        [ForeignKey("codeHotel")]
        public hotel hotel { get; set; }
        [ForeignKey("codeCat")]
        public category category { get; set; }


        [Column("prixStarCat")]
        public double prixStarCat { get; set; }



    }
}
