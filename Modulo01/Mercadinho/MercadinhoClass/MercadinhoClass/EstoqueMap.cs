using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    class EstoqueMap : EntityTypeConfiguration<Estoque>
    {
        public EstoqueMap()
        {
            ToTable("Estoque");

            HasKey(p => p.Id);

            HasRequired(x => x.Produto).WithOptional(x => x.Estoque);
        }
    }
}
