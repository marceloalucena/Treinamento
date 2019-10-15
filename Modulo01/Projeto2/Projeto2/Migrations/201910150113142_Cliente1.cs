namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contas", "Titular_Id", "dbo.Clientes");
            DropIndex("dbo.Contas", new[] { "Titular_Id" });
            RenameColumn(table: "dbo.Contas", name: "Titular_Id", newName: "ClienteID");
            AlterColumn("dbo.Contas", "ClienteID", c => c.Int(nullable: false));
            CreateIndex("dbo.Contas", "ClienteID");
            AddForeignKey("dbo.Contas", "ClienteID", "dbo.Clientes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contas", "ClienteID", "dbo.Clientes");
            DropIndex("dbo.Contas", new[] { "ClienteID" });
            AlterColumn("dbo.Contas", "ClienteID", c => c.Int());
            RenameColumn(table: "dbo.Contas", name: "ClienteID", newName: "Titular_Id");
            CreateIndex("dbo.Contas", "Titular_Id");
            AddForeignKey("dbo.Contas", "Titular_Id", "dbo.Clientes", "Id");
        }
    }
}
