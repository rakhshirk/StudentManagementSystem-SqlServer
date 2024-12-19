using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace WebAppDatabase.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Build configuration to access appsettings.json
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                // Retrieve connection string from appsettings.json
                var connectionString = configuration.GetConnectionString("recorddb");

                // Configure the DbContext to use SQL Server
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}