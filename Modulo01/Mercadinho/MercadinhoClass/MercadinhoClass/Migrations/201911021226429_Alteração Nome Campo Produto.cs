namespace MercadinhoClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteraçãoNomeCampoProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "EstoqueMinimo", c => c.Int(nullable: false));
            DropColumn("dbo.Produtos", "QtdeEstoque");
            DropColumn("dbo.Produtos", "QtdeEstoqueMinimo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtos", "QtdeEstoqueMinimo", c => c.Int(nullable: false));
            AddColumn("dbo.Produtos", "QtdeEstoque", c => c.Int(nullable: false));
            DropColumn("dbo.Produtos", "EstoqueMinimo");
        }
    }
}
