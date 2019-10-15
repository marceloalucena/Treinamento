namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClienteAlteracaoTelefone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Telefone", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Telefone");
        }
    }
}
