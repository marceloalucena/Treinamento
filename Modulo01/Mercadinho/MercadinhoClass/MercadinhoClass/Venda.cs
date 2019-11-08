using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class Venda : Entity
    {
        //public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int QtdeVenda { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
