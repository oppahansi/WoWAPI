using System.Collections.Generic;
using System.Threading.Tasks;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Contracts.Classic
{
    public interface ICCreatureTemplateRepo
    {
        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatessAsync(CreatureFilterParams filterParams);
        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesByTypeAsync(byte creatureType, CreatureFilterParams filterParams);
        Task<CCreatureTemplate> GetCreatureTemplateByEntryAsync(uint entry);
        Task<CCreatureTemplate> GetCreatureTemplateByFiltersAsync(CreatureFilterParams filterParams);
    }
}
