namespace SignLookupService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbupdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Signs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Color = c.Int(nullable: false),
                        Shape = c.Int(nullable: false),
                        Symbol = c.Int(nullable: false),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Signs");
        }
    }
}
