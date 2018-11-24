using LazyCache;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wowapi.Contexts;
using wowapi.Contracts.Classic;
using wowapi.Contracts.Dbc;
using wowapi.Extensions;
using wowapi.Models.Db.Classic;
using wowapi.Models.Db.Dbc;
using wowapi.Models.Search;

namespace wowapi.Repository.Classic
{
    public class ItemDisplayInfoRepo : RepositoryBase<CItemDisplayInfo>, IItemDisplayInfoRepo
    {
        public ItemDisplayInfoRepo(DbcRepositoryContext repositoryContext, IAppCache cache)
            : base(repositoryContext, cache)
        {
        }

        public async Task<CItemDisplayInfo> GetItemDisplayInfoAsync(uint id)
        {
            var itemDisplayInfos = await FindByConditionAsync(x => x.Id == id, "itemSetId" + id);
            return itemDisplayInfos.DefaultIfEmpty(new CItemDisplayInfo()).FirstOrDefault();
        }
    }
}
