namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaineHotelierev3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.category", "nom_category", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("public.category", "nom_category", c => c.Int(nullable: false));
        }
    }
}
