using Microsoft.EntityFrameworkCore;
using StreamingServicesAPI.Data;
using StreamingServicesAPI.Models;

namespace StreamingServicesAPI.Repositories
{
    public class GenreRepository: IGenreRepository
    {
        private readonly StreamingServiceDbContext streamingServiceDbContext;

        public GenreRepository(StreamingServiceDbContext streamingServiceDbContext)
        {
            this.streamingServiceDbContext = streamingServiceDbContext;
        }
        public async Task<Genre> CreateGenre(Genre genre)
        {
            await streamingServiceDbContext.Genre.AddAsync(genre);
            await streamingServiceDbContext.SaveChangesAsync();
            return genre;
        }

        public async Task<List<Genre>> GetAllGenre()
        {
            var genres = await streamingServiceDbContext.Genre.ToListAsync();
            return genres;

        }

        public async Task<Genre> GetGenre(int id)
        {
            var genre = await streamingServiceDbContext.Genre.FirstOrDefaultAsync(x => x.Id == id);
            return genre;
        }
    }
}
