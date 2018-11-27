using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using wowapi.Contracts;
using wowapi.Contracts.Classic;
using wowapi.Extensions;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Controllers.Classic
{
    [Route("api/c/[controller]")]
    public class NpcsController : ControllerBase
    {
        private ILoggerManager _logger;
        private ICRepositoryWrapper _repository;

        public NpcsController(ILoggerManager logger, ICRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetNpcsAsync([FromQuery] CreatureFilterParams filterParams)
        {   
            try
            {
                var creatureList = await _repository.CreatureTemplatesRepo.GetAllCreatureTemplatesAsync(filterParams);
                var paginatedCreatureList = await PaginatedList<CCreatureTemplate>.CreateAsync(creatureList, filterParams.Page, filterParams.PageSize > 100 ? 100 : filterParams.PageSize);
                
                var responseObject = new
                {
                    category = "npcs",
                    page = paginatedCreatureList.PageIndex,
                    totalPages = paginatedCreatureList.TotalPages,
                    pageSize = paginatedCreatureList.PageSize,
                    items = paginatedCreatureList.CreateResultObject()
                };

                _logger.LogInfo($"Returned npc details. {filterParams.ToString()}");

                return Ok(responseObject);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetNpcs method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{entry}", Name = "GetNpc")]
        public async Task<IActionResult> GetNpcAsync(uint entry)
        {
            try
            {
                var creatureTemplate = await _repository.CreatureTemplatesRepo.GetCreatureTemplateByEntryAsync(entry);

                if (creatureTemplate.IsEmptyObject())
                {
                    _logger.LogError($"Npc details with entry: {entry}, hasn't been found in db.");
                    return NotFound();
                }

                _logger.LogInfo($"Returned npc details with entry: {entry}");
                
                return Ok(creatureTemplate.CreateResponeObject());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetNpc method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}