namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaineHotelierev2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.category",
                c => new
                    {
                        code = c.Int(nullable: false, identity: true),
                        nom_category = c.Int(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.code);
            
        }
        
        public override void Down()
        {
            DropTable("public.category");
        }
    }
}
