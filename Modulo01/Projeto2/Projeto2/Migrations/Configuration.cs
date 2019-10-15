namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Projeto2.Projeto2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Projeto2.Projeto2Context context)
        {
            /*
            context.Clientes.Add(new Projeto2.Cliente()
            {
                Id = 1,
                Nome = "1951",
                CPF = "215.273.828-42"
            });
            context.SaveChanges();

            context.Contas.Add(new Conta()
            {
                Id = 1,
                Agencia = "1951",
                Banco = "Banco Itaú",
                Limite = 1000,
                ContaCorrente = "034972",
                Saldo = 1000000
            });
            */
        }
    }
}
