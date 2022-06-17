namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaineHoteliereConsomation2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.service", "client_codeclient", "public.client");
            DropIndex("public.service", new[] { "client_codeclient" });
            DropColumn("public.service", "client_codeclient");
        }
        
        public override void Down()
        {
            AddColumn("public.service", "client_codeclient", c => c.Int());
            CreateIndex("public.service", "client_codeclient");
            AddForeignKey("public.service", "client_codeclient", "public.client", "codeclient");
        }
    }
}
