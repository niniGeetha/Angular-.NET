using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StreamingServicesAPI.Models;
using StreamingServicesAPI.Repositories;

namespace StreamingServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudioController : ControllerBase
    {
        private readonly IStudioRepository studioRepository;

        public StudioController(IStudioRepository studioRepository)
        {
            this.studioRepository = studioRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudios()
        {
            var studios = await studioRepository.GetStudios();
            return Ok(studios);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetStudiosById(int id)
        {
            var studio = await studioRepository.GetStudioById(id);
            return Ok(studio);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudio(Studio studio)
        {
            var newStudio = await studioRepository.CreateStudio(studio);
            return Ok(newStudio);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateStudio(Studio studio, int id)
        {
            var updatedStudio = await studioRepository.UpdateStudio(studio, id);
            return Ok(updatedStudio);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteStudio(int id)
        {
            var deletedStudio = await studioRepository.DeleteStudio(id);
            if (deletedStudio == null)
                return NotFound();
            return Ok();
        }
    }
}
