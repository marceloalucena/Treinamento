using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    interface iBaseRepository<T>
    {
        void Inserir(T entidade);
        void Editar(T entidade);
        void Apagar(int id);
        T Obter(int id);
        List<T> Obter();

    }
}
