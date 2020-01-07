using MAL.Bussiness.Notificacoes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAL.Api.Controllers
{
    [ApiController]
    [Authorize]
    public abstract class ControladorBase: ControllerBase
    {
        private INotificador _notificador;
        protected ControladorBase(INotificador notificador)
        {
            _notificador = notificador;
        }
        protected ActionResult Result(Object objeto = null)
        {
            if (_notificador.TemNotificacao())
            {
                return BadRequest(new
                {
                    sucesso = false,
                    erros = _notificador.ObterNotificacoes().Select(msg => msg.Mensagem)
                });
            }

            return Ok(new
            {
                sucesso = true,
                data = objeto

            });
        }
        protected ActionResult Result(ModelStateDictionary modelState)
        {
            ObterNotificacaoModelInvalida(modelState);
            return Result();
        }
        protected void ObterNotificacaoModelInvalida(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                string mensagemErro = erro.Exception == null ? erro.ErrorMessage : erro.ErrorMessage;
                _notificador.Handle(new Notificacao(mensagemErro));
            }
        }

        protected void NotificarErro(string erro)
        {
            _notificador.Handle(new Notificacao(erro));
        }
    }
}
