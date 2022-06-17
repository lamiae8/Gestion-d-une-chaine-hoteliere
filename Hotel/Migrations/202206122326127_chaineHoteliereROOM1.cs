namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaineHoteliereROOM1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.room", "hotelid", c => c.Int(nullable: false));
            AddColumn("public.room", "Categoryid", c => c.Int(nullable: false));
            CreateIndex("public.room", "hotelid");
            CreateIndex("public.room", "Categoryid");
            AddForeignKey("public.room", "Categoryid", "public.category", "code", cascadeDelete: true);
            AddForeignKey("public.room", "hotelid", "public.hotel", "code", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("public.room", "hotelid", "public.hotel");
            DropForeignKey("public.room", "Categoryid", "public.category");
            DropIndex("public.room", new[] { "Categoryid" });
            DropIndex("public.room", new[] { "hotelid" });
            DropColumn("public.room", "Categoryid");
            DropColumn("public.room", "hotelid");
        }
    }
}
