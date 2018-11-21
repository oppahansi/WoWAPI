using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using wowapi.Contracts;
using wowapi.Extensions;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Controllers.Classic
{
    [Route("api/c/[controller]")]
    public class NpcsController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public NpcsController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetNpcs([FromQuery] CreatureFilterParams filterParams)
        {   
            try
            {
                var creatureList = await _repository.CreatureTemplatesRepo.GetAllCreatureTemplatessAsync(filterParams);
                var paginatedCreatureList = await PaginatedList<CCreatureTemplate>.Create(creatureList, filterParams.Page, filterParams.PageSize > 100 ? 100 : filterParams.PageSize);
                
                var returnObject = new
                {
                    category = "npcps",
                    page = paginatedCreatureList.PageIndex,
                    totalPages = paginatedCreatureList.TotalPages,
                    pageSize = paginatedCreatureList.PageSize,
                    items = paginatedCreatureList.Select(x => new
                    {
                        Id = x.Entry,
                        Name = x.Name,
                        SubName = x.SubName,
                        MinLevel = x.MinLevel,
                        MaxLevel = x.MaxLevel,
                        CreatureType = x.CreatureType,
                        Rank = x.Rank
                    })
                };

                _logger.LogInfo($"Returned npc details. {filterParams.ToString()}");

                return Ok(returnObject);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetNpcs method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{type}", Name = "NpcsByType")]
        public async Task<IActionResult> GetNpcsByType(byte type, [FromQuery] CreatureFilterParams filterParams)
        {
            try
            {
                var creatureList = await _repository.CreatureTemplatesRepo.GetAllCreatureTemplatesByTypeAsync(type, filterParams);                
                var paginatedCreatureList = await PaginatedList<CCreatureTemplate>.Create(creatureList, filterParams.Page, filterParams.PageSize > 100 ? 100 : filterParams.PageSize);

                var returnObject = new
                {
                    category = "npcps",
                    page = paginatedCreatureList.PageIndex,
                    totalPages = paginatedCreatureList.TotalPages,
                    pageSize = paginatedCreatureList.PageSize,
                    items = paginatedCreatureList.Select(x => new
                    {
                        Id = x.Entry,
                        Name = x.Name,
                        SubName = x.SubName,
                        MinLevel = x.MinLevel,
                        MaxLevel = x.MaxLevel,
                        CreatureType = x.CreatureType,
                        Rank = x.Rank
                    })
                };
                
                _logger.LogInfo($"Returned npc details by type. {filterParams.ToString()}");
                
                return Ok(returnObject);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetNpcsByType action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}