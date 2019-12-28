using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using MAL.Bussiness.Interfaces;
using MAL.Bussiness.Model;
using MAL.Bussiness.Notificacoes;
using MAL.Bussiness.Validations;

namespace MAL.Bussiness.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        public FornecedorService
        (
             IFornecedorRepository fornecedorRepository,
             INotificador notificador
        ):base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;     
        }
        public async Task<bool> Apagar(Fornecedor fornecedor)
        {
           await _fornecedorRepository.Apagar(fornecedor);
           return true;
        }

        public async Task<bool> Editar(Fornecedor fornecedor)
        {
            if (!Validar(new FornecedorValidation(), fornecedor)) return false;

            if (_fornecedorRepository.Buscar(x => x.Documento == fornecedor.Documento && x.Id != fornecedor.Id).Result.Any())
            {
                Notificar($"Já existe um fornecedor cadastrado com o Documento ({fornecedor.Documento})");
                return false;
            }
            await _fornecedorRepository.Editar(fornecedor);
            return true;
        }

        public async Task<bool> Inserir(Fornecedor fornecedor)
        {
            if (!Validar(new FornecedorValidation(), fornecedor)) return false;

            if (_fornecedorRepository.Buscar(x => x.Documento == fornecedor.Documento).Result.Any())
            {
                Notificar($"Já existe um fornecedor cadastrado com o Documento ({fornecedor.Documento})");
                return false;
            }

            await _fornecedorRepository.Inserir(fornecedor);
            return true;
        }
        public void Dispose()
        {
            _fornecedorRepository.Dispose();
        }
    }
}
