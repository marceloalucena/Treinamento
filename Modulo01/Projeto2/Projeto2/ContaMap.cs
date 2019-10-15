using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class ContaMap : EntityTypeConfiguration<Conta>
    {
        public ContaMap()
        {
            ToTable("Contas");

            HasKey(p => p.Id);
            Property(x => x.Banco).IsRequired().HasMaxLength(50);
            Property(x => x.Agencia).IsRequired().HasMaxLength(4);
            Property(x => x.ContaCorrente).IsRequired().HasMaxLength(10); 
            Property(x => x.Saldo).IsRequired();
            Property(x => x.Limite).IsRequired();

        }
    }
}
