using FluentValidation;
using FluentValidation.Results;
using MAL.Bussiness.Model;
using MAL.Bussiness.Notificacoes;
using MAL.Bussiness.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAL.Bussiness.Services
{
    public class BaseService
    {
        private readonly INotificador _notificador;
        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }
        public void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }
        protected bool Validar<V, E>(V validacao, E entidade)
            where V : AbstractValidator<E>
            where E : EntidadeBase
            
        {
            ValidationResult result = validacao.Validate(entidade);
            if (!result.IsValid)
            {
                foreach (var erro in result.Errors)
                {
                    Notificar(erro.ErrorMessage);
                }
                return false;

            }
            return true;
        }
    }
}
