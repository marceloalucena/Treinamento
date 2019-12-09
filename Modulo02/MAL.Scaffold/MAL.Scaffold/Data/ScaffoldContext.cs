using MAL.Scaffold.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAL.Scaffold.Data
{
    public class ScaffoldContext: DbContext
    {
        public ScaffoldContext(DbContextOptions<ScaffoldContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
