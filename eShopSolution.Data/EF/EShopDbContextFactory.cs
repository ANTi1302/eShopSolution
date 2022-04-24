using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace eShopSolution.Data.EF
{
    class EShopDbContextFactory : IDesignTimeDbContextFactory<EshopConnectDB>
    {
        public EshopConnectDB CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<EshopConnectDB>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EshopConnectDB(optionsBuilder.Options);
        }
    }
}
