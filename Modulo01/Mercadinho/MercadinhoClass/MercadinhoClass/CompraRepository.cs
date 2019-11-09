using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class CompraRepository : BaseRepository<Compra>
    {
        public override IEnumerable<Compra> Obter()
        {
            return _contexto.Compras.Include("Produto")
                                    .Include("Fornecedor")
                                    .ToList();
        }
        public override Compra Obter(int id)
        {
            return _contexto.Compras.Include("Produto")
                                    .Include("Fornecedor")
                                    .Where(x => x.Id == id)
                                    .FirstOrDefault();
        }

    }
}
