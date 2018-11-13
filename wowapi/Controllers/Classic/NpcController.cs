﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace wowapi.Controllers.Classic
{
    [Route("api/c/[controller]")]
    public class NpcController : Controller
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
                var npcDetails = await _repository.CreatureTemplateRepository.GetNpcDetailsByEntryAsync(entry);

                if (npcDetails.IsEmptyObject())
                {
                    _logger.LogError($"Npc details with entry: {entry}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned npc details with entry: {entry}");
                    return Ok(npcDetails);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetAllCreatureTemplates method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetNpcDetails([FromQuery] string name)
        {
            try
            {
                var npcDetails = await _repository.CreatureTemplateRepository.GetNpcDetailsByNameAsync(name);

                if (npcDetails.IsEmptyObject())
                {
                    _logger.LogError($"Npc details with name: {name}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned npc details with name: {name}");
                    return Ok(npcDetails);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetAllCreatureTemplates method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}