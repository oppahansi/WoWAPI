using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Classic;
using Entities;
using Entities.Models.Classic;
using Entities.ModelsPrepared;

namespace Repository.Classic
{
    public class CCreatureTemplateRepo : CRepositoryBase<CCreatureTemplate>, ICCreatureTemplateRepo
    {
        public CCreatureTemplateRepo(CRepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatessAsync()
        {
            var creatureTemplates = await FindAllAsync();
            return creatureTemplates.OrderBy(x => x.Name);
        }

        public async Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesByTypeAsync(byte creatureType)
        {
            var creatureTemplates = await FindByConditionAync(x => x.CreatureType == creatureType);
            return creatureTemplates.OrderBy(x => x.Name);
        }

        public async Task<IEnumerable<NpcsSearchResultListItem>> GetNpcsSearchResultList()
        {
            var resultList = new List<NpcsSearchResultListItem>();
            var creatureTemplates = await GetAllCreatureTemplatessAsync();

            foreach (var creatureTemplate in creatureTemplates)
                resultList.Add(new NpcsSearchResultListItem(creatureTemplate));

            return await Task.FromResult<IEnumerable<NpcsSearchResultListItem>>(resultList);
        }

        public async Task<IEnumerable<NpcsSearchResultListItem>> GetNpcsByTypeSearchResultList(byte creatureType)
        {
            var resultList = new List<NpcsSearchResultListItem>();
            var creatureTemplates = await GetAllCreatureTemplatesByTypeAsync(creatureType);

            foreach (var creatureTemplate in creatureTemplates)
                resultList.Add(new NpcsSearchResultListItem(creatureTemplate));

            return await Task.FromResult<IEnumerable<NpcsSearchResultListItem>>(resultList);
        }

        public async Task<CCreatureTemplate> GetCreatureTemplateByEntryAsync(uint entry)
        {
            var creatureTemplate = await FindByConditionAync(x => x.Entry == entry);
            return creatureTemplate.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault();
        }

        public async Task<CCreatureTemplate> GetCreatureTemplateByNameAsync(string name)
        {
            var creatureTemplate = await FindByConditionAync(x => string.Compare(x.Name.ToLower(), name.ToLower(), System.StringComparison.Ordinal) == 0);
            return creatureTemplate.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault();
        }

        
    }
}
