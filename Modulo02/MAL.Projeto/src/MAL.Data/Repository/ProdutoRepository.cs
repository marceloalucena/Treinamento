using MAL.Bussiness.Interfaces;
using MAL.Bussiness.Model;

namespace MAL.Data.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(APIContext apiContext) : base(apiContext)
        {

        }
    }
}
