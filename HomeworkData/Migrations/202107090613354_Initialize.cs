namespace HomeworkData.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Sum = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Sum);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Results");
        }
    }
}
