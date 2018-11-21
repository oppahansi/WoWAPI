using System.Linq;
using System.Threading.Tasks;
using LazyCache;
using wowapi.Contexts;
using wowapi.Contracts.Classic;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;
using wowapi.Repository.Classic;
using wowapi.Utilities;

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

        public async Task<CItemTemplate> GetItemByEntryAsync(uint entry)
        {
            var itemTemplates = await FindByConditionAsync(x => x.Entry == entry, "itemEntry" + entry);
            return itemTemplates.DefaultIfEmpty(new CItemTemplate()).FirstOrDefault();
        }

        public async Task<CItemTemplate> GetItemByFiltersAsync(ItemFilterParams filterParams)
        {
            var itemTemplates = await FindAllByConditionsAsync(CommonUtils.GetItemFilters(filterParams), filterParams.FilterType, filterParams.ToCacheString());
            return itemTemplates.DefaultIfEmpty(new CItemTemplate()).FirstOrDefault();
        }
    }
}