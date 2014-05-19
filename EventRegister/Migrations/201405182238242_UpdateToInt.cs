namespace EventRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateToInt : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.People");
            AlterColumn("dbo.People", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.People", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.People");
            AlterColumn("dbo.People", "ID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.People", "ID");
        }
    }
}
