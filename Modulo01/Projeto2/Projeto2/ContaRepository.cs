using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Cliente cliente = new Cliente();
            //Banco banco = new Banco();
            if (conta.ClienteID == 0)
            {
                Context.Clientes.Add(conta.Cliente);
            }
            if (conta.BancoID == 0)
            {
                Context.Bancos.Add(conta.Banco);
            }
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

        public List<Conta> Obter()
        {
            return Context.Contas.ToList();
        }

        public Conta Obter(int id)
        {
            //return Context.Contas.Find(id);
            return Context.Contas.Where(x => x.Id == id).FirstOrDefault();
        }
        public Conta Obter(int bancoId, string conta, string agencia)        
        {
            //Pendente => Colocar and agencia = X
            //return Context.Contas.Where(x => x.ContaCorrente == conta).FirstOrDefault();
            return Context.Contas.SqlQuery($"select * from Contas where BancoID = {bancoId} and ContaCorrente = '{conta}' and agencia = '{agencia}'").FirstOrDefault();
        }
        public String RealizarSaque(Conta conta, decimal valorSaque)
        {
            if (valorSaque <= (conta.Limite+conta.Saldo))
            {
                string sql = "UPDATE Contas SET saldo=saldo-{0} where id = {1}";
                Context.Database.ExecuteSqlCommand(sql,valorSaque,conta.Id);
                return "";
            }
            else
            {
                return "O Valor do Saque é Superior ao Saldo/Limite";
            }
        }
        public void RealizarDeposito(Conta conta, decimal valorDeposito)
        {
            Context.Database.ExecuteSqlCommand($"UPDATE Contas SET saldo=saldo+{valorDeposito} where id = {conta.Id}");
        }
        public string RealizarTransferencia(Conta contaOrigem, Conta contaDestino, decimal valorTransferencia)
        {
            string resultado;
            Decimal taxa = Convert.ToDecimal(3.50D);
            if (contaOrigem.BancoID != contaDestino.BancoID)
            {
                resultado = RealizarSaque(contaOrigem, valorTransferencia + taxa);
            }
            else
            {
                resultado = RealizarSaque(contaOrigem, valorTransferencia);
            }
            if (resultado == "")
            {
                RealizarDeposito(contaDestino, valorTransferencia);
            }
            return resultado;
        }
    }
}
