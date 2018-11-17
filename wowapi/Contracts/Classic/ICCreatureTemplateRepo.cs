using System.Collections.Generic;
using System.Threading.Tasks;
using wowapi.Entities.Models.Classic;
using wowapi.Entities.Models.Search;
using wowapi.Entities.ModelsPrepared;

namespace wowapi.Contracts.Classic
{
    public interface ICCreatureTemplateRepo
    {
        #region Creature Templates - Raw Db

        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatessAsync();
        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesByTypeAsync(byte creatureType);
        Task<CCreatureTemplate> GetCreatureTemplateByEntryAsync(uint entry);
        Task<CCreatureTemplate> GetCreatureTemplateByNameAsync(string name);


        #endregion

        #region Npcs - Prepared Creature Templates

        Task<IEnumerable<NpcDetailsBase>> GetNpcsSearchResultList(CreatureFilterParams filterParams);
        Task<IEnumerable<NpcDetailsBase>> GetNpcsByTypeSearchResultListAsync(byte creatureType, CreatureFilterParams filterParams);
        Task<NpcDetails> GetNpcDetailsByEntryAsync(uint entry);
        Task<NpcDetails> GetNpcDetailsByNameAsync(string name);

        #endregion
    }
}
