namespace Music_Store.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Album",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 500, unicode: false),
                        Price = c.Double(nullable: false),
                        ArtAlbumUrl = c.String(maxLength: 500, unicode: false),
                        Artist_Id = c.Int(),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artist", t => t.Artist_Id)
                .ForeignKey("dbo.Genre", t => t.Genre_Id)
                .Index(t => t.Artist_Id)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.Artist",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500, unicode: false),
                        Description = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        UserName = c.String(maxLength: 500, unicode: false),
                        FirstName = c.String(maxLength: 500, unicode: false),
                        LastName = c.String(maxLength: 500, unicode: false),
                        Address = c.String(maxLength: 500, unicode: false),
                        City = c.String(maxLength: 500, unicode: false),
                        State = c.String(maxLength: 500, unicode: false),
                        PostalCode = c.String(maxLength: 500, unicode: false),
                        Country = c.String(maxLength: 500, unicode: false),
                        Phone = c.String(maxLength: 500, unicode: false),
                        Email = c.String(maxLength: 500, unicode: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Album_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Album", t => t.Album_Id)
                .ForeignKey("dbo.Order", t => t.Order_Id)
                .Index(t => t.Album_Id)
                .Index(t => t.Order_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetail", "Order_Id", "dbo.Order");
            DropForeignKey("dbo.OrderDetail", "Album_Id", "dbo.Album");
            DropForeignKey("dbo.Album", "Genre_Id", "dbo.Genre");
            DropForeignKey("dbo.Album", "Artist_Id", "dbo.Artist");
            DropIndex("dbo.OrderDetail", new[] { "Order_Id" });
            DropIndex("dbo.OrderDetail", new[] { "Album_Id" });
            DropIndex("dbo.Album", new[] { "Genre_Id" });
            DropIndex("dbo.Album", new[] { "Artist_Id" });
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Order");
            DropTable("dbo.Genre");
            DropTable("dbo.Artist");
            DropTable("dbo.Album");
        }
    }
}
