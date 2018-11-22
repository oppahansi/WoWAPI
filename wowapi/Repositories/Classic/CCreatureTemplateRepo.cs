using LazyCache;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wowapi.Contracts.Classic;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;
using wowapi.Enumerations;
using wowapi.Utilities;
using wowapi.Contexts;
using wowapi.Extensions;

namespace wowapi.Repository.Classic
{
    public class CCreatureTemplateRepo : CRepositoryBase<CCreatureTemplate>, ICCreatureTemplateRepo
    {
        private CRepositoryContext _repositoryContext;

        public CCreatureTemplateRepo(CRepositoryContext repositoryContext, IAppCache cache)
            : base(repositoryContext, cache)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesAsync(CreatureFilterParams filterParams)
        {
            IEnumerable<CCreatureTemplate> creatureTemplates;

            if (filterParams.IsEmpty())
                creatureTemplates = await FindAllAsync();
            else
                creatureTemplates = await FindAllByConditionsAsync(filterParams.AsFilters(), filterParams.FilterType, filterParams.ToCacheString());

            return creatureTemplates.OrderCreatureTemplates(filterParams.SortOrder);
        }

        public async Task<CCreatureTemplate> GetCreatureTemplateByEntryAsync(uint entry)
        {
            var creatureTemplate = await FindByConditionAsync(x => x.Entry == entry, "creatureTemplateEntry" + entry);
            return creatureTemplate.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault();
        }

        public async Task<CCreatureTemplate> GetCreatureTemplateByFiltersAsync(CreatureFilterParams filterParams)
        {
            var creatureTemplate = await FindAllByConditionsAsync(filterParams.AsFilters(), filterParams.FilterType, filterParams.ToCacheString());
            return creatureTemplate.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault();
        }
    }
}
