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
using AutoMapper;
using MAL.API.ViewModel;

namespace MAL.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoViewModel>>> GetProdutos()
        {
            return Ok(await _produtoRepository.Obter());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoViewModel>> GetProduto(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);

            if (produto == null)
            {
                return NotFound();
            }
            
            return _mapper.Map<ProdutoViewModel>(produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(Guid id, ProdutoEditarViewModel produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            try
            {
                await _produtoRepository.Editar(_mapper.Map<Produto>(produto));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(id))
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
        public async Task<ActionResult<Produto>> PostProduto(ProdutoAdicionarViewModel produto)
        {
            await _produtoRepository.Inserir(_mapper.Map<Produto>(produto));

            return CreatedAtAction("PostProduto", produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> DeleteProduto(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);
            if (produto == null)
            {
                return NotFound();
            }

            await _produtoRepository.Apagar(produto);

            return produto;
        }

        private bool ProdutoExists(Guid id)
        {
            return _produtoRepository.Obter(id) != null;
        }
    }
}
