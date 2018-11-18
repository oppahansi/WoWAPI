using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wowapi.Contracts.Classic;
using wowapi.Entities;
using wowapi.Entities.Models.Classic;
using wowapi.Entities.Models.Search;
using wowapi.Entities.ModelsPrepared;
using wowapi.Enumerations;
using wowapi.Extensions;
using wowapi.Utilities;

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

        public async Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatessAsync(CreatureFilterParams filterParams)
        {
            IEnumerable<CCreatureTemplate> creatureTemplates;

            if (filterParams.IsEmpty())
                creatureTemplates = await FindAllAsync();
            else
                creatureTemplates = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType);
                
            return creatureTemplates.OrderCCreatureTemplates(filterParams.SortOrder);
        }

        public async Task<IEnumerable<CCreatureTemplate>> GetAllCreatureTemplatesByTypeAsync(byte creatureType, CreatureFilterParams filterParams)
        {
            IEnumerable<CCreatureTemplate> creatureTemplates;

            if (filterParams.IsEmpty())
                creatureTemplates = await FindByConditionAsync(x => x.CreatureType == creatureType);
            else
            {
                filterParams.Type = creatureType;
                creatureTemplates = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType);
            }

            return creatureTemplates.OrderCCreatureTemplates(filterParams.SortOrder);
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

        public async Task<IEnumerable<NpcDetailsBase>> GetNpcsSearchResultList(CreatureFilterParams filterParams)
        {
            var resultList = new List<NpcDetailsBase>();
            IEnumerable<CCreatureTemplate> creatureTemplates;

            if (filterParams.IsEmpty())
                creatureTemplates = await FindAllAsync();
            else
                creatureTemplates = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType);

            foreach (var creatureTemplate in creatureTemplates.OrderCCreatureTemplates(filterParams.SortOrder).Take(100))
                resultList.Add(new NpcDetailsBase(creatureTemplate));

            return await Task.FromResult<IEnumerable<NpcDetailsBase>>(resultList);
        }

        public async Task<IEnumerable<NpcDetailsBase>> GetNpcsByTypeSearchResultListAsync(byte creatureType, CreatureFilterParams filterParams)
        {
            var resultList = new List<NpcDetailsBase>();
            IEnumerable<CCreatureTemplate> creatureTemplates;

            if (filterParams.IsEmpty())
                creatureTemplates = await FindByConditionAsync(x => x.CreatureType == creatureType);
            else
            {
                filterParams.Type = creatureType;
                creatureTemplates = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType);
            }

            foreach (var creatureTemplate in creatureTemplates.OrderCCreatureTemplates(filterParams.SortOrder).Take(100))
                resultList.Add(new NpcDetailsBase(creatureTemplate));

            return await Task.FromResult<IEnumerable<NpcDetailsBase>>(resultList);
        }

        public async Task<IEnumerable<NpcDetailsBase>> GetNpcsByFamilySearchResultListAsync(sbyte creatureFamily, CreatureFilterParams filterParams)
        {
            var resultList = new List<NpcDetailsBase>();
            IEnumerable<CCreatureTemplate> creatureTemplates;

            filterParams.FilterType = (byte)CommonEnums.FilterTypes.ALL;
            filterParams.Type = 1;
            filterParams.Family = creatureFamily;
            creatureTemplates = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType);

            foreach (var creatureTemplate in creatureTemplates.OrderCCreatureTemplates(filterParams.SortOrder).Take(100))
                resultList.Add(new NpcDetailsBase(creatureTemplate));

            return await Task.FromResult<IEnumerable<NpcDetailsBase>>(resultList);
        }

        public async Task<NpcDetails> GetNpcDetailsByEntryAsync(uint entry)
        {
            var searchResult = await FindByConditionAsync(x => x.Entry == entry);
            return await Task.FromResult(new NpcDetails(searchResult.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault()));
        }

        public async Task<NpcDetails> GetNpcDetailsByFiltersAsync(CreatureFilterParams filterParams)
        {
            var searchResult = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType);
            return await Task.FromResult(new NpcDetails(searchResult.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault()));
        }

        #endregion
    }
}
