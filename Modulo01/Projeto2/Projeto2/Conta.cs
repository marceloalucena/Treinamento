using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Conta
    {
        public int Id { get; set; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
        public int BancoID { get; set; }
        public Banco Banco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public override string ToString()
        {
            return $"Id={Id} - Conta Corrente={ContaCorrente} - Saldo={Saldo}";
        }
    }
}
