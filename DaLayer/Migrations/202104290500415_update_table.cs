namespace DaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_table : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT('AdminModels',RESEED,100001)");
        }

        public override void Down()
        {
        }
    }
}
