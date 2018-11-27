using LazyCache;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wowapi.Contexts;
using wowapi.Contracts.Classic;
using wowapi.Enumerations;
using wowapi.Extensions;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Repository.Classic
{
    public class CCreatureLootTemplateRepo : RepositoryBase<CCreatureLootTemplate>, ICCreatureLootTemplateRepo
    {    
        public CCreatureLootTemplateRepo(CRepositoryContext repositoryContext, IAppCache cache)
            : base(repositoryContext, cache)
        {
        }

        public async Task<IEnumerable<CCreatureLootTemplate>> GetCreatureLootTemplatesByEntryAsync(uint entry)
        {
            return await FindByConditionAsync(x => x.Entry == entry, "creatureLootTemplateEntry" + entry);
        }

        public async Task<IEnumerable<CCreatureLootTemplate>> GetCreatureLootTemplateByItemEntryAsync(uint itemEntry)
        {
            return await FindByConditionAsync(x => x.Item == itemEntry, "creatureLootTemplateItemEntry" + itemEntry);;
        }

        public async Task<IEnumerable<CCreatureLootTemplate>> GetCreatureLootTemplatesByItemEntriesAsync(IEnumerable<uint> itemEntries)
        {
            return await FindByConditionAsync(x => itemEntries.Contains(x.Item), "creatureLootTemplatesByItemEntries" + itemEntries.ToCacheString());;
        }

        
    }
}
