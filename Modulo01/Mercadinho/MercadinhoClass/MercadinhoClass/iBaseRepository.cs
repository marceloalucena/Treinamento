using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public interface iBaseRepository<T>
    {
        void Inserir(T entidade);

        void Editar(T entidade);

        void Apagar(T entidade);

        T Obter(int Id);

        IEnumerable<T> Obter();
    }
}
