using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class BancoRepository
    {
        public Projeto2Context Context { get; set; }
        public BancoRepository()
        {
            Context = new Projeto2Context();
        }
        public void Inserir(Banco banco)
        {
            Context.Bancos.Add(banco);
            Context.SaveChanges();
        }
        public void Editar(Banco banco)
        {
            Banco bancoDB = Obter(banco.Id);
            if (bancoDB != null)
            {
                Context.Entry(bancoDB).CurrentValues.SetValues(banco);
                Context.SaveChanges();
            }
        }
        public void Apagar(int id)
        {
            if (Obter(id) != null)
            {
                Context.Bancos.Remove(Obter(id));
                Context.SaveChanges();
            }
        }

        public IEnumerable<Banco> Obter()
        {
            return Context.Bancos.ToList();
        }

        public Banco Obter(int id)
        {
            //return Context.Contas.Find(id);
            return Context.Bancos.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
