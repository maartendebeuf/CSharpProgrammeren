namespace Entity_Framework3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Task2",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Description = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Task2");
        }
    }
}
