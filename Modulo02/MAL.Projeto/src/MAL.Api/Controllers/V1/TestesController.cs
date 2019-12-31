using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAL.Bussiness.Notificacoes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAL.Api.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]

    public class TestesController : ControladorBase
    {
        public TestesController(INotificador notificador) :base(notificador)
        {

        }

        [HttpGet]
        public ActionResult<string> Versao()
        {
            return Result("Versão 1.0");
        }
    }
}