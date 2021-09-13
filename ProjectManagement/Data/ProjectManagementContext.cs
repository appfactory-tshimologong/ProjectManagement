using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectManagement.Data.Entities;

namespace ProjectManagement.Data
{
    public class ProjectManagementContext :DbContext
    {
        private readonly IConfiguration _configuration;

        public ProjectManagementContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ProjectManagementAz"));
        }

        protected override void OnModelCreating(ModelBuilder bldr)
        {
            base.OnModelCreating(bldr);

            bldr.Entity<Employee>(e =>
            {
                e.OwnsOne(e => e.HomeAddress);
            });
        }

    }
}
