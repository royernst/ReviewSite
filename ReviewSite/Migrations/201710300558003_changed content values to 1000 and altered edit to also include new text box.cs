namespace ReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedcontentvaluesto1000andalterededittoalsoincludenewtextbox : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Content", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Content", c => c.String(maxLength: 500));
        }
    }
}
