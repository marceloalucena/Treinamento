using System;
using System.Collections.Generic;

namespace MAL.Bussiness.Model
{
    public class Fornecedor: EntidadeBase
    {
        public string Nome { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public string Documento { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }

    public enum TipoFornecedor
    {
        Fisica,
        Juridica
    }
}