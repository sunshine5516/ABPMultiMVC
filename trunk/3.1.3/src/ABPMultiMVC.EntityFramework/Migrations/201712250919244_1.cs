namespace ABPMultiMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TaskModels", "AssignedPersonId", "dbo.AbpUsers");
            DropIndex("dbo.TaskModels", new[] { "AssignedPersonId" });
            DropTable("dbo.TaskModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TaskModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssignedPersonId = c.Long(),
                        Title = c.String(nullable: false, maxLength: 256),
                        Description = c.String(nullable: false),
                        State = c.Byte(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.TaskModels", "AssignedPersonId");
            AddForeignKey("dbo.TaskModels", "AssignedPersonId", "dbo.AbpUsers", "Id");
        }
    }
}
