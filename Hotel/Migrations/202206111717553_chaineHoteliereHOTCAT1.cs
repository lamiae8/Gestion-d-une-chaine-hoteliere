namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaineHoteliereHOTCAT1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.hotelCat", "prixStarCat", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("public.hotelCat", "prixStarCat");
        }
    }
}
