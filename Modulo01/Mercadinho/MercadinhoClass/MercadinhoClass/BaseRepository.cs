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
            Entidade entidadeDB;
            entidadeDB = Obter(entidade.Id);
            _contexto.Entry<Entidade>(entidadeDB).CurrentValues.SetValues(entidade);
            _contexto.SaveChanges();
        }

        public void Inserir(Entidade entidade)
        {
            _contexto.Set<Entidade>().Add(entidade);
            _contexto.SaveChanges();

        }

        public virtual Entidade Obter(int id)
        {
            return _contexto.Set<Entidade>()
                .Where(p => p.Id == id)
                .FirstOrDefault();
        }

        public virtual IEnumerable<Entidade> Obter()
        {
            return _contexto.Set<Entidade>().ToList();
        }
    }
}
