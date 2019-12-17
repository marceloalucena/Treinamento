using System;

namespace MAL.Bussiness.Model
{
    public class Produto: ChaveBase
    {
        public string Nome { get; set; }  
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public Guid FornecedorID { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}