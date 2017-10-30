namespace ReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alteredcharacterparametersonuserinputforreviewcreation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Title", c => c.String(maxLength: 50));
            AlterColumn("dbo.Reviews", "Tagline", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Tagline", c => c.String(maxLength: 15));
            AlterColumn("dbo.Reviews", "Title", c => c.String(maxLength: 25));
        }
    }
}
