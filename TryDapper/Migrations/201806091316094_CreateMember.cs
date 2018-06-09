namespace TryDapper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMember : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ClassCode = c.String(),
                        ClassName = c.String(),
                        GradeCode = c.String(),
                        GradeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}
