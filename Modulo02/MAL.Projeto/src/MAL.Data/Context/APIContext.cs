using MAL.Data.bin.Model;
using MAL.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MAL.Data.bin.Context
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> option): base(option)
        {
            
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
    }
}