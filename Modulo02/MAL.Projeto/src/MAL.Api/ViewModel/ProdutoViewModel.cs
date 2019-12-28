using MAL.Bussiness.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace MAL.API.ViewModel
{
    public class ProdutoViewModel
    {
        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [StringLength(1000, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }
        
        public string Imagem { get; set; }
        
        [Required(ErrorMessage = "O campo {0} � obrigat�rio")] 
        public decimal Valor { get; set; }
        
        [Required(ErrorMessage = "O campo {0} � obrigat�rio")] 
        public bool Ativo { get; set; }
        
    }
    public class ProdutoAdicionarViewModel
    {
        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        public decimal Valor { get; set; }

        public bool Ativo { get; set; }
    }

    public class ProdutoEditarViewModel
    {
        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        public decimal Valor { get; set; }

        public bool Ativo { get; set; }
    }
}