using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MAL.Bussiness.Model;

namespace MAL.Bussiness.Interfaces
{
    public interface IBaseRepository<E> : IDisposable where E : EntidadeBase
    {
        Task Inserir(E entidade);
        Task Editar(E entidade);
        Task Apagar(E entidade);
        Task<E> Obter(Guid Id);
        Task<IEnumerable<E>> Obter();
        Task<IEnumerable<E>> Buscar(Expression<Func<E, bool>> predicate);
    }
}
