using DrsDemo.Domain.Countries;
using DrsDemo.Domain.Draws;
using DrsDemo.Domain.Groups;
using DrsDemo.Domain.Teams;
using Microsoft.EntityFrameworkCore;

namespace DrsDemo.Infrastructure.Context
{
    public class DrsDemoWriteDbContext : DbContext
    {
        public DrsDemoWriteDbContext(DbContextOptions<DrsDemoWriteDbContext> dbContextOptionsBuilder) :base(dbContextOptionsBuilder)
        {
                
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Draw> Draws { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureDrsDemo();
            base.OnModelCreating(modelBuilder);
        }
    }
}
