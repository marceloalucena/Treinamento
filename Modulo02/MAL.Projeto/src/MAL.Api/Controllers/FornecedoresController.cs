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

namespace MAL.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedorRepository fornecedorRepository, IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> GetFornecedores()
        {
            return Ok(await _fornecedorRepository.Obter());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FornecedorViewModel>> GetFornecedor(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return _mapper.Map<FornecedorViewModel>(fornecedor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedor(Guid id, FornecedorEditarViewModel fornecedor)
        {
            if (id != fornecedor.Id)
            {
                return BadRequest();
            }

            try
            {
                await _fornecedorRepository.Editar(_mapper.Map<Fornecedor>(fornecedor));
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

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> PostFornecedor(FornecedorAdicionarViewModel fornecedor)
        {
            await _fornecedorRepository.Inserir(_mapper.Map<Fornecedor>(fornecedor));

            return Created("PostFornecedor", fornecedor);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Fornecedor>> DeleteFornecedor(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            await _fornecedorRepository.Apagar(fornecedor);

            return fornecedor;
        }

        private bool FornecedorExists(Guid id)
        {
            return _fornecedorRepository.Obter(id) != null;
        }
    }
}
