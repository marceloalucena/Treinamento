using FluentValidation;
using MAL.Bussiness.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static MAL.Bussiness.Validations.Personalizados.Documentos;

namespace MAL.Bussiness.Validations
{
    public class FornecedorValidation: AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .Length(2, 100).WithMessage("Nome precisa ter entre 2 e 100 caracteres")
                .NotEmpty().WithMessage("Nome precisa ser preenchido");
            When(f => f.TipoFornecedor == TipoFornecedor.Fisica, () =>
            {
                RuleFor(f => f.Documento.Length)
                    .Equal(CpfValidacao.TamanhoCpf).WithMessage($"O Documento precisa ter {CpfValidacao.TamanhoCpf} caracteres");
                RuleFor(f => CpfValidacao.Validar(f.Documento)).Equal(true).WithMessage("CPF inválido");
            });
            When(f => f.TipoFornecedor == TipoFornecedor.Juridica, () =>
            {
                RuleFor(f => f.Documento.Length)
                    .Equal(CnpjValidacao.TamanhoCnpj).WithMessage($"O Documento precisa ter {CnpjValidacao.TamanhoCnpj} caracteres");
                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true).WithMessage("CNPJ inválido");
            }); 

        }
    }
}
