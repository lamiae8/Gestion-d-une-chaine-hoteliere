using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    [Table("reservation")]

     class reservation
    {
        [Key]
        [Column("codereservation")]
        public int codereservation { get; set; }


        [Column("arrival")]
        public DateTime arrival { get; set; }


        [Column("departure")]
        public DateTime departure { get; set; }


        [Column("deposit")]
        public double deposit { get; set; }


        [Column("datedeposit")]
        public DateTime datedeposit { get; set; }


        [ForeignKey("room")]
        public int roomid { get; set; }

        public virtual room room { get; set; }
    

        [ForeignKey("client")]
        public int clientid { get; set; }

        public virtual client client { get; set; }
    }
}
