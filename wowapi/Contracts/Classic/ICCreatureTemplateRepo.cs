using System.Collections.Generic;
using System.Threading.Tasks;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Contracts.Classic
{
    public interface ICCreatureTemplateRepo
    {
        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesAsync(CreatureFilterParams filterParams);
        Task<CCreatureTemplate> GetCreatureTemplateByEntryAsync(uint entry);
        Task<CCreatureTemplate> GetCreatureTemplateByFiltersAsync(CreatureFilterParams filterParams);
    }
}
