namespace Projekt_Sisteme_Interneti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Degas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Emri = c.String(),
                        Viti = c.Int(nullable: false),
                        Grupi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.eEnjtes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriLendes = c.String(),
                        LlojiOres = c.String(),
                        Petagogu = c.String(),
                        Salla = c.String(),
                        Ora = c.DateTime(nullable: false),
                        DegaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Degas", t => t.DegaId)
                .Index(t => t.DegaId);
            
            CreateTable(
                "dbo.eHenes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriLendes = c.String(),
                        LlojiOres = c.String(),
                        Petagogu = c.String(),
                        Salla = c.String(),
                        Ora = c.DateTime(nullable: false),
                        DegaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Degas", t => t.DegaId)
                .Index(t => t.DegaId);
            
            CreateTable(
                "dbo.eMartes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriLendes = c.String(),
                        LlojiOres = c.String(),
                        Petagogu = c.String(),
                        Salla = c.String(),
                        Ora = c.DateTime(nullable: false),
                        DegaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Degas", t => t.DegaId)
                .Index(t => t.DegaId);
            
            CreateTable(
                "dbo.eMerkurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriLendes = c.String(),
                        LlojiOres = c.String(),
                        Petagogu = c.String(),
                        Salla = c.String(),
                        Ora = c.DateTime(nullable: false),
                        DegaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Degas", t => t.DegaId)
                .Index(t => t.DegaId);
            
            CreateTable(
                "dbo.ePremtes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmriLendes = c.String(),
                        LlojiOres = c.String(),
                        Petagogu = c.String(),
                        Salla = c.String(),
                        Ora = c.DateTime(nullable: false),
                        DegaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Degas", t => t.DegaId)
                .Index(t => t.DegaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ePremtes", "DegaId", "dbo.Degas");
            DropForeignKey("dbo.eMerkurs", "DegaId", "dbo.Degas");
            DropForeignKey("dbo.eMartes", "DegaId", "dbo.Degas");
            DropForeignKey("dbo.eHenes", "DegaId", "dbo.Degas");
            DropForeignKey("dbo.eEnjtes", "DegaId", "dbo.Degas");
            DropIndex("dbo.ePremtes", new[] { "DegaId" });
            DropIndex("dbo.eMerkurs", new[] { "DegaId" });
            DropIndex("dbo.eMartes", new[] { "DegaId" });
            DropIndex("dbo.eHenes", new[] { "DegaId" });
            DropIndex("dbo.eEnjtes", new[] { "DegaId" });
            DropTable("dbo.ePremtes");
            DropTable("dbo.eMerkurs");
            DropTable("dbo.eMartes");
            DropTable("dbo.eHenes");
            DropTable("dbo.eEnjtes");
            DropTable("dbo.Degas");
        }
    }
}
