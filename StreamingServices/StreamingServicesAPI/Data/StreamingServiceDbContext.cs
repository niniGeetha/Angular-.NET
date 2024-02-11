using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StreamingServicesAPI.Models;
using System;

namespace StreamingServicesAPI.Data
{
    public class StreamingServiceDbContext: DbContext
    {
        public StreamingServiceDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<DemographicGroup> DemographicGroup { get; set; }
        public DbSet<StreamingService> StreamingService { get; set; }
        public DbSet<Studio> Studio { get; set; }
        
    }
}
