namespace Projekt_Sisteme_Interneti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastModify : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ditet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dita = c.String(),
                        Lenda = c.String(),
                        Pedagogu = c.String(),
                        LlojiOres = c.String(),
                        Ora = c.Int(nullable: false),
                        Salla = c.String(),
                        DegaId = c.Int(),
                        VitiId = c.Int(),
                        GrupiId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dega", t => t.DegaId)
                .ForeignKey("dbo.Grupi", t => t.GrupiId)
                .ForeignKey("dbo.Viti", t => t.VitiId)
                .Index(t => t.DegaId)
                .Index(t => t.VitiId)
                .Index(t => t.GrupiId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ditet", "VitiId", "dbo.Viti");
            DropForeignKey("dbo.Ditet", "GrupiId", "dbo.Grupi");
            DropForeignKey("dbo.Ditet", "DegaId", "dbo.Dega");
            DropIndex("dbo.Ditet", new[] { "GrupiId" });
            DropIndex("dbo.Ditet", new[] { "VitiId" });
            DropIndex("dbo.Ditet", new[] { "DegaId" });
            DropTable("dbo.Ditet");
        }
    }
}
