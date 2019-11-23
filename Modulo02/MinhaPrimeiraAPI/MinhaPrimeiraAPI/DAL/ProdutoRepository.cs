using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using MinhaPrimeiraAPI.Models;
using MinhaPrimeiraAPI.Models.Validations;

namespace MinhaPrimeiraAPI.DAL
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly Contexto _contexto;
        public ProdutoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Editar(Produto produto)
        {
            _contexto.Produtos.Update(produto);
            _contexto.SaveChanges();
        }

        public void Excluir(Produto produto)
        {
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();
        }

        public void Inserir(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();
        }

        public Produto Obter(int id)
        {
            return _contexto.Produtos.Find(id);
        }

        public IEnumerable<Produto> Obter()
        {
            return _contexto.Produtos.ToList();
        }
    }
}
