namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacao_Varchar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contas", "NomeTitular", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Contas", "Banco", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Contas", "Agencia", c => c.String(nullable: false, maxLength: 4, unicode: false));
            AlterColumn("dbo.Contas", "ContaCorrente", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contas", "ContaCorrente", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Contas", "Agencia", c => c.String(nullable: false, maxLength: 4));
            AlterColumn("dbo.Contas", "Banco", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contas", "NomeTitular", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
