using LazyCache;
using wowapi.Contexts;
using wowapi.Contracts;
using wowapi.Contracts.Classic;
using wowapi.Contracts.Dbc;
using wowapi.Repositories.Classic;

namespace wowapi.Repository.Classic
{
    public class DbcRepositoryWrapper : IDbcRepositoryWrapper
    {
        private DbcRepositoryContext _dbcRepoContext;
        private readonly IAppCache _cache;

        private IItemSetRepo _itemSetRepo;
        public IItemSetRepo ItemSetRepo
        {
            get
            {
                if (_itemSetRepo == null)
                {
                    _itemSetRepo = new ItemSetRepo(_dbcRepoContext, _cache);
                }

                return _itemSetRepo;
            }
        }

        private IItemDisplayInfoRepo _itemDisplayInfoRepo;
        public IItemDisplayInfoRepo ItemDisplayInfoRepo
        {
            get
            {
                if (_itemDisplayInfoRepo == null)
                {
                    _itemDisplayInfoRepo = new ItemDisplayInfoRepo(_dbcRepoContext, _cache);
                }

                return _itemDisplayInfoRepo;
            }
        }

        public DbcRepositoryWrapper(DbcRepositoryContext dbcRepositoryContext, IAppCache cache)
        {
            _dbcRepoContext = dbcRepositoryContext;
            _cache = cache;
        }
    }
}
