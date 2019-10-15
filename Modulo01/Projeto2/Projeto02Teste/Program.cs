using Projeto2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            ClienteRepository cliRepository = new ClienteRepository();

            #region Inserindo Cliente
            Cliente cliente = new Cliente();
            cliente.Nascimento = new DateTime(1981,12,03);
            cliente.Nome = "Marcelo Lucena";
            cliente.CPF = "215.273.828-42";

            cliRepository.Inserir(cliente);
            #endregion

            ContaRepository repository = new ContaRepository();

            #region InserirConta
            Conta conta = new Conta();
            conta.Limite = 100;
            //conta.Nascimento = new DateTime(1980, 01, 01);
            //conta.NomeTitular = "Teste Titular";
            conta.Saldo = 200;
            conta.ContaCorrente = "12345678";
            conta.Agencia = "1234";
            conta.Banco = "Banco do Brasil";

            repository.Inserir(conta);

            #endregion

            #region Editar Conta
            Conta contaEditar = new Conta();
            contaEditar.Id = 6;
            contaEditar.Limite = 100;
            contaEditar.Saldo = 200;
            contaEditar.ContaCorrente = "12345678";
            contaEditar.Agencia = "4321";
            contaEditar.Banco = "Banco do Brasiiiil";

            repository.Editar(contaEditar);
            #endregion

            #region Apagar Conta
            repository.Apagar(6);
            #endregion

            #region Obter Apenas Uma Conta
            Conta conta_1 = repository.Obter(5);
            Console.WriteLine(conta_1.ToString());
            #endregion

            #region Obter Todas As Conta
            IEnumerable<Conta> contas = repository.Obter();
            Console.WriteLine("Lista de Contas:");
            foreach (var cadaConta in contas)
            {
                Console.WriteLine(cadaConta.ToString());
            }
            #endregion

            #region DepositoNaConta
            Conta contaDeposito = repository.Obter(7);
            repository.RealizarDeposito(contaDeposito, 150);
            #endregion

            #region SaqueNaConta
            Conta contaSaque = repository.Obter(8);
            repository.RealizarSaque(contaSaque, 100);
            #endregion

            #region TransferenciaEntreContas
            Conta contaOrigem = repository.Obter(9);
            Conta contaDestino = repository.Obter(10);
            repository.RealizarTransferencia(contaOrigem, contaDestino, 1000);
            #endregion

            Console.ReadKey();
        }
    }
}
