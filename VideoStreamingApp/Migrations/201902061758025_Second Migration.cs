namespace VideoStreamingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Thumbnail_Url", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Trailer_Url", c => c.String(nullable: false));
            DropColumn("dbo.Movies", "Thumbnail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Thumbnail", c => c.String());
            AlterColumn("dbo.Movies", "Trailer_Url", c => c.String());
            AlterColumn("dbo.Movies", "Title", c => c.String());
            DropColumn("dbo.Movies", "Thumbnail_Url");
        }
    }
}
