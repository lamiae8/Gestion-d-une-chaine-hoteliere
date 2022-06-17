namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaineHoteliereVfullname : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.client", "fullname", c => c.String());
            DropColumn("public.client", "firstname");
            DropColumn("public.client", "lastname");
        }
        
        public override void Down()
        {
            AddColumn("public.client", "lastname", c => c.String());
            AddColumn("public.client", "firstname", c => c.String());
            DropColumn("public.client", "fullname");
        }
    }
}
