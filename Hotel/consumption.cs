using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    [Table("consumption")]
     class consumption
    {
        [Key]
        [Column("codeconsumption")]
        public int codeconsumption { get; set; }


        [Column("dateconsumption")]
        public DateTime dateconsumption { get; set; }

        [ForeignKey("service")]
        public int serviceid { get; set; }

        public virtual service service { get; set; }

        [ForeignKey("client")]
        public int clientid { get; set; }

        public virtual client client { get; set; }
    }
}
