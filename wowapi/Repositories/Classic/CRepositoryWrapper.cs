using LazyCache;
using wowapi.Contracts;
using wowapi.Contracts.Classic;
using wowapi.Entities;

namespace wowapi.Repository.Classic
{
    public class CRepositoryWrapper : IRepositoryWrapper
    {
        private CRepositoryContext _repoContext;
        private readonly IAppCache _cache;

        private ICCreatureTemplateRepo _creatureTemplatesRepo;
        public ICCreatureTemplateRepo CreatureTemplatesRepo
        {
            get
            {
                if (_creatureTemplatesRepo == null)
                {
                    _creatureTemplatesRepo = new CCreatureTemplateRepo(_repoContext, _cache);
                }

                return _creatureTemplatesRepo;
            }
        }

        private ICCreatuteRepo _creaturesRepo;
        public ICCreatuteRepo CreaturesRepo
        {
            get
            {
                if (_creaturesRepo == null)
                {
                    _creaturesRepo = new CCreatureRepo(_repoContext, _cache);
                }

                return _creaturesRepo;
            }
        }


        public CRepositoryWrapper(CRepositoryContext repositoryContext, IAppCache cache)
        {
            _repoContext = repositoryContext;
            _cache = cache;
        }
    }
}
