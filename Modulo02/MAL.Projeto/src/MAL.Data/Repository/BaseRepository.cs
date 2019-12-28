using System;
using System.Collections.Generic;
using MAL.Bussiness.Interfaces;
using MAL.Bussiness.Model;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MAL.Data.Repository
{
    public abstract class BaseRepository<E> : IBaseRepository<E> where E : EntidadeBase
    {
        public APIContext _apiContexto { get; private set; }
        public BaseRepository(APIContext apiContext)
        {
            _apiContexto = apiContext;
        }

        public async Task Apagar(E entidade)
        {
            _apiContexto.Set<E>().Remove(entidade);
            await _apiContexto.SaveChangesAsync();
        }

        public async Task Editar(E entidade)
        {
            E entidadeDB;
            entidadeDB = await Obter(entidade.Id);
            _apiContexto.Entry<E>(entidadeDB).CurrentValues.SetValues(entidade);
            await _apiContexto.SaveChangesAsync();
        }

        public async Task Inserir(E entidade)
        {
            _apiContexto.Set<E>().Add(entidade);
            await _apiContexto.SaveChangesAsync();
        }

        public async Task<E> Obter(Guid Id)
        {
            return await _apiContexto.Set<E>()
                .Where(p => p.Id == Id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<E>> Obter()
        {
            return await _apiContexto.Set<E>().ToListAsync();
        }
        public void Dispose()
        {
            _apiContexto.Dispose();
        }

        public async Task<IEnumerable<E>> Buscar(Expression<Func<E, bool>> predicate)
        {
            return await _apiContexto.Set<E>().Where(predicate).ToListAsync();
        }
    }
}
