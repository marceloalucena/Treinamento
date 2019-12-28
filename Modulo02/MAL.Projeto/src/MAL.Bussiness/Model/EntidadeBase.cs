using System;

namespace MAL.Bussiness.Model
{
    public class EntidadeBase
    {
        public EntidadeBase()
        {
            Id = Guid.NewGuid();
            DataCadastro = DateTime.Now;
        }
        public Guid Id { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}