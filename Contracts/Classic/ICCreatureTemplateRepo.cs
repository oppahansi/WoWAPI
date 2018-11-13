using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models.Classic;
using Entities.ModelsPrepared;

namespace Contracts.Classic
{
    public interface ICCreatureTemplateRepo
    {
        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatessAsync();
        Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesByTypeAsync(byte creatureType);
        Task<IEnumerable<NpcDetailsBase>> GetNpcsSearchResultList();
        Task<IEnumerable<NpcDetailsBase>> GetNpcsByTypeSearchResultList(byte creatureType);
        Task<CCreatureTemplate> GetCreatureTemplateByEntryAsync(uint entry);
        Task<CCreatureTemplate> GetCreatureTemplateByNameAsync(string name);
        Task<NpcDetails> GetNpcDetailsByEntryAsync(uint entry);
        Task<NpcDetails> GetNpcDetailsByNameAsync(string name); 
    }
}
