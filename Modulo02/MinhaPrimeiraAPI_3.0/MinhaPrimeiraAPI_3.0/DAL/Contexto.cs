using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI_3._0.Model;

namespace MinhaPrimeiraAPI_3._0.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
