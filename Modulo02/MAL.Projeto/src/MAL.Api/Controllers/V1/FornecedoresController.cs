using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MAL.Bussiness.Model;
using MAL.Data;
using MAL.Bussiness.Interfaces;
using MAL.API.ViewModel;
using AutoMapper;
using MAL.Bussiness.Notificacoes;
using MAL.Bussiness.Services;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace MAL.Api.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [AllowAnonymous]

    public class FornecedoresController : ControladorBase
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IFornecedorService _fornecedorService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public FornecedoresController
        (
            IFornecedorRepository fornecedorRepository, 
            IFornecedorService fornecedorService, 
            IMapper mapper,
            INotificador notificador,
            ILogger<FornecedoresController> logger
        ) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _fornecedorService = fornecedorService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ResponseCache(Duration = 20)]
        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> GetFornecedores()
        {
            return Ok(await _fornecedorRepository.Obter());
        }

        [HttpGet("{id}")]
        [ResponseCache(Duration = 20)]
        public async Task<ActionResult<FornecedorViewModel>> GetFornecedor(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);

            _logger.LogCritical($">>>>>>>>>>>>>>>>>>>>>>>>>>>Fornecedor ID: {id}");
            _logger.LogDebug($">>>>>>>>>>>>>>>>>>>>>>>>>>> Fornecedor ID: {id}");
            _logger.LogInformation($">>>>>>>>>>>>>>>>>>>>>>>>>>> Fornecedor ID: {id}");
            _logger.LogError($">>>>>>>>>>>>>>>>>>>>>>>>>>> Fornecedor ID: {id}");
            _logger.LogWarning($">>>>>>>>>>>>>>>>>>>>>>>>>>> Fornecedor ID: {id}");

            if (fornecedor == null)
            {
                return NotFound();
            }

            return _mapper.Map<FornecedorViewModel>(fornecedor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedor(Guid id, FornecedorEditarViewModel fornecedor)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            if (id != fornecedor.Id)
            {
                return BadRequest();
            }

            try
            {
                await _fornecedorService.Editar(_mapper.Map<Fornecedor>(fornecedor));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FornecedorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //return NoContent();
            return Result("Registro Alterado com Sucesso");
        }

        [HttpPost]
        public async Task<ActionResult> PostFornecedor(FornecedorAdicionarViewModel fornecedor)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            await _fornecedorService.Inserir(_mapper.Map<Fornecedor>(fornecedor));
            return Result("Registro inserido com sucesso");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Fornecedor>> DeleteFornecedor(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            await _fornecedorService.Apagar(fornecedor);

            //return fornecedor;
            return Result("Registro apagado com sucesso");
        }

        private bool FornecedorExists(Guid id)
        {
            return _fornecedorRepository.Obter(id) != null;
        }
    }
}
