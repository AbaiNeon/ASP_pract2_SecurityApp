namespace SecurityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedrequriedfullnameforVisitor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "FullName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "FullName", c => c.String());
        }
    }
}
