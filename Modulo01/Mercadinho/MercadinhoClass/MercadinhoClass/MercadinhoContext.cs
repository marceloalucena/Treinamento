using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class MercadinhoContext : DbContext
    {
        public MercadinhoContext() : base("ConexaoBD")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Compra> Compras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new FornecedorMap());
            modelBuilder.Configurations.Add(new VendaMap());
            modelBuilder.Configurations.Add(new CompraMap());
            modelBuilder.Entity<Venda>()
                .HasRequired<Produto>(c => c.Produto)
                .WithMany(a => a.Vendas)
                .HasForeignKey<int>(c => c.ProdutoId);

            modelBuilder.Entity<Venda>()
                .HasRequired<Cliente>(c => c.Cliente)
                .WithMany(a => a.Vendas)
                .HasForeignKey<int>(c => c.ClienteId);

            modelBuilder.Entity<Compra>()
                .HasRequired<Produto>(c => c.Produto)
                .WithMany(a => a.Compras)
                .HasForeignKey<int>(c => c.ProdutoId);

            modelBuilder.Entity<Compra>()
                .HasRequired<Fornecedor>(c => c.Fornecedor)
                .WithMany(a => a.Compras)
                .HasForeignKey<int>(c => c.FornecedorId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
