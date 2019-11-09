using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class Compra : Entity
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public string ProdutoDescricao => Produto?.Descricao ?? "";
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public string FornecedorNome => Fornecedor?.Nome ?? "";
        public int QtdeCompra { get; set; }
        public DateTime DataCompra { get; set; }
    }
}
