namespace SignLookupService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbupdate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Signs", "NumberOfAttributes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Signs", "NumberOfAttributes");
        }
    }
}
