using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using wowapi.Contracts;
using wowapi.Models.Search;
using wowapi.Extensions;

namespace wowapi.Controllers.Classic
{
    [Route("api/c/[controller]")]
    public class NpcController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public NpcController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("{entry}", Name = "GetNpcDetails")]
        public async Task<IActionResult> GetNpcDetails(uint entry)
        {
            try
            {
                var npcDetails = await _repository.CreatureTemplatesRepo.GetNpcDetailsByEntryAsync(entry);

                if (npcDetails.IsEmptyObject())
                {
                    _logger.LogError($"Npc details with entry: {entry}, hasn't been found in db.");
                    return NotFound();
                }

                _logger.LogInfo($"Returned npc details with entry: {entry}");
                return Ok(npcDetails);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetAllCreatureTemplates method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetNpcDetails([FromQuery] CreatureFilterParams filterParams)
        {
            try
            {
                var npcDetails = await _repository.CreatureTemplatesRepo.GetNpcDetailsByFiltersAsync(filterParams);

                if (npcDetails.IsEmptyObject())
                {
                    _logger.LogError($"Npc details with provided filterParams, hasn't been found in db. {filterParams.ToString()}");
                    return NotFound();
                }

                _logger.LogInfo($"Returned npc details with provided filterParams. {filterParams.ToString()}");
                return Ok(npcDetails);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetAllCreatureTemplates method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}