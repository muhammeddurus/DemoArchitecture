using DrsDemo.Domain.Countries;
using DrsDemo.Domain.Draws;
using DrsDemo.Domain.Teams;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace DrsDemo.Infrastructure.Context
{
    public class DrsDemoReadDbContext : DbContext
    {
        public DrsDemoReadDbContext(DbContextOptions options) : base(options)
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
