using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class FornecedorMap: EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMap()
        {
            ToTable("Fornecedores");

            HasKey(p => p.Id);
            Property(x => x.Nome).IsRequired().HasMaxLength(50);
        }

    }
}
