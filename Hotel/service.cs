using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    [Table("service")]

    class service
    {
        [Key]
        [Column("codeservice")]
        public int codeservice { get; set; }


        [Column("servicename")]
        public string servicename { get; set; }


        [Column("serviceprice")]
        public double serviceprice { get; set; }



        


        public virtual ICollection<consumption> consumptions { get; set; }

    }
}
