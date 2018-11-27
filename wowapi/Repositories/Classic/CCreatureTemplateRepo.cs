using LazyCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using wowapi.Contexts;
using wowapi.Contracts.Classic;
using wowapi.Enumerations;
using wowapi.Extensions;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Repository.Classic
{
    public class CCreatureTemplateRepo : RepositoryBase<CCreatureTemplate>, ICCreatureTemplateRepo
    {    
        public CCreatureTemplateRepo(CRepositoryContext repositoryContext, IAppCache cache)
            : base(repositoryContext, cache)
        {
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

        public async Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesAsync(IEnumerable<uint> entries)
        {
            return await FindByConditionAsync(x => entries.Contains(x.Entry), "creatureTemplates"+entries.ToCacheString());
        }

        public async Task<CCreatureTemplate> GetCreatureTemplateByEntryAsync(uint entry)
        {
            var creatureTemplate = await FindByConditionAsync(x => x.Entry == entry, "creatureTemplateEntry" + entry);
            return creatureTemplate.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault();
        }

        public async Task<CCreatureTemplate> GetCreatureTemplateByLootIdAsync(uint lootId)
        {
            var creatureTemplate = await FindByConditionAsync(x => x.LootId == lootId || x.Entry == lootId, "creatureTemplateByLootId" + lootId);
            return creatureTemplate.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault();
        }

        public async Task<CCreatureTemplate> GetCreatureTemplateByFiltersAsync(CreatureFilterParams filterParams)
        {
            var creatureTemplate = await FindAllByConditionsAsync(filterParams.AsFilters(), filterParams.FilterType, filterParams.ToCacheString());
            return creatureTemplate.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault();
        }
    }
}
