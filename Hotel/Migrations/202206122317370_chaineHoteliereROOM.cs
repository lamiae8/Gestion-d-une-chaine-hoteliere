namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaineHoteliereROOM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.room",
                c => new
                    {
                        coderoom = c.Int(nullable: false, identity: true),
                        numroom = c.String(),
                        phoneroom = c.String(),
                        priceroom = c.Double(nullable: false),
                        booked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.coderoom);
            
        }
        
        public override void Down()
        {
            DropTable("public.room");
        }
    }
}
