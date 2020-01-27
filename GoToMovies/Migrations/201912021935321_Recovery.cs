namespace GoToMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recovery : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
