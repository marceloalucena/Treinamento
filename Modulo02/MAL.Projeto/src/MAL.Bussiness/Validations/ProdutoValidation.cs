using FluentValidation;
using MAL.Bussiness.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAL.Bussiness.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(f => f.Nome)
                .Length(2, 100).WithMessage("Nome precisa ter entre 2 e 100 caracteres")
                .Empty().WithMessage("Nome precisa ser preenchido");

        }
    }
}
