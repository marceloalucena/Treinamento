using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class ProdutoRepository : iProdutoRepository
    {
        public MercadinhoContext Context { get; set; }
        public ProdutoRepository()
        {
            Context = new MercadinhoContext();
        }
        public void Inserir(Produto produto)
        {
            Context.Produtos.Add(produto);
            Context.SaveChanges();
        }
        public void Editar(Produto produto)
        {
            Produto produtoDB = Obter(produto.Id);
            if (produtoDB != null)
            {
                Context.Entry(produtoDB).CurrentValues.SetValues(produto);
                Context.SaveChanges();
            }
        }
        public void Apagar(int id)
        {
            if (Obter(id) != null)
            {
                Context.Produtos.Remove(Obter(id));
                Context.SaveChanges();
            }
        }

        public IEnumerable<Produto> Obter()
        {
            return Context.Produtos.ToList();
        }

        public Produto Obter(int id)
        {
            return Context.Produtos.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
