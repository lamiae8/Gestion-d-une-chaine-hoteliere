using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Hotel
{
    internal class chaineHoteliereContext : DbContext
    {
        public DbSet<hotel> hotels { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<hotelCat> hotelcats { get; set; }
        public DbSet<room> rooms { get; set; }
        public DbSet<client> clients { get; set; }
        public DbSet<reservation> reservations { get; set; }
        public DbSet<service> services { get; set; }
        public DbSet<consumption> consumptions { get; set; }


        public chaineHoteliereContext(): base(nameOrConnectionString : "PGConnectionString") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }


    }
}
