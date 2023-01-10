using UserAddress.API.Data.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace UserAddress.API.Data.Infrastructure
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext()
        { 
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
        }
         
        protected override void OnModelCreating(ModelBuilder builder)
        { 
            builder.ApplyConfiguration(new AddressRecordConfiguration());  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string appSettingsPath = AppDomain.CurrentDomain.BaseDirectory + "\\appsettings.json";

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(appSettingsPath)
                .Build();

            dbContextOptionsBuilder.UseLazyLoadingProxies();

            var defaultConnection = config.GetConnectionString("DefaultConnection");
            dbContextOptionsBuilder.UseSqlite(defaultConnection); 
        }
    }
}
