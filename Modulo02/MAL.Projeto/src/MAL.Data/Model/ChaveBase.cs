using System;

namespace MAL.Data.bin.Model
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