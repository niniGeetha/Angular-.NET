using Microsoft.EntityFrameworkCore;
using StreamingServicesAPI.Data;
using StreamingServicesAPI.Models;
using System.Threading.Tasks;

namespace StreamingServicesAPI.Repositories
{
    public class DemographicGroupRepository : IDemographicGroupRepository
    {
        private readonly StreamingServiceDbContext streamingServiceDbContext;

        public DemographicGroupRepository(StreamingServiceDbContext streamingServiceDbContext)
        {
            this.streamingServiceDbContext = streamingServiceDbContext;
        }
        public async Task<DemographicGroup> CreateDemographicGroup(DemographicGroup demographicGroup)
        {
            await streamingServiceDbContext.DemographicGroup.AddAsync(demographicGroup);
            await streamingServiceDbContext.SaveChangesAsync();
            return demographicGroup;
        }

        public async Task<DemographicGroup> GetDemographicGroupById(int id)
        {
            var demographicGroup = await streamingServiceDbContext.DemographicGroup.FirstOrDefaultAsync(x=>x.Id == id);
            return demographicGroup;
        }

        public async Task<List<DemographicGroup>> GetDemographicGroups()
        {
            var demographicGroups = await streamingServiceDbContext.DemographicGroup.ToListAsync();
            return demographicGroups;           
        }

        public async Task<DemographicGroup> UpdateDemographicGroup( DemographicGroup demographicGroup, int id)
        {
            var demographicGroupDB = await streamingServiceDbContext.DemographicGroup.FirstOrDefaultAsync(x => x.Id == id);
            if (demographicGroupDB == null)
            {
                return null;              
                
            }
            demographicGroupDB.ShortName = demographicGroup.ShortName;
            demographicGroupDB.LongName = demographicGroup.LongName;
            demographicGroup.AccountNum = demographicGroup.AccountNum;
            await streamingServiceDbContext.SaveChangesAsync();
            return demographicGroupDB;
        }
        public async Task<DemographicGroup> DeleteDemographicGroup(int id)
        {
            var demographicGroupDB = await streamingServiceDbContext.DemographicGroup.FirstOrDefaultAsync(x => x.Id == id);
            if (demographicGroupDB == null)            
                return null;
            
            streamingServiceDbContext.DemographicGroup.Remove(demographicGroupDB);
            await streamingServiceDbContext.SaveChangesAsync();
            return demographicGroupDB;

        }
    }
}
