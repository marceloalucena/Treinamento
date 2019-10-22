using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    interface iContaRepository: iBaseRepository<Conta>
    {
        string RealizarSaque(Conta conta, decimal valorSaque);
        void RealizarDeposito(Conta conta, decimal valorDeposito);
        string RealizarTransferencia(Conta contaOrigem, Conta contaDestino, decimal valorTransferencia);
        Conta Obter(int bancoId, string conta, string agencia);
    }
}
