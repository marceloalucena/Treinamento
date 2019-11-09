using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class ProdutoRepository : BaseRepository<Produto>
    {
        public override IEnumerable<Produto> Obter()
        {
            return _contexto.Produtos.Include("Estoque").ToList();
        }

        public override Produto Obter(int id)
        {
            return _contexto.Produtos.Include("Estoque").Where(x => x.Id == id).FirstOrDefault();
        }

    }
}
