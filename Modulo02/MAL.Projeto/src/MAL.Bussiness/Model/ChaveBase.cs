using System;

namespace MAL.Bussiness.Model
{
    public class ChaveBase
    {
        public ChaveBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}