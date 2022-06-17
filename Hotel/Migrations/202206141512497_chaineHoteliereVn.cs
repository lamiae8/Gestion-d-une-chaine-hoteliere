namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaineHoteliereVn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.client",
                c => new
                    {
                        codeclient = c.Int(nullable: false, identity: true),
                        firstname = c.String(),
                        lastname = c.String(),
                        address = c.String(),
                        city = c.String(),
                        postalcode = c.Int(nullable: false),
                        country = c.String(),
                        phone = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.codeclient);
            
            CreateTable(
                "public.reservation",
                c => new
                    {
                        codereservation = c.Int(nullable: false, identity: true),
                        arrival = c.DateTime(nullable: false),
                        departure = c.DateTime(nullable: false),
                        deposit = c.Double(nullable: false),
                        datedeposit = c.DateTime(nullable: false),
                        roomid = c.Int(nullable: false),
                        clientid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codereservation)
                .ForeignKey("public.client", t => t.clientid, cascadeDelete: true)
                .ForeignKey("public.room", t => t.roomid, cascadeDelete: true)
                .Index(t => t.roomid)
                .Index(t => t.clientid);
            
            CreateTable(
                "public.service",
                c => new
                    {
                        codeservice = c.Int(nullable: false, identity: true),
                        servicename = c.String(),
                        serviceprice = c.Double(nullable: false),
                        dateconsomation = c.DateTime(nullable: false),
                        clientid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codeservice)
                .ForeignKey("public.client", t => t.clientid, cascadeDelete: true)
                .Index(t => t.clientid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.service", "clientid", "public.client");
            DropForeignKey("public.reservation", "roomid", "public.room");
            DropForeignKey("public.reservation", "clientid", "public.client");
            DropIndex("public.service", new[] { "clientid" });
            DropIndex("public.reservation", new[] { "clientid" });
            DropIndex("public.reservation", new[] { "roomid" });
            DropTable("public.service");
            DropTable("public.reservation");
            DropTable("public.client");
        }
    }
}
