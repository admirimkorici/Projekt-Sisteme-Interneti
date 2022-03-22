namespace Projekt_Sisteme_Interneti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeDitet : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ditet", "DegaId", "dbo.Dega");
            DropForeignKey("dbo.Ditet", "GrupiId", "dbo.Grupi");
            DropForeignKey("dbo.Ditet", "VitiId", "dbo.Viti");
            DropIndex("dbo.Ditet", new[] { "DegaId" });
            DropIndex("dbo.Ditet", new[] { "VitiId" });
            DropIndex("dbo.Ditet", new[] { "GrupiId" });
            DropTable("dbo.Ditet");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Ditet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dita = c.String(),
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
            
            CreateIndex("dbo.Ditet", "GrupiId");
            CreateIndex("dbo.Ditet", "VitiId");
            CreateIndex("dbo.Ditet", "DegaId");
            AddForeignKey("dbo.Ditet", "VitiId", "dbo.Viti", "Id");
            AddForeignKey("dbo.Ditet", "GrupiId", "dbo.Grupi", "Id");
            AddForeignKey("dbo.Ditet", "DegaId", "dbo.Dega", "Id");
        }
    }
}
