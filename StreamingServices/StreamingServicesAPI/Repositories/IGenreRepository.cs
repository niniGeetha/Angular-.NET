using StreamingServicesAPI.Models;

namespace StreamingServicesAPI.Repositories
{
    public interface IGenreRepository
    {
        Task<List<Genre>> GetAllGenre();
        Task<Genre> GetGenre(int id);
        Task<Genre> CreateGenre(Genre genre);
    }
}
