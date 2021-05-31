namespace car_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class schemaChange : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Customertable");
            AlterColumn("dbo.Customertable", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customertable", "Password", c => c.String());
            RenameTable(name: "dbo.Customertable", newName: "Customers");
        }
    }
}
