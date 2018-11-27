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
    public class CReferenceLootTemplateRepo : RepositoryBase<CReferenceLootTemplate>, ICReferenceLootTemplateRepo
    {    
        public CReferenceLootTemplateRepo(CRepositoryContext repositoryContext, IAppCache cache)
            : base(repositoryContext, cache)
        {
        }

        public async Task<IEnumerable<CReferenceLootTemplate>> GetReferenceLootTemplatesByEntryAsync(uint entry)
        {
            return await FindByConditionAsync(x => x.Entry == entry, "referenceLootTemplateEntry" + entry);
        }

        public async Task<IEnumerable<CReferenceLootTemplate>> GetReferenceLootTemplatesByItemEntryAsync(uint itemEntry)
        {
            return await FindByConditionAsync(x => x.Item == itemEntry, "itemEntryInReferenceLootTemplate" + itemEntry);
        }

        public async Task<CReferenceLootTemplate> GetReferenceLootTemplateByItemEntryAsync(uint itemEntry)
        {
            var creatureLootTemplates = await FindByConditionAsync(x => x.Item == itemEntry, "referenceLootTemplateItemEntry" + itemEntry);
            return creatureLootTemplates.DefaultIfEmpty(new CReferenceLootTemplate()).FirstOrDefault();
        }
    }
}
