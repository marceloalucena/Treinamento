using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MAL.Bussiness.Interfaces;
using MAL.Bussiness.Model;
using MAL.Bussiness.Notificacoes;
using MAL.Bussiness.Validations;

namespace MAL.Bussiness.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService
        (
            IProdutoRepository produtoRepository,
            INotificador notificador
        ) : base(notificador)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<bool> Apagar(Produto produto)
        {
            await _produtoRepository.Apagar(produto);
            return true;
        }

        public async Task<bool> Editar(Produto produto)
        {
            if (!Validar(new ProdutoValidation(), produto)) return false;

            await _produtoRepository.Editar(produto);
            return true;
        }

        public async Task<bool> Inserir(Produto produto)
        {
            if (!Validar(new ProdutoValidation(), produto)) return false;

            await _produtoRepository.Apagar(produto);
            return true;
        }
        public void Dispose()
        {
            _produtoRepository.Dispose();
        }
    }
}
