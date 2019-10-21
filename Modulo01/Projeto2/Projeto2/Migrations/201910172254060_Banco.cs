namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bancos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Contas", "BancoID", c => c.Int(nullable: false));
            CreateIndex("dbo.Contas", "BancoID");
            AddForeignKey("dbo.Contas", "BancoID", "dbo.Bancos", "Id", cascadeDelete: true);
            DropColumn("dbo.Contas", "Banco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contas", "Banco", c => c.String(nullable: false, maxLength: 50, unicode: false));
            DropForeignKey("dbo.Contas", "BancoID", "dbo.Bancos");
            DropIndex("dbo.Contas", new[] { "BancoID" });
            DropColumn("dbo.Contas", "BancoID");
            DropTable("dbo.Bancos");
        }
    }
}
