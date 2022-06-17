namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaineHotelierev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.hotel",
                c => new
                    {
                        code = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        address = c.String(),
                        phone = c.String(),
                        nbr_chamber = c.Int(nullable: false),
                        star = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.code);
            
        }
        
        public override void Down()
        {
            DropTable("public.hotel");
        }
    }
}
