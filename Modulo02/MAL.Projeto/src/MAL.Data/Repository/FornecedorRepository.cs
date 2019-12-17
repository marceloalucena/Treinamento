using MAL.Bussiness.Interfaces;
using MAL.Bussiness.Model;

namespace MAL.Data.Repository
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(APIContext apiContext) : base(apiContext)
        {
        }
    }
}
