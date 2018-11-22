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
    public class ItemSetRepo : RepositoryBase<CItemSet>, IItemSetRepo
    {
        public ItemSetRepo(DbcRepositoryContext repositoryContext, IAppCache cache)
            : base(repositoryContext, cache)
        {
        }

        public async Task<IEnumerable<CItemSet>> GetItemSetsAsync(ItemSetFilterParams filterParams)
        {
            IEnumerable<CItemSet> itemSets;

            if (filterParams.IsEmpty())
                itemSets = await FindAllAsync();
            else
                itemSets = await FindAllByConditionsAsync(filterParams.AsFilters(), filterParams.FilterType, filterParams.ToCacheString());

            return itemSets.OrderItemSets(filterParams.SortOrder);
        }

        public async Task<CItemSet> GetItemSetAsync(uint id)
        {
            var creature = await FindByConditionAsync(x => x.Id == id, "itemSetId" + id);
            return creature.DefaultIfEmpty(new CItemSet()).FirstOrDefault();
        }

        public async Task<CItemSet> GetItemSetAsync(string name)
        {
            var creature = await FindByConditionAsync(x => x.Name.ToLower().CompareTo(name.ToLower()) == 0 || x.Name.ToLower().Contains(name.ToLower()), "itemSetName" + name);
            return creature.DefaultIfEmpty(new CItemSet()).FirstOrDefault();
        }
    }
}
