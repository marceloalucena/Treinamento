using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.DAL;
using MinhaPrimeiraAPI.Models;
using System.Collections.Generic;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProdutoController : ControllerBase
    {
        public readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        [HttpPost]
        public IActionResult Inserir(Produto produto)
        {
            _produtoRepository.Inserir(produto);
            return Ok(new
            {
                sucesso = true,
                mensagem = "funcionou a inserção"
            }
            );
        }
        [HttpPut]
        public void Editar(Produto produto)
        {
            _produtoRepository.Editar(produto);
        }
        [HttpDelete("{id}")]
        public void Excluir(int id)
        {
            var produto = _produtoRepository.Obter(id);
            if (produto != null)
              _produtoRepository.Excluir(produto);
        }
        [HttpGet("{id}")]
        public Produto Obter(int id)
        {
            return _produtoRepository.Obter(id);
        }
        [HttpGet]
        public IEnumerable<Produto> ObterTodos()
        {
            return _produtoRepository.Obter();
        }
    }
}