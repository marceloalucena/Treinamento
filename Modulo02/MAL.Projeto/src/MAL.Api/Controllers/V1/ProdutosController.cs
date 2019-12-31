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
using MAL.Bussiness.Notificacoes;
using MAL.Bussiness.Services;

namespace MAL.Api.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ProdutosController : ControladorBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutosController
        (
            IProdutoRepository produtoRepository, 
            IProdutoService produtoService, 
            IMapper mapper,
            INotificador notificador
        ) : base(notificador)
        {
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
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
            if (!ModelState.IsValid) return Result(ModelState);
            if (id != produto.Id)
            {
                return BadRequest();
            }

            try
            {
                await _produtoService.Editar(_mapper.Map<Produto>(produto));
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

            //return NoContent();
            return Result("Registro Alterado com Sucesso");
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(ProdutoAdicionarViewModel produto)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            await _produtoService.Inserir(_mapper.Map<Produto>(produto));
            return Result("Registro Incluído com Sucesso");
            
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> DeleteProduto(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);
            if (produto == null)
            {
                return NotFound();
            }

            await _produtoService.Apagar(produto);

            //return produto;
            return Result("Registro Apagado com Sucesso");
        }

        private bool ProdutoExists(Guid id)
        {
            return _produtoRepository.Obter(id) != null;
        }
    }
}
