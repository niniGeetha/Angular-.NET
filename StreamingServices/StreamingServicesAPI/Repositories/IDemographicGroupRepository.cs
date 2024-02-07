using StreamingServicesAPI.Models;

namespace StreamingServicesAPI.Repositories
{
    public interface IDemographicGroupRepository
    {
        Task<List<DemographicGroup>> GetDemographicGroups();
        Task<DemographicGroup> GetDemographicGroupById(int id);
        Task<DemographicGroup> CreateDemographicGroup(DemographicGroup demographicGroup);
        Task<DemographicGroup> UpdateDemographicGroup(DemographicGroup demographicGroup, int id);
        Task<DemographicGroup> DeleteDemographicGroup(int id);
        
    }
}
