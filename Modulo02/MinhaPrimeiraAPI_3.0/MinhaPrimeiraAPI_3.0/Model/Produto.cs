using System.ComponentModel.DataAnnotations;

namespace MinhaPrimeiraAPI_3._0.Model
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Descrição é obrigatório")]
        [MaxLength(60,ErrorMessage = "Descrição com no máximo 60 caracteres")]
        public string Descricao { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}
