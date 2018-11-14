using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wowapi.Contracts.Classic;
using wowapi.Entities;
using wowapi.Entities.Models.Classic;
using wowapi.Entities.ModelsPrepared;

namespace wowapi.Repository.Classic
{
    public class CCreatureTemplateRepo : CRepositoryBase<CCreatureTemplate>, ICCreatureTemplateRepo
    {
        private CRepositoryContext _repositoryContext;

        public CCreatureTemplateRepo(CRepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        #region Creature Templates

        public async Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatessAsync()
        {
            var creatureTemplates = await FindAllAsync();
            return creatureTemplates.OrderBy(x => x.Name);
        }

        public async Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesByTypeAsync(byte creatureType)
        {
            var creatureTemplates = await FindByConditionAsync(x => x.CreatureType == creatureType);
            return creatureTemplates.OrderBy(x => x.Name);
        }

        public async Task<CCreatureTemplate> GetCreatureTemplateByEntryAsync(uint entry)
        {
            var creatureTemplate = await FindByConditionAsync(x => x.Entry == entry);
            return creatureTemplate.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault();
        }

        public async Task<CCreatureTemplate> GetCreatureTemplateByNameAsync(string name)
        {
            var creatureTemplate = await FindByConditionAsync(x => string.Compare(x.Name.ToLower(), name.ToLower(), System.StringComparison.Ordinal) == 0);
            return creatureTemplate.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault();
        }

        #endregion

        #region Npcs

        public async Task<IEnumerable<NpcDetailsBase>> GetNpcsSearchResultList()
        {
            var resultList = new List<NpcDetailsBase>();
            var creatureTemplates = await GetAllCreatureTemplatessAsync();

            foreach (var creatureTemplate in creatureTemplates)
                resultList.Add(new NpcDetailsBase(creatureTemplate));

            return await Task.FromResult<IEnumerable<NpcDetailsBase>>(resultList);
        }

        public async Task<IEnumerable<NpcDetailsBase>> GetNpcsByTypeSearchResultListAsync(byte creatureType)
        {
            var resultList = new List<NpcDetailsBase>();
            var creatureTemplates = await GetAllCreatureTemplatesByTypeAsync(creatureType);

            foreach (var creatureTemplate in creatureTemplates)
                resultList.Add(new NpcDetailsBase(creatureTemplate));

            return await Task.FromResult<IEnumerable<NpcDetailsBase>>(resultList);
        }

        public async Task<NpcDetails> GetNpcDetailsByEntryAsync(uint entry)
        {
            var creatureTemplate = await GetCreatureTemplateByEntryAsync(entry);
            return await Task.FromResult(new NpcDetails(creatureTemplate));
        }

        public async Task<NpcDetails> GetNpcDetailsByNameAsync(string name)
        {
            var creatureTemplate = await GetCreatureTemplateByNameAsync(name);
            return await Task.FromResult(new NpcDetails(creatureTemplate));
        }

        #endregion
    }
}
