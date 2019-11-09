namespace MercadinhoClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Venda_ValorVenda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendas", "ValorVenda", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vendas", "ValorVenda");
        }
    }
}
