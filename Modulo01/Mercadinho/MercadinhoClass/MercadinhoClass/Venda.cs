using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class Venda : Entity
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; private set; }
        public string ProdutoDescricao => Produto?.Descricao ?? "";
        public int ClienteId { get; set; }
        public Cliente Cliente { get; private set; }
        public string ClienteNome => Cliente?.Nome ?? "";
        public int QtdeVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorVenda { get; set; }
    }
}
