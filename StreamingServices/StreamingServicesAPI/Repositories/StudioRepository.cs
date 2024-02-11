using Microsoft.EntityFrameworkCore;
using StreamingServicesAPI.Data;
using StreamingServicesAPI.Models;

namespace StreamingServicesAPI.Repositories
{
    public class StudioRepository : IStudioRepository
    {
        private readonly StreamingServiceDbContext streamingServiceDbContext;

        public StudioRepository(StreamingServiceDbContext streamingServiceDbContext)
        {
            this.streamingServiceDbContext = streamingServiceDbContext;
        }
        public async Task<Studio> CreateStudio(Studio studio)
        {
            await streamingServiceDbContext.Studio.AddAsync(studio);
            await streamingServiceDbContext.SaveChangesAsync();
            return studio;
        }

        public async Task<Studio> DeleteStudio(int id)
        {
            var studioDB = await streamingServiceDbContext.Studio.FirstOrDefaultAsync(x => x.Id == id);
            if (studioDB == null)
                return null;

            streamingServiceDbContext.Studio.Remove(studioDB);
            await streamingServiceDbContext.SaveChangesAsync();
            return studioDB;
        }

        public async Task<Studio> GetStudioById(int id)
        {
            var studioDB = await streamingServiceDbContext.Studio.FirstOrDefaultAsync(x => x.Id == id);
            return studioDB;
        }

        public async Task<List<Studio>> GetStudios()
        {
            var studioDB = await streamingServiceDbContext.Studio.ToListAsync();
            return studioDB;
        }

        public async Task<Studio> UpdateStudio(Studio studio, int id)
        {
            var studioDB = await streamingServiceDbContext.Studio.FirstOrDefaultAsync(x => x.Id == id);
            if (studioDB == null)
            {
                return null;

            }
            studioDB.ShortName = studio.ShortName;
            studioDB.LongName = studio.LongName;            
            await streamingServiceDbContext.SaveChangesAsync();
            return studioDB;
        }
    }
}
