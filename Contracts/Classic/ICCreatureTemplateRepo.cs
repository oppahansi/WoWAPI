using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models.Classic;
using Entities.ModelsPrepared;

namespace Contracts.Classic
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

        Task<IEnumerable<NpcDetailsBase>> GetNpcsSearchResultList();
        Task<IEnumerable<NpcDetailsBase>> GetNpcsByTypeSearchResultListAsync(byte creatureType);
        Task<NpcDetails> GetNpcDetailsByEntryAsync(uint entry);
        Task<NpcDetails> GetNpcDetailsByNameAsync(string name);

        #endregion
    }
}
