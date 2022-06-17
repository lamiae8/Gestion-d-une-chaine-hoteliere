using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    [Table("client")]

     class client
    {
        [Key]
        [Column("codeclient")]
        public int codeclient { get; set; }


        [Column("fullname")]
        public string fullname { get; set; }




        [Column("address")]
        public string address { get; set; }


        [Column("city")]
        public string city { get; set; }

        [Column("postalcode")]
        public int postalcode { get; set; }

        [Column("country")]
        public string country { get; set; }

        [Column("phone")]
        public string phone { get; set; }

        [Column("email")]
        public string email { get; set; }

        public virtual ICollection<reservation> reservation { get; set; }
        public virtual ICollection<consumption> consumption { get; set; }


    }


   
}
