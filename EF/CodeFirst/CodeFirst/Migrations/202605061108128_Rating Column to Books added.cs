namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingColumntoBooksadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblBooks", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblBooks", "Rating");
        }
    }
}
