namespace Projekt_Sisteme_Interneti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grupi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmGrupi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Viti",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NrViti = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.eEnjte", "VitiId", c => c.Int());
            AddColumn("dbo.eEnjte", "GrupiId", c => c.Int());
            AddColumn("dbo.eHene", "VitiId", c => c.Int());
            AddColumn("dbo.eHene", "GrupiId", c => c.Int());
            AddColumn("dbo.eMarte", "VitiId", c => c.Int());
            AddColumn("dbo.eMarte", "GrupiId", c => c.Int());
            AddColumn("dbo.eMerkur", "VitiId", c => c.Int());
            AddColumn("dbo.eMerkur", "GrupiId", c => c.Int());
            AddColumn("dbo.ePremte", "VitiId", c => c.Int());
            AddColumn("dbo.ePremte", "GrupiId", c => c.Int());
            CreateIndex("dbo.eEnjte", "VitiId");
            CreateIndex("dbo.eEnjte", "GrupiId");
            CreateIndex("dbo.eHene", "VitiId");
            CreateIndex("dbo.eHene", "GrupiId");
            CreateIndex("dbo.eMarte", "VitiId");
            CreateIndex("dbo.eMarte", "GrupiId");
            CreateIndex("dbo.eMerkur", "VitiId");
            CreateIndex("dbo.eMerkur", "GrupiId");
            CreateIndex("dbo.ePremte", "VitiId");
            CreateIndex("dbo.ePremte", "GrupiId");
            AddForeignKey("dbo.eEnjte", "GrupiId", "dbo.Grupi", "Id");
            AddForeignKey("dbo.eEnjte", "VitiId", "dbo.Viti", "Id");
            AddForeignKey("dbo.eHene", "GrupiId", "dbo.Grupi", "Id");
            AddForeignKey("dbo.eHene", "VitiId", "dbo.Viti", "Id");
            AddForeignKey("dbo.eMarte", "GrupiId", "dbo.Grupi", "Id");
            AddForeignKey("dbo.eMarte", "VitiId", "dbo.Viti", "Id");
            AddForeignKey("dbo.eMerkur", "GrupiId", "dbo.Grupi", "Id");
            AddForeignKey("dbo.eMerkur", "VitiId", "dbo.Viti", "Id");
            AddForeignKey("dbo.ePremte", "GrupiId", "dbo.Grupi", "Id");
            AddForeignKey("dbo.ePremte", "VitiId", "dbo.Viti", "Id");
            DropColumn("dbo.Dega", "Viti");
            DropColumn("dbo.Dega", "Grupi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dega", "Grupi", c => c.String());
            AddColumn("dbo.Dega", "Viti", c => c.Int(nullable: false));
            DropForeignKey("dbo.ePremte", "VitiId", "dbo.Viti");
            DropForeignKey("dbo.ePremte", "GrupiId", "dbo.Grupi");
            DropForeignKey("dbo.eMerkur", "VitiId", "dbo.Viti");
            DropForeignKey("dbo.eMerkur", "GrupiId", "dbo.Grupi");
            DropForeignKey("dbo.eMarte", "VitiId", "dbo.Viti");
            DropForeignKey("dbo.eMarte", "GrupiId", "dbo.Grupi");
            DropForeignKey("dbo.eHene", "VitiId", "dbo.Viti");
            DropForeignKey("dbo.eHene", "GrupiId", "dbo.Grupi");
            DropForeignKey("dbo.eEnjte", "VitiId", "dbo.Viti");
            DropForeignKey("dbo.eEnjte", "GrupiId", "dbo.Grupi");
            DropIndex("dbo.ePremte", new[] { "GrupiId" });
            DropIndex("dbo.ePremte", new[] { "VitiId" });
            DropIndex("dbo.eMerkur", new[] { "GrupiId" });
            DropIndex("dbo.eMerkur", new[] { "VitiId" });
            DropIndex("dbo.eMarte", new[] { "GrupiId" });
            DropIndex("dbo.eMarte", new[] { "VitiId" });
            DropIndex("dbo.eHene", new[] { "GrupiId" });
            DropIndex("dbo.eHene", new[] { "VitiId" });
            DropIndex("dbo.eEnjte", new[] { "GrupiId" });
            DropIndex("dbo.eEnjte", new[] { "VitiId" });
            DropColumn("dbo.ePremte", "GrupiId");
            DropColumn("dbo.ePremte", "VitiId");
            DropColumn("dbo.eMerkur", "GrupiId");
            DropColumn("dbo.eMerkur", "VitiId");
            DropColumn("dbo.eMarte", "GrupiId");
            DropColumn("dbo.eMarte", "VitiId");
            DropColumn("dbo.eHene", "GrupiId");
            DropColumn("dbo.eHene", "VitiId");
            DropColumn("dbo.eEnjte", "GrupiId");
            DropColumn("dbo.eEnjte", "VitiId");
            DropTable("dbo.Viti");
            DropTable("dbo.Grupi");
        }
    }
}
