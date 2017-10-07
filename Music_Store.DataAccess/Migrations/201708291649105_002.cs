namespace Music_Store.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Album", "Title", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Album", "ArtAlbumUrl", c => c.String(nullable: false, maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Album", "ArtAlbumUrl", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Album", "Title", c => c.String(maxLength: 500, unicode: false));
        }
    }
}
