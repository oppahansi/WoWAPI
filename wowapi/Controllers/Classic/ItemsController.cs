using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using wowapi.Contracts;
using wowapi.Contracts.Classic;
using wowapi.Contracts.Dbc;
using wowapi.Extensions;
using wowapi.Models.Db.Classic;
using wowapi.Models.Db.Dbc;
using wowapi.Models.Search;

namespace wowapi.Controllers.Classic
{
    [Route("api/c/[controller]")]
    public class ItemsController : ControllerBase
    {
        private ILoggerManager _logger;
        private ICRepositoryWrapper _repository;
        private IDbcRepositoryWrapper _dbcRepository;

        public ItemsController(ILoggerManager logger, ICRepositoryWrapper repository, IDbcRepositoryWrapper dbcRepository)
        {
            _logger = logger;
            _repository = repository;
            _dbcRepository = dbcRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems([FromQuery] ItemFilterParams filterParams)
        {   
            try
            {
                var itemList = await _repository.ItemTemplateRepo.GetAllItemTemplatesAsync(filterParams);
                var paginatedItemList = await PaginatedList<CItemTemplate>.CreateAsync(itemList, filterParams.Page, filterParams.PageSize > 100 ? 100 : filterParams.PageSize);
                
                var returnObject = new
                {
                    category = "items",
                    page = paginatedItemList.PageIndex,
                    totalPages = paginatedItemList.TotalPages,
                    pageSize = paginatedItemList.PageSize,
                    items = paginatedItemList.CreateResultObject(filterParams.Class)
                };

                _logger.LogInfo($"Returned items.");

                return Ok(returnObject);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetItems method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{entry}", Name = "GetItem")]
        public async Task<IActionResult> GetItemAsync(uint entry)
        {
            try
            {
                var itemTemplate = await _repository.ItemTemplateRepo.GetItemByEntryAsync(entry);

                if (itemTemplate.IsEmptyObject())
                {
                    _logger.LogError($"Item details with entry: {entry}, hasn't been found in db.");
                    return NotFound();
                }
                
                // TODO  move to an aggregator service ?
                CItemSet itemSet = new CItemSet();
                PaginatedList<CItemTemplate> itemSetItemList = new PaginatedList<CItemTemplate>(new List<CItemTemplate>(), 0, 0, 0);
                if (itemTemplate.Itemset != 0)
                {
                    itemSet = await _dbcRepository.ItemSetRepo.GetItemSetAsync(itemTemplate.Itemset);

                    if (!itemSet.IsEmptyObject())
                    {
                        var filterParams = new ItemFilterParams();
                        filterParams.Entries = itemSet.GetItemEntries();
                        itemSetItemList = await PaginatedList<CItemTemplate>.CreateAsync(await _repository.ItemTemplateRepo.GetAllItemTemplatesAsync(filterParams), 1, 10);
                    }
                }
                
                _logger.LogInfo($"Returned item details with entry: {entry}");
                
                return Ok(itemTemplate.CreateResponeObject(itemSetItemList.Count > 0 ? itemSetItemList.CreateResultObject(itemTemplate.Class) : null));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetItem method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}