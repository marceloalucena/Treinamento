namespace MercadinhoClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Estoque_Campo_EstoqueAtual : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estoque", "QtdeEstoqueAtual", c => c.Int(nullable: false));
            DropColumn("dbo.Estoque", "QtdeEstoque");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Estoque", "QtdeEstoque", c => c.Int(nullable: false));
            DropColumn("dbo.Estoque", "QtdeEstoqueAtual");
        }
    }
}
