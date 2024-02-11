using Microsoft.AspNetCore.Mvc;
using StreamingServicesAPI.Models;

namespace StreamingServicesAPI.Repositories
{
    public interface IStreamingServiceRepository
    {
        Task<List<StreamingService>> GetStreamingServices();        
        Task<StreamingService> GetStreamingServiceById(int id);
        Task<StreamingService> CreateStreamingService(StreamingService streamingService);
        Task<StreamingService> UpdateStreamingService(StreamingService streamingService, int id);
        Task<StreamingService> DeleteStreamingService(int id);

    }
}
