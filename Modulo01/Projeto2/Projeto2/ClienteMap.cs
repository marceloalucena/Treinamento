using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Clientes");

            HasKey(p => p.Id);
            Property(x => x.Nome).IsRequired().HasMaxLength(50);
            Property(x => x.CPF).IsRequired().HasMaxLength(14);
            Property(x => x.Telefone).IsRequired().HasMaxLength(20);
        }
    }
}