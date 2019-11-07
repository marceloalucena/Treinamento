using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal FatorPreco { get; set; }
        public bool Ativo { get; set; }
        public Estoque Estoque { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
    }
}
