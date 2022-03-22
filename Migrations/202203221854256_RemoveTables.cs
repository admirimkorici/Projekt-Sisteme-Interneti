namespace Projekt_Sisteme_Interneti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.eEnjte", newName: "Ditet");
            DropIndex("dbo.eHene", new[] { "DegaId" });
            DropIndex("dbo.eHene", new[] { "VitiId" });
            DropIndex("dbo.eHene", new[] { "GrupiId" });
            DropIndex("dbo.eMarte", new[] { "DegaId" });
            DropIndex("dbo.eMarte", new[] { "VitiId" });
            DropIndex("dbo.eMarte", new[] { "GrupiId" });
            DropIndex("dbo.eMerkur", new[] { "DegaId" });
            DropIndex("dbo.eMerkur", new[] { "VitiId" });
            DropIndex("dbo.eMerkur", new[] { "GrupiId" });
            DropIndex("dbo.ePremte", new[] { "DegaId" });
            DropIndex("dbo.ePremte", new[] { "VitiId" });
            DropIndex("dbo.ePremte", new[] { "GrupiId" });
            AddColumn("dbo.Ditet", "Dita", c => c.String());
            DropTable("dbo.eHene");
            DropTable("dbo.eMarte");
            DropTable("dbo.eMerkur");
            DropTable("dbo.ePremte");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ePremte",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriLendes = c.String(),
                        LlojiOres = c.String(),
                        Petagogu = c.String(),
                        Salla = c.String(),
                        Ora = c.DateTime(nullable: false),
                        DegaId = c.Int(),
                        VitiId = c.Int(),
                        GrupiId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.eMerkur",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriLendes = c.String(),
                        LlojiOres = c.String(),
                        Petagogu = c.String(),
                        Salla = c.String(),
                        Ora = c.DateTime(nullable: false),
                        DegaId = c.Int(),
                        VitiId = c.Int(),
                        GrupiId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.eMarte",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriLendes = c.String(),
                        LlojiOres = c.String(),
                        Petagogu = c.String(),
                        Salla = c.String(),
                        Ora = c.DateTime(nullable: false),
                        DegaId = c.Int(),
                        VitiId = c.Int(),
                        GrupiId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.eHene",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriLendes = c.String(),
                        LlojiOres = c.String(),
                        Petagogu = c.String(),
                        Salla = c.String(),
                        Ora = c.DateTime(nullable: false),
                        DegaId = c.Int(),
                        VitiId = c.Int(),
                        GrupiId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Ditet", "Dita");
            CreateIndex("dbo.ePremte", "GrupiId");
            CreateIndex("dbo.ePremte", "VitiId");
            CreateIndex("dbo.ePremte", "DegaId");
            CreateIndex("dbo.eMerkur", "GrupiId");
            CreateIndex("dbo.eMerkur", "VitiId");
            CreateIndex("dbo.eMerkur", "DegaId");
            CreateIndex("dbo.eMarte", "GrupiId");
            CreateIndex("dbo.eMarte", "VitiId");
            CreateIndex("dbo.eMarte", "DegaId");
            CreateIndex("dbo.eHene", "GrupiId");
            CreateIndex("dbo.eHene", "VitiId");
            CreateIndex("dbo.eHene", "DegaId");
            RenameTable(name: "dbo.Ditet", newName: "eEnjte");
        }
    }
}
