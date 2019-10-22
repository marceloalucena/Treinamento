using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Banco 
    {
        /*public Banco(int codigo, string nome)
        {
            //this.id = Guid.NewGuid();
            Codigo = codigo;
            Nome = nome;
        }*/
        
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Conta> Contas { get; set; }


    }
}
