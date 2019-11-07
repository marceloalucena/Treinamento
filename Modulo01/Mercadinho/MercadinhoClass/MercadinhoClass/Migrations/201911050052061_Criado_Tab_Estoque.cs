namespace MercadinhoClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criado_Tab_Estoque : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        QtdeEstoque = c.Int(nullable: false),
                        QtdeEstoqueMinimo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtos", t => t.Id)
                .Index(t => t.Id);
            
            DropColumn("dbo.Produtos", "EstoqueMinimo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtos", "EstoqueMinimo", c => c.Int(nullable: false));
            DropForeignKey("dbo.Estoque", "Id", "dbo.Produtos");
            DropIndex("dbo.Estoque", new[] { "Id" });
            DropTable("dbo.Estoque");
        }
    }
}
