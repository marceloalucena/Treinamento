using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MAL.Bussiness.Model;
using MAL.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MAL.Data
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
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (item.State == EntityState.Modified)
                {
                    item.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}