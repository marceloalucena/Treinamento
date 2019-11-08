using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public abstract class BaseRepository<Entidade> : iBaseRepository<Entidade> where Entidade : Entity
    {
        public MercadinhoContext _contexto { get; private set; }

        public BaseRepository()
        {
            _contexto = new MercadinhoContext();
        }

        public void Apagar(Entidade entidade)
        {
            _contexto.Set<Entidade>().Remove(entidade);

            _contexto.SaveChanges();

        }

        public void Editar(Entidade entidade)
        {
            _contexto.Entry<Entidade>(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Inserir(Entidade entidade)
        {
            _contexto.Set<Entidade>().Add(entidade);

            _contexto.SaveChanges();

        }

        public Entidade Obter(int id)
        {
            return _contexto.Set<Entidade>()
                .Where(p => p.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Entidade> Obter()
        {
            return _contexto.Set<Entidade>().ToList();
        }
    }
}
