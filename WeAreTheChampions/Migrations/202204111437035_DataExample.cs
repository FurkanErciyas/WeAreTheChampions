namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataExample : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Matches", "Score1", c => c.String());
            AlterColumn("dbo.Matches", "Score2", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Matches", "Score2", c => c.Int(nullable: false));
            AlterColumn("dbo.Matches", "Score1", c => c.Int(nullable: false));
        }
    }
}
