namespace MercadinhoClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProdutoId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        QtdeVenda = c.Int(nullable: false),
                        DataVenda = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Produtos", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                        ValorCusto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FatorPreco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                        QtdeEstoque = c.Int(nullable: false),
                        QtdeEstoqueMinimo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProdutoId = c.Int(nullable: false),
                        FornecedorId = c.Int(nullable: false),
                        QtdeCompra = c.Int(nullable: false),
                        DataCompra = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedores", t => t.FornecedorId, cascadeDelete: true)
                .ForeignKey("dbo.Produtos", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId)
                .Index(t => t.FornecedorId);
            
            CreateTable(
                "dbo.Fornecedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "ProdutoId", "dbo.Produtos");
            DropForeignKey("dbo.Compras", "ProdutoId", "dbo.Produtos");
            DropForeignKey("dbo.Compras", "FornecedorId", "dbo.Fornecedores");
            DropForeignKey("dbo.Vendas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Compras", new[] { "FornecedorId" });
            DropIndex("dbo.Compras", new[] { "ProdutoId" });
            DropIndex("dbo.Vendas", new[] { "ClienteId" });
            DropIndex("dbo.Vendas", new[] { "ProdutoId" });
            DropTable("dbo.Fornecedores");
            DropTable("dbo.Compras");
            DropTable("dbo.Produtos");
            DropTable("dbo.Vendas");
            DropTable("dbo.Clientes");
        }
    }
}
