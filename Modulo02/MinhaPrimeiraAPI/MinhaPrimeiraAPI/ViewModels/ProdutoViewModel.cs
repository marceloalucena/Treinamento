using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.ViewModels
{
    public class ProdutoInserirViewModel
    {
        [Required(ErrorMessage = "Descrição é obrigatório")]
        [MaxLength(60, ErrorMessage = "Descrição com no máximo 60 caracteres")]
        public string Descricao { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
    }
    public class ProdutoEditarViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}
