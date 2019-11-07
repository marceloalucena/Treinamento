using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class VendaRepository : iVendaRepository
    {
        public MercadinhoContext Context { get; set; }
        public VendaRepository()
        {
            Context = new MercadinhoContext();
        }
        public void Inserir(Venda venda)
        {
            Context.Vendas.Add(venda);
            Context.SaveChanges();
        }
        public void Editar(Venda venda)
        {
            Venda vendaDB = Obter(venda.Id);
            if (vendaDB != null)
            {
                Context.Entry(vendaDB).CurrentValues.SetValues(venda);
                Context.SaveChanges();
            }
        }
        public void Apagar(int id)
        {
            if (Obter(id) != null)
            {
                Context.Vendas.Remove(Obter(id));
                Context.SaveChanges();
            }
        }

        public IEnumerable<Venda> Obter()
        {
            return Context.Vendas.ToList();
        }

        public Venda Obter(int id)
        {
            return Context.Vendas.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
