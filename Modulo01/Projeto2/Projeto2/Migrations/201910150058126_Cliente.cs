namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        CPF = c.String(nullable: false, maxLength: 14, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Contas", "Titular_Id", c => c.Int());
            CreateIndex("dbo.Contas", "Titular_Id");
            AddForeignKey("dbo.Contas", "Titular_Id", "dbo.Clientes", "Id");
            DropColumn("dbo.Contas", "NomeTitular");
            DropColumn("dbo.Contas", "Nascimento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contas", "Nascimento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contas", "NomeTitular", c => c.String(nullable: false, maxLength: 50, unicode: false));
            DropForeignKey("dbo.Contas", "Titular_Id", "dbo.Clientes");
            DropIndex("dbo.Contas", new[] { "Titular_Id" });
            DropColumn("dbo.Contas", "Titular_Id");
            DropTable("dbo.Clientes");
        }
    }
}
