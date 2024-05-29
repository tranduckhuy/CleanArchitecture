using Microsoft.EntityFrameworkCore;
using PackIT.Infrastructure.EFCore.Config;
using PackIT.Infrastructure.EFCore.Models;

namespace PackIT.Infrastructure.EFCore.Context
{
    internal sealed class ReadDbContext : DbContext
    {
        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        public DbSet<PackingListReadModel> PackingLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configuration = new ReadConfiguration();
            modelBuilder.ApplyConfiguration<PackingItemReadModel>(configuration);
            modelBuilder.ApplyConfiguration<PackingListReadModel>(configuration);
        }
    }
}
