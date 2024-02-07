using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using StreamingServicesAPI.Models;
using StreamingServicesAPI.Repositories;

namespace StreamingServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemographicGroupController : ControllerBase
    {
        private readonly IDemographicGroupRepository demographicGroupRepository;

        public DemographicGroupController(IDemographicGroupRepository demographicGroupRepository)
        {
            this.demographicGroupRepository = demographicGroupRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetDemographicGroups()
        {
            var demographicGroups = await demographicGroupRepository.GetDemographicGroups();
            return Ok(demographicGroups);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetDemographicGroupById(int id)
        {
            var demographicGroup = await demographicGroupRepository.GetDemographicGroupById(id);
            return Ok(demographicGroup);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDemographicGroup(DemographicGroup demographicGroup)
        {
            var newDemographicGroup = await demographicGroupRepository.CreateDemographicGroup(demographicGroup);
            return Ok(newDemographicGroup);
        }

        [HttpPut]
        [Route("{id}")]        
        public async Task<IActionResult> UpdateDemographicGroup(DemographicGroup demographicGroup, int id)
        {
            var updatedDemographicGroup = await demographicGroupRepository.UpdateDemographicGroup(demographicGroup, id);
            return Ok(updatedDemographicGroup);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteDemographicGroup(int id)
        {
            var deletedDemographicGroup = await demographicGroupRepository.DeleteDemographicGroup(id);
            if (deletedDemographicGroup == null)
                return NotFound();
            return Ok();
        }      

    }
}
