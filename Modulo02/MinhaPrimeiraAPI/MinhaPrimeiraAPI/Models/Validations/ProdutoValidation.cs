using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.Models.Validations
{
    public class ProdutoValidation: AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(x => x.Descricao)
                .NotEmpty()
                .WithMessage("Descrição do Produto tem que ser informada");

            RuleFor(x => x.PrecoCusto)
                .LessThan(10000)
                .GreaterThan(10)
                .WithMessage("Preço de Custo deve estar entre 10 e 1000");
        }
    }
}
