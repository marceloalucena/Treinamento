using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class ContaRepository
    {
        public Projeto2Context Context { get; set; }
        public ContaRepository()
        {
            Context = new Projeto2Context();
        }
        public void Inserir(Conta conta)
        {
            Context.Contas.Add(conta);
            Context.SaveChanges();
        }
        public void Editar(Conta conta)
        {
            // Modelo 01
            //Context.Entry<Conta>(conta).State = System.Data.Entity.EntityState.Modified;
            //Context.SaveChanges();

            // Modelo 02
            Conta contaDB = Obter(conta.Id);
            if (contaDB != null)
            {
                Context.Entry(contaDB).CurrentValues.SetValues(conta);
                Context.SaveChanges();
            }
        }
        public void Apagar(int id)
        {
            if (Obter(id) != null)
            {
                Context.Contas.Remove(Obter(id));
                Context.SaveChanges();
            }
        }

        public IEnumerable<Conta> Obter()
        {
            return Context.Contas.ToList();
        }

        public Conta Obter(int id)
        {
            //return Context.Contas.Find(id);
            return Context.Contas.Where(x => x.Id == id).FirstOrDefault();
        }
        public void RealizarSaque(Conta conta, decimal valorSaque)
        {
            Context.Database.ExecuteSqlCommand($"UPDATE Contas SET saldo=saldo-{valorSaque} where id = {conta.Id}");
        }
        public void RealizarDeposito(Conta conta, decimal valorDeposito)
        {
            Context.Database.ExecuteSqlCommand($"UPDATE Contas SET saldo=saldo+{valorDeposito} where id = {conta.Id}");
        }
        public void RealizarTransferencia(Conta contaOrigem, Conta contaDestino, decimal valorTransferencia)
        {
            RealizarSaque(contaOrigem, valorTransferencia);
            RealizarDeposito(contaDestino, valorTransferencia);
        }
    }
}
