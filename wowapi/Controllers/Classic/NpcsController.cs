using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using wowapi.Contracts;
using wowapi.Entities.Models.Classic;

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
        public async Task<IActionResult> GetNpcs([FromQuery] CCreatureTemplate queryModel, [FromQuery] byte filterType = 0)
        {   
            try
            {
                var creatureList = await _repository.CreatureTemplatesRepo.GetNpcsSearchResultList(queryModel, filterType);

                return Ok(creatureList.Take(250));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetNpcs method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{type}", Name = "NpcsByType")]
        public async Task<IActionResult> GetNpcsByType(byte type)
        {
            try
            {
                var creatureTemplates = await _repository.CreatureTemplatesRepo.GetNpcsByTypeSearchResultListAsync(type);
                return Ok(creatureTemplates.Take(250));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetNpcsByType action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}