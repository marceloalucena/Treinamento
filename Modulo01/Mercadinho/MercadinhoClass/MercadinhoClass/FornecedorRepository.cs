using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class FornecedorRepository : iFornecedorRepository
    {
        public MercadinhoContext Context { get; set; }
        public FornecedorRepository()
        {
            Context = new MercadinhoContext();
        }
        public void Inserir(Fornecedor fornecedor)
        {
            Context.Fornecedores.Add(fornecedor);
            Context.SaveChanges();
        }
        public void Editar(Fornecedor fornecedor)
        {
            Fornecedor fornecedorDB = Obter(fornecedor.Id);
            if (fornecedorDB != null)
            {
                Context.Entry(fornecedorDB).CurrentValues.SetValues(fornecedor);
                Context.SaveChanges();
            }
        }
        public void Apagar(int id)
        {
            if (Obter(id) != null)
            {
                Context.Fornecedores.Remove(Obter(id));
                Context.SaveChanges();
            }
        }

        public IEnumerable<Fornecedor> Obter()
        {
            return Context.Fornecedores.ToList();
        }

        public Fornecedor Obter(int id)
        {
            return Context.Fornecedores.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
