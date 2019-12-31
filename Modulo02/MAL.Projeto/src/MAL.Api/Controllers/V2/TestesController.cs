using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAL.Bussiness.Notificacoes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAL.Api.Controllers.V2
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]

    public class TestesController : ControladorBase
    {
        public TestesController(INotificador notificador) :base(notificador)
        {

        }

        [HttpGet]
        public ActionResult<string> Versao()
        {
            return Result("Versão 2.0");
        }
    }
}