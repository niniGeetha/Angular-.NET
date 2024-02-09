using Microsoft.EntityFrameworkCore;
using StreamingServicesAPI.Data;
using StreamingServicesAPI.Models;

namespace StreamingServicesAPI.Repositories
{
    public class StreamingServiceRepository : IStreamingServiceRepository
    {
        private readonly StreamingServiceDbContext streamingServiceDbContext;

        public StreamingServiceRepository(StreamingServiceDbContext streamingServiceDbContext)
        {
            this.streamingServiceDbContext = streamingServiceDbContext;
        }
        public async Task<StreamingService> CreateStreamingService(StreamingService streamingService)
        {
            await streamingServiceDbContext.StreamingService.AddAsync(streamingService);
            await streamingServiceDbContext.SaveChangesAsync();
            return streamingService;
        }

        public async Task<StreamingService> DeleteStreamingService(int id)
        {
            var streamingServiceDB = await streamingServiceDbContext.StreamingService.FirstOrDefaultAsync(x => x.Id == id);
            if (streamingServiceDB == null)
                return null;

            streamingServiceDbContext.StreamingService.Remove(streamingServiceDB);
            await streamingServiceDbContext.SaveChangesAsync();
            return streamingServiceDB;
        }

        public async Task<StreamingService> GetStreamingServiceById(int id)
        {
            var streamingServiceDB = await streamingServiceDbContext.StreamingService.FirstOrDefaultAsync(x => x.Id == id);
            return streamingServiceDB;
        }

        public async Task<List<StreamingService>> GetStreamingServices()
        {
            var streamingServicesDB = await streamingServiceDbContext.StreamingService.ToListAsync();
            return streamingServicesDB;
        }

        public async Task<StreamingService> UpdateStreamingService(StreamingService streamingService, int id)
        {
            var streamingServiceDB = await streamingServiceDbContext.StreamingService.FirstOrDefaultAsync(x => x.Id == id);
            if (streamingServiceDB == null)
            {
                return null;

            }
            streamingServiceDB.ShortName = streamingService.ShortName;
            streamingServiceDB.LongName = streamingService.LongName;
            streamingServiceDB.SubscriptionPrice = streamingService.SubscriptionPrice;
            await streamingServiceDbContext.SaveChangesAsync();
            return streamingServiceDB;
        }
    }
}
