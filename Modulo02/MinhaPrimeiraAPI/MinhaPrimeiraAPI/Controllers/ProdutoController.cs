using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.DAL;
using MinhaPrimeiraAPI.Models;
using MinhaPrimeiraAPI.Models.Validations;
using MinhaPrimeiraAPI.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProdutoController : ControllerBase
    {
        /// <summary>
        /// Teste de Documentação de API.net
        /// Espero que funcione
        /// </summary>
        /// <returns>Objeto contendo valores de um produto.</returns>
        /// 

        public readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        [HttpPost]
        /// <summary>
        /// Teste de Documentação de API.net
        /// Espero que funcione
        /// </summary>
        /// <returns>Objeto contendo valores de um produto.</returns>
        /// 
        public ActionResult Inserir(ProdutoInserirViewModel produtoVM)
        {
            Produto produto = _mapper.Map<Produto>(produtoVM);

            ProdutoValidation produtoValidation = new ProdutoValidation();

            ValidationResult resultadoValidacao = produtoValidation.Validate(produto);

            if (!resultadoValidacao.IsValid)
            {
                return BadRequest(new { 
                    sucesso = false, 
                    erros = resultadoValidacao.Errors
                              .Select(y => y.ErrorMessage)
                              
                    });
            }
            else
            {

                _produtoRepository.Inserir(produto);
                return Created(nameof(Inserir), new
                {
                    sucesso = true,
                    id_produto = produto.Id
                }
                );
            }
        }
        [HttpPut]
        /// <summary>
        /// Teste de Documentação de API.net
        /// Espero que funcione
        /// </summary>
        /// <returns>Objeto contendo valores de um produto.</returns>
        /// 
        public ActionResult Editar(ProdutoEditarViewModel produtoVM)
        {
            var produto = new Produto();
            produto.Descricao = produtoVM.Descricao;
            produto.PrecoCusto = produtoVM.PrecoCusto;
            produto.PrecoVenda = produtoVM.PrecoVenda;

            _produtoRepository.Editar(produto);

            //Padrão para resposta de Editar/Atualizar
            //return NoContent();
            return Ok(new
                {
                    sucesso = true,
                    id_produto = produto.Id
                }
            );
        }
        [HttpDelete("{id}")]
        public ActionResult Excluir(int id)
        {
            var produto = _produtoRepository.Obter(id);
            if (produto != null)
            {
                _produtoRepository.Excluir(produto);
                return Ok(new
                    {
                        sucesso = true
                    }
                );
            }
            else
            {
                return NotFound(new { sucesso = false, erro = $"Produto {id} não encontrado!" });
            }

        }
        [HttpGet("{id}")]
        public ActionResult<Produto> Obter(int id)
        {
            var produto = _produtoRepository.Obter(id);
            if (produto != null)
            {
                return produto;
            }
            else
            {
                return NotFound(new { sucesso = false, erro = $"Produto {id} não encontrado!" });
            }
        }
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> ObterTodos()
        {
            var produtos = _produtoRepository.Obter();
            return Ok(produtos);
        }
    }
}