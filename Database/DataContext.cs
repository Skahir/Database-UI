using Microsoft.EntityFrameworkCore;

namespace BlazorLearningApp.Database
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("Database"));
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
