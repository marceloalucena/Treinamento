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
        public Cliente Titular { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public override string ToString()
        {
            return $"Id={Id} - Banco={Banco} - Saldo={Saldo}";
        }
    }
}
