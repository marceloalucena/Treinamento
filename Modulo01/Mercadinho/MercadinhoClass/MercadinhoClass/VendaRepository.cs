using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class VendaRepository : BaseRepository<Venda>
    {
        public override IEnumerable<Venda> Obter()
        {
            return _contexto.Vendas.Include("Cliente").Include("Produto").ToList();
        }
        public override Venda Obter(int id)
        {
            return _contexto.Vendas.Include("Cliente")
                                   .Include("Produto")
                                   .Where(x => x.Id == id)
                                   .FirstOrDefault();
        }
    }
}
