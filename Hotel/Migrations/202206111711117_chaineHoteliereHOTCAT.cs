namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaineHoteliereHOTCAT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.hotelCat",
                c => new
                    {
                        codeHotel = c.Int(nullable: false),
                        codeCat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.codeHotel, t.codeCat })
                .ForeignKey("public.category", t => t.codeCat, cascadeDelete: true)
                .ForeignKey("public.hotel", t => t.codeHotel, cascadeDelete: true)
                .Index(t => t.codeHotel)
                .Index(t => t.codeCat);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.hotelCat", "codeHotel", "public.hotel");
            DropForeignKey("public.hotelCat", "codeCat", "public.category");
            DropIndex("public.hotelCat", new[] { "codeCat" });
            DropIndex("public.hotelCat", new[] { "codeHotel" });
            DropTable("public.hotelCat");
        }
    }
}
