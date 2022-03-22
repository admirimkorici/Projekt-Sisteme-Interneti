namespace Projekt_Sisteme_Interneti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Degas", newName: "Dega");
            RenameTable(name: "dbo.eEnjtes", newName: "eEnjte");
            RenameTable(name: "dbo.eHenes", newName: "eHene");
            RenameTable(name: "dbo.eMartes", newName: "eMarte");
            RenameTable(name: "dbo.eMerkurs", newName: "eMerkur");
            RenameTable(name: "dbo.ePremtes", newName: "ePremte");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ePremte", newName: "ePremtes");
            RenameTable(name: "dbo.eMerkur", newName: "eMerkurs");
            RenameTable(name: "dbo.eMarte", newName: "eMartes");
            RenameTable(name: "dbo.eHene", newName: "eHenes");
            RenameTable(name: "dbo.eEnjte", newName: "eEnjtes");
            RenameTable(name: "dbo.Dega", newName: "Degas");
        }
    }
}
