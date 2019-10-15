namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeTitular = c.String(),
                        Nascimento = c.DateTime(nullable: false),
                        Banco = c.String(),
                        Agencia = c.String(),
                        ContaCorrente = c.String(),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Limite = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contas");
        }
    }
}
