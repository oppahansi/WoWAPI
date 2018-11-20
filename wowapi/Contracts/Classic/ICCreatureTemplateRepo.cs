using System.Collections.Generic;
using System.Threading.Tasks;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;
using wowapi.Models.Details;

namespace wowapi.Contracts.Classic
{
    public interface ICCreatureTemplateRepo
    {
        #region Creature Templates - Raw Db

        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatessAsync(CreatureFilterParams filterParams);
        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesByTypeAsync(byte creatureType, CreatureFilterParams filterParams);
        Task<CCreatureTemplate> GetCreatureTemplateByEntryAsync(uint entry);
        Task<CCreatureTemplate> GetCreatureTemplateByNameAsync(string name);


        #endregion

        #region Npcs - Prepared Creature Templates

        Task<IEnumerable<NpcDetailsBase>> GetNpcsAsync(CreatureFilterParams filterParams);
        Task<IEnumerable<NpcDetailsBase>> GetNpcsByTypeAsync(byte creatureType, CreatureFilterParams filterParams);
        Task<IEnumerable<NpcDetailsBase>> GetNpcsByFamilytAsync(sbyte creatureFamily, CreatureFilterParams filterParams);
        Task<NpcDetails> GetNpcDetailsByEntryAsync(uint entry);
        Task<NpcDetails> GetNpcDetailsByFiltersAsync(CreatureFilterParams filterParams);

        #endregion
    }
}
