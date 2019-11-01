using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class CompraRepository : iCompraRepository
    {
        public MercadinhoContext Context { get; set; }
        public CompraRepository()
        {
            Context = new MercadinhoContext();
        }
        public void Inserir(Compra compra)
        {
            Context.Compras.Add(compra);
            Context.SaveChanges();
        }
        public void Editar(Compra compra)
        {
            Compra compraDB = Obter(compra.Id);
            if (compraDB != null)
            {
                Context.Entry(compraDB).CurrentValues.SetValues(compra);
                Context.SaveChanges();
            }
        }
        public void Apagar(int id)
        {
            if (Obter(id) != null)
            {
                Context.Compras.Remove(Obter(id));
                Context.SaveChanges();
            }
        }

        public IEnumerable<Compra> Obter()
        {
            return Context.Compras.ToList();
        }

        public Compra Obter(int id)
        {
            return Context.Compras.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
