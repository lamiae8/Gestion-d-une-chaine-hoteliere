using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel { 

    [Table("category")]
    class category
    {
    [Key]
    [Column("code")]
    public int codeCat { get; set; }

    [Column("nom_category")]
    public string nom_category { get; set; }

    [Column("description")]
    public string description { get; set; }


   
    public ICollection<hotelCat> hotelCat { get; set; }
       
    public virtual ICollection<room> room { get; set; }
    }
}
