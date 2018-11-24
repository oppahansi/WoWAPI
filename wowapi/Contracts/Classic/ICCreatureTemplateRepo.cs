using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Contracts.Classic
{
    public interface ICCreatureTemplateRepo
    {
        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesAsync(CreatureFilterParams filterParams);
        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesAsync(IEnumerable<uint> entries);
        Task<CCreatureTemplate> GetCreatureTemplateByEntryAsync(uint entry);
        Task<CCreatureTemplate> GetCreatureTemplateByLootIdAsync(uint lootId);
        Task<CCreatureTemplate> GetCreatureTemplateByFiltersAsync(CreatureFilterParams filterParams);
    }
}
