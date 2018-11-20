using LazyCache;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wowapi.Contexts;
using wowapi.Contracts.Classic;
using wowapi.Models.Db.Classic;

namespace wowapi.Repository.Classic
{
    public class CCreatureRepo : CRepositoryBase<CCreature>, ICCreatuteRepo
    {
        public CCreatureRepo(CRepositoryContext repositoryContext, IAppCache cache)
            : base(repositoryContext, cache)
        {
        }

        public async Task<CCreature> GetCreaturesByGuidAsync(uint guid)
        {
            var creature = await FindByConditionAsync(x => x.Guid == guid);
            return creature.DefaultIfEmpty(new CCreature()).FirstOrDefault();
        }

        public async Task<IEnumerable<CCreature>> GetCreaturesById(uint id)
        {
            var creatures = await FindByConditionAsync(x => x.Id == id);
            return creatures.OrderBy(x => x.Guid);
        }

        public async Task<IEnumerable<CCreature>> GetCreaturesByMap(ushort map)
        {
            var creatures = await FindByConditionAsync(x => x.Map == map);
            return creatures.OrderBy(x => x.Guid);
        }
    }
}
