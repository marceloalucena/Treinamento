namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClienteAlteracao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Nascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Nascimento");
        }
    }
}
