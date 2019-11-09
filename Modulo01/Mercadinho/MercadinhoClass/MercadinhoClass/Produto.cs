using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class Produto : Entity
    {
        //public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal FatorPreco { get; set; }
        public decimal PrecoVenda
        {
            get
            {
                return Math.Round(ValorCusto * (1+(FatorPreco / 100)),2);
            }
        }
        public bool Ativo { get; set; }
        public Estoque Estoque { get; set; }
        public int QtdeEstoqueAtual
        {
            get
            {
                if (Estoque != null)
                {
                    return Estoque.QtdeEstoqueAtual;
                }
                else
                { 
                    return 0;
                }
            }
        }
        public int QtdeEstoqueMinimo => Estoque?.QtdeEstoqueMinimo??0;
        public virtual ICollection<Venda> Vendas { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
    }
}
