using Microsoft.AspNetCore.Mvc;
using StreamingServicesAPI.Models;
using StreamingServicesAPI.Repositories;

namespace StreamingServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepository genreRepository;

        public GenreController(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var genres = await genreRepository.GetAllGenre();
            return Ok(genres);
        }

        

        [HttpPost]
        public async Task<IActionResult> Create(Genre genre)
        {
            await genreRepository.CreateGenre(genre);
            return Ok();

        }
    }
}
