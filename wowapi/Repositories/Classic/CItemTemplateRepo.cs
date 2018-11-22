using LazyCache;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wowapi.Contexts;
using wowapi.Contracts.Classic;
using wowapi.Extensions;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;
using wowapi.Repository.Classic;

namespace wowapi.Repositories.Classic
{
    public class CItemTemplateRepo : CRepositoryBase<CItemTemplate>, ICItemTemplateRepo
    {
         private CRepositoryContext _repositoryContext;

        public CItemTemplateRepo(CRepositoryContext repositoryContext, IAppCache cache)
            : base(repositoryContext, cache)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task<IEnumerable<CItemTemplate>> GetAllItemTemplatesAsync(ItemFilterParams filterParams)
        {
            IEnumerable<CItemTemplate> itemTemplates;

            if (filterParams.IsEmpty())
                itemTemplates = await FindAllAsync();
            else
                itemTemplates = await FindAllByConditionsAsync(filterParams.AsFilters(), filterParams.FilterType, filterParams.ToCacheString());

            return itemTemplates.OrderItemTemplates(filterParams.SortOrder);
        }

        public async Task<CItemTemplate> GetItemByEntryAsync(uint entry)
        {
            var itemTemplates = await FindByConditionAsync(x => x.Entry == entry, "itemEntry" + entry);
            return itemTemplates.DefaultIfEmpty(new CItemTemplate()).FirstOrDefault();
        }

        public async Task<CItemTemplate> GetItemByFiltersAsync(ItemFilterParams filterParams)
        {
            var itemTemplates = await FindAllByConditionsAsync(filterParams.AsFilters(), filterParams.FilterType, filterParams.ToCacheString());
            return itemTemplates.DefaultIfEmpty(new CItemTemplate()).FirstOrDefault();
        }
    }
}