using StreamingServicesAPI.Models;

namespace StreamingServicesAPI.Repositories
{
    public interface IStudioRepository
    {
        Task<List<Studio>> GetStudios();
        Task<Studio> GetStudioById(int id);
        Task<Studio> CreateStudio(Studio studio);
        Task<Studio> UpdateStudio(Studio studio, int id);
        Task<Studio> DeleteStudio(int id);
    }
}
