using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class BancoMap : EntityTypeConfiguration<Banco>
    {
        public BancoMap()
        {
            ToTable("Bancos");

            HasKey(p => p.Id);
            Property(x => x.Codigo).IsRequired();
            Property(x => x.Nome).IsRequired().HasMaxLength(50);
        }
    }
}
