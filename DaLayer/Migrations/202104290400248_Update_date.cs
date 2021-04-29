namespace DaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_date : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdminModels", "DOB", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdminModels", "DOB", c => c.DateTime(nullable: false));
        }
    }
}
