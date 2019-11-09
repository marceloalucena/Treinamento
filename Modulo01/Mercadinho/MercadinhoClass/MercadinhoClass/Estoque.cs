using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class Estoque: Entity
    {
        //public int Id { get; set; }
        public Produto Produto { get; set; }
        public int QtdeEstoqueAtual { get; set; }
        public int QtdeEstoqueMinimo { get; set; }

    }
}
