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
using wowapi.Services;

namespace wowapi.Controllers.Classic
{
    [Route("api/c/[controller]")]
    public class ItemsController : ControllerBase
    {
        private ILoggerManager _logger;
        private ICRepositoryWrapper _repository;
        private IDbcRepositoryWrapper _dbcRepository;
        private IAggregatorService _aggregator;

        public ItemsController(ILoggerManager logger, ICRepositoryWrapper repository, IDbcRepositoryWrapper dbcRepository, IAggregatorService aggregator)
        {
            _logger = logger;
            _repository = repository;
            _dbcRepository = dbcRepository;
            _aggregator = aggregator;
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

                await _aggregator.AggregateItemInfoAsync(itemTemplate);
                
                _logger.LogInfo($"Returned item details with entry: {entry}");
                
                return Ok(itemTemplate.CreateResponeObject());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetItem method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}