namespace Projekt_Sisteme_Interneti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableKomente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Komentes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Emri = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false),
                        Subjekti = c.String(),
                        Komenti = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Komentes");
        }
    }
}
