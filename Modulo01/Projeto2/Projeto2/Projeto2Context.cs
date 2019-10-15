using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Projeto2Context : DbContext
    {
        public Projeto2Context():base("ConexaoBD")
        {
            

        }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Configurations.Add(new ContaMap());
            modelBuilder.Configurations.Add(new ClienteMap());

            modelBuilder.Entity<Conta>()
                .HasRequired<Cliente>(c => c.Titular)
                .WithMany(a => a.Contas)
                .HasForeignKey<int>(c => c.ClienteID);

            base.OnModelCreating(modelBuilder); 
        }
    }
}
