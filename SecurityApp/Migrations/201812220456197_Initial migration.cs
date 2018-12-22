namespace SecurityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Position = c.String(),
                        FullName = c.String(),
                        LastIncoming = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FullName = c.String(),
                        IIN = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitors");
            DropTable("dbo.Employees");
        }
    }
}
