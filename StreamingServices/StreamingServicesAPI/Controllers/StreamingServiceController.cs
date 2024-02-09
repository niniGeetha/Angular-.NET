using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StreamingServicesAPI.Models;
using StreamingServicesAPI.Repositories;

namespace StreamingServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamingServiceController : ControllerBase
    {
        private readonly IStreamingServiceRepository streamingServiceRepository;

        public StreamingServiceController(IStreamingServiceRepository streamingServiceRepository)
        {
            this.streamingServiceRepository = streamingServiceRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetStreamingServices()
        {
            var streamingServices = await streamingServiceRepository.GetStreamingServices();
            return Ok(streamingServices);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetStreamingServicesById(int id)
        {
            var streamingService = await streamingServiceRepository.GetStreamingServiceById(id);
            return Ok(streamingService);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStreamingService(StreamingService streamingService)
        {
            var newStreamingService = await streamingServiceRepository.CreateStreamingService(streamingService);
            return Ok(newStreamingService);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateStreamingService(StreamingService streamingService, int id)
        {
            var updatedStreamingService = await streamingServiceRepository.UpdateStreamingService(streamingService, id);
            return Ok(updatedStreamingService);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteStreamingService(int id)
        {
            var deletedStreamingService = await streamingServiceRepository.DeleteStreamingService(id);
            if (deletedStreamingService == null)
                return NotFound();
            return Ok();
        }
    }
}
