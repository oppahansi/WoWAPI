using LazyCache;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wowapi.Contracts.Classic;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;
using wowapi.Enumerations;
using wowapi.Utilities;
using wowapi.Contexts;
using wowapi.Models.Details;
using wowapi.Extensions;

namespace wowapi.Repository.Classic
{
    public class CCreatureTemplateRepo : CRepositoryBase<CCreatureTemplate>, ICCreatureTemplateRepo
    {
        private CRepositoryContext _repositoryContext;

        public CCreatureTemplateRepo(CRepositoryContext repositoryContext, IAppCache cache)
            : base(repositoryContext, cache)
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
                creatureTemplates = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType, filterParams.ToCacheString());
                
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
                creatureTemplates = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType, filterParams.ToCacheString());
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

        public async Task<IEnumerable<NpcDetailsBase>> GetNpcsAsync(CreatureFilterParams filterParams)
        {
            var resultList = new List<NpcDetailsBase>();
            IEnumerable<CCreatureTemplate> creatureTemplates;

            if (filterParams.IsEmpty())
                creatureTemplates = await FindAllAsync();
            else
                creatureTemplates = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType, filterParams.ToCacheString());

            foreach (var creatureTemplate in PaginatedList<CCreatureTemplate>.Create(creatureTemplates.OrderCCreatureTemplates(filterParams.SortOrder), filterParams.Page, filterParams.PageSize > 100 ? 100 : filterParams.PageSize))
                resultList.Add(new NpcDetailsBase(creatureTemplate));

            return await Task.FromResult<IEnumerable<NpcDetailsBase>>(resultList);
        }

        public async Task<IEnumerable<NpcDetailsBase>> GetNpcsByTypeAsync(byte creatureType, CreatureFilterParams filterParams)
        {
            var resultList = new List<NpcDetailsBase>();
            IEnumerable<CCreatureTemplate> creatureTemplates;

            if (filterParams.IsEmpty())
                creatureTemplates = await FindByConditionAsync(x => x.CreatureType == creatureType);
            else
            {
                filterParams.Type = creatureType;
                creatureTemplates = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType, filterParams.ToCacheString());
            }

            foreach (var creatureTemplate in PaginatedList<CCreatureTemplate>.Create(creatureTemplates.OrderCCreatureTemplates(filterParams.SortOrder), filterParams.Page, filterParams.PageSize > 100 ? 100 : filterParams.PageSize))
                resultList.Add(new NpcDetailsBase(creatureTemplate));

            return await Task.FromResult<IEnumerable<NpcDetailsBase>>(resultList);
        }

        public async Task<IEnumerable<NpcDetailsBase>> GetNpcsByFamilytAsync(sbyte creatureFamily, CreatureFilterParams filterParams)
        {
            var resultList = new List<NpcDetailsBase>();
            IEnumerable<CCreatureTemplate> creatureTemplates;

            filterParams.FilterType = (byte)CommonEnums.FilterTypes.ALL;
            filterParams.Type = 1;
            filterParams.Family = creatureFamily;
            creatureTemplates = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType, filterParams.ToCacheString());

            foreach (var creatureTemplate in PaginatedList<CCreatureTemplate>.Create(creatureTemplates.OrderCCreatureTemplates(filterParams.SortOrder), filterParams.Page, filterParams.PageSize > 100 ? 100 : filterParams.PageSize))
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
            var searchResult = await FindAllByConditionsAsync(CommonUtils.GetCreatureFilters(filterParams), filterParams.FilterType, filterParams.ToCacheString());
            return await Task.FromResult(new NpcDetails(searchResult.DefaultIfEmpty(new CCreatureTemplate()).FirstOrDefault()));
        }

        #endregion
    }
}
