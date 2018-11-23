using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using wowapi.Contracts;
using wowapi.Contracts.Dbc;
using wowapi.Extensions;
using wowapi.Models.Db.Classic;
using wowapi.Models.Db.Dbc;
using wowapi.Models.Search;

namespace wowapi.Controllers.Classic
{
    [Route("api/c/[controller]")]
    public class ItemSetsController : ControllerBase
    {
        private ILoggerManager _logger;
        private IDbcRepositoryWrapper _repository;

        public ItemSetsController(ILoggerManager logger, IDbcRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetItemSetsAsync([FromQuery] ItemSetFilterParams filterParams)
        {   
            try
            {
                var itemSetList = await _repository.ItemSetRepo.GetItemSetsAsync(filterParams);
                var paginatedList = await PaginatedList<CItemSet>.CreateAsync(itemSetList, filterParams.Page, filterParams.PageSize > 100 ? 100 : filterParams.PageSize);
                
                var responseObject = new
                {
                    category = "itemsets",
                    page = paginatedList.PageIndex,
                    totalPages = paginatedList.TotalPages,
                    pageSize = paginatedList.PageSize,
                    items = paginatedList.CreateResultObject()
                };

                _logger.LogInfo($"Returned itemsets. {filterParams.ToString()}");

                return Ok(responseObject);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetItemSetsAsync method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}", Name = "GetItemSet")]
        public async Task<IActionResult> GetItemSetAsync(uint id)
        {
            try
            {
                var itemSet = await _repository.ItemSetRepo.GetItemSetAsync(id);

                if (itemSet.IsEmptyObject())
                {
                    _logger.LogError($"Item set with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _logger.LogInfo($"Returned item set with id: {id}");
                
                return Ok(itemSet.CreateResponeObject());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetItemSetAsync method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}