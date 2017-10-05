namespace OzzyNote.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.note",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        note = c.String(),
                        pageId = c.Int(nullable: false),
                        Note_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.note", t => t.Note_id)
                .Index(t => t.Note_id);
            
            CreateTable(
                "dbo.page",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        notebookId = c.Int(nullable: false),
                        Page_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.page", t => t.Page_id)
                .Index(t => t.Page_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.page", "Page_id", "dbo.page");
            DropForeignKey("dbo.note", "Note_id", "dbo.note");
            DropIndex("dbo.page", new[] { "Page_id" });
            DropIndex("dbo.note", new[] { "Note_id" });
            DropTable("dbo.page");
            DropTable("dbo.note");
        }
    }
}
