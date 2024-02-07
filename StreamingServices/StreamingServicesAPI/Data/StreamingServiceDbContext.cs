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
        /*public DbSet<Period> Period { get; set; }
        
        public DbSet<Account> Account { get; set; }
        public DbSet<Streaming_service> Streaming_service { get; set; }
        public DbSet<Studio> Studio { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<Transaction> Transaction { get; set; }*/
    }
}
